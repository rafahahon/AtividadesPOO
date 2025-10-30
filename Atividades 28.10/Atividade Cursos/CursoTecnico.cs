using System.Diagnostics.Contracts;

namespace Atividade_Cursos
{
    public class CursoTecnico : Curso
    {
        public override void CalcularPreco()
        {
            Valor = Horas * 20;
        }
    }
}