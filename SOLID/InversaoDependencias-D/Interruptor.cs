
namespace InversaoDependencias_D
{
    public class Interruptor // o interruptor nao e um dispositivo
    {
        private readonly IDispositivo dispositivo; // variavel privada somente para leitura, variavel criada como dispositivo 
        // variavel dispositivo que vem da interface Dispositivo
        
        /*private ArCondicionado ar; JEITO ERRADO (caso nao fizesse como dispositivo)

        public Interruptor()
        {
            ar = new ArCondicionado();
        }
        JEITO ERRADO */ 


        public Interruptor(IDispositivo dispositivo) // = _dispositivo
        {                        // parametro_dispositivo
            // this.dispositivo para nao confundir as variaveis
            this.dispositivo = dispositivo; // ou = _dispositivo
        }                        // parametro_dispositivo

        public void Acionar() => dispositivo.Ligar();

        // public void Acionar() => ar.Ligar(); JEITO ERRADO
    }
}