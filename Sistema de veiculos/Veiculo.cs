
namespace Sistema_de_veiculos
{
    public abstract class Veiculo
    {
        public string Modelo { get; set; }
        public int Ano { get; set; }

        public abstract void CalcularRevisao();

        public void ExibirResumo() 
        {
            Console.WriteLine($"Resumo do(a): {Modelo}, ano: {Ano}.");
        }
    }
}