using HealthCareSync.ViewModels;

namespace HealthCareSync.Views
{
    public partial class ManageTests : Form
    {
        private readonly ManageTestViewModel viewModel;
        public ManageTests()
        {
            InitializeComponent();
            //viewModel = 
        }

        private void exitAppBTN_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void patient_listBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
