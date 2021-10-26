using Microsoft.EntityFrameworkCore;
using Ph.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ph.Data.Context
{
    public class AcademiaDbContext : DbContext
    {
        public AcademiaDbContext(DbContextOptions options) : base(options){ }

        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Plano> Planos { get; set; }
        public DbSet<Turma> Turmas { get; set; }
        public DbSet<Pagamento> Pagamentos { get; set; }
        public DbSet<Professor> Professores { get; set; }
        public DbSet<Atividade> Atividades { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AcademiaDbContext).Assembly);

            //Desabilita o delete cascate
            foreach (var relaionship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
                relaionship.DeleteBehavior = DeleteBehavior.ClientSetNull;

            base.OnModelCreating(modelBuilder); 
        }
    }
}
