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
        public IEnumerable<ParkingSlot> Execute(IEnumerable<ParkingSlot> slots)
        {
            var available = slots.Where(ps => ps.Available);
            return available;
        }
    }
}
