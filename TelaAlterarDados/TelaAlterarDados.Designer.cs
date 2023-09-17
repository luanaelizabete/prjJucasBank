namespace TelaAlterarDados
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
            dtpNascimentoCadastro = new DateTimePicker();
            cbUf = new ComboBox();
            txtNumEnderecoCadastro = new TextBox();
            txtCidadeCadastro = new TextBox();
            txtEnderecoCadastro = new TextBox();
            lblInserirDadosCadastro = new Label();
            btnRetornarCadastro = new Button();
            btnAlterarDados = new Button();
            txtRendaCadastro = new TextBox();
            txtCepCadastro = new TextBox();
            txtGeneroCadastro = new TextBox();
            txtEmailCadastro = new TextBox();
            txtCelularCadastro = new TextBox();
            txtRgCadastro = new TextBox();
            txtCpfCadastro = new TextBox();
            txtNomeCadastro = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.AccessibleRole = AccessibleRole.None;
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BackColor = Color.Black;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(39, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(131, 70);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 50;
            pictureBox1.TabStop = false;
            // 
            // dtpNascimentoCadastro
            // 
            dtpNascimentoCadastro.Font = new Font("Lucida Bright", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtpNascimentoCadastro.Location = new Point(12, 260);
            dtpNascimentoCadastro.Name = "dtpNascimentoCadastro";
            dtpNascimentoCadastro.Size = new Size(300, 26);
            dtpNascimentoCadastro.TabIndex = 36;
            // 
            // cbUf
            // 
            cbUf.Font = new Font("Lucida Bright", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbUf.FormattingEnabled = true;
            cbUf.Items.AddRange(new object[] { "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO" });
            cbUf.Location = new Point(625, 119);
            cbUf.Name = "cbUf";
            cbUf.Size = new Size(70, 28);
            cbUf.TabIndex = 42;
            cbUf.Text = "UF";
            // 
            // txtNumEnderecoCadastro
            // 
            txtNumEnderecoCadastro.Font = new Font("Lucida Bright", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNumEnderecoCadastro.Location = new Point(395, 260);
            txtNumEnderecoCadastro.Name = "txtNumEnderecoCadastro";
            txtNumEnderecoCadastro.PlaceholderText = "Numero de sua residência";
            txtNumEnderecoCadastro.Size = new Size(300, 26);
            txtNumEnderecoCadastro.TabIndex = 40;
            txtNumEnderecoCadastro.TextAlign = HorizontalAlignment.Center;
            // 
            // txtCidadeCadastro
            // 
            txtCidadeCadastro.Font = new Font("Lucida Bright", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCidadeCadastro.Location = new Point(395, 119);
            txtCidadeCadastro.Name = "txtCidadeCadastro";
            txtCidadeCadastro.PlaceholderText = "Cidade";
            txtCidadeCadastro.Size = new Size(224, 26);
            txtCidadeCadastro.TabIndex = 41;
            txtCidadeCadastro.TextAlign = HorizontalAlignment.Center;
            // 
            // txtEnderecoCadastro
            // 
            txtEnderecoCadastro.Font = new Font("Lucida Bright", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEnderecoCadastro.Location = new Point(395, 211);
            txtEnderecoCadastro.Name = "txtEnderecoCadastro";
            txtEnderecoCadastro.PlaceholderText = "Digite seu endereço";
            txtEnderecoCadastro.Size = new Size(300, 26);
            txtEnderecoCadastro.TabIndex = 39;
            txtEnderecoCadastro.TextAlign = HorizontalAlignment.Center;
            // 
            // lblInserirDadosCadastro
            // 
            lblInserirDadosCadastro.AutoSize = true;
            lblInserirDadosCadastro.BackColor = SystemColors.WindowText;
            lblInserirDadosCadastro.Font = new Font("Lucida Bright", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblInserirDadosCadastro.ForeColor = Color.DarkOrchid;
            lblInserirDadosCadastro.Location = new Point(191, 28);
            lblInserirDadosCadastro.Name = "lblInserirDadosCadastro";
            lblInserirDadosCadastro.Size = new Size(254, 39);
            lblInserirDadosCadastro.TabIndex = 44;
            lblInserirDadosCadastro.Text = "Alterar Dados";
            // 
            // btnRetornarCadastro
            // 
            btnRetornarCadastro.BackColor = Color.White;
            btnRetornarCadastro.Font = new Font("Lucida Bright", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnRetornarCadastro.Location = new Point(12, 381);
            btnRetornarCadastro.Name = "btnRetornarCadastro";
            btnRetornarCadastro.Size = new Size(158, 41);
            btnRetornarCadastro.TabIndex = 46;
            btnRetornarCadastro.Text = "Retornar";
            btnRetornarCadastro.UseVisualStyleBackColor = false;
            // 
            // btnAlterarDados
            // 
            btnAlterarDados.BackColor = Color.White;
            btnAlterarDados.Font = new Font("Lucida Bright", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnAlterarDados.Location = new Point(878, 381);
            btnAlterarDados.Name = "btnAlterarDados";
            btnAlterarDados.Size = new Size(195, 41);
            btnAlterarDados.TabIndex = 45;
            btnAlterarDados.Text = "Atualizar Dados";
            btnAlterarDados.UseVisualStyleBackColor = false;
            btnAlterarDados.Click += BtnCriarAcesso_Click;
            // 
            // txtRendaCadastro
            // 
            txtRendaCadastro.Font = new Font("Lucida Bright", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtRendaCadastro.Location = new Point(773, 211);
            txtRendaCadastro.Name = "txtRendaCadastro";
            txtRendaCadastro.PlaceholderText = "Insira sua renda ";
            txtRendaCadastro.Size = new Size(300, 26);
            txtRendaCadastro.TabIndex = 43;
            txtRendaCadastro.TextAlign = HorizontalAlignment.Center;
            // 
            // txtCepCadastro
            // 
            txtCepCadastro.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCepCadastro.Location = new Point(395, 163);
            txtCepCadastro.Name = "txtCepCadastro";
            txtCepCadastro.PlaceholderText = "CEP";
            txtCepCadastro.Size = new Size(300, 29);
            txtCepCadastro.TabIndex = 38;
            txtCepCadastro.TextAlign = HorizontalAlignment.Center;
            // 
            // txtGeneroCadastro
            // 
            txtGeneroCadastro.Font = new Font("Lucida Bright", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtGeneroCadastro.Location = new Point(773, 260);
            txtGeneroCadastro.Name = "txtGeneroCadastro";
            txtGeneroCadastro.PlaceholderText = "Gênero";
            txtGeneroCadastro.Size = new Size(300, 26);
            txtGeneroCadastro.TabIndex = 37;
            txtGeneroCadastro.TextAlign = HorizontalAlignment.Center;
            // 
            // txtEmailCadastro
            // 
            txtEmailCadastro.Font = new Font("Lucida Bright", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmailCadastro.Location = new Point(12, 163);
            txtEmailCadastro.Name = "txtEmailCadastro";
            txtEmailCadastro.PlaceholderText = "seu@email.com";
            txtEmailCadastro.Size = new Size(300, 26);
            txtEmailCadastro.TabIndex = 35;
            txtEmailCadastro.TextAlign = HorizontalAlignment.Center;
            // 
            // txtCelularCadastro
            // 
            txtCelularCadastro.Font = new Font("Lucida Bright", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCelularCadastro.Location = new Point(12, 211);
            txtCelularCadastro.Name = "txtCelularCadastro";
            txtCelularCadastro.PlaceholderText = "Celular";
            txtCelularCadastro.Size = new Size(300, 26);
            txtCelularCadastro.TabIndex = 34;
            txtCelularCadastro.TextAlign = HorizontalAlignment.Center;
            // 
            // txtRgCadastro
            // 
            txtRgCadastro.Font = new Font("Lucida Bright", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtRgCadastro.Location = new Point(773, 163);
            txtRgCadastro.Name = "txtRgCadastro";
            txtRgCadastro.PlaceholderText = "00.000.000-0";
            txtRgCadastro.Size = new Size(300, 26);
            txtRgCadastro.TabIndex = 33;
            txtRgCadastro.TextAlign = HorizontalAlignment.Center;
            // 
            // txtCpfCadastro
            // 
            txtCpfCadastro.Font = new Font("Lucida Bright", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCpfCadastro.Location = new Point(773, 119);
            txtCpfCadastro.Name = "txtCpfCadastro";
            txtCpfCadastro.PlaceholderText = "000.000.000-00";
            txtCpfCadastro.Size = new Size(300, 26);
            txtCpfCadastro.TabIndex = 32;
            txtCpfCadastro.TextAlign = HorizontalAlignment.Center;
            // 
            // txtNomeCadastro
            // 
            txtNomeCadastro.Font = new Font("Lucida Bright", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNomeCadastro.Location = new Point(12, 119);
            txtNomeCadastro.Name = "txtNomeCadastro";
            txtNomeCadastro.PlaceholderText = "Nome Completo";
            txtNomeCadastro.Size = new Size(300, 26);
            txtNomeCadastro.TabIndex = 31;
            txtNomeCadastro.TextAlign = HorizontalAlignment.Center;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1169, 507);
            Controls.Add(pictureBox1);
            Controls.Add(dtpNascimentoCadastro);
            Controls.Add(cbUf);
            Controls.Add(txtNumEnderecoCadastro);
            Controls.Add(txtCidadeCadastro);
            Controls.Add(txtEnderecoCadastro);
            Controls.Add(lblInserirDadosCadastro);
            Controls.Add(btnRetornarCadastro);
            Controls.Add(btnAlterarDados);
            Controls.Add(txtRendaCadastro);
            Controls.Add(txtCepCadastro);
            Controls.Add(txtGeneroCadastro);
            Controls.Add(txtEmailCadastro);
            Controls.Add(txtCelularCadastro);
            Controls.Add(txtRgCadastro);
            Controls.Add(txtCpfCadastro);
            Controls.Add(txtNomeCadastro);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private DateTimePicker dtpNascimentoCadastro;
        private ComboBox cbUf;
        private TextBox txtNumEnderecoCadastro;
        private TextBox txtCidadeCadastro;
        private TextBox txtEnderecoCadastro;
        private Label lblInserirDadosCadastro;
        private Button btnRetornarCadastro;
        private Button btnAlterarDados;
        private TextBox txtRendaCadastro;
        private TextBox txtCepCadastro;
        private TextBox txtGeneroCadastro;
        private TextBox txtEmailCadastro;
        private TextBox txtCelularCadastro;
        private TextBox txtRgCadastro;
        private TextBox txtCpfCadastro;
        private TextBox txtNomeCadastro;
    }
}