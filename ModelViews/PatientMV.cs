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
    internal class PatientMV
    {
        private string connectionString;
        public List<PatientModel> Patients { get; set; } = new List<PatientModel>();

        public PatientMV() 
        {
            connectionString = ConfigurationManager.ConnectionStrings["DefaultConection"].ConnectionString;
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
                        patient_id = reader.GetInt32(0),
                        first_name= reader.GetString(1),
                        last_name = reader.GetString(2),
                        birth_date = reader.GetDateTime(3),
                        gender = reader.GetString(4),
                        student_or_staff = reader.GetString(5),
                        id_number = reader.GetInt32(6),
                        grade_or_department = reader.GetString(7),
                        contact_number = reader.GetInt32(8),    
                        date_registered = reader.GetDateTime(9)
                    };
                    Patients.Add(student);
                }
                connection.Close();
            }
        }
    }
}
