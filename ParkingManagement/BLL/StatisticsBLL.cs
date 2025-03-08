using ParkingManagement.DAL.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingManagement.BLL
{
    public class StatisticsBLL
    {
        private DatabaseHelper dbHelper = new DatabaseHelper();

        public DataTable GetRevenueStatistics()
        {
            string query = "SELECT DATE(payment_date) AS date, SUM(total_price) AS revenue " +
                           "FROM payment_receipt GROUP BY DATE(payment_date) ORDER BY date;";
            return dbHelper.ExecuteQuery(query);
        }

        public DataTable GetVehicleTraffic()
        {
            string query = "SELECT DATE(entry_time) AS date, COUNT(id) AS vehicle_count " +
                           "FROM vehicle GROUP BY DATE(entry_time) ORDER BY date;";
            return dbHelper.ExecuteQuery(query);
        }

        public DataTable GetParkingSlotStatus()
        {
            string query = "SELECT slot_type, COUNT(id) AS count FROM parking_slot GROUP BY slot_type;";
            return dbHelper.ExecuteQuery(query);
        }

        public DataTable GetParkingCards()
        {
            string query = "SELECT status, COUNT(id) AS count FROM parking_card GROUP BY status;";
            return dbHelper.ExecuteQuery(query);
        }

        public DataTable GetEmployeeAndCustomerReport()
        {
            string query = "SELECT role_id, COUNT(id) AS count FROM user GROUP BY role_id;";
            return dbHelper.ExecuteQuery(query);
        }
    }
}
