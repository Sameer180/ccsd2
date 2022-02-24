namespace ccsd2
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.login = new System.Windows.Forms.TabPage();
            this.invalidUser = new System.Windows.Forms.Label();
            this.loginToSelect = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.userType = new System.Windows.Forms.ComboBox();
            this.Selection = new System.Windows.Forms.TabPage();
            this.notFound = new System.Windows.Forms.Label();
            this.selectToLogin = new System.Windows.Forms.Button();
            this.selectToDash = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.selectVehicle = new System.Windows.Forms.ComboBox();
            this.dashboard = new System.Windows.Forms.TabPage();
            this.typeOut = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.makeOut = new System.Windows.Forms.TextBox();
            this.modelOut = new System.Windows.Forms.TextBox();
            this.regOut = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.logOut = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dashToUnpaidBills = new System.Windows.Forms.Button();
            this.dashToPaymentHistory = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.paymentHistory = new System.Windows.Forms.TabPage();
            this.historyToDash = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.unpaidBills = new System.Windows.Forms.TabPage();
            this.unpaidToDash = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.historyId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.distanceKM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.login.SuspendLayout();
            this.Selection.SuspendLayout();
            this.dashboard.SuspendLayout();
            this.paymentHistory.SuspendLayout();
            this.unpaidBills.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.login);
            this.tabControl1.Controls.Add(this.Selection);
            this.tabControl1.Controls.Add(this.dashboard);
            this.tabControl1.Controls.Add(this.paymentHistory);
            this.tabControl1.Controls.Add(this.unpaidBills);
            this.tabControl1.ItemSize = new System.Drawing.Size(50, 20);
            this.tabControl1.Location = new System.Drawing.Point(25, 35);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(750, 383);
            this.tabControl1.TabIndex = 0;
            // 
            // login
            // 
            this.login.Controls.Add(this.invalidUser);
            this.login.Controls.Add(this.loginToSelect);
            this.login.Controls.Add(this.label6);
            this.login.Controls.Add(this.userType);
            this.login.Location = new System.Drawing.Point(4, 24);
            this.login.Name = "login";
            this.login.Padding = new System.Windows.Forms.Padding(3);
            this.login.Size = new System.Drawing.Size(742, 355);
            this.login.TabIndex = 1;
            this.login.Text = "login";
            this.login.UseVisualStyleBackColor = true;
            // 
            // invalidUser
            // 
            this.invalidUser.AutoSize = true;
            this.invalidUser.Location = new System.Drawing.Point(432, 106);
            this.invalidUser.Name = "invalidUser";
            this.invalidUser.Size = new System.Drawing.Size(59, 13);
            this.invalidUser.TabIndex = 3;
            this.invalidUser.Text = "invalidUser";
            // 
            // loginToSelect
            // 
            this.loginToSelect.Location = new System.Drawing.Point(305, 178);
            this.loginToSelect.Name = "loginToSelect";
            this.loginToSelect.Size = new System.Drawing.Size(121, 23);
            this.loginToSelect.TabIndex = 2;
            this.loginToSelect.Text = "Login";
            this.loginToSelect.UseVisualStyleBackColor = true;
            this.loginToSelect.Click += new System.EventHandler(this.loginToSelect_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(331, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "User Selection";
            // 
            // userType
            // 
            this.userType.AllowDrop = true;
            this.userType.FormattingEnabled = true;
            this.userType.Items.AddRange(new object[] {
            "John (Regular User)",
            "Steven (Transport Dept)"});
            this.userType.Location = new System.Drawing.Point(305, 103);
            this.userType.Name = "userType";
            this.userType.Size = new System.Drawing.Size(121, 21);
            this.userType.TabIndex = 0;
            this.userType.Text = "Select User";
            this.userType.SelectedIndexChanged += new System.EventHandler(this.userType_SelectedIndexChanged);
            // 
            // Selection
            // 
            this.Selection.Controls.Add(this.notFound);
            this.Selection.Controls.Add(this.selectToLogin);
            this.Selection.Controls.Add(this.selectToDash);
            this.Selection.Controls.Add(this.label1);
            this.Selection.Controls.Add(this.selectVehicle);
            this.Selection.Location = new System.Drawing.Point(4, 24);
            this.Selection.Name = "Selection";
            this.Selection.Size = new System.Drawing.Size(742, 355);
            this.Selection.TabIndex = 3;
            this.Selection.Text = "Select";
            this.Selection.UseVisualStyleBackColor = true;
            // 
            // notFound
            // 
            this.notFound.AutoSize = true;
            this.notFound.Location = new System.Drawing.Point(478, 126);
            this.notFound.Name = "notFound";
            this.notFound.Size = new System.Drawing.Size(95, 13);
            this.notFound.TabIndex = 5;
            this.notFound.Text = "Vehicle Not Found";
            // 
            // selectToLogin
            // 
            this.selectToLogin.Location = new System.Drawing.Point(323, 263);
            this.selectToLogin.Name = "selectToLogin";
            this.selectToLogin.Size = new System.Drawing.Size(121, 23);
            this.selectToLogin.TabIndex = 4;
            this.selectToLogin.Text = "Log Out";
            this.selectToLogin.UseVisualStyleBackColor = true;
            this.selectToLogin.Click += new System.EventHandler(this.selectToLogin_Click);
            // 
            // selectToDash
            // 
            this.selectToDash.Location = new System.Drawing.Point(323, 217);
            this.selectToDash.Name = "selectToDash";
            this.selectToDash.Size = new System.Drawing.Size(121, 23);
            this.selectToDash.TabIndex = 3;
            this.selectToDash.Text = "Submit";
            this.selectToDash.UseVisualStyleBackColor = true;
            this.selectToDash.Click += new System.EventHandler(this.selectDoTToDash_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(286, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Which Vehicle would you like to see?";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // selectVehicle
            // 
            this.selectVehicle.AllowDrop = true;
            this.selectVehicle.FormattingEnabled = true;
            this.selectVehicle.Location = new System.Drawing.Point(323, 123);
            this.selectVehicle.Name = "selectVehicle";
            this.selectVehicle.Size = new System.Drawing.Size(121, 21);
            this.selectVehicle.TabIndex = 1;
            this.selectVehicle.Text = "Select Vehicle";
            this.selectVehicle.SelectedIndexChanged += new System.EventHandler(this.DoTVehicle_SelectedIndexChanged);
            // 
            // dashboard
            // 
            this.dashboard.Controls.Add(this.typeOut);
            this.dashboard.Controls.Add(this.label2);
            this.dashboard.Controls.Add(this.makeOut);
            this.dashboard.Controls.Add(this.modelOut);
            this.dashboard.Controls.Add(this.regOut);
            this.dashboard.Controls.Add(this.label9);
            this.dashboard.Controls.Add(this.label8);
            this.dashboard.Controls.Add(this.logOut);
            this.dashboard.Controls.Add(this.label5);
            this.dashboard.Controls.Add(this.dashToUnpaidBills);
            this.dashboard.Controls.Add(this.dashToPaymentHistory);
            this.dashboard.Controls.Add(this.label3);
            this.dashboard.Location = new System.Drawing.Point(4, 24);
            this.dashboard.Name = "dashboard";
            this.dashboard.Padding = new System.Windows.Forms.Padding(3);
            this.dashboard.Size = new System.Drawing.Size(742, 355);
            this.dashboard.TabIndex = 0;
            this.dashboard.Text = "dashboard";
            this.dashboard.UseVisualStyleBackColor = true;
            // 
            // typeOut
            // 
            this.typeOut.Location = new System.Drawing.Point(407, 102);
            this.typeOut.Name = "typeOut";
            this.typeOut.Size = new System.Drawing.Size(100, 20);
            this.typeOut.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(404, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Type";
            // 
            // makeOut
            // 
            this.makeOut.Location = new System.Drawing.Point(202, 102);
            this.makeOut.Name = "makeOut";
            this.makeOut.Size = new System.Drawing.Size(100, 20);
            this.makeOut.TabIndex = 9;
            // 
            // modelOut
            // 
            this.modelOut.Location = new System.Drawing.Point(588, 102);
            this.modelOut.Name = "modelOut";
            this.modelOut.Size = new System.Drawing.Size(100, 20);
            this.modelOut.TabIndex = 8;
            // 
            // regOut
            // 
            this.regOut.Location = new System.Drawing.Point(30, 102);
            this.regOut.Name = "regOut";
            this.regOut.Size = new System.Drawing.Size(100, 20);
            this.regOut.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(585, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Model";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(199, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Make";
            // 
            // logOut
            // 
            this.logOut.Location = new System.Drawing.Point(30, 326);
            this.logOut.Name = "logOut";
            this.logOut.Size = new System.Drawing.Size(116, 23);
            this.logOut.TabIndex = 4;
            this.logOut.Text = "Log Out";
            this.logOut.UseVisualStyleBackColor = true;
            this.logOut.Click += new System.EventHandler(this.logOut_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(341, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Dashboard";
            // 
            // dashToUnpaidBills
            // 
            this.dashToUnpaidBills.Location = new System.Drawing.Point(391, 246);
            this.dashToUnpaidBills.Name = "dashToUnpaidBills";
            this.dashToUnpaidBills.Size = new System.Drawing.Size(116, 23);
            this.dashToUnpaidBills.TabIndex = 2;
            this.dashToUnpaidBills.Text = "See Unpaid Bills";
            this.dashToUnpaidBills.UseVisualStyleBackColor = true;
            this.dashToUnpaidBills.Click += new System.EventHandler(this.dashToUnpaidBills_Click);
            // 
            // dashToPaymentHistory
            // 
            this.dashToPaymentHistory.Location = new System.Drawing.Point(232, 245);
            this.dashToPaymentHistory.Name = "dashToPaymentHistory";
            this.dashToPaymentHistory.Size = new System.Drawing.Size(116, 24);
            this.dashToPaymentHistory.TabIndex = 1;
            this.dashToPaymentHistory.Text = "See Payment History";
            this.dashToPaymentHistory.UseVisualStyleBackColor = true;
            this.dashToPaymentHistory.Click += new System.EventHandler(this.dashToPaymentHistory_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Registration";
            // 
            // paymentHistory
            // 
            this.paymentHistory.Controls.Add(this.dataGridView1);
            this.paymentHistory.Controls.Add(this.historyToDash);
            this.paymentHistory.Controls.Add(this.label7);
            this.paymentHistory.Location = new System.Drawing.Point(4, 24);
            this.paymentHistory.Name = "paymentHistory";
            this.paymentHistory.Size = new System.Drawing.Size(742, 355);
            this.paymentHistory.TabIndex = 2;
            this.paymentHistory.Text = " payment history";
            this.paymentHistory.UseVisualStyleBackColor = true;
            // 
            // historyToDash
            // 
            this.historyToDash.Location = new System.Drawing.Point(320, 291);
            this.historyToDash.Name = "historyToDash";
            this.historyToDash.Size = new System.Drawing.Size(108, 23);
            this.historyToDash.TabIndex = 1;
            this.historyToDash.Text = "Back to Dashboard";
            this.historyToDash.UseVisualStyleBackColor = true;
            this.historyToDash.Click += new System.EventHandler(this.historyToDash_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(333, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Payment History";
            // 
            // unpaidBills
            // 
            this.unpaidBills.Controls.Add(this.unpaidToDash);
            this.unpaidBills.Controls.Add(this.label4);
            this.unpaidBills.Location = new System.Drawing.Point(4, 24);
            this.unpaidBills.Name = "unpaidBills";
            this.unpaidBills.Size = new System.Drawing.Size(742, 355);
            this.unpaidBills.TabIndex = 5;
            this.unpaidBills.Text = "unpaidBills";
            this.unpaidBills.UseVisualStyleBackColor = true;
            // 
            // unpaidToDash
            // 
            this.unpaidToDash.Location = new System.Drawing.Point(277, 298);
            this.unpaidToDash.Name = "unpaidToDash";
            this.unpaidToDash.Size = new System.Drawing.Size(108, 23);
            this.unpaidToDash.TabIndex = 2;
            this.unpaidToDash.Text = "Back to Dashboard";
            this.unpaidToDash.UseVisualStyleBackColor = true;
            this.unpaidToDash.Click += new System.EventHandler(this.unpaidToDash_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(299, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Unpaid Bills";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.historyId,
            this.dt,
            this.reg,
            this.distanceKM,
            this.price,
            this.paid});
            this.dataGridView1.Location = new System.Drawing.Point(36, 74);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(648, 170);
            this.dataGridView1.TabIndex = 2;
            // 
            // historyId
            // 
            this.historyId.HeaderText = "id";
            this.historyId.Name = "historyId";
            // 
            // dt
            // 
            this.dt.HeaderText = "Date Time";
            this.dt.Name = "dt";
            // 
            // reg
            // 
            this.reg.HeaderText = "registration";
            this.reg.Name = "reg";
            // 
            // distanceKM
            // 
            this.distanceKM.HeaderText = "distance (KM)";
            this.distanceKM.Name = "distanceKM";
            // 
            // price
            // 
            this.price.HeaderText = "Charge";
            this.price.Name = "price";
            // 
            // paid
            // 
            this.paid.HeaderText = "Paid";
            this.paid.Name = "paid";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.login.ResumeLayout(false);
            this.login.PerformLayout();
            this.Selection.ResumeLayout(false);
            this.Selection.PerformLayout();
            this.dashboard.ResumeLayout(false);
            this.dashboard.PerformLayout();
            this.paymentHistory.ResumeLayout(false);
            this.paymentHistory.PerformLayout();
            this.unpaidBills.ResumeLayout(false);
            this.unpaidBills.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage login;
        private System.Windows.Forms.ComboBox userType;
        private System.Windows.Forms.TabPage dashboard;
        private System.Windows.Forms.TabPage paymentHistory;
        private System.Windows.Forms.ComboBox selectVehicle;
        private System.Windows.Forms.TabPage Selection;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button dashToUnpaidBills;
        private System.Windows.Forms.Button dashToPaymentHistory;
        private System.Windows.Forms.TabPage unpaidBills;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button historyToDash;
        private System.Windows.Forms.Button unpaidToDash;
        private System.Windows.Forms.Button logOut;
        private System.Windows.Forms.Button selectToDash;
        private System.Windows.Forms.TextBox makeOut;
        private System.Windows.Forms.TextBox modelOut;
        private System.Windows.Forms.TextBox regOut;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button loginToSelect;
        private System.Windows.Forms.Button selectToLogin;
        private System.Windows.Forms.TextBox typeOut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label invalidUser;
        private System.Windows.Forms.Label notFound;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn historyId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dt;
        private System.Windows.Forms.DataGridViewTextBoxColumn reg;
        private System.Windows.Forms.DataGridViewTextBoxColumn distanceKM;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn paid;
    }
}

