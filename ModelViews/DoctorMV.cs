using CampusCare.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace CampusCare.ModelViews
{
    internal class DoctorMV
    {
        public string connectionString;
        public List<DoctorModel> Doctors { get; set; } = new List<DoctorModel>();

        public DoctorMV()
        {
            connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            LoadDoctors();
        }
        public void AddDoctor(DoctorModel doctor)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"
                    INSERT INTO Doctors
                    (first_name, last_name, email, role, contact_number, status)
                    VALUES
                    (@FirstName, @LastName, @Email, @Role, @ContactNumber, @Status);";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@FirstName", doctor.first_name);
                command.Parameters.AddWithValue("@LastName", doctor.last_name);
                command.Parameters.AddWithValue("@Email", doctor.email);
                command.Parameters.AddWithValue("@Role", doctor.role);
                command.Parameters.AddWithValue("@ContactNumber", doctor.contact_number);
                command.Parameters.AddWithValue("@Status", doctor.status);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }

        }
        public void DeleteDoctorById(int doctor_id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"
                    DELETE FROM Doctors WHERE doctor_id = @doctor_id";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@doctor_id", doctor_id);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }


        }
        public void UpdateDoctor(DoctorModel doctor)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"
                    UPDATE Doctors SET
                        first_name = @FirstName,
                        last_name = @LastName,
                        email = @Email,
                        role = @Role,
                        contact_number = @ContactNumber,
                        status = @Status
                    WHERE doctor_id = @DoctorId;";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@FirstName", doctor.first_name);
                command.Parameters.AddWithValue("@LastName", doctor.last_name);
                command.Parameters.AddWithValue("@Email", doctor.email);
                command.Parameters.AddWithValue("@Role", doctor.role);
                command.Parameters.AddWithValue("@ContactNumber", doctor.contact_number);
                command.Parameters.AddWithValue("@Status", doctor.status);
                command.Parameters.AddWithValue("@DoctorId", doctor.doctor_id);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

                // Update the patient in the Patients list
                var existingDoctor = Doctors.Find(p => p.doctor_id == doctor.doctor_id);
                if (existingDoctor != null)
                {
                    int index = Doctors.IndexOf(existingDoctor);
                    Doctors[index] = doctor;
                }
            }
        }
        public void LoadDoctors()
        {
            Doctors.Clear();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Doctors;";
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    DoctorModel doctor = new DoctorModel
                    {
                        doctor_id = reader.GetInt32(0),
                        first_name = reader.GetString(1),
                        last_name = reader.GetString(2),
                        email = reader.GetString(3),
                        role = reader.GetString(4),
                        contact_number = reader.GetInt64(5),
                        status = reader.GetString(6)
                    };
                    Doctors.Add(doctor);
                }
                connection.Close();
            }
        }
    }
}
