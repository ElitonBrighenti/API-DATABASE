using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senai.Domain.DTos
{
    public class ProfessorDto
    {
        [Required, MaxLength(60)]
        public string Nome { get; set; }
        public long EscolaId { get; set; }
    }
}
