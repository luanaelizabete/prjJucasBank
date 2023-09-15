namespace prjJucasBank
{
    partial class telaLoginBanco
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(telaLoginBanco));
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            btnEsqueceuSenha = new Button();
            btnCriarCadastro = new Button();
            lblUsuario = new Label();
            btnEntrar = new Button();
            txtSenhaLogin = new TextBox();
            txtUsuarioLogin = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.AccessibleRole = AccessibleRole.None;
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox2.BackColor = Color.Black;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(693, 127);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(315, 165);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 29;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BackColor = SystemColors.MenuText;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(612, -10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(627, 536);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 30;
            pictureBox1.TabStop = false;
            // 
            // btnEsqueceuSenha
            // 
            btnEsqueceuSenha.BackColor = Color.White;
            btnEsqueceuSenha.Font = new Font("Lucida Bright", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnEsqueceuSenha.ForeColor = Color.Black;
            btnEsqueceuSenha.Location = new Point(120, 258);
            btnEsqueceuSenha.Name = "btnEsqueceuSenha";
            btnEsqueceuSenha.Size = new Size(221, 44);
            btnEsqueceuSenha.TabIndex = 36;
            btnEsqueceuSenha.Text = "Esqueci minha senha";
            btnEsqueceuSenha.UseVisualStyleBackColor = false;
            // 
            // btnCriarCadastro
            // 
            btnCriarCadastro.BackColor = Color.White;
            btnCriarCadastro.Font = new Font("Lucida Bright", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCriarCadastro.Location = new Point(130, 380);
            btnCriarCadastro.Name = "btnCriarCadastro";
            btnCriarCadastro.Size = new Size(195, 46);
            btnCriarCadastro.TabIndex = 34;
            btnCriarCadastro.Text = "Criar uma conta";
            btnCriarCadastro.UseVisualStyleBackColor = false;
            btnCriarCadastro.Click += btnCriarCadastro_Click;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.FlatStyle = FlatStyle.Flat;
            lblUsuario.Font = new Font("Lucida Bright", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblUsuario.ForeColor = Color.White;
            lblUsuario.Location = new Point(130, 88);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(87, 23);
            lblUsuario.TabIndex = 35;
            lblUsuario.Text = "Usuário";
            // 
            // btnEntrar
            // 
            btnEntrar.BackColor = Color.White;
            btnEntrar.Cursor = Cursors.Hand;
            btnEntrar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnEntrar.ForeColor = Color.Black;
            btnEntrar.Location = new Point(181, 218);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(96, 34);
            btnEntrar.TabIndex = 33;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = false;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // txtSenhaLogin
            // 
            txtSenhaLogin.BackColor = Color.White;
            txtSenhaLogin.Font = new Font("Lucida Bright", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtSenhaLogin.Location = new Point(130, 163);
            txtSenhaLogin.MaxLength = 6;
            txtSenhaLogin.Name = "txtSenhaLogin";
            txtSenhaLogin.PlaceholderText = "Insira sua senha";
            txtSenhaLogin.Size = new Size(195, 31);
            txtSenhaLogin.TabIndex = 32;
            txtSenhaLogin.TextAlign = HorizontalAlignment.Center;
            txtSenhaLogin.UseSystemPasswordChar = true;
            // 
            // txtUsuarioLogin
            // 
            txtUsuarioLogin.BackColor = Color.White;
            txtUsuarioLogin.Font = new Font("Lucida Bright", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsuarioLogin.ForeColor = Color.Black;
            txtUsuarioLogin.Location = new Point(130, 114);
            txtUsuarioLogin.MaxLength = 11;
            txtUsuarioLogin.Name = "txtUsuarioLogin";
            txtUsuarioLogin.PlaceholderText = "000.000.000-00";
            txtUsuarioLogin.Size = new Size(195, 31);
            txtUsuarioLogin.TabIndex = 31;
            txtUsuarioLogin.TextAlign = HorizontalAlignment.Center;
            // 
            // telaLoginBanco
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkOrchid;
            ClientSize = new Size(1169, 507);
            Controls.Add(btnEsqueceuSenha);
            Controls.Add(btnCriarCadastro);
            Controls.Add(lblUsuario);
            Controls.Add(btnEntrar);
            Controls.Add(txtSenhaLogin);
            Controls.Add(txtUsuarioLogin);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Font = new Font("Lucida Bright", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "telaLoginBanco";
            Text = "TelaLoginBanco";
            Load += TelaLoginBanco_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Button btnEsqueceuSenha;
        private Button btnCriarCadastro;
        private Label lblUsuario;
        private Button btnEntrar;
        private TextBox txtSenhaLogin;
        private TextBox txtUsuarioLogin;
    }
}