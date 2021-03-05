using System;
using ExHotel.Entities;
using ExHotel.Entities.Exceptions;

namespace ExHotel
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Room Namber: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Check-in date (dd/MM/yyyy): ");
                DateTime checkIn = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Check-Out date (dd/MM/yyyy):");
                DateTime checkOut = DateTime.Parse(Console.ReadLine());


                Reservation reservation = new Reservation(number, checkIn, checkOut);
                Console.WriteLine("Reservation: " + reservation);

                Console.WriteLine("Enter date to update the Reservation");
                Console.Write("Check-in date (dd/MM/yyyy): ");
                checkIn = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Check-Out date (dd/MM/yyyy):");
                checkOut = DateTime.Parse(Console.ReadLine());

                reservation.UpdateDates(checkIn, checkOut);
                Console.WriteLine("Reservation: " + reservation);

                Console.ReadKey();
            }
            catch (DomainException e)
            {
                Console.WriteLine("Erro in reservation: " + e.Message);
               
            }
            catch (Exception e) // Exception é uma exceção genérica, qualquer estouro ele vai pegar.
            {
                Console.WriteLine("Erro Inesperado: " + e.Message);
            }
           
            // Comentário teste para verificar versão no Github


        }
    }
}
