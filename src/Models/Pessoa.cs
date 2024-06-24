namespace sistema_de_hospedagem_CSharp.src.Models
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }


        public Pessoa() { }

        public Pessoa(string nome){

            this.Nome = nome;

        }

        public Pessoa(string nome, string sobrenome){

            this.Nome = nome;
            this.Sobrenome = sobrenome;

        }

        public void ApresentarNomeCompleto(){

            Console.WriteLine($"{Nome} {Sobrenome}".ToUpper());

        }
    }
}