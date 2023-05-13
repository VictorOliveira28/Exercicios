
namespace TesteDeLogica
{
    class Program
    {
        static void Main(string[] args)
        {
            int antepenultimo = 5;
            int penultimo = 6;            
            int ultimo = 8;

            for (int i = 4; i <= 50; i++)
            {
                int _50Termo = penultimo + antepenultimo;
                antepenultimo = penultimo;
                penultimo = ultimo;
                ultimo = _50Termo;
            }

            Console.WriteLine(ultimo);

        }
    }
}
