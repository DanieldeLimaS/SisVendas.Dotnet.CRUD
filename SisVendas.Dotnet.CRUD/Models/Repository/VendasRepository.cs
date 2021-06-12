using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI.Models.Entities;
using UI.Models.Interfaces;
using UI.Models.ViewModel;

namespace UI.Models.Repository
{
    class VendasRepository : IVendas
    {
        public List<Clientes> carregaCbxClientes()
        {
            using(Contexto db = new Contexto())
            {
                return db.Clientes.Where(x => x.Ativo==true).AsNoTracking().ToList()
                    .Select(x => new Clientes { Codigo=x.Codigo, Nome=x.Nome }).ToList();
            }
        }

        public List<Produtos> carregaCbxProdutos()
        {
            using(Contexto db = new Contexto())
            {
                return db.Produtos.Where(x => x.Ativo==true).AsNoTracking().ToList()
                    .Select(x => new Produtos { Codigo=x.Codigo, NomeProduto=x.NomeProduto }).ToList();
            }
        }

        public int codcliente(int codvenda)
        {
            using(Contexto db = new Contexto())
            {
                Vendas cli = new Vendas();
                cli=db.Vendas.Where(x => x.Codigo==codvenda).FirstOrDefault();
                return cli.ClienteCodigo;
            }
        }

        public EmailClienteViewModel getEmailCliente(int id)
        {
            using(Contexto db = new Contexto())
            {
                EmailClienteViewModel email = new EmailClienteViewModel();
                email=db.Clientes.Where(x => x.Codigo==id).AsNoTracking().ToList()
                    .Select(x => new EmailClienteViewModel { Email=x.Email }).First();
                return email;
            }
        }

        public List<CarregaListaProdutosVendasViewModel> getItensVendaPorCodigoVenda(int id)
        {
            using(Contexto db = new Contexto())
            {
                List<CarregaListaProdutosVendasViewModel> itens = new List<CarregaListaProdutosVendasViewModel>();
                itens=db.ItensVendas.Include(x => x.Vendas).Include(x => x.Produtos).Where(x => x.VendaCodigo==id).AsNoTracking().ToList()
                    .Select(x => new CarregaListaProdutosVendasViewModel
                    {
                        Cod=x.Produtos.Codigo,
                        NomeProduto=x.Produtos.NomeProduto,
                        qtdvendido=x.QtdVendido,
                        ValorVendido=x.ValorVendido,
                        Total=x.ValorVendido*x.QtdVendido

                    }).ToList();

                return itens;
            }
        }

        public ProdutoPrecoViewModel getProdutoCodigo(int id)
        {
            using(Contexto db = new Contexto())
            {
                ProdutoPrecoViewModel preco = new ProdutoPrecoViewModel();
                preco=db.Produtos.Where(x => x.Codigo==id).AsNoTracking().ToList()
                    .Select(x => new ProdutoPrecoViewModel { PrecoVenda=x.PrecoVenda }).First();
                return preco;
            }
        }

        public List<PesquisaVendaViewModel> ListaVendasRealizadas(string cliParam, DateTime inicio, DateTime fim)
        {
            List<PesquisaVendaViewModel> pesq = new List<PesquisaVendaViewModel>();
            using(Contexto db = new Contexto())
            {
                //if(string.IsNullOrEmpty(cliParam))
                //{
                //    pesq=db.Vendas.Include(x => x.Clientes).Where(x => x.DataVenda>=inicio.Date&&x.DataVenda<=fim).ToList()
                //   .Select(x => new PesquisaVendaViewModel
                //   {
                //       Codigo=x.Codigo,
                //       NomeCliente=x.Clientes.Nome,
                //       ValorVendido=x.ValorVenda,
                //       DtVenda=x.DataVenda
                //   }).ToList();
                //}
                //else
                //{
                    pesq=db.Vendas.Include(x => x.Clientes).Where(x => x.Clientes.Nome.Contains(cliParam)&&(x.DataVenda>=inicio.Date&&x.DataVenda<=fim)).ToList()
                   .Select(x => new PesquisaVendaViewModel
                   {
                       Codigo=x.Codigo,
                       NomeCliente=x.Clientes.Nome,
                       ValorVendido=x.ValorVenda,
                       DtVenda=x.DataVenda
                   }).ToList();
               // }

                return pesq;
            }
        }

        public bool SalvaItensVenda(List<ItensVendas> itens)
        {
            try
            {
                using(Contexto db = new Contexto())
                {
                    db.ItensVendas.AddRange(itens);
                    db.SaveChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }


        public int SalvaVenda(VendaViewModel venda, List<ItensVendas> itens)
        {
            try
            {
                using(Contexto db = new Contexto())
                {
                    var _venda = new Vendas
                    {
                        Codigo=db.Vendas.DefaultIfEmpty().Max(r => r==null ? 1 : r.Codigo+1),
                        ValorVenda=venda.ValorVenda,
                        DataVenda=DateTime.Now,
                        ClienteCodigo=venda.ClienteCodigo,
                        ItensVendas=itens
                    };

                    db.Vendas.Add(_venda);
                    db.SaveChanges();
                    return _venda.Codigo;
                }
            }
            catch
            {
                return 0;
            }
        }
    }
}
