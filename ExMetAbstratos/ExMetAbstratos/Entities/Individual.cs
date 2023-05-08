

namespace ExMetAbstratos.Entities
{
    internal class Individual : TaxPayer
    {
        public double HealthExpenditures { get; set; }

        public Individual()
        {
        }

        public Individual(string name, double anualIncome, double healthExpenditures) : base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Tax()
        {
            if (AnualInCome < 20000.0)
            {
                return AnualInCome * 0.15 - HealthExpenditures * 0.5;
            }
            else
            {
                return (AnualInCome * 0.25 - HealthExpenditures * 0.5);
            }
        }
    }
}
