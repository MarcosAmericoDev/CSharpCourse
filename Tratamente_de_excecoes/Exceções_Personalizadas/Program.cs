using Exceções_Personalizadas.Entities;
using Exceções_Personalizadas.Entities.Exceptions;

namespace Exceções_Personalizadas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Room number: ");
                int numberRoom = int.Parse(Console.ReadLine());
                Console.Write("Check-in date (dd/MM/yyyy): ");
                DateTime checkInRoom = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy): ");
                DateTime checkOutRoom = DateTime.Parse(Console.ReadLine());


                Reservation reservationRoom = new Reservation(numberRoom, checkInRoom, checkOutRoom);
                Console.WriteLine($"Reservation: {reservationRoom}");

                Console.WriteLine();
                Console.WriteLine("Enter data to update the reservation: ");

                Console.Write("Check-in date (dd/MM/yyyy): ");
                checkInRoom = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy): ");
                checkOutRoom = DateTime.Parse(Console.ReadLine());

                reservationRoom.UpdateDates(checkInRoom, checkOutRoom);
                Console.WriteLine($"Reservation: {reservationRoom}");
            }
            catch (DomainException error)
            {
                Console.WriteLine($"Error in reservation: {error.Message}");
            }
            catch (FormatException error)
            {
                Console.WriteLine($"Format error: {error.Message}");
            }
            catch (Exception error)
            {
                Console.WriteLine($"Unexpected error: {error.Message}");
            }
        }
    }
}
