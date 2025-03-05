using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingManagement.Models
{
    public class VehicleType
    {
        public string Id { get; set; } // CHAR(36) - UUID
        public string VehicleTypeName { get; set; } // ENUM
        public string Description { get; set; } // TEXT
        public DateTime CreatedAt { get; set; } // TIMESTAMP DEFAULT CURRENT_TIMESTAMP
        public DateTime UpdatedAt { get; set; } // TIMESTAMP DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP
    }
}
