using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioPOO.Models
{
    //Implementado..!!!
    public class Iphone : Smartphone

    {
        public Iphone(string numero, string modelo, string imei, int memoria): base(numero, modelo, imei, memoria)
        {

        }
        // Implementdo..!!!
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine("Instalando o App: " + nomeApp);
        }
    }
}
