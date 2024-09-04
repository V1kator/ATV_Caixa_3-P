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
    public partial class RecebimentoView : Form
    {
        public RecebimentoView()
        {
            InitializeComponent();
            cbx_Venda.DataSource = ObterVendas();
            cbx_Venda.ValueMember = "id_venda";

            cbx_Caixa.DataSource = ObterCaixas();
            cbx_Caixa.ValueMember = "id_caixa";

            cbx_StatusRecebimento.Items.Add("PENDENTE");
            cbx_StatusRecebimento.Items.Add("PAGO");

            ConfigurarDataGridView();
            ListaRecebimentos();
        }

        private void btn_Atualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_Recebimentos.SelectedRows.Count > 0)
                {
                    foreach (DataGridViewRow row in dgv_Recebimentos.SelectedRows)
                    {
                        int idRecebimento = Convert.ToInt32(row.Cells["id_recebimento"].Value);

                        Recebimentos recebimento = new Recebimentos
                        {
                            id_recebimento = idRecebimento,
                            valor = Convert.ToDouble(txt_Valor.Text),
                            data_vencimento = dtp_Vencimento.Value,
                            data_pagamento = dtp_Pagamento.Value,
                            status_recebimento = (string)cbx_StatusRecebimento.SelectedItem,
                            fk_caixa = (Caixas)cbx_Caixa.SelectedItem,
                            fk_venda = (Vendas)cbx_Venda.SelectedItem
                        };

                        RecebimentoDAO recebimentoDAO = new RecebimentoDAO();
                        recebimentoDAO.Update(recebimento);
                    }

                    ListaRecebimentos();
                }
                else
                {
                    MessageBox.Show("Por favor, selecione pelo menos um recebimento para atualizar.", "Nenhum Recebimento Selecionado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar recebimento(s): " + ex.Message);
            }
            finally
            {
                Conexao.FecharConexao();
            }
        }

        private void btn_Adicionar_Click(object sender, EventArgs e)
        {
            Recebimentos recebimento = new Recebimentos();

            recebimento.valor = Convert.ToDouble(txt_Valor.Text);
            recebimento.data_vencimento = Convert.ToDateTime(dtp_Vencimento.Value);
            recebimento.data_pagamento = Convert.ToDateTime(dtp_Pagamento.Text);
            recebimento.status_recebimento = (string)cbx_StatusRecebimento.SelectedItem;
            Vendas vendaSelecionada = (Vendas)cbx_Venda.SelectedItem;
            recebimento.fk_venda = vendaSelecionada;
            Caixas caixaSelecionado = (Caixas)cbx_Caixa.SelectedItem;
            recebimento.fk_caixa = caixaSelecionado;
            RecebimentoDAO recebimentoDAO = new RecebimentoDAO();
            recebimentoDAO.Insert(recebimento);
            ListaRecebimentos();
        }

        private void ConfigurarDataGridView()
        {
            dgv_Recebimentos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_Recebimentos.AllowUserToAddRows = false;
            dgv_Recebimentos.AllowUserToDeleteRows = false;
            dgv_Recebimentos.ReadOnly = true;
            dgv_Recebimentos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_Recebimentos.BackgroundColor = System.Drawing.Color.White;
            dgv_Recebimentos.BorderStyle = BorderStyle.Fixed3D;
            dgv_Recebimentos.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Blue;
            dgv_Recebimentos.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;

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

        private List<Vendas> ObterVendas()
        {

            List<Vendas> listvd = new List<Vendas>();
            try
            {
                string sql = "SELECT id_venda FROM tb_vendas";


                using (MySqlConnection conectar = Conexao.Conectar())
                using (MySqlCommand comando = new MySqlCommand(sql, conectar))
                using (MySqlDataReader dr = comando.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Vendas vd = new Vendas
                        {
                            id_venda = dr.GetInt32("id_venda")
                        };
                        listvd.Add(vd);
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar Caixas: " + ex.Message);
            }
            return listvd;

        }

        private void ListaRecebimentos()
        {
            try
            {
                RecebimentoDAO rcdao = new RecebimentoDAO();
                List<Recebimentos> rc = rcdao.List();
                
                var dados = rc.Select(r => new
                {
                    r.id_recebimento,
                    r.valor,
                    r.data_vencimento,
                    r.data_pagamento,
                    r.status_recebimento,
                    VendaId = r.fk_venda.id_venda,
                    CaixaId = r.fk_caixa.id_caixa
                }).ToList();
                
                dgv_Recebimentos.DataSource = dados;
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

                if (dgv_Recebimentos.SelectedRows.Count > 0)
                {

                    DialogResult result = MessageBox.Show("Você tem certeza que deseja excluir o(s) recebimentos(s) selecionado(s)?", "Confirmar Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {

                        List<int> idsParaExcluir = new List<int>();


                        foreach (DataGridViewRow row in dgv_Recebimentos.SelectedRows)
                        {
                            int idRecebimento = Convert.ToInt32(row.Cells["id_recebimento"].Value);
                            idsParaExcluir.Add(idRecebimento);
                        }


                        RecebimentoDAO rcdao = new RecebimentoDAO();
                        foreach (int id in idsParaExcluir)
                        {
                            rcdao.Delete(id);
                        }


                        ListaRecebimentos();
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, selecione pelo menos um recebimento para excluir.", "Nenhum Caixa Selecionado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir recebimento(s): " + ex.Message);
            }
            finally
            {
                Conexao.FecharConexao();
            }
        }
    }
}
