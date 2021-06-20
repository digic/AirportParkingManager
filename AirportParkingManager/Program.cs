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

            var parkingLot = new ParkingLot(25, 50, 25);
            parkingLot.generateParkingLot();



            Console.WriteLine($"Parking Lot has {parkingLot.ParkingSlots.Count()} Slots");
            Console.ReadLine();
        }
    }
}
