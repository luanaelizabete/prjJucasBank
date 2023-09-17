namespace prjJucasBank
{
    partial class TelaAlterarSenha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaAlterarSenha));
            txtsenhaAtual = new TextBox();
            btnSalvar = new Button();
            txtconfirmeNovaSenha = new TextBox();
            txtnovaSenha = new TextBox();
            lblAlterarSenha = new Label();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // txtsenhaAtual
            // 
            txtsenhaAtual.Font = new Font("Lucida Bright", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtsenhaAtual.Location = new Point(505, 159);
            txtsenhaAtual.Name = "txtsenhaAtual";
            txtsenhaAtual.PlaceholderText = "Digite sua senha atual";
            txtsenhaAtual.Size = new Size(300, 26);
            txtsenhaAtual.TabIndex = 42;
            txtsenhaAtual.TextAlign = HorizontalAlignment.Center;
            // 
            // btnSalvar
            // 
            btnSalvar.Font = new Font("Lucida Bright", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnSalvar.Location = new Point(563, 351);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(175, 31);
            btnSalvar.TabIndex = 41;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // txtconfirmeNovaSenha
            // 
            txtconfirmeNovaSenha.Font = new Font("Lucida Bright", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtconfirmeNovaSenha.Location = new Point(505, 291);
            txtconfirmeNovaSenha.Name = "txtconfirmeNovaSenha";
            txtconfirmeNovaSenha.PlaceholderText = "Confirme sua nova senha";
            txtconfirmeNovaSenha.Size = new Size(300, 26);
            txtconfirmeNovaSenha.TabIndex = 40;
            txtconfirmeNovaSenha.TextAlign = HorizontalAlignment.Center;
            // 
            // txtnovaSenha
            // 
            txtnovaSenha.Font = new Font("Lucida Bright", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtnovaSenha.Location = new Point(505, 250);
            txtnovaSenha.Name = "txtnovaSenha";
            txtnovaSenha.PlaceholderText = "Nova senha";
            txtnovaSenha.Size = new Size(300, 26);
            txtnovaSenha.TabIndex = 39;
            txtnovaSenha.TextAlign = HorizontalAlignment.Center;
            // 
            // lblAlterarSenha
            // 
            lblAlterarSenha.AutoSize = true;
            lblAlterarSenha.Font = new Font("Lucida Bright", 24.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblAlterarSenha.ForeColor = Color.DarkOrchid;
            lblAlterarSenha.Location = new Point(201, 31);
            lblAlterarSenha.Name = "lblAlterarSenha";
            lblAlterarSenha.Size = new Size(283, 37);
            lblAlterarSenha.TabIndex = 38;
            lblAlterarSenha.Text = "Altere sua senha";
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(36, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(159, 93);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 50;
            pictureBox2.TabStop = false;
            // 
            // TelaAlterarSenha
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1169, 507);
            Controls.Add(pictureBox2);
            Controls.Add(txtsenhaAtual);
            Controls.Add(btnSalvar);
            Controls.Add(txtconfirmeNovaSenha);
            Controls.Add(txtnovaSenha);
            Controls.Add(lblAlterarSenha);
            Name = "TelaAlterarSenha";
            Text = "TelaAlterarSenha";
            Load += TelaAlterarSenha_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtsenhaAtual;
        private Button btnSalvar;
        private TextBox txtconfirmeNovaSenha;
        private TextBox txtnovaSenha;
        private Label lblAlterarSenha;
        private PictureBox pictureBox2;
    }
}