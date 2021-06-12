namespace UI.Models.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Clientes
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Clientes()
        {
            Vendas = new HashSet<Vendas>();
        }

        [Key]
        public int Codigo { get; set; }

        [Required]
        [StringLength(45)]
        public string Nome { get; set; }

        [Required]
        [StringLength(16)]
        public string Telefone { get; set; }

        [StringLength(150)]
        public string Email { get; set; }

        public bool Ativo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Vendas> Vendas { get; set; }
    }
}
