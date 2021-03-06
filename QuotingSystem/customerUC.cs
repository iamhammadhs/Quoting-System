using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace QuotingSystem
{
    public partial class customerUC : UserControl
    {
        public customerUC()
        {
            InitializeComponent();
        }

        private void customerUC_Load(object sender, EventArgs e)
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
                salesIDComboBox.DataSource = read;
                salesIDComboBox.DisplayMember = "StaffID";
                customerIDComboBox.Text = "None";
                CompanyNameComboBox.Text = "None";
                salesIDComboBox.Text = "None";
                salesPersonTextBox.Text = "None";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tblcustomerTableAdapter.Fill(this.quotingsystemDataSet.tblcustomer);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

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
                    companyNameTextBox.Text = read.Rows[0][1].ToString();
                    contactTitleTextBox.Text = read.Rows[0][2].ToString();
                    contactNameTextBox.Text = read.Rows[0][3].ToString();
                    deliveryAddressTextBox.Text = read.Rows[0][4].ToString();
                    deliveryTownTextBox.Text = read.Rows[0][5].ToString();
                    deliveryRegionTextBox.Text = read.Rows[0][6].ToString();
                    postalAddressTextBox.Text = read.Rows[0][7].ToString();
                    postalTownTextBox.Text = read.Rows[0][8].ToString();
                    postalCodeTextBox.Text = read.Rows[0][9].ToString();
                    phoneTextBox.Text = read.Rows[0][10].ToString();
                    mobileTextBox.Text = read.Rows[0][11].ToString();
                    faxTextBox.Text = read.Rows[0][12].ToString();
                    emailTextBox.Text = read.Rows[0][13].ToString();
                    salesIDComboBox.Text = read.Rows[0][14].ToString();
                    q = "select * from tblstaff where StaffID='" + salesIDComboBox.Text + "'";
                    read = db.searchquery(q);
                    salesPersonTextBox.Text = read.Rows[0][2].ToString();
                    db.close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (companyIDTextBox.Text == "" || companyNameTextBox.Text == "" || contactTitleTextBox.Text == "" || contactNameTextBox.Text == "" || deliveryAddressTextBox.Text == "" || deliveryTownTextBox.Text == "" || deliveryRegionTextBox.Text == "" || postalAddressTextBox.Text == "" || postalTownTextBox.Text == "" || postalCodeTextBox.Text == "" || phoneTextBox.Text == "" || mobileTextBox.Text == "" || faxTextBox.Text == "" || emailTextBox.Text == "" || salesIDComboBox.Text == "" || salesPersonTextBox.Text == "")
            {
                MessageBox.Show("Please enter all fields.", "Form Validation");
            }
            else
            {
                try
                {
                    string q;
                    Database db = new Database();
                    db.open();
                    string companyID = companyIDTextBox.Text;
                    string companyName = companyNameTextBox.Text;
                    string contactTitle = contactTitleTextBox.Text;
                    string contactName = contactNameTextBox.Text;
                    string deliveryAddress = deliveryAddressTextBox.Text;
                    string deliveryTown = deliveryTownTextBox.Text;
                    string deliveryRegion = deliveryRegionTextBox.Text;
                    string postalAddress = postalAddressTextBox.Text;
                    string postalTown = postalTownTextBox.Text;
                    string postalCode = postalCodeTextBox.Text;
                    string phone = phoneTextBox.Text;
                    string mobile = mobileTextBox.Text;
                    string fax = faxTextBox.Text;
                    string email = emailTextBox.Text;
                    string salesID = salesIDComboBox.Text;
                    q = "select * from tblstaff where StaffID='" + salesIDComboBox.Text + "'";
                    DataTable read = db.searchquery(q);
                    read = db.searchquery(q);
                    string salesPerson = read.Rows[0][2].ToString();
                    salesPersonTextBox.Text = salesPerson;
                    q = "select * from tblcustomer where CustomerID='" + companyID + "'";
                    read = db.searchquery(q);
                    if (read.Rows.Count == 0)
                    {
                        q = "INSERT INTO `tblcustomer`(`CustomerID`, `CompanyName`, `ContactTitle`, `ContactName`, `Address`, `Town`, `Region`, `POAddress`, `POTown`, `POCode`, `Phone`, `Mobile`, `Fax`, `E-mail`, `SalesID`, `Discount`) VALUES ('" + companyID + "','" + companyName + "','" + contactTitle + "','" + contactName + "','" + deliveryAddress + "','" + deliveryTown + "','" + deliveryRegion + "','" + postalAddress + "','" + postalTown + "','" + postalCode + "','" + phone + "','" + mobile + "','" + fax + "','" + email + "','" + salesID + "','0')";
                        db.insertquery(q);
                        MessageBox.Show("Inserted a New Customer Record", "Customer");
                        companyIDTextBox.Text = "";
                        companyNameTextBox.Text = "";
                        contactTitleTextBox.Text = "";
                        contactNameTextBox.Text = "";
                        deliveryAddressTextBox.Text = "";
                        deliveryTownTextBox.Text = "";
                        deliveryRegionTextBox.Text = "";
                        postalAddressTextBox.Text = "";
                        postalTownTextBox.Text = "";
                        postalCodeTextBox.Text = "";
                        phoneTextBox.Text = "";
                        mobileTextBox.Text = "";
                        faxTextBox.Text = "";
                        emailTextBox.Text = "";
                        salesIDComboBox.Text = "";
                        salesPersonTextBox.Text = ""; 
                        q = "select * from tblcustomer";
                        read = db.searchquery(q);
                        customerIDComboBox.DataSource = read;
                        customerIDComboBox.DisplayMember = "CustomerID";
                        CompanyNameComboBox.DataSource = read;
                        CompanyNameComboBox.DisplayMember = "CompanyName";
                        customerIDComboBox.Text = "None";
                        CompanyNameComboBox.Text = "None";
                        db.close();
                    }
                    else
                    {
                        q = "UPDATE `tblcustomer` SET `CustomerID`='" + companyID + "',`CompanyName`='" + companyName + "',`ContactTitle`='" + contactTitle + "',`ContactName`='" + contactName + "',`Address`='" + deliveryAddress + "',`Town`='" + deliveryTown + "',`Region`='" + deliveryRegion + "',`POAddress`='" + postalAddress + "',`POTown`='" + postalTown + "',`POCode`='" + postalCode + "',`Phone`='" + phone + "',`Mobile`='" + mobile + "',`Fax`='" + fax + "',`E-mail`='" + email + "',`SalesID`='" + salesID + "',`Discount`='0'" + " WHERE `CustomerID`='" + companyID + "'";
                        db.updatequery(q);
                        MessageBox.Show("Updated the Customer Record", "Customer");
                        companyIDTextBox.Text = "";
                        companyNameTextBox.Text = "";
                        contactTitleTextBox.Text = "";
                        contactNameTextBox.Text = "";
                        deliveryAddressTextBox.Text = "";
                        deliveryTownTextBox.Text = "";
                        deliveryRegionTextBox.Text = "";
                        postalAddressTextBox.Text = "";
                        postalTownTextBox.Text = "";
                        postalCodeTextBox.Text = "";
                        phoneTextBox.Text = "";
                        mobileTextBox.Text = "";
                        faxTextBox.Text = "";
                        emailTextBox.Text = "";
                        salesIDComboBox.Text = "";
                        salesPersonTextBox.Text = "";
                        q = "select * from tblcustomer";
                        read = db.searchquery(q);
                        customerIDComboBox.DataSource = read;
                        customerIDComboBox.DisplayMember = "CustomerID";
                        CompanyNameComboBox.DataSource = read;
                        CompanyNameComboBox.DisplayMember = "CompanyName";
                        customerIDComboBox.Text = "None";
                        CompanyNameComboBox.Text = "None";
                        db.close();
                    }
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Customer Page");
                 
                }
            }
        }

        private void salesPersonTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
