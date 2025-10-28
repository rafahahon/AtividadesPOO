
namespace Atividade_Hotel
{
    public class ReservaVip : Reserva
    {
        public double Desconto = 0.5;

        public void CalcularTotal(double PrecoDiaria, int Dias) => Console.WriteLine($"O valor total da reserva VIP foi de: R${PrecoDiaria * Dias * Desconto:F2}");
    }
}