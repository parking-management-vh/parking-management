using MySql.Data.MySqlClient;
using ParkingManagement.DAL.Database;
using ParkingManagement.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkingManagement.DAL.Repositories
{
    internal class parkingCardRepository
    {
        private readonly DatabaseProvider dbProvider = new DatabaseProvider();

        public List<allParkingCard> GetAllParkingCards(string status = null, bool? isMonth = null)
        {
            List<allParkingCard> cards = new List<allParkingCard>();

            string query = @"
                SELECT 
                    pc.id AS parking_card_id,
                    pc.start_date, 
                    pc.end_date, 
                    pc.status, 
                    pc.is_month, 
                    pc.price,
                    u.code AS user_code,                  
                    v.license_plate AS vehicle_license_plate  
                FROM parking_card pc
                JOIN vehicle v ON pc.vehicle_id = v.id
                LEFT JOIN user u ON pc.user_id = u.id
                WHERE 1=1";

            List<MySqlParameter> parameters = new List<MySqlParameter>();

            if (!string.IsNullOrEmpty(status) && status != "Tất cả")
            {
                query += " AND status = @status";
                parameters.Add(new MySqlParameter("@status", status));
            }
            if (isMonth.HasValue)
            {
                query += " AND is_month = @isMonth";
                parameters.Add(new MySqlParameter("@isMonth", isMonth.Value ? 1 : 0));
            }

            DataTable data = dbProvider.ExecuteQuery(query, parameters.ToArray());

            foreach (DataRow row in data.Rows)
            {
                if (!Guid.TryParse(row["parking_card_id"].ToString(), out Guid parsedId))
                {
                    MessageBox.Show($"Lỗi: ID không hợp lệ -> {row["parking_card_id"]}", "Error");
                    continue;
                }

                string vehicleLicensePlate = row["vehicle_license_plate"] == DBNull.Value ? "" : row["vehicle_license_plate"].ToString();
                string userCode = row["user_code"] == DBNull.Value ? "" : row["user_code"].ToString();

                cards.Add(new allParkingCard(
                    parsedId,
                    row["start_date"] == DBNull.Value ? DateTime.MinValue : Convert.ToDateTime(row["start_date"]),
                    row["end_date"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(row["end_date"]),
                    row["status"] == DBNull.Value ? "" : row["status"].ToString(),
                    row["is_month"] == DBNull.Value ? false : Convert.ToBoolean(row["is_month"]),
                    row["price"] == DBNull.Value ? 0 : Convert.ToDecimal(row["price"]),
                    vehicleLicensePlate,  
                    userCode              
                ));
            }
            return cards;
        }

    }
}
