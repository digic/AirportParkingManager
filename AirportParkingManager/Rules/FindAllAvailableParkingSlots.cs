using AirportParkingManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportParkingManager.Rules
{
    public class FindAllAvailableParkingSlots : IParkingSlotRule
    {
        public string Execute(IEnumerable<ParkingSlot> parkingSlots, out IEnumerable<ParkingSlot> slots)
        {
            string message = string.Empty;
            slots = parkingSlots.Where(ps => ps.Available);

            if (!slots.Any()) {
                message = "No available Parking Slots.";
            }

            return message; 
        }

        public IEnumerable<ParkingSlot> Execute(IEnumerable<ParkingSlot> slots, ref string message)
        {
            
            var available = slots.Where(ps => ps.Available);

            if (!available.Any())
            {
                message = "No available Parking Slots.";
            }

            return available;
        }
    }
}
