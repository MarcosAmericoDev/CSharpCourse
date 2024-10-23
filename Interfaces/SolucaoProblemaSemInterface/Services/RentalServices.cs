using SolucaoProblemaSemInterface.Entities;

namespace SolucaoProblemaSemInterface.Services
{
    internal class RentalServices
    {
        public double PricePerHour { get; private set; }
        public double PriceperDay { get; private set; }
        private BrazilTaxService _brazilTaxService = new BrazilTaxService();

        public RentalServices(double pricePerHour, double priceperDay)
        {
            PricePerHour = pricePerHour;
            PriceperDay = priceperDay;
        }

        public void ProcessInvoice(CarRental carRental)
        {
            TimeSpan duration = carRental.Finish.Subtract(carRental.Start);

            double basicPayment = 0.0;

            if(duration.TotalHours <= 12.0)
            {
                basicPayment = PricePerHour * Math.Ceiling(duration.TotalHours);
            }
            else
            {
                basicPayment = PriceperDay * Math.Ceiling(duration.TotalDays);
            }

            double tax = _brazilTaxService.Tax(basicPayment);

            carRental.Invoice = new Invoice(basicPayment, tax);
        }
    }
}
