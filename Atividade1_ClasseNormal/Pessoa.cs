
namespace Atividade_poo
{
    public class Pessoa
    {
        public string Nome;
        public int Idade;

        public virtual void Apresentar() // virutal - vamos utilizar o metodo em outra classe podendo sobrescrever
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos.");
        }
    }
}