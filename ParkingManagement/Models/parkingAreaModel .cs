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
        public string Description { get; set; }

        public parkingAreaModel() { }

        public parkingAreaModel(string id, string areaName, string description)
        {
            Id = id;
            AreaName = areaName;
            Description = description;
        }
    }
}

