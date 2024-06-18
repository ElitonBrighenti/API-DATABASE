using Microsoft.EntityFrameworkCore;
using Senai.Domain;
using Senai.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senai.Repository.Context
{
    public class SenaiContext : DbContext
    {
        public DbSet<Escola> Escola { get; set; }
        public DbSet<Endereco> Endereco { get; set; }
        public DbSet<Professor> Professor { get; set;}
        public DbSet<Classe> Classe { get; set; }
        public DbSet<Aluno> Aluno { get; set; }
        public DbSet<Nota> Nota { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server=127.0.0.1;Port=5432;Database=Senai;User Id=postgres;Password=2024;");
        }
    }
}

