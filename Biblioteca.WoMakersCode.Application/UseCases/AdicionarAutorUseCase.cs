using AutoMapper;
using Biblioteca.WoMakersCode.Application.Models.AdicionarAutor;
using Biblioteca.WoMakersCode.Core.Entities;
using Biblioteca.WoMakersCode.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.WoMakersCode.Application.UseCases
{
    public class AdicionarAutorUseCase : IUseCaseAsync<AdicionarAutorRequest, AdicionarAutorResponse>
    {
        private readonly IAutorRepository _repository;
        private readonly IMapper _mapper;

        public AdicionarAutorUseCase(IAutorRepository repository,
            IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<AdicionarAutorResponse> ExecuteAsync(AdicionarAutorRequest request)
        {
            
            if (request == null)
                return null;

            var autor = _mapper.Map<Autor>(request);

            await _repository.Inserir(autor);

            return new AdicionarAutorResponse();
        }
    }
}
