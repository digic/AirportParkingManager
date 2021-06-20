using AirportParkingManager.Models;
using AirportParkingManager.Rules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportParkingManager
{
    public class ParkingManager
    {
        private readonly ParkingLot parkingLot;

        public ParkingManager()
        {
            parkingLot = new ParkingLot(25, 50, 25);
            parkingLot.generateParkingLot();
        }

        public string Status()
        {
            var available = parkingLot.ParkingSlots.Where(ps => ps.Available);
            var jumbos = available.Where(s => s.Size == Sizes.Jumbo).Count();
            var jets = available.Where(s => s.Size == Sizes.Jet).Count();
            var props = available.Where(s => s.Size == Sizes.Prop).Count();

            var status = $"There are {available.Count()} slots, {jumbos} Jumbo slots available, {jets} Jet slots available and {props} Prop slots available";

            return status;

        }

        public IEnumerable<ParkingSlot> recommend(string planeModel) {

            var plane = getPlane("", planeModel);

            var rules = new List<IParkingSlotRule>()
            {
                new FindAllAvailableParkingSlots()
            };

            var parkingSlots = parkingLot.ParkingSlots.AsEnumerable();

            foreach (var rule in rules)
            {
                parkingSlots = rule.Execute(parkingSlots);
              
            }

            return parkingSlots;

        }



        private Plane getPlane(string plate, string planeModel)
        {
            Sizes size;

            switch (planeModel)
            {
                case "E195":

                    size = Sizes.Prop;
                    break;
                case "A330":
                case "B777":

                    size = Sizes.Jet;
                    break;
                case "A380":
                case "B747":

                    size = Sizes.Jumbo;
                    break;
                default:
                    throw new Exception($"Could not determine Plane Size for {planeModel} plane model.");
            }

            return new Plane(plate, planeModel, size);
        }
    }
}
