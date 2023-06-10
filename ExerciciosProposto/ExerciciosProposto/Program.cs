/*Console.WriteLine("Informe os 5 numeros: ");
string[] numString = Console.ReadLine().Split(' ');
int[] vet = new int[numString.Length];
for(int i = 0; i< numString.Length; i++)
{
    vet[i] = int.Parse(numString[i]);
}
foreach(int n in vet)
{
    Console.Write(" " + n);
}*/



// QUICKSORT

namespace ExercicioProposto
{
    class Program
    {
        public static void Main(string[] args)
        {

            int[] numeros = { 12, 33, 28, 17, 51, 75, 83, 96, 111, 12, 2, 3, 15, 27, 31, 28 };
            Console.WriteLine("Ordenação com QuickSort");
            Console.WriteLine("Array original: ");

            foreach (int n in numeros)
            {
                Console.Write($" {n}");               

            }
            Console.WriteLine();

            QuickSort(numeros);
           

            Console.WriteLine("Array ordenado");
            foreach (int n in numeros)
            {
                Console.Write($" {n}");
            }
        }

        static void QuickSort(int[] v)
        {
            QuickSort(v, 0, v.Length - 1);
        }

        public static void QuickSort(int[] v, int start_pos, int end_pos)
        {
            if (start_pos >= end_pos)
                return;

            int pivot = v[start_pos];
            int l = start_pos + 1;
            int r = end_pos;

            while (l <= r)
            {
                while (l <= r && v[l] < pivot) l++;
                while (l <= r && v[r] >= pivot) r--;

                if (l <= r)
                {
                    (v[l], v[r]) = (v[r], v[l]);
                    l++;
                    r--;
                }
            }
            // Coloca o pivô em sua posição correta
            (v[start_pos], v[r]) = (v[r], v[start_pos]);
            // Chama recursivamente para as partições esquerda e direita
            QuickSort(v, start_pos, r - 1);
            QuickSort(v, r + 1, end_pos);
        }
    }
}



