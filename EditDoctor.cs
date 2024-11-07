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
    public partial class EditDoctor : Form
    {
        private DoctorMV doctorMV;

        internal DoctorModel Doctor { get; private set; }
        internal EditDoctor(DoctorModel doctor, DoctorMV existingDoctorMV)
        {
            InitializeComponent();
            Doctor = doctor;
            doctorMV = existingDoctorMV;

            // Populate combo boxes with appropriate options
            // Attach KeyPress event handlers to restrict input to letters and spaces
            textBox_firstname.KeyPress += TextBox_Name_KeyPress;
            textBox_lastname.KeyPress += TextBox_Name_KeyPress;

            FillFields();
        }

        private void FillFields()
        {
            textBox_firstname.Text = Doctor.first_name;
            textBox_lastname.Text = Doctor.last_name;
            textBox_contact.Text = Doctor.contact_number.ToString();
            comboBox_status.SelectedItem = Doctor.status;
            textBox_email.Text = Doctor.email;
            roleComboBox.Text = Doctor.role;
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

                if (!long.TryParse(textBox_contact.Text.Trim(), out long contactNumber))
                {
                    MessageBox.Show("Please enter a valid contact number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }



                Doctor.first_name = firstName;
                Doctor.last_name = lastName;
                Doctor.email = email;
                Doctor.role = role;
                Doctor.contact_number = contactNumber;
                Doctor.status = status;

                // Add the patient to the database using PatientMV
                doctorMV.UpdateDoctor(Doctor);

                MessageBox.Show("Doctor updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
