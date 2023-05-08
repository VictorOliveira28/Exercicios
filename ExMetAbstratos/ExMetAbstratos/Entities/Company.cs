
namespace ExMetAbstratos.Entities
{
    internal class Company : TaxPayer
    {
        public int NumberOfEmployees { get; set; }
        public Company()
        {
        }

        public Company(string name, double anualInCome, int numberOfEmployees) : base(name, anualInCome)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public override double Tax()
        {
            if (NumberOfEmployees > 10)
            {
                return AnualInCome * 0.14;
            }
            else
            {
                return AnualInCome * 0.16;
            }
        }

    }
}
