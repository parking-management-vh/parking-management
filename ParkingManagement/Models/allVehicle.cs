using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingManagement.Models
{
    public class allVehicle
    {
        public Guid Id { get; set; }
        public string LicensePlate { get; set; }
        public string VehicleType { get; set; }
        public string ParkingSlot { get; set; }
        public string ParkingArea { get; set; }
        public DateTime EntryTime { get; set; }
        public DateTime? ExitTime { get; set; }
        public string Status { get; set; }

        public allVehicle() { }

        public allVehicle(Guid id, string licensePlate, string vehicleType, string parkingSlot, string parkingArea,
                            DateTime entryTime, DateTime? exitTime, string status)
        {
            Id = id;
            LicensePlate = licensePlate;
            VehicleType = vehicleType;
            ParkingSlot = parkingSlot;
            ParkingArea = parkingArea;
            EntryTime = entryTime;
            ExitTime = exitTime;
            Status = status;
        }
    }
}
