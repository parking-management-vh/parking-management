using System;

namespace ParkingManagement.Models
{
    public class allParkingCard
    {
        public Guid Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Status { get; set; }
        public bool IsMonth { get; set; }
        public decimal Price { get; set; }
        public string VehicleLicensePlate { get; set; }
        public string UserCode { get; set; }

        public allParkingCard() { }

        public allParkingCard(Guid id, DateTime startDate, DateTime? endDate, string status, bool isMonth, decimal price, string vehicleLicensePlate, string userCode)
        {
            Id = id;
            StartDate = startDate;
            EndDate = endDate;
            Status = status;
            IsMonth = isMonth;
            Price = price;
            VehicleLicensePlate = vehicleLicensePlate; 
            UserCode = userCode;
        }
    }
}
