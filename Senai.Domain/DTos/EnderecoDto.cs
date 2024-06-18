using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senai.Domain.DTos
{
    public class EnderecoDto
    {
        public long Id { get; set; }

        [MaxLength(80)]
        public string Rua { get; set; }
        [MaxLength(50)]
        public string Bairro { get; set; }
        [MaxLength(60)]
        public string Cidade { get; set; }
        [MaxLength(2)]
        public string Estado { get; set; }
        public int Numero { get; set; }
    }
}
