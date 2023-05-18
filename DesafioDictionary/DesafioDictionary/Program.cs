namespace DesafioDictionary
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
                    Dictionary<string, int> keyValuePairs = new Dictionary<string, int>();

                    while (!sr.EndOfStream)
                    {
                        string[] contagemVotos = sr.ReadLine().Split(',');
                        string name = contagemVotos[0];
                        int votos = int.Parse(contagemVotos[1]);

                        if (keyValuePairs.ContainsKey(name))
                        {
                            keyValuePairs[name] += votos;
                        }
                        else
                        {
                            keyValuePairs[name] = votos;
                        }
                    }

                 foreach(var kvp in keyValuePairs)
                    {
                        Console.WriteLine(kvp.Key + ": " + kvp.Value);
                    }
                }
            }
            catch (IOException e)
            {
                
                Console.WriteLine(e.Message);
            }
        }
    }

}