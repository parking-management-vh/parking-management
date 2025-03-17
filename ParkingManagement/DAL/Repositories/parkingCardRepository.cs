using MySql.Data.MySqlClient;
using ParkingManagement.BLL;
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
        private vehicleBLL vehicleBLL = new vehicleBLL();
        private userBLL userBLL = new userBLL();

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
                    tp.price AS price,
                    u.code AS user_code,                  
                    v.license_plate AS vehicle_license_plate  
                FROM parking_card pc
                JOIN vehicle v ON pc.vehicle_id = v.id                
                JOIN ticket_price tp ON pc.ticket_price_id = tp.id
                LEFT JOIN user u ON pc.user_id = u.id
                WHERE 1=1";

            List<MySqlParameter> parameters = new List<MySqlParameter>();

            if (!string.IsNullOrEmpty(status) && status != "Tất cả")
            {
                query += " AND pc.status = @status";
                parameters.Add(new MySqlParameter("@status", status));
            }
            if (isMonth.HasValue)
            {
                query += " AND pc.is_month = @isMonth";
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

        public void CreateParkingCard(string vehicleLicensePlate, string userCode, bool isMonth)
        {
            Guid? vehicleId = vehicleBLL.GetVehicleIdByLicensePlate(vehicleLicensePlate);
            string status = vehicleBLL.GetVehicleStatusByLicensePlate(vehicleLicensePlate);

            if (vehicleId == null || status != "parked")
            {
                MessageBox.Show("Không tìm thấy phương tiện đang trong bãi với biển số này.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Guid? vehicleTypeId = vehicleBLL.GetVehicleTypeIdByVehicleId(vehicleId.Value);
            if (vehicleTypeId == null)
            {
                MessageBox.Show("Không tìm thấy loại phương tiện.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Guid? ticketPriceId = vehicleBLL.GetTicketPriceIdByVehicleType(vehicleTypeId.Value, isMonth);
            if (ticketPriceId == null)
            {
                MessageBox.Show("Không tìm thấy giá vé phù hợp.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Guid? userId = userBLL.GetUserIdByCode(userCode);

            ParkingCard newCard = new ParkingCard(
                Guid.NewGuid(),
                DateTime.Now,
                null,
                "Hoạt động",
                isMonth,
                vehicleId.Value,
                userId ?? Guid.Empty,
                ticketPriceId.Value
            );

            string query = @"
            INSERT INTO parking_card (id, start_date, end_date, status, is_month, created_at, updated_at, vehicle_id, user_id, ticket_price_id)
            VALUES (@id, @start_date, @end_date, @status, @is_month, NOW(), NOW(), @vehicle_id, @user_id, @ticket_price_id)";

            object[] parameters =
            {
                newCard.Id.ToString(),
                newCard.StartDate.ToString("yyyy-MM-dd HH:mm:ss"),
                newCard.EndDate?.ToString("yyyy-MM-dd HH:mm:ss") ?? (object)DBNull.Value,
                newCard.Status,
                newCard.IsMonth,
                newCard.VehicleId.ToString(),
                newCard.UserId == Guid.Empty ? (object)DBNull.Value : newCard.UserId.ToString(),
                newCard.TickerPriceId.ToString()
            };

            try
            {
                dbProvider.ExecuteNonQuery(query, parameters);
                MessageBox.Show("Thêm thẻ gửi xe thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tạo thẻ gửi xe: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void UpdateParkingCardEndDate(Guid vehicleId)
        {
            string query = @"
            UPDATE parking_card 
            SET end_date = @end_date 
            WHERE vehicle_id = @vehicleId";

                object[] parameters =
                {
                    DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                    vehicleId.ToString()
                };

            try
            {
                int rowsAffected = dbProvider.ExecuteNonQuery(query, parameters);
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Cập nhật end_date thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy thẻ xe để cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật end_date: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        public parkingCardDetail GetParkingCardByLicensePlate(string licensePlate)
        {
            Guid? vehicleId = vehicleBLL.GetVehicleIdByLicensePlate(licensePlate);
            if (!vehicleId.HasValue)
            {
                MessageBox.Show($"Không tìm thấy phương tiện với biển số: {licensePlate}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            string query = @"
            SELECT 
                pc.id, pc.start_date, pc.end_date, pc.status, pc.is_month, 
                v.license_plate, u.code, tp.price, 
                pc.created_at, pc.updated_at
            FROM parking_card pc
            LEFT JOIN vehicle v ON pc.vehicle_id = v.id
            LEFT JOIN user u ON pc.user_id = u.id
            LEFT JOIN ticket_price tp ON pc.ticket_price_id = tp.id
            WHERE pc.vehicle_id = @vehicleId";

            object[] parameters = { vehicleId.Value.ToString() };
            DataTable cardData = dbProvider.ExecuteQuery(query, parameters);

            MessageBox.Show($"Số dòng lấy được từ DB: {cardData.Rows.Count}", "Debug", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (cardData.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy thẻ xe trong database!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }

            DataRow row = cardData.Rows[0];

            bool isMonth = row["is_month"] != DBNull.Value && Convert.ToBoolean(row["is_month"]);

            if (!isMonth)
            {
                vehicleBLL.UpdateExitTime(vehicleId.Value);
                UpdateParkingCardEndDate(vehicleId.Value);
            }

            return new parkingCardDetail
            (
                id: Guid.Parse(row["id"].ToString()),
                startDate: Convert.ToDateTime(row["start_date"]),
                endDate: row["end_date"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(row["end_date"]),
                status: row["status"].ToString(),
                isMonth: Convert.ToBoolean(row["is_month"]),
                licensePlate: row["license_plate"].ToString(),
                userCode: row["code"] == DBNull.Value ? "N/A" : row["code"].ToString(),
                price: row["price"] == DBNull.Value ? 0 : Convert.ToDecimal(row["price"]),
                createdAt: Convert.ToDateTime(row["created_at"]),
                updatedAt: Convert.ToDateTime(row["updated_at"])
            );
        }
    }
}
