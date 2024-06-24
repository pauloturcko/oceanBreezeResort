namespace sistema_de_hospedagem_CSharp.src.Models
{
    public class Suite
    {

        public string TipoSuite { get; set; }
        public int Capacidade { get; set; }
        public decimal ValorDiaria { get; set; }

        public Suite(){ }

        public Suite(string tipoSuite, int capacidade, decimal valorDiaria){

            this.TipoSuite = tipoSuite;
            this.Capacidade = capacidade;
            this.ValorDiaria = valorDiaria;

        }
    }
}