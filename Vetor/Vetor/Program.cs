using System;
using System.Globalization;

namespace Vetor {
    class Program {
        static void Main(string[] args) {

            Cadastro[] vect = new Cadastro[10];

            Console.Write("Quantos quartos serão alugados? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i<= n; i++) {
                Console.WriteLine($"Aluguel: #{i}:");
                Console.WriteLine("Nome do Aluno: ");
                string nome = Console.ReadLine();                
                Console.WriteLine("Email do Aluno: ");
                string email = Console.ReadLine();
                Console.WriteLine("Qual quarto gostaria de alugar? ");
                int quarto = int.Parse(Console.ReadLine());
                vect[quarto] = new Cadastro(nome, email);
                
            }

            Console.WriteLine("Quartos ocupados: ");
            
            for(int i = 0; i < 10; i++) {
                if (vect[i] != null) {
                    Console.WriteLine(i + ": " + vect[i]);
                }
            }            
        }
    }
}