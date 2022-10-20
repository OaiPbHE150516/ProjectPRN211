using ProjectPRN211.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectPRN211
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        MoneyWifeContext context = new MoneyWifeContext();
        
        private void btnBackLogin_Click(object sender, EventArgs e)
        {
            //close this form and open login form
            Password login = new Password();
            login.Show();
            this.Hide();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            //get text from txtUsername, txtPassword, txtConfirmPassword, txtFullname, txtPhoneMail, rad gender, txtLocation
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;
            string fullname = txtFullname.Text;
            string phoneEmail = txtPhoneEmail.Text;
            //string gender = "";
            //if (radMale.Checked)
            //{
            //    gender = "male";
            //}
            //else if (radFemale.Checked)
            //{
            //    gender = "female";
            //}
            //else
            //{
            //    gender = "other";
            //}
            //string location = txtLocation.Text;
            
            ////check if username, password, confirm password, fullname is empty
            //if (username == "" || password == "" || confirmPassword == "" || fullname == "")
            //{
            //    MessageBox.Show("Username, password, confirm password, fullname is empty");
            //    return;
            //}
            
            ////check if password and confirm password is not match
            //if (password != confirmPassword)
            //{
            //    MessageBox.Show("Password and confirm password is not match");
            //    return;
            //}

            ////check if username is exist
            //User? user = context.Users.FirstOrDefault(u => u.Username == username);
            //if (user != null)
            //{
            //    MessageBox.Show("Username is exist");
            //    return;
            //}

            //check if phoneEmail just have number
            if (phoneEmail.Any(c => !char.IsDigit(c)))
            {
                MessageBox.Show("Phone or email is not valid");
                return;
            }
        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }
    }
}
