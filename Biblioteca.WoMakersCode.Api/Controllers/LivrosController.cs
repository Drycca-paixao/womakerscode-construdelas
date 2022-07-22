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
    public class LivrosController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "Novo Livro";
        }
        [HttpPost]
        public string GetTeste([FromHeader] string header)
        {
            return header;
        }
    }
}
