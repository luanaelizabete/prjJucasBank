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


namespace TelaDeposito
{
    public partial class TelaDeposito : Form
    {
        public TelaDeposito()
        {
            InitializeComponent();
        }

        private void btnConfirmarDeposito_Click(object sender, EventArgs e)
        {
            try
            {
                Conta conta = new Conta();

                if (Convert.ToInt32(txtvalorDeposito.Text) <= 0 || decimal.TryParse(txtvalorDeposito.Text, out decimal result) == false)
                {
                    throw new Exception("Insira um caracter válido");
                }
                else if (txtvalorDeposito.Text == string.Empty)
                {
                    throw new Exception("Preencha os dados!");
                }
                else
                {
                    foreach (var item in UsuarioLogado.Contas)
                    {
                        if (item.IdConta == UsuarioLogado.ContaLogada)
                        {
                            conta = item;
                        }
                    }


                    conta.Saldo = conta.Saldo + Convert.ToDecimal(txtvalorDeposito.Text);


                    SqlConnection conexao =
                               new SqlConnection(ConfigurationManager.ConnectionStrings["prjJucasBank.Properties.Settings.strConexao"].ToString());


                    SqlCommand cmd = new SqlCommand();


                    cmd.CommandText = "pi_Conta";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conexao;

                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("idConta", UsuarioLogado.ContaLogada);
                    cmd.Parameters.AddWithValue("idCliente", UsuarioLogado.IdCliente);
                    cmd.Parameters.AddWithValue("saldo", conta.Saldo);
                    cmd.Parameters.AddWithValue("limite", conta.Limite);
                    cmd.Parameters.AddWithValue("tipoConta", conta.TipoConta);
                    cmd.Parameters.AddWithValue("statusConta", conta.StatusConta);
                    if (conta.EncerramentoConta == null)
                    {
                        cmd.Parameters.AddWithValue("encerramentoConta", DBNull.Value);
                    }
                    cmd.Parameters.AddWithValue("senhaConta", conta.SenhaConta);

                    conexao.Open();
                    cmd.ExecuteNonQuery();
                    conexao.Close();

                    UIClear.CleanTxtBoxes(this);
                    lblValorSaldo.Text = conta.Saldo.ToString();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                throw;
            }


        }

        private void lblDepositoConfirmado_Click(object sender, EventArgs e)
        {

        }
    }
}


