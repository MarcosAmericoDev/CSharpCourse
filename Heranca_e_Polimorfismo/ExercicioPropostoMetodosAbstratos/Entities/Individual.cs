namespace ExercicioPropostoMetodosAbstratos.Entities
{
    internal class Individual : TaxPayer
    {
        public double HealthExpenditures { get; set; }

        public Individual(string name, double annualIncome, double healthExpenditures) : base(name, annualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double CalculatTax()
        {
            double taxPercentage;

            if (AnnualIncome < 20000.00)
            {
                taxPercentage = 0.15;
            }
            else
            {
                taxPercentage = 0.25;
            }

            return (AnnualIncome * taxPercentage) - (HealthExpenditures * 0.5);
        }
    }
}
