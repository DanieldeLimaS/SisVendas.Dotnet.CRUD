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
    class ClientesRepository : IClientes
    {
        public bool Create(ClienteViewModel _cliente)
        {
            try
            {
                using(Contexto db = new Contexto())
                {
                    Clientes _cli = new Clientes();
                    _cli.Nome=_cliente.Nome;
                    _cli.Telefone=_cliente.Telefone;
                    _cli.Email=_cliente.Email;
                    _cli.Ativo=true;

                    db.Clientes.Add(_cli);
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
                    Clientes _cli = db.Clientes.Find(id);
                    _cli.Ativo=false;
                    db.Clientes.Attach(_cli);
                    db.Entry(_cli).State=EntityState.Modified;

                    db.SaveChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public List<ClienteViewModel> GetALLClientes(string param = "")
        {
            using(Contexto db = new Contexto())
            {
                List<ClienteViewModel> _cli = new List<ClienteViewModel>();
                _cli=db.Clientes.Where(x=>x.Ativo==true).AsNoTracking().ToList().Select(x => new ClienteViewModel
                {
                    Codigo=x.Codigo,
                    Nome=x.Nome,
                    Telefone=x.Telefone,
                    Email=x.Email
                }).ToList();
                return _cli.ToList();
            }
        }
        public bool Update(ClienteViewModel _cliente)
        {
            try
            {
                using(Contexto db = new Contexto())
                {
                    Clientes _cli = db.Clientes.Find(_cliente.Codigo);
                    _cli.Nome=_cliente.Nome;
                    _cli.Telefone=_cliente.Telefone;
                    _cli.Email=_cliente.Email;
                    _cli.Ativo=true;

                    db.Clientes.Attach(_cli);
                    db.Entry(_cli).State=EntityState.Modified;
                    db.SaveChanges();
                    return true;
                }
            }
            catch{ return false; }
        }

    }
}
