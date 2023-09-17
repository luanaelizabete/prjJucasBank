namespace prjJucasBank
{
    partial class TelaAlterarConta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaAlterarConta));
            btAlterarConta = new Button();
            txtSenhaContaAlt = new TextBox();
            label1 = new Label();
            cbContas = new ComboBox();
            lblAlterarContas = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btAlterarConta
            // 
            btAlterarConta.Font = new Font("Lucida Bright", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btAlterarConta.Location = new Point(630, 311);
            btAlterarConta.Name = "btAlterarConta";
            btAlterarConta.Size = new Size(90, 28);
            btAlterarConta.TabIndex = 45;
            btAlterarConta.Text = "Alterar";
            btAlterarConta.UseVisualStyleBackColor = true;
            // 
            // txtSenhaContaAlt
            // 
            txtSenhaContaAlt.Font = new Font("Lucida Bright", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtSenhaContaAlt.Location = new Point(630, 249);
            txtSenhaContaAlt.MaxLength = 6;
            txtSenhaContaAlt.Name = "txtSenhaContaAlt";
            txtSenhaContaAlt.Size = new Size(90, 23);
            txtSenhaContaAlt.TabIndex = 43;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Bright", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkOrchid;
            label1.Location = new Point(436, 249);
            label1.Name = "label1";
            label1.Size = new Size(164, 23);
            label1.TabIndex = 42;
            label1.Text = "Senha da conta:";
            // 
            // cbContas
            // 
            cbContas.Font = new Font("Lucida Bright", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            cbContas.FormattingEnabled = true;
            cbContas.Location = new Point(630, 162);
            cbContas.Name = "cbContas";
            cbContas.Size = new Size(90, 23);
            cbContas.TabIndex = 41;
            // 
            // lblAlterarContas
            // 
            lblAlterarContas.AutoSize = true;
            lblAlterarContas.Font = new Font("Lucida Bright", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblAlterarContas.ForeColor = Color.DarkOrchid;
            lblAlterarContas.Location = new Point(390, 160);
            lblAlterarContas.Name = "lblAlterarContas";
            lblAlterarContas.Size = new Size(210, 23);
            lblAlterarContas.TabIndex = 40;
            lblAlterarContas.Text = "Alterar para a conta:";
            // 
            // pictureBox1
            // 
            pictureBox1.AccessibleRole = AccessibleRole.None;
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BackColor = Color.Black;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(28, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(146, 77);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 51;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Bright", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkOrchid;
            label2.Location = new Point(191, 49);
            label2.Name = "label2";
            label2.Size = new Size(220, 32);
            label2.TabIndex = 52;
            label2.Text = "Trocar de conta";
            // 
            // TelaAlterarConta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1169, 507);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(btAlterarConta);
            Controls.Add(txtSenhaContaAlt);
            Controls.Add(label1);
            Controls.Add(cbContas);
            Controls.Add(lblAlterarContas);
            Name = "TelaAlterarConta";
            Text = "TelaAlterarConta";
            Load += TelaAlterarConta_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btAlterarConta;
        private TextBox txtSenhaContaAlt;
        private Label label1;
        private ComboBox cbContas;
        private Label lblAlterarContas;
        private PictureBox pictureBox1;
        private Label label2;
    }
}