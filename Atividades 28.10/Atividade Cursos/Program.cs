using Microsoft.Win32.SafeHandles;

namespace Atividade_Cursos;

class Program
{
    static void Main(string[] args)
    {
        Curso curso1 = new CursoTecnico("Excel", 5) { };

        Curso curso2 = new CursoSuperior("ADS", 500) { };

        curso1.CalcularPreco();
        curso1.ExibirResumo();

        curso2.CalcularPreco();
        curso2.ExibirResumo();
    }
}
