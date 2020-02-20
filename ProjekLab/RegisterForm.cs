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
    public partial class RegisterForm : Form
    {
        WatchDBEntities watchDB = new WatchDBEntities();
        public RegisterForm()
        {
            InitializeComponent();
            string lastID = (from u in watchDB.Users
                             orderby u.UserId descending
                             select u.UserId).FirstOrDefault();

            if (lastID != null && lastID != "")
            {
                string noLastID = lastID.Substring(2);
                int newID = int.Parse(noLastID) + 1;
                string newUsID = "US" + newID.ToString("000");
                userIdTxt.Text = newUsID;
            }
            else {
                string newUsID = "US001";
                userIdTxt.Text = newUsID;
            }
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            string message = validate();

            if (message != "")
            {
                MessageBox.Show(message, "Error Register", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                User user = new User();

                user.UserId = userIdTxt.Text;
                user.Fullname = fullNameTxt.Text;
                user.Password = passwordTxt.Text;
                if (maleRB.Checked == true) {
                    user.Gender = "Male";
                }else if(femaleRB.Checked == true){
                    user.Gender = "Female";
                }

                user.Phone = phoneTxt.Text;
                user.Address = addressRTxt.Text;
                user.Role = "Member";

                watchDB.Users.AddObject(user);
                watchDB.SaveChanges();

                MessageBox.Show("Register success!", "Success Register", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
        }

        private bool validate_phone() {
            string phone = phoneTxt.Text;
            int phoneLength = phone.Length;
            int i;

            for (i = 0; i < phoneLength; i++) {
                if (!char.IsDigit(phone[i])) {
                    return false;
                }
            }

                return true;
        }

        private string validate() {
            string name = fullNameTxt.Text;
            string pass = passwordTxt.Text;
            string phone = phoneTxt.Text;
            string address = addressRTxt.Text;
            bool phoneNumeric = validate_phone();

                     
            if(name == "")
            {
                return "Fullname must be filled!";
            }
            else if(name.Length < 5 || name.Length > 30) {
                return "Fullname length must be between 5-30 characters!";
            }
            else if(passwordTxt.TextLength < 5 || passwordTxt.TextLength > 20) {
                return "Password length must be between 5-20 characters!";
            }
            else if(phone == "")
            {
                return "Phone must be filled!";
            }
            else if (phoneNumeric != true)
            {
                return "Phone number must be numeric!";
            }
            else if(phone.Length < 10 || phone.Length > 12)
            {
                return "Phone number length must be between 10-12 characters!";
            }
            else if(!maleRB.Checked && !femaleRB.Checked) {
                return "Gender must be chosen!";
            }
            else if (!address.EndsWith(" Street"))
            {
                return "Address must be ends with “ Street” !";
            }

            return "";
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void userIdTxt_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
