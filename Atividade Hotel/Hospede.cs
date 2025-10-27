
namespace Atividade_Hotel
{
    public class Hospede
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public int Telefone { get; set; }

        public void ExibirInformacoes()
        {
            Console.WriteLine($"Informacoes do hospede: \nNome: {Nome}.\nCPF: {Cpf}.\nTelefone: {Telefone}");
        }
    }
}