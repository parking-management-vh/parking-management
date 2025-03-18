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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ParkingManagement.DAL.Repositories
{
    public class vehicleRepository
    {
        private readonly DatabaseProvider dbProvider = new DatabaseProvider();
        private parkingSlotBLL parkingSlotBLL = new parkingSlotBLL();

        public List<VehicleType> GetAllVehicleType()
        {
            List<VehicleType> areas = new List<VehicleType>();
            string query = "SELECT * FROM vehicle_type";

            List<MySqlParameter> parameters = new List<MySqlParameter>();

            System.Data.DataTable data = dbProvider.ExecuteQuery(query, parameters.ToArray());

            foreach (DataRow row in data.Rows)
            {
                areas.Add(new VehicleType(
                    row["id"].ToString(),
                    row["vehicle_type_name"].ToString(),
                    row["description"].ToString()
                ));
            }
            return areas;
        }

        public List<allVehicle> GetAllVehicle(string areaName = null, string slotNumber = null, string vehicleType = null, string licensePlate = null, string status = null)
        {
            List<allVehicle> vehicles = new List<allVehicle>();

            string query = @"
                SELECT v.id, v.license_plate, vt.vehicle_type_name, 
                       ps.slot_number AS slot_number, pa.area_name AS area_name, 
                       v.entry_time, v.exit_time, v.status
                FROM vehicle v
                JOIN vehicle_type vt ON v.vehicle_type_id = vt.id
                JOIN parking_slot ps ON v.parking_slot_id = ps.id
                JOIN parking_area pa ON v.parking_area_id = pa.id
                WHERE 1 = 1";

            List<MySqlParameter> parameters = new List<MySqlParameter>();

            if (!string.IsNullOrEmpty(areaName) && areaName != "Tất cả")
            {
                query += " AND pa.id = @areaId";
                parameters.Add(new MySqlParameter("@areaId", Guid.Parse(areaName)));
            }

            if (!string.IsNullOrEmpty(vehicleType) && vehicleType != "Tất cả")
            {
                query += " AND vt.id = @vehicleTypeId";
                parameters.Add(new MySqlParameter("@vehicleTypeId", Guid.Parse(vehicleType)));
            }

            if (!string.IsNullOrEmpty(slotNumber) && slotNumber != "Tất cả")
            {
                query += " AND ps.slot_number = @parkingSlot";
                parameters.Add(new MySqlParameter("@parkingSlot", slotNumber));
            }

            if (!string.IsNullOrEmpty(licensePlate))
            {
                query += " AND v.license_plate LIKE @licensePlate";
                parameters.Add(new MySqlParameter("@licensePlate", $"%{licensePlate}%"));
            }

            if (!string.IsNullOrEmpty(status))
            {
                query += " AND v.status LIKE @status";
                parameters.Add(new MySqlParameter("@status", $"%{status}%"));
            }

            try
            {
                DataTable data = dbProvider.ExecuteQuery(query, parameters.ToArray());

                foreach (DataRow row in data.Rows)
                {
                    try
                    {
                        if (!Guid.TryParse(row["id"].ToString(), out Guid parsedId))
                        {
                            MessageBox.Show($"Lỗi: ID không hợp lệ -> {row["id"]}", "Error");
                            continue;
                        }

                        vehicles.Add(new allVehicle(
                            parsedId,
                            row["license_plate"].ToString(),
                            row["vehicle_type_name"].ToString(),  
                            row["slot_number"].ToString(),   
                            row["area_name"].ToString(),   
                            Convert.ToDateTime(row["entry_time"]),
                            row["exit_time"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(row["exit_time"]),
                            row["status"].ToString()
                        ));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi khi mapping dữ liệu: {ex.Message}", "Error");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải danh sách xe: {ex.Message}", "Error");
            }

            return vehicles;
        }

        public void CreateVehicle(VehicleModel vehicle)
        {
            string query = @"
                INSERT INTO vehicle (id, license_plate, vehicle_type_id, parking_slot_id, parking_area_id, entry_time, exit_time, save_time, created_at, updated_at) 
                VALUES (@id, @license_plate, @vehicle_type_id, @parking_slot_id, @parking_area_id, @entry_time, @exit_time, @save_time, @created_at, @updated_at)";

            vehicle.Id = Guid.NewGuid();
            vehicle.CreatedAt = DateTime.Now;
            vehicle.UpdatedAt = DateTime.Now;

            object[] parameters =
            {
                vehicle.Id.ToString(),
                vehicle.LicensePlate ?? (object)DBNull.Value,
                vehicle.VehicleTypeId.ToString(),
                vehicle.ParkingSlotId.ToString(),
                vehicle.ParkingAreaId.ToString(),
                vehicle.EntryTime.ToString("yyyy-MM-dd HH:mm:ss"),
                vehicle.ExitTime?.ToString("yyyy-MM-dd HH:mm:ss") ?? (object)DBNull.Value,
                vehicle.SaveTime == default ? (object)DBNull.Value : vehicle.SaveTime.ToString("yyyy-MM-dd HH:mm:ss"),
                vehicle.CreatedAt.ToString("yyyy-MM-dd HH:mm:ss"),
                vehicle.UpdatedAt.ToString("yyyy-MM-dd HH:mm:ss")
            };

            try
            {
                dbProvider.ExecuteNonQuery(query, parameters);

                parkingSlotBLL.UpdateParkingSlotStatus(vehicle.ParkingSlotId, "Đã có xe"); ;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm xe mới: " + ex.Message);
                throw;
            }
        }

        public void UpdateVehicle(VehicleModel vehicle)
        {
            string query = @"
            UPDATE vehicle 
            SET id = @id,
                license_plate = @license_plate, 
                vehicle_type_id = @vehicle_type_id, 
                parking_slot_id = @parking_slot_id, 
                parking_area_id = @parking_area_id, 
                entry_time = @entry_time, 
                exit_time = @exit_time, 
                save_time = @save_time, 
                updated_at = @updated_at
            WHERE id = @id";

            vehicle.UpdatedAt = DateTime.Now;

            //MessageBox.Show($"ID xe: {vehicle.Id}\nBiển số: {vehicle.LicensePlate}\nLoại xe ID: {vehicle.VehicleTypeId}\nChỗ đỗ ID: {vehicle.ParkingSlotId}\nKhu vực ID: {vehicle.ParkingAreaId}",
            //    "Debug VehicleModel", MessageBoxButtons.OK, MessageBoxIcon.Information);

            object[] parameters =
            {
                vehicle.Id.ToString(),
                vehicle.LicensePlate ?? (object)DBNull.Value,
                vehicle.VehicleTypeId.ToString(),
                vehicle.ParkingSlotId.ToString(),
                vehicle.ParkingAreaId.ToString(),
                vehicle.EntryTime.ToString("yyyy-MM-dd HH:mm:ss"),
                vehicle.ExitTime?.ToString("yyyy-MM-dd HH:mm:ss") ?? (object)DBNull.Value,
                vehicle.SaveTime == default ? (object)DBNull.Value : vehicle.SaveTime.ToString("yyyy-MM-dd HH:mm:ss"),
                vehicle.UpdatedAt.ToString("yyyy-MM-dd HH:mm:ss")
            };

            // Debug giá trị của parameters
            //MessageBox.Show($"Params:\n" +
            //    $"@id = {parameters[0]}\n" +
            //    $"@license_plate = {parameters[1]}\n" +
            //    $"@vehicle_type_id = {parameters[2]}\n" +
            //    $"@parking_slot_id = {parameters[3]}\n" +
            //    $"@parking_area_id = {parameters[4]}\n" +
            //    $"@entry_time = {parameters[5]}\n" +
            //    $"@exit_time = {parameters[6]}\n" +
            //    $"@save_time = {parameters[7]}\n" +
            //    $"@updated_at = {parameters[8]}",
            //    "Debug Query Params", MessageBoxButtons.OK, MessageBoxIcon.Information);

            try
            {
                dbProvider.ExecuteNonQuery(query, parameters);
                MessageBox.Show("Cập nhật phương tiện thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật phương tiện: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        public void UpdateExitTime(Guid vehicleId)
        {
            string query = @"
            UPDATE vehicle 
            SET exit_time = NOW(), 
                updated_at = NOW()
            WHERE id = @id";

                object[] parameters =
                {
            vehicleId.ToString()
        };

            try
            {
                dbProvider.ExecuteNonQuery(query, parameters);
                //MessageBox.Show("Cập nhật thời gian ra thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật thời gian ra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        public void DeleteVehicle(string id)
        {
            string query = "DELETE FROM vehicle WHERE id = @id";

            object[] parameters = { id };

            try
            {
                dbProvider.ExecuteNonQuery(query, parameters);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xoá chỗ đỗ: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        public Guid? GetVehicleIdByLicensePlate(string licensePlate)
        {
            string query = "SELECT id FROM vehicle WHERE license_plate = @licensePlate AND status = 'parked' LIMIT 1";
            object[] parameters = { licensePlate };

            DataTable data = dbProvider.ExecuteQuery(query, parameters);

            if (data.Rows.Count > 0 && Guid.TryParse(data.Rows[0]["id"].ToString(), out Guid vehicleId))
            {
                return vehicleId;
            }

            return null;
        }

        public bool UpdateVehicleStatusByLicensePlate(string licensePlate, string status)
        {
            Guid? vehicleId = GetVehicleIdByLicensePlate(licensePlate);

            if (vehicleId.HasValue)
            {
                string query = "UPDATE vehicle SET status = @status WHERE id = @vehicleId";
                object[] parameters = { status, vehicleId.Value };

                int rowsAffected = dbProvider.ExecuteNonQuery(query, parameters);
                return rowsAffected > 0;
            }

            return false;
        }

        public string GetVehicleStatusByLicensePlate(string licensePlate)
        {
            string query = "SELECT status FROM vehicle WHERE license_plate = @licensePlate";
            object[] parameters = { licensePlate };

            DataTable data = dbProvider.ExecuteQuery(query, parameters);

            if (data.Rows.Count > 0)
            {
                return data.Rows[0]["status"].ToString(); 
            }

            return null; 
        }

        public Guid? GetTicketPriceIdByVehicleType(Guid vehicleTypeId, bool? isMonth)
        {
            string query = @"
            SELECT id 
            FROM ticket_price 
            WHERE vehicle_type_id = @vehicleTypeId AND is_month = @isMonth
            ORDER BY created_at DESC 
            LIMIT 1";

            object[] parameters = { vehicleTypeId.ToString(), isMonth };

            DataTable data = dbProvider.ExecuteQuery(query, parameters);

            if (data.Rows.Count > 0 && Guid.TryParse(data.Rows[0]["id"].ToString(), out Guid ticketPriceId))
            {
                return ticketPriceId;
            }

            return null;
        }

        public Guid? GetVehicleTypeIdByVehicleId(Guid vehicleId)
        {
            string query = "SELECT vehicle_type_id FROM vehicle WHERE id = @vehicleId";
            object[] parameters = { vehicleId.ToString() };

            DataTable data = dbProvider.ExecuteQuery(query, parameters);

            if (data.Rows.Count > 0 && Guid.TryParse(data.Rows[0]["vehicle_type_id"].ToString(), out Guid vehicleTypeId))
            {
                return vehicleTypeId;
            }

            return null;
        }
    }
}
