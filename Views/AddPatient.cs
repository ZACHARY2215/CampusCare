using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using CampusCare.Models;
using CampusCare.ModelViews;

namespace CampusCare.Views
{
    public partial class AddPatient : Form
    {
        public AddPatient()
        {
            InitializeComponent();

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

        private void buttonOk_Click(object sender, EventArgs e)
        {
            try
            {
                // Collect data from input controls
                string firstName = textBox_firstname.Text.Trim();
                string lastName = textBox_lastname.Text.Trim();
                DateTime birthDate = dateTimePicker_birthday.Value.Date;
                string gender = textBox_gender.Text.Trim();
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
                    MessageBox.Show("Gender is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

                DateTime dateRegistered = DateTime.Now;

                // Create a new PatientModel object
                PatientModel newPatient = new PatientModel
                {
                    first_name = firstName,
                    last_name = lastName,
                    birth_date = birthDate,
                    gender = gender,
                    student_or_staff = studentOrStaff,
                    id_number = idNumber,
                    grade_or_department = gradeOrDepartment,
                    contact_number = contactNumber,
                    date_registered = dateRegistered
                };

                // Add the patient to the database using PatientMV
                PatientMV patientMV = new PatientMV();
                patientMV.AddPatient(newPatient);

                MessageBox.Show("Patient added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while adding the patient: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
