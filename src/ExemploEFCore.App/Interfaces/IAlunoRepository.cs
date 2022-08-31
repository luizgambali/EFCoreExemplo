using System.Collections;
using ExemploEFCore.App.Models;

namespace ExemploEFCore.App.Interfaces
{
    public interface IAlunoRepository
    {
        bool Inserir(Aluno aluno);
        bool Atualizar(Aluno aluno);
        bool Excluir(Aluno aluno);
        IEnumerable<Aluno> ListarTodos();
        Aluno ObterPorId(int id);
    }
}

