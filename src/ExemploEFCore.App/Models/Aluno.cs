using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExemploEFCore.App.Models
{
    public class Aluno
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Email { get; set; }
        public bool Validate()
        {
            if (string.IsNullOrEmpty(Nome) || string.IsNullOrEmpty(Email) || Idade < 16)
                return false;

            return true;
        }
    }
}

