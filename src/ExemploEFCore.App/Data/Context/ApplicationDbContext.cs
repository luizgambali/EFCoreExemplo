
using Microsoft.EntityFrameworkCore;
using ExemploEFCore.App.Models;
using ExemploEFCore.App.Configuration;

namespace ExemploEFCore.App.Context
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Aluno> Alunos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source=./database.db;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<Aluno>(new AlunoConfiguration());
        }
    }
}

