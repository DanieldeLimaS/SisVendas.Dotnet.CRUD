using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Models.Interfaces
{
    interface IGlobal
    {
        bool Create(Object T);
        bool Update(Object T);
        bool Delete(Object T, int id);

        List<Object> GetALL(Object T, string param);
        Object GetDados(int id);
        IEnumerable<ValidationResult> getValidationErros(object obj);


    }
}
