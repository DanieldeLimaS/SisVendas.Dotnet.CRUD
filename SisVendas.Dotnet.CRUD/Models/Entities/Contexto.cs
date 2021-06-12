using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace UI.Models.Entities
{
    public partial class Contexto : DbContext
    {
        public Contexto()
            : base("name=Contexto")
        {
        }

        public virtual DbSet<Clientes> Clientes { get; set; }
        public virtual DbSet<ItensVendas> ItensVendas { get; set; }
        public virtual DbSet<Produtos> Produtos { get; set; }
        public virtual DbSet<Vendas> Vendas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Clientes>()
                .Property(e => e.Nome)
                .IsUnicode(false);

            modelBuilder.Entity<Clientes>()
                .Property(e => e.Telefone)
                .IsUnicode(false);

            modelBuilder.Entity<Clientes>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Clientes>()
                .HasMany(e => e.Vendas)
                .WithRequired(e => e.Clientes)
                .HasForeignKey(e => e.ClienteCodigo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Produtos>()
                .Property(e => e.NomeProduto)
                .IsUnicode(false);

            modelBuilder.Entity<Produtos>()
                .Property(e => e.PrecoVenda)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Produtos>()
                .Property(e => e.PrecoCusto)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Produtos>()
                .HasMany(e => e.ItensVendas)
                .WithRequired(e => e.Produtos)
                .HasForeignKey(e => e.ProdutoCodigo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Vendas>()
                .Property(e => e.ValorVenda)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Vendas>()
                .HasMany(e => e.ItensVendas)
                .WithRequired(e => e.Vendas)
                .HasForeignKey(e => e.VendaCodigo)
                .WillCascadeOnDelete(false);
        }
    }
}
