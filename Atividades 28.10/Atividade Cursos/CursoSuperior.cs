namespace Atividade_Cursos
{
    public class CursoSuperior : Curso
    {
        public CursoSuperior(string NomeConstrutor, double HorasConstrutor) : base(NomeConstrutor, HorasConstrutor) { }

        public double Valor;

        public override double CalcularPreco()
        {
            return Valor = Horas * 40;
        }
    }
}