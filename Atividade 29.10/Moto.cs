namespace Atividade_29._10
{
    public class Moto : Veiculo, ICombustivel
    {
        public int Cilindrada { get; set; }

        public override void Ligar()
        {
            Console.WriteLine($"A moto {Modelo} de {Cilindrada} está pronta!");
        }

        public void Abastecer(double litros)
        {
            Console.WriteLine("Carro precisa ser abastecido.");
        }

        public void VerificarNivelCombustivel()
        {
            Console.WriteLine("Carro abastecido com X litros de gasolina.");
        }
    }
}