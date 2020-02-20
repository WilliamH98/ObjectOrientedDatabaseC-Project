using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProjekLab
{
    public partial class LoginForm : Form
    {
        WatchDBEntities watchDB = new WatchDBEntities();
        public static string userIDLogin = "";

        public LoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void userIDTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string message = validate();

            User user = (from u in watchDB.Users 
                         where u.UserId == userIDTxt.Text && u.Password == passwordTxt.Text 
                         select u).FirstOrDefault();
           
            if (message != "")
            {
                MessageBox.Show(message, "Error Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            else if (user == null) {
                MessageBox.Show("User account not found!", "Error Login", MessageBoxButtons.OK, MessageBoxIcon.Error);   
            }
            
            else
            {

                MessageBox.Show("Login Success", "Success Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                userIDLogin = userIDTxt.Text;

                if (user.Role == "Member")
                {
                    MainFormMember member = new MainFormMember();
                    member.Show();
                }
                else {
                    MainFormAdmin admin = new MainFormAdmin();
                    admin.Show();
                }

                Close();
            }
        }

        private string validate(){
            string user = userIDTxt.Text;
            string pass = passwordTxt.Text;

            if (user == "")
            {
                return "User ID must be filled!";
            }
            else if (pass == "")
            {
                return "Password must be filled!";
            }

            return "";
        }

        private void cancelBtn_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
