namespace Exceções_Personalizadas.Entities
{
    internal class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime Checkin { get; set; }
        public DateTime Checkout { get; set; }

        public Reservation() { }

        public Reservation(int roomNumber, DateTime checkin, DateTime checkout)
        {
            RoomNumber = roomNumber;
            Checkin = checkin;
            Checkout = checkout;
        }

        public int Duration()
        {
            TimeSpan duration = Checkout.Subtract(Checkin);
            return (int)duration.TotalDays;
        }

<<<<<<< HEAD
        public string? UpdateDates(DateTime checkIn, DateTime checkOut)
        {
            DateTime now = DateTime.Now;
            if (checkIn < now || checkOut < now)
            {
                return "Reservation dates for update must be future dates";
            }
            if (checkOut <= checkIn)
            {
                return "Check-out date must be after check-in date";
            }

            Checkin = checkIn;
            Checkout = checkOut;
            return null;
=======
        public void UpdateDates(DateTime checkin, DateTime checkout)
        {
            Checkin = checkin;
            Checkout = checkout;
>>>>>>> e4f8ca0bd8873afc09ed181eaae0ed71bbdc855e
        }

        public override string ToString()
        {
            return $"Room: {RoomNumber}, check-in: {Checkin:dd/MM/yyyy}, check-out: " +
                $"{Checkout:dd/MM/yyyy}, {Duration()} nights";
        }
    }
}
