using ExercicioInterface.Entities;
using ExercicioInterface.Services;
using System.Globalization;

namespace ExercicioInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Date(dd/MM/yyyy): ");
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.WriteLine("Contract value: ");
            double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter number of installments: ");
            int numberInstallments = int.Parse(Console.ReadLine());

            Contract MyContracts = new Contract(number, date, value);

            ContractService contractService = new ContractService(new PaylpalService());
            contractService.ProcessContract(MyContracts, numberInstallments);

            Console.WriteLine("Installments:");

            foreach(Installment installment in MyContracts.Installments)
            {
                Console.WriteLine(installment);
            }


        }
    }
}