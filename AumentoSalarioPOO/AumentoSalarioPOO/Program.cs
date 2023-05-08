using System;
using System.Globalization;

namespace AumentoSalarioPOO {
    class Program {
        static void Main(string[] args) {

            Funcionario funcionario;
            
            funcionario = new Funcionario();


            Console.Write("Digite o nome do funcionário: ");
            funcionario.Nome = Console.ReadLine();
            Console.Write("Digite o salário bruto: ");
            funcionario.SalarioBruto = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
            Console.Write("Digite o valor do imposto a ser descontado: ");
            funcionario.Imposto = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
            
            Console.WriteLine();
            Console.WriteLine("Funcionario: " + funcionario);
            Console.WriteLine();
            Console.WriteLine("Deseja aumentar o salario em qual porcentagem? ");
            double porcentagem = double.Parse(Console.ReadLine()!);
            funcionario.AumentarSalario(porcentagem);
            Console.WriteLine();

            Console.WriteLine("Dados atualizados: " + funcionario);



        }
    }
}