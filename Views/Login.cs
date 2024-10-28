using CampusCare.Views;

namespace CampusCare
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public void btn_login_Click(object sender, EventArgs e)
        {
            Main main = new();
            this.Hide();
            main.ShowDialog();
            this.Show();
        }
    }
}
