using AirportParkingManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportParkingManager.Rules
{
    public class IsParkingSlotAvailableForDates : IParkingSlotRule
    {
        private readonly DateTime starts;
        private readonly DateTime ends;
        
        public IsParkingSlotAvailableForDates(DateTime Starts, DateTime Ends)
        {
            starts = Starts;
            ends = Ends;
        }

        public IEnumerable<ParkingSlot> Execute(IEnumerable<ParkingSlot> slots, ref string message)
        {
            var available = slots.Where(ps => !ps.Leases.Any(lease => lease.LeaseStart > ends && starts < lease.LeaseEnd));
            if (!available.Any())
            {
                message = $"No available Parking Slots between {starts} and {ends}";
            }

            return available;
        }

    }
}
