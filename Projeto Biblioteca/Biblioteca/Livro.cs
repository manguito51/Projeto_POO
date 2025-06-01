using System;
using System.Collections.Generic;

namespace Biblioteca
{
    public class Livro
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public int AnoPublicacao { get; set; }
        public string Editora { get; set; }
        public byte[] Imagem { get; set; }
        public bool Disponibilidade { get; set; }
        public DateTime? DataEmprestimo { get; set; }
        public DateTime? DataDevolucao { get; set; }
        public Autor Autor { get; set; }
        public List<Genero> Generos { get; set; }
    }
}
