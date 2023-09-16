namespace prjJucasBank
{
    partial class TelaMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaMenu));
            lblOperacoes = new Label();
            lblExtrato = new Label();
            lblSaldoVal = new Label();
            lblSaldo = new Label();
            lblNomeUser = new Label();
            lblOla = new Label();
            btnSair = new Button();
            btnTransferir = new Button();
            btnAgendarPagamento = new Button();
            btnSacar = new Button();
            btnDepositar = new Button();
            btnConfiguracoes = new Button();
            extratoLista = new ListBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblOperacoes
            // 
            lblOperacoes.AutoSize = true;
            lblOperacoes.Font = new Font("Lucida Bright", 25.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblOperacoes.ForeColor = Color.DarkOrchid;
            lblOperacoes.Location = new Point(201, 51);
            lblOperacoes.Name = "lblOperacoes";
            lblOperacoes.Size = new Size(191, 39);
            lblOperacoes.TabIndex = 27;
            lblOperacoes.Text = "Operações";
            lblOperacoes.Click += lblOperacoes_Click;
            // 
            // lblExtrato
            // 
            lblExtrato.AutoSize = true;
            lblExtrato.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblExtrato.ForeColor = Color.Black;
            lblExtrato.Location = new Point(-242, 24);
            lblExtrato.Name = "lblExtrato";
            lblExtrato.Size = new Size(106, 37);
            lblExtrato.TabIndex = 26;
            lblExtrato.Text = "Extrato:";
            lblExtrato.Click += lblExtrato_Click;
            // 
            // lblSaldoVal
            // 
            lblSaldoVal.AutoSize = true;
            lblSaldoVal.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblSaldoVal.ForeColor = Color.Black;
            lblSaldoVal.Location = new Point(-146, -30);
            lblSaldoVal.Name = "lblSaldoVal";
            lblSaldoVal.Size = new Size(121, 37);
            lblSaldoVal.TabIndex = 25;
            lblSaldoVal.Text = "R$ 50,33";
            lblSaldoVal.Click += lblSaldoVal_Click;
            // 
            // lblSaldo
            // 
            lblSaldo.AutoSize = true;
            lblSaldo.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblSaldo.ForeColor = Color.Black;
            lblSaldo.Location = new Point(-242, -30);
            lblSaldo.Name = "lblSaldo";
            lblSaldo.Size = new Size(90, 37);
            lblSaldo.TabIndex = 24;
            lblSaldo.Text = "Saldo:";
            lblSaldo.Click += lblSaldo_Click;
            // 
            // lblNomeUser
            // 
            lblNomeUser.AutoSize = true;
            lblNomeUser.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblNomeUser.ForeColor = Color.Black;
            lblNomeUser.Location = new Point(-172, -84);
            lblNomeUser.Name = "lblNomeUser";
            lblNomeUser.Size = new Size(108, 37);
            lblNomeUser.TabIndex = 23;
            lblNomeUser.Text = "Usuário";
            lblNomeUser.Click += lblNomeUser_Click;
            // 
            // lblOla
            // 
            lblOla.AutoSize = true;
            lblOla.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblOla.ForeColor = Color.Black;
            lblOla.Location = new Point(-242, -84);
            lblOla.Name = "lblOla";
            lblOla.Size = new Size(64, 37);
            lblOla.TabIndex = 22;
            lblOla.Text = "Olá,";
            lblOla.Click += lblOla_Click;
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.White;
            btnSair.Font = new Font("Lucida Bright", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnSair.Location = new Point(873, 436);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(133, 42);
            btnSair.TabIndex = 21;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += sairMenu_Click;
            // 
            // btnTransferir
            // 
            btnTransferir.BackColor = Color.White;
            btnTransferir.Font = new Font("Lucida Bright", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnTransferir.Location = new Point(71, 351);
            btnTransferir.Name = "btnTransferir";
            btnTransferir.Size = new Size(290, 42);
            btnTransferir.TabIndex = 20;
            btnTransferir.Text = "Pagar / Transferir";
            btnTransferir.UseVisualStyleBackColor = false;
            btnTransferir.Click += pagarTransferir_Click;
            // 
            // btnAgendarPagamento
            // 
            btnAgendarPagamento.BackColor = Color.White;
            btnAgendarPagamento.Font = new Font("Lucida Bright", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgendarPagamento.Location = new Point(71, 436);
            btnAgendarPagamento.Name = "btnAgendarPagamento";
            btnAgendarPagamento.Size = new Size(290, 42);
            btnAgendarPagamento.TabIndex = 19;
            btnAgendarPagamento.Text = "Agendar Pagamento";
            btnAgendarPagamento.UseVisualStyleBackColor = false;
            btnAgendarPagamento.Click += agdPagto_Click;
            // 
            // btnSacar
            // 
            btnSacar.BackColor = Color.White;
            btnSacar.Font = new Font("Lucida Bright", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnSacar.Location = new Point(71, 262);
            btnSacar.Name = "btnSacar";
            btnSacar.Size = new Size(290, 42);
            btnSacar.TabIndex = 18;
            btnSacar.Text = "Sacar";
            btnSacar.UseVisualStyleBackColor = false;
            btnSacar.Click += sacar_Click;
            // 
            // btnDepositar
            // 
            btnDepositar.BackColor = Color.White;
            btnDepositar.Font = new Font("Lucida Bright", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnDepositar.Location = new Point(71, 171);
            btnDepositar.Name = "btnDepositar";
            btnDepositar.Size = new Size(290, 42);
            btnDepositar.TabIndex = 17;
            btnDepositar.Text = "Depositar";
            btnDepositar.UseVisualStyleBackColor = false;
            btnDepositar.Click += depositar_Click;
            // 
            // btnConfiguracoes
            // 
            btnConfiguracoes.BackColor = Color.White;
            btnConfiguracoes.Font = new Font("Lucida Bright", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnConfiguracoes.Location = new Point(803, 342);
            btnConfiguracoes.Name = "btnConfiguracoes";
            btnConfiguracoes.Size = new Size(203, 51);
            btnConfiguracoes.TabIndex = 15;
            btnConfiguracoes.Text = "Configurações";
            btnConfiguracoes.UseVisualStyleBackColor = false;
            btnConfiguracoes.Click += btConfig_Click;
            // 
            // extratoLista
            // 
            extratoLista.Anchor = AnchorStyles.None;
            extratoLista.BackColor = Color.White;
            extratoLista.Font = new Font("Lucida Bright", 15F, FontStyle.Regular, GraphicsUnit.Point);
            extratoLista.FormattingEnabled = true;
            extratoLista.ItemHeight = 23;
            extratoLista.Items.AddRange(new object[] { "      ( mostrar extrato em lista )", "", "      ( mostrar extrato em lista )", "", "      ( mostrar extrato em lista )", "", "      ( mostrar extrato em lista )" });
            extratoLista.Location = new Point(663, 47);
            extratoLista.Name = "extratoLista";
            extratoLista.Size = new Size(343, 257);
            extratoLista.TabIndex = 14;
            extratoLista.SelectedIndexChanged += extratoLista_SelectedIndexChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.AccessibleRole = AccessibleRole.None;
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BackColor = Color.Black;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(79, 36);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(99, 63);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 31;
            pictureBox1.TabStop = false;
            // 
            // TelaMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1169, 507);
            Controls.Add(pictureBox1);
            Controls.Add(lblOperacoes);
            Controls.Add(lblExtrato);
            Controls.Add(lblSaldoVal);
            Controls.Add(lblSaldo);
            Controls.Add(lblNomeUser);
            Controls.Add(lblOla);
            Controls.Add(btnSair);
            Controls.Add(btnTransferir);
            Controls.Add(btnAgendarPagamento);
            Controls.Add(btnSacar);
            Controls.Add(btnDepositar);
            Controls.Add(btnConfiguracoes);
            Controls.Add(extratoLista);
            Name = "TelaMenu";
            Text = "TelaMenu";
            Load += TelaMenu_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblOperacoes;
        private Label lblExtrato;
        private Label lblSaldoVal;
        private Label lblSaldo;
        private Label lblNomeUser;
        private Label lblOla;
        private Button btnSair;
        private Button btnTransferir;
        private Button btnAgendarPagamento;
        private Button btnSacar;
        private Button btnDepositar;
        private Button btnConfiguracoes;
        private ListBox extratoLista;
        private PictureBox pictureBox1;
    }
}