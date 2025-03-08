using ParkingManagement.DAL.Repositories;
using ParkingManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingManagement.BLL
{
    public class vehicleBLL
    {
        private readonly vehicleRepository repository = new vehicleRepository();

        public List<VehicleType> GetAllVehicleType()
        {
            return repository.GetAllVehicleType();
        }
        public List<allVehicle> GetAllVehicle(string areaName = null, string slotNumber = null, string vehicleType = null, string licensePlate = null)
        {
            return repository.GetAllVehicle(areaName, slotNumber, vehicleType, licensePlate);
        }
        public void CreateVehicle(VehicleModel vehicle)
        {
            repository.CreateVehicle(vehicle);
        }

        public void UpdateVehicle(VehicleModel vehicle)
        {
            repository.UpdateVehicle(vehicle);
        }

        public void DeleteVehicle(string id)
        {
            repository.DeleteVehicle(id);
        }

    }
}
