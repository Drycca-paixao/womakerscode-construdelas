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
        //public ApplicationContext(DbContextOptions<ApplicationContext> options)
        //    : base(options)
        //{

        //}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-DRY23;Database=biblioteca;Trusted_Connection=True;MultipleActiveResultSets=true");
        }
    
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
                modelBuilder.ApplyConfiguration(new UsuarioConfiguration());
        }
    }
}
