namespace Livraria.Apresentacao.ModuloLivro
{
    partial class LivroForm
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
            btnCancelar = new Button();
            btnGravar = new Button();
            txtPreco = new TextBox();
            lblPreco = new Label();
            txtGenero = new TextBox();
            lblGenero = new Label();
            txtTitulo = new TextBox();
            lblTitulo = new Label();
            txtPaginas = new TextBox();
            lblPaginas = new Label();
            txtAutor = new TextBox();
            lblAutor = new Label();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(309, 226);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(73, 28);
            btnCancelar.TabIndex = 27;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(388, 226);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(70, 28);
            btnGravar.TabIndex = 26;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(85, 88);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(297, 23);
            txtPreco.TabIndex = 25;
            // 
            // lblPreco
            // 
            lblPreco.AutoSize = true;
            lblPreco.Location = new Point(29, 88);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(37, 15);
            lblPreco.TabIndex = 24;
            lblPreco.Text = "Preço";
            // 
            // txtGenero
            // 
            txtGenero.Location = new Point(85, 59);
            txtGenero.Name = "txtGenero";
            txtGenero.Size = new Size(297, 23);
            txtGenero.TabIndex = 23;
            // 
            // lblGenero
            // 
            lblGenero.AutoSize = true;
            lblGenero.Location = new Point(29, 59);
            lblGenero.Name = "lblGenero";
            lblGenero.Size = new Size(45, 15);
            lblGenero.TabIndex = 22;
            lblGenero.Text = "Genero";
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(85, 30);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(297, 23);
            txtTitulo.TabIndex = 21;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(37, 33);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(37, 15);
            lblTitulo.TabIndex = 20;
            lblTitulo.Text = "Titulo";
            // 
            // txtPaginas
            // 
            txtPaginas.Location = new Point(85, 148);
            txtPaginas.Name = "txtPaginas";
            txtPaginas.Size = new Size(297, 23);
            txtPaginas.TabIndex = 31;
            // 
            // lblPaginas
            // 
            lblPaginas.AutoSize = true;
            lblPaginas.Location = new Point(26, 146);
            lblPaginas.Name = "lblPaginas";
            lblPaginas.Size = new Size(48, 15);
            lblPaginas.TabIndex = 30;
            lblPaginas.Text = "Paginas";
            // 
            // txtAutor
            // 
            txtAutor.Location = new Point(85, 117);
            txtAutor.Name = "txtAutor";
            txtAutor.Size = new Size(297, 23);
            txtAutor.TabIndex = 29;
            // 
            // lblAutor
            // 
            lblAutor.AutoSize = true;
            lblAutor.Location = new Point(29, 117);
            lblAutor.Name = "lblAutor";
            lblAutor.Size = new Size(37, 15);
            lblAutor.TabIndex = 28;
            lblAutor.Text = "Autor";
            // 
            // LivroForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(503, 273);
            Controls.Add(txtPaginas);
            Controls.Add(lblPaginas);
            Controls.Add(txtAutor);
            Controls.Add(lblAutor);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(txtPreco);
            Controls.Add(lblPreco);
            Controls.Add(txtGenero);
            Controls.Add(lblGenero);
            Controls.Add(txtTitulo);
            Controls.Add(lblTitulo);
            Name = "LivroForm";
            Text = "Cadastro de Livro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Button btnGravar;
        private TextBox txtPreco;
        private Label lblPreco;
        private TextBox txtGenero;
        private Label lblGenero;
        private TextBox txtTitulo;
        private Label lblTitulo;
        private TextBox txtPaginas;
        private Label lblPaginas;
        private TextBox txtAutor;
        private Label lblAutor;
    }
}