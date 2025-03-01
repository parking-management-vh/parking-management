using System;
using System.Data;
using MySql.Data.MySqlClient;
using System.Configuration;  // 📌 Dùng để đọc App.config
using System.Text.RegularExpressions;

namespace ParkingManagement.DAL.Database
{
    class DatabaseProvider
    {
        private string connectDB = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;

        // SELECT - Trả về DataTable
        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();

            using (MySqlConnection connection = new MySqlConnection(connectDB))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    AddParameters(command, query, parameter);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    adapter.Fill(data);
                }
                connection.Close();
            }

            return data;
        }

        // INSERT, UPDATE, DELETE - Trả về số dòng bị ảnh hưởng
        public int ExecuteNonQuery(string query, object[] parameter = null)
        {
            int result = 0;
            using (MySqlConnection connection = new MySqlConnection(connectDB))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    AddParameters(command, query, parameter);
                    result = command.ExecuteNonQuery();
                }
                connection.Close();
            }
            return result;
        }

        // Lấy giá trị đơn
        public object ExecuteScalar(string query, object[] parameter = null)
        {
            object result = null;
            using (MySqlConnection connection = new MySqlConnection(connectDB))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    AddParameters(command, query, parameter);
                    result = command.ExecuteScalar();
                }
                connection.Close();
            }
            return result;
        }

        // Thêm tham số vào câu lệnh
        private void AddParameters(MySqlCommand command, string query, object[] parameter)
        {
            if (parameter != null)
            {
                MatchCollection matches = Regex.Matches(query, @"@\w+");
                int index = 0;

                foreach (Match match in matches)
                {
                    string paramName = match.Value;
                    object paramValue = parameter[index] ?? DBNull.Value;

                    command.Parameters.AddWithValue(paramName, paramValue);
                    index++;
                }
            }
        }
    }
}
