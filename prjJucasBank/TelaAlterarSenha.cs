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
    public partial class TelaAlterarSenha : Form
    {
        public TelaAlterarSenha()
        {
            InitializeComponent();
        }

        private void TelaAlterarSenha_Load(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtnovaSenha.Text == txtconfirmeNovaSenha.Text)
                {
                    SqlConnection conexao =
                    new SqlConnection(ConfigurationManager.ConnectionStrings["prjJucasBank.Properties.Settings.strConexao"].ToString());


                    SqlCommand cmd = new SqlCommand();

                    cmd.CommandText = "pu_AlterarSenha";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conexao;

                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("idCliente", UsuarioLogado.IdCliente);
                    cmd.Parameters.AddWithValue("senhaLogin", txtnovaSenha.Text);

                    conexao.Open();
                    cmd.ExecuteNonQuery();
                    conexao.Close();
                    MessageBox.Show("Senha alterada!", "Informação");
                    UIClear.CleanTxtBoxes(this);
                }

                else
                {
                    throw new Exception("Erro!");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

    }
}

