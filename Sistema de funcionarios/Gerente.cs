
namespace Sistema_de_funcionarios
{
    public class Gerente : Funcionario
    {
        public override void CalcularSalario()
        {
            SalarioBase + (SalarioBase * 0.5);
        }
    }
}