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
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr one, int two, int three, int four);

        private void login_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            db.open();
            string usernameT = username.Text;
            string passwordT = password.Text;
            DataTable read;
            string query;
            query = "select * from tblstaff where StaffID='" + usernameT + "' and password='" + passwordT + "'";
            db.open();
            read = db.searchquery(query);
            db.close();
            if (read.Rows.Count != 1)
            {
                MessageBox.Show("Invalid Username Or Password", "Login");
            }
            else
            {
                Dashboard form = new Dashboard();
                username.Text = "";
                password.Text = "";
                form.Show();
                this.Hide();
            }
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {

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

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
