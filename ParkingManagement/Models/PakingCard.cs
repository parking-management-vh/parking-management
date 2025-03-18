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
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public Guid VehicleId { get; set; } 
        public Guid TickerPriceId { get; set; }
        public Guid UserId { get; set; }
        public ParkingCard() { }

        public ParkingCard(Guid id, DateTime startDate, DateTime? endDate, string status, bool isMonth, Guid vehicleId, Guid userId, Guid tickerPriceId, DateTime createdAt = default, DateTime updatedAt = default)
        {
            Id = id;
            StartDate = startDate;
            EndDate = endDate;
            Status = status;
            IsMonth = isMonth;
            TickerPriceId = tickerPriceId;
            VehicleId = vehicleId;
            UserId = userId;
            CreatedAt = createdAt == default ? DateTime.Now : createdAt;
            UpdatedAt = updatedAt == default ? DateTime.Now : updatedAt;
        }
    }
}
