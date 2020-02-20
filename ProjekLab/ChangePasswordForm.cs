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
    public partial class ChangePasswordForm : Form
    {
        WatchDBEntities watchDB = new WatchDBEntities();
        public ChangePasswordForm()
        {
            InitializeComponent();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            string message = validate();

            string password = oldPassTxt.Text;
            User user = new User();
            user = (from u in watchDB.Users
                    where password == u.Password
                    select u).FirstOrDefault();

            if (message != "")
            {
                MessageBox.Show(message, "Error Change Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (user == null) {
                MessageBox.Show("Old Password doesn’t match with the current password!", "Error Change Password", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }

            else
            {
                user.Password = newPassTxt.Text;
                //watchDB.Users.AddObject(user);
                watchDB.SaveChanges();
                MessageBox.Show("Successfully Change Password", "Success Change Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
        }

        private string validate() {
            string oldPass = oldPassTxt.Text;
            string newPass = newPassTxt.Text;
            string confirmPass = confirmPassTxt.Text;

            if (oldPass == "")
            {
                return "Old Password must be filled!";
            }
            else if (newPass == "")
            {
                return "New Password must be filled!";
            }
            else if (newPass.Length < 5 || newPass.Length > 10)
            {
                return "New Password length must be 5-10 characters!";
            }
            else if (newPass == oldPass)
            {
                return "New Password can't be same with the Old Password!";
            }
            else if (confirmPass != newPass)
            {
                return "New Password doesn't match with Confirm New Password!";
            }

            return "";
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
