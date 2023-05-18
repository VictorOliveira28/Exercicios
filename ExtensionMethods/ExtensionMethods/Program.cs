using ExtensionMethods.Extensions;
using System.Threading.Channels;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "Bom dia queridos estudantes!";
            Console.WriteLine(s1.Cut(7));
        }
    }
}