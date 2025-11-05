using System.Diagnostics.Contracts;

namespace Atividade_Cursos
{
    public class CursoTecnico : Curso
    {
        public CursoTecnico(string NomeConstrutor, double HorasConstrutor) : base(NomeConstrutor, HorasConstrutor) { }
        public double Valor;
        
        public override double CalcularPreco()
        {
            return Valor = Horas * 20;
        }
    }
}