namespace Atividade_Animais;

class Program
{
    static void Main(string[] args)
    {
        Leao leao1 = new Leao();

        Elefante elefante1 = new Elefante();

        leao1.EmitirSom();
        leao1.TipoAlimentacao();

        elefante1.EmitirSom();
        elefante1.TipoAlimentacao();
    }
}
