using System.Globalization;
namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite o valor do emprestimo: ");
            double emp = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite a quantidade de parcelas: ");
            int parc = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a taxa de juros em %: ");
            double txJuros = double.Parse(Console.ReadLine());

            double valJuros = emp * (txJuros / 100);
            double valTotal = emp + valJuros;
            double valParcela = valTotal / parc;

            

            Console.WriteLine("O valor das parcelas é: " + valParcela);
            Console.WriteLine("O valor total do emprestimo é: " + valTotal.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("A porcentagem de juros aplicada foi de: " + txJuros + "%");
        }
    }
}