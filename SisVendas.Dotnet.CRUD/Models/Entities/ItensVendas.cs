namespace UI.Models.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ItensVendas
    {
        [Key]
        public int Codigo { get; set; }

        public int ProdutoCodigo { get; set; }

        public int VendaCodigo { get; set; }

        public int QtdVendido { get; set; }
        public decimal ValorVendido { get; set; }

        public virtual Produtos Produtos { get; set; }

        public virtual Vendas Vendas { get; set; }
    }
}
