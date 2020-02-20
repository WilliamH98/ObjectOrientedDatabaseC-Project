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
    public partial class ViewAllTransactionForm : Form
    {
        WatchDBEntities watchDB = new WatchDBEntities();
        public ViewAllTransactionForm()
        {
            InitializeComponent();
            initialState();
        }

        public void initialState() {
            salesTransactionDgv.DataSource = (from ds in watchDB.DetailSales1
                                              select new {
                                                Fullname = ds.SalesTransaction.User.Fullname,
                                                WatchId = ds.WatchId,
                                                WatchName = ds.Watch.WatchName,
                                                WatchTypeName = ds.Watch.WatchType.WatchTypeName,
                                                Quantity = ds.Quantity,
                                                WatchPrice = ds.Watch.WatchPrice
                                              });
        }

        private void salesTransactionDgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = salesTransactionDgv.Rows[e.RowIndex];

            fullnameTxt.Text = row.Cells[0].Value.ToString();
            watchIdTxt.Text = row.Cells[1].Value.ToString();
            watchNameTxt.Text = row.Cells[2].Value.ToString();
            watchTypeTxt.Text = row.Cells[3].Value.ToString();
            quantityTxt.Text = row.Cells[4].Value.ToString();
            watchPriceTxt.Text = row.Cells[5].Value.ToString();
            totalPriceTxt.Text = (int.Parse(quantityTxt.Text) * int.Parse(watchPriceTxt.Text)).ToString();
        }
    }
}
