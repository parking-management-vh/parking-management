using System;

namespace ParkingManagement.Models
{
    public class PaymentReceipt
    {
        public string Id { get; set; }
        public string ParkingCardId { get; set; }
        public string VehicleId { get; set; }
        public string StaffCode { get; set; }
        public DateTime PaymentDate { get; set; }
        public decimal TotalPrice { get; set; }
        public string PaymentMethod { get; set; }
        public string PaymentStatus { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public PaymentReceipt()
        {
            PaymentDate = DateTime.UtcNow;
            CreatedAt = DateTime.UtcNow;
            UpdatedAt = DateTime.UtcNow;
            PaymentStatus = "Chờ duyệt";
        }
    }
}