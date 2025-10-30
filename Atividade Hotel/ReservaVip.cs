
namespace Atividade_Hotel
{
    public class ReservaVip : Reserva
    {
        public double Desconto { get; set; }

        public ReservaVip(Hospede HospedeConstrutor, Quarto QuartoConstrutor, int DiasConstrutor, double DescontoConstrutor) : base(HospedeConstrutor, QuartoConstrutor, DiasConstrutor) // ":base" -Forma de herdar construtores, colocando na ordem que foi colocado no construtor
        { 
            Desconto = DescontoConstrutor;
            // Não precisa escrever os outros construtores, pois já foi herdado exatamente da mesma forma
        }

        public override double CalcularTotal() 
        {
            double ValorSemDesconto = QuartoReserva.PrecoDiaria * Dias;
            double ValorComDesconto = ValorSemDesconto * (1 - (Desconto/100));
            return ValorComDesconto;
        }

        public override string ResumoReserva()
        {
            return
                    $"Reserva VIP de {HospedeReserva.Nome}\nQuarto: {QuartoReserva.Numero} ({QuartoReserva.Tipo})\nDesconto aplicado: {Desconto}%\nValor total: R${CalcularTotal():F2}";
        }
    }
}