using System.Collections;
using ExemploEFCore.App.Models;

namespace ExemploEFCore.App.Interfaces
{
    public interface IAlunoService
    {
        bool InserirAluno(Aluno aluno);
        bool AtualizarDados(int id, Aluno aluno);
        bool ExcluirAluno(int id);
        IEnumerable<Aluno> ListarAlunos();
        Aluno ObterPorId(int id);
    }
}


