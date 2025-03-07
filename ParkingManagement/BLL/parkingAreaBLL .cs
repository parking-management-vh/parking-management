using ParkingManagement.DAL.Database;
using ParkingManagement.DAL.Repositories;
using ParkingManagement.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingManagement.BLL
{
    public class parkingAreaBLL
    {
        private readonly ParkingAreaRepository repository = new ParkingAreaRepository();

        public List<parkingAreaModel> GetAllParkingAreas(string status = null)
        {
            return repository.GetAllParkingAreas(status);
        }

        public void CreateParkingArea(parkingAreaModel area)
        {
            repository.CreateParkingArea(area);
        }

        public void UpdateParkingArea(parkingAreaModel parkingArea) 
        { 
            repository.UpdateParkingArea(parkingArea);
        }

        public void DeleteParkingArea(string id)
        {
            repository.DeleteParkingArea(id);        
        }
    }
}
