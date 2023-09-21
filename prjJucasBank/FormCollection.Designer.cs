namespace prjJucasBank
{
    partial class FormCollection
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
            Lstinfo = new ListBox();
            Btnlistar = new Button();
            Btnadicionar = new Button();
            txtnomecliente = new TextBox();
            txtId = new TextBox();
            SuspendLayout();
            // 
            // Lstinfo
            // 
            Lstinfo.FormattingEnabled = true;
            Lstinfo.ItemHeight = 15;
            Lstinfo.Location = new Point(30, 181);
            Lstinfo.Name = "Lstinfo";
            Lstinfo.Size = new Size(422, 244);
            Lstinfo.TabIndex = 10;
            // 
            // Btnlistar
            // 
            Btnlistar.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Btnlistar.Location = new Point(289, 99);
            Btnlistar.Name = "Btnlistar";
            Btnlistar.Size = new Size(103, 32);
            Btnlistar.TabIndex = 9;
            Btnlistar.Text = "Listar";
            Btnlistar.UseVisualStyleBackColor = true;
            Btnlistar.Click += Btnlistar_Click;
            // 
            // Btnadicionar
            // 
            Btnadicionar.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Btnadicionar.Location = new Point(71, 99);
            Btnadicionar.Name = "Btnadicionar";
            Btnadicionar.Size = new Size(103, 32);
            Btnadicionar.TabIndex = 8;
            Btnadicionar.Text = "Adicionar";
            Btnadicionar.UseVisualStyleBackColor = true;
            Btnadicionar.Click += Btnadicionar_Click;
            // 
            // txtnomecliente
            // 
            txtnomecliente.Location = new Point(30, 57);
            txtnomecliente.Name = "txtnomecliente";
            txtnomecliente.Size = new Size(422, 23);
            txtnomecliente.TabIndex = 7;
            // 
            // txtId
            // 
            txtId.Location = new Point(30, 14);
            txtId.Name = "txtId";
            txtId.Size = new Size(40, 23);
            txtId.TabIndex = 6;
            // 
            // FormCollection
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(485, 450);
            Controls.Add(Lstinfo);
            Controls.Add(Btnlistar);
            Controls.Add(Btnadicionar);
            Controls.Add(txtnomecliente);
            Controls.Add(txtId);
            Name = "FormCollection";
            Text = "FormCollection";
            Load += FormCollection_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox Lstinfo;
        private Button Btnlistar;
        private Button Btnadicionar;
        private TextBox txtnomecliente;
        private TextBox txtId;
    }
}