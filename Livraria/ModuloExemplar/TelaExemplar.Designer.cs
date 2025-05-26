namespace Trabalho_Forms
{
    partial class TelaExemplar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btnSalvar = new Button();
            panel2 = new Panel();
            generoExemplar = new ComboBox();
            anoPublicacao = new NumericUpDown();
            statusExemplar = new ComboBox();
            txtEditora = new TextBox();
            txtEscritor = new TextBox();
            txtSubTitulo = new TextBox();
            txtTitulo = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel3 = new Panel();
            controlador = new TabControl();
            Livro = new TabPage();
            painalEbook = new Panel();
            ebookUrl = new TextBox();
            label19 = new Label();
            ebookTamanho = new NumericUpDown();
            label18 = new Label();
            ebookFormato = new ComboBox();
            label17 = new Label();
            checkEBook = new CheckBox();
            livroISBN = new TextBox();
            label11 = new Label();
            label10 = new Label();
            livroTipoCapa = new ComboBox();
            livroPaginas = new NumericUpDown();
            label9 = new Label();
            Revista = new TabPage();
            label13 = new Label();
            revistaPaginas = new NumericUpDown();
            label12 = new Label();
            revistaEdicao = new NumericUpDown();
            HQ = new TabPage();
            hqIlustrador = new TextBox();
            label15 = new Label();
            label14 = new Label();
            hqEdicao = new NumericUpDown();
            Generico = new TabPage();
            genericoTipo = new ListBox();
            label16 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)anoPublicacao).BeginInit();
            panel3.SuspendLayout();
            controlador.SuspendLayout();
            Livro.SuspendLayout();
            painalEbook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ebookTamanho).BeginInit();
            ((System.ComponentModel.ISupportInitialize)livroPaginas).BeginInit();
            Revista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)revistaPaginas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)revistaEdicao).BeginInit();
            HQ.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)hqEdicao).BeginInit();
            Generico.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnSalvar);
            panel1.Location = new Point(10, 317);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(679, 29);
            panel1.TabIndex = 0;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = SystemColors.GradientInactiveCaption;
            btnSalvar.DialogResult = DialogResult.OK;
            btnSalvar.Location = new Point(3, 2);
            btnSalvar.Margin = new Padding(3, 2, 3, 2);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(674, 25);
            btnSalvar.TabIndex = 0;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(generoExemplar);
            panel2.Controls.Add(anoPublicacao);
            panel2.Controls.Add(statusExemplar);
            panel2.Controls.Add(txtEditora);
            panel2.Controls.Add(txtEscritor);
            panel2.Controls.Add(txtSubTitulo);
            panel2.Controls.Add(txtTitulo);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(10, 9);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(336, 304);
            panel2.TabIndex = 1;
            // 
            // generoExemplar
            // 
            generoExemplar.DropDownStyle = ComboBoxStyle.DropDownList;
            generoExemplar.FormattingEnabled = true;
            generoExemplar.Items.AddRange(new object[] { "Romance", "Novela", "Conto", "Crônica", "Poema", "Canção", "Drama histórico", "Teatro de vanguarda" });
            generoExemplar.Location = new Point(3, 206);
            generoExemplar.Margin = new Padding(3, 2, 3, 2);
            generoExemplar.Name = "generoExemplar";
            generoExemplar.Size = new Size(192, 23);
            generoExemplar.TabIndex = 18;
            // 
            // anoPublicacao
            // 
            anoPublicacao.Location = new Point(3, 170);
            anoPublicacao.Margin = new Padding(3, 2, 3, 2);
            anoPublicacao.Maximum = new decimal(new int[] { 2026, 0, 0, 0 });
            anoPublicacao.Name = "anoPublicacao";
            anoPublicacao.Size = new Size(144, 23);
            anoPublicacao.TabIndex = 17;
            anoPublicacao.Value = new decimal(new int[] { 2025, 0, 0, 0 });
            // 
            // statusExemplar
            // 
            statusExemplar.DropDownStyle = ComboBoxStyle.DropDownList;
            statusExemplar.FormattingEnabled = true;
            statusExemplar.Items.AddRange(new object[] { "Pendente", "Lido", "Emprestado", "Devolvido", "Perdido" });
            statusExemplar.Location = new Point(3, 244);
            statusExemplar.Margin = new Padding(3, 2, 3, 2);
            statusExemplar.Name = "statusExemplar";
            statusExemplar.Size = new Size(192, 23);
            statusExemplar.TabIndex = 16;
            // 
            // txtEditora
            // 
            txtEditora.Location = new Point(3, 131);
            txtEditora.Margin = new Padding(3, 2, 3, 2);
            txtEditora.Name = "txtEditora";
            txtEditora.Size = new Size(286, 23);
            txtEditora.TabIndex = 14;
            // 
            // txtEscritor
            // 
            txtEscritor.Location = new Point(3, 93);
            txtEscritor.Margin = new Padding(3, 2, 3, 2);
            txtEscritor.Name = "txtEscritor";
            txtEscritor.Size = new Size(286, 23);
            txtEscritor.TabIndex = 13;
            // 
            // txtSubTitulo
            // 
            txtSubTitulo.Location = new Point(3, 56);
            txtSubTitulo.Margin = new Padding(3, 2, 3, 2);
            txtSubTitulo.Name = "txtSubTitulo";
            txtSubTitulo.Size = new Size(286, 23);
            txtSubTitulo.TabIndex = 12;
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(3, 18);
            txtTitulo.Margin = new Padding(3, 2, 3, 2);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(286, 23);
            txtTitulo.TabIndex = 11;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(3, 229);
            label8.Name = "label8";
            label8.Size = new Size(39, 15);
            label8.TabIndex = 10;
            label8.Text = "Status";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(3, 193);
            label7.Name = "label7";
            label7.Size = new Size(45, 15);
            label7.TabIndex = 9;
            label7.Text = "Genero";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 154);
            label6.Name = "label6";
            label6.Size = new Size(90, 15);
            label6.TabIndex = 8;
            label6.Text = "Ano Publicacao";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 116);
            label5.Name = "label5";
            label5.Size = new Size(44, 15);
            label5.TabIndex = 7;
            label5.Text = "Editora";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 79);
            label4.Name = "label4";
            label4.Size = new Size(46, 15);
            label4.TabIndex = 6;
            label4.Text = "Escritor";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 40);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 5;
            label3.Text = "SubTitulo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 5);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 4;
            label2.Text = "Titulo";
            // 
            // panel3
            // 
            panel3.Controls.Add(controlador);
            panel3.Location = new Point(352, 9);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(338, 304);
            panel3.TabIndex = 2;
            // 
            // controlador
            // 
            controlador.Controls.Add(Livro);
            controlador.Controls.Add(Revista);
            controlador.Controls.Add(HQ);
            controlador.Controls.Add(Generico);
            controlador.Location = new Point(3, 5);
            controlador.Margin = new Padding(3, 2, 3, 2);
            controlador.Name = "controlador";
            controlador.SelectedIndex = 0;
            controlador.Size = new Size(332, 296);
            controlador.TabIndex = 0;
            // 
            // Livro
            // 
            Livro.Controls.Add(painalEbook);
            Livro.Controls.Add(checkEBook);
            Livro.Controls.Add(livroISBN);
            Livro.Controls.Add(label11);
            Livro.Controls.Add(label10);
            Livro.Controls.Add(livroTipoCapa);
            Livro.Controls.Add(livroPaginas);
            Livro.Controls.Add(label9);
            Livro.Location = new Point(4, 24);
            Livro.Margin = new Padding(3, 2, 3, 2);
            Livro.Name = "Livro";
            Livro.Padding = new Padding(3, 2, 3, 2);
            Livro.Size = new Size(324, 268);
            Livro.TabIndex = 0;
            Livro.Text = "Livro";
            Livro.UseVisualStyleBackColor = true;
            // 
            // painalEbook
            // 
            painalEbook.CausesValidation = false;
            painalEbook.Controls.Add(ebookUrl);
            painalEbook.Controls.Add(label19);
            painalEbook.Controls.Add(ebookTamanho);
            painalEbook.Controls.Add(label18);
            painalEbook.Controls.Add(ebookFormato);
            painalEbook.Controls.Add(label17);
            painalEbook.Location = new Point(5, 143);
            painalEbook.Margin = new Padding(3, 2, 3, 2);
            painalEbook.Name = "painalEbook";
            painalEbook.Size = new Size(315, 124);
            painalEbook.TabIndex = 21;
            // 
            // ebookUrl
            // 
            ebookUrl.Location = new Point(3, 107);
            ebookUrl.Margin = new Padding(3, 2, 3, 2);
            ebookUrl.Name = "ebookUrl";
            ebookUrl.Size = new Size(310, 23);
            ebookUrl.TabIndex = 19;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(3, 86);
            label19.Name = "label19";
            label19.Size = new Size(28, 15);
            label19.TabIndex = 20;
            label19.Text = "URL";
            // 
            // ebookTamanho
            // 
            ebookTamanho.Location = new Point(3, 59);
            ebookTamanho.Margin = new Padding(3, 2, 3, 2);
            ebookTamanho.Maximum = new decimal(new int[] { 2026, 0, 0, 0 });
            ebookTamanho.Name = "ebookTamanho";
            ebookTamanho.Size = new Size(144, 23);
            ebookTamanho.TabIndex = 19;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(3, 44);
            label18.Name = "label18";
            label18.Size = new Size(56, 15);
            label18.TabIndex = 18;
            label18.Text = "Tamanho";
            // 
            // ebookFormato
            // 
            ebookFormato.DropDownStyle = ComboBoxStyle.DropDownList;
            ebookFormato.FormattingEnabled = true;
            ebookFormato.Items.AddRange(new object[] { "Portable Document Format (PDF)", "Electronic Publication (ePUB)", "Mobipocket (MOBI)", "Kindle Package Format (KPF)", "Outros" });
            ebookFormato.Location = new Point(3, 22);
            ebookFormato.Margin = new Padding(3, 2, 3, 2);
            ebookFormato.Name = "ebookFormato";
            ebookFormato.Size = new Size(310, 23);
            ebookFormato.TabIndex = 6;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(3, 6);
            label17.Name = "label17";
            label17.Size = new Size(52, 15);
            label17.TabIndex = 5;
            label17.Text = "Formato";
            // 
            // checkEBook
            // 
            checkEBook.AutoSize = true;
            checkEBook.Location = new Point(5, 124);
            checkEBook.Margin = new Padding(3, 2, 3, 2);
            checkEBook.Name = "checkEBook";
            checkEBook.Size = new Size(59, 19);
            checkEBook.TabIndex = 20;
            checkEBook.Text = "EBook";
            checkEBook.UseVisualStyleBackColor = true;
            checkEBook.CheckedChanged += TelaExemplar_Load;
            // 
            // livroISBN
            // 
            livroISBN.Location = new Point(5, 100);
            livroISBN.Margin = new Padding(3, 2, 3, 2);
            livroISBN.Name = "livroISBN";
            livroISBN.Size = new Size(286, 23);
            livroISBN.TabIndex = 19;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(5, 82);
            label11.Name = "label11";
            label11.Size = new Size(32, 15);
            label11.TabIndex = 4;
            label11.Text = "ISBN";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(5, 42);
            label10.Name = "label10";
            label10.Size = new Size(74, 15);
            label10.TabIndex = 3;
            label10.Text = "Tipo de capa";
            // 
            // livroTipoCapa
            // 
            livroTipoCapa.DropDownStyle = ComboBoxStyle.DropDownList;
            livroTipoCapa.FormattingEnabled = true;
            livroTipoCapa.Items.AddRange(new object[] { "Capa Dura", "Capa Flexível ou Brochura", "Capa de Papel Cartão", "Capa com Sobrecapa (Jacket) • Capa com Relevo", "Capa com Verniz UV", "Capa Metalizada", "Capa de Tecido", "Capa com Janela", "Capa Transparente", "Capa Digital" });
            livroTipoCapa.Location = new Point(5, 59);
            livroTipoCapa.Margin = new Padding(3, 2, 3, 2);
            livroTipoCapa.Name = "livroTipoCapa";
            livroTipoCapa.Size = new Size(133, 23);
            livroTipoCapa.TabIndex = 2;
            // 
            // livroPaginas
            // 
            livroPaginas.Location = new Point(5, 20);
            livroPaginas.Margin = new Padding(3, 2, 3, 2);
            livroPaginas.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            livroPaginas.Name = "livroPaginas";
            livroPaginas.Size = new Size(131, 23);
            livroPaginas.TabIndex = 1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(5, 2);
            label9.Name = "label9";
            label9.Size = new Size(48, 15);
            label9.TabIndex = 0;
            label9.Text = "Paginas";
            // 
            // Revista
            // 
            Revista.Controls.Add(label13);
            Revista.Controls.Add(revistaPaginas);
            Revista.Controls.Add(label12);
            Revista.Controls.Add(revistaEdicao);
            Revista.Location = new Point(4, 24);
            Revista.Margin = new Padding(3, 2, 3, 2);
            Revista.Name = "Revista";
            Revista.Padding = new Padding(3, 2, 3, 2);
            Revista.Size = new Size(324, 268);
            Revista.TabIndex = 1;
            Revista.Text = "Revista";
            Revista.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(5, 68);
            label13.Name = "label13";
            label13.Size = new Size(48, 15);
            label13.TabIndex = 21;
            label13.Text = "Paginas";
            // 
            // revistaPaginas
            // 
            revistaPaginas.Location = new Point(5, 83);
            revistaPaginas.Margin = new Padding(3, 2, 3, 2);
            revistaPaginas.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            revistaPaginas.Name = "revistaPaginas";
            revistaPaginas.Size = new Size(131, 23);
            revistaPaginas.TabIndex = 20;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(5, 14);
            label12.Name = "label12";
            label12.Size = new Size(42, 15);
            label12.TabIndex = 19;
            label12.Text = "Edicao";
            // 
            // revistaEdicao
            // 
            revistaEdicao.Location = new Point(5, 29);
            revistaEdicao.Margin = new Padding(3, 2, 3, 2);
            revistaEdicao.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            revistaEdicao.Name = "revistaEdicao";
            revistaEdicao.Size = new Size(131, 23);
            revistaEdicao.TabIndex = 0;
            // 
            // HQ
            // 
            HQ.Controls.Add(hqIlustrador);
            HQ.Controls.Add(label15);
            HQ.Controls.Add(label14);
            HQ.Controls.Add(hqEdicao);
            HQ.Location = new Point(4, 24);
            HQ.Margin = new Padding(3, 2, 3, 2);
            HQ.Name = "HQ";
            HQ.Size = new Size(324, 268);
            HQ.TabIndex = 2;
            HQ.Text = "HQ";
            HQ.UseVisualStyleBackColor = true;
            // 
            // hqIlustrador
            // 
            hqIlustrador.Location = new Point(3, 83);
            hqIlustrador.Margin = new Padding(3, 2, 3, 2);
            hqIlustrador.Name = "hqIlustrador";
            hqIlustrador.Size = new Size(286, 23);
            hqIlustrador.TabIndex = 19;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(3, 68);
            label15.Name = "label15";
            label15.Size = new Size(57, 15);
            label15.TabIndex = 23;
            label15.Text = "Ilustrador";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(3, 14);
            label14.Name = "label14";
            label14.Size = new Size(42, 15);
            label14.TabIndex = 21;
            label14.Text = "Edicao";
            // 
            // hqEdicao
            // 
            hqEdicao.Location = new Point(3, 29);
            hqEdicao.Margin = new Padding(3, 2, 3, 2);
            hqEdicao.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            hqEdicao.Name = "hqEdicao";
            hqEdicao.Size = new Size(131, 23);
            hqEdicao.TabIndex = 20;
            // 
            // Generico
            // 
            Generico.Controls.Add(genericoTipo);
            Generico.Controls.Add(label16);
            Generico.Location = new Point(4, 24);
            Generico.Margin = new Padding(3, 2, 3, 2);
            Generico.Name = "Generico";
            Generico.Size = new Size(324, 268);
            Generico.TabIndex = 3;
            Generico.Text = "Generico";
            Generico.UseVisualStyleBackColor = true;
            // 
            // genericoTipo
            // 
            genericoTipo.FormattingEnabled = true;
            genericoTipo.ItemHeight = 15;
            genericoTipo.Items.AddRange(new object[] { "Jornais", "Calendários e Agendas", "Mapas e Atlas", "Postais e Cartões de Saudação", "Papéis de Presente e Material de Embalagem", "DVDs e Blu-rays", "CDs e Vinis", "K7", "Jogos de Tabuleiro e Quebra-Cabeças", "Material de Papelaria e Escritório", "Produtos Relacionados à Cultura Pop", "Audiolivros", "Outros" });
            genericoTipo.Location = new Point(15, 31);
            genericoTipo.Margin = new Padding(3, 2, 3, 2);
            genericoTipo.Name = "genericoTipo";
            genericoTipo.Size = new Size(294, 199);
            genericoTipo.TabIndex = 25;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(15, 14);
            label16.Name = "label16";
            label16.Size = new Size(30, 15);
            label16.TabIndex = 24;
            label16.Text = "Tipo";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, -1);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 3;
            label1.Text = "Exemplar";
            // 
            // TelaExemplar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 356);
            Controls.Add(label1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "TelaExemplar";
            Text = "TelaExemplar";
            Load += TelaExemplar_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)anoPublicacao).EndInit();
            panel3.ResumeLayout(false);
            controlador.ResumeLayout(false);
            Livro.ResumeLayout(false);
            Livro.PerformLayout();
            painalEbook.ResumeLayout(false);
            painalEbook.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ebookTamanho).EndInit();
            ((System.ComponentModel.ISupportInitialize)livroPaginas).EndInit();
            Revista.ResumeLayout(false);
            Revista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)revistaPaginas).EndInit();
            ((System.ComponentModel.ISupportInitialize)revistaEdicao).EndInit();
            HQ.ResumeLayout(false);
            HQ.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)hqEdicao).EndInit();
            Generico.ResumeLayout(false);
            Generico.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Button btnSalvar;
        private Label label1;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtEditora;
        private TextBox txtEscritor;
        private TextBox txtSubTitulo;
        private TextBox txtTitulo;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private NumericUpDown anoPublicacao;
        private ComboBox statusExemplar;
        private ComboBox generoExemplar;
        private TabControl controlador;
        private TabPage Livro;
        private Label label10;
        private ComboBox livroTipoCapa;
        private NumericUpDown livroPaginas;
        private Label label9;
        private TabPage Revista;
        private TabPage HQ;
        private TabPage Generico;
        private TextBox livroISBN;
        private Label label11;
        private Label label13;
        private NumericUpDown revistaPaginas;
        private Label label12;
        private NumericUpDown revistaEdicao;
        private TextBox hqIlustrador;
        private Label label15;
        private Label label14;
        private NumericUpDown hqEdicao;
        private Label label16;
        private ListBox genericoTipo;
        private ComboBox ebookFormato;
        private Label label17;
        private CheckBox checkEBook;
        private TextBox ebookUrl;
        private Label label19;
        private NumericUpDown ebookTamanho;
        private Label label18;
        public Panel painalEbook;
    }
}