
using System.Runtime.CompilerServices;

namespace Atividade_Hotel
{
    public class Quarto
    {
        public int Numero { get; set; }
        public string Tipo { get; set; }
        public double PrecoDiaria { get; set; }
        public bool Disponivel { get; set; } 

        // metodo construtor
        public Quarto(int NumeroQuartoConstrutor, string TipoQuartoConstrutor, double PrecoDiariaConstrutor){
            Numero = NumeroQuartoConstrutor;
            Tipo = TipoQuartoConstrutor;
            PrecoDiaria = PrecoDiariaConstrutor;

            Disponivel = true; // Quarto inicializa como disponível
        }

        public void ExibirDetalhes()
        {
            Console.WriteLine($"Detalhes do quarto:\nNumero: {Numero}.\nTipo: {Tipo}.\nPreco diaria: {PrecoDiaria}\nDisponibilidade: {Disponivel}");
        }

        public void Ocupar()
        {
            if(Disponivel) 
            {
                Disponivel = false;
                Console.WriteLine("Quarto ocupado com sucesso!");
            }
            else 
            {
                Console.WriteLine("Quarto ja ocupado.");
            }
        }

        public void Liberar()
        {
            if(!Disponivel)
            {
                Disponivel = true;
                Console.WriteLine("Quarto liberado com sucesso!");
            }
            else 
            {
                Console.WriteLine("Quarto ja disponivel.");
            }
        }
    }
}