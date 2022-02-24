using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ccsd2
{
    public partial class Form1 : Form
    {
        Account account;
        private string userName;
        private string regNum;

        public Form1()
        {
            InitializeComponent();
            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.ItemSize = new Size(0, 1);
            tabControl1.SizeMode = TabSizeMode.Fixed;
            invalidUser.Visible = false;
            notFound.Visible = false;
            this.userName = "";
            this.regNum = "";
            this.selectVehicle.Items.Clear();
            this.selectVehicle.Text = "";
        }

        private void DoTVehicle_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void userType_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dashToPaymentHistory_Click(object sender, EventArgs e)
        {       // id dt registration distanceKM price paid
            this.dataGridView1.Rows.Clear();
            List<List<string>> paidBills = account.paidBillsToUi();
            List<string> bill;
            string[] row;

            if (paidBills.Any())
            {
                for (int i = 0; i < paidBills.Count; i++)
                {
                    bill = paidBills.ElementAt(i);
                    row = new string[] { bill.ElementAt(0), bill.ElementAt(1), bill.ElementAt(2),
                                         bill.ElementAt(3), bill.ElementAt(4), bill.ElementAt(5) };
                    this.dataGridView1.Rows.Add(row);
                }
            }
            else
                row = new string[] { "Empty", "", "", "", "" };

            this.tabControl1.SelectTab("paymentHistory");
        }

        private void dashToUnpaidBills_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectTab("unpaidBills");
        }

        private void historyToDash_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectTab("dashboard");
        }

        private void unpaidToDash_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectTab("dashboard");
        }

        private void logOut_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectTab("login");
            this.userName = "";
            this.regNum = "";
            this.selectVehicle.Items.Clear();
            this.selectVehicle.Text = "";
            invalidUser.Visible = false;
            notFound.Visible = false;
            this.dataGridView1.Rows.Clear();
        }

        private void selectDoTToDash_Click(object sender, EventArgs e)
        {
           
            this.regNum = selectVehicle.Text;
            List<string> details = account.getVehicleDetails(regNum);
            if (details.Any())
            {
                this.regOut.Text = regNum;
                this.makeOut.Text = details.ElementAt(0);
                this.modelOut.Text = details.ElementAt(1);
                this.typeOut.Text = details.ElementAt(2);
                this.tabControl1.SelectTab("dashboard");
            }
            else
            {
                notFound.Visible = true;
            }

        }

        private void loginToSelect_Click(object sender, EventArgs e)
        {
            this.userName = userType.Text;
            this.account = new Account(userName); 
            List<string> regNums = this.account.vehicleList(); // get list of registrations of vehicles for this account
            if (regNums.Any())
            {
                for (int i = 0; i < regNums.Count; i++)
                    this.selectVehicle.Items.Add(regNums.ElementAt(i));
                this.tabControl1.SelectTab("Selection");
            }
            else
            {
                invalidUser.Visible = true;
            }
        }

        private void selectToLogin_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectTab("login");
            this.userName = "";
            this.regNum = "";
            this.selectVehicle.Items.Clear();
            this.selectVehicle.Text = "";
            invalidUser.Visible = false;
            notFound.Visible = false;
            this.dataGridView1.Rows.Clear();
        }
    }
}
