using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuotingSystem.Properties;

namespace QuotingSystem
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            Load += Dashboard_Load;
        }
        public void Dashboard_Load(object sender, EventArgs e)
        {
            setActivePanel(dashboardUC1);
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr one, int two, int three, int four);

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
                button2.Image = Resources.icons8_normal_screen_15px_1;
            }
            else
            {
                WindowState = FormWindowState.Normal;
                button2.Image = Resources.icons8_full_screen_15px_1;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            setActivePanel(dashboardUC1);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void dashboardBtn_Click(object sender, EventArgs e)
        {
            setActivePanel(dashboardUC1);
        }

        

        private void newQuoteBtn_Click(object sender, EventArgs e)
        {
            setActivePanel(newQuoteUC1);
        }

        public void setActivePanel(UserControl userControl)
        {
            dashboardUC1.Visible = false;
            newQuoteUC1.Visible = false;
            customerUC1.Visible = false;
            adminLoginUC1.Visible = false;
            userControl.Visible = true;
        }

        private void customerDetailsBtn_Click(object sender, EventArgs e)
        {
            setActivePanel(customerUC1);
        }

        private void customerUC1_Load(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            setActivePanel(adminLoginUC1);
        }

        private void newQuoteUC1_Load(object sender, EventArgs e)
        {

        }
    }
}
