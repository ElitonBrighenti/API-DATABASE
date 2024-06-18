using Senai.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senai.Domain.DTos
{
    public class MediaNotasDto
    {
        public string Aluno { get; set; }
        public decimal Media {  get; set; }
        public DisciplinaEnum Disciplina { get; set; }

    }
}
