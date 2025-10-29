namespace Atividade_29._10
{
    public abstract class Transporte
    {
        public abstract void CalcularTempoViagem(double distancia);
        public void IniciarViagem()
        {
            Console.WriteLine("Viagem iniciada...");
        }
    }
}