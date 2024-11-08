using CampusCare.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampusCare.ModelViews
{
    public class AdministratorMV
    {
        public string connectionString;
        public List<AdministratorModel> Administrators { get; set; } = new List<AdministratorModel>();

        public AdministratorMV()
        {
            connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            LoadAdministrators();
        }

        public void LoadAdministrators()
        {
            Administrators.Clear();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Administrator;";
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    AdministratorModel admin = new AdministratorModel
                    {
                        admin_id = reader.GetInt32(0),
                        username = reader.GetString(1),
                        password = reader.GetString(2),
                    };
                    Administrators.Add(admin);
                }
                connection.Close();
            }
        }
        public void UpdateAdminPassword(string password)
        {
            AdministratorModel administrator = Administrators[0];
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"
                    UPDATE administrator SET
                        pass_word = @newPassword
                    Where admin_id = 1";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@newPassword", password);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

            }
        }
    }
}
