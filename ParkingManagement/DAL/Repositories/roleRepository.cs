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
    public class roleRepository
    {
        private readonly DatabaseProvider dbProvider = new DatabaseProvider();

        public List<roleModel> GetAllRoleAreas()
        {
            List<roleModel> roles = new List<roleModel>();
            string query = "SELECT * FROM role";
            DataTable data = dbProvider.ExecuteQuery(query);

            foreach (DataRow row in data.Rows)
            {
                roles.Add(new roleModel(
                    Guid.Parse(row["id"].ToString()),
                    row["role_name"].ToString(),
                    row["description"].ToString()
                ));
            }
            return roles;
        }

        public void InsertRole(roleModel role)
        {
            string query = "INSERT INTO role (id, role_name, description) VALUES (@id, @role_name, @description)";

            role.Id = Guid.NewGuid();

            object[] parameters =
            {
                role.Id.ToString(),
                role.RoleName ?? (object)DBNull.Value,
                role.Description ?? (object)DBNull.Value
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

        public void UpdateRole(roleModel role)
        {
            string query = "UPDATE role SET role_name = @role_name, description = @description WHERE id = @id";

            object[] parameters =
            {
            role.RoleName ?? (object)DBNull.Value,
            role.Description ?? (object)DBNull.Value,
            role.Id.ToString()
        };

            try
            {
                int rowsAffected = dbProvider.ExecuteNonQuery(query, parameters);

                if (rowsAffected == 0)
                {
                    MessageBox.Show("Không tìm thấy vai trò để cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật vai trò: " + ex.Message);
                throw;
            }
        }

        public void DeleteRole(Guid roleId)
        {
            string query = "DELETE FROM role WHERE id = @id";
            object[] parameters = { roleId.ToString() };

            try
            {
                dbProvider.ExecuteNonQuery(query, parameters);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xoá vai trò: " + ex.Message);
                throw;
            }
        }

    }
}
