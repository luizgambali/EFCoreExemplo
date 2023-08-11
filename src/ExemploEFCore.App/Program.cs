using ExemploEFCore.App.Models;
using ExemploEFCore.App.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using ExemploEFCore.App.DI;

namespace ExemploEFCore.App
{
    public static class Program
    {
        private static ServiceProvider serviceProvider;

        public static void Main(String[] args)
        {
            DependencyInjection.ConfigureServices(ref serviceProvider);

            //pegando a instancia da classe AlunoService
            var alunoService = serviceProvider.GetService<IAlunoService>();

            //criando os alunos
            var primeiroAluno = new Aluno("Primeiro Aluno", 22, new Email("primeiroaluno@email.com"));            
            var segundoAluno = new Aluno("Segundo Aluno",27, new Email("segundoaluno@email.com"));            
            var terceiroAluno = new Aluno("Terceiro Aluno", 19, new Email("terceiroaluno@email.com"));

            //inserindo um aluno
            alunoService.InserirAluno(primeiroAluno);
            alunoService.InserirAluno(segundoAluno);
            alunoService.InserirAluno(terceiroAluno);

            //recuperando os alunos
            var lista = alunoService.ListarAlunos();

            //mostrando os alunos cadastrados no banco
            foreach(var item in lista) 
                Console.WriteLine($"Aluno: {item.Nome}, Idade: {item.Idade}, E-mail: {item.Email} ");

            //pega o primeiro aluno cadastrado
            var aluno  = lista.FirstOrDefault();

            if (aluno != null)
            {
                aluno.AlterarNome("Teste de alteração de nome");
                aluno.AlterarIdade(35);
                aluno.AlterarEmail(new Email("testenome@email.com"));
                alunoService.AtualizarDados(aluno.Id, aluno);
            }
            
            var alunoAlterado = alunoService.ObterPorId(aluno.Id);

            Console.WriteLine($"Aluno: {alunoAlterado.Nome}, Idade: {alunoAlterado.Idade}, E-mail: {alunoAlterado.Email} ");

            alunoService.ExcluirAluno(aluno.Id);

            foreach(var item in lista) 
                Console.WriteLine($"Aluno: {item.Nome}, Idade: {item.Idade}, E-mail: {item.Email} ");
        }
    }
}






            