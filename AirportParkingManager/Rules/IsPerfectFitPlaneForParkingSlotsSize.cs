using AirportParkingManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportParkingManager.Rules
{
    public class IsPerfectFitPlaneForParkingSlotsSize : IParkingSlotRule
    {
        private readonly Sizes size;

        public IsPerfectFitPlaneForParkingSlotsSize(Sizes Size)
        {
            size = Size;
        }

        public IEnumerable<ParkingSlot> Execute(IEnumerable<ParkingSlot> slots, ref string message)
        {
            var available = slots.Where(ps => ps.Size.CompareTo(size) == 0);
            if (!available.Any())
            {
                message = $"No available parking slots for {Enum.GetName(typeof(Sizes), size)} models";
            }

            return available;
        }
    }
}
