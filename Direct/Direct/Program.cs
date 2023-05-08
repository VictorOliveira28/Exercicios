
namespace Direct
{
    class Program
    {
        static void Main(string[] args)
        {
            string Path = @"c:\data\myfolder";

            try
            {
                IEnumerable<string> folders = Directory.EnumerateDirectories(Path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FOLDERS:");
                foreach (string s in folders) 
                {
                    Console.WriteLine(s);
                }
                var files = Directory.EnumerateFiles(Path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FILES:");
                foreach (string s in files)
                {
                    Console.WriteLine(s);
                }

                Directory.CreateDirectory(Path + @"\newfolder");
            }
            catch(IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
