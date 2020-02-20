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
    public partial class Master_Watch_Form : Form
    {
        WatchDBEntities watchDB = new WatchDBEntities();
        Watch mw = new Watch();
        int flag = 0;

        public Master_Watch_Form()
        {
            InitializeComponent();

            initialState();
            loadData();
        }

        public void initialState()
        {
            string lastID = (from w in watchDB.Watches
                             orderby w.WatchId descending
                             select w.WatchId).FirstOrDefault();
            
            watchIdTxt.Enabled = false;
            watchNameTxt.Enabled = false;
            watchPriceTxt.Enabled = false;
            watchTypeCb.Enabled = false;
            stockNud.Enabled = false;
            insertBtn.Enabled = true;
            updateBtn.Enabled = true;
            deleteBtn.Enabled = true;
            //panel1.Enabled = true;
            
            submitBtn.Enabled = false;
            cancelBtn.Enabled = false;
            //panel2.Enabled = false;

            watchNameTxt.Text = "";
            watchPriceTxt.Text = "";
            stockNud.Value = 0;
            if (lastID != null && lastID != "")
            {
                string noLastID = lastID.Substring(2);
                int newID = int.Parse(noLastID) + 1;
                string newWtID = "WT" + newID.ToString("000");
                watchIdTxt.Text = newWtID;
            }
            else
            {
                string newWtID = "WT001";
                watchIdTxt.Text = newWtID;
            }
            flag = 0;
        }

        void loadData() {
            watchDgv.DataSource = (from watch in watchDB.Watches 
                                   select new {WatchId = watch.WatchId, 
                                       WatchName = watch.WatchName, 
                                       WatchPrice = watch.WatchPrice, 
                                       WatchTypeName = watch.WatchType.WatchTypeName, 
                                       Stock = watch.WatchStock
                                   });

            watchTypeCb.DataSource = (from type in watchDB.WatchTypes
                                      select type.WatchTypeName);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void watchNameLbl_Click(object sender, EventArgs e)
        {

        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            string message = validate();

            if (message != "")
            {
                MessageBox.Show(message, "Error Master Watch", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string searchWatchTypeID = (from type in watchDB.WatchTypes
                                            where  watchTypeCb.Text == type.WatchTypeName
                                            select type.WatchTypeId).FirstOrDefault();
                if (flag == 1)
                {
                    mw.WatchId = watchIdTxt.Text;
                    mw.WatchName = watchNameTxt.Text;
                    mw.WatchTypeId = searchWatchTypeID;
                    mw.WatchPrice = Int32.Parse(watchPriceTxt.Text);
                    mw.WatchPrice = Int32.Parse(watchPriceTxt.Text);
                    mw.WatchStock = Decimal.ToInt32(stockNud.Value);

                    watchDB.Watches.AddObject(mw);
                    watchDB.SaveChanges();
                    flag = 0;
                }
                else {
                    Watch updateWatch = (from w in watchDB.Watches
                                        where w.WatchId == watchIdTxt.Text
                                        select w).FirstOrDefault();
                    
                    updateWatch.WatchName = watchNameTxt.Text;
                    updateWatch.WatchTypeId = searchWatchTypeID;
                    updateWatch.WatchPrice = Int32.Parse(watchPriceTxt.Text);
                    updateWatch.WatchStock = Decimal.ToInt32(stockNud.Value);

                    watchDB.SaveChanges();
                }
                loadData();
                MessageBox.Show("Successfully inserted/updated data!", "Success Master Watch", MessageBoxButtons.OK, MessageBoxIcon.Information);
                initialState();
            }
        }

        public void enabled() {
            watchIdTxt.Enabled = false;
            watchNameTxt.Enabled = true;
            watchPriceTxt.Enabled = true;
            watchTypeCb.Enabled = true;
            stockNud.Enabled = true;
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

        private bool validate_price()
        {
            string price = watchPriceTxt.Text;
            int priceLength = price.Length;
            int i;

            for (i = 0; i < priceLength; i++)
            {
                if (!char.IsDigit(price[i]))
                {
                    return false;
                }
            }

            return true;
        }


        private string validate()
        {
            string watchId = watchIdTxt.Text;
            bool watchPriceNumeric = validate_price();
            string watchName = watchNameTxt.Text;
            int stock = (int)stockNud.Value;

            if (watchName == "")
            {
                return "Watch Name must be filled!";
            }
            else if (watchPriceNumeric != true) {
                return "Watch Price must be numeric";
            }
            else if (stock < 1)
            {
                return "Stock must be more or equal to 1!";
            }
            return "";
        }

        private void insertBtn_Click_1(object sender, EventArgs e)
        {
            initialState();
            enabled();
            flag += 1;
        }

        private void updateBtn_Click_1(object sender, EventArgs e)
        {
            if (watchNameTxt.Text == "" && watchPriceTxt.Text == "" && stockNud.Value == 0)
            {
                MessageBox.Show("Please select data first!", "Error Master Watch", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                enabled();
            }
        }

        private void deleteBtn_Click_1(object sender, EventArgs e)
        {
            if (watchNameTxt.Text == "" && watchPriceTxt.Text == "" && stockNud.Value == 0)
            {
                MessageBox.Show("Please choose data first!", "Error Master Watch", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are you sure want to delete this data?", "Delete Data", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {

                    string ID = watchIdTxt.Text;
                    mw = (from watch in watchDB.Watches where ID == watch.WatchId select watch).FirstOrDefault();

                    watchDB.Watches.DeleteObject(mw);
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

        private void watchDgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = watchDgv.Rows[e.RowIndex];

            watchIdTxt.Text = row.Cells[0].Value.ToString(); 
            watchNameTxt.Text = row.Cells[1].Value.ToString(); 
            watchPriceTxt.Text = row.Cells[2].Value.ToString(); 
            watchTypeCb.Text = row.Cells[3].Value.ToString(); 
            stockNud.Text = row.Cells[4].Value.ToString(); 
        }
    }
}
