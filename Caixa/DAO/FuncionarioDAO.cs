using Caixa.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caixa.DAO
{
    internal class FuncionarioDAO
    {
        public void Insert(Funcionarios funcionario)
        {
            try
            {
                string sql = "INSERT INTO tb_funcionarios (nome, cpf) VALUES (@nome, @cpf)";
                using (MySqlConnection conn = Conexao.Conectar())
                using (MySqlCommand comando = new MySqlCommand(sql, conn))
                {
                    comando.Parameters.AddWithValue("@nome", funcionario.nome);
                    comando.Parameters.AddWithValue("@cpf", funcionario.cpf);
                    comando.ExecuteNonQuery();
                }
                Console.WriteLine("Funcionário cadastrado com sucesso!");
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao cadastrar funcionário: {ex.Message}");
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
                string sql = "DELETE FROM tb_funcionarios WHERE id_funcionario = @id_funcionario";
                using (MySqlConnection conn = Conexao.Conectar())
                using (MySqlCommand comando = new MySqlCommand(sql, conn))
                {
                    comando.Parameters.AddWithValue("@id_funcionario", id);
                    comando.ExecuteNonQuery();
                }
                Console.WriteLine("Funcionário excluído com sucesso!");
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao excluir funcionário: {ex.Message}");
            }
            finally
            {
                Conexao.FecharConexao();
            }
        }

        public void Update(Funcionarios funcionario)
        {
            try
            {
                string sql = "UPDATE tb_funcionarios SET nome = @nome, cpf = @cpf WHERE id_funcionario = @id_funcionario";
                using (MySqlConnection conn = Conexao.Conectar())
                using (MySqlCommand comando = new MySqlCommand(sql, conn))
                {
                    comando.Parameters.AddWithValue("@nome", funcionario.nome);
                    comando.Parameters.AddWithValue("@cpf", funcionario.cpf);
                    comando.Parameters.AddWithValue("@id_funcionario", funcionario.id_funcionario);
                    comando.ExecuteNonQuery();
                }
                Console.WriteLine("Funcionário atualizado com sucesso!");
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao atualizar funcionário: {ex.Message}");
            }
            finally
            {
                Conexao.FecharConexao();
            }
        }

        public List<Funcionarios> List()
        {
            List<Funcionarios> funcionarios = new List<Funcionarios>();
            try
            {
                string sql = "SELECT * FROM tb_funcionarios ORDER BY id_funcionario";
                using (MySqlConnection conn = Conexao.Conectar())
                using (MySqlCommand comando = new MySqlCommand(sql, conn))
                using (MySqlDataReader dr = comando.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Funcionarios funcionario = new Funcionarios
                        {
                            id_funcionario = dr.GetInt32("id_funcionario"),
                            nome = dr.GetString("nome"),
                            cpf = dr.GetString("cpf")
                        };
                        funcionarios.Add(funcionario);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Erro ao listar funcionários: {ex.Message}");
                Console.ResetColor();
            }
            finally
            {
                Conexao.FecharConexao();
            }
            return funcionarios;
        }
    }
}
