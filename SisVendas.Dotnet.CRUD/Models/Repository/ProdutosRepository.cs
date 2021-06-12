using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using UI.Models.Entities;
using UI.Models.Interfaces;
using UI.Models.ViewModel;

namespace UI.Models.Repository
{
     class ProdutosRepository : IProdutos
    {
        public bool Create(ProdutosViewModel _produto)
        {
            try
            {
                using(Contexto db = new Contexto())
                {
                    Produtos _prod = new Produtos();
                    _prod.NomeProduto=_produto.NomeProduto;
                    _prod.Ean=_produto.Ean;
                    _prod.PrecoCusto=_produto.PrecoCusto;
                    _prod.PrecoVenda=_produto.PrecoVenda;
                    _prod.Ativo=true;

                    db.Produtos.Add(_prod);
                    db.SaveChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                using(Contexto db = new Contexto())
                {
                    Produtos _prod = db.Produtos.Find(id);
                    _prod.Ativo=false;
                    db.Produtos.Attach(_prod);
                    db.Entry(_prod).State=EntityState.Modified;

                    db.SaveChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public List<ProdutosViewModel> GetALLProdutos()
        {
            using(Contexto db = new Contexto())
            {
                List<ProdutosViewModel> _prod = new List<ProdutosViewModel>();
                _prod=db.Produtos.Where(x => x.Ativo==true).AsNoTracking().ToList().Select(x => new ProdutosViewModel
                {
                    Codigo=x.Codigo,
                    Ean=x.Ean,
                    NomeProduto=x.NomeProduto,
                    PrecoCusto=x.PrecoCusto,
                    PrecoVenda=x.PrecoVenda
                }).ToList();
                return _prod.ToList();
            }
        }

        public bool Update(ProdutosViewModel _produto)
        {
            try
            {
                using(Contexto db = new Contexto())
                {
                    Produtos _prod = db.Produtos.Find(_produto.Codigo);
                    _prod.NomeProduto=_produto.NomeProduto;
                    _prod.Ean=_produto.Ean;
                    _prod.PrecoCusto=_produto.PrecoCusto;
                    _prod.PrecoVenda=_produto.PrecoVenda;
                    _prod.Ativo=true;

                    db.Produtos.Attach(_prod);
                    db.Entry(_prod).State=EntityState.Modified;
                    db.SaveChanges();
                    return true;
                }
            }
            catch { return false; }
        }
    }
}
