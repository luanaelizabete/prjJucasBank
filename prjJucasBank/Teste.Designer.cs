namespace prjJucasBank
{
    partial class Teste
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Teste));
            btnesconderSaldo = new Button();
            btnverSaldo = new Button();
            btnSaque = new Button();
            lblTotalSaldo = new Label();
            txtvalorDeposito = new TextBox();
            btnDepositar = new Button();
            pictureBox2 = new PictureBox();
            lblUsuario = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnesconderSaldo
            // 
            btnesconderSaldo.Font = new Font("Lucida Bright", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnesconderSaldo.Location = new Point(744, 193);
            btnesconderSaldo.Name = "btnesconderSaldo";
            btnesconderSaldo.Size = new Size(199, 39);
            btnesconderSaldo.TabIndex = 13;
            btnesconderSaldo.Text = "Esconder Saldo";
            btnesconderSaldo.UseVisualStyleBackColor = true;
            btnesconderSaldo.Click += btnEsconderSaldo_Click;
            // 
            // btnverSaldo
            // 
            btnverSaldo.Font = new Font("Lucida Bright", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnverSaldo.Location = new Point(305, 193);
            btnverSaldo.Name = "btnverSaldo";
            btnverSaldo.Size = new Size(179, 39);
            btnverSaldo.TabIndex = 12;
            btnverSaldo.Text = "Verificar Saldo";
            btnverSaldo.UseVisualStyleBackColor = true;
            btnverSaldo.Click += btnVerSaldo_Click;
            // 
            // btnSaque
            // 
            btnSaque.Font = new Font("Lucida Bright", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSaque.Location = new Point(305, 301);
            btnSaque.Name = "btnSaque";
            btnSaque.Size = new Size(179, 42);
            btnSaque.TabIndex = 11;
            btnSaque.Text = "Sacar";
            btnSaque.UseVisualStyleBackColor = true;
            btnSaque.Click += btnSaque_Click;
            // 
            // lblTotalSaldo
            // 
            lblTotalSaldo.AutoSize = true;
            lblTotalSaldo.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotalSaldo.Location = new Point(575, 401);
            lblTotalSaldo.Name = "lblTotalSaldo";
            lblTotalSaldo.Size = new Size(0, 25);
            lblTotalSaldo.TabIndex = 10;
            // 
            // txtvalorDeposito
            // 
            txtvalorDeposito.Font = new Font("Lucida Bright", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtvalorDeposito.Location = new Point(519, 193);
            txtvalorDeposito.Name = "txtvalorDeposito";
            txtvalorDeposito.PlaceholderText = "0,00";
            txtvalorDeposito.Size = new Size(185, 39);
            txtvalorDeposito.TabIndex = 9;
            txtvalorDeposito.TextChanged += txtVlrDpst_TextChanged;
            // 
            // btnDepositar
            // 
            btnDepositar.Font = new Font("Lucida Bright", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnDepositar.Location = new Point(744, 301);
            btnDepositar.Name = "btnDepositar";
            btnDepositar.Size = new Size(199, 42);
            btnDepositar.TabIndex = 8;
            btnDepositar.Text = "Depositar";
            btnDepositar.UseVisualStyleBackColor = true;
            btnDepositar.Click += btnDepositar_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.AccessibleRole = AccessibleRole.None;
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox2.BackColor = Color.Black;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(58, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(138, 91);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 30;
            pictureBox2.TabStop = false;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.FlatStyle = FlatStyle.Flat;
            lblUsuario.Font = new Font("Lucida Bright", 25.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblUsuario.ForeColor = Color.DarkOrchid;
            lblUsuario.Location = new Point(202, 36);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(174, 39);
            lblUsuario.TabIndex = 36;
            lblUsuario.Text = "Testando";
            // 
            // Teste
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1169, 507);
            Controls.Add(lblUsuario);
            Controls.Add(pictureBox2);
            Controls.Add(btnesconderSaldo);
            Controls.Add(btnverSaldo);
            Controls.Add(btnSaque);
            Controls.Add(lblTotalSaldo);
            Controls.Add(txtvalorDeposito);
            Controls.Add(btnDepositar);
            Name = "Teste";
            Text = "Teste";
            Load += Teste_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnesconderSaldo;
        private Button btnverSaldo;
        private Button btnSaque;
        private Label lblTotalSaldo;
        private TextBox txtvalorDeposito;
        private Button btnDepositar;
        private PictureBox pictureBox2;
        private Label lblUsuario;
    }
}