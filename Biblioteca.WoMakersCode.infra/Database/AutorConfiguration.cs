using Biblioteca.WoMakersCode.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.WoMakersCode.infra.Database
{
    public class AutorConfiguration : IEntityTypeConfiguration<Autor>
    {
        public void Configure(EntityTypeBuilder<Autor> builder)
        {
            builder.ToTable("autores");
            builder.HasKey(pk => pk.Id);
            builder.Property(p => p.Nome)
                .HasColumnType("VARCHAR(100)")
                .IsRequired();
        }
    }
}
