using Senai.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senai.Domain.DTos
{
    public  class MediaNotarPorAlunoESemestreDto
    {
        public long AlunoId { get; set; }
        public SemestreEnum Semestre { get; set; }
    }
}
