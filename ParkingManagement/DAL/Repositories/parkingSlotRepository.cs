using Microsoft.Office.Interop.Excel;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ParkingManagement.DAL.Repositories
{
    internal class parkingSlotRepository
    {
        private readonly DatabaseProvider dbProvider = new DatabaseProvider();
        public List<allParkingSlot> GetAllParkingSlots(string areaName = null, string status = null, string slotType = null)
        {
            List<allParkingSlot> slots = new List<allParkingSlot>();
            string query = @"
            SELECT 
                u.id, 
                u.slot_number, 
                u.slot_type, 
                u.status, 
                pa.area_name AS area_name
            FROM parking_slot u 
            LEFT JOIN parking_area pa ON u.parking_area_id = pa.id
            WHERE 1=1";

            List<MySqlParameter> parameters = new List<MySqlParameter>();

            if (!string.IsNullOrEmpty(areaName) && areaName != "Tất cả")
            {
                query += " AND pa.area_name = @areaName";
                parameters.Add(new MySqlParameter("@areaName", areaName));
            }
            if (!string.IsNullOrEmpty(status) && status != "Tất cả")
            {
                query += " AND u.status = @status";
                parameters.Add(new MySqlParameter("@status", status));
            }
            if (!string.IsNullOrEmpty(slotType) && slotType != "Tất cả")
            {
                query += " AND u.slot_type = @slotType";
                parameters.Add(new MySqlParameter("@slotType", slotType));
            }

            System.Data.DataTable data = dbProvider.ExecuteQuery(query, parameters.ToArray());

            foreach (DataRow row in data.Rows)
            {
                slots.Add(new allParkingSlot(
                    Guid.Parse(row["id"].ToString()),
                    Convert.ToInt32(row["slot_number"]),
                    row["slot_type"].ToString(),
                    row["status"].ToString(),
                    row["area_name"].ToString()
                ));
            }
            return slots;
        }


        public void InsertParkingSlot(ParkingSlotModel slot)
        {
            string query = "INSERT INTO parking_slot (id, slot_number, slot_type, status, parking_area_id) " +
                           "VALUES (@id, @slot_number, @slot_type, @status, @parking_area_id)";

            slot.Id = Guid.NewGuid();

            object[] parameters =
            {
                slot.Id.ToString(),
                slot.SlotNumber,
                slot.SlotType ?? (object)DBNull.Value,
                slot.SlotStatus ?? (object)DBNull.Value,
                slot.ParkingAreaId.ToString(),
            };
            try
            {
                dbProvider.ExecuteNonQuery(query, parameters);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thực hiện Insert: " + ex.Message);
                throw;
            }
        }
        public void DeleteParkingSlot(string id)
        {
            string query = "DELETE FROM parking_slot WHERE id = @id";

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
        public void UpdateParkingSlot(ParkingSlotModel slot)
        {
            string query = @"
            UPDATE parking_slot 
            SET slot_number = @slot_number, 
                slot_type = @slot_type, 
                status = @status, 
                parking_area_id = @parking_area_id,
                updated_at = NOW()
            WHERE id = @id";

            object[] parameters =
            {
                slot.SlotNumber,
                slot.SlotType ?? (object)DBNull.Value,
                slot.SlotStatus ?? (object)DBNull.Value,
                slot.ParkingAreaId.ToString(),
                slot.Id.ToString()
            };

            try
            {
                dbProvider.ExecuteNonQuery(query, parameters);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật chỗ đỗ: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        public void UpdateParkingSlotStatus(Guid slotId, string status)
        {
            string query = @"
                UPDATE parking_slot 
                SET status = @status, updated_at = NOW() 
                WHERE id = @id";

                    object[] parameters =
                    {
                new MySqlParameter("@status", status),
                new MySqlParameter("@id", slotId.ToString())
            };

            try
            {
                dbProvider.ExecuteNonQuery(query, parameters);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật trạng thái chỗ đỗ: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        public List<ParkingSlotModel> GetSlotByArea(Guid areaId)
        {
            List<ParkingSlotModel> slots = new List<ParkingSlotModel>();
            string query = "SELECT * FROM parking_slot WHERE parking_area_id = @areaId AND status = 'Sẵn sàng'";

            object[] parameters = { areaId.ToString() };

            try
            {
                System.Data.DataTable data = dbProvider.ExecuteQuery(query, parameters);

                foreach (DataRow row in data.Rows)
                {
                    slots.Add(new ParkingSlotModel(
                        Guid.Parse(row["id"].ToString()),
                        Convert.ToInt32(row["slot_number"]),
                        row["slot_type"].ToString(),
                        row["status"].ToString(),
                        Guid.Parse(row["parking_area_id"].ToString())
                    ));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy danh sách vị trí đỗ: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }

            return slots;
        }

        public List<ParkingSlotModel> GetSlotArea(Guid areaId)
        {
            List<ParkingSlotModel> slots = new List<ParkingSlotModel>();
            string query = "SELECT * FROM parking_slot WHERE parking_area_id = @areaId";

            object[] parameters = { areaId.ToString() };

            try
            {
                System.Data.DataTable data = dbProvider.ExecuteQuery(query, parameters);

                foreach (DataRow row in data.Rows)
                {
                    slots.Add(new ParkingSlotModel(
                        Guid.Parse(row["id"].ToString()),
                        Convert.ToInt32(row["slot_number"]),
                        row["slot_type"].ToString(),
                        row["status"].ToString().Trim(),
                        Guid.Parse(row["parking_area_id"].ToString())
                    ));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy danh sách vị trí đỗ: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }

            return slots;
        }
    }
}
