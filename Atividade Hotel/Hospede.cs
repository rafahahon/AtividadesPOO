
namespace Atividade_Hotel
{
    public class Hospede
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Telefone { get; set; }

        // metodo construtor
        public Hospede(string NomeConstrutor, string CPFconstrutor, string TelefoneConstrutor)
        {
            Nome = NomeConstrutor;
            Cpf = CPFconstrutor;
            Telefone = TelefoneConstrutor;
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine($"Informacoes do hospede: \nNome: {Nome}.\nCPF: {Cpf}.\nTelefone: {Telefone}");
        }
    }
}