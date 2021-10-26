using Microsoft.EntityFrameworkCore;
using Ph.Business.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ph.Data.Mappings
{
    public class TurmaMapping : IEntityTypeConfiguration<Turma>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Turma> builder)
        {
            builder.HasKey(t => t.Id);

            builder.Property(t => t.Nome)
                .IsRequired()
                .HasColumnType("varchar(200)");

            //1 : N => Turma : Aluno
            builder.HasMany(t => t.Alunos)
                .WithOne(a => a.Turma)
                .HasForeignKey(t => t.TurmaId);

            builder.ToTable("Turmas");

        }
    }
}
