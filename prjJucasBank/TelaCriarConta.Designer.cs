namespace prjJucasBank
{
    partial class TelaCriarConta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaCriarConta));
            pictureBox1 = new PictureBox();
            btnCriarConta = new Button();
            lblPrimDeposito = new Label();
            txtvalorDeposito = new TextBox();
            txtContaSenha = new TextBox();
            txtConfContaSenha = new TextBox();
            lblValorMin = new Label();
            lblDeposito = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.AccessibleRole = AccessibleRole.None;
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BackColor = Color.Black;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(80, 17);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(153, 91);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 77;
            pictureBox1.TabStop = false;
            // 
            // btnCriarConta
            // 
            btnCriarConta.BackColor = Color.White;
            btnCriarConta.Font = new Font("Lucida Bright", 13F, FontStyle.Regular, GraphicsUnit.Point);
            btnCriarConta.ForeColor = Color.Black;
            btnCriarConta.Location = new Point(591, 366);
            btnCriarConta.Name = "btnCriarConta";
            btnCriarConta.Size = new Size(141, 36);
            btnCriarConta.TabIndex = 70;
            btnCriarConta.Text = "Criar conta";
            btnCriarConta.UseVisualStyleBackColor = false;
            btnCriarConta.Click += btnCriarConta_Click;
            // 
            // lblPrimDeposito
            // 
            lblPrimDeposito.AutoSize = true;
            lblPrimDeposito.Font = new Font("Lucida Bright", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrimDeposito.ForeColor = Color.DarkOrchid;
            lblPrimDeposito.Location = new Point(379, 130);
            lblPrimDeposito.Name = "lblPrimDeposito";
            lblPrimDeposito.Size = new Size(533, 32);
            lblPrimDeposito.TabIndex = 75;
            lblPrimDeposito.Text = "Insira o valor de seu primeiro depósito:";
            // 
            // txtvalorDeposito
            // 
            txtvalorDeposito.BackColor = Color.White;
            txtvalorDeposito.Font = new Font("Lucida Bright", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtvalorDeposito.Location = new Point(557, 211);
            txtvalorDeposito.Name = "txtvalorDeposito";
            txtvalorDeposito.PlaceholderText = "R$ 0,00";
            txtvalorDeposito.Size = new Size(192, 39);
            txtvalorDeposito.TabIndex = 69;
            txtvalorDeposito.TextAlign = HorizontalAlignment.Center;
            // 
            // txtContaSenha
            // 
            txtContaSenha.BackColor = Color.White;
            txtContaSenha.Font = new Font("Lucida Bright", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtContaSenha.Location = new Point(504, 258);
            txtContaSenha.Name = "txtContaSenha";
            txtContaSenha.PlaceholderText = "Crie a senha da sua conta";
            txtContaSenha.Size = new Size(300, 28);
            txtContaSenha.TabIndex = 67;
            txtContaSenha.TextAlign = HorizontalAlignment.Center;
            // 
            // txtConfContaSenha
            // 
            txtConfContaSenha.BackColor = Color.White;
            txtConfContaSenha.Font = new Font("Lucida Bright", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtConfContaSenha.Location = new Point(504, 308);
            txtConfContaSenha.Name = "txtConfContaSenha";
            txtConfContaSenha.PlaceholderText = "Confirme sua senha";
            txtConfContaSenha.Size = new Size(300, 28);
            txtConfContaSenha.TabIndex = 65;
            txtConfContaSenha.TextAlign = HorizontalAlignment.Center;
            // 
            // lblValorMin
            // 
            lblValorMin.AutoSize = true;
            lblValorMin.Font = new Font("Lucida Bright", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblValorMin.ForeColor = Color.DarkOrchid;
            lblValorMin.Location = new Point(498, 175);
            lblValorMin.Name = "lblValorMin";
            lblValorMin.Size = new Size(310, 32);
            lblValorMin.TabIndex = 74;
            lblValorMin.Text = "(valor mínimo R$1,00)";
            // 
            // lblDeposito
            // 
            lblDeposito.AutoSize = true;
            lblDeposito.Font = new Font("Lucida Bright", 25.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblDeposito.ForeColor = Color.DarkOrchid;
            lblDeposito.Location = new Point(254, 43);
            lblDeposito.Name = "lblDeposito";
            lblDeposito.Size = new Size(292, 39);
            lblDeposito.TabIndex = 72;
            lblDeposito.Text = "Criação de conta";
            // 
            // TelaCriarConta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1169, 507);
            Controls.Add(pictureBox1);
            Controls.Add(btnCriarConta);
            Controls.Add(lblPrimDeposito);
            Controls.Add(txtvalorDeposito);
            Controls.Add(txtContaSenha);
            Controls.Add(txtConfContaSenha);
            Controls.Add(lblValorMin);
            Controls.Add(lblDeposito);
            Name = "TelaCriarConta";
            Text = "TelaCriarConta";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnCriarConta;
        private Label lblPrimDeposito;
        private TextBox txtvalorDeposito;
        private TextBox txtContaSenha;
        private TextBox txtConfContaSenha;
        private Label lblValorMin;
        private Label lblDeposito;
    }
}