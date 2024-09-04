using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caixa.Models;
using MySql.Data.MySqlClient;

namespace Caixa.DAO
{
    internal class CaixaDAO
    {
        public void Insert(Caixas caixa)
        {
            try
            {
                string sql = "INSERT INTO tb_caixas (saldo_inicial, total_entradas, total_saidas, status_caixa, saldo_final, fk_funcionario)" +
                "VALUES(@saldo_inicial, @total_entradas, @total_saidas, @status_caixa, @saldo_final, @fk_funcionario)";
                MySqlCommand comando = new MySqlCommand(sql, Conexao.Conectar());
                comando.Parameters.AddWithValue("@saldo_inicial", caixa.saldo_inicial);
                comando.Parameters.AddWithValue("@total_entradas", caixa.total_entradas);
                comando.Parameters.AddWithValue("@total_saidas", caixa.total_saidas);
                comando.Parameters.AddWithValue("@status_caixa", caixa.status_caixa);
                comando.Parameters.AddWithValue("@saldo_final", caixa.saldo_final);
                comando.Parameters.AddWithValue("@fk_funcionario", caixa.fk_funcionario.id_funcionario);
                comando.ExecuteNonQuery();
                Console.WriteLine("caixa cadastrado com sucesso!");
                Conexao.FecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao Cadastrar caixa! {ex.Message}");
            }
            finally
            {
                Conexao.FecharConexao();
            }
        }

        public void Delete(int id)
        {
            try
            {
                string sql = "DELETE FROM tb_Caixas WHERE id_caixa = @id_caixa";

                using (MySqlConnection conectar = Conexao.Conectar())
                using (MySqlCommand comando = new MySqlCommand(sql, conectar))
                {
                    comando.Parameters.AddWithValue("@id_caixa", id);
                    comando.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao excluir caixa: " + ex.Message);
            }
            finally
            {
                Conexao.FecharConexao();
            }
        }

        public void Update(Caixas caixa)
        {
            try
            {
                string sql = "UPDATE tb_Caixas SET saldo_inicial = @saldo_inicial, total_entradas = @total_entradas, total_saidas = @total_saidas, status_caixa = @status_caixa, saldo_final = @saldo_final, fk_funcionario = @fk_funcionario WHERE id_caixa = @id_caixa";

                using (MySqlConnection conectar = Conexao.Conectar())
                using (MySqlCommand comando = new MySqlCommand(sql, conectar))
                {
                    comando.Parameters.AddWithValue("@saldo_inicial", caixa.saldo_inicial);
                    comando.Parameters.AddWithValue("@total_entradas", caixa.total_entradas);
                    comando.Parameters.AddWithValue("@total_saidas", caixa.total_saidas);
                    comando.Parameters.AddWithValue("@status_caixa", caixa.status_caixa);
                    comando.Parameters.AddWithValue("@saldo_final", caixa.saldo_final);
                    comando.Parameters.AddWithValue("@fk_funcionario", caixa.fk_funcionario.id_funcionario);
                    comando.Parameters.AddWithValue("@id_caixa", caixa.id_caixa);

                    comando.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao atualizar caixa: " + ex.Message);
            }
            finally
            {
                Conexao.FecharConexao();
            }
        }

        public List<Caixas> List()
        {
            List<Caixas> caixas = new List<Caixas>();
            try
            {
                string sql = "SELECT * FROM tb_caixas AS cx " +
                             "INNER JOIN tb_funcionarios AS f ON f.id_funcionario = cx.fk_funcionario " +
                             "ORDER BY id_caixa";

                using (MySqlConnection conn = Conexao.Conectar())
                using (MySqlCommand comando = new MySqlCommand(sql, conn))
                using (MySqlDataReader dr = comando.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Caixas caixa = new Caixas
                        {
                            id_caixa = dr.GetInt32("id_caixa"),
                            saldo_inicial = dr.GetDouble("saldo_inicial"),
                            total_entradas = dr.GetDouble("total_entradas"),
                            total_saidas = dr.GetDouble("total_saidas"),
                            status_caixa = dr.GetString("status_caixa"),
                            saldo_final = dr.GetDouble("saldo_final"),
                            fk_funcionario = new Funcionarios
                            {
                                id_funcionario = dr.GetInt32("id_funcionario"),
                                nome = dr.GetString("nome"),
                                cpf = dr.GetString("cpf")
                            }
                        };
                        caixas.Add(caixa);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Erro ao listar caixas: {ex.Message}");
                Console.ResetColor();
            }
            finally
            {
                Conexao.FecharConexao();
            }
            return caixas;
        }


    }
}
