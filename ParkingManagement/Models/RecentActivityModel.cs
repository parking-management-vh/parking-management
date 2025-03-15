using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingManagement.Models
{
    public class RecentActivityModel
    {
        public string Type { get; set; } // Loại hoạt động (Vehicle Entry, Payment, Overdue)
        public string LicensePlate { get; set; } // Biển số xe
        public string Details { get; set; } // Chi tiết (Thời gian, Trạng thái)
        public DateTime DateTime { get; set; } // Thời gian xảy ra
    }
}
