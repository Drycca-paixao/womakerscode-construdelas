using Biblioteca.WoMakersCode.Application.Models.AdicionarUsuario;
using Biblioteca.WoMakersCode.Application.UseCases;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Biblioteca.WoMakersCode.Api.Controllers
{
    [ApiController]
    [Route("api/usuarios")]
    public class UsuariosController : ControllerBase
    {
        private readonly IUseCaseAsync<AdicionarUsuarioRequest, AdicionarUsuarioResponse> _useCaseAsync;

        public UsuariosController(IUseCaseAsync<AdicionarUsuarioRequest, AdicionarUsuarioResponse> useCaseAsync)
        {
            _useCaseAsync = useCaseAsync;
        }
        //inserir()
        [HttpPost]
        public async Task<ActionResult<AdicionarUsuarioResponse>> Post([FromBody] AdicionarUsuarioRequest request)
        {
            return await _useCaseAsync.ExecuteAsync(request);
        }
    }
}
