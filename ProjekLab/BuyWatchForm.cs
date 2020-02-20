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
    public partial class BuyWatchForm : Form
    {
        WatchDBEntities watchDB = new WatchDBEntities();
        Watch mw = new Watch();
        User u = new User();
        SalesTransaction st = new SalesTransaction();
        DetailSales ds = new DetailSales();

        public BuyWatchForm()
        {
            InitializeComponent();
            
            initialState();
            loadData();
        }

        public void initialState()
        {
            watchIdTxt.Enabled = false;
            watchNameTxt.Enabled = false;
            watchPriceTxt.Enabled = false;
            watchTypeTxt.Enabled = false;
            quantityNud.Enabled = false;

            watchNameTxt.Text = "";
            watchPriceTxt.Text = "";
            quantityNud.Value = 0;
        }

        void loadData() {
            watchDgv.DataSource = (from watch in watchDB.Watches 
                                   select new {WatchId = watch.WatchId, 
                                       WatchName = watch.WatchName, 
                                       WatchPrice = watch.WatchPrice, 
                                       WatchTypeName = watch.WatchType.WatchTypeName, 
                                       Stock = watch.WatchStock
                                   });
        }

        private void buyBtn_Click(object sender, EventArgs e)
        {
            string message = validate();

            if (message != "")
            {
                MessageBox.Show(message, "Error Buy Watch", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DateTime currentDT = DateTime.Now;
                mw = (from w in watchDB.Watches
                      where watchIdTxt.Text == w.WatchId
                      select w).FirstOrDefault();

                mw.WatchStock -= Decimal.ToInt32(quantityNud.Value);

                string lastID = (from tr in watchDB.SalesTransactions
                                 orderby tr.TransactionId descending
                                 select tr.TransactionId).FirstOrDefault();

                if (lastID != null && lastID != "")
                {
                    string noLastID = lastID.Substring(2);
                    int newID = int.Parse(noLastID) + 1;
                    string newTrID = "TR" + newID.ToString("000");
                    st.TransactionId = newTrID;
                    ds.TransactionId = newTrID;
                }
                else
                {
                    string newTrID = "TR001";
                    st.TransactionId = newTrID;
                    ds.TransactionId = newTrID;
                }

                st.TransactionDate = currentDT;
                st.UserId = LoginForm.userIDLogin;
                
                ds.WatchId = watchIdTxt.Text;
                ds.Quantity = decimal.ToInt32(quantityNud.Value);

                watchDB.SalesTransactions.AddObject(st);
                watchDB.DetailSales1.AddObject(ds);
                watchDB.SaveChanges();

                loadData();
                //MessageBox.Show(LoginForm.userIDLogin, "Success Buy Watch", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show("Successfully buy watch!", "Success Buy Watch", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                initialState();
            }
        }

        private string validate()
        {
            int searchStock = (from w in watchDB.Watches
                               where watchIdTxt.Text == w.WatchId
                               select w.WatchStock).FirstOrDefault();

            string watchName = watchNameTxt.Text;
            string watchType = watchTypeTxt.Text;
            string watchPrice = watchPriceTxt.Text;
            int quantity = (int)quantityNud.Value;

            if (watchName == "" && watchType == "" && watchPrice == "")
            {
                return "Please choose data first!";
            }
            else if (quantity < 1)
            {
                return "Quantity must be more or equal to 1!";
            }
            else if (quantity > searchStock)
            {
                return "Quantity must be less or equals to Stock!";
            }
            return "";
        }

        private void watchDgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = watchDgv.Rows[e.RowIndex];

            watchIdTxt.Text = row.Cells[0].Value.ToString();
            watchNameTxt.Text = row.Cells[1].Value.ToString();
            watchTypeTxt.Text = row.Cells[3].Value.ToString();
            watchPriceTxt.Text = row.Cells[2].Value.ToString();
            quantityNud.Enabled = true;
        }
    }
}
