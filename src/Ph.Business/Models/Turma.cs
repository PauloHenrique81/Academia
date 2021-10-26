using System;
using System.Collections.Generic;

namespace Ph.Business.Models
{
    public class Turma : Entity
    {
        public Guid AtividadeId { get; set; }

        public AulasPorSemana Aulas { get; set; }
        public TimeSpan Horario { get; set; }
        public string Nome { get; set; }
        public Sexo Sexo { get; set; }

        

        //EF Relation
        public IEnumerable<Aluno> Alunos { get; set; }
        public Atividade Atividade { get; set; }

    }
}