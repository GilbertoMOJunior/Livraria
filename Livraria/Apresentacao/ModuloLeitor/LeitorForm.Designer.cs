namespace Livraria.Apresentacao.ModuloLeitor
{
    partial class LeitorForm
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
            txtEmail = new TextBox();
            lblEmail = new Label();
            txtTelefone = new TextBox();
            lblTelefone = new Label();
            txtNome = new TextBox();
            label1 = new Label();
            txtGeneroFav = new TextBox();
            lblGeneroFav = new Label();
            txtMatricula = new TextBox();
            lblMatricula = new Label();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(303, 231);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(73, 28);
            btnCancelar.TabIndex = 19;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(382, 231);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(70, 28);
            btnGravar.TabIndex = 18;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(126, 96);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(297, 23);
            txtEmail.TabIndex = 17;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(72, 96);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 16;
            lblEmail.Text = "Email";
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(126, 67);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(297, 23);
            txtTelefone.TabIndex = 15;
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Location = new Point(57, 67);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(51, 15);
            lblTelefone.TabIndex = 14;
            lblTelefone.Text = "Telefone";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(126, 38);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(297, 23);
            txtNome.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(68, 38);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 12;
            label1.Text = "Nome";
            // 
            // txtGeneroFav
            // 
            txtGeneroFav.Location = new Point(126, 154);
            txtGeneroFav.Name = "txtGeneroFav";
            txtGeneroFav.Size = new Size(297, 23);
            txtGeneroFav.TabIndex = 23;
            // 
            // lblGeneroFav
            // 
            lblGeneroFav.AutoSize = true;
            lblGeneroFav.Location = new Point(12, 154);
            lblGeneroFav.Name = "lblGeneroFav";
            lblGeneroFav.Size = new Size(96, 15);
            lblGeneroFav.TabIndex = 22;
            lblGeneroFav.Text = "Genero Preferido";
            // 
            // txtMatricula
            // 
            txtMatricula.Location = new Point(126, 125);
            txtMatricula.Name = "txtMatricula";
            txtMatricula.Size = new Size(297, 23);
            txtMatricula.TabIndex = 21;
            // 
            // lblMatricula
            // 
            lblMatricula.AutoSize = true;
            lblMatricula.Location = new Point(51, 125);
            lblMatricula.Name = "lblMatricula";
            lblMatricula.Size = new Size(57, 15);
            lblMatricula.TabIndex = 20;
            lblMatricula.Text = "Matricula";
            // 
            // LeitorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(469, 266);
            Controls.Add(txtGeneroFav);
            Controls.Add(lblGeneroFav);
            Controls.Add(txtMatricula);
            Controls.Add(lblMatricula);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(txtTelefone);
            Controls.Add(lblTelefone);
            Controls.Add(txtNome);
            Controls.Add(label1);
            Name = "LeitorForm";
            Text = "Cadastrar Leitor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Button btnGravar;
        private TextBox txtEmail;
        private Label lblEmail;
        private TextBox txtTelefone;
        private Label lblTelefone;
        private TextBox txtNome;
        private Label label1;
        private TextBox txtGeneroFav;
        private Label lblGeneroFav;
        private TextBox txtMatricula;
        private Label lblMatricula;
    }
}