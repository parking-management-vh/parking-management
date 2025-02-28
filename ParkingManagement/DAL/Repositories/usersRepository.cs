using MySql.Data.MySqlClient;
using ParkingManagement.DAL.Database;
using ParkingManagement.Models;
using ParkingManagement.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ParkingManagement.Models.allUserModel;

namespace ParkingManagement.DAL.Repositories
{
    class userRepository
    {
        private readonly DatabaseProvider dbProvider = new DatabaseProvider();

        public (List<allUserModel>, int) GetUsersByPage(
            int page, 
            int pageSize, 
            bool? status = null, 
            string roleName = null,
            string areaName = null, 
            string searchColumn = null, 
            string searchValue = null)
        {
            List<allUserModel> users = new List<allUserModel>();
            int totalRecords = 0;
            int offset = Pagination.CalculateOffset(page, pageSize);

            string whereClause = "WHERE 1=1";
            List<MySqlParameter> parameters = new List<MySqlParameter>();

            if (status.HasValue)
            {
                whereClause += " AND u.status = @status";
                parameters.Add(new MySqlParameter("@status", status.Value ? 1 : 0));
            }
            if (!string.IsNullOrEmpty(roleName))
            {
                whereClause += " AND r.role_name = @roleName";
                parameters.Add(new MySqlParameter("@roleName", roleName));
            }
            if (!string.IsNullOrEmpty(areaName))
            {
                whereClause += " AND pa.area_name = @areaName";
                parameters.Add(new MySqlParameter("@areaName", areaName));
            }
            if (!string.IsNullOrEmpty(searchColumn) && !string.IsNullOrEmpty(searchValue))
            {
                string[] validColumns = { "code", "full_name", "phone_number", "email" };
                if (validColumns.Contains(searchColumn))
                {
                    whereClause += $" AND `{searchColumn}` LIKE '%{searchValue}%'";
                    parameters.Add(new MySqlParameter("@searchValue", $"%{searchValue}%"));
                }
            }

            string query = $@"
                SELECT 
                    u.id, u.code, u.full_name, u.date_of_birth, 
                    u.gender, u.phone_number, u.email, u.address, 
                    u.status, pa.area_name AS area_name, 
                    r.role_name AS role_name, COUNT(*) OVER() AS total_count
                FROM `user` u
                LEFT JOIN `parking_area` pa ON u.area_id = pa.id            
                LEFT JOIN `role` r ON u.role_id = r.id
                {whereClause}
                LIMIT {pageSize} OFFSET {offset}";

                    DataTable data = dbProvider.ExecuteQuery(query, parameters.ToArray());

                    string countQuery = $@"
                SELECT COUNT(*) FROM `user` u
                LEFT JOIN `parking_area` pa ON u.area_id = pa.id
                LEFT JOIN `role` r ON u.role_id = r.id
                {whereClause}";

            DataTable totalData = dbProvider.ExecuteQuery(countQuery, parameters.ToArray());

            if (totalData.Rows.Count > 0)
            {
                totalRecords = Convert.ToInt32(totalData.Rows[0][0]);
            }

            foreach (DataRow row in data.Rows)
            {
                users.Add(new allUserModel(
                    row["code"].ToString(),
                    row["full_name"].ToString(),
                    row["date_of_birth"] != DBNull.Value ? Convert.ToDateTime(row["date_of_birth"]) : (DateTime?)null,
                    row["gender"].ToString(),
                    row["phone_number"].ToString(),
                    row["email"].ToString(),
                    row["address"].ToString(),
                    row["area_name"] != DBNull.Value ? row["area_name"].ToString() : "Chưa có khu vực",
                    Guid.Parse(row["id"].ToString()),
                    row["role_name"].ToString(),
                    Convert.ToBoolean(row["status"])
                ));
            }

            int totalPages = (int)Math.Ceiling((double)totalRecords / pageSize);
            return (users, totalPages);
        }


    }

}
