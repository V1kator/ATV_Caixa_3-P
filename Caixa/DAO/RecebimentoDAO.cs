using Caixa.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caixa.DAO
{
    internal class RecebimentoDAO
    {
        public void Insert(Recebimentos recebimento)
        {
            try
            {
                string sql = "INSERT INTO tb_recebimentos (valor, data_vencimento, data_pagamento, status_recebimento, fk_venda, fk_caixa)" +
                             "VALUES(@valor, @data_vencimento, @data_pagamento, @status_recebimento, @fk_venda, @fk_caixa)";
                MySqlCommand comando = new MySqlCommand(sql, Conexao.Conectar());
                comando.Parameters.AddWithValue("@valor", recebimento.valor);
                comando.Parameters.AddWithValue("@data_vencimento", recebimento.data_vencimento);
                comando.Parameters.AddWithValue("@data_pagamento", recebimento.data_pagamento);
                comando.Parameters.AddWithValue("@status_recebimento", recebimento.status_recebimento);
                comando.Parameters.AddWithValue("@fk_venda", recebimento.fk_venda.id_venda);
                comando.Parameters.AddWithValue("@fk_caixa", recebimento.fk_caixa.id_caixa);
                comando.ExecuteNonQuery();
                Console.WriteLine("Recebimento cadastrado com sucesso!");

            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao cadastrar recebimento: {ex.Message}");
            }
            finally
            {
                Conexao.FecharConexao();
            }
        }

        public List<Recebimentos> List()
        {
            List<Recebimentos> recebimentos = new List<Recebimentos>();

            try
            {
                string sql = "SELECT r.id_recebimento, r.valor, r.data_vencimento, r.data_pagamento, r.status_recebimento, " +
                             "v.id_venda, c.id_caixa " +
                             "FROM tb_recebimentos r " +
                             "INNER JOIN tb_vendas v ON v.id_venda = r.fk_venda " +
                             "INNER JOIN tb_caixas c ON c.id_caixa = r.fk_caixa " +
                             "ORDER BY r.id_recebimento";

                using (var conn = Conexao.Conectar())
                using (var comando = new MySqlCommand(sql, conn))
                using (var dr = comando.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        var recebimento = new Recebimentos
                        {
                            id_recebimento = dr.GetInt32("id_recebimento"),
                            valor = dr.GetDouble("valor"),
                            data_vencimento = dr.GetDateTime("data_vencimento"),
                            data_pagamento = dr.GetDateTime("data_pagamento"),
                            status_recebimento = dr.GetString("status_recebimento"),
                            fk_venda = new Vendas
                            {
                                id_venda = dr.GetInt32("id_venda") 
                            },
                            fk_caixa = new Caixas
                            {
                                id_caixa = dr.GetInt32("id_caixa")
                            }
                        };

                        recebimentos.Add(recebimento);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Erro ao listar recebimentos: {ex.Message}");
                Console.ResetColor();
            }
            finally
            {
                Conexao.FecharConexao();
            }
            return recebimentos;
        }

        public void Update(Recebimentos recebimento)
        {
            try
            {
                string sql = "UPDATE tb_recebimentos SET valor = @valor, data_vencimento = @data_vencimento, data_pagamento = @data_pagamento, " +
                             "status_recebimento = @status_recebimento, fk_venda = @fk_venda, fk_caixa = @fk_caixa " +
                             "WHERE id_recebimento = @id_recebimento";
                MySqlCommand comando = new MySqlCommand(sql, Conexao.Conectar());
                comando.Parameters.AddWithValue("@id_recebimento", recebimento.id_recebimento);
                comando.Parameters.AddWithValue("@valor", recebimento.valor);
                comando.Parameters.AddWithValue("@data_vencimento", recebimento.data_vencimento);
                comando.Parameters.AddWithValue("@data_pagamento", recebimento.data_pagamento);
                comando.Parameters.AddWithValue("@status_recebimento", recebimento.status_recebimento);
                comando.Parameters.AddWithValue("@fk_venda", recebimento.fk_venda.id_venda);
                comando.Parameters.AddWithValue("@fk_caixa", recebimento.fk_caixa.id_caixa);
                comando.ExecuteNonQuery();
                Console.WriteLine("Recebimento atualizado com sucesso!");
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao atualizar recebimento: {ex.Message}");
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
                string sql = "DELETE FROM tb_recebimentos WHERE id_recebimento = @id_recebimento";
                MySqlCommand comando = new MySqlCommand(sql, Conexao.Conectar());
                comando.Parameters.AddWithValue("@id_recebimento", id);
                comando.ExecuteNonQuery();
                Console.WriteLine("Recebimento removido com sucesso!");
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao excluir recebimento: {ex.Message}");
            }
            finally
            {
                Conexao.FecharConexao();
            }
        }

    }
}
