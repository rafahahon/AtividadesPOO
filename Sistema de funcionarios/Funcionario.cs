
namespace Sistema_de_funcionarios
{
    public abstract class Funcionario
    {
        public string Nome { get; set; }
        public double SalarioBase { get; set; }

        public abstract void CalcularSalario();

        public void ExibirResumo()
        {
            Console.WriteLine($"O(a) funcionario(a): {Nome} recebe: R${SalarioBase:F2}");
        }
    }
}