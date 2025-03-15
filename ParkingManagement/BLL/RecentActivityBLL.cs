using ParkingManagement.DAL.Repositories;
using ParkingManagement.Models;
using System.Collections.Generic;

namespace ParkingManagement.BLL
{
    public class RecentActivityBLL
    {
        private RecentActivityDAL recentActivityDAL;

        // Constructor with dependency injection
        public RecentActivityBLL(RecentActivityDAL dal)
        {
            this.recentActivityDAL = dal;
        }

        // Default constructor (fixing your error)
        public RecentActivityBLL()
        {
            this.recentActivityDAL = new RecentActivityDAL();
        }

        public List<VehicleModel> GetRecentVehicles()
        {
            return recentActivityDAL.GetRecentVehicles();
        }

        public List<ParkingCard> GetRecentTransactions()
        {
            return recentActivityDAL.GetRecentTransactions();
        }

        public List<VehicleModel> GetOverdueVehicles()
        {
            return recentActivityDAL.GetOverdueVehicles();
        }


        
    }
}
