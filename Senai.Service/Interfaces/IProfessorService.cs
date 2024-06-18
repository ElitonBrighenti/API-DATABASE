using Senai.Domain.DTos;
using Senai.Domain.Entidades;

namespace Senai.Service.Interfaces
{
    public interface IProfessorService
    {
        bool Salvar(ProfessorDto model);
        bool Remover(long id);
        Professor? BuscarPorId(long id);
        List<Professor> BuscarTodos();
    }
}
