using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using ParkingManagement.Models;

namespace ParkingManagement.DAL.Repositories
{
    public class TicketPriceRepository
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;

        public List<TicketPrice> GetAllTicketPrices()
        {
            var ticketPrices = new List<TicketPrice>();

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT id, vehicle_type_id, price, is_month, description, created_at, updated_at FROM ticket_price";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ticketPrices.Add(new TicketPrice
                            {
                                Id = reader["id"].ToString(),
                                VehicleTypeId = reader["vehicle_type_id"].ToString(),
                                Price = Convert.ToDecimal(reader["price"]),
                                IsMonth = Convert.ToBoolean(reader["is_month"]),
                                Description = reader["description"]?.ToString(),
                                CreatedAt = Convert.ToDateTime(reader["created_at"]),
                                UpdatedAt = Convert.ToDateTime(reader["updated_at"])
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi tải danh sách giá vé: " + ex.Message);
            }

            return ticketPrices;
        }
        public List<VehicleType> GetVehicleTypes()
        {
            var vehicleTypes = new List<VehicleType>();

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT id, vehicle_type_name FROM vehicle_type";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            vehicleTypes.Add(new VehicleType
                            {
                                Id = reader["id"].ToString(),
                                VehicleTypeName = reader["vehicle_type_name"].ToString()
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi tải danh sách loại xe: " + ex.Message);
            }

            return vehicleTypes;
        }
        public void InsertTicketPrice(TicketPrice ticketPrice)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"
                        INSERT INTO ticket_price (id, vehicle_type_id, price, is_month, description, created_at) 
                        VALUES (UUID(), @vehicleTypeId, @price, @isMonth, @description, NOW())";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@vehicleTypeId", ticketPrice.VehicleTypeId);
                        cmd.Parameters.AddWithValue("@price", ticketPrice.Price);
                        cmd.Parameters.AddWithValue("@isMonth", ticketPrice.IsMonth);
                        cmd.Parameters.AddWithValue("@description", ticketPrice.Description);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi thêm giá vé: " + ex.Message);
            }
        }

        public void UpdateTicketPrice(TicketPrice ticketPrice)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"
                        UPDATE ticket_price 
                        SET price = @price, is_month = @isMonth, description = @description, updated_at = NOW() 
                        WHERE id = @id";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", ticketPrice.Id);
                        cmd.Parameters.AddWithValue("@price", ticketPrice.Price);
                        cmd.Parameters.AddWithValue("@isMonth", ticketPrice.IsMonth);
                        cmd.Parameters.AddWithValue("@description", ticketPrice.Description);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi cập nhật giá vé: " + ex.Message);
            }
        }

        public void DeleteTicketPrice(string id)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM ticket_price WHERE id = @id";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi xóa giá vé: " + ex.Message);
            }
        }
    }
}
