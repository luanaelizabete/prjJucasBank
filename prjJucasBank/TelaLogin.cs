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
    public partial class TelaLogin : Form
    {
        public TelaLogin()
        {
            InitializeComponent();
        }

        private void TelaLogin_Load(object sender, EventArgs e)
        {
            if (this.menu.Items[0].Text == "Login")
            {
                TelaLogin telaLogin = new TelaLogin();
                telaLogin.MdiParent = this;
                telaLogin.Show();
            }
            else
            {
                menu.Items[0].Text = "Login";
                menu.Items[1].Visible = false;
                menu.Items[2].Visible = false;
                menu.Items[3].Visible = false;
                menu.Items[4].Visible = false;
                menu.Items[4].Text = String.Empty;
                menu.Items[5].Visible = false;
                menu.Items[6].Visible = false;
                menu.Items[6].Text = String.Empty;
                UsuarioLogado.Deslogar();
            }

        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {

            TelaCadastro telaCadastro = new TelaCadastro();
            telaCadastro.Show();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saqueToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void depósitoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
