namespace TelaDeposito
{
    partial class TelaDeposito
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaDeposito));
            pictureBox1 = new PictureBox();
            lblDepositoConfirmado = new Label();
            lblVoltarDeposito = new Button();
            btnConfirmarDeposito = new Button();
            lblValorDeposito = new Label();
            txtvalorDeposito = new TextBox();
            txtNome = new TextBox();
            txtRecebedor = new TextBox();
            txtContaDestino = new TextBox();
            txtAgenciaDestino = new TextBox();
            lblValorSaldo = new Label();
            lblSaldo = new Label();
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
            pictureBox1.Location = new Point(86, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(153, 91);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 64;
            pictureBox1.TabStop = false;
            // 
            // lblDepositoConfirmado
            // 
            lblDepositoConfirmado.AutoSize = true;
            lblDepositoConfirmado.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblDepositoConfirmado.ForeColor = Color.DarkOrchid;
            lblDepositoConfirmado.Location = new Point(833, 330);
            lblDepositoConfirmado.Name = "lblDepositoConfirmado";
            lblDepositoConfirmado.Size = new Size(249, 37);
            lblDepositoConfirmado.TabIndex = 63;
            lblDepositoConfirmado.Text = "Depósito realizado!";
            // 
            // lblVoltarDeposito
            // 
            lblVoltarDeposito.BackColor = Color.White;
            lblVoltarDeposito.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblVoltarDeposito.Location = new Point(1024, 453);
            lblVoltarDeposito.Name = "lblVoltarDeposito";
            lblVoltarDeposito.Size = new Size(133, 42);
            lblVoltarDeposito.TabIndex = 58;
            lblVoltarDeposito.Text = "Voltar";
            lblVoltarDeposito.UseVisualStyleBackColor = false;
            // 
            // btnConfirmarDeposito
            // 
            btnConfirmarDeposito.BackColor = Color.White;
            btnConfirmarDeposito.Font = new Font("Lucida Bright", 13F, FontStyle.Regular, GraphicsUnit.Point);
            btnConfirmarDeposito.ForeColor = Color.Black;
            btnConfirmarDeposito.Location = new Point(812, 279);
            btnConfirmarDeposito.Name = "btnConfirmarDeposito";
            btnConfirmarDeposito.Size = new Size(300, 48);
            btnConfirmarDeposito.TabIndex = 57;
            btnConfirmarDeposito.Text = "Confirmar depósito";
            btnConfirmarDeposito.UseVisualStyleBackColor = false;
            btnConfirmarDeposito.Click += btnConfirmarDeposito_Click;
            // 
            // lblValorDeposito
            // 
            lblValorDeposito.AutoSize = true;
            lblValorDeposito.Font = new Font("Lucida Bright", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblValorDeposito.ForeColor = Color.DarkOrchid;
            lblValorDeposito.Location = new Point(23, 226);
            lblValorDeposito.Name = "lblValorDeposito";
            lblValorDeposito.Size = new Size(419, 32);
            lblValorDeposito.TabIndex = 62;
            lblValorDeposito.Text = "Insira o valor a ser depositado:";
            // 
            // txtvalorDeposito
            // 
            txtvalorDeposito.BackColor = Color.White;
            txtvalorDeposito.Font = new Font("Lucida Bright", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtvalorDeposito.Location = new Point(49, 276);
            txtvalorDeposito.Name = "txtvalorDeposito";
            txtvalorDeposito.PlaceholderText = "R$ 0,00";
            txtvalorDeposito.Size = new Size(267, 39);
            txtvalorDeposito.TabIndex = 56;
            txtvalorDeposito.TextAlign = HorizontalAlignment.Center;
            // 
            // txtNome
            // 
            txtNome.BackColor = Color.White;
            txtNome.Font = new Font("Lucida Bright", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtNome.Location = new Point(812, 217);
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "Seu nome";
            txtNome.Size = new Size(300, 28);
            txtNome.TabIndex = 55;
            txtNome.TextAlign = HorizontalAlignment.Center;
            // 
            // txtRecebedor
            // 
            txtRecebedor.BackColor = Color.White;
            txtRecebedor.Font = new Font("Lucida Bright", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtRecebedor.Location = new Point(812, 60);
            txtRecebedor.Name = "txtRecebedor";
            txtRecebedor.PlaceholderText = "Quem vai receber ?";
            txtRecebedor.Size = new Size(300, 28);
            txtRecebedor.TabIndex = 54;
            txtRecebedor.TextAlign = HorizontalAlignment.Center;
            // 
            // txtContaDestino
            // 
            txtContaDestino.BackColor = Color.White;
            txtContaDestino.Font = new Font("Lucida Bright", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtContaDestino.Location = new Point(812, 166);
            txtContaDestino.Name = "txtContaDestino";
            txtContaDestino.PlaceholderText = "Conta de destino";
            txtContaDestino.Size = new Size(300, 28);
            txtContaDestino.TabIndex = 53;
            txtContaDestino.TextAlign = HorizontalAlignment.Center;
            // 
            // txtAgenciaDestino
            // 
            txtAgenciaDestino.BackColor = Color.White;
            txtAgenciaDestino.Font = new Font("Lucida Bright", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtAgenciaDestino.Location = new Point(812, 118);
            txtAgenciaDestino.Name = "txtAgenciaDestino";
            txtAgenciaDestino.PlaceholderText = "Agência de destino";
            txtAgenciaDestino.Size = new Size(300, 28);
            txtAgenciaDestino.TabIndex = 52;
            txtAgenciaDestino.TextAlign = HorizontalAlignment.Center;
            // 
            // lblValorSaldo
            // 
            lblValorSaldo.AutoSize = true;
            lblValorSaldo.Font = new Font("Lucida Bright", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblValorSaldo.ForeColor = Color.DarkOrchid;
            lblValorSaldo.Location = new Point(145, 163);
            lblValorSaldo.Name = "lblValorSaldo";
            lblValorSaldo.Size = new Size(127, 32);
            lblValorSaldo.TabIndex = 61;
            lblValorSaldo.Text = "R$ 50,33";
            // 
            // lblSaldo
            // 
            lblSaldo.AutoSize = true;
            lblSaldo.Font = new Font("Lucida Bright", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblSaldo.ForeColor = Color.DarkOrchid;
            lblSaldo.Location = new Point(46, 163);
            lblSaldo.Name = "lblSaldo";
            lblSaldo.Size = new Size(93, 32);
            lblSaldo.TabIndex = 60;
            lblSaldo.Text = "Saldo:";
            // 
            // lblDeposito
            // 
            lblDeposito.AutoSize = true;
            lblDeposito.Font = new Font("Lucida Bright", 25.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblDeposito.ForeColor = Color.DarkOrchid;
            lblDeposito.Location = new Point(260, 49);
            lblDeposito.Name = "lblDeposito";
            lblDeposito.Size = new Size(166, 39);
            lblDeposito.TabIndex = 59;
            lblDeposito.Text = "Depósito";
            // 
            // TelaDeposito
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1169, 507);
            Controls.Add(pictureBox1);
            Controls.Add(lblDepositoConfirmado);
            Controls.Add(lblVoltarDeposito);
            Controls.Add(btnConfirmarDeposito);
            Controls.Add(lblValorDeposito);
            Controls.Add(txtvalorDeposito);
            Controls.Add(txtNome);
            Controls.Add(txtRecebedor);
            Controls.Add(txtContaDestino);
            Controls.Add(txtAgenciaDestino);
            Controls.Add(lblValorSaldo);
            Controls.Add(lblSaldo);
            Controls.Add(lblDeposito);
            Name = "TelaDeposito";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblDepositoConfirmado;
        private Button lblVoltarDeposito;
        private Button btnConfirmarDeposito;
        private Label lblValorDeposito;
        private TextBox txtvalorDeposito;
        private TextBox txtNome;
        private TextBox txtRecebedor;
        private TextBox txtContaDestino;
        private TextBox txtAgenciaDestino;
        private Label lblValorSaldo;
        private Label lblSaldo;
        private Label lblDeposito;
    }
}