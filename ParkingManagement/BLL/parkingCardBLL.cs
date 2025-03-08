using ParkingManagement.DAL.Repositories;
using ParkingManagement.Models;
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
    }
}
