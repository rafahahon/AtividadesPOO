namespace AbertoFechado_O;

class Program
{
    static void Main(string[] args)
    {
        Desconto d1 = new DescontoNatal();
        Desconto d2 = new DescontoBlackFriday();

        Console.WriteLine($"Natal: {d1.Calcular(1000):C}"); // :C traz o formato monetario do sistema
        Console.WriteLine($"Black Friday: {d2.Calcular(1000).ToString("C")}"); // funciona igual o :C
        Console.WriteLine($"Black Friday: {d2.Calcular(2000)}");
    }
}
