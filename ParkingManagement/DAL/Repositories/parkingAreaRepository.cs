using ParkingManagement.DAL.Database;
using ParkingManagement.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingManagement.DAL.Repositories
{
    class parkingAreaRepository
    {
        private readonly DatabaseProvider dbProvider = new DatabaseProvider();

        public List<parkingAreaModel> GetAllParkingAreas()
        {
            List<parkingAreaModel> areas = new List<parkingAreaModel>();
            string query = "SELECT * FROM parking_area";
            DataTable data = dbProvider.ExecuteQuery(query);

            foreach (DataRow row in data.Rows)
            {
                areas.Add(new parkingAreaModel(
                    row["id"].ToString(),
                    row["area_name"].ToString(),
                    row["description"].ToString()
                ));
            }
            return areas;
        }
    }
}
