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
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly ApplicationContext _context;

        public UsuarioRepository(ApplicationContext context)
        {
            _context = context;
        }
        public async Task Atualizar(Usuario obj)
        {
            throw new NotImplementedException();
        }

        public async Task Excluir(int id)
        {
            throw new NotImplementedException();
        }

        public async Task Inserir(Usuario obj)
        {
           _context.Add(obj);
           _context.SaveChanges();
        }

        public async Task<Usuario> ListarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Usuario>> ListarTodos()
        {
            throw new NotImplementedException();
        }
    }
}

