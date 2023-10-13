using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_abstracao_de_celular.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class IPhone: Smartphone
    {
        public IPhone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria) {}

        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando app {nomeApp} no IPhone");
        }
    }
}
