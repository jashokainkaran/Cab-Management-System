namespace CabManagementSystem
{
    public partial class Form1 : Form
    {
        private Admin admin;
        public Form1()
        {
            InitializeComponent();
            this.admin = new Admin();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void login_Click(object sender, EventArgs e)
        {
            string userName = username.Text;
            string passWord = password.Text;

            if (userName == "admin" && passWord == "admin")
            {
                MessageBox.Show($"You are logged in as {userName}");
                AdminDashboard adminDashboard = new AdminDashboard();
                adminDashboard.ShowDialog();
                this.Close();
            }
            else
            {
                if (admin.LoginCustomer(userName, passWord))
                {
                    MessageBox.Show($"You are logged in as {userName}");
                    CustomerDashboard customerDashboard = new CustomerDashboard(userName);
                    customerDashboard.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show($"Invalid Credentials \n Please Try Again");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           CreateNewCustomer createNewCustomer = new CreateNewCustomer();
           createNewCustomer.ShowDialog();
        }
    }
}
