using Microsoft.EntityFrameworkCore;
using Senai.Domain.DTos;
using Senai.Domain.Interfaces;
using Senai.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senai.Service.Services
{
    public class NotaService : INotaService
    {
        private readonly INotaRepository _notaRepostory;

        public NotaService(INotaRepository notaRepostory)
        {
            _notaRepostory = notaRepostory;
        }

        public List<MediaNotasDto> MediaNotas (MediaNotarPorAlunoESemestreDto alunoMedia)
        {
            var notasDoAluno = _notaRepostory.BuscarTodos().Include(c => c.Aluno)
                .Where(c => c.AlunoId == alunoMedia.AlunoId && c.Semestre == alunoMedia.Semestre)
                .ToList();

            var mediaNotas =  new List<MediaNotasDto>();
            var notasAgrupadasPorDisciplina = notasDoAluno.GroupBy(c => c.Disciplina);
            foreach (var notas in notasAgrupadasPorDisciplina)
            {
                var media = new MediaNotasDto()
                {
                    Aluno = notasDoAluno.FirstOrDefault(c => c.AlunoId == alunoMedia.AlunoId).Aluno.Nome,
                    Disciplina = notas.Key,
                    Media = notas.Select(d => d.Notas).Sum() / notas.Count()
                };
                mediaNotas.Add(media);
            }
            return new List<MediaNotasDto>();
        }
    }
}
