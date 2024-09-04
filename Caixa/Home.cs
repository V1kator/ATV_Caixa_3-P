using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Caixa.DAO;
using Caixa.Models;
using Caixa.Views;

namespace Caixa
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            
        }

        private void btnCaixa_Click(object sender, EventArgs e)
        {
            CaixaView cx = new CaixaView();
            cx.ShowDialog();
        }

        private void btnRecebimento_Click(object sender, EventArgs e)
        {
            RecebimentoView recebimento = new RecebimentoView();
            recebimento.ShowDialog();
        }

        private void btnDespesa_Click(object sender, EventArgs e)
        {
            DespesaView despesa = new DespesaView();
            despesa.ShowDialog();
        }

        private void btnFuncionario_Click(object sender, EventArgs e)
        {
            FuncionarioView funcionario = new FuncionarioView();
            funcionario.ShowDialog();
        }
    }
}
