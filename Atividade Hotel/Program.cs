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
            Hospede = hospede1.Nome,
            Quarto = quarto1.Numero,
            Dias = 3,
        };


        reserva1.ResumoReserva();
        reserva1.CalcularTotal(quarto1.PrecoDiaria);

    
        ReservaVip reserva2 = new ReservaVip{
            Dias = 4
        };

        reserva2.CalcularTotal(quarto2.PrecoDiaria, reserva2.Dias);
        

        hospede1.ExibirInformacoes();

        quarto2.Ocupar();
    }
}
