namespace prjJucasBank
{
    partial class TelaLoginBanco
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaLoginBanco));
            txtUsuarioLogin = new TextBox();
            txtSenhaLogin = new TextBox();
            BotaoEntrar = new Button();
            btnEsqueceuSenha = new Button();
            btnCriarCadastro = new Button();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // txtUsuarioLogin
            // 
            txtUsuarioLogin.BackColor = Color.White;
            txtUsuarioLogin.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsuarioLogin.ForeColor = Color.Black;
            txtUsuarioLogin.Location = new Point(132, 82);
            txtUsuarioLogin.MaxLength = 11;
            txtUsuarioLogin.Name = "txtUsuarioLogin";
            txtUsuarioLogin.PlaceholderText = "000.000.000-00";
            txtUsuarioLogin.Size = new Size(195, 36);
            txtUsuarioLogin.TabIndex = 1;
            txtUsuarioLogin.TextAlign = HorizontalAlignment.Center;
            txtUsuarioLogin.TextChanged += caixaLogin_TextChanged;
            // 
            // txtSenhaLogin
            // 
            txtSenhaLogin.BackColor = Color.White;
            txtSenhaLogin.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            txtSenhaLogin.Location = new Point(132, 146);
            txtSenhaLogin.MaxLength = 6;
            txtSenhaLogin.Name = "txtSenhaLogin";
            txtSenhaLogin.PlaceholderText = "Insira sua senha";
            txtSenhaLogin.Size = new Size(195, 36);
            txtSenhaLogin.TabIndex = 2;
            txtSenhaLogin.TextAlign = HorizontalAlignment.Center;
            txtSenhaLogin.UseSystemPasswordChar = true;
            // 
            // BotaoEntrar
            // 
            BotaoEntrar.BackColor = Color.White;
            BotaoEntrar.Cursor = Cursors.Hand;
            BotaoEntrar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BotaoEntrar.ForeColor = Color.Black;
            BotaoEntrar.Location = new Point(180, 210);
            BotaoEntrar.Name = "BotaoEntrar";
            BotaoEntrar.Size = new Size(96, 34);
            BotaoEntrar.TabIndex = 3;
            BotaoEntrar.Text = "Entrar";
            BotaoEntrar.UseVisualStyleBackColor = false;
            BotaoEntrar.Click += BotaoEntrar_Click;
            // 
            // btnEsqueceuSenha
            // 
            btnEsqueceuSenha.BackColor = Color.White;
            btnEsqueceuSenha.Font = new Font("Lucida Bright", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnEsqueceuSenha.ForeColor = Color.Black;
            btnEsqueceuSenha.Location = new Point(106, 386);
            btnEsqueceuSenha.Name = "btnEsqueceuSenha";
            btnEsqueceuSenha.Size = new Size(221, 44);
            btnEsqueceuSenha.TabIndex = 41;
            btnEsqueceuSenha.Text = "Esqueci minha senha";
            btnEsqueceuSenha.UseVisualStyleBackColor = false;
            btnEsqueceuSenha.Click += btnEsqueceuSenha_Click;
            // 
            // btnCriarCadastro
            // 
            btnCriarCadastro.BackColor = Color.White;
            btnCriarCadastro.Font = new Font("Lucida Bright", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCriarCadastro.Location = new Point(118, 302);
            btnCriarCadastro.Name = "btnCriarCadastro";
            btnCriarCadastro.Size = new Size(195, 46);
            btnCriarCadastro.TabIndex = 42;
            btnCriarCadastro.Text = "Criar uma conta";
            btnCriarCadastro.UseVisualStyleBackColor = false;
            btnCriarCadastro.Click += btnCriarCadastro_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(818, 57);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(290, 145);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 50;
            pictureBox2.TabStop = false;
            // 
            // TelaLoginBanco
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1169, 507);
            Controls.Add(pictureBox2);
            Controls.Add(btnCriarCadastro);
            Controls.Add(btnEsqueceuSenha);
            Controls.Add(BotaoEntrar);
            Controls.Add(txtSenhaLogin);
            Controls.Add(txtUsuarioLogin);
            Name = "TelaLoginBanco";
            Text = "TelaLoginB";
            Load += TelaLoginBanco_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsuarioLogin;
        private TextBox txtSenhaLogin;
        private Button BotaoEntrar;
        private Button btnEsqueceuSenha;
        private Button btnCriarCadastro;
        private PictureBox pictureBox2;
    }
}