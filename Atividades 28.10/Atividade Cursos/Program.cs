using Microsoft.Win32.SafeHandles;

namespace Atividade_Cursos;

class Program
{
    static void Main(string[] args)
    {
        Curso curso1 = new CursoTecnico()
        {
            Nome = "Excel",
            Horas = 5
        };

        Curso curso2 = new CursoSuperior()
        {
            Nome = "ADS",
            Horas = 1000
        };

        curso1.CalcularPreco();
        curso1.ExibirResumo();

        curso2.CalcularPreco();
        curso2.ExibirResumo();
    }
}
