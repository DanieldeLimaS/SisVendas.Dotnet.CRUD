namespace UI.Models.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Vendas
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Vendas()
        {
            ItensVendas = new HashSet<ItensVendas>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Codigo { get; set; }

        public DateTime DataVenda { get; set; }

        public decimal ValorVenda { get; set; }

        public int ClienteCodigo { get; set; }

        public virtual Clientes Clientes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ItensVendas> ItensVendas { get; set; }
    }
}
