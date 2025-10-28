namespace Atividade_Hotel;

class Program
{
    static void Main(string[] args)
    {
        Hospede hospede1 = new Hospede
        {
            Nome = "Rafaella Hahon",
            Cpf = "4324234-44",
            Telefone = 324242542
        };

        Hospede hospede2 = new Hospede
        {
            Nome = "Mayara Almeida",
            Cpf = "546234-44",
            Telefone = 35436546
        };

        Quarto quarto1 = new Quarto 
        {
            Numero = 101,
            Tipo = "Simples",
            PrecoDiaria = 99.99,
            Disponivel = true
        };

        Quarto quarto2 = new Quarto 
        {
            Numero = 102,
            Tipo = "Duplo",
            PrecoDiaria = 199.99,
            Disponivel = false
        };

        Reserva reserva1 = new Reserva
        {
            Hospede = "hospede1",
            Quarto = 101,
            Dias = 3,
            PrecoDiaria = 99.99
        };


        //reserva1.ResumoReserva();
        //Console.WriteLine($"O valor total da reserva foi de: R${reserva1.CalcularTotal():F2}");
    

    
        ReservaVip reserva2 = new ReservaVip
        {
            Dias = 7,
            PrecoDiaria = 199.99
        };
        
        Console.WriteLine($"O valor total da reserva VIP foi de: R${reserva2.CalcularTotal():F2}");

        //hospede1.ExibirInformacoes();

        //quarto2.Ocupar();
    }
}
