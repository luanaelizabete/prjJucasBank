namespace prjJucasBank
{
    partial class TelaLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaLogin));
            menu = new MenuStrip();
            cadastroToolStripMenuItem = new ToolStripMenuItem();
            loginToolStripMenuItem = new ToolStripMenuItem();
            operaçõesToolStripMenuItem = new ToolStripMenuItem();
            saqueToolStripMenuItem = new ToolStripMenuItem();
            depósitoToolStripMenuItem = new ToolStripMenuItem();
            transferênciaToolStripMenuItem = new ToolStripMenuItem();
            contaToolStripMenuItem = new ToolStripMenuItem();
            extratoToolStripMenuItem = new ToolStripMenuItem();
            pagamentosToolStripMenuItem = new ToolStripMenuItem();
            agendamentosToolStripMenuItem = new ToolStripMenuItem();
            nomeToolStripMenuItem = new ToolStripMenuItem();
            pictureBox2 = new PictureBox();
            menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // menu
            // 
            menu.Items.AddRange(new ToolStripItem[] { cadastroToolStripMenuItem, loginToolStripMenuItem, operaçõesToolStripMenuItem, contaToolStripMenuItem, extratoToolStripMenuItem, pagamentosToolStripMenuItem, agendamentosToolStripMenuItem, nomeToolStripMenuItem });
            menu.Location = new Point(0, 0);
            menu.Name = "menu";
            menu.Size = new Size(998, 24);
            menu.TabIndex = 51;
            menu.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            cadastroToolStripMenuItem.Size = new Size(66, 20);
            cadastroToolStripMenuItem.Text = "Cadastro";
            cadastroToolStripMenuItem.Click += cadastroToolStripMenuItem_Click;
            // 
            // loginToolStripMenuItem
            // 
            loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            loginToolStripMenuItem.Size = new Size(49, 20);
            loginToolStripMenuItem.Text = "Login";
            loginToolStripMenuItem.Click += loginToolStripMenuItem_Click;
            // 
            // operaçõesToolStripMenuItem
            // 
            operaçõesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { saqueToolStripMenuItem, depósitoToolStripMenuItem, transferênciaToolStripMenuItem });
            operaçõesToolStripMenuItem.Name = "operaçõesToolStripMenuItem";
            operaçõesToolStripMenuItem.Size = new Size(75, 20);
            operaçõesToolStripMenuItem.Text = "Operações";
            // 
            // saqueToolStripMenuItem
            // 
            saqueToolStripMenuItem.Name = "saqueToolStripMenuItem";
            saqueToolStripMenuItem.Size = new Size(143, 22);
            saqueToolStripMenuItem.Text = "Saque";
            saqueToolStripMenuItem.Click += saqueToolStripMenuItem_Click;
            // 
            // depósitoToolStripMenuItem
            // 
            depósitoToolStripMenuItem.Name = "depósitoToolStripMenuItem";
            depósitoToolStripMenuItem.Size = new Size(143, 22);
            depósitoToolStripMenuItem.Text = "Depósito";
            depósitoToolStripMenuItem.Click += depósitoToolStripMenuItem_Click;
            // 
            // transferênciaToolStripMenuItem
            // 
            transferênciaToolStripMenuItem.Name = "transferênciaToolStripMenuItem";
            transferênciaToolStripMenuItem.Size = new Size(143, 22);
            transferênciaToolStripMenuItem.Text = "Transferência";
            // 
            // contaToolStripMenuItem
            // 
            contaToolStripMenuItem.Name = "contaToolStripMenuItem";
            contaToolStripMenuItem.Size = new Size(51, 20);
            contaToolStripMenuItem.Text = "Conta";
            // 
            // extratoToolStripMenuItem
            // 
            extratoToolStripMenuItem.Name = "extratoToolStripMenuItem";
            extratoToolStripMenuItem.Size = new Size(56, 20);
            extratoToolStripMenuItem.Text = "Extrato";
            // 
            // pagamentosToolStripMenuItem
            // 
            pagamentosToolStripMenuItem.Name = "pagamentosToolStripMenuItem";
            pagamentosToolStripMenuItem.Size = new Size(85, 20);
            pagamentosToolStripMenuItem.Text = "Pagamentos";
            // 
            // agendamentosToolStripMenuItem
            // 
            agendamentosToolStripMenuItem.Name = "agendamentosToolStripMenuItem";
            agendamentosToolStripMenuItem.Size = new Size(100, 20);
            agendamentosToolStripMenuItem.Text = "Agendamentos";
            // 
            // nomeToolStripMenuItem
            // 
            nomeToolStripMenuItem.Name = "nomeToolStripMenuItem";
            nomeToolStripMenuItem.Size = new Size(52, 20);
            nomeToolStripMenuItem.Text = "Nome";
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(698, 46);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(263, 125);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 49;
            pictureBox2.TabStop = false;
            // 
            // TelaLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(998, 478);
            Controls.Add(pictureBox2);
            Controls.Add(menu);
            MainMenuStrip = menu;
            Name = "TelaLogin";
            Text = "TelaCadastro2";
            menu.ResumeLayout(false);
            menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menu;
        private ToolStripMenuItem cadastroToolStripMenuItem;
        private ToolStripMenuItem loginToolStripMenuItem;
        private ToolStripMenuItem operaçõesToolStripMenuItem;
        private ToolStripMenuItem saqueToolStripMenuItem;
        private ToolStripMenuItem depósitoToolStripMenuItem;
        private ToolStripMenuItem transferênciaToolStripMenuItem;
        private ToolStripMenuItem contaToolStripMenuItem;
        private PictureBox pictureBox2;
        private ToolStripMenuItem extratoToolStripMenuItem;
        private ToolStripMenuItem pagamentosToolStripMenuItem;
        private ToolStripMenuItem agendamentosToolStripMenuItem;
        private ToolStripMenuItem nomeToolStripMenuItem;
    }
}