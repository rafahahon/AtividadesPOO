namespace Atividade_29._10
{
    public class Moto : Veiculo
    {
        public int Cilindrada { get; set; }

        public virtual void Ligar()
        {
            Console.WriteLine($"A moto {Modelo} de {Cilindrada} está pronta!");
        }
    }
}