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
    public partial class MainFormAdmin : Form
    {
        public MainFormAdmin()
        {
            InitializeComponent();
        }

        private void exitStrMenu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void viewAllTransStrMenu_Click(object sender, EventArgs e)
        {
            ViewAllTransactionForm vtf = new ViewAllTransactionForm();
            vtf.Show();
        }

        private void changePasswordStrMenu_Click_1(object sender, EventArgs e)
        {
            ChangePasswordForm changePass = new ChangePasswordForm();
            changePass.Show();
        }

        private void logoutStrMenu_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void masterWatchStrMenu_Click_1(object sender, EventArgs e)
        {
            Master_Watch_Form mwf = new Master_Watch_Form();
            mwf.Show();
        }

        private void masterWatchTypeStrMenu_Click(object sender, EventArgs e)
        {
            MasterWatchType mwt = new MasterWatchType();
            mwt.Show();
        }

        private void masterUserStrMenu_Click_1(object sender, EventArgs e)
        {
            MasterUser mu = new MasterUser();
            mu.Show();
        }
    }
}
