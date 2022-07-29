using Biblioteca.WoMakersCode.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Biblioteca.WoMakersCode.infra.Database
{
    public class EmprestimoConfiguration : IEntityTypeConfiguration<Emprestimo>
    {
        public void Configure(EntityTypeBuilder<Emprestimo> builder)
        {
            builder.ToTable("emprestimos");
            builder.HasKey(pk => pk.Id);
            builder.Property(p => p.DataEmprestimo)
            .HasColumnType("DATETIME")
            .IsRequired();
            builder.Property(p => p.DataDevolucao)
                .HasColumnType("DATETIME");
            builder.HasOne(fk => fk.Livro)
                .WithMany(fk => fk.Emprestimos)
                .HasForeignKey(fk => fk.IdLivro);
            builder.HasOne(fk => fk.Usuario)
                .WithMany(fk => fk.Emprestimos)
                .HasForeignKey(fk => fk.IdUsuario);
        }
    }
}