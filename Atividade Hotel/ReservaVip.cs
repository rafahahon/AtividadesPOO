
namespace Atividade_Hotel
{
    public class ReservaVip : Reserva
    {
        public double Desconto = 0.5;
        public int Dias { get; set; }
        public double PrecoDiaria { get; set; }

        public override double CalcularTotal() => PrecoDiaria * Dias * Desconto;
    }
}