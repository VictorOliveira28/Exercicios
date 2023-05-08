using System;
using System.Globalization;

namespace Exercicio {
    class Program {
        static void Main(string[] args) {
            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double media = 53.234567;

            Console.WriteLine("Produtos: ");
            Console.WriteLine("{0}, cujo preço é ${1:F2}", produto1, preco1);
            Console.WriteLine("{0}, cujo preço é ${1:F2}", produto2, preco2);
            Console.WriteLine();

            Console.WriteLine("Registo: {0} anos de idade, código: {1} e gênero: {2}", idade, codigo, genero);

            Console.WriteLine("");

            Console.WriteLine("Media com oito casas decimais:{0:F8}", media);
            Console.WriteLine("Arredondado (três casas decimais):{0:F3}", media);
            Console.WriteLine("Separador decimal Invariant Culture: " + media.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine();


            //OPERADORES ARITMÉTICOS 

            int n1 = 3 + 4 * 2;
            int n2 = (3 + 4) * 2;
            int n3 = 17 % 3;
            double n4 = 10.0 / 8.0;

            double a = 1.0, b = -3.0, c = -4.0;

            double delta = Math.Pow(b, 2.0) - 4.0 * a * c;

            double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);

            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(delta);
            Console.WriteLine(x1);
            Console.WriteLine(x2);

            Console.WriteLine();

            //OPERADORES DE ATRIBUIÇÃO
            
                        int a1 = 10;
                        Console.WriteLine(a1);
                        a1 += 2;
                        Console.WriteLine(a1);
                        a1 *= 3;
                        Console.WriteLine(a1);

                        String s = "ABC";
                        Console.WriteLine(s);
                        s += "DEF";
                        Console.WriteLine(s);
            



        }
    }
}