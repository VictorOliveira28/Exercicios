using AulaComparison.Services;
namespace AulaComparison
{
    delegate double BinaryNumericOperation(double n1, double n2);
    

    class Program
    {
        public static int globalValue = 3;
        static void Main(string[] args)
        {
            /*int[] vect = new int[] { 3, 4, 5 };
            ChangeOddValues(vect);
            Console.WriteLine(string.Join(" ", vect));
        }
        public static void ChangeOddValues(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 != 0)
                {
                    numbers[i] += globalValue;
                }
            }*/

            //DELEGATE

            double a = 10;
            double b = 12;

            BinaryNumericOperation op = CalculationService.Max;

            double result = op(a, b);
            Console.WriteLine(result);
        }
    }
}