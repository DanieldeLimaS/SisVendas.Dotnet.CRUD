using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI.Models.Entities;
using UI.Models.ViewModel;

namespace UI.Models.Interfaces
{
    interface IClientes
    {
        bool Create(ClienteViewModel _cliente);
        bool Update(ClienteViewModel _cliente);
        bool Delete(int id);
        List<ClienteViewModel> GetALLClientes(string param = "");
    }
}
