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
    public class EmprestimoRepository : IEmprestimoRepository
    {
        private readonly ApplicationContext _context;

        public EmprestimoRepository(ApplicationContext context)
        {
            _context = context;
        }

        public async Task Atualizar(Emprestimo obj)
        {
            _context.Update(obj);
            _context.SaveChanges();
        }

        public async Task Excluir(Emprestimo obj)
        {
            _context.Remove(obj);
            _context.SaveChanges();
        }

        public async Task Inserir(Emprestimo obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }

        public async Task<List<Emprestimo>> ListarEmprestimosEmAtraso(int diasParaDevolucao)
        {
            return await _context
                .Emprestimos
                .Include(i => i.Livro)
                .Include(i => i.Usuario)
                .Where(w => w.DataDevolucao == null 
                    && DateTime.Now > w.DataEmprestimo.AddDays(diasParaDevolucao))
                .AsNoTracking()
                .ToListAsync();
        }

        //Listar para visualizar
        public async Task<Emprestimo> ListarPorId(int id)
        {
            return await _context
                .Emprestimos
                .Where(w => w.Id == id)
                .AsNoTracking()
                .FirstOrDefaultAsync();
        }

        //Listar para atualizar
        public async Task<Emprestimo> ListarPorIdParaAtualizarEmprestimo(int id)
        {
            return await _context
                .Emprestimos
                .Where(w => w.Id == id)                
                .FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Emprestimo>> ListarTodos()
        {
            return await _context
                .Emprestimos
                .Include(i =>i.Livro)
                    .ThenInclude(i => i.Autor)
                .Include(i => i.Usuario)
                .AsNoTracking()
                .ToListAsync();
        }
    }
}
