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
            dataGridViewPatient.DataSource = patientMV.Patients;
        }

        private void LoadDoctorData()
        {
            dataGridViewDoctor.DataSource = null;
            dataGridViewDoctor.DataSource = doctorMV.Doctors;
        }

        private void LoadRecentPatientData()
        {
            dataGridViewRecentPatients.DataSource = null;
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
            LoadPatientData() ;
        }

        private void buttonViewPatient_Click(object sender, EventArgs e)
        {
            using (ViewPatient vp = new())
            {
                vp.ShowDialog();
            }
        }
    }
}