namespace Atividade_Cursos
{
    public class CursoSuperior : Curso
    {
        public override void CalcularPreco()
        {
            Valor = Horas * 40;
        }
    }
}