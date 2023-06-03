namespace ExemplosLivroAlgoritmos.Entities
{
    internal class Fatorial
    {

        public double FatorialCalculate(double x)
        {
            if (x == 1)
            {
                return 1;
            }
            return x * FatorialCalculate(x - 1);

        }
    }
}
