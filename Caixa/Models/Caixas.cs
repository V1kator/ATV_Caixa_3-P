using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caixa.Models
{
    internal class Caixas
    {
        public int id_caixa { get; set; }
        public double saldo_inicial { get; set; }
        public double total_entradas { get; set; }
        public double total_saidas { get; set; }
        public string status_caixa { get; set; }
        public double saldo_final { get; set; }
        public Funcionarios fk_funcionario { get; set; }
    }
}
