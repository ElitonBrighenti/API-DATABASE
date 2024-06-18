using Senai.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senai.Domain.Interfaces
{
    public interface IAlunoRepository
    {
        bool Salvar(Aluno entity);
        bool Remover(long id);
        Aluno? BuscarPorId(long id);
        IQueryable<Aluno> BuscarTodos();
    }
}
