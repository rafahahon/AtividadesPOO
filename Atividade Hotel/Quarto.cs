
using System.Runtime.CompilerServices;

namespace Atividade_Hotel
{
    public class Quarto
    {
        public int Numero { get; set; }
        public string Tipo { get; set; }
        public double PrecoDiaria { get; set; }
        public bool Disponivel { get; set; } = true;

        public void ExibirDetalhes()
        {
            Console.WriteLine($"Detalhes do quarto:\nNumero: {Numero}.\nTipo: {Tipo}.\nPreco diaria: {PrecoDiaria}\nDisponibilidade: {Disponivel}");
        }

        public void Ocupar()
        {
            if(Disponivel) 
            {
                Console.WriteLine("Quarto ocupado com sucesso!");
                Disponivel = false;
            }
            else 
            {
                Console.WriteLine("Quarto ja ocupado.");
            }
        }

        public void Liberar()
        {
            if(Disponivel = false)
            {
                Console.WriteLine("Quarto liberado com sucesso!");
                Disponivel = true;
            }
            else 
            {
                Console.WriteLine("Quarto ja disponivel.");
            }
        }
    }
}