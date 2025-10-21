namespace Atividade_poo;

class Program
{
    static void Main(string[] args)
    {
        Pessoa p = new Pessoa
        {
            Nome = "Rafaella",
            Idade = 18,
        };

        Aluno a = new Aluno
        {
            Nome = "Alana",
            Idade = 20,
            Curso = "Desenvolvimento de sistemas"
        };

        p.Apresentar();
        a.Apresentar();
    }
}
