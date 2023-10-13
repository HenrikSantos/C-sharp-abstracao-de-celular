using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_abstracao_de_celular.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        public string Modelo { get => _modelo; set => _modelo = value; }

        private string _modelo;
        private string IMEI;
        private int Memoria;

        

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }

        public void Ligar(Smartphone smartphoneParaLigar)
        {
            Console.WriteLine($"Ligando para {smartphoneParaLigar.Numero} do modelo {smartphoneParaLigar.Modelo}.");
        }

        public void ReceberLigacao(Smartphone smartphoneParaLigar)
        {
            Console.WriteLine($"Recebendo ligação de {smartphoneParaLigar.Numero} do modelo {smartphoneParaLigar.Modelo}.");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}
