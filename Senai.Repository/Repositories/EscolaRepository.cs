using Microsoft.EntityFrameworkCore;
using Senai.Domain.Entidades;
using Senai.Domain.Interfaces;
using Senai.Repository.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Senai.Repository.Repositories
{
    public class EscolaRepository : IEscolaRepository
    {
        private readonly SenaiContext _context;

        public EscolaRepository(SenaiContext context)
        {
            _context = context;
        }

        public bool Salvar(Escola entity)
        {
            try
            {
                if(entity.Id == 0)
                {
                    _context.Escola.Add(entity);
                }
                else
                {
                    _context.Escola.Update(entity);
                }
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public Escola? BuscarPorId(long id)
        {
            return _context.Escola.FirstOrDefault(c => c.Id == id); 
        }
        public bool Remover(long id)
        {
            try
            {
                var escola = BuscarPorId(id);
                if (escola != null)
                {
                    _context.Escola.Remove(escola);
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

        public IQueryable<Escola> BuscarTodos()
        {
            return _context.Escola;
        }

    }
}
