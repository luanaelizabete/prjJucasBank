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
    public partial class TelaCadastro : Form
    {
        public TelaCadastro()
        {
            InitializeComponent();
        }

        private void TelaCadastro_Load(object sender, EventArgs e)
        {

        }

        private void txtNomeCadastro_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(txtNomeCadastro.Text, out var valorDigitado))
            {
                txtNomeCadastro.Clear();
            }
        }

        private void btnCriarAcesso_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSenhaCadastro.Text == txtSenhaConfirmaCadastro.Text)
                {

                    SqlConnection conexao =
                    new SqlConnection(ConfigurationManager.ConnectionStrings["prjJucasBank.Properties.Settings.strConexao"].ToString());

                   
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "pi_Cliente";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conexao;

                  
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("nome", txtNomeCadastro.Text);
                    cmd.Parameters.AddWithValue("email", txtEmailCadastro.Text);
                    cmd.Parameters.AddWithValue("celular", txtCelularCadastro.Text);
                    cmd.Parameters.AddWithValue("dataNascimento", Convert.ToDateTime(dtpNascimentoCadastro.Text));
                    cmd.Parameters.AddWithValue("genero", txtGeneroCadastro.Text);
                    cmd.Parameters.AddWithValue("cidade", txtCidadeCadastro.Text);
                    cmd.Parameters.AddWithValue("estado", cbUf.Text);
                    cmd.Parameters.AddWithValue("cep", txtCepCadastro.Text);
                    cmd.Parameters.AddWithValue("endereco", txtEnderecoCadastro.Text);
                    cmd.Parameters.AddWithValue("numeroEndereco", txtNumEnderecoCadastro.Text);
                    cmd.Parameters.AddWithValue("cpf", txtCpfCadastro.Text);
                    cmd.Parameters.AddWithValue("rg", txtRgCadastro.Text);
                    cmd.Parameters.AddWithValue("renda", txtRendaCadastro.Text);
                    cmd.Parameters.AddWithValue("senhaLogin", txtSenhaCadastro.Text);

                    conexao.Open();
                    cmd.ExecuteNonQuery();
                    conexao.Close();
                    MessageBox.Show("Cadastro realizado com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   UIClear.CleanTxtBoxes(this);
                }
                else
                {
                    throw new Exception("As senhas não coincidem!");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro durante o cadastro! ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRetornarCadastro_Click(object sender, EventArgs e)
        {

            this.Close();
        }
    }
}
