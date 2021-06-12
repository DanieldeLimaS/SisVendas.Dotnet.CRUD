using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Models.ViewModel
{
    class CarregaListaProdutosVendasViewModel
    {
        public int Cod { get; set; }

        public string NomeProduto { get; set; }

        public int qtdvendido { get; set; }
        public decimal ValorVendido { get; set; }
        public decimal Total { get; set; }
    }
}
