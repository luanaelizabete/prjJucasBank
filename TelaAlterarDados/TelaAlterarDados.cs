using prjJucasBank;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TelaAlterarDados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCriarAcesso_Click(object sender, EventArgs e)
        {
            txtNomeCadastro.Text = UsuarioLogado.Nome;
            txtCpfCadastro.Text = UsuarioLogado.Cpf;
            txtRgCadastro.Text = UsuarioLogado.Rg;
            txtCelularCadastro.Text = UsuarioLogado.Celular;
            txtEmailCadastro.Text = UsuarioLogado.Email;
            dtpNascimentoCadastro.Text = Convert.ToString(UsuarioLogado.DataNascimento);
            txtGeneroCadastro.Text = UsuarioLogado.Genero;
            txtCepCadastro.Text = UsuarioLogado.Cep;
            txtEnderecoCadastro.Text = UsuarioLogado.Endereco;
            txtNumEnderecoCadastro.Text = UsuarioLogado.NumEndereco;
            txtCidadeCadastro.Text = UsuarioLogado.Cidade;
            cbUf.Text = UsuarioLogado.Estado;
            txtRendaCadastro.Text = Convert.ToString(UsuarioLogado.Renda);
        }
    }
}