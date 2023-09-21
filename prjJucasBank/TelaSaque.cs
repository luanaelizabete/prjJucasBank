﻿using DTO;
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
    public partial class TelaSaque : Form
    {
        public TelaSaque()
        {
            InitializeComponent();
        }

        private void btConfirmarSaque_Click(object sender, EventArgs e)
        {
            try
            {
                Conta conta = new Conta();

                if (Convert.ToInt32(txtValorDeposito.Text) <= 0 || decimal.TryParse(txtValorDeposito.Text, out decimal result) == false)
                {
                    throw new Exception("Insira um caracter válido. \n ");
                }
                else if (txtValorDeposito.Text == string.Empty)
                {
                    throw new Exception("Insira algum dado.");
                }
                else if (Convert.ToDecimal(txtValorDeposito.Text) > Convert.ToDecimal(lblSaldoVal.Text))
                {
                    throw new Exception("Você não tem dinheiro suficiente para sacar.");
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

                    conta.Saldo = conta.Saldo - Convert.ToDecimal(txtValorDeposito.Text);

                    //Criando uma conexão
                    SqlConnection conexao =
                               new SqlConnection(ConfigurationManager.ConnectionStrings["prjJucasBank.Properties.Settings.strConexao"].ToString());

                    //Criando um comando
                    SqlCommand cmd = new SqlCommand();

                    //criando texto do comando, tipo e conexão que será usada
                    cmd.CommandText = "pi_Conta";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conexao;

                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("idconta", UsuarioLogado.ContaLogada);
                    cmd.Parameters.AddWithValue("idcliente", UsuarioLogado.IdCliente);
                    cmd.Parameters.AddWithValue("saldo", conta.Saldo);
                    cmd.Parameters.AddWithValue("limite", conta.Limite);
                    cmd.Parameters.AddWithValue("tipoconta", conta.TipoConta);
                    cmd.Parameters.AddWithValue("statusconta", conta.StatusConta);
                    if (conta.EncerramentoConta == null)
                    {
                        cmd.Parameters.AddWithValue("encerramentoconta", DBNull.Value);
                    }
                    cmd.Parameters.AddWithValue("senhaconta", conta.SenhaConta);

                    conexao.Open();
                    cmd.ExecuteNonQuery();
                    conexao.Close();

                    UIClear.CleanTxtBoxes(this);
                    lblSaldoVal.Text = conta.Saldo.ToString();
                    MessageBox.Show("Saque realizado com sucesso!", "Info!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void TelaSaque_Load(object sender, EventArgs e)
        {
            foreach (var item in UsuarioLogado.Contas)
                if (item.IdConta == UsuarioLogado.ContaLogada)
                {
                    lblSaldoVal.Text = item.Saldo.ToString();
                }
        }
    }
}

