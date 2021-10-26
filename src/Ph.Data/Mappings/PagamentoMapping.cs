using Microsoft.EntityFrameworkCore;
using Ph.Business.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ph.Data.Mappings
{
    public class PagamentoMapping : IEntityTypeConfiguration<Pagamento>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Pagamento> builder)
        {
            builder.HasKey(a => a.Id);

            builder.Property(p => p.Data)
                .IsRequired();

            //1 : 1 => Turma : Aluno
            builder.HasOne(p => p.Aluno)
                .WithOne(a => a.Pagamento);

            builder.ToTable("Pagamentos");

        }
    }
}
