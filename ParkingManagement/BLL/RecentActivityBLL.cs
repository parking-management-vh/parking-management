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
            recentActivityDAL = dal;
        }

        // Default constructor (fixing your error)
        public RecentActivityBLL()
        {
            recentActivityDAL = new RecentActivityDAL();
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

        public int GetTotalSlots()
        {
            return recentActivityDAL.GetTotalSlots();
        }

        public int GetAvailableSlots(string parkingAreaId)
        {
            return recentActivityDAL.GetAvailableSlots(parkingAreaId);
        }


        public int GetVehiclesInParking()
        {
            return recentActivityDAL.GetVehiclesInParking();
        }

        public int GetEntriesToday()
        {
            return recentActivityDAL.GetEntriesToday();
        }

        public int GetExitsToday()
        {
            return recentActivityDAL.GetExitsToday();
        }

        public decimal GetTodayRevenue()
        {
            return recentActivityDAL.GetTodayRevenue();
        }
    }
}
