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
    public partial class ChangePassword : Form
    {
        private AdministratorMV adminMV;
        public AdministratorModel administrator { get; private set; }
        public ChangePassword()
        {
            InitializeComponent();
            adminMV = new AdministratorMV();

        }


        private void btn_ok_Click(object sender, EventArgs e)
        {
            string newPassword = textBox_confirmpass.Text;

            if (IsCurrentPasswordMatching() && IsNewAndConfirmPasswodMatching())
            {
                adminMV.UpdateAdminPassword(newPassword);
                DialogResult = DialogResult.OK;
            }
            else if (!IsCurrentPasswordMatching())
            {
                MessageBox.Show("Current password is incorrect!");
            }
            else if (!IsNewAndConfirmPasswodMatching())
            {
                MessageBox.Show("New Password and Confirm Password does not match!");
            }
        }

        private bool IsCurrentPasswordMatching()
        {
            return adminMV.Administrators.Exists(e => e.password.Equals(textBox_currpass.Text));
        }

        private bool IsNewAndConfirmPasswodMatching()
        {
            return textBox_newpass.Text == textBox_confirmpass.Text;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            DialogResult= DialogResult.Cancel;
        }
    }
}
