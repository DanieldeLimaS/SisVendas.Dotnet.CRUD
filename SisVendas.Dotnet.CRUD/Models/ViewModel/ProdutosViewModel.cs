using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Models.ViewModel
{
    class ProdutosViewModel
    {
        public int Codigo { get; set; }
        [Required]
        public string Ean { get; set; }
        [Required]
        public string NomeProduto { get; set; }
        [Required]
        [DataType(DataType.Currency)]
        public decimal PrecoCusto { get; set; }
        [Required]
        [DataType(DataType.Currency)]
        public decimal PrecoVenda { get; set; }
        
    }
}
