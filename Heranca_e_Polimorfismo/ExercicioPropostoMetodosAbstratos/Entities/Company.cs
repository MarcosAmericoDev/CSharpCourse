namespace ExercicioPropostoMetodosAbstratos.Entities
{
    internal class Company : TaxPayer
    {
        public int NumberOfEmployees { get; set; }

        public Company(string name, double annualIncome, int numberOfEmployees) : base(name, annualIncome)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public override double CalculatTax()
        {
            double taxPercentage;

            if(NumberOfEmployees <= 10)
            {
                taxPercentage = 0.16;
            }
            else
            {
                taxPercentage = 0.14;
            }

            return AnnualIncome * taxPercentage;
        }
    }
}
