namespace prjJucasBank
{
    partial class TelaSaque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaSaque));
            pictureBox1 = new PictureBox();
            lblDepositoConfirmado = new Label();
            lblVoltarDeposito = new Button();
            btConfirmarSaque = new Button();
            lblValorDeposito = new Label();
            txtValorDeposito = new TextBox();
            txtIdentificacao = new TextBox();
            txtNomeDestino = new TextBox();
            txtNumConta = new TextBox();
            txtAgencia = new TextBox();
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
            pictureBox1.Location = new Point(101, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(146, 83);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 64;
            pictureBox1.TabStop = false;
            // 
            // lblDepositoConfirmado
            // 
            lblDepositoConfirmado.AutoSize = true;
            lblDepositoConfirmado.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblDepositoConfirmado.ForeColor = Color.DarkOrchid;
            lblDepositoConfirmado.Location = new Point(918, 376);
            lblDepositoConfirmado.Name = "lblDepositoConfirmado";
            lblDepositoConfirmado.Size = new Size(214, 37);
            lblDepositoConfirmado.TabIndex = 63;
            lblDepositoConfirmado.Text = "Saque realizado!";
            lblDepositoConfirmado.Click += lblDepositoConfirmado_Click;
            // 
            // lblVoltarDeposito
            // 
            lblVoltarDeposito.BackColor = Color.White;
            lblVoltarDeposito.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblVoltarDeposito.Location = new Point(1028, 493);
            lblVoltarDeposito.Name = "lblVoltarDeposito";
            lblVoltarDeposito.Size = new Size(133, 42);
            lblVoltarDeposito.TabIndex = 58;
            lblVoltarDeposito.Text = "Voltar";
            lblVoltarDeposito.UseVisualStyleBackColor = false;
            lblVoltarDeposito.Click += lblVoltarDeposito_Click;
            // 
            // btConfirmarSaque
            // 
            btConfirmarSaque.BackColor = Color.White;
            btConfirmarSaque.Font = new Font("Lucida Bright", 13F, FontStyle.Regular, GraphicsUnit.Point);
            btConfirmarSaque.ForeColor = Color.Black;
            btConfirmarSaque.Location = new Point(861, 325);
            btConfirmarSaque.Name = "btConfirmarSaque";
            btConfirmarSaque.Size = new Size(300, 48);
            btConfirmarSaque.TabIndex = 57;
            btConfirmarSaque.Text = "Confirmar Saque";
            btConfirmarSaque.UseVisualStyleBackColor = false;
            btConfirmarSaque.Click += btConfirmarSaque_Click;
            // 
            // lblValorDeposito
            // 
            lblValorDeposito.AutoSize = true;
            lblValorDeposito.Font = new Font("Lucida Bright", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblValorDeposito.ForeColor = Color.DarkOrchid;
            lblValorDeposito.Location = new Point(16, 227);
            lblValorDeposito.Name = "lblValorDeposito";
            lblValorDeposito.Size = new Size(363, 32);
            lblValorDeposito.TabIndex = 62;
            lblValorDeposito.Text = "Insira o valor a ser sacado:";
            // 
            // txtValorDeposito
            // 
            txtValorDeposito.BackColor = Color.White;
            txtValorDeposito.Font = new Font("Lucida Bright", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtValorDeposito.Location = new Point(42, 277);
            txtValorDeposito.Name = "txtValorDeposito";
            txtValorDeposito.PlaceholderText = "R$ 0,00";
            txtValorDeposito.Size = new Size(267, 39);
            txtValorDeposito.TabIndex = 56;
            txtValorDeposito.TextAlign = HorizontalAlignment.Center;
            // 
            // txtIdentificacao
            // 
            txtIdentificacao.BackColor = Color.White;
            txtIdentificacao.Font = new Font("Lucida Bright", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtIdentificacao.Location = new Point(861, 263);
            txtIdentificacao.Name = "txtIdentificacao";
            txtIdentificacao.PlaceholderText = "Número de telefone";
            txtIdentificacao.Size = new Size(300, 28);
            txtIdentificacao.TabIndex = 55;
            txtIdentificacao.TextAlign = HorizontalAlignment.Center;
            // 
            // txtNomeDestino
            // 
            txtNomeDestino.BackColor = Color.White;
            txtNomeDestino.Font = new Font("Lucida Bright", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtNomeDestino.Location = new Point(861, 106);
            txtNomeDestino.Name = "txtNomeDestino";
            txtNomeDestino.PlaceholderText = "Nome do usuário";
            txtNomeDestino.Size = new Size(300, 28);
            txtNomeDestino.TabIndex = 54;
            txtNomeDestino.TextAlign = HorizontalAlignment.Center;
            // 
            // txtNumConta
            // 
            txtNumConta.BackColor = Color.White;
            txtNumConta.Font = new Font("Lucida Bright", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtNumConta.Location = new Point(861, 212);
            txtNumConta.Name = "txtNumConta";
            txtNumConta.PlaceholderText = "Seu e-mail";
            txtNumConta.Size = new Size(300, 28);
            txtNumConta.TabIndex = 53;
            txtNumConta.TextAlign = HorizontalAlignment.Center;
            // 
            // txtAgencia
            // 
            txtAgencia.BackColor = Color.White;
            txtAgencia.Font = new Font("Lucida Bright", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtAgencia.Location = new Point(861, 164);
            txtAgencia.Name = "txtAgencia";
            txtAgencia.PlaceholderText = "Seu CPF";
            txtAgencia.Size = new Size(300, 28);
            txtAgencia.TabIndex = 52;
            txtAgencia.TextAlign = HorizontalAlignment.Center;
            // 
            // lblSaldoVal
            // 
            lblSaldoVal.AutoSize = true;
            lblSaldoVal.Font = new Font("Lucida Bright", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblSaldoVal.ForeColor = Color.DarkOrchid;
            lblSaldoVal.Location = new Point(138, 164);
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
            lblSaldo.Location = new Point(39, 164);
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
            lblDeposito.Location = new Point(269, 48);
            lblDeposito.Name = "lblDeposito";
            lblDeposito.Size = new Size(115, 39);
            lblDeposito.TabIndex = 59;
            lblDeposito.Text = "Saque";
            // 
            // TelaSaque
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1169, 507);
            Controls.Add(pictureBox1);
            Controls.Add(lblDepositoConfirmado);
            Controls.Add(lblVoltarDeposito);
            Controls.Add(btConfirmarSaque);
            Controls.Add(lblValorDeposito);
            Controls.Add(txtValorDeposito);
            Controls.Add(txtIdentificacao);
            Controls.Add(txtNomeDestino);
            Controls.Add(txtNumConta);
            Controls.Add(txtAgencia);
            Controls.Add(lblSaldoVal);
            Controls.Add(lblSaldo);
            Controls.Add(lblDeposito);
            Name = "TelaSaque";
            Text = "TelaSaque1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblDepositoConfirmado;
        private Button lblVoltarDeposito;
        private Button btConfirmarSaque;
        private Label lblValorDeposito;
        private TextBox txtValorDeposito;
        private TextBox txtIdentificacao;
        private TextBox txtNomeDestino;
        private TextBox txtNumConta;
        private TextBox txtAgencia;
        private Label lblSaldoVal;
        private Label lblSaldo;
        private Label lblDeposito;
    }
}