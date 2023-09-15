using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace prjJucasBank
{
    public static class UsuarioLogado
    {
        public static int IdCliente { get; set; }
        public static string? Nome { get; set; }
        public static DateTime? DataNascimento { get; set; }
        public static string? Rg { get; set; }
        public static string? Cpf { get; set; }
        public static string? Email { get; set; }
        public static string? Endereco { get; set; }
        public static string? NumEndereco { get; set; }
        public static string? Cidade { get; set; }
        public static string? Estado { get; set; }
        public static string? Cep { get; set; }
        public static string? Celular { get; set; }
        public static string? Senha { get; set; }
        public static string? Genero { get; set; }
        public static Decimal Renda { get; set; }
        public static int ContaLogada { get; set; }


        public static List<Conta> Contas = new List<Conta>();



        public static void Deslogar()
        {
            UsuarioLogado.IdCliente = 0;
            UsuarioLogado.Nome = String.Empty;
            UsuarioLogado.DataNascimento = null;
            UsuarioLogado.Rg = String.Empty;
            UsuarioLogado.Cpf = String.Empty;
            UsuarioLogado.Email = String.Empty;
            UsuarioLogado.Endereco = String.Empty;
            UsuarioLogado.NumEndereco = String.Empty;
            UsuarioLogado.Cidade = String.Empty;
            UsuarioLogado.Estado = String.Empty;
            UsuarioLogado.Cep = String.Empty;
            UsuarioLogado.Celular = String.Empty;
            UsuarioLogado.Senha = String.Empty;
            UsuarioLogado.Contas.Clear();
            UsuarioLogado.Genero = String.Empty;
            UsuarioLogado.Renda = 0;

        }
    }
}

