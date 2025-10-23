namespace Atividade4_Comparacao;

class Program
{
    static void Main(string[] args)
    {
        Programador dev = new Programador {Nome = "Rafaella"}; 
        dev.Trabalhar();
        dev.ExecutarTarefa();

        Pessoa p = new Pessoa {Nome = "Mayara"};
        p.Falar();

        // nao posso criar objeto a partir de classe abstrata
        //Funcionario f = new Funcionario {Nome = "Rafaella"};
        //f.Trabalhar();
    }
}
