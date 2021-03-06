namespace QuotingSystem
{
    partial class adminDashboardUC
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
            this.menu = new System.Windows.Forms.Panel();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.editQuoteBtn = new System.Windows.Forms.Button();
            this.updateChartBtn = new System.Windows.Forms.Button();
            this.addNewStaffBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.newStaffUC1 = new QuotingSystem.newStaffUC();
            this.menu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.menu.Controls.Add(this.logoutBtn);
            this.menu.Controls.Add(this.editQuoteBtn);
            this.menu.Controls.Add(this.updateChartBtn);
            this.menu.Controls.Add(this.addNewStaffBtn);
            this.menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1038, 64);
            this.menu.TabIndex = 8;
            // 
            // logoutBtn
            // 
            this.logoutBtn.BackColor = System.Drawing.Color.Transparent;
            this.logoutBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.logoutBtn.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBtn.ForeColor = System.Drawing.Color.White;
            this.logoutBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.logoutBtn.Location = new System.Drawing.Point(516, 0);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(522, 64);
            this.logoutBtn.TabIndex = 14;
            this.logoutBtn.Text = "Logout";
            this.logoutBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.logoutBtn.UseVisualStyleBackColor = false;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // editQuoteBtn
            // 
            this.editQuoteBtn.BackColor = System.Drawing.Color.Transparent;
            this.editQuoteBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.editQuoteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.editQuoteBtn.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editQuoteBtn.ForeColor = System.Drawing.Color.White;
            this.editQuoteBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.editQuoteBtn.Location = new System.Drawing.Point(344, 0);
            this.editQuoteBtn.Name = "editQuoteBtn";
            this.editQuoteBtn.Size = new System.Drawing.Size(172, 64);
            this.editQuoteBtn.TabIndex = 13;
            this.editQuoteBtn.Text = "Edit Quote";
            this.editQuoteBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.editQuoteBtn.UseVisualStyleBackColor = false;
            // 
            // updateChartBtn
            // 
            this.updateChartBtn.BackColor = System.Drawing.Color.Transparent;
            this.updateChartBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.updateChartBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.updateChartBtn.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateChartBtn.ForeColor = System.Drawing.Color.White;
            this.updateChartBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.updateChartBtn.Location = new System.Drawing.Point(172, 0);
            this.updateChartBtn.Name = "updateChartBtn";
            this.updateChartBtn.Size = new System.Drawing.Size(172, 64);
            this.updateChartBtn.TabIndex = 12;
            this.updateChartBtn.Text = "Update Pricing Chart";
            this.updateChartBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.updateChartBtn.UseVisualStyleBackColor = false;
            this.updateChartBtn.Click += new System.EventHandler(this.customerDetailsBtn_Click);
            // 
            // addNewStaffBtn
            // 
            this.addNewStaffBtn.BackColor = System.Drawing.Color.Transparent;
            this.addNewStaffBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.addNewStaffBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addNewStaffBtn.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewStaffBtn.ForeColor = System.Drawing.Color.White;
            this.addNewStaffBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.addNewStaffBtn.Location = new System.Drawing.Point(0, 0);
            this.addNewStaffBtn.Name = "addNewStaffBtn";
            this.addNewStaffBtn.Size = new System.Drawing.Size(172, 64);
            this.addNewStaffBtn.TabIndex = 11;
            this.addNewStaffBtn.Text = "Add New Staff";
            this.addNewStaffBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addNewStaffBtn.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.newStaffUC1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1038, 561);
            this.panel1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admin Dashboard";
            // 
            // newStaffUC1
            // 
            this.newStaffUC1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.newStaffUC1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newStaffUC1.ForeColor = System.Drawing.Color.White;
            this.newStaffUC1.Location = new System.Drawing.Point(0, 0);
            this.newStaffUC1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.newStaffUC1.Name = "newStaffUC1";
            this.newStaffUC1.Size = new System.Drawing.Size(1038, 561);
            this.newStaffUC1.TabIndex = 1;
            this.newStaffUC1.Load += new System.EventHandler(this.newStaffUC1_Load);
            // 
            // adminDashboardUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menu);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "adminDashboardUC";
            this.Size = new System.Drawing.Size(1038, 625);
            this.menu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menu;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Button editQuoteBtn;
        private System.Windows.Forms.Button updateChartBtn;
        private System.Windows.Forms.Button addNewStaffBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private newStaffUC newStaffUC1;
    }
}
