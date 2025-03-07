using System;

namespace ParkingManagement.Models
{
    internal class ParkingSlotModel
    {
        public Guid Id { get; set; }
        public int SlotNumber { get; set; }
        public string SlotType { get; set; }
        public string SlotStatus { get; set; }
        public Guid ParkingAreaId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public ParkingSlotModel() { }

        public ParkingSlotModel(Guid id, int slotNumber, string slotType, string slotStatus, Guid parkingAreaId, DateTime createdAt = default, DateTime updatedAt = default)
        {
            Id = id;
            SlotNumber = slotNumber;
            SlotType = slotType;
            SlotStatus = slotStatus;
            ParkingAreaId = parkingAreaId;
            CreatedAt = createdAt == default ? DateTime.UtcNow : createdAt;
            UpdatedAt = updatedAt == default ? DateTime.UtcNow : updatedAt;
        }
    }
}
