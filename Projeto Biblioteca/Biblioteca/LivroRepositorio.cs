using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace Biblioteca
{
    public class LivroRepositorio
    {
        private readonly string connectionString = "Server=localhost;Database=Biblioteca;Uid=root;Pwd=;";

        public LivroRepositorio()
        {
            CriarBancoETabelas();
        }

        private void CriarBancoETabelas()
        {
            using (var conexao = new MySqlConnection("Server=localhost;Uid=root;Pwd=;"))
            {
                conexao.Open();
                using (var cmd = new MySqlCommand("CREATE DATABASE IF NOT EXISTS Biblioteca", conexao))
                    cmd.ExecuteNonQuery();
            }

            using (var conexao = new MySqlConnection(connectionString))
            {
                conexao.Open();
                List<string> comandos = new List<string>
                {
                    "CREATE TABLE IF NOT EXISTS autor (" +
                        "Id INT AUTO_INCREMENT PRIMARY KEY, " +
                        "Nome VARCHAR(50), " +
                        "Sobrenome VARCHAR(50))",

                    "CREATE TABLE IF NOT EXISTS genero (" +
                        "Id INT AUTO_INCREMENT PRIMARY KEY, " +
                        "Nome VARCHAR(50))",

                    "CREATE TABLE IF NOT EXISTS livro (" +
                        "Id INT AUTO_INCREMENT PRIMARY KEY, " +
                        "Titulo VARCHAR(100), " +
                        "AnoPublicacao INT, " +
                        "Editora VARCHAR(100), " +
                        "Imagem LONGBLOB, " +
                        "Disponibilidade BOOLEAN, " +
                        "DataEmprestimo DATE, " +
                        "DataDevolucao DATE, " +
                        "AutorId INT, " +
                        "FOREIGN KEY (AutorId) REFERENCES autor(Id))",

                    "CREATE TABLE IF NOT EXISTS livro_genero (" +
                        "LivroId INT, " +
                        "GeneroId INT, " +
                        "PRIMARY KEY (LivroId, GeneroId), " +
                        "FOREIGN KEY (LivroId) REFERENCES livro(Id), " +
                        "FOREIGN KEY (GeneroId) REFERENCES genero(Id))"
                };

                foreach (var sql in comandos)
                {
                    using (var cmd = new MySqlCommand(sql, conexao))
                        cmd.ExecuteNonQuery();
                }
            }
        }

        public int InserirAutor(Autor autor)
        {
            using (var conexao = new MySqlConnection(connectionString))
            {
                conexao.Open();
                string consulta = "SELECT Id FROM autor WHERE Nome = @Nome AND Sobrenome = @Sobrenome";
                using (var cmd = new MySqlCommand(consulta, conexao))
                {
                    cmd.Parameters.AddWithValue("@Nome", autor.Nome);
                    cmd.Parameters.AddWithValue("@Sobrenome", autor.Sobrenome);
                    object resultado = cmd.ExecuteScalar();
                    if (resultado != null) return Convert.ToInt32(resultado);
                }

                string insert = "INSERT INTO autor (Nome, Sobrenome) VALUES (@Nome, @Sobrenome); SELECT LAST_INSERT_ID();";
                using (var cmd = new MySqlCommand(insert, conexao))
                {
                    cmd.Parameters.AddWithValue("@Nome", autor.Nome);
                    cmd.Parameters.AddWithValue("@Sobrenome", autor.Sobrenome);
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }

        public int InserirGenero(Genero genero)
        {
            using (var conexao = new MySqlConnection(connectionString))
            {
                conexao.Open();
                string consulta = "SELECT Id FROM genero WHERE Nome = @Nome";
                using (var cmd = new MySqlCommand(consulta, conexao))
                {
                    cmd.Parameters.AddWithValue("@Nome", genero.Nome);
                    object resultado = cmd.ExecuteScalar();
                    if (resultado != null) return Convert.ToInt32(resultado);
                }

                string insert = "INSERT INTO genero (Nome) VALUES (@Nome); SELECT LAST_INSERT_ID();";
                using (var cmd = new MySqlCommand(insert, conexao))
                {
                    cmd.Parameters.AddWithValue("@Nome", genero.Nome);
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }

        public void InserirLivro(Livro livro)
        {
            using (var conexao = new MySqlConnection(connectionString))
            {
                conexao.Open();
                using (var transacao = conexao.BeginTransaction())
                {
                    int autorId = InserirAutor(livro.Autor);

                    string sql = @"INSERT INTO livro (Titulo, AnoPublicacao, Editora, Imagem, Disponibilidade, DataEmprestimo, DataDevolucao, AutorId) 
                                    VALUES (@Titulo, @Ano, @Editora, @Imagem, @Disp, @Emp, @Dev, @AutorId); SELECT LAST_INSERT_ID();";
                    int livroId;
                    using (var cmd = new MySqlCommand(sql, conexao, transacao))
                    {
                        cmd.Parameters.AddWithValue("@Titulo", livro.Titulo);
                        cmd.Parameters.AddWithValue("@Ano", livro.AnoPublicacao);
                        cmd.Parameters.AddWithValue("@Editora", livro.Editora);
                        cmd.Parameters.AddWithValue("@Imagem", livro.Imagem);
                        cmd.Parameters.AddWithValue("@Disp", livro.Disponibilidade);
                        cmd.Parameters.AddWithValue("@Emp", livro.DataEmprestimo);
                        cmd.Parameters.AddWithValue("@Dev", livro.DataDevolucao);
                        cmd.Parameters.AddWithValue("@AutorId", autorId);
                        livroId = Convert.ToInt32(cmd.ExecuteScalar());
                    }

                    foreach (var genero in livro.Generos)
                    {
                        int generoId = InserirGenero(genero);
                        string relacao = "INSERT INTO livro_genero (LivroId, GeneroId) VALUES (@LivroId, @GeneroId)";
                        using (var cmd = new MySqlCommand(relacao, conexao, transacao))
                        {
                            cmd.Parameters.AddWithValue("@LivroId", livroId);
                            cmd.Parameters.AddWithValue("@GeneroId", generoId);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    transacao.Commit();
                }
            }
        }

        public List<Livro> ObterLivros()
        {
            var livros = new List<Livro>();
            using (var conexao = new MySqlConnection(connectionString))
            {
                conexao.Open();
                string sql = @"SELECT l.Id, l.Titulo, l.AnoPublicacao, l.Editora, l.Imagem, l.Disponibilidade, 
                                      l.DataEmprestimo, l.DataDevolucao, a.Id AS AutorId, a.Nome AS AutorNome, a.Sobrenome AS AutorSobrenome
                               FROM livro l
                               JOIN autor a ON l.AutorId = a.Id";
                using (var cmd = new MySqlCommand(sql, conexao))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var livro = new Livro
                        {
                            Id = reader.GetInt32("Id"),
                            Titulo = reader.GetString("Titulo"),
                            AnoPublicacao = reader.GetInt32("AnoPublicacao"),
                            Editora = reader.GetString("Editora"),
                            Imagem = reader.IsDBNull(reader.GetOrdinal("Imagem")) ? null : (byte[])reader["Imagem"],
                            Disponibilidade = reader.GetBoolean("Disponibilidade"),
                            DataEmprestimo = reader.IsDBNull(reader.GetOrdinal("DataEmprestimo")) ? (DateTime?)null : reader.GetDateTime("DataEmprestimo"),
                            DataDevolucao = reader.IsDBNull(reader.GetOrdinal("DataDevolucao")) ? (DateTime?)null : reader.GetDateTime("DataDevolucao"),
                            Autor = new Autor
                            {
                                Id = reader.GetInt32("AutorId"),
                                Nome = reader.GetString("AutorNome"),
                                Sobrenome = reader.GetString("AutorSobrenome")
                            },
                            Generos = new List<Genero>()
                        };
                        livros.Add(livro);
                    }
                }
                foreach (var livro in livros)
                {
                    string generoSql = "SELECT g.Id, g.Nome FROM genero g " +
                                       "JOIN livro_genero lg ON g.Id = lg.GeneroId " +
                                       "WHERE lg.LivroId = @LivroId";
                    using (var cmdGenero = new MySqlCommand(generoSql, conexao))
                    {
                        cmdGenero.Parameters.AddWithValue("@LivroId", livro.Id);
                        using (var readerGenero = cmdGenero.ExecuteReader())
                        {
                            while (readerGenero.Read())
                            {
                                var genero = new Genero
                                {
                                    Id = readerGenero.GetInt32("Id"),
                                    Nome = readerGenero.GetString("Nome")
                                };
                                livro.Generos.Add(genero);
                            }
                        }
                    }
                }
            }
            return livros;
        }
    }
}