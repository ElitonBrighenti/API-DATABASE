using AutoMapper;
using Senai.Domain.DTos;
using Senai.Domain.Entidades;
using Senai.Domain.Interfaces;
using Senai.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senai.Service.Services
{
    public class ClasseService : IClasseService
    {
        private readonly IMapper _mapper;
        private readonly IClasseRepository _classeRepository;

        public ClasseService(IClasseRepository classeRepository, IMapper mapper)
        {
            _mapper = mapper;
            _classeRepository = classeRepository;
        }

        public bool Salvar(ClasseDto model)
        {
            var entidade = _mapper.Map<Classe>(model);
            return _classeRepository.Salvar(entidade);
        }

        public bool Remover(long id)
        {
            return _classeRepository.Remover(id);
        }

        public Classe? BuscarPorId(long id)
        {
            return _classeRepository.BuscarPorId(id);
        }
        public List<Classe> BuscarTodos()
        {
            return _classeRepository.BuscarTodos().ToList();
        }
    }
}
