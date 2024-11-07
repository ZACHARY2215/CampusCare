using System;
using System.Collections.Generic;
using System.Configuration;
using Microsoft.Data.SqlClient;
using CampusCare.Models;

namespace CampusCare.ModelViews
{
    public class PatientMV
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
                    Patients.Add(patient);
                }
                connection.Close();
            }
        }

        public void DeletePatientById(int patient_id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"
                    DELETE FROM Patients WHERE patient_id = @patient_id";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@patient_id", patient_id);

                connection.Open();
                command.ExecuteNonQuery();
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
        public void RemovePatient(PatientModel patient)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Patients WHERE patient_id = @PatientId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@PatientId", patient.patient_id);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

                // Remove the patient from the list
                Patients.Remove(patient);
            }
        }
    }
}
