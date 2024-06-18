using Senai.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senai.Domain.DTos
{
    public class ClasseDto
    {
        public SerieEnum Serie { get; set; }
        public long ProfessorId { get; set; }
        public long EscolaId { get; set; }


    }
}
