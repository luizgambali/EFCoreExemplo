
using Microsoft.EntityFrameworkCore;
using ExemploEFCore.App.Models;

namespace ExemploEFCore.App.Context
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Aluno> Alunos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=localhost;Initial Catalog=AlunosDB;User ID=test;Password=$trongPassword;");
        }
    }
}
