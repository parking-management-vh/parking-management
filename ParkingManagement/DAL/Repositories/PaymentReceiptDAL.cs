using ParkingManagement.Models;
using MySql.Data.MySqlClient;
using System.Data;
using System;
using System.Configuration;

namespace ParkingManagement.DAL.Repositories
{
    public class PaymentReceiptDAL
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;

        private DataTable ExecuteQuery(string query, MySqlParameter[] parameters = null)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    if (parameters != null)
                        cmd.Parameters.AddRange(parameters);

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        return dt;
                    }
                }
            }
        }

        private int ExecuteNonQuery(string query, MySqlParameter[] parameters = null)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    if (parameters != null)
                        cmd.Parameters.AddRange(parameters);

                    return cmd.ExecuteNonQuery();
                }
            }
        }

        public DataTable GetAllReceipts()
        {
            string query = "SELECT * FROM payment_receipt";
            return ExecuteQuery(query);
        }

        public bool InsertReceipt(PaymentReceipt receipt)
        {
            string query = "INSERT INTO payment_receipt (parking_card_id, vehicle_id, staff_code, total_price, payment_method, payment_date, payment_status, created_at, updated_at) " +
                           "VALUES (@ParkingCardId, @VehicleId, @StaffCode, @TotalPrice, @PaymentMethod, @PaymentDate, @PaymentStatus, @CreatedAt, @UpdatedAt)";

            MySqlParameter[] parameters = {
                new MySqlParameter("@ParkingCardId", receipt.ParkingCardId ?? (object)DBNull.Value), // Cho phép null
                new MySqlParameter("@VehicleId", receipt.VehicleId),
                new MySqlParameter("@StaffCode", receipt.StaffCode),
                new MySqlParameter("@TotalPrice", receipt.TotalPrice),
                new MySqlParameter("@PaymentMethod", receipt.PaymentMethod),
                new MySqlParameter("@PaymentDate", receipt.PaymentDate),
                new MySqlParameter("@PaymentStatus", receipt.PaymentStatus),
                new MySqlParameter("@CreatedAt", receipt.CreatedAt),
                new MySqlParameter("@UpdatedAt", receipt.UpdatedAt)
            };

            return ExecuteNonQuery(query, parameters) > 0;
        }

        public bool UpdateReceipt(PaymentReceipt receipt)
        {
            string query = "UPDATE payment_receipt SET parking_card_id = @ParkingCardId, vehicle_id = @VehicleId, " +
                           "staff_code = @StaffCode, total_price = @TotalPrice, payment_method = @PaymentMethod, " +
                           "payment_date = @PaymentDate, payment_status = @PaymentStatus, updated_at = @UpdatedAt " +
                           "WHERE id = @Id";

            MySqlParameter[] parameters = {
                new MySqlParameter("@Id", receipt.Id),
                new MySqlParameter("@ParkingCardId", receipt.ParkingCardId ?? (object)DBNull.Value),
                new MySqlParameter("@VehicleId", receipt.VehicleId),
                new MySqlParameter("@StaffCode", receipt.StaffCode),
                new MySqlParameter("@TotalPrice", receipt.TotalPrice),
                new MySqlParameter("@PaymentMethod", receipt.PaymentMethod),
                new MySqlParameter("@PaymentDate", receipt.PaymentDate),
                new MySqlParameter("@PaymentStatus", receipt.PaymentStatus),
                new MySqlParameter("@UpdatedAt", DateTime.UtcNow) // Cập nhật thời gian hiện tại
            };

            return ExecuteNonQuery(query, parameters) > 0;
        }

        public bool DeleteReceipt(int id)
        {
            string query = "DELETE FROM payment_receipt WHERE id = @Id";
            MySqlParameter[] parameters = { new MySqlParameter("@Id", id) };
            return ExecuteNonQuery(query, parameters) > 0;
        }
    }
}