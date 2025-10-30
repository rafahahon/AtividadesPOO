namespace Atividade_29._10
{
    public class Onibus : Transporte
    {
        public override void CalcularTempoViagem(double distancia)
        {
            Console.WriteLine($"O tempo de viagem estimado é de: {distancia / 60}");
        }
    }
}