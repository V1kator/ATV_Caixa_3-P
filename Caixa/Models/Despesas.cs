using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caixa.Models
{
    internal class Despesas
    {
        public int id_despesa { get; set; }
        public double valor { get; set; }
        public DateTime data_vencimento { get; set; }
        public DateTime data_pagamento { get; set; }
        public string status_Despesas { get; set; }
        public Caixas fk_caixa { get; set; }
        public Fornecedores fk_fornecedor { get; set; }
    }
}
