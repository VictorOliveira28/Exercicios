namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int primeiro = 0;
            int segundo = 1;

            Console.Write(primeiro + " " + segundo);
            for (int i = 3; i <= 15; i++)
            {

                int terceiro = primeiro + segundo;
                primeiro = segundo;
                segundo = terceiro;

                Console.Write(" " + segundo);
            }

            


        }
    }
}

