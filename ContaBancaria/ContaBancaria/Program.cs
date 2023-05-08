
using System.Globalization;

namespace ContaBancaria {
    class Program {

        static void Main(string[] args) {

            AddConta conta;

            Console.Write("Entre com o número da conta: ");
            int numero = int.Parse(Console.ReadLine()!);
            Console.Write("Entre com o titular da conta: ");
            string nome = Console.ReadLine()!;
            Console.Write("Haverá depósito inicial (S/N)? ");
            char resp = char.Parse(Console.ReadLine()!);
            if (resp == 's' || resp == 'S') {
                Console.Write("Entre com o valor do depósito inicial: ");
                double DepositoInicial = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
                conta = new AddConta(numero, nome, DepositoInicial);
            }
            else {
                conta = new AddConta(numero, nome);
            }

            Console.WriteLine();
            Console.Write("Dados da conta: ");
            Console.Write(conta);
            Console.WriteLine();

            Console.Write("Entre com um valor para depósito: ");
            double deposito = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
            conta.ValorDeposito(deposito);
            Console.WriteLine();
            Console.Write("Dados da conta atualizados: ");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Entre com um valor para saque: ");
            double saque = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
            conta.Saque(saque);
            Console.Write("Dados da conta atualizados: ");
            Console.WriteLine(conta);

        }
    }
}