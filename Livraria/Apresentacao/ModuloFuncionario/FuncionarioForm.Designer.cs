namespace Livraria.Apresentacao.ModuloFuncionario
{
    partial class FuncionarioForm
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
            label1 = new Label();
            txtNome = new TextBox();
            txtTelefone = new TextBox();
            lblTelefone = new Label();
            txtCargo = new TextBox();
            lblCargo = new Label();
            txtEmail = new TextBox();
            lblEmail = new Label();
            txtMatricula = new TextBox();
            lblMatricula = new Label();
            btnGravar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 60);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(95, 57);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(297, 23);
            txtNome.TabIndex = 1;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(95, 86);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(297, 23);
            txtTelefone.TabIndex = 3;
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Location = new Point(39, 86);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(51, 15);
            lblTelefone.TabIndex = 2;
            lblTelefone.Text = "Telefone";
            // 
            // txtCargo
            // 
            txtCargo.Location = new Point(95, 144);
            txtCargo.Name = "txtCargo";
            txtCargo.Size = new Size(297, 23);
            txtCargo.TabIndex = 7;
            // 
            // lblCargo
            // 
            lblCargo.AutoSize = true;
            lblCargo.Location = new Point(48, 147);
            lblCargo.Name = "lblCargo";
            lblCargo.Size = new Size(39, 15);
            lblCargo.TabIndex = 6;
            lblCargo.Text = "Cargo";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(95, 115);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(297, 23);
            txtEmail.TabIndex = 5;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(51, 118);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "Email";
            // 
            // txtMatricula
            // 
            txtMatricula.Location = new Point(95, 173);
            txtMatricula.Name = "txtMatricula";
            txtMatricula.Size = new Size(297, 23);
            txtMatricula.TabIndex = 9;
            // 
            // lblMatricula
            // 
            lblMatricula.AutoSize = true;
            lblMatricula.Location = new Point(30, 176);
            lblMatricula.Name = "lblMatricula";
            lblMatricula.Size = new Size(57, 15);
            lblMatricula.TabIndex = 8;
            lblMatricula.Text = "Matricula";
            // 
            // btnGravar
            // 
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(398, 253);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(70, 28);
            btnGravar.TabIndex = 10;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(319, 253);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(73, 28);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // FuncionarioForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(480, 296);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(txtMatricula);
            Controls.Add(lblMatricula);
            Controls.Add(txtCargo);
            Controls.Add(lblCargo);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(txtTelefone);
            Controls.Add(lblTelefone);
            Controls.Add(txtNome);
            Controls.Add(label1);
            Name = "FuncionarioForm";
            Text = "Cadastrar Funcionario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNome;
        private TextBox txtTelefone;
        private Label lblTelefone;
        private TextBox txtCargo;
        private Label lblCargo;
        private TextBox txtEmail;
        private Label lblEmail;
        private TextBox txtMatricula;
        private Label lblMatricula;
        private Button btnGravar;
        private Button btnCancelar;
    }
}