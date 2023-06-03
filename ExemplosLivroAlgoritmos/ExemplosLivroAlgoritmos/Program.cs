using ExemplosLivroAlgoritmos.Entities;
namespace ExemplosLivroAlgoritmos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calcular Fatorial de um Numero:

            Fatorial fatorial = new Fatorial();


            double x = 5;
            double result = fatorial.FatorialCalculate(x);
            Console.WriteLine("O resultado é: " + result);

            // BUSCA BINÁRIA:

            int[] array = { 2, 5, 8, 12, 16, 23, 38, 56, 72, 91 };
            int item = 16;
            int result1 = BuscaBinaria(array, item);

            if (result1 != 1)
            {
                Console.WriteLine("O elemento {0} foi encontrado no indice {1}.", item, result1);
            }
            else
            {
                Console.WriteLine($"O elemento {0} não foi encontrado no array", item, result1);
            }

            //Soma de Array
            int[] list = { 2, 4, 6, 28, 36, 54, -35, 22, 90, 88, 35, 160 };
            int resultado = soma(list, 0);
            int maiorValor = MaxValue(list, 0);
            int menorValor = MinValue(list, 0);
            Console.WriteLine("A soma dos numeros no array é: " +  resultado);
            Console.WriteLine("O maior valor encontrado é: " + maiorValor);
            Console.WriteLine("O maior valor encontrado é: " + menorValor);
            
        }

       
        static int soma(int[] list, int index) 
        {           
            
            if(index >= list.Length)
            {
                return 0;
            }
            return list[index] + soma(list, index + 1);
        }

        static int MinValue(int[] list, int index)
        {
            if(index >= list.Length)
            {
                return int.MaxValue;
            }
            int minValue = MinValue(list, index + 1);

            return Math.Min(list[index], minValue);
        }
        static int MaxValue(int[] list, int index)
        {
            if(index >= list.Length)
            {
                return int.MinValue;
            }

            int maxValue = MaxValue(list, index + 1);

            return Math.Max(list[index], maxValue);
        }

        static int BuscaBinaria(int[] array, int item)
        {
            int baixo = 0;
            int alto = array.Length - 1;

            while (baixo <= alto)
            {
                int meio = (baixo + alto) / 2;
                if (array[meio] == item)
                {
                    return meio;
                }
                if (array[meio] < item)
                {
                    baixo = meio + 1;
                }
                else
                {
                    alto = meio - 1;
                }
            }
            return -1;
        }
    }
}
