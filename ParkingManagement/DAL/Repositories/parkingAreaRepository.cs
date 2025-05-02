using Microsoft.Office.Interop.Excel;
using MySql.Data.MySqlClient;
using ParkingManagement.DAL.Database;
using ParkingManagement.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ParkingManagement.DAL.Repositories
{
    public class ParkingAreaRepository
    {
        private readonly DatabaseProvider dbProvider = new DatabaseProvider();

        // Lấy danh sách tất cả khu vực
        public List<parkingAreaModel> GetAllParkingAreas(string status = null)
        {
            List<parkingAreaModel> areas = new List<parkingAreaModel>();
            string query = "SELECT * FROM parking_area WHERE 1=1"; 

            List<MySqlParameter> parameters = new List<MySqlParameter>();

            if (!string.IsNullOrEmpty(status) && status != "Tất cả")
            {
                query += " AND status = @status"; 
                parameters.Add(new MySqlParameter("@status", status));
            }

            System.Data.DataTable data = dbProvider.ExecuteQuery(query, parameters.ToArray());

            foreach (DataRow row in data.Rows)
            {
                areas.Add(new parkingAreaModel(
                    row["id"].ToString(),
                    row["status"].ToString(),
                    row["area_name"].ToString(),
                    row["description"].ToString()
                ));
            }
            return areas;
        }

        // Lấy khu vực theo ID
        //public parkingAreaModel GetParkingAreaById(string id)
        //{
        //    string query = "SELECT * FROM parking_area WHERE id = @id";
        //    var parameters = new Dictionary<string, object> { { "@id", id } };
        //    DataTable data = dbProvider.ExecuteQuery(query, parameters);

        //    if (data.Rows.Count > 0)
        //    {
        //        DataRow row = data.Rows[0];
        //        return new parkingAreaModel(
        //            row["id"].ToString(),
        //            row["status"].ToString(),
        //            row["area_name"].ToString(),
        //            row["description"].ToString()
        //        );
        //    }
        //    return null;
        //}

        // Thêm khu vực mới
        public void CreateParkingArea(parkingAreaModel area)
        {
            try
            {
                string query = "INSERT INTO parking_area (id, status, area_name, description) VALUES (@id, @status, @area_name, @description)";
                object[] parameters =
            {
                area.Id.ToString(),
                area.Status ?? (object)DBNull.Value,
                area.AreaName ?? (object)DBNull.Value,
                area.Description ?? (object)DBNull.Value
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
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi thêm khu vực: {ex.Message}");
            }
        }

        // Cập nhật thông tin khu vực
        public void UpdateParkingArea(parkingAreaModel area)
        {
            try
            {
                string query = "UPDATE parking_area SET status = @status, area_name = @area_name, description = @description WHERE id = @id";
                object[] parameters =
            {
                area.Id.ToString(),
                area.Status ?? (object)DBNull.Value,
                area.AreaName ?? (object)DBNull.Value,
                area.Description ?? (object)DBNull.Value
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
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi cập nhật khu vực: {ex.Message}");
            }
        }

        // Xóa khu vực
        public void DeleteParkingArea(string id)
        {
            try
            {
                string query = "DELETE FROM parking_area WHERE id = @id";
                object[] parameters =
                {
                    id.ToString(),
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
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi xóa khu vực: {ex.Message}");
            }
        }
    }
}
