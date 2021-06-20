using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportParkingManager.Models
{
    public class Plane
    {
        public Plane(string plate, string model, Sizes size)
        {
            Plate = plate;
            Model = model;
            Size = size;
        }

        public string Plate { get; private set; }
        public string Model { get; private set; }
        public Sizes Size { get; private set; }
        string Airline { get; set; }
    }
}
