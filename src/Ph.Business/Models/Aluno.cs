using System;
using System.Collections.Generic;
using System.Text;

namespace Ph.Business.Models
{
    public class Aluno : Entity
    {
        public Guid TurmaId { get; set; }
        public Guid PlanoId { get; set; }

        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Graduacao { get; set; }
        public DateTime DataDeNascimento { get; set; }
        public string  Sexo { get; set; }
        public string  Telefone { get; set; }
        public DateTime DataDaMatricula { get; set; }
        public int DiaDoPagamento { get; set; }
        public bool Ativo { get; set; }


        //EF Relation
        public Turma Turma { get; set; }
        public Plano Plano { get; set; }
        public Pagamento Pagamento { get; set; }

    }
}