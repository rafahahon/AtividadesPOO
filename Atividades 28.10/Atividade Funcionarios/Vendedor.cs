namespace Atividade_Funcionarios
{
    public class Vendedor : Funcionario
    {
        public override void CalcularSalario()
        {
            SalarioBase = SalarioBase + (SalarioBase * 0.2);
        }
    }
}