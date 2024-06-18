using Senai.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senai.Domain.Entidades
{
    public class Nota : BaseEntity
    {
        public long AlunoId { get; set; }
        public Aluno Aluno { get; set; }
        public DisciplinaEnum Disciplina { get; set; }  
        public SemestreEnum Semestre { get; set; }
        public decimal Notas { get; set; }

    }
}
