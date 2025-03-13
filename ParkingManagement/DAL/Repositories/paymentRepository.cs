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
    class paymentRepository
    {
        private readonly DatabaseProvider dbProvider = new DatabaseProvider();
        public List<paymentModel> GetAllPayments(string filterType, string filterValue, string paymentMethodFilter, DateTime? paymentDate)
        {
            List<paymentModel> payments = new List<paymentModel>();
            string query = @"
                SELECT pr.*, v.license_plate 
                FROM payment_receipt pr
                LEFT JOIN vehicle v ON pr.vehicle_id = v.id
                WHERE 1 = 1";

            List<MySqlParameter> parameters = new List<MySqlParameter>();

            if (filterType != "Tất cả" && !string.IsNullOrEmpty(filterValue))
            {
                switch (filterType)
                {
                    case "Biển số":
                        query += " AND v.license_plate LIKE @filterValue";
                        break;
                    case "Mã nhân viên":
                        query += " AND pr.staff_code LIKE @filterValue";
                        break;
                    case "Mã hoá đơn":
                        query += " AND pr.invoice_code LIKE @filterValue";
                        break;
                }
                parameters.Add(new MySqlParameter("@filterValue", "%" + filterValue + "%"));
            }

            if (!string.IsNullOrEmpty(paymentMethodFilter) && paymentMethodFilter != "Tất cả")
            {
                query += " AND pr.payment_method = @paymentMethod";
                parameters.Add(new MySqlParameter("@paymentMethod", paymentMethodFilter));
            }

            if (paymentDate.HasValue)
            {
                query += " AND DATE(pr.payment_date) = @paymentDate";
                parameters.Add(new MySqlParameter("@paymentDate", paymentDate.Value.ToString("yyyy-MM-dd")));
            }

            DataTable data = dbProvider.ExecuteQuery(query, parameters.ToArray());

            foreach (DataRow row in data.Rows)
            {
                payments.Add(new paymentModel(
                    Convert.ToInt32(row["id"]),
                    row["parking_card_id"] != DBNull.Value ? Guid.Parse(row["parking_card_id"].ToString()) : (Guid?)null,
                    Convert.ToDateTime(row["payment_date"]),
                    Convert.ToDecimal(row["total_price"]),
                    row["payment_method"].ToString(),
                    Convert.ToInt32(row["total_time"]),
                    Guid.Parse(row["vehicle_id"].ToString()),
                    row["staff_code"].ToString(),
                    row["invoice_code"].ToString(),
                    Convert.ToDateTime(row["created_at"]),
                    Convert.ToDateTime(row["updated_at"])
                )
                {
                    LicensePlate = row["license_plate"].ToString()
                });
            }
            return payments;
        }

        public List<paymentModel> GetAllPaymentsByStaffCode(string staffCode, string filterType, string filterValue, string paymentMethodFilter, DateTime? paymentDate = null)
        {
            List<paymentModel> payments = new List<paymentModel>();
            string query = @"
                SELECT pr.*, v.license_plate 
                FROM payment_receipt pr
                LEFT JOIN vehicle v ON pr.vehicle_id = v.id
                WHERE pr.staff_code = @staffCode";

            List<MySqlParameter> parameters = new List<MySqlParameter>
            {
                new MySqlParameter("@staffCode", staffCode)
            };

            if (filterType != "Tất cả" && !string.IsNullOrEmpty(filterValue))
            {
                switch (filterType)
                {
                    case "Biển số":
                        query += " AND v.license_plate LIKE @filterValue";
                        break;
                    case "Mã hoá đơn":
                        query += " AND pr.invoice_code LIKE @filterValue";
                        break;
                }
                parameters.Add(new MySqlParameter("@filterValue", "%" + filterValue + "%"));
            }

            if (!string.IsNullOrEmpty(paymentMethodFilter) && paymentMethodFilter != "Tất cả")
            {
                query += " AND pr.payment_method = @paymentMethod";
                parameters.Add(new MySqlParameter("@paymentMethod", paymentMethodFilter));
            }

            if (paymentDate.HasValue)
            {
                query += " AND DATE(pr.payment_date) = @paymentDate";
                parameters.Add(new MySqlParameter("@paymentDate", paymentDate.Value.ToString("yyyy-MM-dd")));
            }

            if (paymentDate.HasValue)
            {
                query += " AND DATE(pr.payment_date) = @paymentDate";
                parameters.Add(new MySqlParameter("@paymentDate", paymentDate.Value.ToString("yyyy-MM-dd")));
            }

            DataTable data = dbProvider.ExecuteQuery(query, parameters.ToArray());

            foreach (DataRow row in data.Rows)
            {
                payments.Add(new paymentModel(
                    Convert.ToInt32(row["id"]),
                    row["parking_card_id"] != DBNull.Value ? Guid.Parse(row["parking_card_id"].ToString()) : (Guid?)null,
                    Convert.ToDateTime(row["payment_date"]),
                    Convert.ToDecimal(row["total_price"]),
                    row["payment_method"].ToString(),
                    Convert.ToInt32(row["total_time"]),
                    Guid.Parse(row["vehicle_id"].ToString()),
                    row["staff_code"].ToString(),
                    row["invoice_code"].ToString(),
                    Convert.ToDateTime(row["created_at"]),
                    Convert.ToDateTime(row["updated_at"])
                )
                {
                    LicensePlate = row["license_plate"].ToString()
                });
            }
            return payments;
        }


        private vehicleBLL vehicleBLL = new vehicleBLL();
        private ParkingCardBLL ParkingCardBLL = new ParkingCardBLL();
        public bool CreatePayment(string licensePlate, string staffCode, string paymentMethod)
        {
            
            Guid? vehicleId = vehicleBLL.GetVehicleIdByLicensePlate(licensePlate);
            if (!vehicleId.HasValue)
            {
                MessageBox.Show($"Không tìm thấy phương tiện với biển số: {licensePlate}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            parkingCardDetail parkingCard = ParkingCardBLL.GetParkingCardByLicensePlate(licensePlate);
            if (parkingCard == null)
            {
                MessageBox.Show("Không tìm thấy thẻ xe trong database!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            decimal totalPrice = 0;
            int totalTime = 0;

            if (parkingCard.IsMonth)
            {
                totalPrice = parkingCard.Price;  
                totalTime = 30; 
            }
            else if (parkingCard.EndDate.HasValue)
            {
                TimeSpan duration = parkingCard.EndDate.Value - parkingCard.StartDate;
                int totalMinutes = (int)duration.TotalMinutes;

                if (totalMinutes <= 15)
                {
                    totalTime = 0; 
                    totalPrice = 0; 
                }
                else
                {
                    totalTime = (int)Math.Ceiling(duration.TotalHours); 
                    totalPrice = totalTime * parkingCard.Price;
                }
            }
            else
            {
                MessageBox.Show("Dữ liệu ngày ra không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            string invoiceCode = "HD" + DateTime.Now.ToString("yyMMddHHmm");

            string query = @"
            INSERT INTO payment_receipt 
            (parking_card_id, payment_date, total_price, payment_method, total_time, vehicle_id, staff_code, invoice_code, created_at, updated_at) 
            VALUES 
            (@parkingCardId, NOW(), @totalPrice, @paymentMethod, @totalTime, @vehicleId, @staffCode, @invoiceCode, NOW(), NOW())";

            object[] parameters =
            {
                parkingCard.Id.ToString(), 
                totalPrice,
                paymentMethod,  
                totalTime,   
                vehicleId.Value.ToString(), 
                staffCode,
                invoiceCode
            };

            int rowsAffected = dbProvider.ExecuteNonQuery(query, parameters);

            if (rowsAffected > 0)
            {
                MessageBox.Show("Thanh toán thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            else
            {
                MessageBox.Show("Thanh toán thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public bool DeletePayment(int paymentId)
        {
            string query = "DELETE FROM payment_receipt WHERE id = @paymentId";
            object[] parameters = { paymentId };

            int rowsAffected = dbProvider.ExecuteNonQuery(query, parameters);

            if (rowsAffected > 0)
            {
                MessageBox.Show("Xóa thanh toán thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            else
            {
                MessageBox.Show("Xóa thanh toán thất bại! Không tìm thấy ID.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
