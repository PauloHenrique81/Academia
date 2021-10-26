using System;
using System.Collections.Generic;
using System.Text;

namespace Ph.Business.Models
{
    public class Atividade : Entity
    {

        public Guid TurmaId { get; set; }
        public Guid ProfessorId { get; set; }
        public string  Nome { get; set; }

        //EF Relation
        public Professor Professor { get; set; }
        public IEnumerable<Turma> Turma { get; set; }

    }
}
