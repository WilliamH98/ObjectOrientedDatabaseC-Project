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
    public partial class MainFormMember : Form
    {
        
        public MainFormMember()
        {
            InitializeComponent();
        }

        private void exitStrMenu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buyWatchStrMenu_Click(object sender, EventArgs e)
        {
            BuyWatchForm bwf = new BuyWatchForm();
            bwf.Show();
        }

        private void viewHistoryStrMenu_Click(object sender, EventArgs e)
        {
            ViewHistoryForm vhf = new ViewHistoryForm();
            vhf.Show();
        }

        private void logoutStrMenu_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void changePassStrMenu_Click(object sender, EventArgs e)
        {
            ChangePasswordForm changePass = new ChangePasswordForm();
            changePass.Show();
        }
    }
}
