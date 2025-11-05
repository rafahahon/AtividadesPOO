namespace Atividade_Animais
{
    public abstract class Animal
    {
        public string Nome { get; set; }

        public Animal(string NomeConstrutor)
        {
            Nome = NomeConstrutor;
        }

        public abstract void EmitirSom();
        public abstract void TipoAlimentacao();
    }
}