using prjJucasBank;
using DTO;
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
    public partial class FormCollection : Form
    {
        public FormCollection()
        {
            InitializeComponent();
        }

        private void Btnadicionar_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente cliente = new Cliente(Convert.ToInt32(txtId.Text), txtnomecliente.Text);

                MessageBox.Show($"Cliente adicionado com sucesso!\n\n{cliente.Id}-{cliente.Nome}",
                    "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Cliente.Add(cliente);
            }
            catch (FormatException ex)
            {
                MessageBox.Show($"{ex.HResult} que paia, bota um número dahora aí tio.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.HResult} - {ex.Message}");
            }


            txtnomecliente.Clear();
            txtId.Clear();
            txtId.Focus();
        }

        private void Btnlistar_Click(object sender, EventArgs e)
        {
            Lstinfo.Items.Clear();
            foreach (var cliente in Cliente)
            {
                //MessageBox.Show($"{cliente.Id}: {cliente.Nome}");
                Lstinfo.Items.Add($"{cliente.Id}-{cliente.Nome}");
            }

        }

        private void FormCollection_Load(object sender, EventArgs e)
        {
         
            string[] meuArrayString = new string[3];

           
            int[] meuArrayInt = { 2, 7, 8, 9, 11 };

           
            meuArrayString[0] = "tobibas";
          
            string mensagemFinal = "";

            for (int contador = 0; contador < meuArrayString.Length; contador++)
            {
                mensagemFinal = mensagemFinal + $"{meuArrayString[contador]}\n";
            }
            MessageBox.Show(meuArrayString[0]);


        }
    }
    }


