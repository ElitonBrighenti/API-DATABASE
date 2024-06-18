using Senai.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senai.Domain.Interfaces
{
    public interface IProfessorRepository
    {
        bool Salvar(Professor entity);
        bool Remover(long id);
        Professor? BuscarPorId(long id);
        IQueryable<Professor> BuscarTodos();
    }
}
