﻿using Biblioteca.WoMakersCode.Core.Entities;
using Biblioteca.WoMakersCode.Core.Repositories;
using Biblioteca.WoMakersCode.infra.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.WoMakersCode.infra.Repositories
{
    public class LivroRepository : ILivroRepository
    {
        private readonly ApplicationContext _context;
        public LivroRepository(ApplicationContext context)
        {
            _context = context;
        }      
        
        public async Task Atualizar(Livro obj)
        {
            throw new NotImplementedException();
        }

        public async Task Excluir(Livro obj)
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
            return await _context
                .Livros
                .AsNoTracking()
                .ToListAsync();
        }
    }
}
