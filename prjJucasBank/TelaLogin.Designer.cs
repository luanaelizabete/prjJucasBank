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
            loginToolStripMenuItem = new ToolStripMenuItem();
            cadastroToolStripMenuItem = new ToolStripMenuItem();
            operaçõesToolStripMenuItem = new ToolStripMenuItem();
            saqueToolStripMenuItem = new ToolStripMenuItem();
            depósitoToolStripMenuItem = new ToolStripMenuItem();
            transferênciaToolStripMenuItem = new ToolStripMenuItem();
            contaToolStripMenuItem = new ToolStripMenuItem();
            extratoToolStripMenuItem = new ToolStripMenuItem();
            nomeToolStripMenuItem = new ToolStripMenuItem();
            configuraçõesToolStripMenuItem = new ToolStripMenuItem();
            criarContaToolStripMenuItem = new ToolStripMenuItem();
            alterarContaToolStripMenuItem = new ToolStripMenuItem();
            alterarDadosToolStripMenuItem = new ToolStripMenuItem();
            alterarSenhaToolStripMenuItem = new ToolStripMenuItem();
            pictureBox2 = new PictureBox();
            menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // menu
            // 
            menu.Items.AddRange(new ToolStripItem[] { loginToolStripMenuItem, cadastroToolStripMenuItem, operaçõesToolStripMenuItem, contaToolStripMenuItem, extratoToolStripMenuItem, nomeToolStripMenuItem, configuraçõesToolStripMenuItem });
            menu.Location = new Point(0, 0);
            menu.Name = "menu";
            menu.Size = new Size(995, 24);
            menu.TabIndex = 51;
            menu.Text = "menuStrip1";
            menu.ItemClicked += menu_ItemClicked;
            // 
            // loginToolStripMenuItem
            // 
            loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            loginToolStripMenuItem.Size = new Size(49, 20);
            loginToolStripMenuItem.Text = "Login";
            loginToolStripMenuItem.Click += loginToolStripMenuItem_Click;
            // 
            // cadastroToolStripMenuItem
            // 
            cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            cadastroToolStripMenuItem.Size = new Size(66, 20);
            cadastroToolStripMenuItem.Text = "Cadastro";
            cadastroToolStripMenuItem.Click += cadastroToolStripMenuItem_Click;
            // 
            // operaçõesToolStripMenuItem
            // 
            operaçõesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { saqueToolStripMenuItem, depósitoToolStripMenuItem, transferênciaToolStripMenuItem });
            operaçõesToolStripMenuItem.Name = "operaçõesToolStripMenuItem";
            operaçõesToolStripMenuItem.Size = new Size(75, 20);
            operaçõesToolStripMenuItem.Text = "Operações";
            operaçõesToolStripMenuItem.Visible = false;
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
            transferênciaToolStripMenuItem.Click += transferênciaToolStripMenuItem_Click;
            // 
            // contaToolStripMenuItem
            // 
            contaToolStripMenuItem.Name = "contaToolStripMenuItem";
            contaToolStripMenuItem.Size = new Size(51, 20);
            contaToolStripMenuItem.Text = "Conta";
            contaToolStripMenuItem.Visible = false;
            contaToolStripMenuItem.Click += contaToolStripMenuItem_Click;
            // 
            // extratoToolStripMenuItem
            // 
            extratoToolStripMenuItem.Name = "extratoToolStripMenuItem";
            extratoToolStripMenuItem.Size = new Size(56, 20);
            extratoToolStripMenuItem.Text = "Extrato";
            extratoToolStripMenuItem.TextImageRelation = TextImageRelation.TextBeforeImage;
            extratoToolStripMenuItem.Visible = false;
            // 
            // nomeToolStripMenuItem
            // 
            nomeToolStripMenuItem.Name = "nomeToolStripMenuItem";
            nomeToolStripMenuItem.Size = new Size(52, 20);
            nomeToolStripMenuItem.Text = "Nome";
            nomeToolStripMenuItem.Visible = false;
            nomeToolStripMenuItem.Click += nomeToolStripMenuItem_Click;
            // 
            // configuraçõesToolStripMenuItem
            // 
            configuraçõesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { criarContaToolStripMenuItem, alterarContaToolStripMenuItem, alterarDadosToolStripMenuItem, alterarSenhaToolStripMenuItem });
            configuraçõesToolStripMenuItem.Name = "configuraçõesToolStripMenuItem";
            configuraçõesToolStripMenuItem.Size = new Size(96, 20);
            configuraçõesToolStripMenuItem.Text = "Configurações";
            configuraçõesToolStripMenuItem.Visible = false;
            // 
            // criarContaToolStripMenuItem
            // 
            criarContaToolStripMenuItem.Name = "criarContaToolStripMenuItem";
            criarContaToolStripMenuItem.Size = new Size(180, 22);
            criarContaToolStripMenuItem.Text = "Criar Conta";
            criarContaToolStripMenuItem.Click += criarContaToolStripMenuItem_Click;
            // 
            // alterarContaToolStripMenuItem
            // 
            alterarContaToolStripMenuItem.Name = "alterarContaToolStripMenuItem";
            alterarContaToolStripMenuItem.Size = new Size(180, 22);
            alterarContaToolStripMenuItem.Text = "Alterar Conta";
            alterarContaToolStripMenuItem.Click += alterarContaToolStripMenuItem_Click;
            // 
            // alterarDadosToolStripMenuItem
            // 
            alterarDadosToolStripMenuItem.Name = "alterarDadosToolStripMenuItem";
            alterarDadosToolStripMenuItem.Size = new Size(180, 22);
            alterarDadosToolStripMenuItem.Text = "Alterar Dados";
            alterarDadosToolStripMenuItem.Click += alterarDadosToolStripMenuItem_Click;
            // 
            // alterarSenhaToolStripMenuItem
            // 
            alterarSenhaToolStripMenuItem.Name = "alterarSenhaToolStripMenuItem";
            alterarSenhaToolStripMenuItem.Size = new Size(180, 22);
            alterarSenhaToolStripMenuItem.Text = "Alterar Senha";
            alterarSenhaToolStripMenuItem.Click += alterarSenhaToolStripMenuItem_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(688, 41);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(260, 125);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 49;
            pictureBox2.TabStop = false;
            // 
            // TelaLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(995, 478);
            Controls.Add(pictureBox2);
            Controls.Add(menu);
            MainMenuStrip = menu;
            Name = "TelaLogin";
            Text = "TelaCadastro2";
            Load += TelaLogin_Load_1;
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
        private ToolStripMenuItem nomeToolStripMenuItem;
        private ToolStripMenuItem configuraçõesToolStripMenuItem;
        private ToolStripMenuItem criarContaToolStripMenuItem;
        private ToolStripMenuItem alterarContaToolStripMenuItem;
        private ToolStripMenuItem alterarDadosToolStripMenuItem;
        private ToolStripMenuItem alterarSenhaToolStripMenuItem;
    }
}