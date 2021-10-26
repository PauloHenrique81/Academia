using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ph.Business.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ph.Data.Mappings
{
    public class AtividadeMapping : IEntityTypeConfiguration<Atividade>
    {
        public void Configure(EntityTypeBuilder<Atividade> builder)
        {
            builder.HasKey(t => t.Id);

            builder.Property(t => t.Nome)
                .IsRequired()
                .HasColumnType("varchar(200)");

            //1 : N => Atividade : Turma
            builder.HasMany(t => t.Turma)
                .WithOne(a => a.Atividade)
                .HasForeignKey(t => t.AtividadeId);

            builder.ToTable("Atividades");
        }
    }
}
