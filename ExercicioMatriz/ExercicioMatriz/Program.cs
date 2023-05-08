namespace ExercicioMatriz {
    class Program {
         static void Main(string[] args) {

            Console.WriteLine("Digite a quantidade de linhas: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade de colunas: ");
            int m = int.Parse(Console.ReadLine());

            Console.WriteLine();

            int[,] mat = new int[n, m];

            for (int i = 0; i < n; i++) {
                string[] values = Console.ReadLine().Split(' ');

                for (int j = 0; j < m; j++) {
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            Console.Write("Digite um valor que pertence a Matriz: ");

            int x = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++) {

                for(int j = 0; j < m; j++) {

                    if (mat[i, j] == x) {
                        Console.WriteLine("Position: " + i + ", " + j + ": ");
                        if(j > 0) {
                            Console.WriteLine("Left: " + mat[i, j - 1]); 
                        }
                        if(i > 0) {
                            Console.WriteLine("Up: " + mat[i - 1, j]);
                        }
                        if (j < n - 1) {
                            Console.WriteLine("Right: " + mat[i, j + 1]);
                        }
                        if(i < n - 1) {
                            Console.WriteLine("Down: " + mat[i + 1, j]);
                        }
                    }
                }
            }
        }
    }
}

