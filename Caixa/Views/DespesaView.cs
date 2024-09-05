using Caixa.DAO;
using Caixa.Models;
using MySql.Data.MySqlClient;
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
    public partial class DespesaView : Form
    {
        public DespesaView()
        {
            InitializeComponent();
            cbx_Fornecedores.DataSource = ObterFornecedores();
            cbx_Fornecedores.ValueMember = "id_fornecedor";
            cbx_Fornecedores.DisplayMember = "nome";

            cbx_Caixas.DataSource = ObterCaixas();
            cbx_Caixas.ValueMember = "id_caixa";

            cbx_StatusDespesas.Items.Add("PENDENTE");
            cbx_StatusDespesas.Items.Add("PAGO");

            ConfigurarDataGridView();
            ListaDespesas();
        }     

        private void btn_Adicionar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
            {
                return;
            }
            
            Despesas despesa = new Despesas();

            despesa.valor = Convert.ToDouble(txt_Valor.Text);
            despesa.data_vencimento = Convert.ToDateTime(dtp_Vencimento.Value);
            despesa.data_pagamento = Convert.ToDateTime(dtp_Pagamento.Text);
            despesa.status_Despesas = (string)cbx_StatusDespesas.SelectedItem;
            Fornecedores FornecedorSelecionado = (Fornecedores)cbx_Fornecedores.SelectedItem;
            despesa.fk_fornecedor = FornecedorSelecionado;
            Caixas caixaSelecionado = (Caixas)cbx_Caixas.SelectedItem;
            despesa.fk_caixa = caixaSelecionado;
            DespesaDAO despesaDAO = new DespesaDAO();
            despesaDAO.Insert(despesa);
            ListaDespesas();
        }

        private void ConfigurarDataGridView()
        {
            dgv_Despesas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_Despesas.AllowUserToAddRows = false;
            dgv_Despesas.AllowUserToDeleteRows = false;
            dgv_Despesas.ReadOnly = true;
            dgv_Despesas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_Despesas.BackgroundColor = System.Drawing.Color.White;
            dgv_Despesas.BorderStyle = BorderStyle.Fixed3D;
            dgv_Despesas.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Blue;
            dgv_Despesas.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
        }

        private List<Caixas> ObterCaixas()
        {
            List<Caixas> listcx = new List<Caixas>();
            try
            {
                string sql = "SELECT id_caixa, status_caixa FROM tb_caixas";
                using (MySqlConnection conectar = Conexao.Conectar())
                using (MySqlCommand comando = new MySqlCommand(sql, conectar))
                using (MySqlDataReader dr = comando.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Caixas cx = new Caixas
                        {
                            id_caixa = dr.GetInt32("id_caixa")
                        };
                        listcx.Add(cx);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar Caixas: " + ex.Message);
            }
            return listcx;
        }

        private List<Fornecedores> ObterFornecedores()
        {
            List<Fornecedores> listFor = new List<Fornecedores>();
            try
            {
                string sql = "SELECT id_fornecedor, nome FROM tb_fornecedores";
                using (MySqlConnection conectar = Conexao.Conectar())
                using (MySqlCommand comando = new MySqlCommand(sql, conectar))
                using (MySqlDataReader dr = comando.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Fornecedores fornecedor = new Fornecedores
                        {
                            id_fornecedor = dr.GetInt32("id_fornecedor"),
                            nome = dr.GetString("nome")
                        };
                        listFor.Add(fornecedor);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar Fornecedores: " + ex.Message);
            }
            return listFor;
        }

        private void ListaDespesas()
        {
            try
            {
                DespesaDAO despesaDAO = new DespesaDAO();
                List<Despesas> despesas = despesaDAO.List();

                var dados = despesas.Select(d => new
                {
                    d.id_despesa,
                    d.valor,
                    d.data_vencimento,
                    d.data_pagamento,
                    d.status_Despesas,
                    FornecedorId = d.fk_fornecedor.nome,
                    CaixaId = d.fk_caixa.id_caixa
                }).ToList();

                dgv_Despesas.DataSource = dados;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar despesas: " + ex.Message);
            }
            finally
            {
                Conexao.FecharConexao();
            }
        }

        private void btn_Atualizar_Click_1(object sender, EventArgs e)
        {
            if (!ValidarCampos())
            {
                return;
            }
            try
            {
                if (dgv_Despesas.SelectedRows.Count > 0)
                {
                    foreach (DataGridViewRow row in dgv_Despesas.SelectedRows)
                    {
                        int idDespesa = Convert.ToInt32(row.Cells["id_despesa"].Value);

                        Despesas despesa = new Despesas
                        {
                            id_despesa = idDespesa,
                            valor = Convert.ToDouble(txt_Valor.Text),
                            data_vencimento = dtp_Vencimento.Value,
                            data_pagamento = dtp_Pagamento.Value,
                            status_Despesas = (string)cbx_StatusDespesas.SelectedItem,
                            fk_caixa = (Caixas)cbx_Caixas.SelectedItem,
                            fk_fornecedor = (Fornecedores)cbx_Fornecedores.SelectedItem
                        };

                        DespesaDAO despesaDAO = new DespesaDAO();
                        despesaDAO.Update(despesa);
                    }

                    ListaDespesas();
                }
                else
                {
                    MessageBox.Show("Por favor, selecione pelo menos uma despesa para atualizar.", "Nenhuma Despesa Selecionada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar despesa(s): " + ex.Message);
            }
            finally
            {
                Conexao.FecharConexao();
            }
        }

        private void btn_Deletar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (dgv_Despesas.SelectedRows.Count > 0)
                {
                    DialogResult result = MessageBox.Show("Você tem certeza que deseja excluir a(s) despesa(s) selecionada(s)?", "Confirmar Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        List<int> idsParaExcluir = new List<int>();

                        foreach (DataGridViewRow row in dgv_Despesas.SelectedRows)
                        {
                            int idDespesa = Convert.ToInt32(row.Cells["id_despesa"].Value);
                            idsParaExcluir.Add(idDespesa);
                        }

                        DespesaDAO despesaDAO = new DespesaDAO();
                        foreach (int id in idsParaExcluir)
                        {
                            despesaDAO.Delete(id);
                        }

                        ListaDespesas();
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, selecione pelo menos uma despesa para excluir.", "Nenhuma Despesa Selecionada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir despesa(s): " + ex.Message);
            }
            finally
            {
                Conexao.FecharConexao();
            }
        }

        private bool ValidarCampos()
        {
            
            if (string.IsNullOrWhiteSpace(txt_Valor.Text) || !double.TryParse(txt_Valor.Text, out _))
            {
                MessageBox.Show("Por favor, insira um valor válido para a despesa.");
                txt_Valor.Focus();
                return false;
            }

            
            if (dtp_Vencimento.Value == null)
            {
                MessageBox.Show("Por favor, insira a data de vencimento.");
                dtp_Vencimento.Focus();
                return false;
            }

            
            if (dtp_Pagamento.Value == null)
            {
                MessageBox.Show("Por favor, insira a data de pagamento.");
                dtp_Pagamento.Focus();
                return false;
            }

            
            if (cbx_StatusDespesas.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecione o status da despesa.");
                cbx_StatusDespesas.Focus();
                return false;
            }

            
            if (cbx_Fornecedores.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecione um fornecedor.");
                cbx_Fornecedores.Focus();
                return false;
            }

            
            if (cbx_Caixas.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecione um caixa.");
                cbx_Caixas.Focus();
                return false;
            }

            return true;
        }


    }
}
