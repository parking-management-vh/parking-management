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
        private readonly parkingAreaRepository repository = new parkingAreaRepository();

        public List<parkingAreaModel> GetAllParkingAreas()
        {
            return repository.GetAllParkingAreas();
        }

    }
}
