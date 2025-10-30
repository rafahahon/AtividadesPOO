
namespace Atividade_Hotel
{
    public class Reserva
    {
        public Hospede HospedeReserva { get; set; }
        public Quarto QuartoReserva { get; set; }
        public int Dias { get; set; }
        public double ValorTotal { get; set; }

        public Reserva(Hospede HospedeConstrutor, Quarto QuartoConstrutor, int DiasConstrutor)
        { // Sempre é passado o tipo do dado (Hospede) e o nome da variável (HospedeConstrutor)
            HospedeReserva = HospedeConstrutor;
            QuartoReserva = QuartoConstrutor;
            Dias = DiasConstrutor;
        }

        public virtual double CalcularTotal()
        {
            ValorTotal = QuartoReserva.PrecoDiaria * Dias;
            return ValorTotal;
        }

        public virtual string ResumoReserva()
        {
            return
                 $"Hóspede {HospedeReserva.Nome} está hospedado(a) no quarto {QuartoReserva.Numero} por {Dias} dias. Pagando o total de R${ValorTotal}.";
        }
    }
}