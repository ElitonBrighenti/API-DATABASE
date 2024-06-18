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
    public class NotaRepository : INotaRepository
    {
        private readonly SenaiContext _context;
        public NotaRepository(SenaiContext context)
        {
            _context = context;
        }

        public bool Salvar(Nota entity)
        {
            try
            {
                if (entity.Id == 0)
                {
                    _context.Nota.Add(entity);
                }
                else
                {
                    _context.Nota.Update(entity);
                }
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public Nota? BuscarPorId(long id)
        {
            return _context.Nota.FirstOrDefault(c => c.Id == id);
        }
        public bool Remover(long id)
        {
            try
            {
                var escola = BuscarPorId(id);
                if (escola != null)
                {
                    _context.Nota.Remove(escola);
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

        public IQueryable<Nota> BuscarTodos()
        {
            return _context.Nota;
        }
    }
}
