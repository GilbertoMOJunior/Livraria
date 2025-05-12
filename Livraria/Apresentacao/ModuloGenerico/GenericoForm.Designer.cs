namespace Livraria.Apresentacao.ModuloGenerico
{
    partial class GenericoForm
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
            txtIdioma = new TextBox();
            lblIdioma = new Label();
            txtAutor = new TextBox();
            lblAutor = new Label();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(306, 221);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(73, 28);
            btnCancelar.TabIndex = 19;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(385, 221);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(70, 28);
            btnGravar.TabIndex = 18;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(82, 83);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(297, 23);
            txtPreco.TabIndex = 17;
            // 
            // lblPreco
            // 
            lblPreco.AutoSize = true;
            lblPreco.Location = new Point(34, 86);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(37, 15);
            lblPreco.TabIndex = 16;
            lblPreco.Text = "Preço";
            // 
            // txtGenero
            // 
            txtGenero.Location = new Point(82, 54);
            txtGenero.Name = "txtGenero";
            txtGenero.Size = new Size(297, 23);
            txtGenero.TabIndex = 15;
            // 
            // lblGenero
            // 
            lblGenero.AutoSize = true;
            lblGenero.Location = new Point(26, 54);
            lblGenero.Name = "lblGenero";
            lblGenero.Size = new Size(45, 15);
            lblGenero.TabIndex = 14;
            lblGenero.Text = "Genero";
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(82, 25);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(297, 23);
            txtTitulo.TabIndex = 13;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(34, 28);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(37, 15);
            lblTitulo.TabIndex = 12;
            lblTitulo.Text = "Titulo";
            // 
            // txtIdioma
            // 
            txtIdioma.Location = new Point(82, 141);
            txtIdioma.Name = "txtIdioma";
            txtIdioma.Size = new Size(297, 23);
            txtIdioma.TabIndex = 23;
            // 
            // lblIdioma
            // 
            lblIdioma.AutoSize = true;
            lblIdioma.Location = new Point(27, 144);
            lblIdioma.Name = "lblIdioma";
            lblIdioma.Size = new Size(44, 15);
            lblIdioma.TabIndex = 22;
            lblIdioma.Text = "Idioma";
            // 
            // txtAutor
            // 
            txtAutor.Location = new Point(82, 112);
            txtAutor.Name = "txtAutor";
            txtAutor.Size = new Size(297, 23);
            txtAutor.TabIndex = 21;
            // 
            // lblAutor
            // 
            lblAutor.AutoSize = true;
            lblAutor.Location = new Point(34, 115);
            lblAutor.Name = "lblAutor";
            lblAutor.Size = new Size(37, 15);
            lblAutor.TabIndex = 20;
            lblAutor.Text = "Autor";
            // 
            // GenericoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(470, 263);
            Controls.Add(txtIdioma);
            Controls.Add(lblIdioma);
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
            Name = "GenericoForm";
            Text = "Cadastrar Generico";
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
        private TextBox txtIdioma;
        private Label lblIdioma;
        private TextBox txtAutor;
        private Label lblAutor;
    }
}