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
    public partial class CheckPassword : Form
    {
        public CheckPassword()
        {
            InitializeComponent();
        }

        private void btn_ok_Click_1(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
