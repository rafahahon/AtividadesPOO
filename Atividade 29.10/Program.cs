namespace Atividade_29._10;

class Program
{
    static void Main(string[] args)
    {
        Carro carro1 = new Carro()
        {
            Marca = "Honda",
            Modelo = "Civic",
            Ano = 2009,
            QuantidadeDePortas = 4
        };

        carro1.ExibirDetalhes();
    }
}
