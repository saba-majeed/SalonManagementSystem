using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using SalonManagementSystem.Models;

namespace SalonManagementSystem.Database
{
    public class AppointmentRepository
    {
        // Returns all appointments with customer, staff and service names
        // Uses JOIN to get names instead of just IDs
        // Latest appointment shown first
        public List<Appointment> GetAll()
        {
            var list = new List<Appointment>();

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();

                // JOIN with Customers, Staff and Services to get their names
                string query = @"SELECT a.*,
                                        c.FullName    AS CustomerName,
                                        s.FullName    AS StaffName,
                                        sv.ServiceName
                                 FROM Appointments a
                                 LEFT JOIN Customers c  ON a.CustomerID = c.CustomerID
                                 LEFT JOIN Staff     s  ON a.StaffID    = s.StaffID
                                 LEFT JOIN Services  sv ON a.ServiceID  = sv.ServiceID
                                 ORDER BY a.AppointmentDate DESC";

                using (var cmd = new MySqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Appointment
                        {
                            AppointmentID = Convert.ToInt32(reader["AppointmentID"]),
                            CustomerID = Convert.ToInt32(reader["CustomerID"]),
                            StaffID = Convert.ToInt32(reader["StaffID"]),
                            ServiceID = Convert.ToInt32(reader["ServiceID"]),
                            AppointmentDate = Convert.ToDateTime(reader["AppointmentDate"]),
                            Status = reader["Status"].ToString(),
                            Notes = reader["Notes"].ToString(),
                            CustomerName = reader["CustomerName"].ToString(),
                            StaffName = reader["StaffName"].ToString(),
                            ServiceName = reader["ServiceName"].ToString()
                        });
                    }
                }
            }
            return list;
        }

        // Books a new appointment
        public bool Add(Appointment a)
        {
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string query = @"INSERT INTO Appointments
                                     (CustomerID, StaffID, ServiceID, AppointmentDate, Status, Notes)
                                     VALUES (@cid, @sid, @svid, @date, @status, @notes)";

                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@cid", a.CustomerID);
                        cmd.Parameters.AddWithValue("@sid", a.StaffID);
                        cmd.Parameters.AddWithValue("@svid", a.ServiceID);
                        cmd.Parameters.AddWithValue("@date", a.AppointmentDate);
                        cmd.Parameters.AddWithValue("@status", a.Status);
                        cmd.Parameters.AddWithValue("@notes", a.Notes);
                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch { return false; }
        }

        // Updates appointment status (Pending → Completed or Cancelled)
        public bool UpdateStatus(int appointmentID, string status)
        {
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string query = "UPDATE Appointments SET Status=@status WHERE AppointmentID=@id";

                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@status", status);
                        cmd.Parameters.AddWithValue("@id", appointmentID);
                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch { return false; }
        }

        // Deletes an appointment by ID
        public bool Delete(int appointmentID)
        {
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string query = "DELETE FROM Appointments WHERE AppointmentID=@id";

                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", appointmentID);
                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch { return false; }
        }
    }
}
