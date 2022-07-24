using AutoMapper;
using Biblioteca.WoMakersCode.Application.Models.ListarLivros;
using Biblioteca.WoMakersCode.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.WoMakersCode.Application.UseCases
{
    public class ListarLivrosUseCase : IUseCaseAsync<ListarLivrosRequest, List<ListarLivrosResponse>>
    {
        public readonly ILivroRepository _repository;
        public readonly IMapper _mapper;


        public ListarLivrosUseCase(ILivroRepository repository,
            IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<List<ListarLivrosResponse>> ExecuteAsync(ListarLivrosRequest request)
        {
            var livros = await _repository.ListarTodos();
            var livrosResponse = _mapper.Map<List<ListarLivrosResponse>>(livros);

            return livrosResponse;

        }
    }
}
