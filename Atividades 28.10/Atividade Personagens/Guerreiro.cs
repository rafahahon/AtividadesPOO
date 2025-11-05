using System.Security.Cryptography.X509Certificates;

namespace Atividade_Personagens
{
    public class Guerreiro : Personagem
    {
        public Guerreiro(string NomeConstrutor, int NivelConstrutor) : base(NomeConstrutor, NivelConstrutor) { }
        public int Poder;
    
        public override int CalcularPoder()
        {
            return  Poder = Nivel * 10;
        }
    }
}