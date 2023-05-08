
namespace StWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"c:\data\File1.txt";
            string targetPath = @"c:\data\File2.txt";

            try
            {
                string[] lines = File.ReadAllLines(sourcePath);
                
                using (StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach (string line in lines)
                    {
                        sw.WriteLine(line.ToUpper());
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