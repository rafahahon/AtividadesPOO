namespace Atividade_Funcionarios
{
    public class Gerente : Funcionario
    {
        public override void CalcularSalario()
        {
            SalarioBase = SalarioBase + (SalarioBase * 0.5);
        }
    }
}