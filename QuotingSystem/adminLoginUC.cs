using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuotingSystem
{
    public partial class adminLoginUC : UserControl
    {
        public adminLoginUC()
        {
            InitializeComponent();
            adminLogin.Visible = true;
            Load += adminLoginUC_Load;
        }
        private void adminLoginUC_Load(Object sender, EventArgs e)
        {
            adminLogin.Visible = true;
        }
        private void login_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            db.open();
            string usernameT = username.Text;
            string passwordT = password.Text;
            DataTable read;
            string query;
            query = "SELECT * FROM `tbladmin` WHERE `username`='" + usernameT + "' and `password`='" + passwordT + "'";
            db.open();
            read = db.searchquery(query);
            db.close();
            if (read.Rows.Count != 1)
            {
                MessageBox.Show("Invalid Username Or Password", "Login");
            }
            else
            {
                adminDashboardUC1.Visible = true;
                adminDashboardUC1.BringToFront();
                username.Text = "";
                password.Text = "";
            }
        }
        public void setActivePanel(UserControl userControl)
        {
            adminDashboardUC1.Visible = false;
            adminLogin.Visible = false;
            userControl.Visible = true;
        }
        private void adminDashboardUC1_Load(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_Click_1(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel1_Click_1(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel3_Click_1(object sender, EventArgs e)
        {

        }

        private void username_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void password_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel2_Click_1(object sender, EventArgs e)
        {

        }

        
    }
}
