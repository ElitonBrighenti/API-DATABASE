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
    public class AlunoService : IAlunoService
    {
        private readonly IMapper _mapper;
        private readonly IAlunoRepository _alunoRepository;

        public AlunoService(IAlunoRepository alunoRepository, IMapper mapper)
        {
            _mapper = mapper;
            _alunoRepository = alunoRepository;
        }

        public bool Salvar(AlunoDto model)
        {
            var entidade = _mapper.Map<Aluno>(model);
            return _alunoRepository.Salvar(entidade);
        }

        public bool Remover(long id)
        {
            return _alunoRepository.Remover(id);
        }

        public Aluno? BuscarPorId(long id)
        {
            return _alunoRepository.BuscarPorId(id);
        }
        public List<Aluno> BuscarTodos()
        {
            return _alunoRepository.BuscarTodos().ToList();
        }
    }
}
