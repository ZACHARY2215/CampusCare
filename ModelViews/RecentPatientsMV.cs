using CampusCare.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using Microsoft.Data.SqlClient;

namespace CampusCare.ModelViews
{
    internal class RecentPatientsMV
    {
        public string connectionString;
        public List<RecentPatientModel> RecentPatients { get; set; } = new List<RecentPatientModel>();

        public RecentPatientsMV()
        {
            connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            LoadRecentPatients();
        }

        public void LoadRecentPatients()
        {
            RecentPatients.Clear();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT TOP 5 patient_id, first_name, last_name, date_registered FROM Patients ORDER BY date_registered DESC;";
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        RecentPatientModel patient = new RecentPatientModel
                        {
                            patient_id = reader.GetInt32(0),
                            first_name = reader.GetString(1),
                            last_name = reader.GetString(2),
                            date_registered = reader.GetDateTime(3)
                        };
                        RecentPatients.Add(patient);
                    }
                }
                connection.Close();
            }
        }
    }
}
