using Biblioteca.WoMakersCode.Application.Models.AtualizarDevolucaoLivro;
using Biblioteca.WoMakersCode.Application.Models.ExcluirEmprestimo;
using Biblioteca.WoMakersCode.Application.UseCases;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Biblioteca.WoMakersCode.Api.Controllers
{
    [ApiController]
    [Route("api/emprestimos")]
    public class EmprestimoController : ControllerBase

    {
        private readonly IUseCaseAsync<AtualizarDevolucaoLivroRequest, AtualizarDevolucaoLivroResponse> _useCase;
        private readonly IUseCaseAsync<ExcluirEmprestimoRequest, ExcluirEmprestimoResponse> _excluirUseCase;

        public EmprestimoController(IUseCaseAsync<AtualizarDevolucaoLivroRequest, AtualizarDevolucaoLivroResponse> useCase,
            IUseCaseAsync<ExcluirEmprestimoRequest, ExcluirEmprestimoResponse> excluirUseCase)
        {
            _useCase = useCase;
            _excluirUseCase = excluirUseCase;
        }

        [HttpPut("devolucao-livro/{id:int}")]
        public async Task<ActionResult<AtualizarDevolucaoLivroResponse>> Put([FromRoute] int id)
        {
            return await _useCase.ExecuteAsync(new AtualizarDevolucaoLivroRequest() { Id = id});
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult<ExcluirEmprestimoResponse>> Delete([FromRoute] int id)
        {
            return await _excluirUseCase.ExecuteAsync(new ExcluirEmprestimoRequest() { Id = id });
        }
    }
}
