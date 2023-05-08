using System;
using System.Globalization;
namespace ConversorMoedaPOO {
    class Program {
        static void Main(string[] args) {


            Console.Write("Qual é a cotação do dolar atual? ");
            double dolarHoje = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
            Console.Write("Quantos dólares você vai comprar? ");
            double qtdDolar = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

            double result = ConversorDeMoeda.DolarHoje(dolarHoje, qtdDolar);

            Console.WriteLine("Valor a ser pago em reais: R$ " + result.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}