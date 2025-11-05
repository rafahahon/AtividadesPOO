namespace Atividade_Personagens;

class Program
{
    static void Main(string[] args)
    {
        Guerreiro guerreiro1 = new Guerreiro("Arthur", 15);

        guerreiro1.CalcularPoder();
        guerreiro1.ExibirStatus();
    }
}
