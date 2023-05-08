using System;
using System.Globalization;
using System.Net.Http.Headers;

namespace salarioPOO {
    class Program {
        static void Main(string[] args) {
            Person p1, p2;
            double media;
            p1 = new Person();
            p2 = new Person();

            Console.WriteLine("Digite o nome da primeira pessoa: ");
            p1.nome = Console.ReadLine();
            Console.WriteLine("Digite o salario da primeira pessoa: ");
            p1.salario = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

            Console.WriteLine("Digite o nome da segunda pessoa: ");
            p2.nome = Console.ReadLine();
            Console.WriteLine("Digite o salario da segunda pessoa: ");
            p2.salario = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

            media = (p1.salario + p2.salario) / 2;

            Console.WriteLine("A media dos salarios é: R$ " + media.ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}