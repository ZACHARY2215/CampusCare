using System;
using System.Collections.Generic;
using System.Configuration;
using Microsoft.Data.SqlClient;
using CampusCare.Models;

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
                string query = "SELECT * FROM Patients;";
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    PatientModel patient = new PatientModel
                    {
                        patient_id = reader.GetInt32(0),
                        first_name = reader.GetString(1),
                        last_name = reader.GetString(2),
                        birth_date = reader.GetDateTime(3),
                        gender = reader.GetString(4),
                        student_or_staff = reader.GetString(5),
                        id_number = reader.GetInt32(6),
                        grade_or_department = reader.GetString(7),
                        contact_number = reader.GetInt64(8),
                        date_registered = reader.GetDateTime(9)
                    };
                    Patients.Add(patient);
                }
                connection.Close();
            }
        }

        // Method to add a new patient to the database
        public void AddPatient(PatientModel patient)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"
                    INSERT INTO Patients
                    (first_name, last_name, birth_date, gender, student_or_staff, id_number, grade_or_department, contact_number, date_registered)
                    VALUES
                    (@FirstName, @LastName, @BirthDate, @Gender, @StudentOrStaff, @IdNumber, @GradeOrDepartment, @ContactNumber, @DateRegistered);";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@FirstName", patient.first_name);
                command.Parameters.AddWithValue("@LastName", patient.last_name);
                command.Parameters.AddWithValue("@BirthDate", patient.birth_date);
                command.Parameters.AddWithValue("@Gender", patient.gender);
                command.Parameters.AddWithValue("@StudentOrStaff", patient.student_or_staff);
                command.Parameters.AddWithValue("@IdNumber", patient.id_number);
                command.Parameters.AddWithValue("@GradeOrDepartment", patient.grade_or_department);
                command.Parameters.AddWithValue("@ContactNumber", patient.contact_number);
                command.Parameters.AddWithValue("@DateRegistered", patient.date_registered);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }

        }
        public void UpdatePatient(PatientModel patient)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"
                    UPDATE Patients SET
                        first_name = @FirstName,
                        last_name = @LastName,
                        birth_date = @BirthDate,
                        gender = @Gender,
                        student_or_staff = @StudentOrStaff,
                        id_number = @IdNumber,
                        grade_or_department = @GradeOrDepartment,
                        contact_number = @ContactNumber
                    WHERE patient_id = @PatientId;";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@FirstName", patient.first_name);
                command.Parameters.AddWithValue("@LastName", patient.last_name);
                command.Parameters.AddWithValue("@BirthDate", patient.birth_date);
                command.Parameters.AddWithValue("@Gender", patient.gender);
                command.Parameters.AddWithValue("@StudentOrStaff", patient.student_or_staff);
                command.Parameters.AddWithValue("@IdNumber", patient.id_number);
                command.Parameters.AddWithValue("@GradeOrDepartment", patient.grade_or_department);
                command.Parameters.AddWithValue("@ContactNumber", patient.contact_number);
                command.Parameters.AddWithValue("@PatientId", patient.patient_id);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

                // Update the patient in the Patients list
                var existingPatient = Patients.Find(p => p.patient_id == patient.patient_id);
                if (existingPatient != null)
                {
                    int index = Patients.IndexOf(existingPatient);
                    Patients[index] = patient;
                }
            }
        }
    }
}
