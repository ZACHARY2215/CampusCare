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
    public partial class Main : Form
    {
        private PatientMV patientMV;
        private DoctorMV doctorMV;
        private RecentPatientsMV recentPatientsMV;

        public Main()
        {
            InitializeComponent();
            patientMV = new PatientMV();
            doctorMV = new DoctorMV();
            recentPatientsMV = new RecentPatientsMV();
            LoadPatientData();
            LoadDoctorData();
            LoadRecentPatientData();
        }

        private void LoadPatientData()
        {
            dataGridViewPatient.DataSource = null;
            patientMV.LoadPatients();
            dataGridViewPatient.DataSource = patientMV.Patients;
        }

        private void LoadDoctorData()
        {
            dataGridViewDoctor.DataSource = null;
            doctorMV.LoadDoctors();
            dataGridViewDoctor.DataSource = doctorMV.Doctors;
        }

        private void LoadRecentPatientData()
        {
            dataGridViewRecentPatients.DataSource = null;
            recentPatientsMV.LoadRecentPatients();
            dataGridViewRecentPatients.DataSource = recentPatientsMV.RecentPatients;
        }

        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush _textBrush;
            TabPage _tabPage = tabControl1.TabPages[e.Index];
            Rectangle _tabBounds = tabControl1.GetTabRect(e.Index);

            if (e.State == DrawItemState.Selected)
            {
                _textBrush = new SolidBrush(e.ForeColor);
                g.FillRectangle(Brushes.Gray, e.Bounds);
            }
            else
            {
                _textBrush = new SolidBrush(e.ForeColor);
                g.FillRectangle(Brushes.Transparent, e.Bounds);
            }

            Font _tabFont = e.Font;
            StringFormat _stringFlags = new StringFormat();
            _stringFlags.Alignment = StringAlignment.Near;
            _stringFlags.LineAlignment = StringAlignment.Center;
            g.DrawString(_tabPage.Text, _tabFont, _textBrush, _tabBounds, new StringFormat(_stringFlags));
        }



        private void buttonAddPatient_Click(object sender, EventArgs e)
        {
            using (AddPatient ap = new())
            {
                if (ap.ShowDialog() == DialogResult.OK)
                {
                    patientMV.LoadPatients();
                    LoadPatientData();
                }
            }
        }


        private void buttonEditPatient_Click(object sender, EventArgs e)
        {
            // Get the selected patient from the DataGridView
            if (dataGridViewPatient.CurrentRow != null)
            {
                PatientModel selectedPatient = dataGridViewPatient.CurrentRow.DataBoundItem as PatientModel;
                if (selectedPatient != null)
                {
                    using (EditPatient ep = new(selectedPatient, patientMV))
                    {
                        if (ep.ShowDialog() == DialogResult.OK)
                        {
                            // Refresh the DataGridView
                            dataGridViewPatient.Refresh();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a patient to edit.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            LoadPatientData();
        }


        private void buttonRemovePatient_Click(object sender, EventArgs e)
        {
            // Get the selected patient from the DataGridView
            if (dataGridViewPatient.CurrentRow != null)
            {
                PatientModel selectedPatient = dataGridViewPatient.CurrentRow.DataBoundItem as PatientModel;
                if (selectedPatient != null)
                {
                    patientMV.DeletePatientById(selectedPatient.patient_id);
                }
            }
            else
            {
                MessageBox.Show("Please select a patient to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            LoadPatientData();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string searchText = textBoxSearch.Text.ToLower();

            var filteredPatients = patientMV.Patients.Where(p =>
                p.first_name.ToLower().Contains(searchText) ||
                p.last_name.ToLower().Contains(searchText) ||
                p.id_number.ToString().Contains(searchText) ||
                p.gender.ToLower().Contains(searchText) ||
                p.grade_or_department.ToLower().Contains(searchText) ||
                p.contact_number.ToString().Contains(searchText)).ToList();

            // Update the DataGridView with the filtered list
            dataGridViewPatient.DataSource = null;
            dataGridViewPatient.DataSource = filteredPatients;
        }

        
        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxSearch.Text))
               
            {
                // Reset to display all patients if the search box is cleared
                dataGridViewPatient.DataSource = null;
                dataGridViewPatient.DataSource = patientMV.Patients;
            }
        }
        private void comboBoxSortOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedOption = comboBoxSortOptions.SelectedItem.ToString();

            switch (selectedOption)
            {
                case "First Name (A-Z)":
                    patientMV.Patients = patientMV.Patients.OrderBy(p => p.first_name).ToList();
                    break;
                case "First Name (Z-A)":
                    patientMV.Patients = patientMV.Patients.OrderByDescending(p => p.first_name).ToList();
                    break;
                case "Last Name (A-Z)":
                    patientMV.Patients = patientMV.Patients.OrderBy(p => p.last_name).ToList();
                    break;
                case "Last Name (Z-A)":
                    patientMV.Patients = patientMV.Patients.OrderByDescending(p => p.last_name).ToList();
                    break;
                case "ID (Ascending)":
                    patientMV.Patients = patientMV.Patients.OrderBy(p => p.id_number).ToList();
                    break;
                case "ID (Descending)":
                    patientMV.Patients = patientMV.Patients.OrderByDescending(p => p.id_number).ToList();
                    break;
                case "Gender":
                    patientMV.Patients = patientMV.Patients.OrderBy(p => p.gender).ToList();
                    break;
                case "Grade/Department":
                    patientMV.Patients = patientMV.Patients.OrderBy(p => p.grade_or_department).ToList();
                    break;
                default:
                    break;
            }

            // Refresh the DataGridView with the sorted list
            dataGridViewPatient.DataSource = null;
            dataGridViewPatient.DataSource = patientMV.Patients;
        }

    }
}