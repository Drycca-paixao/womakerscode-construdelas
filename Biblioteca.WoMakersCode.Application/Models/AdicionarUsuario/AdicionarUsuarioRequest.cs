using Biblioteca.WoMakersCode.Application.Models.AdicionarAutor;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.WoMakersCode.Application.Models.AdicionarUsuario
{
    public class AdicionarUsuarioRequest
    {
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
    }

    public class AdicionarUsuarioRequestValidator : AbstractValidator<AdicionarUsuarioRequest>
    {
        public AdicionarUsuarioRequestValidator()
        {
            RuleFor(r => r.Nome)
                .NotEmpty()
                .WithMessage("Nome não pode ser vazio")
                .NotNull()
                .WithMessage("Nome não pode ser nulo");
        }

        public object Validate(AdicionarAutorRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
