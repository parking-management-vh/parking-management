using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingManagement.Models
{
    public class parkingCardDetail
    {
        public Guid Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Status { get; set; }
        public bool IsMonth { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string LicensePlate { get; set; } 
        public string UserCode { get; set; }  
        public decimal Price { get; set; }  

        public parkingCardDetail() { }

        public parkingCardDetail(Guid id, DateTime startDate, DateTime? endDate, string status, bool isMonth, string licensePlate, string userCode, decimal price, DateTime createdAt, DateTime updatedAt)
        {
            Id = id;
            StartDate = startDate;
            EndDate = endDate;
            Status = status;
            IsMonth = isMonth;
            LicensePlate = licensePlate;
            UserCode = userCode;
            Price = price;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
        }
    }
}
