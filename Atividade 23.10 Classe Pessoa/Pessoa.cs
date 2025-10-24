
namespace Atividade_23._10_Classe_Pessoa
{
    public abstract class Pessoa
    {
        public string Nome { get; set; } = string.Empty;

        public List<Endereco> Enderecos { get; } = new List<Endereco>();
        
        public abstract void PagarImposto();

        public void AdicionarEndereco(Endereco parametro_endereco)
        {
            Enderecos.Add(parametro_endereco); // add vai adicionar dentro da lista
        }
    } 
}