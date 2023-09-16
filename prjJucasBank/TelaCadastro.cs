using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace PrjtAula01
{
    public partial class TelaCadastro : Form
    {
        public TelaCadastro()
        {
            InitializeComponent();
        }

        private void LblInserirDadosCadastro_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtNomeCadastro_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(txtNomeCadastro.Text, out var valorDigitado))
            {
                txtNomeCadastro.Clear();
            }
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TxtRendaCadastro_TextChanged(object sender, EventArgs e)
        {

        }

        private void TelaCadastro_Load(object sender, EventArgs e)
        {

        }

        private void BtnCriarAcesso_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSenhaCadastro.Text == txtSenhaConfirmaCadastro.Text)
                {
                    SqlConnection conexao =
                    new SqlConnection(ConfigurationManager.ConnectionStrings["prjJucasBank.Properties.Settings.strConexao"].ToString());

                    //Criando um comando
                    SqlCommand cmd = new SqlCommand();

                    //criando texto do comando, tipo e conexão que será usada
                    cmd.CommandText = "pi_Cliente";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conexao;

                    //inserindo parâmetros na procedure
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("Nome", txtNomeCadastro.Text);
                    cmd.Parameters.AddWithValue("Email", txtEmailCadastro.Text);
                    cmd.Parameters.AddWithValue("Celular", txtCelularCadastro.Text);
                    cmd.Parameters.AddWithValue("dtNasc", Convert.ToDateTime(dtpNascimentoCadastro.Text));
                    cmd.Parameters.AddWithValue("Genero", txtGeneroCadastro.Text);
                    cmd.Parameters.AddWithValue("Cidade", txtCidadeCadastro.Text);
                    cmd.Parameters.AddWithValue("Uf", cbUf.Text);
                    cmd.Parameters.AddWithValue("Cep", txtCepCadastro.Text);
                    cmd.Parameters.AddWithValue("Endereco", txtEnderecoCadastro.Text);
                    cmd.Parameters.AddWithValue("numeroEndereco", txtNumEnderecoCadastro.Text);
                    cmd.Parameters.AddWithValue("Cpf", txtCpfCadastro.Text);
                    cmd.Parameters.AddWithValue("Rg", txtRgCadastro.Text);
                    cmd.Parameters.AddWithValue("Renda", txtRendaCadastro.Text);
                    cmd.Parameters.AddWithValue("Senha", txtSenhaCadastro.Text);

                    conexao.Open();
                    cmd.ExecuteNonQuery();
                    conexao.Close();
                    MessageBox.Show("Cadastro realizado com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    prjJucasBank.UIClear.CleanTxtBoxes(this);
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

        private void TxtNumLogCad_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtLogradCad_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRetornarCadastro_Click(object sender, EventArgs e)
        {

        }
    }
}
