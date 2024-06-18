using AutoMapper;
using Senai.Domain.DTos;
using Senai.Domain.Entidades;
using Senai.Domain.Interfaces;
using Senai.Repository.Repositories;
using Senai.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senai.Service.Services
{
    public class ProfessorService : IProfessorService
    {
        private readonly IMapper _mapper;
        private readonly IProfessorRepository _professorRepository;

        public ProfessorService(IProfessorRepository professorRepository, IMapper mapper)
        {
            _mapper = mapper;
            _professorRepository = professorRepository;
        }
        public bool Salvar(ProfessorDto model)
        {
            var entidade = _mapper.Map<Professor>(model);
            return _professorRepository.Salvar(entidade);
        }

        public bool Remover(long id)
        {
            return _professorRepository.Remover(id);
        }

        public Professor? BuscarPorId(long id)
        {
            return _professorRepository.BuscarPorId(id);
        }
        public List<Professor> BuscarTodos()
        {
            return _professorRepository.BuscarTodos().ToList();
        }
    }
}
