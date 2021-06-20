using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportParkingManager.Models
{
    public class Lease
    {
        public Lease(Plane plane, DateTime leaseStart, DateTime leaseEnd)
        {
            Plane = plane;
            LeaseStart = leaseStart;
            LeaseEnd = leaseEnd;
        }

        public Plane Plane { get; set; }
        public DateTime LeaseStart { get; set; }
        public DateTime LeaseEnd { get; set; }
        public bool Active
        {
            get
            {
                var now = DateTime.Now;
                return LeaseStart < now && LeaseEnd > now;
            }
        }
    }
}
