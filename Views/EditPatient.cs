using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using CampusCare.Models;
using CampusCare.ModelViews;

namespace CampusCare.Views
{
    public partial class EditPatient : Form
    {
        private PatientMV patientMV;

        public PatientModel Patient { get; private set; }

        // Constructor that takes a PatientModel and PatientMV as arguments
        internal EditPatient(PatientModel patient, PatientMV existingPatientMV)
        {
            InitializeComponent();
            Patient = patient;
            patientMV = existingPatientMV;

            // Populate combo boxes with appropriate options
            comboBox_studentorstaff.Items.AddRange(new string[] { "Student", "Staff" });
            comboBox_gradeordepartment.Items.AddRange(new string[]
            {
                "Grade 7", "Grade 8", "Grade 9", "Grade 10", "Grade 11", "Grade 12",
                "ATYCB", "CEA", "CHS", "CCIS", "CAS"
            });
            
            // Attach KeyPress event handlers to restrict input to letters and spaces
            textBox_firstname.KeyPress += TextBox_Name_KeyPress;
            textBox_lastname.KeyPress += TextBox_Name_KeyPress;

            // Fill fields with patient's current information
            FillFields();
        }

        // Event handler to allow only letters and spaces in the name TextBoxes
        private void TextBox_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow control characters (e.g., backspace), letters, and spaces
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true; // Ignore the key press
            }
        }

        // Method to fill form fields with patient's current information
        private void FillFields()
        {
            textBox_firstname.Text = Patient.first_name;
            textBox_lastname.Text = Patient.last_name;
            textBox_contact.Text = Patient.contact_number.ToString();
            textBox_gender.Text = Patient.gender;
            textBox_id.Text = Patient.id_number.ToString();
            comboBox_gradeordepartment.SelectedItem = Patient.grade_or_department;
            comboBox_studentorstaff.SelectedItem = Patient.student_or_staff;
            dateTimePicker_birthday.Value = Patient.birth_date;
        }

        // Method to update the Patient object with the current form field values
        private void UpdatePatient()
        {
            // Collect data from input controls
            string firstName = textBox_firstname.Text.Trim();
            string lastName = textBox_lastname.Text.Trim();
            DateTime birthDate = dateTimePicker_birthday.Value.Date;
            string gender = textBox_gender.Text?.Trim();
            string studentOrStaff = comboBox_studentorstaff.SelectedItem?.ToString();
            string gradeOrDepartment = comboBox_gradeordepartment.SelectedItem?.ToString();

            // Validate required fields
            if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName))
            {
                MessageBox.Show("First name and last name are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate that first name and last name contain only letters and spaces
            if (!IsAllLettersOrSpaces(firstName))
            {
                MessageBox.Show("First name can only contain letters and spaces.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!IsAllLettersOrSpaces(lastName))
            {
                MessageBox.Show("Last name can only contain letters and spaces.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(gender))
            {
                MessageBox.Show("Please select a gender.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(studentOrStaff))
            {
                MessageBox.Show("Please select Student or Staff.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(gradeOrDepartment))
            {
                MessageBox.Show("Please select Grade or Department.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(textBox_id.Text.Trim(), out int idNumber))
            {
                MessageBox.Show("Please enter a valid ID number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!long.TryParse(textBox_contact.Text.Trim(), out long contactNumber))
            {
                MessageBox.Show("Please enter a valid contact number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Update the Patient object with new values
            Patient.first_name = firstName;
            Patient.last_name = lastName;
            Patient.birth_date = birthDate;
            Patient.gender = gender;
            Patient.student_or_staff = studentOrStaff;
            Patient.grade_or_department = gradeOrDepartment;
            Patient.id_number = idNumber;
            Patient.contact_number = contactNumber;

            // Save the updated patient record to the database
            patientMV.UpdatePatient(Patient);
        }

        // Helper method to check if a string contains only letters and spaces
        private bool IsAllLettersOrSpaces(string str)
        {
            foreach (char c in str)
            {
                if (!char.IsLetter(c) && c != ' ')
                    return false;
            }
            return true;
        }

        // Event handler for OK button
        private void buttonOk_Click(object sender, EventArgs e)
        {
            try
            {
                UpdatePatient();
                MessageBox.Show("Patient updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating the patient: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Event handler for Cancel button
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
