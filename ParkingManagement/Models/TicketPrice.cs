using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingManagement.Models
{
    public class TicketPrice
    {
        public string Id { get; set; }
        public string VehicleTypeId { get; set; }
        public decimal Price { get; set; }
        public bool IsMonth { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
