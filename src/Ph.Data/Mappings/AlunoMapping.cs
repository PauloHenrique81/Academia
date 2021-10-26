using Microsoft.EntityFrameworkCore;
using Ph.Business.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ph.Data.Mappings
{
    public class AlunoMapping : IEntityTypeConfiguration<Aluno>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Aluno> builder)
        {
            builder.HasKey(a => a.Id);

            builder.Property(a => a.Nome)
                .IsRequired()
                .HasColumnType("varchar(200)");

            builder.Property(a => a.Graduacao)
               .HasColumnType("varchar(200)");

            builder.Property(a => a.Cpf)
               .HasColumnType("varchar(20)");

            builder.Property(a => a.Telefone)
               .IsRequired()
               .HasColumnType("varchar(20)");

            builder.ToTable("Alunos");

        }
    }
}
