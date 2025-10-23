
namespace Atividade2_ClasseAbstrata
{
    public abstract class Forma
    {
        public abstract double CalcularArea(); // metodo abstrato obriga a classe filha a implementar o metodo e sobrescrever (override)

        public void MostrarTipo()
        {
            Console.WriteLine("Sou uma forma geometrica.");
        }
    }
}