namespace Livraria.Apresentacao.ModuloHQ
{
    partial class HQForm
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
            txtEdicao = new TextBox();
            lblEdicao = new Label();
            txtAutor = new TextBox();
            lblAutor = new Label();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(295, 221);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(73, 28);
            btnCancelar.TabIndex = 27;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(374, 221);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(70, 28);
            btnGravar.TabIndex = 26;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(71, 83);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(297, 23);
            txtPreco.TabIndex = 25;
            // 
            // lblPreco
            // 
            lblPreco.AutoSize = true;
            lblPreco.Location = new Point(23, 86);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(37, 15);
            lblPreco.TabIndex = 24;
            lblPreco.Text = "Preço";
            // 
            // txtGenero
            // 
            txtGenero.Location = new Point(71, 54);
            txtGenero.Name = "txtGenero";
            txtGenero.Size = new Size(297, 23);
            txtGenero.TabIndex = 23;
            // 
            // lblGenero
            // 
            lblGenero.AutoSize = true;
            lblGenero.Location = new Point(15, 54);
            lblGenero.Name = "lblGenero";
            lblGenero.Size = new Size(45, 15);
            lblGenero.TabIndex = 22;
            lblGenero.Text = "Genero";
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(71, 25);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(297, 23);
            txtTitulo.TabIndex = 21;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(23, 28);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(37, 15);
            lblTitulo.TabIndex = 20;
            lblTitulo.Text = "Titulo";
            // 
            // txtEdicao
            // 
            txtEdicao.Location = new Point(71, 141);
            txtEdicao.Name = "txtEdicao";
            txtEdicao.Size = new Size(297, 23);
            txtEdicao.TabIndex = 31;
            // 
            // lblEdicao
            // 
            lblEdicao.AutoSize = true;
            lblEdicao.Location = new Point(18, 144);
            lblEdicao.Name = "lblEdicao";
            lblEdicao.Size = new Size(42, 15);
            lblEdicao.TabIndex = 30;
            lblEdicao.Text = "Edição";
            // 
            // txtAutor
            // 
            txtAutor.Location = new Point(71, 112);
            txtAutor.Name = "txtAutor";
            txtAutor.Size = new Size(297, 23);
            txtAutor.TabIndex = 29;
            // 
            // lblAutor
            // 
            lblAutor.AutoSize = true;
            lblAutor.Location = new Point(23, 112);
            lblAutor.Name = "lblAutor";
            lblAutor.Size = new Size(37, 15);
            lblAutor.TabIndex = 28;
            lblAutor.Text = "Autor";
            // 
            // HQForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(483, 276);
            Controls.Add(txtEdicao);
            Controls.Add(lblEdicao);
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
            Name = "HQForm";
            Text = "Cadastro de HQ";
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
        private TextBox txtEdicao;
        private Label lblEdicao;
        private TextBox txtAutor;
        private Label lblAutor;
    }
}