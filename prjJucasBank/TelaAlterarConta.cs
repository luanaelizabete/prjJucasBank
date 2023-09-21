﻿using System;
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
    public partial class TelaAlterarConta : Form
    {
        public TelaAlterarConta()
        {
            InitializeComponent();
        }

        private void TelaAlterarConta_Load(object sender, EventArgs e)
        {
            foreach (var item in UsuarioLogado.Contas)
            {
                cbContas.Items.Add(item.IdConta);
            }
            cbContas.Text = cbContas.Items[0].ToString();
        }

        private void btAlterarConta_Click(object sender, EventArgs e)
        {
            try
            {

                SqlConnection conexao =
                new SqlConnection(ConfigurationManager.ConnectionStrings["prjJucasBank.Properties.Settings.strConexao"].ToString());
                SqlDataReader leitor;

                SqlCommand cmd = new SqlCommand();

                cmd.CommandText = "ps_validarSenhaConta";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conexao;

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("idconta", cbContas.Text);
                cmd.Parameters.AddWithValue("senhaConta", txtSenhaContaAlt.Text);

                conexao.Open();

                leitor = cmd.ExecuteReader();

                if (leitor.HasRows)
                {
                    UsuarioLogado.ContaLogada = Convert.ToInt32(cbContas.Text);
                    MessageBox.Show($"Você está na sua conta {UsuarioLogado.ContaLogada}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Form telaLogin = Application.OpenForms["TelaLogin"];
                    MenuStrip menuStrip = (MenuStrip)telaLogin.Controls[0];
                    menuStrip.Items[9].Text = $"Conta: {UsuarioLogado.ContaLogada}";

                    telaLogin.Show();
                    this.Close();
                }
                else
                {
                    throw new Exception("Senha Incorreta.");
                }

                conexao.Close();
                UIClear.CleanTxtBoxes(this);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cbContas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

