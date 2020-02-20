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
    public partial class ViewHistoryForm : Form
    {
        WatchDBEntities watchDB = new WatchDBEntities();
        Watch mw = new Watch();

        public ViewHistoryForm()
        {
            InitializeComponent();

            initialState();
        }

        private void initialState(){
            dataGridDetail.DataSource = "";
            dataGridHeader.DataSource = "";
            watchIdTxt.Enabled = false;
            watchNameTxt.Enabled = false;
            watchTypeTxt.Enabled = false;
            watchPriceTxt.Enabled = false;
            quantityTxt.Enabled = false;
            totalPriceTxt.Enabled = false;
        }

        private void goBtn_Click(object sender, EventArgs e)
        {
            dataGridHeader.DataSource = (from h in watchDB.SalesTransactions
                                         where h.TransactionDate.Day == transactionDateDP.Value.Day
                                            && h.TransactionDate.Month == transactionDateDP.Value.Month
                                            && h.TransactionDate.Year == transactionDateDP.Value.Year
                                            && h.UserId == LoginForm.userIDLogin
                                         select new { 
                                            TransactionID = h.TransactionId,
                                            TransactionDate = h.TransactionDate,
                                            UserID = h.UserId
                                         }
                                        );
            dataGridDetail.DataSource = "";
        }

        private void dataGridHeader_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dataGridHeader.Rows[e.RowIndex];
            string transactionID = row.Cells[0].Value.ToString();

            dataGridDetail.DataSource = (from d in watchDB.DetailSales1
                                         where d.TransactionId == transactionID
                                         select new
                                         {
                                             TransactionID = d.TransactionId,
                                             WatchID = d.WatchId,
                                             Quantity = d.Quantity
                                         }
                                        );
        }

        private void dataGridDetail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dataGridDetail.Rows[e.RowIndex];
            string watchId = row.Cells[1].Value.ToString();
            string watchName = (from w in watchDB.Watches
                                where w.WatchId == watchId
                                select w.WatchName).FirstOrDefault();
            string watchTypeName = (from w in watchDB.Watches
                                    where w.WatchId == watchId 
                                    select w.WatchType.WatchTypeName).FirstOrDefault();
            int watchPrice = (from w in watchDB.Watches
                                 where w.WatchId == watchId
                                 select w.WatchPrice).FirstOrDefault();

            watchIdTxt.Text = watchId;
            watchNameTxt.Text = watchName;
            watchTypeTxt.Text = watchTypeName;
            watchPriceTxt.Text = watchPrice.ToString();
            quantityTxt.Text = row.Cells[2].Value.ToString();
            totalPriceTxt.Text = (int.Parse(quantityTxt.Text) * watchPrice).ToString();    
        }
    }
}
