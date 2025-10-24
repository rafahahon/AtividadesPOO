namespace Atividade_23._10_Classe_Pessoa;

class Program
{
    static void Main(string[] args)
    {
        PessoaFisica pf = new PessoaFisica 
        {
            Nome = "Rafa Hahon",
            Cpf = "123.456.789-00",
            DataNascimento = new DateTime(2006, 11, 21)
        };

        pf.AdicionarEndereco(new Endereco 
        {
            Rua = "Rua das Flores",
            Numero = 100,
            Cidade = "Sao Paulo",
            Estado = "SP",
            Cep = "01000-000",
            Comercial = false
        });

        PessoaJuridica pj = new PessoaJuridica 
        {
            Nome = "Loja Exemplo",
            RazaoSocial = "Loja Exemplo LTDA",
            Cnpj = "12.345.678/001-99"
        };

        pj.AdicionarEndereco(new Endereco
        {
            Rua = "Av. Central",
            Numero = 2000,
            Cidade = "Campinas",
            Estado = "SP",
            Cep = "13000-000",
            Comercial = true
        });

        pf.PagarImposto();
        pj.PagarImposto();
    }
}