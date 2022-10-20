using ProjectPRN211.Models;

namespace ProjectPRN211
{
    public partial class Password : Form
    {
        public Password()
        {
            InitializeComponent();
        }

        MoneyWifeContext context = new MoneyWifeContext();

        private void btnRegister_Click(object sender, EventArgs e)
        {
            //open register form and close login form
            Registration register = new Registration();
            register.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //get text from txtUsername and txtPassword
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            //check if username and password is empty
            if (username == "" || password == "")
            {
                MessageBox.Show("Username or password is empty");
                return;
            }
            //check if username and password is correct
            User user = context.Users.FirstOrDefault(u => u.Username == username && u.Password == password);
            if (user == null)
            {
                MessageBox.Show("Username or password is incorrect");
                return;
            }
            //if username and password is correct, message box show "Login successfully"
            MessageBox.Show("Login successfully");

        }
    }
}