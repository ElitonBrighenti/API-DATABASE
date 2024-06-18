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
    public class AlunoRepository : IAlunoRepository
    {
        private readonly SenaiContext _context;

        public AlunoRepository(SenaiContext context)
        {
            _context = context;
        }

        public bool Salvar(Aluno entity)
        {
            try
            {
                if (entity.Id == 0)
                {
                    _context.Aluno.Add(entity);
                }
                else
                {
                    _context.Aluno.Update(entity);
                }
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public Aluno? BuscarPorId(long id)
        {
            return _context.Aluno.FirstOrDefault(c => c.Id == id);
        }
        public bool Remover(long id)
        {
            try
            {
                var escola = BuscarPorId(id);
                if (escola != null)
                {
                    _context.Aluno.Remove(escola);
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

        public IQueryable<Aluno> BuscarTodos()
        {
            return _context.Aluno;
        }
    }
}
