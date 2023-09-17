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



                }




            }
            catch (Exception)
            {

                throw;
            }


        }
    }
}


