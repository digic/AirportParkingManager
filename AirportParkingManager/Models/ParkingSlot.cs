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
        }

        public int SlotNumber { get; set; }
        public Sizes Size { get; set; }
    }
}
