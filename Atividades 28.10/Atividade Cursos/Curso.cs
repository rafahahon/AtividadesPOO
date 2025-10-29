namespace Atividade_Cursos
{
    public abstract class Curso
    {
        public string Nome { get; set; } = string.Empty;
        public double Horas { get; set; }
        public double Valor;

        public abstract void CalcularPreco();
        public void ExibirResumo()
        {
            Console.WriteLine($"O curso: {Nome} tem a duração de: {Horas} horas e o valor é de: R${Valor}");
        }
    }
}