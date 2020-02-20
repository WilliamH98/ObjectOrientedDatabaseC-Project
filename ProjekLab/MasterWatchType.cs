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
    public partial class MasterWatchType : Form
    {
        WatchDBEntities watchDB = new WatchDBEntities();
        WatchType mwt = new WatchType();
        int flag = 0;

        public MasterWatchType()
        {
            InitializeComponent();
            initialState();
            loadData();
        }

        public void initialState() {
            string lastID = (from wt in watchDB.WatchTypes
                             orderby wt.WatchTypeId descending
                             select wt.WatchTypeId).FirstOrDefault();

            watchIdTxt.Enabled = false;
            watchNameTxt.Enabled = false;
            descriptionRtxt.Enabled = false;
            insertBtn.Enabled = true;
            updateBtn.Enabled = true;
            deleteBtn.Enabled = true;
            //panel1.Enabled = true;
                
            submitBtn.Enabled = false;
            cancelBtn.Enabled = false; 
            //panel2.Enabled = false;

            watchNameTxt.Text = "";
            descriptionRtxt.Text = "";

            if (lastID != null && lastID != "")
            {
                string noLastID = lastID.Substring(3);
                int newID = int.Parse(noLastID) + 1;
                string newWtyID = "WTY" + newID.ToString("000");
                watchIdTxt.Text = newWtyID;
            }
            else
            {
                string newWtyID = "WTY001";
                watchIdTxt.Text = newWtyID;
            }

            flag = 0;            
        }

        void loadData() {
            watchTypeDgv.DataSource = (from watchType in watchDB.WatchTypes
                                       select new {watchType.WatchTypeId,
                                           watchType.WatchTypeName,
                                           watchType.WatchDescription
                                       });
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            string message = validate();

            if (message != "")
            {
                MessageBox.Show(message, "Error Master Watch Type", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (flag == 1)
                {
                    mwt.WatchTypeId = watchIdTxt.Text;
                    mwt.WatchTypeName = watchNameTxt.Text;
                    mwt.WatchDescription = descriptionRtxt.Text;

                    watchDB.WatchTypes.AddObject(mwt);
                    watchDB.SaveChanges();
                    flag = 0;
                }
                else
                {
                    WatchType updateType = (from wt in watchDB.WatchTypes
                                  where wt.WatchTypeId == watchIdTxt.Text
                                  select wt).FirstOrDefault();
                    
                    updateType.WatchTypeId = watchIdTxt.Text;
                    updateType.WatchTypeName = watchNameTxt.Text;
                    updateType.WatchDescription = descriptionRtxt.Text;

                    watchDB.SaveChanges();
                }
                loadData();
                MessageBox.Show("Successfully inserted/updated data!", "Success Master Watch Type", MessageBoxButtons.OK, MessageBoxIcon.Information);
                initialState();
                //Close();
            }
        }

        public void enabled() {
            watchIdTxt.Enabled = false;
            watchNameTxt.Enabled = true;
            descriptionRtxt.Enabled = true;
            insertBtn.Enabled = false;
            updateBtn.Enabled = false;
            deleteBtn.Enabled = false;
            //panel1.Enabled = false;

            submitBtn.Enabled = true;
            cancelBtn.Enabled = true;
            //panel2.Enabled = true;
        }

        public void disabled() {

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            initialState();
        }

        private bool validate_description()
        {
            string specialChar = @"\|!#$%&/()=?»«@£§€{}.-;'<>_,";
            string description = descriptionRtxt.Text;
            if (!description.Any(char.IsDigit) || !description.Any(char.IsLetter)) return false;
            
            foreach (var item in specialChar)
            {
                if (description.Contains(item)) return false;
            }

            return true;
        }

        private string validate() {
            string watchName = watchNameTxt.Text;
            string description = descriptionRtxt.Text;
            bool descriptionAlnum = validate_description();

            if (watchName == "")
            {
                return "Watch Type Name must be filled!";
            }
            else if (descriptionAlnum != true)
            {
                return "Description must be alpha numeric!";
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
            if (watchNameTxt.Text == "" && descriptionRtxt.Text == "")
            {
                MessageBox.Show("Please select data first!", "Error Master Watch Type", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                enabled();
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (watchNameTxt.Text == "" && descriptionRtxt.Text == "")
            {
                MessageBox.Show("Please choose data first!", "Error Master Watch Type", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are you sure want to delete this data?", "Delete Data", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {

                    string ID = watchIdTxt.Text;
                    mwt = (from watchT in watchDB.WatchTypes where ID == watchT.WatchTypeId select watchT).FirstOrDefault();

                    watchDB.WatchTypes.DeleteObject(mwt);
                    watchDB.SaveChanges();
                    loadData();
                    MessageBox.Show("Successfully deleted data", "Delete Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    initialState();
                }
                else 
                {
                    initialState();
                }
            }
        }

        private void watchTypeDgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = watchTypeDgv.Rows[e.RowIndex];

            watchIdTxt.Text = row.Cells[0].Value.ToString();
            watchNameTxt.Text = row.Cells[1].Value.ToString();
            descriptionRtxt.Text = row.Cells[2].Value.ToString();
        }

    }
}
