using System.Collections.Generic;
using UI.Models.ViewModel;

namespace UI.Models.Interfaces
{
    interface IProdutos
    {
        bool Create(ProdutosViewModel _produto);
        bool Update(ProdutosViewModel _produto);
        bool Delete(int id);
        List<ProdutosViewModel> GetALLProdutos();
    }
}
