using ParkingManagement.DAL.Repositories;
using ParkingManagement.Models;
using System;
using System.Collections.Generic;

namespace ParkingManagement.BLL
{
    public class ParkingCardBLL
    {
        private readonly parkingCardRepository repository = new parkingCardRepository();

        public List<allParkingCard> GetAllParkingCards(string status = null, bool? isMonth = null)
        {
            return repository.GetAllParkingCards(status, isMonth);
        }

        public void CreateParkingCard(string vehicleLicensePlate, string userCode, bool isMonth)
        {
            repository.CreateParkingCard(vehicleLicensePlate, userCode, isMonth);
        }
        public parkingCardDetail GetParkingCardByLicensePlate(string licensePlate)
        {
            return repository.GetParkingCardByLicensePlate(licensePlate);
        }
        public void UpdateParkingCardEndDate(Guid vehicleId)
        {
            repository.UpdateParkingCardEndDate(vehicleId);
        }
        public void DeleteParkingCard(string id)
        {
            repository.DeleteParkingCard(id);
        }
        
    }
}
