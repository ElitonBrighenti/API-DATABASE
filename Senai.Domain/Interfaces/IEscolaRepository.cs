using Senai.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senai.Domain.Interfaces
{
    public interface IEscolaRepository
    {
        bool Salvar(Escola entity);
        bool Remover(long id);
        Escola? BuscarPorId(long id);
        IQueryable<Escola> BuscarTodos();
    }
}
