using System.IO;
namespace TrabAquivos
{
    class Program
    {
        static void Main(string[] args)
        {
            string Path = @"c:\data\File1.txt";
            FileStream fs = null;
            StreamReader sr = null;
            try
            {
                sr = File.OpenText(Path);
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }
                
            }
            catch(IOException e)
            {
                Console.WriteLine("An error occurred!");
                Console.WriteLine(e.Message);

            }
            finally
            {
                if (sr != null) sr.Close();               
                
            }
           
        }
    }
}