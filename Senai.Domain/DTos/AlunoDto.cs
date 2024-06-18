using Senai.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senai.Domain.DTos
{
    public class AlunoDto
    {
        public long Id { get; set; }

        [Required, MaxLength(60)]
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        [Required]
        public DateTime Nascimento { get; set; }
        [Required, MaxLength(14)]
        public string CPF { get; set; }
        public long ClasseId { get; set; }

    }
}
