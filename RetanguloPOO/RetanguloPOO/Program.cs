using System;
using System.Globalization;

namespace RetanguloPOO {
    class Program {
        static void Main(string[] args) {

            Retangulo A;
            A = new Retangulo();

            Console.Write("Entre com a largura do retangulo: ");
            A.Widith = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
            Console.Write("Entre com a altura do retangulo: ");
            A.Height = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

            Console.WriteLine("AREA: " + A.Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PERÍMETRO: " + A.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL: " + A.Diagonal().ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}