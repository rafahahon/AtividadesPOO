namespace Atividade_Personagens;

class Program
{
    static void Main(string[] args)
    {
        Personagem guerreiro1 = new Guerreiro()
        {
            Nome = "Arthur",
            Nivel = 15
        };

        Personagem mago1 = new Mago()
        {
            Nome = "Michael",
            Nivel = 20
        };

        guerreiro1.CalcularPoder();
        guerreiro1.ExibirStatus();

        mago1.CalcularPoder();
        mago1.ExibirStatus();
    }
}
