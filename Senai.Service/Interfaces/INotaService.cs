using Senai.Domain.DTos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senai.Service.Interfaces
{
    public interface INotaService
    {
        public List<MediaNotasDto> MediaNotas(MediaNotarPorAlunoESemestreDto alunoMedia);
    }
}
