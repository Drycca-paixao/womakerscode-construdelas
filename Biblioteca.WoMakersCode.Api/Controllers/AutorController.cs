using Biblioteca.WoMakersCode.Application.Models.AdicionarAutor;
using Biblioteca.WoMakersCode.Application.UseCases;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Biblioteca.WoMakersCode.Api.Controllers
{
    [ApiController]
    [Route("api/autores")]
    public class AutorController
    {
        private readonly IUseCaseAsync<AdicionarAutorRequest, AdicionarAutorResponse> _useCaseAsync;

        public AutorController(IUseCaseAsync<AdicionarAutorRequest, AdicionarAutorResponse> useCaseAsync)
        {
            _useCaseAsync = useCaseAsync;
        }
        //inserir()
        [HttpPost]
        public async Task<ActionResult<AdicionarAutorResponse>> Post([FromBody] AdicionarAutorRequest request)
        {
            return await _useCaseAsync.ExecuteAsync(request);
        }
    }
}
