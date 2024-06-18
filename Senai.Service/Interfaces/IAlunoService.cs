using Senai.Domain.DTos;
using Senai.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senai.Service.Interfaces
{
    public interface IAlunoService
    {
        bool Salvar(AlunoDto model);
        bool Remover(long id);
        Aluno? BuscarPorId(long id);
        List<Aluno> BuscarTodos();
    }
}
