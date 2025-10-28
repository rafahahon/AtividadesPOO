
namespace Atividade_Hotel
{
    public class Reserva 
    {
        public string Hospede { get; set; }
        public int Quarto { get; set; }
        public int Dias { get; set; }

       public virtual void CalcularTotal(double PrecoDiaria) => Console.WriteLine($"O valor total da reserva foi de: R${PrecoDiaria * Dias:F2}");

        public void ResumoReserva()
        {
            Console.WriteLine($"Informacoes da reserva:\nHospede: {Hospede}.\nQuarto: {Quarto}.\nDias: {Dias}");
        }
    }
}