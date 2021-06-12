namespace UI.Models.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Produtos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Produtos()
        {
            ItensVendas = new HashSet<ItensVendas>();
        }

        [Key]
        public int Codigo { get; set; }

        [Required]
        [StringLength(150)]
        public string NomeProduto { get; set; }

        public string Ean { get; set; }

        public decimal PrecoVenda { get; set; }

        public bool Ativo { get; set; }

        public decimal PrecoCusto { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ItensVendas> ItensVendas { get; set; }
    }
}
