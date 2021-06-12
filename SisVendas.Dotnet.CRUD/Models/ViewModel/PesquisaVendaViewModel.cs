using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Models.ViewModel
{
    class PesquisaVendaViewModel
    {
        public int Codigo { get; set; }
        public string NomeCliente { get; set; }
        public decimal ValorVendido { get; set; }
        public DateTime DtVenda { get; set; }
    }
}
