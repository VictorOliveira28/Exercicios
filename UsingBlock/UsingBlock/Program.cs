using System.IO;
namespace UsingBlock
{
    class Program
    {
        static void Main(string[] args)
        {
            string Path = @"c:\data\File1.txt";
            try
            {

                using (StreamReader sr = File.OpenText(Path))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
