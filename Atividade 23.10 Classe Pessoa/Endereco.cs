
namespace Atividade_23._10_Classe_Pessoa
{
    public class Endereco
    {
        public string Rua { get; set; } = string.Empty; // preenche o nome com vazio ao inves de nulo
                                                        // empty avisa pra maquina q esta vazio intencionalmente, ja o null a maquina considera um erro
        public int Numero { get; set; }
        public string Cidade { get; set; } = string.Empty;
        public string Estado { get; set; } = string.Empty;
        public string Cep { get; set; } = string.Empty;
        public string Complemento { get; set; } = string.Empty;
        public bool Comercial { get; set; }
    }
}