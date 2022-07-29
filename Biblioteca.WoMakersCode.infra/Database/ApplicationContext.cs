using Biblioteca.WoMakersCode.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.WoMakersCode.infra.Database
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Autor> Autores { get; set; }
        public DbSet<Livro> Livros { get; set; }
        public DbSet<Emprestimo> Emprestimos { get; set; }


        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)

        {

        }
                
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioConfiguration());
            modelBuilder.ApplyConfiguration(new AutorConfiguration());
            modelBuilder.ApplyConfiguration(new LivroConfiguration());
            modelBuilder.ApplyConfiguration(new EmprestimoConfiguration());
            
        }
    }
}
