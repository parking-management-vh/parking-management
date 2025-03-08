using System;

namespace ParkingManagement.Models
{
    public class ParkingCard
    {
        public Guid Id { get; set; } 
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Status { get; set; } 
        public bool IsMonth { get; set; } 
        public decimal Price { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string VehicleId { get; set; } 
        public string UserId { get; set; } 

        public ParkingCard() { }

        public ParkingCard(Guid id, DateTime startDate, DateTime? endDate, string status, bool isMonth, decimal price, string vehicleId, string userId, DateTime createdAt = default, DateTime updatedAt = default)
        {
            Id = id;
            StartDate = startDate;
            EndDate = endDate;
            Status = status;
            IsMonth = isMonth;
            Price = price;
            VehicleId = vehicleId;
            UserId = userId;
            CreatedAt = createdAt == default ? DateTime.Now : createdAt;
            UpdatedAt = updatedAt == default ? DateTime.Now : updatedAt;
        }
    }
}
