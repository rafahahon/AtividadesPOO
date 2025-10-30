namespace Atividade_Funcionarios;

class Program
{
    static void Main(string[] args)
    {
        Gerente gerente1 = new Gerente
        {
            Nome = "Rebeca",
            SalarioBase = 5000.00
        };

        Vendedor vendedor1 = new Vendedor
        {
            Nome = "Tomas",
            SalarioBase = 2000.00
        };

        gerente1.CalcularSalario();
        gerente1.ExibirResumo();

        vendedor1.CalcularSalario();
        vendedor1.ExibirResumo();
    }
}
