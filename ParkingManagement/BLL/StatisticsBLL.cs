using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using ParkingManagement.DAL.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingManagement.BLL
{
    public class StatisticsBLL
    {
        private DatabaseHelper dbHelper = new DatabaseHelper();
        public DataTable GetRoles()
        {
            string query = "SELECT id, role_name FROM role;";
            return dbHelper.ExecuteQuery(query);
        }
        public DataTable GetRevenueStatistics()
        {
            string query = "SELECT DATE(payment_date) AS date, SUM(total_price) AS revenue " +
                           "FROM payment_receipt GROUP BY DATE(payment_date) ORDER BY date;";
            return dbHelper.ExecuteQuery(query);
        }

        public DataTable GetVehicleTraffic()
        {
            string query = "SELECT DATE(entry_time) AS date, COUNT(id) AS vehicle_count " +
                           "FROM vehicle GROUP BY DATE(entry_time) ORDER BY date;";
            return dbHelper.ExecuteQuery(query);
        }

        public DataTable GetParkingSlotStatus()
        {
            string query = "SELECT slot_type, COUNT(id) AS count FROM parking_slot GROUP BY slot_type;";
            return dbHelper.ExecuteQuery(query);
        }

        public DataTable GetParkingCards()
        {
            string query = "SELECT status, COUNT(id) AS count FROM parking_card GROUP BY status;";
            return dbHelper.ExecuteQuery(query);
        }

        public DataTable GetEmployeeAndCustomerReport()
        {
            string query = "SELECT role_id, COUNT(id) AS count FROM user GROUP BY role_id;";
            return dbHelper.ExecuteQuery(query);
        }

        // 1. Lấy tổng doanh thu theo loại phương tiện
        public DataTable GetRevenueByType()
        {
            string query = "SELECT vehicle_type, SUM(total_price) AS revenue FROM payment_receipt GROUP BY vehicle_type;";
            return dbHelper.ExecuteQuery(query);
        }

        // 2. Lấy tổng số lượt vào
        public int GetTotalEntries()
        {
            string query = "SELECT COUNT(id) FROM vehicle;";
            return Convert.ToInt32(dbHelper.ExecuteQuery(query).Rows[0][0]);
        }

        // 3. Lấy tổng số lượt ra
        public int GetTotalExits()
        {
            string query = "SELECT COUNT(id) FROM vehicle WHERE exit_time IS NOT NULL;";
            return Convert.ToInt32(dbHelper.ExecuteQuery(query).Rows[0][0]);
        }

        // 4. Lấy số lượng xe tồn đầu kỳ
        public int GetInitialStock()
        {
            string query = "SELECT COUNT(id) FROM vehicle WHERE entry_time < CURRENT_DATE;";
            return Convert.ToInt32(dbHelper.ExecuteQuery(query).Rows[0][0]);
        }

        // 5. Lấy số lượng xe tồn hiện tại
        public int GetCurrentStock()
        {
            string query = "SELECT COUNT(id) FROM vehicle WHERE exit_time IS NULL;";
            return Convert.ToInt32(dbHelper.ExecuteQuery(query).Rows[0][0]);
        }

        // 6. Thống kê lượt vào theo tháng
        public DataTable GetMonthlyEntries()
        {
            string query = "SELECT MONTH(entry_time) AS month, COUNT(id) AS total FROM vehicle GROUP BY MONTH(entry_time);";
            return dbHelper.ExecuteQuery(query);
        }

        // 7. Thống kê lượt ra theo tháng
        public DataTable GetMonthlyExits()
        {
            string query = "SELECT MONTH(exit_time) AS month, COUNT(id) AS total FROM vehicle WHERE exit_time IS NOT NULL GROUP BY MONTH(exit_time);";
            return dbHelper.ExecuteQuery(query);
        }

        // 8. Số xe tồn đầu tháng
        public int GetMonthlyInitialStock()
        {
            string query = "SELECT COUNT(id) FROM vehicle WHERE entry_time < DATE_FORMAT(CURDATE(), '%Y-%m-01');";
            return Convert.ToInt32(dbHelper.ExecuteQuery(query).Rows[0][0]);
        }

        // 9. Số xe tồn cuối tháng
        public int GetMonthlyCurrentStock()
        {
            string query = "SELECT COUNT(id) FROM vehicle WHERE exit_time IS NULL;";
            return Convert.ToInt32(dbHelper.ExecuteQuery(query).Rows[0][0]);
        }

        // 10. Thống kê lượt vào của khách vãng lai
        public DataTable GetGuestEntries(DateTime fromDate, DateTime toDate)
        {
            string query = "SELECT DATE(entry_time) AS date, COUNT(id) AS total " +
                           "FROM vehicle WHERE customer_type = 'guest' AND DATE(entry_time) BETWEEN @fromDate AND @toDate " +
                           "GROUP BY DATE(entry_time);";

            MySqlParameter[] parameters = {
                new MySqlParameter("@fromDate", MySqlDbType.Date) { Value = fromDate },
                new MySqlParameter("@toDate", MySqlDbType.Date) { Value = toDate }
            };

            return dbHelper.ExecuteQuery(query, parameters);
        }

        // 11. Thống kê lượt ra của khách vãng lai
        public DataTable GetGuestExits()
        {
            string query = "SELECT DATE(exit_time) AS date, COUNT(id) AS total FROM vehicle WHERE customer_type = 'guest' AND exit_time IS NOT NULL GROUP BY DATE(exit_time);";
            return dbHelper.ExecuteQuery(query);
        }

        // 12. Số xe khách vãng lai tồn đầu kỳ
        public int GetGuestInitialStock()
        {
            string query = "SELECT COUNT(id) FROM vehicle WHERE customer_type = 'guest' AND entry_time < CURRENT_DATE;";
            return Convert.ToInt32(dbHelper.ExecuteQuery(query).Rows[0][0]);
        }

        // 13. Số xe khách vãng lai tồn hiện tại
        public int GetGuestCurrentStock()
        {
            string query = "SELECT COUNT(id) FROM vehicle WHERE customer_type = 'guest' AND entry_time < CURRENT_DATE;";
            DataTable dt = dbHelper.ExecuteQuery(query);

            return (dt.Rows.Count > 0 && dt.Rows[0][0] != DBNull.Value) ? Convert.ToInt32(dt.Rows[0][0]) : 0;
        }
        /*        // 14. Thống kê tổng quan bãi đỗ
                public DataTable GetParkingStatistics()
                {
                    string query = "SELECT (SELECT COUNT(id) FROM vehicle WHERE exit_time IS NULL) AS CurrentStock, " +
                                   "(SELECT COUNT(id) FROM vehicle WHERE exit_time IS NOT NULL) AS TotalExits, " +
                                   "(SELECT COUNT(id) FROM vehicle) AS TotalEntries;";
                    return dbHelper.ExecuteQuery(query);
                }*/
        // Lấy số xe đang đỗ trong từng khu vực
        public DataTable GetCurrentParkedVehicles()
        {
            string query = "SELECT parking_area_id, COUNT(id) AS total_vehicles " +
                           "FROM vehicle WHERE exit_time IS NULL " +
                           "GROUP BY parking_area_id;";
            return dbHelper.ExecuteQuery(query);
        }

        // Lấy số chỗ trống trong từng khu vực
        public DataTable GetEmptyParkingSlots()
        {
            string query = "SELECT parking_area_id, COUNT(id) AS empty_slots " +
                           "FROM parking_slot WHERE status = 'Sẵn sàng' " +
                           "GROUP BY parking_area_id;";
            return dbHelper.ExecuteQuery(query);
        }
        public DataTable GetParkingStatistics()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Loại Xe", typeof(string));
            dt.Columns.Add("Doanh Thu", typeof(decimal));
            dt.Columns.Add("Tổng Vào", typeof(int));
            dt.Columns.Add("Tổng Ra", typeof(int));
            dt.Columns.Add("Tồn Đầu", typeof(int));
            dt.Columns.Add("Tồn", typeof(int));
            dt.Columns.Add("Tổng Tồn", typeof(int));
            dt.Columns.Add("Vé Tháng Vào", typeof(int));
            dt.Columns.Add("Vé Tháng Ra", typeof(int));
            dt.Columns.Add("Vé Tháng Tồn Đầu", typeof(int));
            dt.Columns.Add("Vé Tháng Tồn", typeof(int));
            dt.Columns.Add("Vé Tháng Tổng Tồn", typeof(int));
            dt.Columns.Add("Vãng Lai Vào", typeof(int));
            dt.Columns.Add("Vãng Lai Ra", typeof(int));
            dt.Columns.Add("Vãng Lai Tồn Đầu", typeof(int));
            dt.Columns.Add("Vãng Lai Tồn", typeof(int));
            dt.Columns.Add("Vãng Lai Tổng Tồn", typeof(int));

            string query = @"

            SELECT vt.vehicle_type_name AS vehicle_type,
                   DATE(v.entry_time) AS date,
                   COALESCE(SUM(pr.total_price), 0) AS revenue,
                   COUNT(v.id) AS total_entries,
                   SUM(CASE WHEN v.exit_time IS NOT NULL THEN 1 ELSE 0 END) AS total_exits,
                   SUM(CASE WHEN v.entry_time < CURDATE() THEN 1 ELSE 0 END) AS initial_stock,
                   SUM(CASE WHEN v.exit_time IS NULL THEN 1 ELSE 0 END) AS current_stock,
                   -- Vé tháng
                   SUM(CASE WHEN pc.is_month = 1 THEN 1 ELSE 0 END) AS monthly_entries,
                   SUM(CASE WHEN pc.is_month = 1 AND v.exit_time IS NOT NULL THEN 1 ELSE 0 END) AS monthly_exits,
                   SUM(CASE WHEN pc.is_month = 1 AND v.entry_time < CURDATE() THEN 1 ELSE 0 END) AS monthly_initial_stock,
                   SUM(CASE WHEN pc.is_month = 1 AND v.exit_time IS NULL THEN 1 ELSE 0 END) AS monthly_current_stock,
                   -- Vãng lai
                   SUM(CASE WHEN pc.is_month = 0 THEN 1 ELSE 0 END) AS guest_entries,
                   SUM(CASE WHEN pc.is_month = 0 AND v.exit_time IS NOT NULL THEN 1 ELSE 0 END) AS guest_exits,
                   SUM(CASE WHEN pc.is_month = 0 AND v.entry_time < CURDATE() THEN 1 ELSE 0 END) AS guest_initial_stock,
                   SUM(CASE WHEN pc.is_month = 0 AND v.exit_time IS NULL THEN 1 ELSE 0 END) AS guest_current_stock
            FROM vehicle v
            LEFT JOIN vehicle_type vt ON v.vehicle_type_id = vt.id
            LEFT JOIN payment_receipt pr ON v.id = pr.vehicle_id
            LEFT JOIN parking_card pc ON v.id = pc.vehicle_id
            GROUP BY vt.vehicle_type_name, DATE(v.entry_time)
            ORDER BY DATE(v.entry_time);";


            DataTable result = dbHelper.ExecuteQuery(query);

            foreach (DataRow row in result.Rows)
            {
                DataRow newRow = dt.NewRow();

                // Kiểm tra dòng tổng (WHEN ROLLUP tạo NULL cho vehicle_type)
                string vehicleType = row["vehicle_type"] == DBNull.Value ? "Tổng" : row["vehicle_type"].ToString();

                newRow["Loại Xe"] = vehicleType;
                newRow["Loại Xe"] = row["vehicle_type"].ToString();
                newRow["Doanh Thu"] = Convert.ToDecimal(row["revenue"]);
                newRow["Tổng Vào"] = Convert.ToInt32(row["total_entries"]);
                newRow["Tổng Ra"] = Convert.ToInt32(row["total_exits"]);
                newRow["Tồn Đầu"] = Convert.ToInt32(row["initial_stock"]);
                newRow["Tồn"] = Convert.ToInt32(row["current_stock"]);
                newRow["Tổng Tồn"] = Convert.ToInt32(newRow["Tồn Đầu"]) + Convert.ToInt32(newRow["Tồn"]);

                newRow["Vé Tháng Vào"] = Convert.ToInt32(row["monthly_entries"]);
                newRow["Vé Tháng Ra"] = Convert.ToInt32(row["monthly_exits"]);
                newRow["Vé Tháng Tồn Đầu"] = Convert.ToInt32(row["monthly_initial_stock"]);
                newRow["Vé Tháng Tồn"] = Convert.ToInt32(row["monthly_current_stock"]);
                newRow["Vé Tháng Tổng Tồn"] = Convert.ToInt32(newRow["Vé Tháng Tồn Đầu"]) + Convert.ToInt32(newRow["Vé Tháng Tồn"]);

                newRow["Vãng Lai Vào"] = Convert.ToInt32(row["guest_entries"]);
                newRow["Vãng Lai Ra"] = Convert.ToInt32(row["guest_exits"]);
                newRow["Vãng Lai Tồn Đầu"] = Convert.ToInt32(row["guest_initial_stock"]);
                newRow["Vãng Lai Tồn"] = Convert.ToInt32(row["guest_current_stock"]);
                newRow["Vãng Lai Tổng Tồn"] = Convert.ToInt32(newRow["Vãng Lai Tồn Đầu"]) + Convert.ToInt32(newRow["Vãng Lai Tồn"]);

                dt.Rows.Add(newRow);
            }

            // Thêm dòng tổng cộng
            DataRow totalRow = dt.NewRow();
            totalRow["Loại Xe"] = "Tổng";
            foreach (DataColumn col in dt.Columns)
            {
                if (col.DataType == typeof(int) || col.DataType == typeof(decimal))
                {
                    totalRow[col.ColumnName] = dt.AsEnumerable().Sum(row => row.Field<object>(col.ColumnName) == DBNull.Value ? 0 : Convert.ToDecimal(row[col.ColumnName]));
                }
            }
            dt.Rows.Add(totalRow);

            return dt;
        }
        public DataTable GetCurrentParkedVehicles(DateTime fromDate, DateTime toDate)
        {
            string query = "SELECT parking_area_id, COUNT(id) AS total_vehicles " +
                           "FROM vehicle WHERE exit_time IS NULL AND DATE(entry_time) BETWEEN @fromDate AND @toDate " +
                           "GROUP BY parking_area_id;";

            MySqlParameter[] parameters = {
                new MySqlParameter("@fromDate", MySqlDbType.Date) { Value = fromDate },
                new MySqlParameter("@toDate", MySqlDbType.Date) { Value = toDate }
            };

            return dbHelper.ExecuteQuery(query, parameters);
        }

        public DataTable GetEmptyParkingSlots(DateTime fromDate, DateTime toDate)
        {
            string query = "SELECT parking_area_id, COUNT(id) AS empty_slots " +
                           "FROM parking_slot WHERE status = 'Sẵn sàng' " +
                           "GROUP BY parking_area_id;";

            MySqlParameter[] parameters = {
                new MySqlParameter("@fromDate", MySqlDbType.Date) { Value = fromDate },
                new MySqlParameter("@toDate", MySqlDbType.Date) { Value = toDate }
            };

            return dbHelper.ExecuteQuery(query, parameters);
        }

        public int GetTotalEntries(DateTime fromDate, DateTime toDate)
        {
            string query = "SELECT COUNT(id) FROM vehicle WHERE DATE(entry_time) BETWEEN @fromDate AND @toDate;";
            MySqlParameter[] parameters = {
                new MySqlParameter("@fromDate", MySqlDbType.Date) { Value = fromDate },
                new MySqlParameter("@toDate", MySqlDbType.Date) { Value = toDate }
            };
            DataTable dt = dbHelper.ExecuteQuery(query, parameters);
            return dt.Rows.Count > 0 ? Convert.ToInt32(dt.Rows[0][0]) : 0;
        }

        public int GetTotalExits(DateTime fromDate, DateTime toDate)
        {
            string query = "SELECT COUNT(id) FROM vehicle WHERE exit_time IS NOT NULL AND DATE(exit_time) BETWEEN @fromDate AND @toDate;";
            MySqlParameter[] parameters = {
                new MySqlParameter("@fromDate", MySqlDbType.Date) { Value = fromDate },
                new MySqlParameter("@toDate", MySqlDbType.Date) { Value = toDate }
            };
            DataTable dt = dbHelper.ExecuteQuery(query, parameters);
            return dt.Rows.Count > 0 ? Convert.ToInt32(dt.Rows[0][0]) : 0;
        }

        public int GetInitialStock(DateTime fromDate, DateTime toDate)
        {
            string query = "SELECT COUNT(id) FROM vehicle WHERE entry_time < @fromDate AND DATE(exit_time) IS NULL;";
            MySqlParameter[] parameters = {
                new MySqlParameter("@fromDate", MySqlDbType.Date) { Value = fromDate }
            };
            DataTable dt = dbHelper.ExecuteQuery(query, parameters);
            return dt.Rows.Count > 0 ? Convert.ToInt32(dt.Rows[0][0]) : 0;
        }

        public int GetCurrentStock(DateTime fromDate, DateTime toDate)
        {
            string query = "SELECT COUNT(id) FROM vehicle WHERE exit_time IS NULL AND DATE(entry_time) BETWEEN @fromDate AND @toDate;";
            MySqlParameter[] parameters = {
                new MySqlParameter("@fromDate", MySqlDbType.Date) { Value = fromDate },
                new MySqlParameter("@toDate", MySqlDbType.Date) { Value = toDate }
            };
            DataTable dt = dbHelper.ExecuteQuery(query, parameters);
            return dt.Rows.Count > 0 ? Convert.ToInt32(dt.Rows[0][0]) : 0;
        }
        public DataTable GetRevenueStatisticsByVehicleType(DateTime fromDate, DateTime toDate)
        {
            string query = @"SELECT 
                            vt.vehicle_type_name AS vehicle_type,
                            DATE(pr.payment_date) AS date,
                            SUM(pr.total_price) AS revenue
                         FROM payment_receipt pr
                         LEFT JOIN vehicle v ON pr.vehicle_id = v.id
                         LEFT JOIN vehicle_type vt ON v.vehicle_type_id = vt.id
                         WHERE DATE(pr.payment_date) BETWEEN @fromDate AND @toDate
                         GROUP BY vt.vehicle_type_name, DATE(pr.payment_date)
                         ORDER BY DATE(pr.payment_date), vt.vehicle_type_name;";

            MySqlParameter[] parameters = {
            new MySqlParameter("@fromDate", MySqlDbType.Date) { Value = fromDate },
            new MySqlParameter("@toDate", MySqlDbType.Date) { Value = toDate }
        };

            return dbHelper.ExecuteQuery(query, parameters);
        }
    }
}
