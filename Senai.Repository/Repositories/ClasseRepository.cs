using Microsoft.EntityFrameworkCore;
using Senai.Domain.Entidades;
using Senai.Domain.Interfaces;
using Senai.Repository.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senai.Repository.Repositories
{
    public class ClasseRepository : IClasseRepository
    {
        private readonly SenaiContext _context;

        public ClasseRepository(SenaiContext context)
        {
            _context = context;
        }

        public bool Salvar(Classe entity)
        {
            try
            {
                if (entity.Id == 0)
                {
                    _context.Classe.Add(entity);
                }
                else
                {
                    _context.Classe.Update(entity);
                }
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public Classe? BuscarPorId(long id)
        {
            return _context.Classe.FirstOrDefault(c => c.Id == id);
        }
        public bool Remover(long id)
        {
            try
            {
                var classe = BuscarPorId(id);
                if (classe != null)
                {
                    _context.Classe.Remove(classe);
                    _context.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public async Task RemoverPorId(long id)
        {
            var sql = $"DELETE \"Escola\" e WHERE e.\"Id\" = {id}";
            await _context.Database.ExecuteSqlRawAsync(sql);
        }

        public IQueryable<Classe> BuscarTodos()
        {
            return _context.Classe;
        }
    }
}
