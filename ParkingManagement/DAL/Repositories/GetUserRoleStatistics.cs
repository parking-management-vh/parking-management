using MySql.Data.MySqlClient;
using ParkingManagement.DAL.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingManagement.DAL.Repositories
{
    public class UserStatisticsDAL
    {
       /* public DataTable GetUserRoleStatistics()
        {
            using (MySqlConnection conn = DatabaseProvider.GetMySqlConnection())
            {
                conn.Open();
                string query = "SELECT role_name, COUNT(*) AS total_users FROM user INNER JOIN role ON user.role_id = role.id GROUP BY role_name";
                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public DataTable GetNewUsersByMonthYear()
        {
            using (MySqlConnection conn = DatabaseProvider.GetMySqlConnection())
            {
                conn.Open();
                string query = "SELECT DATE_FORMAT(created_at, '%Y-%m') AS month_year, COUNT(*) AS total_users FROM user GROUP BY month_year ORDER BY month_year DESC";
                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public DataTable GetActiveParkingCardUsers()
        {
            using (MySqlConnection conn = DatabaseProvider.GetMySqlConnection())
            {
                conn.Open();
                string query = "SELECT user.full_name, user.phone_number, parking_card.start_date, parking_card.end_date FROM parking_card INNER JOIN user ON parking_card.user_id = user.id WHERE parking_card.status = 'Hoạt động'";
                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public DataTable GetUserTransactionStatistics()
        {
            using (MySqlConnection conn = DatabaseProvider.GetMySqlConnection())
            {
                conn.Open();
                string query = "SELECT user.full_name, COUNT(payment_receipt.id) AS total_transactions, SUM(payment_receipt.total_price) AS total_spent FROM payment_receipt INNER JOIN user ON payment_receipt.staff_code = user.code GROUP BY user.full_name";
                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }*/
    }
}
