namespace Biblioteca
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.buttonInserir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textTitulo = new System.Windows.Forms.TextBox();
            this.textNome = new System.Windows.Forms.TextBox();
            this.buttonImagem = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.textSobrenome = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pesquisarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonAnt = new System.Windows.Forms.Button();
            this.buttonProx = new System.Windows.Forms.Button();
            this.pictureBoxPesquisa = new System.Windows.Forms.PictureBox();
            this.labelAutor = new System.Windows.Forms.Label();
            this.labelAno = new System.Windows.Forms.Label();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.textAno = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textEditora = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBoxDisponibilidade = new System.Windows.Forms.PictureBox();
            this.buttonAlterarDisponibilidade = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPesquisa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDisponibilidade)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(186, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Título";
            // 
            // buttonInserir
            // 
            this.buttonInserir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonInserir.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInserir.Location = new System.Drawing.Point(354, 381);
            this.buttonInserir.Name = "buttonInserir";
            this.buttonInserir.Size = new System.Drawing.Size(75, 33);
            this.buttonInserir.TabIndex = 1;
            this.buttonInserir.Text = "INSERIR";
            this.buttonInserir.UseVisualStyleBackColor = true;
            this.buttonInserir.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ano";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Disponível",
            "Insdiponível"});
            this.comboBox1.Location = new System.Drawing.Point(274, 273);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(271, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Disponibilidade";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(45, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Autor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(111, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 21);
            this.label5.TabIndex = 6;
            this.label5.Text = "Gênero";
            // 
            // textTitulo
            // 
            this.textTitulo.Location = new System.Drawing.Point(115, 72);
            this.textTitulo.Name = "textTitulo";
            this.textTitulo.Size = new System.Drawing.Size(213, 20);
            this.textTitulo.TabIndex = 7;
            // 
            // textNome
            // 
            this.textNome.Location = new System.Drawing.Point(124, 175);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(120, 20);
            this.textNome.TabIndex = 9;
            this.textNome.Text = "Nome";
            // 
            // buttonImagem
            // 
            this.buttonImagem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonImagem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonImagem.Location = new System.Drawing.Point(544, 331);
            this.buttonImagem.Name = "buttonImagem";
            this.buttonImagem.Size = new System.Drawing.Size(137, 30);
            this.buttonImagem.TabIndex = 12;
            this.buttonImagem.Text = "Procurar imagem";
            this.buttonImagem.UseVisualStyleBackColor = true;
            this.buttonImagem.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(482, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(264, 260);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Ficção",
            "Não Ficção",
            "Fantasia",
            "Romance",
            "Aventura"});
            this.checkedListBox1.Location = new System.Drawing.Point(93, 273);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(95, 79);
            this.checkedListBox1.TabIndex = 15;
            // 
            // textSobrenome
            // 
            this.textSobrenome.Location = new System.Drawing.Point(275, 175);
            this.textSobrenome.Name = "textSobrenome";
            this.textSobrenome.Size = new System.Drawing.Size(120, 20);
            this.textSobrenome.TabIndex = 17;
            this.textSobrenome.Text = "Sobrenome";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarToolStripMenuItem,
            this.pesquisarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrarToolStripMenuItem
            // 
            this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.cadastrarToolStripMenuItem.Text = "Cadastrar";
            this.cadastrarToolStripMenuItem.Click += new System.EventHandler(this.cadastrarToolStripMenuItem_Click);
            // 
            // pesquisarToolStripMenuItem
            // 
            this.pesquisarToolStripMenuItem.Name = "pesquisarToolStripMenuItem";
            this.pesquisarToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.pesquisarToolStripMenuItem.Text = "Pesquisar";
            this.pesquisarToolStripMenuItem.Click += new System.EventHandler(this.pesquisarToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonAlterarDisponibilidade);
            this.panel1.Controls.Add(this.pictureBoxDisponibilidade);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.buttonAnt);
            this.panel1.Controls.Add(this.buttonProx);
            this.panel1.Controls.Add(this.pictureBoxPesquisa);
            this.panel1.Controls.Add(this.labelAutor);
            this.panel1.Controls.Add(this.labelAno);
            this.panel1.Controls.Add(this.labelTitulo);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 426);
            this.panel1.TabIndex = 19;
            // 
            // buttonAnt
            // 
            this.buttonAnt.Location = new System.Drawing.Point(41, 127);
            this.buttonAnt.Name = "buttonAnt";
            this.buttonAnt.Size = new System.Drawing.Size(75, 23);
            this.buttonAnt.TabIndex = 6;
            this.buttonAnt.Text = "Anterior";
            this.buttonAnt.UseVisualStyleBackColor = true;
            this.buttonAnt.Click += new System.EventHandler(this.buttonAnt_Click);
            // 
            // buttonProx
            // 
            this.buttonProx.Location = new System.Drawing.Point(647, 127);
            this.buttonProx.Name = "buttonProx";
            this.buttonProx.Size = new System.Drawing.Size(75, 23);
            this.buttonProx.TabIndex = 5;
            this.buttonProx.Text = "Próximo";
            this.buttonProx.UseVisualStyleBackColor = true;
            this.buttonProx.Click += new System.EventHandler(this.buttonProx_Click);
            // 
            // pictureBoxPesquisa
            // 
            this.pictureBoxPesquisa.Location = new System.Drawing.Point(241, 24);
            this.pictureBoxPesquisa.Name = "pictureBoxPesquisa";
            this.pictureBoxPesquisa.Size = new System.Drawing.Size(281, 243);
            this.pictureBoxPesquisa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPesquisa.TabIndex = 4;
            this.pictureBoxPesquisa.TabStop = false;
            // 
            // labelAutor
            // 
            this.labelAutor.AutoSize = true;
            this.labelAutor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAutor.Location = new System.Drawing.Point(322, 357);
            this.labelAutor.MinimumSize = new System.Drawing.Size(200, 0);
            this.labelAutor.Name = "labelAutor";
            this.labelAutor.Size = new System.Drawing.Size(200, 21);
            this.labelAutor.TabIndex = 2;
            this.labelAutor.Text = "Autor";
            // 
            // labelAno
            // 
            this.labelAno.AutoSize = true;
            this.labelAno.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAno.Location = new System.Drawing.Point(322, 311);
            this.labelAno.MinimumSize = new System.Drawing.Size(200, 0);
            this.labelAno.Name = "labelAno";
            this.labelAno.Size = new System.Drawing.Size(200, 21);
            this.labelAno.TabIndex = 1;
            this.labelAno.Text = "Ano";
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(322, 270);
            this.labelTitulo.MinimumSize = new System.Drawing.Size(200, 0);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(200, 21);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "Título";
            // 
            // textAno
            // 
            this.textAno.Location = new System.Drawing.Point(93, 120);
            this.textAno.Name = "textAno";
            this.textAno.Size = new System.Drawing.Size(79, 20);
            this.textAno.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(252, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 21);
            this.label6.TabIndex = 20;
            this.label6.Text = "Editora";
            // 
            // textEditora
            // 
            this.textEditora.Location = new System.Drawing.Point(317, 118);
            this.textEditora.Name = "textEditora";
            this.textEditora.Size = new System.Drawing.Size(142, 20);
            this.textEditora.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(237, 270);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 21);
            this.label7.TabIndex = 7;
            this.label7.Text = "Título:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(237, 311);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 21);
            this.label8.TabIndex = 8;
            this.label8.Text = "Ano:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(237, 357);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 21);
            this.label9.TabIndex = 9;
            this.label9.Text = "Autor:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(643, 285);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 21);
            this.label10.TabIndex = 10;
            this.label10.Text = "Disponibilidade";
            // 
            // pictureBoxDisponibilidade
            // 
            this.pictureBoxDisponibilidade.Location = new System.Drawing.Point(677, 323);
            this.pictureBoxDisponibilidade.Name = "pictureBoxDisponibilidade";
            this.pictureBoxDisponibilidade.Size = new System.Drawing.Size(45, 41);
            this.pictureBoxDisponibilidade.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDisponibilidade.TabIndex = 11;
            this.pictureBoxDisponibilidade.TabStop = false;
            // 
            // buttonAlterarDisponibilidade
            // 
            this.buttonAlterarDisponibilidade.Location = new System.Drawing.Point(661, 370);
            this.buttonAlterarDisponibilidade.Name = "buttonAlterarDisponibilidade";
            this.buttonAlterarDisponibilidade.Size = new System.Drawing.Size(75, 23);
            this.buttonAlterarDisponibilidade.TabIndex = 12;
            this.buttonAlterarDisponibilidade.Text = "Alterar";
            this.buttonAlterarDisponibilidade.UseVisualStyleBackColor = true;
            this.buttonAlterarDisponibilidade.Click += new System.EventHandler(this.buttonAlterarDisponibilidade_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textSobrenome);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonImagem);
            this.Controls.Add(this.textNome);
            this.Controls.Add(this.textTitulo);
            this.Controls.Add(this.textAno);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonInserir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.textEditora);
            this.Controls.Add(this.label6);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPesquisa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDisponibilidade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonInserir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textAno;
        private System.Windows.Forms.TextBox textTitulo;
        private System.Windows.Forms.TextBox textNome;
        private System.Windows.Forms.Button buttonImagem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.TextBox textSobrenome;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pesquisarToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textEditora;
        private System.Windows.Forms.PictureBox pictureBoxPesquisa;
        private System.Windows.Forms.Label labelAutor;
        private System.Windows.Forms.Label labelAno;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Button buttonAnt;
        private System.Windows.Forms.Button buttonProx;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBoxDisponibilidade;
        private System.Windows.Forms.Button buttonAlterarDisponibilidade;
    }
}

