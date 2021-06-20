using AirportParkingManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportParkingManager.Rules
{
    public class FindParkingSlotbySlotNumber : IParkingSlotRule
    {
        private readonly int slotNumber;
        public FindParkingSlotbySlotNumber(int SlotNumber)
        {
            slotNumber = SlotNumber;

        }

        public IEnumerable<ParkingSlot> Execute(IEnumerable<ParkingSlot> slots, ref string message)
        {
            var slot = inner(slots);
            if (!slot.Any())
            {
                message = $"Could not find Slot {slotNumber}";
            }
            return slot;
        }

        private IEnumerable<ParkingSlot> inner(IEnumerable<ParkingSlot> slots)
        {
            yield return slots.Where(ps => ps.SlotNumber == slotNumber).FirstOrDefault();
        }

    }
}
