namespace QuotingSystem
{
    partial class customerUC
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.customerIDComboBox = new System.Windows.Forms.ComboBox();
            this.tblcustomerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quotingsystemDataSet = new QuotingSystem.quotingsystemDataSet();
            this.tblcustomerTableAdapter = new QuotingSystem.quotingsystemDataSetTableAdapters.tblcustomerTableAdapter();
            this.CompanyNameComboBox = new System.Windows.Forms.ComboBox();
            this.loadData = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.companyIDTextBox = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.companyNameTextBox = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.postalAddressTextBox = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.postalTownTextBox = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.postalCodeTextBox = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.deliveryAddressTextBox = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.deliveryTownTextBox = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.deliveryRegionTextBox = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.phoneTextBox = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.mobileTextBox = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.emailTextBox = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.faxTextBox = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.contactTitleTextBox = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.contactNameTextBox = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.salesIDComboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.salesPersonTextBox = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.tblcustomerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quotingsystemDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(14, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 34);
            this.label1.TabIndex = 6;
            this.label1.Text = "Customer Data Page";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(16, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Select Company ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(376, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(240, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "Select Company Name";
            // 
            // customerIDComboBox
            // 
            this.customerIDComboBox.BackColor = System.Drawing.Color.DimGray;
            this.customerIDComboBox.DataSource = this.tblcustomerBindingSource;
            this.customerIDComboBox.DisplayMember = "CustomerID";
            this.customerIDComboBox.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerIDComboBox.ForeColor = System.Drawing.Color.White;
            this.customerIDComboBox.FormattingEnabled = true;
            this.customerIDComboBox.Location = new System.Drawing.Point(222, 86);
            this.customerIDComboBox.Name = "customerIDComboBox";
            this.customerIDComboBox.Size = new System.Drawing.Size(152, 31);
            this.customerIDComboBox.TabIndex = 10;
            // 
            // tblcustomerBindingSource
            // 
            this.tblcustomerBindingSource.DataMember = "tblcustomer";
            this.tblcustomerBindingSource.DataSource = this.quotingsystemDataSet;
            // 
            // quotingsystemDataSet
            // 
            this.quotingsystemDataSet.DataSetName = "quotingsystemDataSet";
            this.quotingsystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblcustomerTableAdapter
            // 
            this.tblcustomerTableAdapter.ClearBeforeFill = true;
            // 
            // CompanyNameComboBox
            // 
            this.CompanyNameComboBox.BackColor = System.Drawing.Color.DimGray;
            this.CompanyNameComboBox.DataSource = this.tblcustomerBindingSource;
            this.CompanyNameComboBox.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompanyNameComboBox.ForeColor = System.Drawing.Color.White;
            this.CompanyNameComboBox.FormattingEnabled = true;
            this.CompanyNameComboBox.Location = new System.Drawing.Point(622, 86);
            this.CompanyNameComboBox.Name = "CompanyNameComboBox";
            this.CompanyNameComboBox.Size = new System.Drawing.Size(247, 31);
            this.CompanyNameComboBox.TabIndex = 11;
            // 
            // loadData
            // 
            this.loadData.BackColor = System.Drawing.Color.DimGray;
            this.loadData.Location = new System.Drawing.Point(901, 72);
            this.loadData.Name = "loadData";
            this.loadData.Size = new System.Drawing.Size(113, 53);
            this.loadData.TabIndex = 12;
            this.loadData.Text = "Load";
            this.loadData.UseVisualStyleBackColor = false;
            this.loadData.Click += new System.EventHandler(this.loadData_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(16, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 23);
            this.label4.TabIndex = 14;
            this.label4.Text = "ID";
            // 
            // companyIDTextBox
            // 
            this.companyIDTextBox.BackColor = System.Drawing.Color.Gray;
            this.companyIDTextBox.BorderColor = System.Drawing.Color.Gray;
            this.companyIDTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.companyIDTextBox.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companyIDTextBox.ForeColor = System.Drawing.Color.Transparent;
            this.companyIDTextBox.Location = new System.Drawing.Point(52, 173);
            this.companyIDTextBox.Name = "companyIDTextBox";
            this.companyIDTextBox.Size = new System.Drawing.Size(152, 32);
            this.companyIDTextBox.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(376, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 23);
            this.label5.TabIndex = 16;
            this.label5.Text = "Company";
            // 
            // companyNameTextBox
            // 
            this.companyNameTextBox.BackColor = System.Drawing.Color.Gray;
            this.companyNameTextBox.BorderColor = System.Drawing.Color.Gray;
            this.companyNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.companyNameTextBox.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companyNameTextBox.ForeColor = System.Drawing.Color.Transparent;
            this.companyNameTextBox.Location = new System.Drawing.Point(490, 173);
            this.companyNameTextBox.Name = "companyNameTextBox";
            this.companyNameTextBox.Size = new System.Drawing.Size(247, 32);
            this.companyNameTextBox.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(15, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 28);
            this.label6.TabIndex = 18;
            this.label6.Text = "Postal";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(375, 225);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 28);
            this.label7.TabIndex = 19;
            this.label7.Text = "Delivery";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(48, 276);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 23);
            this.label8.TabIndex = 20;
            this.label8.Text = "Address";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(48, 321);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 23);
            this.label9.TabIndex = 21;
            this.label9.Text = "Town";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(48, 368);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 23);
            this.label10.TabIndex = 22;
            this.label10.Text = "Code";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(376, 368);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 23);
            this.label11.TabIndex = 25;
            this.label11.Text = "Region";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(376, 321);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 23);
            this.label12.TabIndex = 24;
            this.label12.Text = "Town";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(376, 276);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 23);
            this.label13.TabIndex = 23;
            this.label13.Text = "Address";
            // 
            // postalAddressTextBox
            // 
            this.postalAddressTextBox.BackColor = System.Drawing.Color.Gray;
            this.postalAddressTextBox.BorderColor = System.Drawing.Color.Gray;
            this.postalAddressTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.postalAddressTextBox.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postalAddressTextBox.ForeColor = System.Drawing.Color.Transparent;
            this.postalAddressTextBox.Location = new System.Drawing.Point(142, 274);
            this.postalAddressTextBox.Name = "postalAddressTextBox";
            this.postalAddressTextBox.Size = new System.Drawing.Size(152, 32);
            this.postalAddressTextBox.TabIndex = 26;
            // 
            // postalTownTextBox
            // 
            this.postalTownTextBox.BackColor = System.Drawing.Color.Gray;
            this.postalTownTextBox.BorderColor = System.Drawing.Color.Gray;
            this.postalTownTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.postalTownTextBox.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postalTownTextBox.ForeColor = System.Drawing.Color.Transparent;
            this.postalTownTextBox.Location = new System.Drawing.Point(142, 319);
            this.postalTownTextBox.Name = "postalTownTextBox";
            this.postalTownTextBox.Size = new System.Drawing.Size(152, 32);
            this.postalTownTextBox.TabIndex = 27;
            // 
            // postalCodeTextBox
            // 
            this.postalCodeTextBox.BackColor = System.Drawing.Color.Gray;
            this.postalCodeTextBox.BorderColor = System.Drawing.Color.Gray;
            this.postalCodeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.postalCodeTextBox.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postalCodeTextBox.ForeColor = System.Drawing.Color.Transparent;
            this.postalCodeTextBox.Location = new System.Drawing.Point(142, 366);
            this.postalCodeTextBox.Name = "postalCodeTextBox";
            this.postalCodeTextBox.Size = new System.Drawing.Size(152, 32);
            this.postalCodeTextBox.TabIndex = 28;
            // 
            // deliveryAddressTextBox
            // 
            this.deliveryAddressTextBox.BackColor = System.Drawing.Color.Gray;
            this.deliveryAddressTextBox.BorderColor = System.Drawing.Color.Gray;
            this.deliveryAddressTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.deliveryAddressTextBox.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deliveryAddressTextBox.ForeColor = System.Drawing.Color.Transparent;
            this.deliveryAddressTextBox.Location = new System.Drawing.Point(470, 274);
            this.deliveryAddressTextBox.Name = "deliveryAddressTextBox";
            this.deliveryAddressTextBox.Size = new System.Drawing.Size(152, 32);
            this.deliveryAddressTextBox.TabIndex = 29;
            // 
            // deliveryTownTextBox
            // 
            this.deliveryTownTextBox.BackColor = System.Drawing.Color.Gray;
            this.deliveryTownTextBox.BorderColor = System.Drawing.Color.Gray;
            this.deliveryTownTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.deliveryTownTextBox.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deliveryTownTextBox.ForeColor = System.Drawing.Color.Transparent;
            this.deliveryTownTextBox.Location = new System.Drawing.Point(470, 319);
            this.deliveryTownTextBox.Name = "deliveryTownTextBox";
            this.deliveryTownTextBox.Size = new System.Drawing.Size(152, 32);
            this.deliveryTownTextBox.TabIndex = 30;
            // 
            // deliveryRegionTextBox
            // 
            this.deliveryRegionTextBox.BackColor = System.Drawing.Color.Gray;
            this.deliveryRegionTextBox.BorderColor = System.Drawing.Color.Gray;
            this.deliveryRegionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.deliveryRegionTextBox.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deliveryRegionTextBox.ForeColor = System.Drawing.Color.Transparent;
            this.deliveryRegionTextBox.Location = new System.Drawing.Point(470, 366);
            this.deliveryRegionTextBox.Name = "deliveryRegionTextBox";
            this.deliveryRegionTextBox.Size = new System.Drawing.Size(152, 32);
            this.deliveryRegionTextBox.TabIndex = 31;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(17, 429);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(71, 23);
            this.label14.TabIndex = 32;
            this.label14.Text = "Phone";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(252, 429);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(77, 23);
            this.label15.TabIndex = 33;
            this.label15.Text = "Mobile";
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.BackColor = System.Drawing.Color.Gray;
            this.phoneTextBox.BorderColor = System.Drawing.Color.Gray;
            this.phoneTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.phoneTextBox.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneTextBox.ForeColor = System.Drawing.Color.Transparent;
            this.phoneTextBox.Location = new System.Drawing.Point(94, 427);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(152, 32);
            this.phoneTextBox.TabIndex = 34;
            // 
            // mobileTextBox
            // 
            this.mobileTextBox.BackColor = System.Drawing.Color.Gray;
            this.mobileTextBox.BorderColor = System.Drawing.Color.Gray;
            this.mobileTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mobileTextBox.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mobileTextBox.ForeColor = System.Drawing.Color.Transparent;
            this.mobileTextBox.Location = new System.Drawing.Point(335, 427);
            this.mobileTextBox.Name = "mobileTextBox";
            this.mobileTextBox.Size = new System.Drawing.Size(152, 32);
            this.mobileTextBox.TabIndex = 35;
            // 
            // emailTextBox
            // 
            this.emailTextBox.BackColor = System.Drawing.Color.Gray;
            this.emailTextBox.BorderColor = System.Drawing.Color.Gray;
            this.emailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emailTextBox.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTextBox.ForeColor = System.Drawing.Color.Transparent;
            this.emailTextBox.Location = new System.Drawing.Point(796, 427);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(152, 32);
            this.emailTextBox.TabIndex = 39;
            // 
            // faxTextBox
            // 
            this.faxTextBox.BackColor = System.Drawing.Color.Gray;
            this.faxTextBox.BorderColor = System.Drawing.Color.Gray;
            this.faxTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.faxTextBox.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.faxTextBox.ForeColor = System.Drawing.Color.Transparent;
            this.faxTextBox.Location = new System.Drawing.Point(570, 427);
            this.faxTextBox.Name = "faxTextBox";
            this.faxTextBox.Size = new System.Drawing.Size(152, 32);
            this.faxTextBox.TabIndex = 38;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(728, 429);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(62, 23);
            this.label16.TabIndex = 37;
            this.label16.Text = "Email";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(520, 429);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(44, 23);
            this.label17.TabIndex = 36;
            this.label17.Text = "Fax";
            // 
            // contactTitleTextBox
            // 
            this.contactTitleTextBox.BackColor = System.Drawing.Color.Gray;
            this.contactTitleTextBox.BorderColor = System.Drawing.Color.Gray;
            this.contactTitleTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.contactTitleTextBox.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactTitleTextBox.ForeColor = System.Drawing.Color.Transparent;
            this.contactTitleTextBox.Location = new System.Drawing.Point(209, 536);
            this.contactTitleTextBox.Name = "contactTitleTextBox";
            this.contactTitleTextBox.Size = new System.Drawing.Size(152, 32);
            this.contactTitleTextBox.TabIndex = 43;
            // 
            // contactNameTextBox
            // 
            this.contactNameTextBox.BackColor = System.Drawing.Color.Gray;
            this.contactNameTextBox.BorderColor = System.Drawing.Color.Gray;
            this.contactNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.contactNameTextBox.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactNameTextBox.ForeColor = System.Drawing.Color.Transparent;
            this.contactNameTextBox.Location = new System.Drawing.Point(209, 491);
            this.contactNameTextBox.Name = "contactNameTextBox";
            this.contactNameTextBox.Size = new System.Drawing.Size(152, 32);
            this.contactNameTextBox.TabIndex = 42;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(48, 538);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(132, 23);
            this.label18.TabIndex = 41;
            this.label18.Text = "Contact Title";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(48, 493);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(155, 23);
            this.label19.TabIndex = 40;
            this.label19.Text = "Contact Name";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(376, 500);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(86, 23);
            this.label20.TabIndex = 44;
            this.label20.Text = "Sales ID";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(376, 538);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(130, 23);
            this.label21.TabIndex = 45;
            this.label21.Text = "Sales Person";
            // 
            // salesIDComboBox
            // 
            this.salesIDComboBox.BackColor = System.Drawing.Color.DimGray;
            this.salesIDComboBox.DataSource = this.quotingsystemDataSet;
            this.salesIDComboBox.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesIDComboBox.ForeColor = System.Drawing.Color.White;
            this.salesIDComboBox.FormattingEnabled = true;
            this.salesIDComboBox.Location = new System.Drawing.Point(524, 490);
            this.salesIDComboBox.Name = "salesIDComboBox";
            this.salesIDComboBox.Size = new System.Drawing.Size(152, 31);
            this.salesIDComboBox.TabIndex = 46;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DimGray;
            this.button1.Location = new System.Drawing.Point(901, 521);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 53);
            this.button1.TabIndex = 48;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // salesPersonTextBox
            // 
            this.salesPersonTextBox.BackColor = System.Drawing.Color.Gray;
            this.salesPersonTextBox.BorderColor = System.Drawing.Color.Gray;
            this.salesPersonTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.salesPersonTextBox.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesPersonTextBox.ForeColor = System.Drawing.Color.Transparent;
            this.salesPersonTextBox.Location = new System.Drawing.Point(524, 536);
            this.salesPersonTextBox.Name = "salesPersonTextBox";
            this.salesPersonTextBox.Size = new System.Drawing.Size(152, 32);
            this.salesPersonTextBox.TabIndex = 49;
            this.salesPersonTextBox.TextChanged += new System.EventHandler(this.salesPersonTextBox_TextChanged);
            // 
            // customerUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.salesPersonTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.salesIDComboBox);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.contactTitleTextBox);
            this.Controls.Add(this.contactNameTextBox);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.faxTextBox);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.mobileTextBox);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.deliveryRegionTextBox);
            this.Controls.Add(this.deliveryTownTextBox);
            this.Controls.Add(this.deliveryAddressTextBox);
            this.Controls.Add(this.postalCodeTextBox);
            this.Controls.Add(this.postalTownTextBox);
            this.Controls.Add(this.postalAddressTextBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.companyNameTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.companyIDTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.loadData);
            this.Controls.Add(this.CompanyNameComboBox);
            this.Controls.Add(this.customerIDComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "customerUC";
            this.Size = new System.Drawing.Size(1038, 625);
            this.Load += new System.EventHandler(this.customerUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblcustomerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quotingsystemDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox customerIDComboBox;
        private System.Windows.Forms.BindingSource tblcustomerBindingSource;
        private quotingsystemDataSet quotingsystemDataSet;
        private quotingsystemDataSetTableAdapters.tblcustomerTableAdapter tblcustomerTableAdapter;
        private System.Windows.Forms.ComboBox CompanyNameComboBox;
        private System.Windows.Forms.Button loadData;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label4;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox companyIDTextBox;
        private System.Windows.Forms.Label label5;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox companyNameTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox postalAddressTextBox;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox postalTownTextBox;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox postalCodeTextBox;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox deliveryAddressTextBox;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox deliveryTownTextBox;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox deliveryRegionTextBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox phoneTextBox;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox mobileTextBox;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox emailTextBox;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox faxTextBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox contactTitleTextBox;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox contactNameTextBox;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox salesIDComboBox;
        private System.Windows.Forms.Button button1;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox salesPersonTextBox;
    }
}
