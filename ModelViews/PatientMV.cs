using CampusCare.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Diagnostics;

namespace CampusCare.ModelViews
{
    internal class PatientMV
    {
        public string connectionString;
        public List<PatientModel> Patients { get; set; } = new List<PatientModel>();

        public PatientMV() 
        {
            connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            LoadPatients();
        }

        public void LoadPatients()
        {
            Patients.Clear();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "Select * from Patients;";
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    PatientModel student = new PatientModel
                    {
                        patient_id = reader.IsDBNull(0) ? 0 : reader.GetInt32(0),
                        first_name = reader.IsDBNull(1) ? string.Empty : reader.GetString(1),
                        last_name = reader.IsDBNull(2) ? string.Empty : reader.GetString(2),
                        birth_date = reader.IsDBNull(3) ? DateTime.MinValue : reader.GetDateTime(3),
                        gender = reader.IsDBNull(4) ? string.Empty : reader.GetString(4),
                        student_or_staff = reader.IsDBNull(5) ? string.Empty : reader.GetString(5),
                        id_number = reader.IsDBNull(6) ? 0 : reader.GetInt32(6),
                        grade_or_department = reader.IsDBNull(7) ? string.Empty : reader.GetString(7),
                        contact_number = reader.IsDBNull(8) ? 0 : reader.GetInt64(8),
                        date_registered = reader.IsDBNull(9) ? DateTime.MinValue : reader.GetDateTime(9)
                    };
                    Patients.Add(student);
                }
                connection.Close();
            }
        }
    }
}
