
namespace Atividade_Hotel
{
    public class Reserva
    {
        public string Hospede { get; set; }
        public int Quarto { get; set; }
        public int Dias { get; set; }
        public double PrecoDiaria { get; set; } 

       public virtual double CalcularTotal() => PrecoDiaria * Dias;

        public void ResumoReserva()
        {
            Console.WriteLine($"Informacoes da reserva:\nHospede: {Hospede}.\nQuarto: {Quarto}.\nDias: {Dias}");
        }
    }
}