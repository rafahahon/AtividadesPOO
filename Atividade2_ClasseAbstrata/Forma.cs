
namespace Atividade2_ClasseAbstrata
{
    public abstract class Forma
    {
        public abstract double CalcularArea(); // obriga a classe a implementar o metodo

        public void MostrarTipo()
        {
            Console.WriteLine("Sou uma forma geometrica.");
        }
    }
}