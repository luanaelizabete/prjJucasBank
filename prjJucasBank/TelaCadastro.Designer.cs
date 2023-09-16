namespace PrjtAula01
{
    partial class TelaCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaCadastro));
            txtNomeCadastro = new TextBox();
            txtCpfCadastro = new TextBox();
            txtRgCadastro = new TextBox();
            txtCelularCadastro = new TextBox();
            txtEmailCadastro = new TextBox();
            txtGeneroCadastro = new TextBox();
            txtCepCadastro = new TextBox();
            txtRendaCadastro = new TextBox();
            btnCriarAcesso = new Button();
            btnRetornarCadastro = new Button();
            lblInserirDadosCadastro = new Label();
            txtEnderecoCadastro = new TextBox();
            txtCidadeCadastro = new TextBox();
            txtNumEnderecoCadastro = new TextBox();
            cbUf = new ComboBox();
            dtpNascimentoCadastro = new DateTimePicker();
            txtSenhaCadastro = new TextBox();
            txtSenhaConfirmaCadastro = new TextBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtNomeCadastro
            // 
            txtNomeCadastro.Font = new Font("Lucida Bright", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNomeCadastro.Location = new Point(60, 139);
            txtNomeCadastro.Name = "txtNomeCadastro";
            txtNomeCadastro.PlaceholderText = "Nome Completo";
            txtNomeCadastro.Size = new Size(300, 26);
            txtNomeCadastro.TabIndex = 0;
            txtNomeCadastro.TextAlign = HorizontalAlignment.Center;
            txtNomeCadastro.TextChanged += TxtNomeCadastro_TextChanged;
            // 
            // txtCpfCadastro
            // 
            txtCpfCadastro.Font = new Font("Lucida Bright", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCpfCadastro.Location = new Point(821, 139);
            txtCpfCadastro.Name = "txtCpfCadastro";
            txtCpfCadastro.PlaceholderText = "000.000.000-00";
            txtCpfCadastro.Size = new Size(300, 26);
            txtCpfCadastro.TabIndex = 1;
            txtCpfCadastro.TextAlign = HorizontalAlignment.Center;
            // 
            // txtRgCadastro
            // 
            txtRgCadastro.Font = new Font("Lucida Bright", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtRgCadastro.Location = new Point(821, 183);
            txtRgCadastro.Name = "txtRgCadastro";
            txtRgCadastro.PlaceholderText = "00.000.000-0";
            txtRgCadastro.Size = new Size(300, 26);
            txtRgCadastro.TabIndex = 2;
            txtRgCadastro.TextAlign = HorizontalAlignment.Center;
            // 
            // txtCelularCadastro
            // 
            txtCelularCadastro.Font = new Font("Lucida Bright", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCelularCadastro.Location = new Point(60, 231);
            txtCelularCadastro.Name = "txtCelularCadastro";
            txtCelularCadastro.PlaceholderText = "Celular";
            txtCelularCadastro.Size = new Size(300, 26);
            txtCelularCadastro.TabIndex = 3;
            txtCelularCadastro.TextAlign = HorizontalAlignment.Center;
            // 
            // txtEmailCadastro
            // 
            txtEmailCadastro.Font = new Font("Lucida Bright", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmailCadastro.Location = new Point(60, 183);
            txtEmailCadastro.Name = "txtEmailCadastro";
            txtEmailCadastro.PlaceholderText = "seu@email.com";
            txtEmailCadastro.Size = new Size(300, 26);
            txtEmailCadastro.TabIndex = 4;
            txtEmailCadastro.TextAlign = HorizontalAlignment.Center;
            // 
            // txtGeneroCadastro
            // 
            txtGeneroCadastro.Font = new Font("Lucida Bright", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtGeneroCadastro.Location = new Point(60, 325);
            txtGeneroCadastro.Name = "txtGeneroCadastro";
            txtGeneroCadastro.PlaceholderText = "Gênero";
            txtGeneroCadastro.Size = new Size(300, 26);
            txtGeneroCadastro.TabIndex = 6;
            txtGeneroCadastro.TextAlign = HorizontalAlignment.Center;
            // 
            // txtCepCadastro
            // 
            txtCepCadastro.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCepCadastro.Location = new Point(443, 183);
            txtCepCadastro.Name = "txtCepCadastro";
            txtCepCadastro.PlaceholderText = "CEP";
            txtCepCadastro.Size = new Size(300, 29);
            txtCepCadastro.TabIndex = 7;
            txtCepCadastro.TextAlign = HorizontalAlignment.Center;
            // 
            // txtRendaCadastro
            // 
            txtRendaCadastro.Font = new Font("Lucida Bright", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtRendaCadastro.Location = new Point(821, 231);
            txtRendaCadastro.Name = "txtRendaCadastro";
            txtRendaCadastro.PlaceholderText = "Insira sua renda ";
            txtRendaCadastro.Size = new Size(300, 26);
            txtRendaCadastro.TabIndex = 12;
            txtRendaCadastro.TextAlign = HorizontalAlignment.Center;
            txtRendaCadastro.TextChanged += TxtRendaCadastro_TextChanged;
            // 
            // btnCriarAcesso
            // 
            btnCriarAcesso.BackColor = Color.White;
            btnCriarAcesso.Font = new Font("Lucida Bright", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnCriarAcesso.Location = new Point(926, 450);
            btnCriarAcesso.Name = "btnCriarAcesso";
            btnCriarAcesso.Size = new Size(195, 35);
            btnCriarAcesso.TabIndex = 16;
            btnCriarAcesso.Text = "Criar cadastro";
            btnCriarAcesso.UseVisualStyleBackColor = false;
            btnCriarAcesso.Click += BtnCriarAcesso_Click;
            // 
            // btnRetornarCadastro
            // 
            btnRetornarCadastro.BackColor = Color.White;
            btnRetornarCadastro.Font = new Font("Lucida Bright", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnRetornarCadastro.Location = new Point(60, 450);
            btnRetornarCadastro.Name = "btnRetornarCadastro";
            btnRetornarCadastro.Size = new Size(158, 35);
            btnRetornarCadastro.TabIndex = 17;
            btnRetornarCadastro.Text = "Retornar";
            btnRetornarCadastro.UseVisualStyleBackColor = false;
            btnRetornarCadastro.Click += btnRetornarCadastro_Click;
            // 
            // lblInserirDadosCadastro
            // 
            lblInserirDadosCadastro.AutoSize = true;
            lblInserirDadosCadastro.BackColor = SystemColors.WindowText;
            lblInserirDadosCadastro.Font = new Font("Lucida Bright", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblInserirDadosCadastro.ForeColor = Color.DarkOrchid;
            lblInserirDadosCadastro.Location = new Point(239, 52);
            lblInserirDadosCadastro.Name = "lblInserirDadosCadastro";
            lblInserirDadosCadastro.Size = new Size(313, 39);
            lblInserirDadosCadastro.TabIndex = 15;
            lblInserirDadosCadastro.Text = "Crie seu cadastro";
            lblInserirDadosCadastro.Click += LblInserirDadosCadastro_Click;
            // 
            // txtEnderecoCadastro
            // 
            txtEnderecoCadastro.Font = new Font("Lucida Bright", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEnderecoCadastro.Location = new Point(443, 231);
            txtEnderecoCadastro.Name = "txtEnderecoCadastro";
            txtEnderecoCadastro.PlaceholderText = "Digite seu endereço";
            txtEnderecoCadastro.Size = new Size(300, 26);
            txtEnderecoCadastro.TabIndex = 8;
            txtEnderecoCadastro.TextAlign = HorizontalAlignment.Center;
            txtEnderecoCadastro.TextChanged += TxtLogradCad_TextChanged;
            // 
            // txtCidadeCadastro
            // 
            txtCidadeCadastro.Font = new Font("Lucida Bright", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCidadeCadastro.Location = new Point(443, 139);
            txtCidadeCadastro.Name = "txtCidadeCadastro";
            txtCidadeCadastro.PlaceholderText = "Cidade";
            txtCidadeCadastro.Size = new Size(224, 26);
            txtCidadeCadastro.TabIndex = 10;
            txtCidadeCadastro.TextAlign = HorizontalAlignment.Center;
            txtCidadeCadastro.TextChanged += TextBox2_TextChanged;
            // 
            // txtNumEnderecoCadastro
            // 
            txtNumEnderecoCadastro.Font = new Font("Lucida Bright", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNumEnderecoCadastro.Location = new Point(443, 280);
            txtNumEnderecoCadastro.Name = "txtNumEnderecoCadastro";
            txtNumEnderecoCadastro.PlaceholderText = "Numero de sua residência";
            txtNumEnderecoCadastro.Size = new Size(300, 26);
            txtNumEnderecoCadastro.TabIndex = 9;
            txtNumEnderecoCadastro.TextAlign = HorizontalAlignment.Center;
            txtNumEnderecoCadastro.TextChanged += TxtNumLogCad_TextChanged;
            // 
            // cbUf
            // 
            cbUf.Font = new Font("Lucida Bright", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbUf.FormattingEnabled = true;
            cbUf.Items.AddRange(new object[] { "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO" });
            cbUf.Location = new Point(673, 139);
            cbUf.Name = "cbUf";
            cbUf.Size = new Size(70, 28);
            cbUf.TabIndex = 11;
            cbUf.Text = "UF";
            cbUf.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;
            // 
            // dtpNascimentoCadastro
            // 
            dtpNascimentoCadastro.Font = new Font("Lucida Bright", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtpNascimentoCadastro.Location = new Point(60, 280);
            dtpNascimentoCadastro.Name = "dtpNascimentoCadastro";
            dtpNascimentoCadastro.Size = new Size(300, 26);
            dtpNascimentoCadastro.TabIndex = 5;
            // 
            // txtSenhaCadastro
            // 
            txtSenhaCadastro.Font = new Font("Lucida Bright", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSenhaCadastro.Location = new Point(821, 325);
            txtSenhaCadastro.Name = "txtSenhaCadastro";
            txtSenhaCadastro.PlaceholderText = "Crie sua senha";
            txtSenhaCadastro.Size = new Size(300, 26);
            txtSenhaCadastro.TabIndex = 22;
            txtSenhaCadastro.TextAlign = HorizontalAlignment.Center;
            // 
            // txtSenhaConfirmaCadastro
            // 
            txtSenhaConfirmaCadastro.Font = new Font("Lucida Bright", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSenhaConfirmaCadastro.Location = new Point(821, 385);
            txtSenhaConfirmaCadastro.Name = "txtSenhaConfirmaCadastro";
            txtSenhaConfirmaCadastro.PlaceholderText = "Confirme sua senha";
            txtSenhaConfirmaCadastro.Size = new Size(300, 26);
            txtSenhaConfirmaCadastro.TabIndex = 23;
            txtSenhaConfirmaCadastro.TextAlign = HorizontalAlignment.Center;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(118, 52);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(65, 0);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 24;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.AccessibleRole = AccessibleRole.None;
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BackColor = Color.Black;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(60, 32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(158, 84);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 30;
            pictureBox1.TabStop = false;
            // 
            // TelaCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowText;
            ClientSize = new Size(1169, 507);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Controls.Add(txtSenhaConfirmaCadastro);
            Controls.Add(txtSenhaCadastro);
            Controls.Add(dtpNascimentoCadastro);
            Controls.Add(cbUf);
            Controls.Add(txtNumEnderecoCadastro);
            Controls.Add(txtCidadeCadastro);
            Controls.Add(txtEnderecoCadastro);
            Controls.Add(lblInserirDadosCadastro);
            Controls.Add(btnRetornarCadastro);
            Controls.Add(btnCriarAcesso);
            Controls.Add(txtRendaCadastro);
            Controls.Add(txtCepCadastro);
            Controls.Add(txtGeneroCadastro);
            Controls.Add(txtEmailCadastro);
            Controls.Add(txtCelularCadastro);
            Controls.Add(txtRgCadastro);
            Controls.Add(txtCpfCadastro);
            Controls.Add(txtNomeCadastro);
            Name = "TelaCadastro";
            Text = "Tela Cadastro";
            Load += TelaCadastro_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNomeCadastro;
        private TextBox txtCpfCadastro;
        private TextBox txtRgCadastro;
        private TextBox txtCelularCadastro;
        private TextBox txtEmailCadastro;
        private TextBox txtGeneroCadastro;
        private TextBox txtCepCadastro;
        private TextBox txtRendaCadastro;
        private Button btnCriarAcesso;
        private Button btnRetornarCadastro;
        private Label lblInserirDadosCadastro;
        private TextBox txtEnderecoCadastro;
        private TextBox txtCidadeCadastro;
        private TextBox txtNumEnderecoCadastro;
        private ComboBox cbUf;
        private DateTimePicker dtpNascimentoCadastro;
        private TextBox txtSenhaCadastro;
        private TextBox txtSenhaConfirmaCadastro;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
    }
}