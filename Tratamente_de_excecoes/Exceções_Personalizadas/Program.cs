using Exceções_Personalizadas.Entities;

namespace Exceções_Personalizadas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Room number: ");
            int numberRoom = int.Parse(Console.ReadLine());
            Console.Write("Check-in date (dd/MM/yyyy): ");
            DateTime checkInRoom = DateTime.Parse(Console.ReadLine());
            Console.Write("Check-out date (dd/MM/yyyy): ");
            DateTime checkOutRoom = DateTime.Parse(Console.ReadLine());

            if (checkOutRoom <= checkInRoom)
            {
                Console.WriteLine("Error in reservation: Check-out date must be after check-in date");
            }
            else
            {
                Reservation reservationRoom = new Reservation(numberRoom, checkInRoom, checkOutRoom);
                Console.WriteLine($"Reservation: {reservationRoom}");

                Console.WriteLine();
                Console.WriteLine("Enter data to update the reservation: ");

                Console.Write("Check-in date (dd/MM/yyyy): ");
                checkInRoom = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy): ");
                checkOutRoom = DateTime.Parse(Console.ReadLine());

                DateTime now = DateTime.Now;
                string? error = reservationRoom.UpdateDates(checkInRoom, checkOutRoom);
                if (error != null)
                {
                    Console.WriteLine($"Error in reservation: {error}");
                }
                else
                {
                    Console.WriteLine($"Reservation: {reservationRoom}");
                }
            }
        }
    }
}
