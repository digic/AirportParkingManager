using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportParkingManager.Models
{
    public class ParkingLot
    {
        private readonly int jumboSlots;
        private readonly int jetSlots;
        private readonly int propSlots;
        private readonly int capacity;
        public List<ParkingSlot> ParkingSlots;

        public ParkingLot(int JumboSlots, int JetSlots, int PropSlots)
        {
            jumboSlots = JumboSlots;
            jetSlots = JetSlots;
            propSlots = PropSlots;
            capacity = jumboSlots + jetSlots + propSlots;
            ParkingSlots = new List<ParkingSlot>(capacity);
        }

        public void generateParkingLot()
        {
            int parkingNumber = 0;
            for (int i = 0; i < propSlots; i++)
            {
                ParkingSlots.Add(new ParkingSlot(parkingNumber++, Sizes.Prop));
            }

            for (int i = 0; i < jetSlots; i++)
            {
                ParkingSlots.Add(new ParkingSlot(parkingNumber++, Sizes.Jet));
            }

            for (int i = 0; i < jumboSlots; i++)
            {
                ParkingSlots.Add(new ParkingSlot(parkingNumber++, Sizes.Jumbo));
            }
        }
    }
}
