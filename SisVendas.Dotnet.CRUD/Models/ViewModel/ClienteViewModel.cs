using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Models.ViewModel
{
    class ClienteViewModel
    {
        public int Codigo { get; set; }

        [Required(ErrorMessage = "O nome completo é obrigatório.")]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$", ErrorMessage ="Números e caracteres especiais não são permitidos no nome.")]
        public string Nome { get; set; }

        [Required]
        [StringLength(16,MinimumLength =14,ErrorMessage ="Campo Telefone está incompleto.")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "Informe o email")]
        [RegularExpression(@"^(([A-Za-z0-9]+_+)|([A-Za-z0-9]+\-+)|([A-Za-z0-9]+\.+)|([A-Za-z0-9]+\++))*[A-Za-z0-9]+@((\w+\-+)|(\w+\.))*\w{1,63}\.[a-zA-Z]{2,6}$", ErrorMessage = "Informe um email válido")]
        public string Email { get; set; }


    }
}
