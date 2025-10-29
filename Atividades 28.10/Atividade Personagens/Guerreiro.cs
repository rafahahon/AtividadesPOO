namespace Atividade_Personagens
{
    public class Guerreiro : Personagem
    {
        public int Poder;

        public override void CalcularPoder()
        {
            Poder = Nivel * 10;
            Nivel = Poder;
        }
    }
}