namespace Atividade_29._10
{
    public class Veiculo
    {
        public string Marca { get; set; } = string.Empty;
        public string Modelo { get; set; } = string.Empty;
        public int Ano { get; set; }

        public virtual void Ligar()
        {
            Console.WriteLine($"O veículo {Modelo} está ligado!");
        }

        public void ExibirDetalhes()
        {
            Console.WriteLine($"O veículo da marca {Marca}, modelo {Modelo} e ano {Ano}.");
        }
    }
}