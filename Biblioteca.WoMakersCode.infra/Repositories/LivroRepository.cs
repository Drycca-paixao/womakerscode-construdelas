using Biblioteca.WoMakersCode.Core.Entities;
using Biblioteca.WoMakersCode.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.WoMakersCode.infra.Repositories
{
    public class LivroRepository : ILivroRepository
    {
        public async Task Atualizar(Livro obj)
        {
            throw new NotImplementedException();
        }

        public async Task Excluir(int id)
        {
            throw new NotImplementedException();
        }

        public async Task Inserir(Livro obj)
        {
            throw new NotImplementedException();
        }

        public async Task<Livro> ListarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Livro>> ListarTodos()
        {
            throw new NotImplementedException();
        }
    }
}
