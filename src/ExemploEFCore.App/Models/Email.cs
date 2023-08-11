namespace ExemploEFCore.App.Models
{
    public class Email 
    {
        public string Endereco { get; private set; } 

        public Email(string endereco)
        {
            Endereco = endereco;
            Validar();
        }

        //validação básica do endereço de e-mail
        public void Validar()
        {
            if (string.IsNullOrEmpty(Endereco))
                throw new ArgumentException("Email inválido!");

            if (!Endereco.Contains("@"))
                throw new ArgumentException("Email em formato inválido!");

            
            var prefixo = Endereco.Split("@")[0].Trim();
            var sufixo = Endereco.Split("@")[1].Trim();


            if (string.IsNullOrEmpty(prefixo) 
                || string.IsNullOrEmpty(sufixo) 
                || prefixo.Length < 3 
                || sufixo.Length < 3 
                || !sufixo.Contains(".") 
                || sufixo.EndsWith("."))
                throw new ArgumentException("Email em formato inválido!");

        }
    }
}