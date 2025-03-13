using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingManagement.Models
{
    public class paymentModel
    {
        public int Id { get; set; }
        [Browsable(false)]
        public Guid? ParkingCardId { get; set; }
        public DateTime PaymentDate { get; set; }
        public decimal TotalPrice { get; set; }
        public string PaymentMethod { get; set; }
        public int TotalTime { get; set; }
        [Browsable(false)]
        public Guid VehicleId { get; set; }
        public string StaffCode { get; set; }
        public string InvoiceCode { get; set; }
        [Browsable(false)]
        public DateTime CreatedAt { get; set; }
        [Browsable(false)]
        public DateTime UpdatedAt { get; set; }
        public string LicensePlate { get; set; } 

        public paymentModel() { }

        public paymentModel(int id, Guid? parkingCardId, DateTime paymentDate, decimal totalPrice, string paymentMethod, int totalTime, Guid vehicleId, string staffCode, string invoiceCode, DateTime createdAt, DateTime updatedAt)
        {
            Id = id;
            ParkingCardId = parkingCardId;
            PaymentDate = paymentDate;
            TotalPrice = totalPrice;
            PaymentMethod = paymentMethod;
            TotalTime = totalTime;
            VehicleId = vehicleId;
            StaffCode = staffCode;
            InvoiceCode = invoiceCode;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
        }
    }
}
