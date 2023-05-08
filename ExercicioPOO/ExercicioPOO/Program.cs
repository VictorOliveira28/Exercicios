using System;
using System.Globalization;

namespace ExercicioPOO {
    class Program {
        static void Main(string[] args) {
            Pessoa p1, p2;
            p1 = new Pessoa();
            p2 = new Pessoa();

            Console.WriteLine("Entre com o nome da primeira pessoa: ");
            p1.nome = Console.ReadLine()!;
            Console.WriteLine("Entre com a idade da primeira pessoa: ");
            p1.idade = int.Parse(Console.ReadLine()!);

            Console.WriteLine("Entre com o nome da segunda pessoa: ");
            p2.nome = Console.ReadLine()!;
            Console.WriteLine("Entre com a idade da segunda pessoa: ");
            p2.idade = int.Parse(Console.ReadLine()!);

            if (p1.idade > p2.idade) {
                Console.WriteLine("A pessoa mais velha é: " + p1.nome + " e tem " + p1.idade + " anos");
            }
            else {
                Console.WriteLine("A pessoa mais velha é: " + p2.nome + " e tem " + p2.idade + " anos");
            }

        }
    }
}
