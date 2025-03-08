using ParkingManagement.DAL.Repositories;
using ParkingManagement.Models;
using System;
using System.Collections.Generic;

namespace ParkingManagement.BLL
{
    internal class parkingSlotBLL
    {
        private readonly parkingSlotRepository repository = new parkingSlotRepository();

        public List<allParkingSlot> GetAllParkingSlots(string areaName = null, string status = null, string slotType = null)
        {
            return repository.GetAllParkingSlots(areaName, status, slotType);
        }

        public void InsertParkingSlot(ParkingSlotModel parkingSlot)
        {
            repository.InsertParkingSlot(parkingSlot);
        }

        public void DeleteParkingSlot(string id)
        {
            repository.DeleteParkingSlot(id);
        }

        public void UpdateParkingSlot(ParkingSlotModel slot)
        {
            repository.UpdateParkingSlot(slot);
        }

        public List<ParkingSlotModel> GetSlotByArea(Guid areaId)
        {
            return repository.GetSlotByArea(areaId);
        }
    }
}
