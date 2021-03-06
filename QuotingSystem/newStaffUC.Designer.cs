namespace QuotingSystem
{
    partial class newStaffUC
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
            this.loadData = new System.Windows.Forms.Button();
            this.staffNameComboBox = new System.Windows.Forms.ComboBox();
            this.userIDComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.quotingsystemDataSet69 = new QuotingSystem.quotingsystemDataSet69();
            this.tblstaffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblstaffTableAdapter = new QuotingSystem.quotingsystemDataSet69TableAdapters.tblstaffTableAdapter();
            this.tblstaffBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.staffIDTextBox = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.staffNameTextBox = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.passwordTextBox = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.confirmPasswordTextBox = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.isManagerComboBox = new System.Windows.Forms.ComboBox();
            this.isActiveComboBox = new System.Windows.Forms.ComboBox();
            this.saveBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.quotingsystemDataSet69)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblstaffBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblstaffBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // loadData
            // 
            this.loadData.BackColor = System.Drawing.Color.DimGray;
            this.loadData.Location = new System.Drawing.Point(800, 67);
            this.loadData.Name = "loadData";
            this.loadData.Size = new System.Drawing.Size(113, 53);
            this.loadData.TabIndex = 17;
            this.loadData.Text = "Load";
            this.loadData.UseVisualStyleBackColor = false;
            this.loadData.Click += new System.EventHandler(this.loadData_Click);
            // 
            // staffNameComboBox
            // 
            this.staffNameComboBox.BackColor = System.Drawing.Color.DimGray;
            this.staffNameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.tblstaffBindingSource1, "Name", true));
            this.staffNameComboBox.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffNameComboBox.ForeColor = System.Drawing.Color.White;
            this.staffNameComboBox.FormattingEnabled = true;
            this.staffNameComboBox.Location = new System.Drawing.Point(466, 81);
            this.staffNameComboBox.Name = "staffNameComboBox";
            this.staffNameComboBox.Size = new System.Drawing.Size(247, 31);
            this.staffNameComboBox.TabIndex = 16;
            this.staffNameComboBox.Text = "None";
            // 
            // userIDComboBox
            // 
            this.userIDComboBox.BackColor = System.Drawing.Color.DimGray;
            this.userIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.tblstaffBindingSource, "StaffID", true));
            this.userIDComboBox.DisplayMember = "CustomerID";
            this.userIDComboBox.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userIDComboBox.ForeColor = System.Drawing.Color.White;
            this.userIDComboBox.FormattingEnabled = true;
            this.userIDComboBox.Location = new System.Drawing.Point(166, 81);
            this.userIDComboBox.Name = "userIDComboBox";
            this.userIDComboBox.Size = new System.Drawing.Size(152, 31);
            this.userIDComboBox.TabIndex = 15;
            this.userIDComboBox.Text = "None";
            this.userIDComboBox.SelectedIndexChanged += new System.EventHandler(this.userIDComboBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(324, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 23);
            this.label3.TabIndex = 14;
            this.label3.Text = "Select Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(17, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 23);
            this.label2.TabIndex = 13;
            this.label2.Text = "Select User ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 34);
            this.label1.TabIndex = 18;
            this.label1.Text = "Customer Data Page";
            // 
            // quotingsystemDataSet69
            // 
            this.quotingsystemDataSet69.DataSetName = "quotingsystemDataSet69";
            this.quotingsystemDataSet69.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblstaffBindingSource
            // 
            this.tblstaffBindingSource.DataMember = "tblstaff";
            this.tblstaffBindingSource.DataSource = this.quotingsystemDataSet69;
            // 
            // tblstaffTableAdapter
            // 
            this.tblstaffTableAdapter.ClearBeforeFill = true;
            // 
            // tblstaffBindingSource1
            // 
            this.tblstaffBindingSource1.DataMember = "tblstaff";
            this.tblstaffBindingSource1.DataSource = this.quotingsystemDataSet69;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(17, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 23);
            this.label4.TabIndex = 19;
            this.label4.Text = "User ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(17, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 23);
            this.label5.TabIndex = 20;
            this.label5.Text = "User Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(17, 290);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 21;
            this.label6.Text = "Password";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(17, 335);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(183, 23);
            this.label7.TabIndex = 22;
            this.label7.Text = "Confirm Password";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(582, 199);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 23);
            this.label8.TabIndex = 23;
            this.label8.Text = "Manager ?";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(582, 245);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 23);
            this.label9.TabIndex = 24;
            this.label9.Text = "Is Active ?";
            // 
            // staffIDTextBox
            // 
            this.staffIDTextBox.BackColor = System.Drawing.Color.Gray;
            this.staffIDTextBox.BorderColor = System.Drawing.Color.Gray;
            this.staffIDTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.staffIDTextBox.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffIDTextBox.ForeColor = System.Drawing.Color.Transparent;
            this.staffIDTextBox.Location = new System.Drawing.Point(234, 197);
            this.staffIDTextBox.Name = "staffIDTextBox";
            this.staffIDTextBox.Size = new System.Drawing.Size(152, 32);
            this.staffIDTextBox.TabIndex = 25;
            // 
            // staffNameTextBox
            // 
            this.staffNameTextBox.BackColor = System.Drawing.Color.Gray;
            this.staffNameTextBox.BorderColor = System.Drawing.Color.Gray;
            this.staffNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.staffNameTextBox.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffNameTextBox.ForeColor = System.Drawing.Color.Transparent;
            this.staffNameTextBox.Location = new System.Drawing.Point(234, 243);
            this.staffNameTextBox.Name = "staffNameTextBox";
            this.staffNameTextBox.Size = new System.Drawing.Size(152, 32);
            this.staffNameTextBox.TabIndex = 26;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BackColor = System.Drawing.Color.Gray;
            this.passwordTextBox.BorderColor = System.Drawing.Color.Gray;
            this.passwordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordTextBox.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.ForeColor = System.Drawing.Color.Transparent;
            this.passwordTextBox.Location = new System.Drawing.Point(234, 288);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(152, 32);
            this.passwordTextBox.TabIndex = 27;
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // confirmPasswordTextBox
            // 
            this.confirmPasswordTextBox.BackColor = System.Drawing.Color.Gray;
            this.confirmPasswordTextBox.BorderColor = System.Drawing.Color.Gray;
            this.confirmPasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.confirmPasswordTextBox.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmPasswordTextBox.ForeColor = System.Drawing.Color.Transparent;
            this.confirmPasswordTextBox.Location = new System.Drawing.Point(234, 333);
            this.confirmPasswordTextBox.Name = "confirmPasswordTextBox";
            this.confirmPasswordTextBox.Size = new System.Drawing.Size(152, 32);
            this.confirmPasswordTextBox.TabIndex = 28;
            this.confirmPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // isManagerComboBox
            // 
            this.isManagerComboBox.BackColor = System.Drawing.Color.DimGray;
            this.isManagerComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.tblstaffBindingSource, "StaffID", true));
            this.isManagerComboBox.DisplayMember = "CustomerID";
            this.isManagerComboBox.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isManagerComboBox.ForeColor = System.Drawing.Color.White;
            this.isManagerComboBox.FormattingEnabled = true;
            this.isManagerComboBox.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.isManagerComboBox.Location = new System.Drawing.Point(777, 196);
            this.isManagerComboBox.Name = "isManagerComboBox";
            this.isManagerComboBox.Size = new System.Drawing.Size(152, 31);
            this.isManagerComboBox.TabIndex = 29;
            this.isManagerComboBox.Text = "None";
            // 
            // isActiveComboBox
            // 
            this.isActiveComboBox.BackColor = System.Drawing.Color.DimGray;
            this.isActiveComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.tblstaffBindingSource, "StaffID", true));
            this.isActiveComboBox.DisplayMember = "CustomerID";
            this.isActiveComboBox.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isActiveComboBox.ForeColor = System.Drawing.Color.White;
            this.isActiveComboBox.FormattingEnabled = true;
            this.isActiveComboBox.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.isActiveComboBox.Location = new System.Drawing.Point(777, 242);
            this.isActiveComboBox.Name = "isActiveComboBox";
            this.isActiveComboBox.Size = new System.Drawing.Size(152, 31);
            this.isActiveComboBox.TabIndex = 30;
            this.isActiveComboBox.Text = "None";
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.DimGray;
            this.saveBtn.Location = new System.Drawing.Point(777, 335);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(113, 53);
            this.saveBtn.TabIndex = 31;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // newStaffUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.isActiveComboBox);
            this.Controls.Add(this.isManagerComboBox);
            this.Controls.Add(this.confirmPasswordTextBox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.staffNameTextBox);
            this.Controls.Add(this.staffIDTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loadData);
            this.Controls.Add(this.staffNameComboBox);
            this.Controls.Add(this.userIDComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "newStaffUC";
            this.Size = new System.Drawing.Size(1038, 561);
            this.Load += new System.EventHandler(this.newStaffUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quotingsystemDataSet69)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblstaffBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblstaffBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loadData;
        private System.Windows.Forms.ComboBox staffNameComboBox;
        private System.Windows.Forms.ComboBox userIDComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource tblstaffBindingSource1;
        private quotingsystemDataSet69 quotingsystemDataSet69;
        private System.Windows.Forms.BindingSource tblstaffBindingSource;
        private quotingsystemDataSet69TableAdapters.tblstaffTableAdapter tblstaffTableAdapter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox staffIDTextBox;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox staffNameTextBox;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox passwordTextBox;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox confirmPasswordTextBox;
        private System.Windows.Forms.ComboBox isManagerComboBox;
        private System.Windows.Forms.ComboBox isActiveComboBox;
        private System.Windows.Forms.Button saveBtn;
    }
}
