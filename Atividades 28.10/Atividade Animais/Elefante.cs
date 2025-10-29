namespace Atividade_Animais
{
    public class Elefante : Animal
    {
        public override void EmitirSom()
        {
            Console.WriteLine("O som do elefante é o barrito.");
        }
        public override void TipoAlimentacao()
        {
            Console.WriteLine("O elefante é herbívoro.");
        }
    }
}