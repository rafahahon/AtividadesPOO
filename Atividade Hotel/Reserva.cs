
namespace Atividade_Hotel
{
    public class Reserva : Quarto
    {
        public string Hospede { get; set; }
        public int Quarto { get; set; }
        public int Dias { get; set; }
        public double PrecoDiaria { get; }

       /* public virtual void CalcularTotal()
        {
            PrecoDiaria * Dias;
        } */

        public void ResumoReserva()
        {
            Console.WriteLine($"Informacoes da reserva:\nHospede: {Hospede}.\nQuarto: {Quarto}.\nDias: {Dias}");
        }
    }
}