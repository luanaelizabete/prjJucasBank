using prjJucasBank;
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

        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var TelaLogin = new TelaLoginBanco();

            TelaCadastro telaCadastro = new TelaCadastro();

            telaCadastro.Show();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var TelaLogin = new TelaLoginBanco();

            if (this.menu.Items[0].Text == "Login")
            {
                TelaLoginBanco telaLoginBanco = new TelaLoginBanco();
              
                telaLoginBanco.Show();
            }
            else
            {
                menu.Items[0].Text = "Login";
                menu.Items[1].Visible = true;
                menu.Items[2].Visible = false;
                menu.Items[3].Visible = false;
                menu.Items[4].Text = String.Empty;
                menu.Items[5].Visible = false;
                menu.Items[6].Visible = false;
                menu.Items[6].Text = String.Empty;
                UsuarioLogado.Deslogar();
            }

        }


        private void saqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaSaque telaSaque = new TelaSaque();
            telaSaque.Show();


        }

        private void depósitoToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }

        private void TelaLogin_Load_1(object sender, EventArgs e)
        {


        }

        private void transferênciaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void contaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaCriarConta telaCriarConta = new TelaCriarConta();

            telaCriarConta.Show();
        }

        private void pagamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }

        private void menu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void agendamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nomeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void criarContaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaCriarConta criarConta = new TelaCriarConta();
            criarConta.Show();
        }

        private void alterarContaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaAlterarConta alterarConta = new TelaAlterarConta();
            alterarConta.Show();
        }

        private void alterarDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaAlterarDados alterarDados = new TelaAlterarDados();
            alterarDados.Show();
        }

        private void alterarSenhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaAlterarSenha alterarSenha = new TelaAlterarSenha();
            alterarSenha.Show();
        }
    }
}
