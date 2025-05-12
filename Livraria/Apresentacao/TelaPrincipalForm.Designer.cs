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
            funcioanriosToolStripMenuItem = new ToolStripMenuItem();
            leitoresToolStripMenuItem = new ToolStripMenuItem();
            exemplaresToolStripMenuItem = new ToolStripMenuItem();
            hQToolStripMenuItem = new ToolStripMenuItem();
            livroToolStripMenuItem = new ToolStripMenuItem();
            revistaToolStripMenuItem = new ToolStripMenuItem();
            genericoToolStripMenuItem = new ToolStripMenuItem();
            exemplaresToolStripMenuItem1 = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            btnAdicionar = new ToolStripButton();
            btnEditar = new ToolStripButton();
            btnExcluir = new ToolStripButton();
            painelRegistros = new Panel();
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
            pessoasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { funcioanriosToolStripMenuItem, leitoresToolStripMenuItem });
            pessoasToolStripMenuItem.Name = "pessoasToolStripMenuItem";
            pessoasToolStripMenuItem.Size = new Size(134, 22);
            pessoasToolStripMenuItem.Text = "Pessoas";
            // 
            // funcioanriosToolStripMenuItem
            // 
            funcioanriosToolStripMenuItem.Name = "funcioanriosToolStripMenuItem";
            funcioanriosToolStripMenuItem.Size = new Size(142, 22);
            funcioanriosToolStripMenuItem.Text = "Funcioanrios";
            funcioanriosToolStripMenuItem.Click += funcioanriosToolStripMenuItem_Click;
            // 
            // leitoresToolStripMenuItem
            // 
            leitoresToolStripMenuItem.Name = "leitoresToolStripMenuItem";
            leitoresToolStripMenuItem.Size = new Size(142, 22);
            leitoresToolStripMenuItem.Text = "Leitores";
            leitoresToolStripMenuItem.Click += leitoresToolStripMenuItem_Click;
            // 
            // exemplaresToolStripMenuItem
            // 
            exemplaresToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { hQToolStripMenuItem, livroToolStripMenuItem, revistaToolStripMenuItem, genericoToolStripMenuItem });
            exemplaresToolStripMenuItem.Name = "exemplaresToolStripMenuItem";
            exemplaresToolStripMenuItem.Size = new Size(134, 22);
            exemplaresToolStripMenuItem.Text = "Exemplares";
            // 
            // hQToolStripMenuItem
            // 
            hQToolStripMenuItem.Name = "hQToolStripMenuItem";
            hQToolStripMenuItem.Size = new Size(121, 22);
            hQToolStripMenuItem.Text = "HQ";
            hQToolStripMenuItem.Click += hQToolStripMenuItem_Click;
            // 
            // livroToolStripMenuItem
            // 
            livroToolStripMenuItem.Name = "livroToolStripMenuItem";
            livroToolStripMenuItem.Size = new Size(121, 22);
            livroToolStripMenuItem.Text = "Livro";
            livroToolStripMenuItem.Click += livroToolStripMenuItem_Click;
            // 
            // revistaToolStripMenuItem
            // 
            revistaToolStripMenuItem.Name = "revistaToolStripMenuItem";
            revistaToolStripMenuItem.Size = new Size(121, 22);
            revistaToolStripMenuItem.Text = "Revista";
            revistaToolStripMenuItem.Click += revistaToolStripMenuItem_Click;
            // 
            // genericoToolStripMenuItem
            // 
            genericoToolStripMenuItem.Name = "genericoToolStripMenuItem";
            genericoToolStripMenuItem.Size = new Size(121, 22);
            genericoToolStripMenuItem.Text = "Generico";
            genericoToolStripMenuItem.Click += genericoToolStripMenuItem_Click;
            // 
            // exemplaresToolStripMenuItem1
            // 
            exemplaresToolStripMenuItem1.Name = "exemplaresToolStripMenuItem1";
            exemplaresToolStripMenuItem1.Size = new Size(32, 19);
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnAdicionar, btnEditar, btnExcluir });
            toolStrip1.Location = new Point(0, 24);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 25);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnAdicionar
            // 
            btnAdicionar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnAdicionar.Image = (Image)resources.GetObject("btnAdicionar.Image");
            btnAdicionar.ImageTransparentColor = Color.Magenta;
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(23, 22);
            btnAdicionar.Text = "toolStripButton1";
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnEditar
            // 
            btnEditar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnEditar.Image = (Image)resources.GetObject("btnEditar.Image");
            btnEditar.ImageTransparentColor = Color.Magenta;
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(23, 22);
            btnEditar.Text = "toolStripButton2";
            btnEditar.Click += btnEditar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnExcluir.Image = (Image)resources.GetObject("btnExcluir.Image");
            btnExcluir.ImageTransparentColor = Color.Magenta;
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(23, 22);
            btnExcluir.Text = "toolStripButton3";
            btnExcluir.Click += btnExcluir_Click;
            // 
            // painelRegistros
            // 
            painelRegistros.Dock = DockStyle.Fill;
            painelRegistros.Location = new Point(0, 49);
            painelRegistros.Name = "painelRegistros";
            painelRegistros.Size = new Size(800, 401);
            painelRegistros.TabIndex = 2;
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
        private ToolStripMenuItem funcioanriosToolStripMenuItem;
        private ToolStripMenuItem leitoresToolStripMenuItem;
        private ToolStripMenuItem exemplaresToolStripMenuItem;
        private ToolStripMenuItem hQToolStripMenuItem;
        private ToolStripMenuItem livroToolStripMenuItem;
        private ToolStripMenuItem revistaToolStripMenuItem;
        private ToolStripMenuItem genericoToolStripMenuItem;
        private ToolStripMenuItem exemplaresToolStripMenuItem1;
        private ToolStrip toolStrip1;
        private ToolStripButton btnAdicionar;
        private ToolStripButton btnEditar;
        private ToolStripButton btnExcluir;
        private Panel painelRegistros;
    }
}