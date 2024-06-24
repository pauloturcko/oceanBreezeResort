namespace sistema_de_hospedagem_CSharp.src.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados){

            this.DiasReservados = diasReservados;

        }

        public void CadastrarHospedes(List<Pessoa> hospedes){

            int quantideDeHospedes = hospedes.Count;

            try {

                if (quantideDeHospedes <= Suite.Capacidade)
                {
                    this.Hospedes = hospedes;
                }
                else
                {
                    Console.WriteLine($"Quantidade de hospedes superior ao limite máximo da suite");
                }

            } catch (Exception ex){

                Console.WriteLine(ex.Message);

            }

        }

        public void CadastrarSuite(Suite suite)
        {
            this.Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            int hospedes = Hospedes.Count;
            return hospedes;
        }

        public decimal CalcularValorDiaria()
        {

            decimal valor = DiasReservados * Suite.ValorDiaria;
            const decimal DESCONTO = 0.10M;
            decimal valorComDesconto = valor - (valor * DESCONTO);

            if (DiasReservados >= 10)
            {
                return valorComDesconto;
            }
            return valor;
        }
    }
}