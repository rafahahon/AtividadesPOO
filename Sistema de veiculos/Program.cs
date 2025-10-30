namespace Sistema_de_veiculos;

class Program
{
    static void Main(string[] args)
    {
        Carro veiculo1 = new Carro 
        {
            Modelo = "HB20",
            Ano = 2025
        };

        Moto veiculo2 = new Moto
        {
            Modelo = "PCX",
            Ano = 2024
        };

        veiculo1.CalcularRevisao();
        veiculo2.CalcularRevisao();
    }
}
