namespace Atividade_Personagens
{
    public class Mago : Personagem
    {
        public Mago(string NomeConstrutor, int NivelConstrutor) : base(NomeConstrutor, NivelConstrutor) { }
        public int Poder;

        public override int CalcularPoder()
        {
            return Poder = Nivel* 8 + 20;
        }
    }
}