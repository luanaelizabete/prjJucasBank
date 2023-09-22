using DTO;
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
            try
            {
                SqlConnection conexao =
            new SqlConnection(ConfigurationManager.ConnectionStrings["prjJucasBank.Properties.Settings.strConexao"].ToString());
                SqlDataReader leitor;

                SqlCommand cmd = new SqlCommand();

                cmd.CommandText = "ps_validarLogin";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conexao;

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("cpf", txtUsuarioLogin.Text);
                cmd.Parameters.AddWithValue("senhaLogin", txtSenhaLogin.Text);

                conexao.Open();


                leitor = cmd.ExecuteReader();

                if (leitor.HasRows)
                {
                    leitor.Read();

                    UsuarioLogado.IdCliente = leitor.GetInt32(0);
                    UsuarioLogado.Nome = leitor.GetString(1);
                    UsuarioLogado.Cpf = leitor.GetString(2);
                    if (!leitor.IsDBNull(3))
                    {
                        UsuarioLogado.Rg = leitor.GetString(3);
                    }
                    UsuarioLogado.Celular = leitor.GetString(4);
                    UsuarioLogado.Email = leitor.GetString(5);
                    UsuarioLogado.Endereco = leitor.GetString(6);
                    UsuarioLogado.NumEndereco = leitor.GetString(7);
                    UsuarioLogado.Cep = leitor.GetString(8);
                    UsuarioLogado.Cidade = leitor.GetString(9);
                    UsuarioLogado.Estado = leitor.GetString(10);
                    UsuarioLogado.Genero = leitor.GetString(11);
                    UsuarioLogado.DataNascimento = leitor.GetDateTime(12);
                    UsuarioLogado.Renda = leitor.GetDecimal(13);
                    UsuarioLogado.Senha = leitor.GetString(14);

                    leitor.Close();

                    cmd.CommandText = "ps_buscaContaPorIdCliente";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conexao;

                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("IdCliente", UsuarioLogado.IdCliente);

                    leitor = cmd.ExecuteReader();


                    if (leitor.HasRows)
                    {

                        while (leitor.Read())
                        {

                            Conta conta = new Conta();

                            conta.IdConta = leitor.GetInt32(0);
                            conta.IdCliente = leitor.GetInt32(1);
                            conta.Saldo = leitor.GetDecimal(2);
                            conta.StatusConta = leitor.GetString(5);
                            conta.TipoConta = leitor.GetString(4);
                            conta.Limite = leitor.GetDecimal(3);
                            conta.AberturaConta = leitor.GetDateTime(6);
                            if (!leitor.IsDBNull(7))
                            {
                                conta.EncerramentoConta = leitor.GetDateTime(7);
                            }
                            conta.SenhaConta = leitor.GetString(8);

                            UsuarioLogado.Contas.Add(conta);
                        }
                    }
                    leitor.Close();
                    conexao.Close();

                    Form TelaLogin = Application.OpenForms["TelaLogin"];
                    using (MenuStrip menuPrincipal = (MenuStrip)TelaLogin.Controls[0])
                    {
                        menuPrincipal.Items[0].Text = "Logout";
                        menuPrincipal.Items[1].Visible = false;
                        menuPrincipal.Items[2].Visible = true;
                        menuPrincipal.Items[3].Visible = true;
                        menuPrincipal.Items[4].Visible = true;
                        menuPrincipal.Items[5].Visible = true;
                        menuPrincipal.Items[5].Text = UsuarioLogado.Nome;
                        menuPrincipal.Items[6].Visible = true;


                        if (UsuarioLogado.Contas.Count == 0)
                        {
                            menuPrincipal.Items[4].Text = "não há contas";
                            MessageBox.Show($"Olá,{UsuarioLogado.Nome}");
                        }
                        else
                        {
                            menuPrincipal.Items[4].Text = $"Conta: {UsuarioLogado.Contas[0].IdCliente.ToString()}";

                            MessageBox.Show($"Olá,{UsuarioLogado.Nome}!\n" +
                                $"Você foi logado na conta {UsuarioLogado.Contas[0].IdCliente.ToString()}\n");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Usuário ou senha incorretos.");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void btnCriarCadastro_Click(object sender, EventArgs e)
        {
            TelaCadastro TelaLoginBanco = new TelaCadastro();
            TelaLoginBanco.Show();
        }

        private void txtUsuarioLogin_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
