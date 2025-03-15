using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using ParkingManagement.DAL.Database;
using ParkingManagement.Models;

namespace ParkingManagement.DAL.Repositories
{
    public class RecentActivityDAL
    {
        private readonly DatabaseProvider dbProvider = new DatabaseProvider();

        // Lấy danh sách xe vào gần đây
        public List<VehicleModel> GetRecentVehicles()
        {
            List<VehicleModel> vehicles = new List<VehicleModel>();
            string query = "SELECT v.id, v.license_plate, v.entry_time, vt.vehicle_type_name " +
                           "FROM vehicle v " +
                           "JOIN vehicle_type vt ON v.vehicle_type_id = vt.id " +
                           "ORDER BY v.entry_time DESC LIMIT 10";

            using (DataTable data = dbProvider.ExecuteQuery(query))
            {
                foreach (DataRow row in data.Rows)
                {
                    vehicles.Add(new VehicleModel
                    {
                        Id = row["id"] != DBNull.Value ? Guid.Parse(row["id"].ToString()) : Guid.Empty,
                        LicensePlate = row["license_plate"].ToString(),
                        EntryTime = row["entry_time"] != DBNull.Value ? Convert.ToDateTime(row["entry_time"]) : DateTime.MinValue,
                        //VehicleTypeName = row["vehicle_type_name"].ToString()
                    });
                }
            }
            return vehicles;
        }

        // Lấy danh sách giao dịch gần nhất
        public List<ParkingCard> GetRecentTransactions()
        {
            List<ParkingCard> transactions = new List<ParkingCard>();
            string query = "SELECT pc.id, pc.vehicle_id, pc.status, pc.end_date " +
                           "FROM parking_card pc " +
                           "ORDER BY pc.end_date DESC LIMIT 10";

            using (DataTable data = dbProvider.ExecuteQuery(query))
            {
                foreach (DataRow row in data.Rows)
                {
                    transactions.Add(new ParkingCard
                    {
                        Id = row["id"] != DBNull.Value ? Guid.Parse(row["id"].ToString()) : Guid.Empty,
                        VehicleId = row["vehicle_id"] != DBNull.Value ? Guid.Parse(row["vehicle_id"].ToString()) : Guid.Empty,
                        Status = row["status"].ToString(),
                        EndDate = row["end_date"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(row["end_date"]) : null
                    });
                }
            }
            return transactions;
        }

        // Lấy danh sách xe quá hạn
        public List<VehicleModel> GetOverdueVehicles()
        {
            List<VehicleModel> overdueVehicles = new List<VehicleModel>();
            string query = "SELECT v.id, v.license_plate, v.entry_time " +
                           "FROM vehicle v " +
                           "WHERE v.exit_time IS NULL " +
                           "AND TIMESTAMPDIFF(HOUR, v.entry_time, NOW()) > 24";

            using (DataTable data = dbProvider.ExecuteQuery(query))
            {
                foreach (DataRow row in data.Rows)
                {
                    overdueVehicles.Add(new VehicleModel
                    {
                        Id = row["id"] != DBNull.Value ? Guid.Parse(row["id"].ToString()) : Guid.Empty,
                        LicensePlate = row["license_plate"].ToString(),
                        EntryTime = row["entry_time"] != DBNull.Value ? Convert.ToDateTime(row["entry_time"]) : DateTime.MinValue,
                    });
                }
            }
            return overdueVehicles;
        }
        // Lấy tổng số chỗ trong bãi
        public int GetTotalSlots()
        {
            string query = "SELECT COUNT(*) FROM parking_slot;";
            return Convert.ToInt32(dbProvider.ExecuteScalar(query));
        }

        // Lấy số chỗ trống
        public int GetAvailableSlots()
        {
            string query = "SELECT COUNT(*) FROM parking_slot WHERE status = 'Sẵn sàng';";
            return Convert.ToInt32(dbProvider.ExecuteScalar(query));
        }

        // Lấy số xe hiện đang trong bãi
        public int GetVehiclesInParking()
        {
            string query = "SELECT COUNT(*) FROM vehicle WHERE exit_time IS NULL;";
            return Convert.ToInt32(dbProvider.ExecuteScalar(query));
        }

        // Lấy số lượt vào hôm nay
        public int GetEntriesToday()
        {
            string query = "SELECT COUNT(*) FROM vehicle WHERE DATE(entry_time) = CURDATE();";
            return Convert.ToInt32(dbProvider.ExecuteScalar(query));
        }

        // Lấy số lượt ra hôm nay
        public int GetExitsToday()
        {
            string query = "SELECT COUNT(*) FROM vehicle WHERE DATE(exit_time) = CURDATE();";
            return Convert.ToInt32(dbProvider.ExecuteScalar(query));
        }

        // Lấy tổng doanh thu hôm nay
        public decimal GetTodayRevenue()
        {
            string query = "SELECT IFNULL(SUM(total_price), 0) FROM payment_receipt WHERE DATE(payment_date) = CURDATE();";
            return Convert.ToDecimal(dbProvider.ExecuteScalar(query));
        }


    }
}
