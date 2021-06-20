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

            var slots = manager.recommend("E195");
            Console.WriteLine(slots.Count());
            Console.ReadLine();
        }
    }
}
