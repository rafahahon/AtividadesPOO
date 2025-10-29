namespace Atividade_Funcionarios
{
    public abstract class Funcionario
    {
        public string Nome { get; set; } = string.Empty;
        public double SalarioBase { get; set; }

        public abstract void CalcularSalario();
        
        public void ExibirResumo()
        {
            Console.WriteLine($"O(a) funcionário(a): {Nome}, recebe R${SalarioBase}");
        }
    }
}