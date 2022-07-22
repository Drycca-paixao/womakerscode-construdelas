using Biblioteca.WoMakersCode.Core.Entities;
using Biblioteca.WoMakersCode.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.WoMakersCode.infra.Repositories
{
    public class AutorRepository : IAutorRepository
    {
        public async Task Atualizar(Autor obj)
        {
            throw new NotImplementedException();
        }

        public async Task Excluir(int id)
        {
            throw new NotImplementedException();
        }

        public async Task Inserir(Autor obj)
        {
            throw new NotImplementedException();
        }

        public async Task<Autor> ListarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Autor>> ListarTodos()
        {
            throw new NotImplementedException();
        }
    }
}
