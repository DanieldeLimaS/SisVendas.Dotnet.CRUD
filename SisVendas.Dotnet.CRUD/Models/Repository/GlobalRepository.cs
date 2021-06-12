using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI.Models.Interfaces;

namespace UI.Models.Repository
{
    class GlobalRepository : IGlobal
    {
        public bool Create(object T)
        {
            throw new NotImplementedException();
        }

        public bool Delete(object T, int id)
        {
            throw new NotImplementedException();
        }

        public List<object> GetALL(object T, string param)
        {
            throw new NotImplementedException();
        }

        public object GetDados(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ValidationResult> getValidationErros(object obj)
        {
            var resultadoValidacao = new List<ValidationResult>();
            var contexto = new ValidationContext(obj, null, null);
            Validator.TryValidateObject(obj, contexto, resultadoValidacao, true);
            return resultadoValidacao;
        }

        public bool Update(object T)
        {
            throw new NotImplementedException();
        }

        public bool ValidaDados(object obj)
        {
            throw new NotImplementedException();
        }
    }
}
