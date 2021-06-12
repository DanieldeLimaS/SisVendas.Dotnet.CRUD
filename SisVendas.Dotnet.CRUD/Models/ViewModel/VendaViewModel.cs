using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Models.ViewModel
{
    class VendaViewModel
    {
        public int Codigo { get; set; }

        public DateTime DataVenda { get; set; }

        public decimal ValorVenda { get; set; }

        public int ClienteCodigo { get; set; }

    }
}
