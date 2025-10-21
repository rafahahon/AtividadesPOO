
using System.Runtime.CompilerServices;

namespace Atividade_poo
{
    public class Aluno : Pessoa
    {
        public string Curso;

        public override void Apresentar()
        {
            Console.WriteLine($"Sou o(a) aluno(a) {Nome}, tenho {Idade} anos e estudo {Curso}.");
        }
    }
}