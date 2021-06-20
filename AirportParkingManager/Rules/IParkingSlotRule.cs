using AirportParkingManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportParkingManager.Rules
{
    public interface IParkingSlotRule
    {
        IEnumerable<ParkingSlot> Execute(IEnumerable<ParkingSlot> slots);
    }
}
