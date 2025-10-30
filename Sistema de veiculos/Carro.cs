
namespace Sistema_de_veiculos
{
    public class Carro : Veiculo
    {
        public override void CalcularRevisao() 
        {
            Console.WriteLine($"Valor fixo da revisao do modelo {Modelo}: R$500,00.");
        }
    }
}
