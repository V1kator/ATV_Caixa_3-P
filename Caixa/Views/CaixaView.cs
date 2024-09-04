using Caixa.DAO;
using Caixa.Models;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Esf;
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
    public partial class CaixaView : Form
    {
        public CaixaView()
        {
            InitializeComponent();
            cbx_Funcionario.DataSource = ObterFuncionarios();
            cbx_Funcionario.DisplayMember = "nome";
            cbx_Funcionario.ValueMember = "id_funcionario";
            cbx_StatusCaixa.Items.Add("ABERTO");
            cbx_StatusCaixa.Items.Add("FECHADO");
            ConfigurarDataGridView();
            ListaCaixas();

        }

        private void Caixa_Load(object sender, EventArgs e)
        {
           
        }

        public List<Funcionarios> ObterFuncionarios()
        {

            List<Funcionarios> funcionarios = new List<Funcionarios>();
            try
            {
                string sql = "SELECT id_funcionario, nome FROM tb_funcionarios";


                using (MySqlConnection conectar = Conexao.Conectar())
                using (MySqlCommand comando = new MySqlCommand(sql, conectar))
                using (MySqlDataReader dr = comando.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Funcionarios fun = new Funcionarios
                        {
                            id_funcionario = dr.GetInt32("id_funcionario"),
                            nome = dr.GetString("nome")
                        };
                        funcionarios.Add(fun);
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar funcionários: " + ex.Message);
            }
            return funcionarios;

        }

        private void btn_InserirCaixa_Click(object sender, EventArgs e)
        {
            try
            {
                Caixas cx = new Caixas();
                cx.saldo_inicial = Convert.ToDouble(txt_SaldoInicial.Text);
                cx.total_entradas = Convert.ToDouble(txt_TotalEntradas.Text);
                cx.total_saidas = Convert.ToDouble(txt_TotalSaidas.Text);
                cx.status_caixa = (string)cbx_StatusCaixa.SelectedItem;
                cx.saldo_final = (cx.total_entradas + cx.saldo_inicial) - cx.total_saidas;
                Funcionarios funcionarioSelecionado = (Funcionarios)cbx_Funcionario.SelectedItem;
                cx.fk_funcionario = funcionarioSelecionado;

                CaixaDAO cxdao = new CaixaDAO();
                cxdao.Insert(cx);
                ListaCaixas();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao adicionar Caixa: " + ex.Message);
            }
            finally
            {
                Conexao.FecharConexao();
            }
            
        }

        private void ConfigurarDataGridView()
        {            
            dgv_Caixas.AllowUserToAddRows = false;
            dgv_Caixas.AllowUserToDeleteRows = false;
            dgv_Caixas.ReadOnly = true;
            dgv_Caixas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_Caixas.BackgroundColor = System.Drawing.Color.White;
            dgv_Caixas.BorderStyle = BorderStyle.Fixed3D;
            dgv_Caixas.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Blue;
            dgv_Caixas.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;

        }

        private void ListaCaixas()
        {
            try
            {
                CaixaDAO caixaDAO = new CaixaDAO();
                List<Caixas> caixas = caixaDAO.List();
                
                var dados = caixas.Select(c => new
                {
                    c.id_caixa,
                    c.saldo_inicial,
                    c.total_entradas,
                    c.total_saidas,
                    c.status_caixa,
                    c.saldo_final,
                    FuncionarioId = c.fk_funcionario.nome
                }).ToList();
                dgv_Caixas.DataSource = dados;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar caixas: " + ex.Message);
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
                
                if (dgv_Caixas.SelectedRows.Count > 0)
                {
                    
                    DialogResult result = MessageBox.Show("Você tem certeza que deseja excluir o(s) caixa(s) selecionado(s)?", "Confirmar Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        
                        List<int> idsParaExcluir = new List<int>();

                        
                        foreach (DataGridViewRow row in dgv_Caixas.SelectedRows)
                        {
                            int idCaixa = Convert.ToInt32(row.Cells["id_caixa"].Value);
                            idsParaExcluir.Add(idCaixa);
                        }

                        
                        CaixaDAO cxdao = new CaixaDAO();
                        foreach (int id in idsParaExcluir)
                        {
                            cxdao.Delete(id);
                        }

                        
                        ListaCaixas();
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, selecione pelo menos um caixa para excluir.", "Nenhum Caixa Selecionado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir caixa(s): " + ex.Message);
            }
            finally
            {
                Conexao.FecharConexao();
            }
        }
               

        private void btn_AtualizarCaixa_Click_1(object sender, EventArgs e)
        {
            try
            {
                
                if (dgv_Caixas.SelectedRows.Count > 0)
                {
                    
                    foreach (DataGridViewRow row in dgv_Caixas.SelectedRows)
                    {
                        
                        int idCaixa = Convert.ToInt32(row.Cells["id_caixa"].Value);

                        
                        Funcionarios fun = (Funcionarios)cbx_Funcionario.SelectedItem;
                        Caixas cx = new Caixas
                        {
                            id_caixa = idCaixa,
                            saldo_inicial = Convert.ToDouble(txt_SaldoInicial.Text),
                            total_entradas = Convert.ToDouble(txt_TotalEntradas.Text),
                            total_saidas = Convert.ToDouble(txt_TotalSaidas.Text),
                            status_caixa = (string)cbx_StatusCaixa.SelectedItem,
                            saldo_final = (Convert.ToDouble(txt_TotalEntradas.Text) + Convert.ToDouble(txt_SaldoInicial.Text)) - Convert.ToDouble(txt_TotalSaidas.Text),                            
                            fk_funcionario = fun
                        };

                        
                        CaixaDAO cxdao = new CaixaDAO();
                        cxdao.Update(cx);
                    }

                    
                    ListaCaixas();
                }
                else
                {
                    MessageBox.Show("Por favor, selecione pelo menos um caixa para atualizar.", "Nenhum Caixa Selecionado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar caixa(s): " + ex.Message);
            }
            finally
            {
                Conexao.FecharConexao();
            }
        }
        
    }
}
