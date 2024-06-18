using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Senai.Domain.Enum;

namespace Senai.Domain.Entidades
{
    public class Classe : BaseEntity
    {
        public SerieEnum Serie { get; set; }

        public long EscolaId { get; set; }
        public Escola Escola { get; set; }
        
        public long ProfessorId { get; set; }
        public Professor Professor { get; set; }  

        public List<Aluno> Alunos { get; set; } 

        
    }
}
