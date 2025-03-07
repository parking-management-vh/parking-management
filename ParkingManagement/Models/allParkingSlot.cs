using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingManagement.Models
{
    internal class allParkingSlot
    {
        public Guid Id { get; set; }
        public int SlotNumber { get; set; }
        public string SlotType { get; set; }
        public string SlotStatus { get; set; }
        public string AreaName { get; set; }

        public allParkingSlot() { }

        public allParkingSlot(Guid id, int slotNumber, string slotType, string slotStatus, string areaName)
        {
            Id = id;
            SlotNumber = slotNumber;
            SlotType = slotType;
            SlotStatus = slotStatus;
            AreaName = areaName;
        }
    }
}
