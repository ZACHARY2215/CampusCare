using CampusCare.Models;
using CampusCare.ModelViews;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CampusCare.Views
{
    public partial class AddDoctor : Form
    {
        public AddDoctor()
        {
            InitializeComponent();

            // Populate combo boxes with appropriate options
            // Attach KeyPress event handlers to restrict input to letters and spaces
            textBox_firstname.KeyPress += TextBox_Name_KeyPress;
            textBox_lastname.KeyPress += TextBox_Name_KeyPress;
        }

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
                string email = textBox_email.Text.Trim();
                string role = roleComboBox.SelectedItem?.ToString();
                string status = comboBox_status.SelectedItem?.ToString();

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
                if (string.IsNullOrWhiteSpace(role))
                {
                    MessageBox.Show("Please select Nurse or Doctor.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (string.IsNullOrWhiteSpace(status))
                {
                    MessageBox.Show("Please select Available or Unavailable.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!long.TryParse(textBox_contact.Text.Trim(), out long contactNumber))
                {
                    MessageBox.Show("Please enter a valid contact number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DateTime dateRegistered = DateTime.Now;

                // Create a new PatientModel object
                DoctorModel newDoctor = new DoctorModel
                {
                    first_name = firstName,
                    last_name = lastName,
                    email = email,
                    role = role,
                    contact_number = contactNumber,
                    status = status,
                };

                // Add the patient to the database using PatientMV
                DoctorMV doctorMV = new DoctorMV();
                doctorMV.AddDoctor(newDoctor);

                MessageBox.Show("Doctor added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while adding the doctor: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
