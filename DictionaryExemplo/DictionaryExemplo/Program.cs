namespace DictionaryExemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> cookies = new Dictionary<string, string>();

            cookies["user"] = "Maria";
            cookies["email"] = "maria@gmail.com";
            cookies["Phone"] = "99712234";
            cookies["Phone"] = "83737388";

            Console.WriteLine(cookies["email"]);
            Console.WriteLine(cookies["Phone"]);

            cookies.Remove("email");

            if (cookies.ContainsKey("email"))
            {
                Console.WriteLine(cookies["email"]);
            }
            else
            {
                Console.WriteLine("There's no 'email' key.");
            }

            Console.WriteLine("Size: " + cookies.Count);
            Console.WriteLine("All cookies");
            foreach(KeyValuePair<string, string> kvp in cookies)
            {
                Console.WriteLine(kvp.Key + ": " + kvp.Value);
            }

        }
    }
}