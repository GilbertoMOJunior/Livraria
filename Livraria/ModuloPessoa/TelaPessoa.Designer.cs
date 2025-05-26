namespace Trabalho_Forms
{
    partial class TelaPessoa
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
            txtTelefone = new MaskedTextBox();
            txtCPF = new MaskedTextBox();
            txtEmail = new TextBox();
            dateNascimento = new DateTimePicker();
            txtNome = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            controlador = new TabControl();
            Leitor = new TabPage();
            label7 = new Label();
            tipoLeitor = new ListBox();
            Funcionario = new TabPage();
            label11 = new Label();
            txtFuncao = new TextBox();
            label10 = new Label();
            label9 = new Label();
            cargaHoraria = new NumericUpDown();
            salario = new NumericUpDown();
            label8 = new Label();
            cargoFuncionario = new ComboBox();
            btnSalvar = new Button();
            pageSetupDialog1 = new PageSetupDialog();
            label1 = new Label();
            panel3 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            controlador.SuspendLayout();
            Leitor.SuspendLayout();
            Funcionario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cargaHoraria).BeginInit();
            ((System.ComponentModel.ISupportInitialize)salario).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(txtTelefone);
            panel1.Controls.Add(txtCPF);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(dateNascimento);
            panel1.Controls.Add(txtNome);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.ImeMode = ImeMode.NoControl;
            panel1.Location = new Point(10, 11);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(335, 266);
            panel1.TabIndex = 0;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(3, 227);
            txtTelefone.Margin = new Padding(3, 2, 3, 2);
            txtTelefone.Mask = "(00) 0000-0000";
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(137, 23);
            txtTelefone.TabIndex = 11;
            // 
            // txtCPF
            // 
            txtCPF.Location = new Point(3, 124);
            txtCPF.Margin = new Padding(3, 2, 3, 2);
            txtCPF.Mask = "000,000,000-00";
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new Size(137, 23);
            txtCPF.TabIndex = 10;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(3, 175);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(304, 23);
            txtEmail.TabIndex = 8;
            // 
            // dateNascimento
            // 
            dateNascimento.Location = new Point(3, 76);
            dateNascimento.Margin = new Padding(3, 2, 3, 2);
            dateNascimento.Name = "dateNascimento";
            dateNascimento.Size = new Size(304, 23);
            dateNascimento.TabIndex = 6;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(3, 29);
            txtNome.Margin = new Padding(3, 2, 3, 2);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(304, 23);
            txtNome.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 210);
            label6.Name = "label6";
            label6.Size = new Size(51, 15);
            label6.TabIndex = 4;
            label6.Text = "Telefone";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 158);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 3;
            label5.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 107);
            label4.Name = "label4";
            label4.Size = new Size(28, 15);
            label4.TabIndex = 2;
            label4.Text = "CPF";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 59);
            label3.Name = "label3";
            label3.Size = new Size(71, 15);
            label3.TabIndex = 1;
            label3.Text = "Nascimento";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 12);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 0;
            label2.Text = "Nome";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlDark;
            panel2.Controls.Add(controlador);
            panel2.Location = new Point(351, 9);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(339, 266);
            panel2.TabIndex = 1;
            // 
            // controlador
            // 
            controlador.Controls.Add(Leitor);
            controlador.Controls.Add(Funcionario);
            controlador.Location = new Point(3, 2);
            controlador.Margin = new Padding(3, 2, 3, 2);
            controlador.Name = "controlador";
            controlador.SelectedIndex = 0;
            controlador.Size = new Size(333, 262);
            controlador.TabIndex = 1;
            // 
            // Leitor
            // 
            Leitor.BackColor = Color.Transparent;
            Leitor.Controls.Add(label7);
            Leitor.Controls.Add(tipoLeitor);
            Leitor.Location = new Point(4, 24);
            Leitor.Margin = new Padding(3, 2, 3, 2);
            Leitor.Name = "Leitor";
            Leitor.Padding = new Padding(3, 2, 3, 2);
            Leitor.Size = new Size(325, 234);
            Leitor.TabIndex = 0;
            Leitor.Text = "Leitor";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(16, 10);
            label7.Name = "label7";
            label7.Size = new Size(30, 15);
            label7.TabIndex = 1;
            label7.Text = "Tipo";
            // 
            // tipoLeitor
            // 
            tipoLeitor.ForeColor = SystemColors.InfoText;
            tipoLeitor.FormattingEnabled = true;
            tipoLeitor.ItemHeight = 15;
            tipoLeitor.Items.AddRange(new object[] { "Leitor Casual", "Leitor Avido", "Leitor de Ficcao", "Leitor de Nao Ficcao", "Leitor Critico", "Leitor de Best-sellers", "Leitor de Classicos", "Leitor de Genero Epscifico", "Leitor Academico", "Leitor Digital", "Leitor Tradicional", "Leitor de Livros de Bolso", "Leitor Multitarefa", "Outros" });
            tipoLeitor.Location = new Point(16, 28);
            tipoLeitor.Margin = new Padding(3, 2, 3, 2);
            tipoLeitor.Name = "tipoLeitor";
            tipoLeitor.Size = new Size(295, 199);
            tipoLeitor.TabIndex = 0;
            // 
            // Funcionario
            // 
            Funcionario.Controls.Add(label11);
            Funcionario.Controls.Add(txtFuncao);
            Funcionario.Controls.Add(label10);
            Funcionario.Controls.Add(label9);
            Funcionario.Controls.Add(cargaHoraria);
            Funcionario.Controls.Add(salario);
            Funcionario.Controls.Add(label8);
            Funcionario.Controls.Add(cargoFuncionario);
            Funcionario.Location = new Point(4, 24);
            Funcionario.Margin = new Padding(3, 2, 3, 2);
            Funcionario.Name = "Funcionario";
            Funcionario.Padding = new Padding(3, 2, 3, 2);
            Funcionario.Size = new Size(325, 234);
            Funcionario.TabIndex = 1;
            Funcionario.Text = "Funcionario";
            Funcionario.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(18, 186);
            label11.Name = "label11";
            label11.Size = new Size(46, 15);
            label11.TabIndex = 7;
            label11.Text = "Funcao";
            // 
            // txtFuncao
            // 
            txtFuncao.Location = new Point(18, 203);
            txtFuncao.Margin = new Padding(3, 2, 3, 2);
            txtFuncao.Name = "txtFuncao";
            txtFuncao.Size = new Size(110, 23);
            txtFuncao.TabIndex = 6;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(18, 125);
            label10.Name = "label10";
            label10.Size = new Size(80, 15);
            label10.TabIndex = 5;
            label10.Text = "Carga Horaria";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(19, 67);
            label9.Name = "label9";
            label9.Size = new Size(42, 15);
            label9.TabIndex = 4;
            label9.Text = "Salario";
            // 
            // cargaHoraria
            // 
            cargaHoraria.Location = new Point(18, 142);
            cargaHoraria.Margin = new Padding(3, 2, 3, 2);
            cargaHoraria.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            cargaHoraria.Name = "cargaHoraria";
            cargaHoraria.Size = new Size(131, 23);
            cargaHoraria.TabIndex = 3;
            cargaHoraria.Value = new decimal(new int[] { 80, 0, 0, 0 });
            // 
            // salario
            // 
            salario.DecimalPlaces = 2;
            salario.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            salario.Location = new Point(18, 84);
            salario.Margin = new Padding(3, 2, 3, 2);
            salario.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            salario.Name = "salario";
            salario.Size = new Size(131, 23);
            salario.TabIndex = 2;
            salario.Value = new decimal(new int[] { 1000, 0, 0, 0 });
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(18, 10);
            label8.Name = "label8";
            label8.Size = new Size(39, 15);
            label8.TabIndex = 1;
            label8.Text = "Cargo";
            // 
            // cargoFuncionario
            // 
            cargoFuncionario.DisplayMember = "1";
            cargoFuncionario.DropDownStyle = ComboBoxStyle.DropDownList;
            cargoFuncionario.FormattingEnabled = true;
            cargoFuncionario.Items.AddRange(new object[] { "Gerente", "Atendente", "Caixa", "Estagiário" });
            cargoFuncionario.Location = new Point(18, 29);
            cargoFuncionario.Margin = new Padding(3, 2, 3, 2);
            cargoFuncionario.Name = "cargoFuncionario";
            cargoFuncionario.Size = new Size(193, 23);
            cargoFuncionario.TabIndex = 0;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = SystemColors.GradientInactiveCaption;
            btnSalvar.DialogResult = DialogResult.OK;
            btnSalvar.Location = new Point(3, 2);
            btnSalvar.Margin = new Padding(3, 2, 3, 2);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(674, 44);
            btnSalvar.TabIndex = 0;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, -1);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 0;
            label1.Text = "Pessoa";
            // 
            // panel3
            // 
            panel3.Controls.Add(btnSalvar);
            panel3.Location = new Point(10, 280);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(679, 49);
            panel3.TabIndex = 2;
            // 
            // TelaPessoa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(700, 338);
            Controls.Add(label1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "TelaPessoa";
            Text = "TelaPessoa";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            controlador.ResumeLayout(false);
            Leitor.ResumeLayout(false);
            Leitor.PerformLayout();
            Funcionario.ResumeLayout(false);
            Funcionario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cargaHoraria).EndInit();
            ((System.ComponentModel.ISupportInitialize)salario).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button btnSalvar;
        private PageSetupDialog pageSetupDialog1;
        private Label label2;
        private Label label1;
        private TextBox txtEmail;
        private DateTimePicker dateNascimento;
        private TextBox txtNome;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private MaskedTextBox txtTelefone;
        private MaskedTextBox txtCPF;
        private TabControl controlador;
        private TabPage Leitor;
        private TabPage Funcionario;
        private ListBox tipoLeitor;
        private Label label7;
        private Label label10;
        private Label label9;
        private NumericUpDown cargaHoraria;
        private NumericUpDown salario;
        private Label label8;
        private ComboBox cargoFuncionario;
        private Label label11;
        private TextBox txtFuncao;
        private Panel panel3;
    }
}