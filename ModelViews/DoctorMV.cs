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
