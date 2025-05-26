namespace Livraria.Apresentacao
{
    partial class TelaPrincipalForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPrincipalForm));
            menuStrip1 = new MenuStrip();
            cadastrosToolStripMenuItem = new ToolStripMenuItem();
            pessoasToolStripMenuItem = new ToolStripMenuItem();
            exemplaresToolStripMenuItem = new ToolStripMenuItem();
            exemplaresToolStripMenuItem1 = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            btnAdicionar = new ToolStripButton();
            btnEditar = new ToolStripButton();
            btnExcluir = new ToolStripButton();
            painelRegistros = new Panel();
            leitoresToolStripMenuItem = new ToolStripMenuItem();
            funcionariosToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(16, 18);
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastrosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            cadastrosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { pessoasToolStripMenuItem, exemplaresToolStripMenuItem });
            cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            cadastrosToolStripMenuItem.Size = new Size(71, 20);
            cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // pessoasToolStripMenuItem
            // 
            pessoasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { leitoresToolStripMenuItem, funcionariosToolStripMenuItem });
            pessoasToolStripMenuItem.Name = "pessoasToolStripMenuItem";
            pessoasToolStripMenuItem.Size = new Size(180, 22);
            pessoasToolStripMenuItem.Text = "Pessoas";
            // 
            // exemplaresToolStripMenuItem
            // 
            exemplaresToolStripMenuItem.Name = "exemplaresToolStripMenuItem";
            exemplaresToolStripMenuItem.Size = new Size(180, 22);
            exemplaresToolStripMenuItem.Text = "Exemplares";
            exemplaresToolStripMenuItem.Click += exemplaresToolStripMenuItem_Click;
            // 
            // exemplaresToolStripMenuItem1
            // 
            exemplaresToolStripMenuItem1.Name = "exemplaresToolStripMenuItem1";
            exemplaresToolStripMenuItem1.Size = new Size(32, 19);
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnAdicionar, btnEditar, btnExcluir });
            toolStrip1.Location = new Point(0, 24);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 27);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnAdicionar
            // 
            btnAdicionar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnAdicionar.Enabled = false;
            btnAdicionar.Image = (Image)resources.GetObject("btnAdicionar.Image");
            btnAdicionar.ImageTransparentColor = Color.Magenta;
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(24, 24);
            btnAdicionar.Text = "Adicionar Registro";
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnEditar
            // 
            btnEditar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnEditar.Enabled = false;
            btnEditar.Image = (Image)resources.GetObject("btnEditar.Image");
            btnEditar.ImageTransparentColor = Color.Magenta;
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(24, 24);
            btnEditar.Text = "Editar Registro";
            btnEditar.Click += btnEditar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnExcluir.Enabled = false;
            btnExcluir.Image = (Image)resources.GetObject("btnExcluir.Image");
            btnExcluir.ImageTransparentColor = Color.Magenta;
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(24, 24);
            btnExcluir.Text = "Excluir Registro";
            btnExcluir.Click += btnExcluir_Click;
            // 
            // painelRegistros
            // 
            painelRegistros.Dock = DockStyle.Fill;
            painelRegistros.Location = new Point(0, 51);
            painelRegistros.Name = "painelRegistros";
            painelRegistros.Size = new Size(800, 399);
            painelRegistros.TabIndex = 2;
            // 
            // leitoresToolStripMenuItem
            // 
            leitoresToolStripMenuItem.Name = "leitoresToolStripMenuItem";
            leitoresToolStripMenuItem.Size = new Size(180, 22);
            leitoresToolStripMenuItem.Text = "Leitores";
            leitoresToolStripMenuItem.Click += leitoresToolStripMenuItem_Click;
            // 
            // funcionariosToolStripMenuItem
            // 
            funcionariosToolStripMenuItem.Name = "funcionariosToolStripMenuItem";
            funcionariosToolStripMenuItem.Size = new Size(180, 22);
            funcionariosToolStripMenuItem.Text = "Funcionarios";
            funcionariosToolStripMenuItem.Click += funcionariosToolStripMenuItem_Click;
            // 
            // TelaPrincipalForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(painelRegistros);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "TelaPrincipalForm";
            Text = "TelaPrincipalForm";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastrosToolStripMenuItem;
        private ToolStripMenuItem pessoasToolStripMenuItem;
        private ToolStripMenuItem exemplaresToolStripMenuItem;
        private ToolStripMenuItem exemplaresToolStripMenuItem1;
        private ToolStrip toolStrip1;
        private ToolStripButton btnAdicionar;
        private ToolStripButton btnEditar;
        private ToolStripButton btnExcluir;
        private Panel painelRegistros;
        private ToolStripMenuItem leitoresToolStripMenuItem;
        private ToolStripMenuItem funcionariosToolStripMenuItem;
    }
}