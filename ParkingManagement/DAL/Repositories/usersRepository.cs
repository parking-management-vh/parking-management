using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using ParkingManagement.BLL;
using ParkingManagement.DAL.Database;
using ParkingManagement.GUI.Forms;
using ParkingManagement.Models;
using ParkingManagement.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ParkingManagement.Models.allUserModel;

namespace ParkingManagement.DAL.Repositories
{
    class userRepository
    {
        private readonly DatabaseProvider dbProvider = new DatabaseProvider();

        private string HashPassword(string password)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2")); // Convert byte to hex string
                }
                return builder.ToString();
            }
        }

        public createUser LoginUser(string code, string password)
        {
            string hashedInputPassword = HashPassword(password);
            string query = @"
                SELECT u.id, u.code, u.full_name, u.date_of_birth, u.gender, 
                       u.phone_number, u.email, u.address, u.password, 
                       u.role_id, r.role_name, 
                       u.area_id, p.area_name, 
                       u.created_at, u.updated_at, u.status
                FROM user u
                LEFT JOIN role r ON u.role_id = r.id
                LEFT JOIN parking_area p ON u.area_id = p.id
                WHERE u.code = @code AND u.password = @password AND u.status = 1";

            try
            {
                object[] parameters = {
                    new MySqlParameter("@code", code),
                    new MySqlParameter("@password", hashedInputPassword)
                };

                DataTable data = dbProvider.ExecuteQuery(query, parameters);

                if (data.Rows.Count > 0)
                {
                    DataRow row = data.Rows[0];
                    createUser user = new createUser
                    {
                        Id = Guid.Parse(row["id"].ToString()),
                        Code = row["code"].ToString(),
                        FullName = row["full_name"].ToString(),
                        DateOfBirth = row["date_of_birth"] != DBNull.Value ? Convert.ToDateTime(row["date_of_birth"]) : (DateTime?)null,
                        Gender = row["gender"].ToString(),
                        PhoneNumber = row["phone_number"].ToString(),
                        Email = row["email"].ToString(),
                        Address = row["address"].ToString(),
                        Password = row["password"].ToString(),
                        RoleId = row["role_id"] != DBNull.Value ? Guid.Parse(row["role_id"].ToString()) : (Guid?)null,
                        AreaId = row["area_id"] != DBNull.Value ? Guid.Parse(row["area_id"].ToString()) : (Guid?)null,
                        AreaName = row["area_name"] != DBNull.Value ? row["area_name"].ToString() : "Không có khu vực",
                        Role = row["role_name"] != DBNull.Value ? row["role_name"].ToString() : "Không có role",
                        CreatedAt = Convert.ToDateTime(row["created_at"]),
                        UpdatedAt = Convert.ToDateTime(row["updated_at"]),
                        Status = Convert.ToBoolean(row["status"])
                    };

                    string roleName = row["role_name"] != DBNull.Value ? row["role_name"].ToString() : null;
                    string areaName = row["area_name"] != DBNull.Value ? row["area_name"].ToString() : null;

                    SessionManager.SetUser(user);

                    return user;
                }
                else
                {
                    MessageBox.Show("⚠️ No User Found!", "Debug User");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"❌ Error: {ex.Message}", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return null;
        }


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


        public void AddUser(createUser user)
        {
            string query = @"
                INSERT INTO user (id, code, full_name, gender, date_of_birth, area_id, email, phone_number, address, role_id, status, password) 
                VALUES (@id, @code, @full_name, @gender, @date_of_birth, @area_id, @email, @phone_number, @address, @role_id, @status, @password)";

            user.Id = Guid.NewGuid();

            object[] parameters =
            {
                user.Id.ToString(),
                user.Code ?? (object)DBNull.Value,
                user.FullName ?? (object)DBNull.Value,
                user.Gender ?? (object)DBNull.Value,
                user.DateOfBirth?.ToString("yyyy-MM-dd") ?? (object)DBNull.Value,
                user.AreaId?.ToString() ?? (object)DBNull.Value,
                user.Email ?? (object)DBNull.Value,
                user.PhoneNumber ?? (object)DBNull.Value,
                user.Address ?? (object)DBNull.Value,
                user.RoleId?.ToString() ?? (object)DBNull.Value,
                user.Status ? 1 : 0,
                user.Password ?? (object)DBNull.Value
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


        public bool UpdateUser(createUser user)
        {
            string query = @"
                UPDATE user
                SET code = @Code,  
                    full_name = @FullName, 
                    date_of_birth = @DateOfBirth,
                    gender = @Gender,
                    phone_number = @PhoneNumber, 
                    email = @Email, 
                    address = @Address, 
                    password = @Password,
                    role_id = @RoleId, 
                    area_id = @AreaId, 
                    status = @Status,
                    updated_at = @UpdatedAt
                WHERE id = @Id";

            object[] parameters = {
                user.Code, user.FullName, user.DateOfBirth, user.Gender,
                user.PhoneNumber, user.Email, user.Address,
                user.Password, user.RoleId?.ToString(),
                user.AreaId?.ToString(), user.Status,
                user.UpdatedAt, user.Id 
            };

            try
            {
                int rowsAffected = dbProvider.ExecuteNonQuery(query, parameters);
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật user: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool DeleteUserByCode(string userCode)
        {
            string query = "DELETE FROM user WHERE code = @code";

            object[] parameters = { userCode };

            try
            {
                int rowsAffected = dbProvider.ExecuteNonQuery(query, parameters);
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa user: " + ex.Message);
                return false;
            }
        }

        public Guid? GetUserIdByCode(string userCode)
        {
            string query = "SELECT id FROM user WHERE code = @userCode";
            object[] parameters = { userCode };

            DataTable data = dbProvider.ExecuteQuery(query, parameters);

            if (data.Rows.Count > 0 && Guid.TryParse(data.Rows[0]["id"].ToString(), out Guid userId))
            {
                return userId; 
            }

            return null; 
        }
    }

}
