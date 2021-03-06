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
    public partial class adminDashboardUC : UserControl
    {
        public adminDashboardUC()
        {
            InitializeComponent();
            Load += Dashboard_Load;
        }
        public void Dashboard_Load(object sender, EventArgs e)
        {

        }
        private void customerDetailsBtn_Click(object sender, EventArgs e)
        {

        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void newStaffUC1_Load(object sender, EventArgs e)
        {

        }
    }
}
