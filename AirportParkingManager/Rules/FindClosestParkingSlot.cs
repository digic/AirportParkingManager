using AirportParkingManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportParkingManager.Rules
{
    public class FindClosestParkingSlot : IParkingSlotRule
    {
        public IEnumerable<ParkingSlot> Execute(IEnumerable<ParkingSlot> slots, ref string message)
        {
            return inner(slots);
        }

        private IEnumerable<ParkingSlot> inner(IEnumerable<ParkingSlot> slots)
        {
            yield return slots.OrderBy(ps => ps.SlotNumber).FirstOrDefault();
        }
    }
}
