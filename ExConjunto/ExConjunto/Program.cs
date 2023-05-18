using ExConjunto.Entities;
namespace ExConjunto
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> cursoA = new HashSet<int>();
            HashSet<int> cursoB = new HashSet<int>();
            HashSet<int> cursoC = new HashSet<int>();

            Console.Write("How many students for course A? ");
            int Id = int.Parse(Console.ReadLine());

            for (int i = 0; i < Id; i++)
            {
                int Cod = int.Parse(Console.ReadLine());
                cursoA.Add(Cod);
            }

            Console.Write("How many students for course B? ");
             Id = int.Parse(Console.ReadLine());

            for (int i = 0; i < Id; i++)
            {
                int Cod = int.Parse(Console.ReadLine());
                cursoB.Add(Cod);
            }

            Console.Write("How many students for course B? ");
            Id = int.Parse(Console.ReadLine());

            for (int i = 0; i < Id; i++)
            {
                int Cod = int.Parse(Console.ReadLine());
                cursoC.Add(Cod);
            }

            HashSet<int> all = new HashSet<int>(cursoA);
            all.UnionWith(cursoB);
            all.UnionWith(cursoC);

            Console.WriteLine("Total students: " + all.Count);








        }
    }
}
