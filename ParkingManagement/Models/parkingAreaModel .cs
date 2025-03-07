using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingManagement.Models
{
    public class parkingAreaModel
    {
        public string Id { get; set; }
        public string AreaName { get; set; }
        public string Status { get; set; }
        public string Description { get; set; }
        //public DateTime CreatedAt { get; set; }
        //public DateTime UpdatedAt { get; set; }

        public parkingAreaModel() { }

        public parkingAreaModel(string id, string status, string areaName, string description, DateTime createdAt = default, DateTime updatedAt = default)
        {
            Id = id;
            Status = status;
            AreaName = areaName;
            Description = description;
            //CreatedAt = createdAt;
            //UpdatedAt = updatedAt;
        }
    }
}

