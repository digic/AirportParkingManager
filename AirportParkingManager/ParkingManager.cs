using AirportParkingManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportParkingManager
{
    public class ParkingManager
    {
        private readonly ParkingLot parkingLot;

        public ParkingManager()
        {
            parkingLot = new ParkingLot(25, 50, 25);
            parkingLot.generateParkingLot();
        }

        public string Status()
        {
            var available = parkingLot.ParkingSlots.Where(ps => ps.Available);
            var jumbos = available.Where(s => s.Size == Sizes.Jumbo).Count();
            var jets = available.Where(s => s.Size == Sizes.Jet).Count();
            var props = available.Where(s => s.Size == Sizes.Prop).Count();

            var status = $"There are {available.Count()} slots, {jumbos} Jumbo slots available, {jets} Jet slots available and {props} Prop slots available";

            return status;

        }
    }
}
