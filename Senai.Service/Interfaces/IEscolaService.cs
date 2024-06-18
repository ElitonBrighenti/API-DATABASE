using Senai.Domain.DTos;
using Senai.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senai.Service.Interfaces
{
    public interface IEscolaService
    {
        bool Salvar(EscolaDto model);
        bool Remover (long id);
        Escola? BuscarPorId(long id);
        List<Escola> BuscarTodos();
    }
}
