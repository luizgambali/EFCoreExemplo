using ExemploEFCore.App.Models;
using ExemploEFCore.App.Interfaces;
using ExemploEFCore.App.Services;
using ExemploEFCore.App.Data;
using Microsoft.Extensions.DependencyInjection;
using ExemploEFCore.App.DI;
using System.Linq;

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
            var primeiroAluno = new Aluno() { Nome = "Primeiro Aluno", Email = "primeiroaluno@email.com", Idade = 22 };
            var segundoAluno = new Aluno() { Nome = "Segundo Aluno", Email = "segundoaluno@email.com", Idade = 27 };
            var terceiroAluno = new Aluno() { Nome = "Terceiro Aluno", Email = "terceiroaluno@email.com", Idade = 19 };

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

            //altera os dados desse aluno
            aluno.Nome = "Teste de alteração de nome";
            aluno.Idade = 35;
            aluno.Email = "testenome@email.com";

            //atualiza os dados do aluno
            alunoService.AtualizarDados(aluno.Id, aluno);

            //recupera os dados do aluno novamente
            var alunoAlterado = alunoService.ObterPorId(aluno.Id);

            //mostra os dados do aluno
            Console.WriteLine($"Aluno: {alunoAlterado.Nome}, Idade: {alunoAlterado.Idade}, E-mail: {alunoAlterado.Email} ");

            //
            alunoService.ExcluirAluno(aluno.Id);

            //mostrando os alunos cadastrados no banco
            foreach(var item in lista) 
                Console.WriteLine($"Aluno: {item.Nome}, Idade: {item.Idade}, E-mail: {item.Email} ");
        }
    }
}






            