using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PragueParking2._0
{
    public class ParkingSpot
    {
        private int size;
        private Vehicle[] parkedVehicles;
        private DateTime[] parkedDateTimes;

        public ParkingSpot()
        {
            //change from hard-coded values to values from config file
            size = 4;
            parkedVehicles = new Vehicle[2];
            parkedDateTimes = new DateTime[2];
        }
        public void AddVehicle(Vehicle vehicle)
        {
            size = 4;
            if (vehicle.Size <= size)
            {
                parkedVehicles[Array.IndexOf(parkedVehicles, null)] = vehicle;
                parkedDateTimes[Array.IndexOf(parkedDateTimes, DateTime.MinValue)] = DateTime.Now;
            }
        }

        public void RemoveVehicle(Vehicle vehicle)
        {
            int i = Array.IndexOf(parkedVehicles, vehicle);
            parkedVehicles[i] = null;
            parkedDateTimes[i] = DateTime.MinValue;
        }
    }
}
