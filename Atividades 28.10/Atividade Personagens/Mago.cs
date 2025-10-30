namespace Atividade_Personagens
{
    public class Mago : Personagem
    {
        public int Poder;

        public override void CalcularPoder()
        {
            Poder = Nivel * 8 + 20;
            Nivel = Poder;
        }
    }
}