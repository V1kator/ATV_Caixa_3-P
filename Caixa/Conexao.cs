using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caixa
{
    public static class Conexao
    {
        static MySqlConnection conexao;
        public static MySqlConnection Conectar()
        {
            try
            {
                string sqlconexao = "server=localhost;" +
                    "port=3306;" +
                    "pwd=victor;" +
                    "uid=root;" +
                    "database=ATVCaixa";
                conexao = new MySqlConnection(sqlconexao);
                conexao.Open();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao Conectar" + ex.Message);
            }

            return conexao;

        }

        public static void FecharConexao()
        {
            conexao.Close();
        }
    }
}
