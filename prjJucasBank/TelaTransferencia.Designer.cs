namespace TelaTransferencia
{
    partial class TelaTransferencia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaTransferencia));
            pictureBox1 = new PictureBox();
            lblDepositoConfirmado = new Label();
            lblVoltarDeposito = new Button();
            btConfirmarDeposito = new Button();
            lblValorDeposito = new Label();
            txtValorDeposito = new TextBox();
            txtNomeDestino = new TextBox();
            lblSaldoVal = new Label();
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
            pictureBox1.Location = new Point(39, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(142, 79);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 64;
            pictureBox1.TabStop = false;
            // 
            // lblDepositoConfirmado
            // 
            lblDepositoConfirmado.AutoSize = true;
            lblDepositoConfirmado.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblDepositoConfirmado.ForeColor = Color.DarkOrchid;
            lblDepositoConfirmado.Location = new Point(791, 367);
            lblDepositoConfirmado.Name = "lblDepositoConfirmado";
            lblDepositoConfirmado.Size = new Size(293, 37);
            lblDepositoConfirmado.TabIndex = 63;
            lblDepositoConfirmado.Text = "Transferência realizada!";
            lblDepositoConfirmado.Click += lblDepositoConfirmado_Click;
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
            // btConfirmarDeposito
            // 
            btConfirmarDeposito.BackColor = Color.White;
            btConfirmarDeposito.Font = new Font("Lucida Bright", 13F, FontStyle.Regular, GraphicsUnit.Point);
            btConfirmarDeposito.ForeColor = Color.Black;
            btConfirmarDeposito.Location = new Point(779, 316);
            btConfirmarDeposito.Name = "btConfirmarDeposito";
            btConfirmarDeposito.Size = new Size(300, 48);
            btConfirmarDeposito.TabIndex = 57;
            btConfirmarDeposito.Text = "Confirmar transferência";
            btConfirmarDeposito.UseVisualStyleBackColor = false;
            btConfirmarDeposito.Click += btConfirmarDeposito_Click;
            // 
            // lblValorDeposito
            // 
            lblValorDeposito.AutoSize = true;
            lblValorDeposito.Font = new Font("Lucida Bright", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblValorDeposito.ForeColor = Color.DarkOrchid;
            lblValorDeposito.Location = new Point(663, 200);
            lblValorDeposito.Name = "lblValorDeposito";
            lblValorDeposito.Size = new Size(421, 32);
            lblValorDeposito.TabIndex = 62;
            lblValorDeposito.Text = "Insira o valor a ser transferido:";
            // 
            // txtValorDeposito
            // 
            txtValorDeposito.BackColor = Color.White;
            txtValorDeposito.Font = new Font("Lucida Bright", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtValorDeposito.Location = new Point(799, 246);
            txtValorDeposito.Name = "txtValorDeposito";
            txtValorDeposito.PlaceholderText = "R$ 0,00";
            txtValorDeposito.Size = new Size(267, 39);
            txtValorDeposito.TabIndex = 56;
            txtValorDeposito.TextAlign = HorizontalAlignment.Center;
            // 
            // txtNomeDestino
            // 
            txtNomeDestino.BackColor = Color.White;
            txtNomeDestino.Font = new Font("Lucida Bright", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtNomeDestino.Location = new Point(766, 144);
            txtNomeDestino.Name = "txtNomeDestino";
            txtNomeDestino.PlaceholderText = "CPF do usuário de destino";
            txtNomeDestino.Size = new Size(300, 28);
            txtNomeDestino.TabIndex = 54;
            txtNomeDestino.TextAlign = HorizontalAlignment.Center;
            // 
            // lblSaldoVal
            // 
            lblSaldoVal.AutoSize = true;
            lblSaldoVal.Font = new Font("Lucida Bright", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblSaldoVal.ForeColor = Color.DarkOrchid;
            lblSaldoVal.Location = new Point(231, 200);
            lblSaldoVal.Name = "lblSaldoVal";
            lblSaldoVal.Size = new Size(127, 32);
            lblSaldoVal.TabIndex = 61;
            lblSaldoVal.Text = "R$ 50,33";
            // 
            // lblSaldo
            // 
            lblSaldo.AutoSize = true;
            lblSaldo.Font = new Font("Lucida Bright", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblSaldo.ForeColor = Color.DarkOrchid;
            lblSaldo.Location = new Point(132, 200);
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
            lblDeposito.Location = new Point(207, 51);
            lblDeposito.Name = "lblDeposito";
            lblDeposito.Size = new Size(242, 39);
            lblDeposito.TabIndex = 59;
            lblDeposito.Text = "Transferência";
            // 
            // TelaTransferencia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1169, 507);
            Controls.Add(pictureBox1);
            Controls.Add(lblDepositoConfirmado);
            Controls.Add(lblVoltarDeposito);
            Controls.Add(btConfirmarDeposito);
            Controls.Add(lblValorDeposito);
            Controls.Add(txtValorDeposito);
            Controls.Add(txtNomeDestino);
            Controls.Add(lblSaldoVal);
            Controls.Add(lblSaldo);
            Controls.Add(lblDeposito);
            Name = "TelaTransferencia";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblDepositoConfirmado;
        private Button lblVoltarDeposito;
        private Button btConfirmarDeposito;
        private Label lblValorDeposito;
        private TextBox txtValorDeposito;
        private TextBox txtNomeDestino;
        private Label lblSaldoVal;
        private Label lblSaldo;
        private Label lblDeposito;
    }
}