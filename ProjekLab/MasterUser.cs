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
    public partial class MasterUser : Form
    {
        WatchDBEntities watchDB = new WatchDBEntities();
        User us = new User();

        int flag = 0;
        public MasterUser()
        {
            InitializeComponent();

            initialState();
            loadData();
        }

        public void initialState() {
            string lastID = (from u in watchDB.Users
                             orderby u.UserId descending
                             select u.UserId).FirstOrDefault();

            userIdTxt.Enabled = false;
            fullNameTxt.Enabled = false;
            roleCb.Enabled = false;
            phoneTxt.Enabled = false;
            addressRtxt.Enabled = false;
            maleRb.Enabled = false;
            femaleRb.Enabled = false;
            insertBtn.Enabled = true;
            updateBtn.Enabled = true;
            deleteBtn.Enabled = true;

            submitBtn.Enabled = false;
            cancelBtn.Enabled = false; 

            fullNameTxt.Text = "";
            phoneTxt.Text = "";
            roleCb.SelectedIndex = -1;
            roleCb.Text = "--Choose Role--";
            maleRb.Checked = false;
            femaleRb.Checked = false;
            addressRtxt.Text = "";

            if (lastID != null && lastID != "")
            {
                string noLastID = lastID.Substring(2);
                int newID = int.Parse(noLastID) + 1;
                string newUsID = "US" + newID.ToString("000");
                userIdTxt.Text = newUsID;
            }
            else
            {
                string newUsID = "US001";
                   userIdTxt.Text = newUsID;
            }
            flag = 0;
        }

        void loadData() {
            userDgv.DataSource = (from user in watchDB.Users 
                                  select new {UserId = user.UserId, 
                                      Fullname = user.Fullname,
                                      Gender = user.Gender,
                                      Phone = user.Phone,
                                      Address = user.Address
                                  });
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            string message = validate();

            if (message != "")
            {
                MessageBox.Show(message, "Error Master User", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (flag == 1)
                {
                    us.UserId = userIdTxt.Text;
                    us.Fullname = fullNameTxt.Text;

                    if (maleRb.Checked == true)
                    {
                        us.Gender = "Male";
                    }
                    else if (femaleRb.Checked == true)
                    {
                        us.Gender = "Female";
                    }

                    if (roleCb.SelectedIndex == 0)
                    {
                        us.Role = "Member";
                    }
                    else if (roleCb.SelectedIndex == 1)
                    {
                        us.Role = "Admin";
                    }

                    us.Phone = phoneTxt.Text;
                    us.Address = addressRtxt.Text;
                    us.Password = "default";
                    watchDB.Users.AddObject(us);
                    watchDB.SaveChanges();
                    flag = 0;
                }else{
                    User updateUser = (from u in watchDB.Users
                                  where u.UserId == userIdTxt.Text
                                  select u).FirstOrDefault();
                    
                    //updateUser.UserId = userIdTxt.Text;
                    updateUser.Fullname = fullNameTxt.Text;

                    if (maleRb.Checked == true)
                    {
                        updateUser.Gender = "Male";
                    }
                    else if (femaleRb.Checked == true)
                    {
                        updateUser.Gender = "Female";
                    }

                    if (roleCb.SelectedIndex == 0)
                    {
                        updateUser.Role = "Member";
                    }
                    else if (roleCb.SelectedIndex == 1)
                    {
                        updateUser.Role = "Admin";
                    }

                    updateUser.Phone = phoneTxt.Text;
                    updateUser.Address = addressRtxt.Text;
                    updateUser.Password = "default";
                    watchDB.SaveChanges();
                }
                
                loadData();
                MessageBox.Show("Successfully inserted/updated data!", "Success Master User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                initialState();
                //Close();
            }
        }

        public void enabled()
        {
            userIdTxt.Enabled = false;
            fullNameTxt.Enabled = true;
            roleCb.Enabled = true;
            phoneTxt.Enabled = true;
            addressRtxt.Enabled = true;
            maleRb.Enabled = true;
            femaleRb.Enabled = true;
            insertBtn.Enabled = false;
            updateBtn.Enabled = false;
            deleteBtn.Enabled = false;

            submitBtn.Enabled = true;
            cancelBtn.Enabled = true;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            initialState();
        }

        private bool validate_phone()
        {
            string phone = phoneTxt.Text;
            int phoneLength = phone.Length;
            int i;

            for (i = 0; i < phoneLength; i++)
            {
                if (!char.IsDigit(phone[i]))
                {
                    return false;
                }
            }

            return true;
        }

        private string validate() {
            string name = fullNameTxt.Text;
            string phone = phoneTxt.Text;
            string address = addressRtxt.Text;
            bool phoneNumeric = validate_phone();

            if (name == "")
            {
                return "Fullname must be filled!";
            }
            else if (name.Length < 5 || name.Length > 30)
            {
                return "Fullname length must be between 5-30 characters!";
            }
            else if (roleCb.SelectedIndex == -1) {
                return "User Role must be either Member or Admin";
            }
            else if (phoneNumeric != true)
            {
                return "Phone number must be numeric!";
            }
            else if (phone == "")
            {
                return "Phone must be filled!";
            }
            else if (phone.Length < 10 || phone.Length > 12)
            {
                return "Phone number length must be between 10-12 characters!";
            }
            else if (!maleRb.Checked && !femaleRb.Checked)
            {
                return "Please select Gender!";
            }
            else if (!address.EndsWith(" Street"))
            {
                return "Address must be ends with “ Street” !";
            }

            return "";
        }

        private void insertBtn_Click(object sender, EventArgs e)
        {
            initialState();
            enabled();
            flag += 1;
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (fullNameTxt.Text == "" && roleCb.SelectedIndex == -1 && phoneTxt.Text == "" && (!maleRb.Checked && !femaleRb.Checked) && addressRtxt.Text == "")
            {
                MessageBox.Show("Please select data first!", "Error Master User", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                enabled();
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (fullNameTxt.Text == "" && roleCb.SelectedIndex == -1 && phoneTxt.Text == "" && (!maleRb.Checked && !femaleRb.Checked) && addressRtxt.Text == "")
            {
                MessageBox.Show("Please choose data first!", "Error Master User", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are you sure want to delete this data?", "Delete Data", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    string ID = userIdTxt.Text;
                    us = (from user in watchDB.Users where ID == user.UserId select user).FirstOrDefault();

                    watchDB.Users.DeleteObject(us);
                    watchDB.SaveChanges();
                    loadData();
                    MessageBox.Show("Successfully deleted data", "Delete Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    initialState();
                }
                else {
                    initialState();
                }
            }
        }

        private void userDgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = userDgv.Rows[e.RowIndex];

            User us = new User();
            userIdTxt.Text = row.Cells[0].Value.ToString();
            fullNameTxt.Text = row.Cells[1].Value.ToString();
            phoneTxt.Text = row.Cells[3].Value.ToString();
            if (row.Cells[2].Value.ToString() == "Male") maleRb.Checked = true;
            else if(row.Cells[2].Value.ToString() == "Female") femaleRb.Checked = true;
            addressRtxt.Text = row.Cells[4].Value.ToString();
        }

    }
}
