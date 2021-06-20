using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportParkingManager.Models
{
    public class ParkingSlot
    {
        public ParkingSlot(int slotNumber, Sizes size)
        {
            SlotNumber = slotNumber;
            Size = size;
            Leases = new List<Lease>();
        }

        public int SlotNumber { get; set; }
        public Sizes Size { get; set; }

        public bool Available { get => !Leases.Where(lease => lease.Active).Any(); }

        public List<Lease> Leases { get; set; }

        public bool bookParkingSlot(Lease lease)
        {
            Leases.Add(lease);
            return true;
        }
    }
}
