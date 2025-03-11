using System;

namespace ParkingManagement.Models
{
    public class VehicleModel
    {
        public Guid Id { get; set; }
        public string LicensePlate { get; set; }
        public Guid VehicleTypeId { get; set; }
        public Guid ParkingSlotId { get; set; }
        public Guid ParkingAreaId { get; set; }
        public DateTime EntryTime { get; set; }
        public DateTime? ExitTime { get; set; }
        public DateTime SaveTime { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public VehicleModel() { }

        public VehicleModel(Guid id, string licensePlate, Guid vehicleTypeId, Guid parkingSlotId, Guid parkingAreaId,
                            DateTime entryTime, DateTime? exitTime, DateTime saveTime, DateTime createdAt, DateTime updatedAt)
        {
            Id = id;
            LicensePlate = licensePlate;
            VehicleTypeId = vehicleTypeId;
            ParkingSlotId = parkingSlotId;
            ParkingAreaId = parkingAreaId;
            EntryTime = entryTime;
            ExitTime = exitTime;
            SaveTime = saveTime;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
        }
    }
}
