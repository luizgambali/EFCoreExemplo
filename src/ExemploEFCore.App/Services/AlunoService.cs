using ExemploEFCore.App.Interfaces;
using ExemploEFCore.App.Models;
using ExemploEFCore.App.Data;
using System.Linq;

namespace ExemploEFCore.App.Services
{
    public class AlunoService: IAlunoService
    {
        private readonly IAlunoRepository _alunoRepository;

        public AlunoService(IAlunoRepository alunoRepository)
        {
            _alunoRepository = alunoRepository;
        }

        public bool InserirAluno(Aluno aluno) 
        { 
            try
            {
                if (aluno.Validate())
                {
                    _alunoRepository.Inserir(aluno);
                    Console.WriteLine("Aluno inserido com sucesso!");
                    return true;
                }
                else
                {
                    Console.WriteLine("Dados do aluno estão inconsistentes!");
                    return false;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("InserirAluno() : Ops! Algo saiu errado! " + ex.Message);
                return false;
            }

            return false; 
        }


        public bool AtualizarDados(int id, Aluno aluno) 
        { 
            try
            {
                var result = _alunoRepository.ObterPorId(id);

                if (result == null)
                {
                    Console.WriteLine("Aluno não encontrado!");
                    return false;
                }

                if (aluno.Validate())
                {
                    result.Nome = aluno.Nome;
                    result.Idade = aluno.Idade;
                    result.Email = aluno.Email;
                    
                    _alunoRepository.Atualizar(result);

                    Console.WriteLine("Dados do aluno atualizados com sucesso!");
                    return true;
                }
                else
                {
                    Console.WriteLine("Dados do aluno estão inconsistentes!");
                    return false;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("AtualizarDados() : Ops! Algo saiu errado! " + ex.Message);
                return false;
            }
        }
        
        public bool ExcluirAluno(int id) 
        { 
            try 
            {
                var aluno = _alunoRepository.ObterPorId(id);

                if (aluno == null)
                {
                    Console.WriteLine("Aluno não encontrado!");
                    return false;
                }
                else 
                {
                    if (_alunoRepository.Excluir(aluno))
                    {
                        Console.WriteLine("Aluno excluido com sucesso!");
                        return true; 
                    }
                    else
                    {
                        Console.WriteLine("Falha ao excluir aluno!");
                        return false;
                    }
                }

            }
            catch(Exception ex)
            {
                Console.WriteLine("ExcluiurAluno() : Ops! Algo saiu errado! " + ex.Message);
                return false;
            }
        }

        public IEnumerable<Aluno> ListarAlunos()
        { 
            try
            {
                return _alunoRepository.ListarTodos().ToList();
            } 
            catch(Exception ex)
            {
                Console.WriteLine("ListarAlunos() : Ops! Algo saiu errado! " + ex.Message);
                return new List<Aluno>();
            }
        }
        public Aluno ObterPorId(int id) 
        { 
            try
            {
                return _alunoRepository.ObterPorId(id);
            }
            catch(Exception ex)
            {
                Console.WriteLine("ObterPorId() : Ops! Algo saiu errado! " + ex.Message);
                return null;
            }
        }
    }
}

