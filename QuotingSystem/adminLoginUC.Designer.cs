namespace QuotingSystem
{
    partial class adminLoginUC
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
            this.adminLoginPanel = new System.Windows.Forms.Panel();
            this.adminLogin = new System.Windows.Forms.Panel();
            this.username = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.password = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.login = new System.Windows.Forms.Button();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.adminDashboardUC1 = new QuotingSystem.adminDashboardUC();
            this.adminLoginPanel.SuspendLayout();
            this.adminLogin.SuspendLayout();
            this.panelContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // adminLoginPanel
            // 
            this.adminLoginPanel.Controls.Add(this.adminLogin);
            this.adminLoginPanel.Controls.Add(this.adminDashboardUC1);
            this.adminLoginPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.adminLoginPanel.Location = new System.Drawing.Point(0, 0);
            this.adminLoginPanel.Name = "adminLoginPanel";
            this.adminLoginPanel.Size = new System.Drawing.Size(1038, 625);
            this.adminLoginPanel.TabIndex = 27;
            // 
            // adminLogin
            // 
            this.adminLogin.Controls.Add(this.username);
            this.adminLogin.Controls.Add(this.password);
            this.adminLogin.Controls.Add(this.bunifuCustomLabel3);
            this.adminLogin.Controls.Add(this.login);
            this.adminLogin.Controls.Add(this.bunifuCustomLabel1);
            this.adminLogin.Controls.Add(this.bunifuCustomLabel2);
            this.adminLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.adminLogin.Location = new System.Drawing.Point(0, 0);
            this.adminLogin.Name = "adminLogin";
            this.adminLogin.Size = new System.Drawing.Size(1038, 625);
            this.adminLogin.TabIndex = 34;
            // 
            // username
            // 
            this.username.BackColor = System.Drawing.Color.Gray;
            this.username.BorderColor = System.Drawing.Color.Gray;
            this.username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.username.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.ForeColor = System.Drawing.Color.Transparent;
            this.username.Location = new System.Drawing.Point(467, 275);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(201, 37);
            this.username.TabIndex = 31;
            this.username.TextChanged += new System.EventHandler(this.username_TextChanged_1);
            // 
            // password
            // 
            this.password.BackColor = System.Drawing.Color.Gray;
            this.password.BorderColor = System.Drawing.Color.Gray;
            this.password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.password.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.ForeColor = System.Drawing.Color.Transparent;
            this.password.Location = new System.Drawing.Point(467, 359);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(201, 37);
            this.password.TabIndex = 32;
            this.password.UseSystemPasswordChar = true;
            this.password.TextChanged += new System.EventHandler(this.password_TextChanged_1);
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(413, 161);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(187, 34);
            this.bunifuCustomLabel3.TabIndex = 33;
            this.bunifuCustomLabel3.Text = "Admin Login";
            this.bunifuCustomLabel3.Click += new System.EventHandler(this.bunifuCustomLabel3_Click_1);
            // 
            // login
            // 
            this.login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.login.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.login.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login.ForeColor = System.Drawing.Color.White;
            this.login.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.login.Location = new System.Drawing.Point(428, 463);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(141, 56);
            this.login.TabIndex = 28;
            this.login.Text = "Login";
            this.login.UseVisualStyleBackColor = false;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(297, 277);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(133, 30);
            this.bunifuCustomLabel1.TabIndex = 29;
            this.bunifuCustomLabel1.Text = "Username";
            this.bunifuCustomLabel1.Click += new System.EventHandler(this.bunifuCustomLabel1_Click_1);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(297, 361);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(122, 30);
            this.bunifuCustomLabel2.TabIndex = 30;
            this.bunifuCustomLabel2.Text = "Password";
            this.bunifuCustomLabel2.Click += new System.EventHandler(this.bunifuCustomLabel2_Click_1);
            // 
            // panelContainer
            // 
            this.panelContainer.Controls.Add(this.adminLoginPanel);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1038, 625);
            this.panelContainer.TabIndex = 27;
            // 
            // adminDashboardUC1
            // 
            this.adminDashboardUC1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.adminDashboardUC1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminDashboardUC1.ForeColor = System.Drawing.Color.White;
            this.adminDashboardUC1.Location = new System.Drawing.Point(0, 0);
            this.adminDashboardUC1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.adminDashboardUC1.Name = "adminDashboardUC1";
            this.adminDashboardUC1.Size = new System.Drawing.Size(1038, 625);
            this.adminDashboardUC1.TabIndex = 26;
            this.adminDashboardUC1.Load += new System.EventHandler(this.adminDashboardUC1_Load);
            // 
            // adminLoginUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.panelContainer);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "adminLoginUC";
            this.Size = new System.Drawing.Size(1038, 625);
            this.adminLoginPanel.ResumeLayout(false);
            this.adminLogin.ResumeLayout(false);
            this.adminLogin.PerformLayout();
            this.panelContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel adminLoginPanel;
        private adminDashboardUC adminDashboardUC1;
        private System.Windows.Forms.Panel adminLogin;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox username;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox password;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private System.Windows.Forms.Button login;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private System.Windows.Forms.Panel panelContainer;




    }
}
