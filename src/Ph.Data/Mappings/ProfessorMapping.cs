using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ph.Business.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ph.Data.Mappings
{
    public class ProfessorMapping : IEntityTypeConfiguration<Professor>
    {
        public void Configure(EntityTypeBuilder<Professor> builder)
        {
            builder.HasKey(t => t.Id);

            builder.Property(t => t.Nome)
                .IsRequired()
                .HasColumnType("varchar(200)");

            //1 : N => Professor : Atividade
            builder.HasMany(t => t.Atividades)
                .WithOne(a => a.Professor)
                .HasForeignKey(t => t.ProfessorId);

            builder.ToTable("Professores");
        }
    }
}
