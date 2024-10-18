namespace HealthCareSync.Views
{
    public partial class AdminHomePage : Form
    {
        public AdminHomePage(string loggedInUser)
        {
            InitializeComponent();
        }

        private void exitAppBTN_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
