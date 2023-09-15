using PrjtAula01;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjJucasBank
{
    public partial class telaLoginBanco : Form
    {
        public telaLoginBanco()
        {
            InitializeComponent();
        }

        private void TelaLoginBanco_Load(object sender, EventArgs e)
        {

        }

        private void Senha_Click(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {

        }

        private void btnCriarCadastro_Click(object sender, EventArgs e)
        {
            TelaCadastro TelaLoginBanco = new TelaCadastro();
            TelaLoginBanco.Show();
        }
    }
}
