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
        public Main()
        {
            InitializeComponent();
            patientMV = new PatientMV();
            LoadPatientData();
        }

        private void LoadPatientData()
        {
            dataGridViewPatient.DataSource = null;
            dataGridViewPatient.DataSource = patientMV.Patients;
        }

        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            // https://learn.microsoft.com/en-us/dotnet/desktop/winforms/controls/how-to-display-side-aligned-tabs-with-tabcontrol?view=netframeworkdesktop-4.8&redirectedfrom=MSDN
            Graphics g = e.Graphics;
            Brush _textBrush;

            // Get the item from the collection.
            TabPage _tabPage = tabControl1.TabPages[e.Index];

            // Get the real bounds for the tab rectangle.
            Rectangle _tabBounds = tabControl1.GetTabRect(e.Index);

            if (e.State == DrawItemState.Selected)
            {

                // Draw a different background color, and don't paint a focus rectangle.
                _textBrush = new SolidBrush(e.ForeColor);
                g.FillRectangle(Brushes.Gray, e.Bounds);
            }
            else
            {
                _textBrush = new SolidBrush(e.ForeColor);
                g.FillRectangle(Brushes.Transparent, e.Bounds);
                //e.DrawBackground();
            }

            // Use our own font.
            //Font _tabFont = new Font("Segoe UI", 15.0f, FontStyle.Bold, GraphicsUnit.Pixel);
            Font _tabFont = e.Font;

            // Draw string. Center the text.
            StringFormat _stringFlags = new StringFormat();
            _stringFlags.Alignment = StringAlignment.Near;
            _stringFlags.LineAlignment = StringAlignment.Center;
            g.DrawString(_tabPage.Text, _tabFont, _textBrush, _tabBounds, new StringFormat(_stringFlags));
        }
    }
}
