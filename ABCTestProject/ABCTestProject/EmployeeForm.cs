using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABCTestProject
{
    public partial class EmployeeForm : Form
    {
        private DataModule DM;
        private MainForm frmMenu;
        private CurrencyManager currencyManager;

        public EmployeeForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
            BindControls();
            pnlAddEmployee.Left = 148;
            pnlAddEmployee.Top = 25;
            pnlUpdateEmployee.Left = 148;
            pnlUpdateEmployee.Top = 25;
        }

        private void BindControls()
        {
            txtEmployeeID.DataBindings.Add("Text", DM.dsABCTestProject, "Employee.EmployeeID");
            txtFirstN.DataBindings.Add("Text", DM.dsABCTestProject, "Employee.FirstName");
            txtLastN.DataBindings.Add("Text", DM.dsABCTestProject, "Employee.LastName");
            txtJob.DataBindings.Add("Text", DM.dsABCTestProject, "Employee.JobTitle");
            txtExt.DataBindings.Add("Text", DM.dsABCTestProject, "Employee.Ext");
            txtEmail.DataBindings.Add("Text", DM.dsABCTestProject, "Employee.Email");
            txtUpdateFirstN.DataBindings.Add("Text", DM.dsABCTestProject, "Employee.FirstName");
            txtUpdateLastN.DataBindings.Add("Text", DM.dsABCTestProject, "Employee.LastName");
            txtUpdateJob.DataBindings.Add("Text", DM.dsABCTestProject, "Employee.JobTitle");
            txtUpdateExt.DataBindings.Add("Text", DM.dsABCTestProject, "Employee.Ext");
            txtUpdateEmail.DataBindings.Add("Text", DM.dsABCTestProject, "Employee.Email");
            txtEmployeeID.Enabled = false;
            txtFirstN.Enabled = false;
            txtLastN.Enabled = false;
            txtJob.Enabled = false;
            txtExt.Enabled = false;
            txtEmail.Enabled = false;
            txtUpdateFirstN.Enabled = false;
            txtUpdateLastN.Enabled = false;
            lstEmployee.DataSource = DM.dsABCTestProject;
            lstEmployee.DisplayMember = "Employee.EmployeeID";
            lstEmployee.ValueMember = "Employee.EmployeeID";
            currencyManager = (CurrencyManager)this.BindingContext[DM.dsABCTestProject, "Employee"];
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (currencyManager.Position > 0)
            {
                --currencyManager.Position;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currencyManager.Position < currencyManager.Count - 1)
            {
                ++currencyManager.Position;
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlAddEmployee.Hide();
            lstEmployee.Visible = true;
            btnReturn.Enabled = true;
            btnDeleteEmployee.Enabled = true;
            btnNext.Enabled = true;
            btnPrevious.Enabled = true;
            btnUpdateEmployee.Enabled = true;
        }

        private void btnSaveEmployee_Click(object sender, EventArgs e)
        {
            DataRow newEmployeeRow = DM.dtEmployee.NewRow();

            if ((txtAddFirstN.Text == "") || (txtAddLastN.Text == "") || (txtAddJob.Text == "") || (txtAddExt.Text == "") || (txtAddEmail.Text == ""))
            {
                MessageBox.Show("You must type in a full name, job title, ext. number and email.", "Error");
            }
            else
            {
                newEmployeeRow["FirstName"] = txtAddFirstN.Text;
                newEmployeeRow["LastName"] = txtAddLastN.Text;
                newEmployeeRow["JobTitle"] = txtAddJob.Text;
                newEmployeeRow["Ext"] = txtAddExt.Text;
                newEmployeeRow["Email"] = txtAddEmail.Text;
                DM.dtEmployee.Rows.Add(newEmployeeRow);
                MessageBox.Show("Employee added successfully.", "Success");
                DM.UpdateEmployee();
                pnlAddEmployee.Hide();
                lstEmployee.Visible = true;
                btnReturn.Enabled = true;
                btnDeleteEmployee.Enabled = true;
                btnNext.Enabled = true;
                btnPrevious.Enabled = true;
                btnUpdateEmployee.Enabled = true;
            }
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            lstEmployee.Visible = false;
            btnDeleteEmployee.Enabled = false;
            btnNext.Enabled = false;
            btnPrevious.Enabled = false;
            btnReturn.Enabled = false;
            btnUpdateEmployee.Enabled = false;
            pnlAddEmployee.Show();
        }

        private void btnCancel2_Click(object sender, EventArgs e)
        {
            pnlUpdateEmployee.Hide();
            lstEmployee.Visible = true;
            btnReturn.Enabled = true;
            btnDeleteEmployee.Enabled = true;
            btnNext.Enabled = true;
            btnPrevious.Enabled = true;
            btnAddEmployee.Enabled = true;
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            DataRow updateEmployeeRow = DM.dtEmployee.Rows[currencyManager.Position];

            if ((txtUpdateJob.Text == "") || (txtUpdateExt.Text == "") || (lblUpdateEmail.Text == ""))
            {
                MessageBox.Show("You must type in a job title, ext. number and email.", "Error");
            }
            else
            {
                updateEmployeeRow["JobTitle"] = txtUpdateJob.Text;
                updateEmployeeRow["Ext"] = txtUpdateExt.Text;
                updateEmployeeRow["Email"] = lblUpdateEmail.Text;
                currencyManager.EndCurrentEdit();
                DM.UpdateEmployee();
                MessageBox.Show("Employee updated successfully.", "Success");
                pnlUpdateEmployee.Hide();
                lstEmployee.Visible = true;
                btnReturn.Enabled = true;
                btnDeleteEmployee.Enabled = true;
                btnNext.Enabled = true;
                btnPrevious.Enabled = true;
                btnAddEmployee.Enabled = true;
            }
        }

        private void btnUpdateEmployee_Click(object sender, EventArgs e)
        {
            lstEmployee.Visible = false;
            btnDeleteEmployee.Enabled = false;
            btnNext.Enabled = false;
            btnPrevious.Enabled = false;
            btnReturn.Enabled = false;
            btnAddEmployee.Enabled = false;
            pnlUpdateEmployee.Show();
        }

        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            DataRow deleteEmployeeRow = DM.dtEmployee.Rows[currencyManager.Position];
            double employeeCount = 0;

            foreach (DataRow drTest in DM.dtTest.Rows)
            {
                string employeeID = drTest["EmployeeID"].ToString();
                if (employeeID.Equals(txtEmployeeID.Text) == true)
                {
                    employeeCount += 1;
                }
            }

            foreach (DataRow drBug in DM.dtBug.Rows)
            {
                string employeeID2 = drBug["EmployeeID"].ToString();
                if (employeeID2.Equals(txtEmployeeID.Text) == true)
                {
                    employeeCount += 1;
                }
            }

            if (employeeCount == 0)
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "warning", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    deleteEmployeeRow.Delete();
                    DM.UpdateEmployee();
                    MessageBox.Show("Employee deleted successfully.", "Success");
                }
            }
            else
            {
                MessageBox.Show("You may only delete a employee that is not working.", "Error");
            }
        }
    }
}
