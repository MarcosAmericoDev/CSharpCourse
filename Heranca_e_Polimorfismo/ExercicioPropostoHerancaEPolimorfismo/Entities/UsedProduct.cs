namespace ExercicioPropostoHerancaEPolimorfismo.Entities
{
    internal class UsedProduct : Product
    {
        // Auto properts
        public DateTime ManufactureDate { get; set; }

        //Constructors
        public UsedProduct() { }

        public UsedProduct(string name, double price, DateTime manufactureDate) : base(name, price)
        {
            ManufactureDate = manufactureDate;
        }

        // Methods
        public override string PriceTag()
        {
            return $"{Name} (used) $ {Price} (Manufacture Date: {ManufactureDate.ToString("dd/MM/yyyy")})";
        }
    }
}
