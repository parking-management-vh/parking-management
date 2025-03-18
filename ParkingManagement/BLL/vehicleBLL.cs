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
        private readonly inOutVehicleRepository inOutVehicleRepository = new inOutVehicleRepository();

        public List<VehicleType> GetAllVehicleType()
        {
            return repository.GetAllVehicleType();
        }
        public List<allVehicle> GetAllVehicle(string areaName = null, string slotNumber = null, string vehicleType = null, string licensePlate = null, string status = null)
        {
            return repository.GetAllVehicle(areaName, slotNumber, vehicleType, licensePlate, status);
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

        public Guid? GetVehicleIdByLicensePlate(string licensePlate)
        {
            return repository.GetVehicleIdByLicensePlate(licensePlate);
        }

        public bool UpdateVehicleStatusByLicensePlate(string licensePlate, string status)
        {
            return repository.UpdateVehicleStatusByLicensePlate(licensePlate, status);
        }

        public Guid? GetTicketPriceIdByVehicleType(Guid vehicleTypeId, bool? isMonth)
        {
            return repository.GetTicketPriceIdByVehicleType(vehicleTypeId, isMonth);
        }

        public Guid? GetVehicleTypeIdByVehicleId(Guid vehicleId)
        {
            return repository.GetVehicleTypeIdByVehicleId(vehicleId);
        }

        public void UpdateExitTime(Guid vehicleId)
        {
            repository.UpdateExitTime(vehicleId);
        }

        public string GetVehicleStatusByLicensePlate(string licensePlate)
        {
            return repository.GetVehicleStatusByLicensePlate(licensePlate);
        }

    }
}
