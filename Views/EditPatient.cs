using CampusCare.Models;
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
    public partial class EditPatient : Form
    {
        public PatientModel Patient { get; private set; }

        public EditPatient(PatientModel patient)
        {
            InitializeComponent();
            Patient = patient;
            FillFields();
        }

        // fill the fields with patient's current info
        private void FillFields()
        {
            textBox_firstname.Text = Patient.first_name;
            textBox_lastname.Text = Patient.last_name;
            textBox_contact.Text = Patient.contact_number.ToString();
            textBox_gender.Text = Patient.gender;
            textBox_id.Text = Patient.id_number.ToString();
            comboBox_gradeordepartment.Text = Patient.grade_or_department;
            comboBox_studentorstaff.Text = Patient.student_or_staff;
            dateTimePicker_birthday.Value = Patient.birth_date;
        }

        // upon clicking OK button, update the property Patient with info from fields
        private void UpdatePatient()
        {
            Patient.first_name = textBox_firstname.Text;
            Patient.last_name = textBox_lastname.Text;
            Patient.contact_number = Int64.Parse(textBox_id.Text);
            Patient.gender = textBox_gender.Text;
            Patient.grade_or_department = comboBox_gradeordepartment.Text;
            Patient.student_or_staff = comboBox_studentorstaff.Text;
            Patient.birth_date = dateTimePicker_birthday.Value;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            UpdatePatient();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult= DialogResult.Cancel;
        }
    }
}
