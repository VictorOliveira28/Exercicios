﻿using System;
using System.Globalization;

namespace Exercicio2 {
    class Program {
        static void Main(string[] args) {
            //ENTRADA DE DADOS EM C# Parte 1

            /*
            string frase = Console.ReadLine();
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();
            string[] v = Console.ReadLine().Split(' ');
            string a2 = v[0];
            string b2 = v[1];
            string c2 = v[3];

            Console.WriteLine("Você digitou: ");
            Console.WriteLine(frase);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(a2);
            Console.WriteLine(b2);
            Console.WriteLine(c2); */

            //ENTRADA DE DADOS EM C# PARTE 2


            /*string frase = Console.ReadLine()!;
            string x = Console.ReadLine()!;
            string y = Console.ReadLine()!;
            string z = Console.ReadLine()!;
            
            string[] v = Console.ReadLine()!.Split(' ');
            string p1 = v[0];
            string p2 = v[1];
            string p3 = v[2];



            Console.WriteLine("Você digitou: ");
            Console.WriteLine(frase);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.WriteLine(p3);
            */
            /*
            int n1 = int.Parse(Console.ReadLine()!);
            char ch = char.Parse(Console.ReadLine()!);
            double n2 = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
            string[] vet = Console.ReadLine()!.Split(' ');
            string nome = vet[0];
            char sexo = char.Parse(vet[1]);
            int idade = int.Parse(vet[2]);
            double altura = double.Parse(vet[3], CultureInfo.InvariantCulture);
            Console.WriteLine("Você digitou: ");
            Console.WriteLine(n1);
            Console.WriteLine(ch);
            Console.WriteLine(n2.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(nome);
            Console.WriteLine(sexo);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));
            */

            Console.WriteLine("Entre com o seu nome completo: ");
            string nomeCompleto = Console.ReadLine()!;
            Console.WriteLine("Quantos quartos tem sua casa? ");
            int qtdQuartos = int.Parse(Console.ReadLine()!);
            Console.WriteLine("Entre com o preço do produto: ");
            double preco = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
            Console.WriteLine("Entre com o seu último nome, idade e altura (Mesma linha): ");
            string[] complemento = Console.ReadLine()!.Split(' ');
            string sobreNome = complemento[0];
            int idade = int.Parse(complemento[1]);
            double altura = double.Parse(complemento[2], CultureInfo.InvariantCulture);

            Console.WriteLine(nomeCompleto);
            Console.WriteLine(qtdQuartos);
            Console.WriteLine(preco.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(sobreNome);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));

















        }
    }
}






