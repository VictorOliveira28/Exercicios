using System;
using System.Globalization;
namespace CircunferenciaMembroEstatico {
    class Program {
        static double Pi = 3.14;
        static void Main(string[] args) {
            Console.WriteLine("Digite o valor do Raio: ");
            double raio = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

            double circ = Circunferencia(raio);
            double vol = Volume(raio);

            Console.WriteLine("Raio: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + vol.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de Pi: " + Pi.ToString("F2", CultureInfo.InvariantCulture));

        }

        static double Circunferencia(double r) {
            return 2.0 * Pi * r;
        }

        static double Volume(double r) {
            return 4.0 / 3.0 * Pi * Math.Pow(r, 3);
        }
    }
}