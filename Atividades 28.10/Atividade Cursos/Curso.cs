namespace Atividade_Cursos
{
    public abstract class Curso
    {
        public string Nome { get; set; } = string.Empty;
        public double Horas { get; set; }

        public Curso(string NomeConstrutor, double HorasConstrutor)
        {
            Nome = NomeConstrutor;
            Horas = HorasConstrutor;
        }

        public abstract double CalcularPreco();
        public void ExibirResumo()
        {
            Console.WriteLine($"O curso: {Nome} tem a duração de: {Horas} horas e o valor é de: R${CalcularPreco():F2}");
        }
    }
}