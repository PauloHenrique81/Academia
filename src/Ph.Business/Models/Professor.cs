using System;
using System.Collections.Generic;
using System.Text;

namespace Ph.Business.Models
{
    public class Professor : Entity
    {
        public string Nome { get; set; }

        public string CPF { get; set; }

        public String Especialidade { get; set; }

        public DateTime DataDeNascimento { get; set; }

        //EF Relation
        public IEnumerable<Atividade> Atividades { get; set; }
    }
}
