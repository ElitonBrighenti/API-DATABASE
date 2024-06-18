using Senai.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senai.Domain.Interfaces
{
    public interface IClasseRepository
    {
        bool Salvar(Classe entity);
        bool Remover(long id);
        Classe? BuscarPorId(long id);
        IQueryable<Classe> BuscarTodos();
    }
}
