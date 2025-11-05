namespace Atividade_Funcionarios
{
    public class Gerente : Funcionario
    {
        public Gerente(string NomeConstrutor, double SalarioBaseConstrutor) : base(NomeConstrutor, SalarioBaseConstrutor) {}

        public override double CalcularSalario()
        {
            return SalarioBase * 1.5;
        }
    }
}