
namespace Sistema_de_veiculos
{
    public class Moto : Veiculo
    {
        public override void CalcularRevisao() 
        {
            Console.WriteLine($"Valor fixo da revisao do modelo {Modelo}: R$300,00.");
        }
    }
}