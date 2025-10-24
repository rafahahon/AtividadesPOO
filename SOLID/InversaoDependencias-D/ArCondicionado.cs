
namespace InversaoDependencias_D
{
    public class ArCondicionado : IDispositivo // nao vai funcionar se nao herdar o dispositivo pq o interruptor precisa ser um dispositivo
    {
        public void Ligar() => Console.WriteLine("Ar-condicionado ligado!");
    }
}