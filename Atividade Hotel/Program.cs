namespace Atividade_Hotel;

class Program
{
    static void Main(string[] args)
    {
        Hospede hospede1 = new Hospede("Ana Souza", "123.456.789-00", "(11) 99999 9999");
        Hospede hospede2 = new Hospede("Mayara Almeida", "321.654.789-00", "(11) 88888 9999");

        Quarto quarto1 = new Quarto(101, "Suite", 400);
        Quarto quarto2 = new Quarto(102, "Duplo", 500);

        Reserva reserva1 = new Reserva(hospede1, quarto1, 3);
        ReservaVip reservaVip1 = new ReservaVip(hospede2, quarto2, 2, 10);

        List<Reserva> reservas = new List<Reserva> {reserva1, reservaVip1};

        foreach(var reserva in reservas)
        {
            reserva.CalcularTotal();
            Console.WriteLine(reserva.ResumoReserva());
        }
    }
}
