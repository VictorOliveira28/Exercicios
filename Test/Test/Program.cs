

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite o valor do emprestimo: ");
            double emp = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade de parcelas: ");
            int parc = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a taxa de juros em %: ");
            double txJuros = double.Parse(Console.ReadLine());

            txJuros = emp * txJuros;

            double valParcela = emp/parc + txJuros;

            Console.WriteLine("O valor das parcelas é: " + valParcela);
        }
    }
}

