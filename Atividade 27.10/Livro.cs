
namespace Atividade_27._10
{
    public class Livro
    {
        public string Titulo { get; set; } // get e set servem para colocar algumas regrinhas dentro do atributo 
        public string Autor { get; set; }
        public int AnoPublicacao { get; set; }
        /*{ 
            get
            {
                return AnoPublicacao;
            }
            set
            {
                if (value > 0)
                {
                    AnoPublicacao = value;
                }

                else
                {
                    Console.WriteLine("Erro, ano de publicacao e invalido.");
                }
            }
        } */
        public double Preco { get; set; }
        public bool EstaDisponivel { get; set; } = true;

        // construtor 
        // e um metodo especial, usado para inicializar o estado do objeto 

        public Livro(string tituloConstrutor, string autorConstrutor, int anoConstrutor, double precoConstrutor)
        {
            // this.titulo = titulo
            Titulo = tituloConstrutor;
            Autor = autorConstrutor;
            AnoPublicacao = anoConstrutor;
            Preco = precoConstrutor;

            // definindo valor inicial como true
            EstaDisponivel = true;

            Console.WriteLine($"Novo livro: {tituloConstrutor} criado e disponivel.");
        }

        public void ExibirDetalhes()
        {
            Console.WriteLine("*** DETALHES DO LIVRO ***");
            Console.WriteLine($"Titulo: {Titulo}");
            Console.WriteLine($"Autor: {Autor}");
            Console.WriteLine($"Publicacao: {AnoPublicacao}");
            Console.WriteLine($"Preco: {Preco:F2}"); // f2 formata com 2 casas decimais

            if(EstaDisponivel)
            {
                Console.WriteLine("Status: Disponivel para emprestimo.");
            }
            else 
            {
                Console.WriteLine("Status: Emprestado! (Indisponivel)");
            }
        }

        public void Emprestar()
        {
            if(EstaDisponivel)
            {
                EstaDisponivel = false;
                Console.WriteLine($"O livro: {Titulo} foi emprestado.");
            }
            else
            {
                Console.WriteLine($"O livro: {Titulo} ja esta emprestado.");
            }
        }
    }
}