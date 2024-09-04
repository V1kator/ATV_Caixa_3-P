using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caixa.Models
{
    internal class Vendas
    {
        public int id_venda { get; set; }
        public DateTime data_venda { get; set; }
        public double valor_total { get; set; }
        public double desconto { get; set; }
        public double valor_final { get; set; }
        public string tipo { get; set; }
        public Clientes fk_cliente { get; set; }
    }
}
