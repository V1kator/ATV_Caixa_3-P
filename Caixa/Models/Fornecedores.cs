using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caixa.Models
{
    internal class Fornecedores
    {
        public int id_fornecedor { get; set; }
        public string razao_social { get; set; }
        public string nome { get; set; }
        public string cnpj { get; set; }
        public string ativo { get; set; }
        public string atividade_economica { get; set; }
        public string telefone { get; set; }
        public string email { get; set; }
    }
}
