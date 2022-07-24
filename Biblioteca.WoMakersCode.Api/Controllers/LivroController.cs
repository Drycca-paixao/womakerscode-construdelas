using Biblioteca.WoMakersCode.Application.Models.ListarLivros;
using Biblioteca.WoMakersCode.Application.UseCases;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Biblioteca.WoMakersCode.Api.Controllers
{
    [ApiController]
    [Route("api/livros")]
    public class LivroController : ControllerBase
    {        
        private readonly IUseCaseAsync<ListarLivrosRequest, List<ListarLivrosResponse>> _useCase;

        public LivroController(IUseCaseAsync<ListarLivrosRequest, List<ListarLivrosResponse>> useCase)
        {
            _useCase = useCase;
        }

        [HttpGet]
        public async Task<ActionResult<List<ListarLivrosResponse>>> Get([FromQuery] ListarLivrosRequest request)
        {
            return await _useCase.ExecuteAsync(request);
        }
        
    }
}
