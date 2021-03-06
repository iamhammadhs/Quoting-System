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
    public partial class newStaffUC : UserControl
    {
        public newStaffUC()
        {
            InitializeComponent();
        }

        private void loadData_Click(object sender, EventArgs e)
        {
            string staffID = userIDComboBox.Text;
            string staffName = staffNameComboBox.Text;
            try
            {
                Database db = new Database();
                db.open();
                string temp;
                string q = "select * from tblstaff where StaffID='" + staffID + "' and Name='" + staffName + "'";
                DataTable read = db.searchquery(q);
                if (read.Rows.Count == 1)
                {
                    staffIDTextBox.Text = read.Rows[0][0].ToString();
                    passwordTextBox.Text = read.Rows[0][1].ToString();
                    confirmPasswordTextBox.Text = read.Rows[0][1].ToString();
                    staffNameTextBox.Text = read.Rows[0][2].ToString();
                    temp = read.Rows[0][3].ToString();
                    if (temp == "0")
                    {
                        isManagerComboBox.Text = "No";
                    }
                    else
                    {
                        isManagerComboBox.Text = "Yes";
                    }
                    temp = read.Rows[0][4].ToString();
                    if (temp == "0")
                    {
                        isActiveComboBox.Text = "No";
                    }
                    else
                    {
                        isActiveComboBox.Text = "Yes";
                    }

                    db.close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void userIDComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void newStaffUC_Load(object sender, EventArgs e)
        {
            try
            {
                Database db = new Database();
                db.open();
                string q = "select * from tblstaff";
                DataTable read = db.searchquery(q);

                userIDComboBox.DataSource = read;
                userIDComboBox.DisplayMember = "StaffID";
                staffNameComboBox.DataSource = read;
                staffNameComboBox.DisplayMember = "Name";
                db.close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            string staffID = staffIDTextBox.Text;
            string staffName = staffNameTextBox.Text;
            string password = passwordTextBox.Text;
            string confirmPassword = confirmPasswordTextBox.Text;
            string isManager = isManagerComboBox.Text;
            string isActive = isActiveComboBox.Text;
            if (isManagerComboBox.Text == "Yes")
            {
                isManager = "1";
            }
            else
            {
                isManager = "0";
            }
            if (isActiveComboBox.Text == "Yes")
            {
                isActive = "1";
            }
            else
            {
                isActive = "0";
            }
            if (staffID == "" || staffName == "" || password == "" || confirmPassword == "" || isManager == "" || isActive == "")
            {
                MessageBox.Show("Please Enter All Fields.", "Add New Staff Error");
            }
            else
            {
                if (password != confirmPassword)
                {
                    MessageBox.Show("The Entered Passwords Dont Match.", "Add New Staff Error");
                    return;
                }
                else
                {
                    Database db = new Database();
                    db.open();
                    string query;
                    query = "select * from tblstaff where StaffID='" + staffID + "'";
                    DataTable read = db.searchquery(query);
                    if (read.Rows.Count == 0)
                    {
                        query = "INSERT INTO `tblstaff`(`StaffID`, `password`, `Name`, `Manager?`, `InActive?`) VALUES ('" + staffID + "','" + staffName + "','" + password + "','" + isManager + "','" + isActive + "')";
                        MessageBox.Show("Added a New User SuccessFully", "User Message"); 
                        if (isManager == "1")
                        {
                            query = "INSERT INTO `tblstaff`(`StaffID`, `password`, `Name`, `Manager?`, `InActive?`) VALUES ('" + staffID + "','" + staffName + "','" + password + "','" + isManager + "','" + isActive + "')";
                            MessageBox.Show("Added a New Admin SuccessFully", "User Message");

                        }
                    }
                    else
                    {
                        query = "UPDATE `tblstaff` SET `StaffID`='" + staffID + "',`password`='" + password + "',`Name`='" + staffName + "',`Manager?`='" + isManager + "',`InActive?`='" + isActive + "' WHERE `StaffID`=" + staffID; 
                        MessageBox.Show("Updated User SuccessFully", "User Message");
                    }
                    
                    
                }
            }
        }
    }
}
