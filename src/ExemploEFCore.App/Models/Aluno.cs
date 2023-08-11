namespace ExemploEFCore.App.Models
{
    public class Aluno
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public int Idade { get; private set; }
        public string Email { get; private set; }

        public Aluno(){}

        public Aluno(string nome, int idade, Email email)
        {
            Nome = nome;
            Idade = idade;
            Email = email.Endereco;

            Validar();
        }

        public void AlterarNome(string novoNome)
        {
            Nome = novoNome;
            Validar();
        }

        public void AlterarIdade(int idade)
        {
            Idade = idade;
        }

        public void AlterarEmail(Email email)
        {
            Email = email.Endereco;
        }

        public void Validar()
        {
            if (string.IsNullOrEmpty(Nome))
                throw new ArgumentException("O nome do aluno não pode ser vazio");
        }
    }
}

