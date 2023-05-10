using ComparareTo.Entities;

namespace ComparareTo
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\data\in.txt";

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    List<Funcionario> list = new List<Funcionario>();
                    while (!sr.EndOfStream)
                    {
                        list.Add(new Funcionario(sr.ReadLine()));
                    }
                    list.Sort();
                    foreach(Funcionario emp in list)
                    {
                        Console.WriteLine(emp);
                    }
                }
            }
            catch(IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}