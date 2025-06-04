using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Biblioteca
{
    public partial class Form1 : Form
    {
        // Variável do banco de dados
        private LivroRepositorio bancoDados = new LivroRepositorio();
        // Váriavel para converter imagem escolhida em byte, para a inserção no banco
        private byte[] imagemBytes;
        List<Livro> livrosTable = new List<Livro>();
        private int livroAtualIndex = 0;
        public Form1()
        {
            InitializeComponent();
            cadastrarToolStripMenuItem.BackColor = ColorTranslator.FromHtml("#FFCC00");
            panel1.Visible = false;
            livrosTable = bancoDados.ObterLivros();
        }

        // Função para limpar os campos da aba cadastrar
        private void LimparCampos()
        {
            textTitulo.Clear();
            textAno.Clear();
            textNome.Clear();
            textSobrenome.Clear();
            textEditora.Clear();
            comboBox1.SelectedIndex = -1;
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, false);
            }
            pictureBox1.Image = null;
        }

        // Função do botão para inserir os dados no banco
        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dataRetirada = DateTime.Now;
            DateTime dataDevolucao = dataRetirada.AddDays(7);

            // 1. Inserir autor
            Autor autor = new Autor
            {
                Nome = textNome.Text.Trim(),
                Sobrenome = textSobrenome.Text.Trim()
            };

            // 2. Inserir gêneros e obter os ids
            List<Genero> idsGenero = new List<Genero>();
            foreach (var item in checkedListBox1.CheckedItems)
            {
                string genero = item.ToString();
                idsGenero.Add(new Genero { Nome = genero });
            }

            // 3. Inserir livro
            Livro livro = new Livro
            {
                Titulo = textTitulo.Text.Trim(),
                AnoPublicacao = int.Parse(textAno.Text.Trim()),
                Editora = textEditora.Text.Trim(),
                Imagem = imagemBytes,
                Disponibilidade = comboBox1.SelectedText == "Disponível",
                DataEmprestimo = dataRetirada,
                DataDevolucao = dataDevolucao,
                Autor = autor,
                Generos = idsGenero
            };

            bancoDados.InserirLivro(livro);

            LimparCampos();
        }

        // Função do botão para escolher imagem em máquina
        private void button2_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Selecionar Imagem";
                openFileDialog.Filter = "Imagens (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp";
                openFileDialog.Multiselect = false;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;

                    imagemBytes = System.IO.File.ReadAllBytes(filePath);

                    pictureBox1.Image = Image.FromFile(filePath);
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
        }

        // Função do botão (Cadastrar) para mudar para panel do cadastro
        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pesquisarToolStripMenuItem.BackColor = SystemColors.Control;
            cadastrarToolStripMenuItem.BackColor = ColorTranslator.FromHtml("#FFCC00");
            panel1.Visible = false;
        }

        // Função do botão (Pesquisar) para mudar para o panel da pesquisa
        private void pesquisarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cadastrarToolStripMenuItem.BackColor = SystemColors.Control;
            pesquisarToolStripMenuItem.BackColor = ColorTranslator.FromHtml("#FFCC00");
            panel1.Visible = true;

            livrosTable = bancoDados.ObterLivros();
            livroAtualIndex = 0;
            ExibirLivroAtual();
        }

        // Função para receber os dados do livro atual do banco de dados
        private void ExibirLivroAtual()
        {
            if (livrosTable == null || livrosTable.Count == 0)
            {
                labelTitulo.Text = "Nenhum livro cadastrado";
                labelAno.Text = "";
                labelAutor.Text = "";
                pictureBoxDisponibilidade.Image = null;
                pictureBoxPesquisa.Image = null;
                return;
            }

            var livro = livrosTable[livroAtualIndex];
            labelTitulo.Text = livro.Titulo;
            labelAno.Text = livro.AnoPublicacao.ToString();
            if (livro.Autor != null)
                labelAutor.Text = livro.Autor.Nome + " " + livro.Autor.Sobrenome;
            else
                labelAutor.Text = "";

            // Exibir imagem armazenada em byte[] no banco de dados
            if (livro.Imagem != null && livro.Imagem.Length > 0)
            {
                using (var ms = new System.IO.MemoryStream(livro.Imagem))
                {
                    pictureBoxPesquisa.Image = Image.FromStream(ms);
                }
            }
            else
            {
                pictureBoxPesquisa.Image = null;
            }

            string imagemDisponivel = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Sources", "Images", "disponivel.png");
            string imagemIndisponivel = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Sources", "Images", "indisponivel.png");

            if (livro.Disponibilidade && System.IO.File.Exists(imagemDisponivel))
                pictureBoxDisponibilidade.Image = Image.FromFile(imagemDisponivel);

            else if (!livro.Disponibilidade && System.IO.File.Exists(imagemIndisponivel))
                pictureBoxDisponibilidade.Image = Image.FromFile(imagemIndisponivel);

            else
                pictureBoxDisponibilidade.Image = null;
        }

        // Função do botão "próximo" na aba de pesquisa, seleciona o próximo livro na livrosTable
        private void buttonProx_Click(object sender, EventArgs e)
        {
            if (livrosTable == null || livrosTable.Count == 0) return;
            if (livroAtualIndex < livrosTable.Count - 1) livroAtualIndex++;
            ExibirLivroAtual();
        }

        // Função do botão "anterior" na aba de pesquisa, seleciona o livro anterior na livrosTable
        private void buttonAnt_Click(object sender, EventArgs e)
        {
            if (livrosTable == null || livrosTable.Count == 0) return;
            if (livroAtualIndex > 0) livroAtualIndex--;
            ExibirLivroAtual();
        }

        // Função de alterar as disponibilidade do livro no banco
        private void buttonAlterarDisponibilidade_Click(object sender, EventArgs e)
        {
            if (livrosTable == null || livrosTable.Count == 0) return;
            var livroAtual = livrosTable[livroAtualIndex];
            livroAtual.Disponibilidade = !livroAtual.Disponibilidade;
            bancoDados.AtualizarLivro(livroAtual);
            ExibirLivroAtual();
        }
    }
}
