using System.ComponentModel;

namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone: Smartphone
    {
        public Iphone(string numero)
        {
            Numero = numero;
        }

        public Iphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando aplicativo {nomeApp} no celular Iphone");
        }
    }
}