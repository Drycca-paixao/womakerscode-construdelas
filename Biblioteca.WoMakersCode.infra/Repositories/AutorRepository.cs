using Biblioteca.WoMakersCode.Core.Entities;
using Biblioteca.WoMakersCode.Core.Repositories;
using Biblioteca.WoMakersCode.infra.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.WoMakersCode.infra.Repositories
{
    public class AutorRepository : IAutorRepository
    {
        private readonly ApplicationContext _context;

        public AutorRepository(ApplicationContext context)
        {
            _context = context;
        }
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
            _context.Add(obj);
            _context.SaveChanges();
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