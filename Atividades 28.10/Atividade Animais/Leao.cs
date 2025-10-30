using System.IO.Pipes;

namespace Atividade_Animais
{
    public class Leao : Animal
    {
        public override void EmitirSom()
        {
            Console.WriteLine("O som do leão é o rugido.");
        }
        public override void TipoAlimentacao()
        {
            Console.WriteLine("O leão é carnívoro.");
        }
    }
}