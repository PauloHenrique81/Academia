using Microsoft.EntityFrameworkCore;
using Ph.Business.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ph.Data.Mappings
{
    public class PlanoMapping : IEntityTypeConfiguration<Plano>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Plano> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Nome)
                .IsRequired()
                .HasColumnType("varchar(200)");

            builder.Property(p => p.Descricao)
               .IsRequired()
               .HasColumnType("varchar(1000)");

            //1 : N => Plano : Aluno
            builder.HasMany(p => p.Alunos)
                .WithOne(a => a.Plano)
                .HasForeignKey(p => p.PlanoId);

            builder.ToTable("Planos");

        }
    }
}
