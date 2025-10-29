namespace Atividade_29._10
{
    public class Carro : Veiculo
    {
        public int QuantidadeDePortas { get; set; }

        public override void Ligar()
        {
            Console.WriteLine($"O carro {Modelo} está pronto para rodar!");
        }
    }
}