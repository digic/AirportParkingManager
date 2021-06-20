using System;
using System.Linq;
using AirportParkingManager.Models;

namespace AirportParkingManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var manager = new ParkingManager();
            Console.WriteLine(manager.Status());
            Console.ReadLine();

            BookClosesPerfectFit(manager, "EHG897872", "E195", DateTime.Now, DateTime.Now.AddDays(2));
            BookClosesPerfectFit(manager, "EHG834352", "E195", DateTime.Now, DateTime.Now.AddDays(2));
            BookClosesPerfectFit(manager, "EHG000352", "E195", DateTime.Now, DateTime.Now.AddDays(2));
            BookClosesPerfectFit(manager, "EHG999354", "A330", DateTime.Now, DateTime.Now.AddDays(2));

            Console.WriteLine(manager.Status());
            Console.ReadLine();


            BookClosestAnyFit(manager, "EHGA38054", "A380", DateTime.Now, DateTime.Now.AddDays(2));
            BookClosestAnyFit(manager, "B74738054", "B747", DateTime.Now, DateTime.Now.AddDays(2));
            BookClosestAnyFit(manager, "E19548054", "E195", DateTime.Now, DateTime.Now.AddDays(2));
            BookClosestAnyFit(manager, "B77780546", "B777", DateTime.Now, DateTime.Now.AddDays(2));


            Console.WriteLine(manager.Status());
            Console.ReadLine();
         
        }




        private static void BookClosesPerfectFit(ParkingManager manager, string plate, string model, DateTime starts, DateTime ends)
        {
            var slot = manager.RecommendClosestPerfectFit(plate, model, starts, ends);
            if (slot != null)
            {
                var booked = manager.BookParkingSlot(slot.SlotNumber, plate, model, starts, ends);
                if (booked)
                {
                    Console.WriteLine($"Plane {plate}:{model} has been booked in {slot.SlotNumber}.");
                }
            }

        }


        private static void BookClosestAnyFit(ParkingManager manager, string plate, string model, DateTime starts, DateTime ends)
        {
            var slots = manager.RecommendBestFitSize(plate, model, starts, ends);
            if (slots.Any())
            {
                var slot = slots.First();
                var booked = manager.BookParkingSlot(slot.SlotNumber, plate, model, starts, ends);
                if (booked)
                {
                    Console.WriteLine($"Plane {plate}:{model} has been booked in {slot.SlotNumber}.");
                }
            }

        }
    }
}
