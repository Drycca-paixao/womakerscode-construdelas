using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.WoMakersCode.Application.Models.AdicionarEmprestimos
{
    public class AdicionarEmprestimoRequest
    {
        public DateTime DataEmprestimo { get; set; }
        public int IdUsuario { get; set; }
        public int IdLivro { get; set; }
    }
}
