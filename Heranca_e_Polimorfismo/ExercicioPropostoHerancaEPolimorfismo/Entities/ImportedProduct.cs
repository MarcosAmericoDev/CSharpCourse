using System.Globalization;

namespace ExercicioPropostoHerancaEPolimorfismo.Entities
{
    internal class ImportedProduct : Product
    {
        // Auto properts
        public double CustomsFee { get; set; }

        // Constructors
        public ImportedProduct() { }

        public ImportedProduct(string name, double price, double customsFee) : base(name, price)
        {
            CustomsFee = customsFee;
        }

        // Methods

        public double TotalPrice()
        {
            return Price + CustomsFee;
        }

        public override string PriceTag()
        {
            return $"{Name} $ {TotalPrice()} (Customs fee: $ {CustomsFee.ToString("F2", CultureInfo.InvariantCulture)})";
        }
    }
}
