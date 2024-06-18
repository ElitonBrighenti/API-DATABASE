using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senai.Domain.Entidades
{
    public class Escola : BaseEntity
    {
        [Required, MaxLength(60)]
        public string Nome { get; set; }
        public Endereco Endereco { get; set; }
        public List<Professor> Professores { get; set; }
        public List<Classe> Classes {  get; set; }
    }
}
