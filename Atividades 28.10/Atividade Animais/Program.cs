namespace Atividade_Animais;

class Program
{
    static void Main(string[] args)
    {
        Leao leao1 = new Leao("Alan");

        Elefante elefante1 = new Elefante("Tomas");

        leao1.EmitirSom();
        leao1.TipoAlimentacao();

        elefante1.EmitirSom();
        elefante1.TipoAlimentacao();
    }
}
