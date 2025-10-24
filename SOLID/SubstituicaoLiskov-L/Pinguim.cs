
namespace SubstituicaoLiskov_L
{
    public class Pinguim : Ave
    {
        public override void Mover() => Console.WriteLine("Andando..."); // isso e um override, adicionar uma "acao" ao metodo abstrato

        public override void Dormir() => Console.WriteLine("Pinguim dormindo...");
    }
}