using CampusCare.ModelViews;
using CampusCare.Views;

namespace CampusCare
{
    public partial class Login : Form
    {
        private AdministratorMV adminMV;

        public Login()
        {
            InitializeComponent();
            adminMV = new AdministratorMV();
        }

        public void btn_login_Click(object sender, EventArgs e)
        {

            if (adminMV.Administrators.Exists(e => e.username.Equals(txt_username.Text) && e.password.Equals(txt_password.Text)))
            {
                Main main = new();
                this.Hide();
                main.ShowDialog();
                this.Show();
                errorLabel.Visible = false;
            }
            else
            {
                errorLabel.Visible = true;
            }
        }
    }
}