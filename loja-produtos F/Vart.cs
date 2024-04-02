using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loja_produtos_F
{
    internal class Vart
    {
        public static string servidor = "server=localhost;Database=bd_vendas;Uid=root;Pwd=";
        public static MySqlConnection conexao = new MySqlConnection(servidor);
        public static MySqlCommand comando = conexao.CreateCommand();
        public static string id_func = "1";
        public static string id_cliente = "1";
        public static double carrinho = 0;
    }
}
