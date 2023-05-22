using System.Linq;
namespace IntroLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            //Specify data source
            int[] numbers = new int[] { 2, 3, 4, 5 };

            //Define the query expression

            var result = numbers.Where(x => x % 2 == 0).Select(x => x * 10);


            //Execute the Query
            foreach(int x in result)
            {
                Console.WriteLine(x);
            }
        }
    }
}