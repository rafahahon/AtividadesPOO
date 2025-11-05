namespace Atividade_Funcionarios
{
    public abstract class Funcionario
    {
        public string Nome { get; set; } = string.Empty;
        public double SalarioBase { get; set; }

        public Funcionario(string NomeConstrutor, double SalarioBaseConstrutor)
        {
            Nome = NomeConstrutor;
            SalarioBase = SalarioBaseConstrutor;
        }

        public abstract double CalcularSalario();
        
        public void ExibirResumo()
        {
            Console.WriteLine($"O(a) funcionário(a): {Nome}, tem o salário base: R${SalarioBase:F2} e recebe R${CalcularSalario():F2}.");
        }
    }
}