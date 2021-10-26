using System;
using System.Collections.Generic;
using System.Text;

namespace Ph.Business.Models
{
    public class Pagamento : Entity
    {
        public Guid AlunoId { get; set; }
        public DateTime Data { get; set; }


        //EF Relation
        public Aluno Aluno { get; set; }
    }
}
