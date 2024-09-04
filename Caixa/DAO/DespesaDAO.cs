using Caixa.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caixa.DAO
{
    internal class DespesaDAO
    {
        public void Insert(Despesas Despesas)
        {
            try
            {
                string sql = "INSERT INTO tb_Despesa (valor, data_vencimento, data_pagamento, status_Despesa, fk_caixa, fk_fornecedor) " +
                             "VALUES (@valor, @data_vencimento, @data_pagamento, @status_Despesa, @fk_caixa, @fk_fornecedor)";
                MySqlCommand comando = new MySqlCommand(sql, Conexao.Conectar());
                comando.Parameters.AddWithValue("@valor", Despesas.valor);
                comando.Parameters.AddWithValue("@data_vencimento", Despesas.data_vencimento);
                comando.Parameters.AddWithValue("@data_pagamento", Despesas.data_pagamento);
                comando.Parameters.AddWithValue("@status_Despesa", Despesas.status_Despesas);
                comando.Parameters.AddWithValue("@fk_caixa", Despesas.fk_caixa.id_caixa);
                comando.Parameters.AddWithValue("@fk_fornecedor", Despesas.fk_fornecedor.id_fornecedor);
                comando.ExecuteNonQuery();
                Console.WriteLine("Despesas cadastrada com sucesso!");
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao cadastrar Despesas: {ex.Message}");
            }
            finally
            {
                Conexao.FecharConexao();
            }
        }

        public void Update(Despesas despesas)
        {
            try
            {
                string sql = "UPDATE tb_Despesa SET valor = @valor, data_vencimento = @data_vencimento, data_pagamento = @data_pagamento, " +
                             "status_despesa = @status_despesa, fk_caixa = @fk_caixa, fk_fornecedor = @fk_fornecedor " +
                             "WHERE id_despesa = @id_despesa";

                MySqlCommand comando = new MySqlCommand(sql, Conexao.Conectar());
                {
                    comando.Parameters.AddWithValue("@id_despesa", despesas.id_despesa);
                    comando.Parameters.AddWithValue("@valor", despesas.valor);
                    comando.Parameters.AddWithValue("@data_vencimento", despesas.data_vencimento);
                    comando.Parameters.AddWithValue("@data_pagamento", despesas.data_pagamento);
                    comando.Parameters.AddWithValue("@status_despesa", despesas.status_Despesas);
                    comando.Parameters.AddWithValue("@fk_caixa", despesas.fk_caixa.id_caixa);
                    comando.Parameters.AddWithValue("@fk_fornecedor", despesas.fk_fornecedor.id_fornecedor);

                    comando.ExecuteNonQuery();
                    Console.WriteLine("Despesa atualizada com sucesso!");
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao atualizar despesa: {ex.Message}", ex);
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
                string sql = "DELETE FROM tb_Despesa WHERE id_Despesa = @id_Despesas";
                MySqlCommand comando = new MySqlCommand(sql, Conexao.Conectar());
                comando.Parameters.AddWithValue("@id_Despesas", id);
                comando.ExecuteNonQuery();
                Console.WriteLine("Despesas removida com sucesso!");
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao excluir Despesas: {ex.Message}");
            }
            finally
            {
                Conexao.FecharConexao();
            }
        }

        public List<Despesas> List()
        {
            List<Despesas> despesas = new List<Despesas>();

            try
            {
                string sql = "SELECT d.id_despesa, d.valor, d.data_vencimento, d.data_pagamento, d.status_despesa, " +
                             "c.id_caixa, f.nome " +
                             "FROM tb_despesa d " +
                             "INNER JOIN tb_caixas c ON c.id_caixa = d.fk_caixa " +
                             "INNER JOIN tb_fornecedores f ON f.id_fornecedor = d.fk_fornecedor " +
                             "ORDER BY d.id_despesa";

                using (var conn = Conexao.Conectar())
                using (var comando = new MySqlCommand(sql, conn))
                using (var dr = comando.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        var despesa = new Despesas
                        {
                            id_despesa = dr.GetInt32("id_despesa"),
                            valor = dr.GetDouble("valor"),
                            data_vencimento = dr.GetDateTime("data_vencimento"),
                            data_pagamento = dr.GetDateTime("data_pagamento"),
                            status_Despesas = dr.GetString("status_despesa"),
                            fk_caixa = new Caixas
                            {
                                
                                id_caixa = dr.GetInt32("id_caixa")
                            },
                            fk_fornecedor = new Fornecedores
                            {                                
                                nome = dr.GetString("nome"),
                                
                            }
                        };

                        despesas.Add(despesa);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Erro ao listar despesas: {ex.Message}");
                Console.ResetColor();
            }
            finally
            {
                Conexao.FecharConexao();
            }
            return despesas;
        }

    }
}
