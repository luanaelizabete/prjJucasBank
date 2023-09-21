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

namespace prjJucasBank
{
    public partial class TelaAlterarDados : Form
    {
        public TelaAlterarDados()
        {
            InitializeComponent();
        }

        private void btnAlterarDados_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtConfSenhaLoginAlt.Text == String.Empty || txtSenhaLoginAlt.Text == String.Empty)
                {
                    throw new Exception("Digite algo nos campos de senha!");
                }
                else if (txtSenhaLoginAlt.Text != txtConfSenhaLoginAlt.Text)
                {
                    throw new Exception("As senhas não coincidem.");
                }
                else if (txtConfSenhaLoginAlt.Text != UsuarioLogado.Senha)
                {
                    throw new Exception("Senha incorreta.");
                }
                else
                {
                    SqlConnection conexao =
                        new SqlConnection(ConfigurationManager.ConnectionStrings["prjJucasBank.Properties.Settings.strConexao"].ToString());


                    SqlCommand cmd = new SqlCommand();

                    cmd.CommandText = "pu_alterarDados";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conexao;

                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("idCliente", UsuarioLogado.IdCliente);
                    cmd.Parameters.AddWithValue("nome", txtNomeCadastro.Text);
                    cmd.Parameters.AddWithValue("cpf", txtCpfCadastro.Text);
                    cmd.Parameters.AddWithValue("rg", txtRgCadastro.Text);
                    cmd.Parameters.AddWithValue("celular", txtCelularCadastro.Text);
                    cmd.Parameters.AddWithValue("email", txtEmailCadastro.Text);
                    cmd.Parameters.AddWithValue("endereco", txtEnderecoCadastro.Text);
                    cmd.Parameters.AddWithValue("numeroEndereco", txtNumEnderecoCadastro.Text);
                    cmd.Parameters.AddWithValue("cep", txtCepCadastro.Text);
                    cmd.Parameters.AddWithValue("cidade", txtCidadeCadastro.Text);
                    cmd.Parameters.AddWithValue("estado", cbUf.Text);
                    cmd.Parameters.AddWithValue("genero", txtGeneroCadastro.Text);
                    cmd.Parameters.AddWithValue("datanasc", Convert.ToDateTime(dtpNascimentoCadastro.Text));
                    cmd.Parameters.AddWithValue("renda", Convert.ToDecimal(txtRendaCadastro.Text));
                    cmd.Parameters.AddWithValue("senhalogin", UsuarioLogado.Senha);

                    conexao.Open();
                    cmd.ExecuteNonQuery();
                    conexao.Close();

                    MessageBox.Show("Alteração feita com sucesso!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void TelaAlterarDados_Load(object sender, EventArgs e)
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
