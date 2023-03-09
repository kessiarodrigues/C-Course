// See https://aka.ms/new-console-template for more information
using aula21.Entities;
using aula21.Entities.Exceptions;

namespace aula21{
    class Program{
        static void Main(string[] args){

            try {
            Console.Write("Room number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Check-in date: ");
            DateTime checkIn = DateTime.Parse(Console.ReadLine());
            Console.Write("Check-out date: ");
            DateTime checkOut = DateTime.Parse(Console.ReadLine());

            Reservation reservation = new Reservation(number, checkIn, checkOut); 
            Console.WriteLine("Reservation: " + reservation);

            Console.WriteLine();
            Console.WriteLine("CheckIn date: ");
            checkIn = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("CheckOut date: ");
            checkOut = DateTime.Parse(Console.ReadLine());

            reservation.UpdateDates(checkIn, checkOut);
            Console.WriteLine("Reservation: " + reservation);
            }
            catch (DomainException e)
            {
                System.Console.WriteLine("Error in reservation: " + e.Message);
            }
            catch(FormatException e)
            {
                Console.WriteLine("Format error: " + e.Message);
            }

        }
    }
}
