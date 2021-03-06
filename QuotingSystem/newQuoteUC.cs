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
    public partial class newQuoteUC : UserControl
    {
        public newQuoteUC()
        {
            InitializeComponent();
        }

        private void newQuoteUC_Load(object sender, EventArgs e)
        {
            try
            {
                Database db = new Database();
                db.open();
                string q = "select * from tblcustomer";
                DataTable read = db.searchquery(q);
                customerIDComboBox.DataSource = read;
                customerIDComboBox.DisplayMember = "CustomerID";
                CompanyNameComboBox.DataSource = read;
                CompanyNameComboBox.DisplayMember = "CompanyName";
                q = "select * from tblstaff";
                read = db.searchquery(q);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void salesIDComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomTextbox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void loadData_Click(object sender, EventArgs e)
        {
            string customerID = customerIDComboBox.Text;
            string companyName = CompanyNameComboBox.Text;
            try
            {
                Database db = new Database();
                db.open();
                string q = "select * from tblcustomer where CustomerID='" + customerID + "' and CompanyName='" + companyName + "'";
                DataTable read = db.searchquery(q);
                if (read.Rows.Count == 1)
                {
                    companyIDTextBox.Text = read.Rows[0][0].ToString();
                    contactNameTextBox.Text = read.Rows[0][3].ToString();
                    deliveryTownTextBox.Text = read.Rows[0][5].ToString();
                    deliveryRegionTextBox.Text = read.Rows[0][6].ToString();
                    deliveryAddressTextBox.Text = read.Rows[0][7].ToString();
                    deliveryTownTextBox.Text = read.Rows[0][8].ToString();
                    phoneTextBox.Text = read.Rows[0][10].ToString();
                    faxTextBox.Text = read.Rows[0][12].ToString();
                    emailTextBox.Text = read.Rows[0][13].ToString();
                    db.close();
                }
                else
                {
                    companyIDTextBox.Text = "";
                    contactNameTextBox.Text = "";
                    deliveryTownTextBox.Text = "";
                    deliveryRegionTextBox.Text = "";
                    deliveryAddressTextBox.Text = "";
                    deliveryTownTextBox.Text = "";
                    phoneTextBox.Text = "";
                    faxTextBox.Text = "";
                    emailTextBox.Text = "";
                    db.close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
