using Senai.Domain.DTos;
using Senai.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senai.Service.Interfaces
{
    public interface IClasseService
    {
        bool Salvar(ClasseDto model);
        bool Remover(long id);
        Classe? BuscarPorId(long id);
        List<Classe> BuscarTodos();
    }
}
