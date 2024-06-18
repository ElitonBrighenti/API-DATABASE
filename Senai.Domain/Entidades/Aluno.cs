using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senai.Domain.Entidades
{
    public class Aluno : BaseEntity
    {
        [Required, MaxLength(60)]
        public string Nome { get; set; }
        public string Sobrenome {  get; set; }
        [Required]
        public DateTime Nascimento { get; set; }
        [Required, MaxLength(14)]
        public string CPF { get; set; }
        public long ClasseId { get; set; }
        public Classe Classe { get; set; }


    }
}
