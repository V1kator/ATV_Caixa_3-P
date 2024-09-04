using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caixa.Models
{
    internal class Recebimentos
    {
        public int id_recebimento { get; set; }
        public double valor { get; set; }
        public DateTime data_vencimento { get; set; }
        public DateTime data_pagamento { get; set; }
        public string status_recebimento { get; set; }
        public Vendas fk_venda { get; set; }
        public Caixas fk_caixa { get; set; }
    }
}
