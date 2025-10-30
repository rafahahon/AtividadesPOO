namespace Atividade_Personagens
{
    public abstract class Personagem
    {
        public string Nome { get; set; } = string.Empty;
        public int Nivel { get; set; }

        public abstract void CalcularPoder();
        public void ExibirStatus()
        {
            Console.WriteLine($"O(a): {Nome} está no nível {Nivel}.");
        }
    }
}