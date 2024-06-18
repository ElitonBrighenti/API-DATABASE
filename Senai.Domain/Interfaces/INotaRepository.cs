using Senai.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senai.Domain.Interfaces
{
    public interface INotaRepository
    {
        bool Salvar(Nota entity);
        bool Remover(long id);
        Nota? BuscarPorId(long id);
        IQueryable<Nota> BuscarTodos();
    }
}
