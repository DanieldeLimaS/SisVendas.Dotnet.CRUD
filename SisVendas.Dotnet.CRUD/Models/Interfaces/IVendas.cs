using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI.Models.Entities;
using UI.Models.ViewModel;

namespace UI.Models.Interfaces
{
    interface IVendas
    {
        int SalvaVenda(VendaViewModel venda, List<ItensVendas> itens);
        List<Clientes> carregaCbxClientes();
        List<Produtos> carregaCbxProdutos();
        ProdutoPrecoViewModel getProdutoCodigo(int id);
        EmailClienteViewModel getEmailCliente(int id);
        int codcliente(int codvenda);
        List<PesquisaVendaViewModel> ListaVendasRealizadas(string cliParam,DateTime inicio, DateTime fim);

        List<CarregaListaProdutosVendasViewModel> getItensVendaPorCodigoVenda(int id);
    }
}
