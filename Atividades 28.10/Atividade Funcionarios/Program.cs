namespace Atividade_Funcionarios;

class Program
{
    static void Main(string[] args)
    {
        List<Funcionario> funcionarios = new List<Funcionario>
        {
            new Gerente("Rafaella", 5000),
            new Vendedor("Mayara", 3000)
        };

        foreach(var funcionario in funcionarios)
        {
            funcionario.ExibirResumo();
        }
    }
}
