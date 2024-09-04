using Caixa.DAO;
using Caixa.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caixa.Views
{
    public partial class FuncionarioView : Form
    {
        public FuncionarioView()
        {
            InitializeComponent();
            ConfigurarDataGridView();
            ListaFuncionarios();
        }

        private void btn_Adicionar_Click(object sender, EventArgs e)
        {
            try
            {
                Funcionarios funcionario = new Funcionarios
                {
                    nome = txt_Nome.Text,
                    cpf = txt_cpf.Text
                };

                FuncionarioDAO funcionarioDAO = new FuncionarioDAO();
                funcionarioDAO.Insert(funcionario);
                ListaFuncionarios();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao adicionar funcionário: " + ex.Message);
            }
            finally
            {
                Conexao.FecharConexao();
            }
        }

        private void btn_Atualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_Funcionarios.SelectedRows.Count > 0)
                {
                    foreach (DataGridViewRow row in dgv_Funcionarios.SelectedRows)
                    {
                        int idFuncionario = Convert.ToInt32(row.Cells["id_funcionario"].Value);

                        Funcionarios funcionario = new Funcionarios
                        {
                            id_funcionario = idFuncionario,
                            nome = txt_Nome.Text,
                            cpf = txt_cpf.Text
                        };

                        FuncionarioDAO funcionarioDAO = new FuncionarioDAO();
                        funcionarioDAO.Update(funcionario);
                    }

                    ListaFuncionarios();
                }
                else
                {
                    MessageBox.Show("Por favor, selecione pelo menos um funcionário para atualizar.", "Nenhum Funcionário Selecionado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar funcionário: " + ex.Message);
            }
            finally
            {
                Conexao.FecharConexao();
            }
        }

        private void btn_Deletar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_Funcionarios.SelectedRows.Count > 0)
                {
                    DialogResult result = MessageBox.Show("Você tem certeza que deseja excluir o(s) funcionário(s) selecionado(s)?", "Confirmar Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        List<int> idsParaExcluir = new List<int>();

                        foreach (DataGridViewRow row in dgv_Funcionarios.SelectedRows)
                        {
                            int idFuncionario = Convert.ToInt32(row.Cells["id_funcionario"].Value);
                            idsParaExcluir.Add(idFuncionario);
                        }

                        FuncionarioDAO funcionarioDAO = new FuncionarioDAO();
                        foreach (int id in idsParaExcluir)
                        {
                            funcionarioDAO.Delete(id);
                        }

                        ListaFuncionarios();
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, selecione pelo menos um funcionário para excluir.", "Nenhum Funcionário Selecionado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir funcionário(s): " + ex.Message);
            }
            finally
            {
                Conexao.FecharConexao();
            }
        }

        private void ConfigurarDataGridView()
        {            
            dgv_Funcionarios.AllowUserToAddRows = false;
            dgv_Funcionarios.AllowUserToDeleteRows = false;
            dgv_Funcionarios.ReadOnly = true;
            dgv_Funcionarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_Funcionarios.BackgroundColor = System.Drawing.Color.White;
            dgv_Funcionarios.BorderStyle = BorderStyle.Fixed3D;
            dgv_Funcionarios.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Blue;
            dgv_Funcionarios.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;

        }

        private void ListaFuncionarios()
        {
            try
            {
                FuncionarioDAO funcionarioDAO = new FuncionarioDAO();
                List<Funcionarios> funcionarios = funcionarioDAO.List();

                dgv_Funcionarios.DataSource = funcionarios.Select(f => new
                {
                    f.id_funcionario,
                    f.nome,
                    f.cpf
                }).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar funcionários: " + ex.Message);
            }
            finally
            {
                Conexao.FecharConexao();
            }
        }
    }
}
