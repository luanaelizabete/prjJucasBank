namespace TelaPagamento
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            lblDepositoConfirmado = new Label();
            lblVoltarDeposito = new Button();
            btConfirmarDeposito = new Button();
            lblDeposito = new Label();
            lblValorDeposito = new Label();
            txtValorDeposito = new TextBox();
            lblSaldoVal = new Label();
            lblSaldo = new Label();
            txtIdentificacaoPag = new TextBox();
            txtNomeDestinoPag = new TextBox();
            txtNumContaPag = new TextBox();
            txtCodBarrasPag = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.AccessibleRole = AccessibleRole.None;
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BackColor = Color.Black;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(54, 19);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(146, 83);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 74;
            pictureBox1.TabStop = false;
            // 
            // lblDepositoConfirmado
            // 
            lblDepositoConfirmado.AutoSize = true;
            lblDepositoConfirmado.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblDepositoConfirmado.ForeColor = Color.DarkOrchid;
            lblDepositoConfirmado.Location = new Point(748, 360);
            lblDepositoConfirmado.Name = "lblDepositoConfirmado";
            lblDepositoConfirmado.Size = new Size(276, 37);
            lblDepositoConfirmado.TabIndex = 73;
            lblDepositoConfirmado.Text = "Pagamento realizado!";
            // 
            // lblVoltarDeposito
            // 
            lblVoltarDeposito.BackColor = Color.White;
            lblVoltarDeposito.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblVoltarDeposito.Location = new Point(981, 446);
            lblVoltarDeposito.Name = "lblVoltarDeposito";
            lblVoltarDeposito.Size = new Size(133, 42);
            lblVoltarDeposito.TabIndex = 68;
            lblVoltarDeposito.Text = "Voltar";
            lblVoltarDeposito.UseVisualStyleBackColor = false;
            // 
            // btConfirmarDeposito
            // 
            btConfirmarDeposito.BackColor = Color.White;
            btConfirmarDeposito.Font = new Font("Lucida Bright", 13F, FontStyle.Regular, GraphicsUnit.Point);
            btConfirmarDeposito.ForeColor = Color.Black;
            btConfirmarDeposito.Location = new Point(736, 309);
            btConfirmarDeposito.Name = "btConfirmarDeposito";
            btConfirmarDeposito.Size = new Size(300, 48);
            btConfirmarDeposito.TabIndex = 67;
            btConfirmarDeposito.Text = "Confirmar pagamento";
            btConfirmarDeposito.UseVisualStyleBackColor = false;
            // 
            // lblDeposito
            // 
            lblDeposito.AutoSize = true;
            lblDeposito.Font = new Font("Lucida Bright", 25.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblDeposito.ForeColor = Color.DarkOrchid;
            lblDeposito.Location = new Point(222, 44);
            lblDeposito.Name = "lblDeposito";
            lblDeposito.Size = new Size(214, 39);
            lblDeposito.TabIndex = 69;
            lblDeposito.Text = "Pagamentos";
            // 
            // lblValorDeposito
            // 
            lblValorDeposito.AutoSize = true;
            lblValorDeposito.Font = new Font("Lucida Bright", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblValorDeposito.ForeColor = Color.DarkOrchid;
            lblValorDeposito.Location = new Point(31, 225);
            lblValorDeposito.Name = "lblValorDeposito";
            lblValorDeposito.Size = new Size(337, 32);
            lblValorDeposito.TabIndex = 78;
            lblValorDeposito.Text = "Insira o valor a ser pago:";
            // 
            // txtValorDeposito
            // 
            txtValorDeposito.BackColor = Color.White;
            txtValorDeposito.Font = new Font("Lucida Bright", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtValorDeposito.Location = new Point(57, 275);
            txtValorDeposito.Name = "txtValorDeposito";
            txtValorDeposito.PlaceholderText = "R$ 0,00";
            txtValorDeposito.Size = new Size(267, 39);
            txtValorDeposito.TabIndex = 75;
            txtValorDeposito.TextAlign = HorizontalAlignment.Center;
            // 
            // lblSaldoVal
            // 
            lblSaldoVal.AutoSize = true;
            lblSaldoVal.Font = new Font("Lucida Bright", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblSaldoVal.ForeColor = Color.DarkOrchid;
            lblSaldoVal.Location = new Point(153, 162);
            lblSaldoVal.Name = "lblSaldoVal";
            lblSaldoVal.Size = new Size(127, 32);
            lblSaldoVal.TabIndex = 77;
            lblSaldoVal.Text = "R$ 50,33";
            // 
            // lblSaldo
            // 
            lblSaldo.AutoSize = true;
            lblSaldo.Font = new Font("Lucida Bright", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblSaldo.ForeColor = Color.DarkOrchid;
            lblSaldo.Location = new Point(54, 162);
            lblSaldo.Name = "lblSaldo";
            lblSaldo.Size = new Size(93, 32);
            lblSaldo.TabIndex = 76;
            lblSaldo.Text = "Saldo:";
            // 
            // txtIdentificacaoPag
            // 
            txtIdentificacaoPag.BackColor = Color.White;
            txtIdentificacaoPag.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtIdentificacaoPag.Location = new Point(698, 238);
            txtIdentificacaoPag.Name = "txtIdentificacaoPag";
            txtIdentificacaoPag.PlaceholderText = "Quem está depositando?";
            txtIdentificacaoPag.Size = new Size(379, 29);
            txtIdentificacaoPag.TabIndex = 82;
            txtIdentificacaoPag.TextAlign = HorizontalAlignment.Center;
            // 
            // txtNomeDestinoPag
            // 
            txtNomeDestinoPag.BackColor = Color.White;
            txtNomeDestinoPag.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNomeDestinoPag.Location = new Point(698, 181);
            txtNomeDestinoPag.Name = "txtNomeDestinoPag";
            txtNomeDestinoPag.PlaceholderText = "Nome do beneficiário";
            txtNomeDestinoPag.Size = new Size(379, 29);
            txtNomeDestinoPag.TabIndex = 81;
            txtNomeDestinoPag.TextAlign = HorizontalAlignment.Center;
            // 
            // txtNumContaPag
            // 
            txtNumContaPag.BackColor = Color.White;
            txtNumContaPag.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNumContaPag.Location = new Point(698, 124);
            txtNumContaPag.Name = "txtNumContaPag";
            txtNumContaPag.PlaceholderText = "Número da conta destino";
            txtNumContaPag.Size = new Size(379, 29);
            txtNumContaPag.TabIndex = 80;
            txtNumContaPag.TextAlign = HorizontalAlignment.Center;
            // 
            // txtCodBarrasPag
            // 
            txtCodBarrasPag.BackColor = Color.White;
            txtCodBarrasPag.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCodBarrasPag.Location = new Point(698, 73);
            txtCodBarrasPag.Name = "txtCodBarrasPag";
            txtCodBarrasPag.PlaceholderText = "0000.0000.0000.0000.000000.0.000000000";
            txtCodBarrasPag.Size = new Size(379, 29);
            txtCodBarrasPag.TabIndex = 79;
            txtCodBarrasPag.TextAlign = HorizontalAlignment.Center;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1169, 507);
            Controls.Add(txtIdentificacaoPag);
            Controls.Add(txtNomeDestinoPag);
            Controls.Add(txtNumContaPag);
            Controls.Add(txtCodBarrasPag);
            Controls.Add(lblValorDeposito);
            Controls.Add(txtValorDeposito);
            Controls.Add(lblSaldoVal);
            Controls.Add(lblSaldo);
            Controls.Add(pictureBox1);
            Controls.Add(lblDepositoConfirmado);
            Controls.Add(lblVoltarDeposito);
            Controls.Add(btConfirmarDeposito);
            Controls.Add(lblDeposito);
            Name = "Form1";
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
        private Label lblDeposito;
        private Label lblValorDeposito;
        private TextBox txtValorDeposito;
        private Label lblSaldoVal;
        private Label lblSaldo;
        private TextBox txtIdentificacaoPag;
        private TextBox txtNomeDestinoPag;
        private TextBox txtNumContaPag;
        private TextBox txtCodBarrasPag;
    }
}