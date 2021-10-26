using System;
using System.Collections.Generic;
using System.Text;

namespace Ph.Business.Models
{
    public class Plano : Entity
    {
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public string Descricao { get; set; }
        public int QtdAulas { get; set; }

        //EF Relation
        public IEnumerable<Aluno> Alunos { get; set; }
    }
}
