namespace Atividade_29._10
{
    public class Carro : Veiculo, ICombustivel
    {
        public int QuantidadeDePortas { get; set; }

        public override void Ligar()
        {
            Console.WriteLine($"O carro {Modelo} está pronto para rodar!");
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