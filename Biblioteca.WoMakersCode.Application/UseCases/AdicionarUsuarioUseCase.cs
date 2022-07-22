using AutoMapper;
using Biblioteca.WoMakersCode.Application.Models.AdicionarUsuario;
using Biblioteca.WoMakersCode.Core.Entities;
using Biblioteca.WoMakersCode.Core.Repositories;
using System;
using System.Threading.Tasks;

namespace Biblioteca.WoMakersCode.Application.UseCases
{
    public class AdicionarUsuarioUseCase : IUseCaseAsync<AdicionarUsuarioRequest, AdicionarUsuarioResponse>
    {
        private readonly IUsuarioRepository _repository;
        private readonly IMapper _mapper;

        public AdicionarUsuarioUseCase(IUsuarioRepository repository,
            IMapper mapper)            
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<AdicionarUsuarioResponse> ExecuteAsync(AdicionarUsuarioRequest request)
        {
            if (request == null)
                return null;

            var usuario = _mapper.Map<Usuario>(request);

            await _repository.Inserir(usuario);

            return new AdicionarUsuarioResponse();
        }
    }
}
