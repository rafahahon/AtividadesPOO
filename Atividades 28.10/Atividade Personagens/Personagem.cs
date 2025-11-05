namespace Atividade_Personagens
{
    public abstract class Personagem
    {
        public string Nome { get; set; } = string.Empty;
        public int Nivel { get; set; }

        public Personagem(string NomeConstrutor, int NivelConstrutor)
        {
            Nome = NomeConstrutor;
            Nivel = NivelConstrutor;
        }

        public abstract int CalcularPoder();
        public void ExibirStatus()
        {
            Console.WriteLine($"O(a): {Nome} começou no nível: {Nivel} e está atualmente no nível: {CalcularPoder()}.");
        }
    }
}