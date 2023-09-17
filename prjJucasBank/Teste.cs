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
    public partial class Teste : Form
    {
        ContaAntiga minhaConta;
        public Teste()
        {
            InitializeComponent();
        }

        private void Teste_Load(object sender, EventArgs e)
        {
            ContaAntiga minhaConta;
            minhaConta = new ContaAntiga(1, 0, 2040, "Ativa", 0, DateTime.Now, null, "Poupança");
        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {

            try
            {


                if (txtvalorDeposito.Text == String.Empty)
                {
                    throw new Exception("Digite um valor:");
                }


                lblTotalSaldo.Text = $"Saldo: R$ {minhaConta.Depositar(Convert.ToDouble(txtvalorDeposito.Text)).ToString("n2")}.";

                //MessageBox.Show(Conta.RetornarSaldoTodasContas(), "Valor Total de depósitos");
                txtvalorDeposito.Clear();
                txtvalorDeposito.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnSaque_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtvalorDeposito.Text == String.Empty)
                {
                    throw new Exception("Digite um valor:");
                }

                lblTotalSaldo.Text = $"Saldo: R$ {minhaConta.Sacar(Convert.ToDouble(txtvalorDeposito.Text)).ToString("n2")}.";
                txtvalorDeposito.Clear();
                txtvalorDeposito.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                txtvalorDeposito.Focus();
            }

        }

        private void btnVerSaldo_Click(object sender, EventArgs e)
        {
            {
                lblTotalSaldo.Text = $"Saldo: R$ {minhaConta.Saldo.ToString("n2")}";
                lblTotalSaldo.Show();
            }
        }

        private void txtVlrDpst_TextChanged(object sender, EventArgs e)
        {
            if (!double.TryParse(txtvalorDeposito.Text, out var valorDigitado))
            {
                txtvalorDeposito.Clear();
            }
        }

        private void btnEsconderSaldo_Click(object sender, EventArgs e)
        {
            lblTotalSaldo.Hide();
        }
    }
}


