using ExemploEFCore.App.Context;
using ExemploEFCore.App.Interfaces;
using ExemploEFCore.App.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace ExemploEFCore.App.Data
{
    public class AlunoRepository : IAlunoRepository
    {
        private ApplicationDbContext _context;
        private readonly DbSet<Aluno> _dbSet;

        public AlunoRepository(ApplicationDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<Aluno>();
        }
        public bool Inserir(Aluno aluno)
        {
            _dbSet.Add(aluno);
            SaveChanges();
            return true;
        }

        public bool Atualizar(Aluno aluno)
        {
            _dbSet.Update(aluno);
            SaveChanges();
            return true;
        }
        public bool Excluir(Aluno aluno)
        {
            _dbSet.Remove(aluno);
            SaveChanges();
            return true;
        }
        public IEnumerable<Aluno> ListarTodos()
        {
            return _dbSet.ToList();
        }
        public Aluno ObterPorId(int id)
        {
            return _dbSet.Find(id);
        }

        private void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}