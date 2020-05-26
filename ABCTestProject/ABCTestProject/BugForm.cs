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
    public partial class BugForm : Form
    {
        private DataModule DM;
        private MainForm frmMenu;
        private CurrencyManager currencyManager;
        private CurrencyManager cmTest;
        private CurrencyManager cmEmployee;
        private CurrencyManager cmPriority;
        private CurrencyManager cmSeverity;

        public BugForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
            BindControls();
            pnlAddBug.Left = 130;
            pnlAddBug.Top = 25;
            pnlUpdateBug.Left = 130;
            pnlUpdateBug.Top = 25;
        }

        private void BindControls()
        {
            txtBugID.DataBindings.Add("Text", DM.dsABCTestProject, "Bug.BugID");
            txtBugAbb.DataBindings.Add("Text", DM.dsABCTestProject, "Bug.BugAbb");
            txtStatus.DataBindings.Add("Text", DM.dsABCTestProject, "Bug.Status");
            txtDateDetected.DataBindings.Add("Text", DM.dsABCTestProject, "Bug.DateDetected");
            txtDateFinish.DataBindings.Add("Text", DM.dsABCTestProject, "Bug.DateFinished");
            txtActualDate.DataBindings.Add("Text", DM.dsABCTestProject, "Bug.ACtualDate");
            txtPriorityID.DataBindings.Add("Text", DM.dsABCTestProject, "Bug.PriorityID");
            txtSeverityID.DataBindings.Add("Text", DM.dsABCTestProject, "Bug.SeverityID");
            txtRating.DataBindings.Add("Text", DM.dsABCTestProject, "Bug.Rating");
            txtComment.DataBindings.Add("Text", DM.dsABCTestProject, "Bug.Comment");
            txtUpdateBugAbb.DataBindings.Add("Text", DM.dsABCTestProject, "Bug.BugAbb");
            txtUpdateDDetected.DataBindings.Add("Text", DM.dsABCTestProject, "Bug.DateDetected");
            txtUpdateDFinish.DataBindings.Add("Text", DM.dsABCTestProject, "Bug.DateFinished");
            txtUpdatePriority.DataBindings.Add("Text", DM.dsABCTestProject, "Bug.PriorityID");
            txtUpdateSverity.DataBindings.Add("Text", DM.dsABCTestProject, "Bug.SeverityID");
            txtUpdateComment.DataBindings.Add("Text", DM.dsABCTestProject, "Bug.Comment");
            txtBugID.Enabled = false;
            txtBugAbb.Enabled = false;
            txtTestAbb.Enabled = false;
            txtStatus.Enabled = false;
            txtDateDetected.Enabled = false;
            txtDateFinish.Enabled = false;
            txtEmployee.Enabled = false;
            txtActualDate.Enabled = false;
            txtPriorityID.Enabled = false;
            txtPriorityDescription.Enabled = false;
            txtSeverityID.Enabled = false;
            txtSeverityDescription.Enabled = false;
            txtRating.Enabled = false;
            txtComment.Enabled = false;
            txtUpdateBugAbb.Enabled = false;
            txtUpdateTestAbb.Enabled = false;
            txtUpdateDDetected.Enabled = false;
            txtUpdateDFinish.Enabled = false;
            txtUpdatePriority.Enabled = false;
            txtUpdateSverity.Enabled = false;
            lstBug.DataSource = DM.dsABCTestProject;
            lstBug.DisplayMember = "Bug.BugAbb";
            lstBug.ValueMember = "Bug.BugAbb";
            currencyManager = (CurrencyManager)this.BindingContext[DM.dsABCTestProject, "Bug"];
            cmTest = (CurrencyManager)this.BindingContext[DM.dsABCTestProject, "Test"];
            cmEmployee = (CurrencyManager)this.BindingContext[DM.dsABCTestProject, "Employee"];
            cmPriority = (CurrencyManager)this.BindingContext[DM.dsABCTestProject, "Priority"];
            cmSeverity = (CurrencyManager)this.BindingContext[DM.dsABCTestProject, "Severity"];
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

        private void txtBugID_TextChanged(object sender, EventArgs e)
        {
            int BugID = Convert.ToInt32(txtBugID.Text);
            currencyManager.Position = DM.bugView.Find(BugID);
            DataRow drBug = DM.dtBug.Rows[currencyManager.Position];
            int TestID = Convert.ToInt32(drBug["TestID"].ToString());
            cmTest.Position = DM.testView.Find(TestID);
            DataRow drTest = DM.dtTest.Rows[cmTest.Position];
            string TestAbb = drTest["TestAbb"].ToString();
            txtTestAbb.Text = TestAbb;
            txtUpdateTestAbb.Text = TestAbb;

            string Assigned = drBug["Assigned"].ToString();
            if (Assigned == "Assigned")
            {
                int EmployeeID = Convert.ToInt32(drBug["EmployeeID"].ToString());
                cmEmployee.Position = DM.employeeView.Find(EmployeeID);
                DataRow drEmployee = DM.dtEmployee.Rows[cmEmployee.Position];
                string firstName = drEmployee["FirstName"].ToString();
                string lastName = drEmployee["LastName"].ToString();
                txtEmployee.Text = firstName + " " + lastName;
            }
            

            int priorityID = Convert.ToInt32(drBug["PriorityID"].ToString());
            cmPriority.Position = DM.priorityView.Find(priorityID);
            DataRow drPriority = DM.dtPriority.Rows[cmPriority.Position];
            string Priority = drPriority["Priority"].ToString();
            string PriorityD = drPriority["Description"].ToString();
            txtPriorityDescription.Text = Priority + ". " + PriorityD;

            int severityID = Convert.ToInt32(drBug["SeverityID"].ToString());
            cmSeverity.Position = DM.severityView.Find(severityID);
            DataRow drSeverity = DM.dtSeverity.Rows[cmSeverity.Position];
            string Severity = drSeverity["Severity"].ToString();
            string SeverityD = drSeverity["Description"].ToString();
            txtSeverityDescription.Text = Severity + ". " + SeverityD;
        }

        private void LoadAdd()
        {
            cboAddTestID.DataSource = DM.dsABCTestProject;
            cboAddTestID.DisplayMember = "Test.TestID";
            cboAddTestID.ValueMember = "Test.TestID";

            cboAddTestAbb.DataSource = DM.dsABCTestProject;
            cboAddTestAbb.DisplayMember = "Test.TestAbb";
            cboAddTestAbb.ValueMember = "Test.TestAbb";

            cboAddPriorityID.DataSource = DM.dsABCTestProject;
            cboAddPriorityID.DisplayMember = "Priority.PriorityID";
            cboAddPriorityID.ValueMember = "Priority.PriorityID";

            cboAddPriority.DataSource = DM.dsABCTestProject;
            cboAddPriority.DisplayMember = "Priority.Priority";
            cboAddPriority.ValueMember = "Priority.Priority";

            cboAddSeverityID.DataSource = DM.dsABCTestProject;
            cboAddSeverityID.DisplayMember = "Severity.SeverityID";
            cboAddSeverityID.ValueMember = "Severity.SeverityID";

            cboAddSeverity.DataSource = DM.dsABCTestProject;
            cboAddSeverity.DisplayMember = "Severity.Severity";
            cboAddSeverity.ValueMember = "Severity.Severity";
        }

        private void LoadUpdate()
        {
            cboUpdateEmployeeID.DataSource = DM.dsABCTestProject;
            cboUpdateEmployeeID.DisplayMember = "Employee.EmployeeID";
            cboUpdateEmployeeID.ValueMember = "Employee.EmployeeID";

            cboUpdateFirstN.DataSource = DM.dsABCTestProject;
            cboUpdateFirstN.DisplayMember = "Employee.FirstName";
            cboUpdateFirstN.ValueMember = "Employee.FirstName";

            cboUpdateLastN.DataSource = DM.dsABCTestProject;
            cboUpdateLastN.DisplayMember = "Employee.LastName";
            cboUpdateLastN.ValueMember = "Employee.LastName";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlAddBug.Hide();
            lstBug.Enabled = true;
            btnReturn.Enabled = true;
            btnDeleteBug.Enabled = true;
            btnNext.Enabled = true;
            btnPrevious.Enabled = true;
            btnUpdateBug.Enabled = true;
        }

        private void btnSaveTest_Click(object sender, EventArgs e)
        {
            DataRow newBugRow = DM.dtBug.NewRow();

            if ((txtAddBugAbb.Text == ""))
            {
                MessageBox.Show("You must type in a Bug Abb.", "Error");
            }
            else
            {
                int priorityID = Convert.ToInt32(cboAddPriorityID.Text);
                int severityID = Convert.ToInt32(cboAddSeverityID.Text);
                double rating = priorityID*severityID;

                newBugRow["BugAbb"] = txtAddBugAbb.Text;
                newBugRow["TestID"] = cboAddTestID.Text;
                newBugRow["PriorityID"] = cboAddPriorityID.Text;
                newBugRow["SeverityID"] = cboAddSeverityID.Text;
                newBugRow["DateDetected"] = dtpAddDDetected.Text;
                newBugRow["DateFinished"] = dtpAddDFinish.Text;
                newBugRow["Comment"] = txtAddComment.Text;
                newBugRow["Assigned"] = "Not Assigned";
                newBugRow["Rating"] = rating;
                DM.dtBug.Rows.Add(newBugRow);
                MessageBox.Show("Bug record added successfully.", "Success");
                DM.UpdateBug();
                pnlAddBug.Hide();
                lstBug.Enabled = true;
                btnReturn.Enabled = true;
                btnDeleteBug.Enabled = true;
                btnNext.Enabled = true;
                btnPrevious.Enabled = true;
                btnUpdateBug.Enabled = true;
            }
        }

        private void btnAddBug_Click(object sender, EventArgs e)
        {
            lstBug.Enabled = false;
            lstBug.SelectedItem = null;
            btnDeleteBug.Enabled = false;
            btnNext.Enabled = false;
            btnPrevious.Enabled = false;
            btnReturn.Enabled = false;
            btnUpdateBug.Enabled = false;
            pnlAddBug.Show();
            LoadAdd();
        }

        private void btnCancel2_Click(object sender, EventArgs e)
        {
            pnlUpdateBug.Hide();
            lstBug.Visible = true;
            btnReturn.Enabled = true;
            btnDeleteBug.Enabled = true;
            btnNext.Enabled = true;
            btnPrevious.Enabled = true;
            btnAddBug.Enabled = true;
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            DataRow updateBugRow = DM.dtBug.Rows[currencyManager.Position];

            if ((txtUpdateComment.Text == ""))
            {
                MessageBox.Show("You must type in a comment.", "Error");
            }
            else
            {
                updateBugRow["Status"] = cboUpdateStatus.Text;
                updateBugRow["ActualDate"] = dtpUpdateActualD.Text;
                updateBugRow["EmployeeID"] = cboUpdateEmployeeID.Text;
                updateBugRow["Comment"] = txtUpdateComment.Text;
                updateBugRow["Assigned"] = "Assigned";
                currencyManager.EndCurrentEdit();
                DM.UpdateBug();
                MessageBox.Show("Bug record updated successfully.", "Success");
                pnlUpdateBug.Hide();
                lstBug.Visible = true;
                btnReturn.Enabled = true;
                btnDeleteBug.Enabled = true;
                btnNext.Enabled = true;
                btnPrevious.Enabled = true;
                btnAddBug.Enabled = true;
            }
        }

        private void btnUpdateBug_Click(object sender, EventArgs e)
        {
            lstBug.Visible = false;
            btnDeleteBug.Enabled = false;
            btnNext.Enabled = false;
            btnPrevious.Enabled = false;
            btnReturn.Enabled = false;
            btnAddBug.Enabled = false;
            pnlUpdateBug.Show();
            LoadUpdate();
        }

        private void btnDeleteBug_Click(object sender, EventArgs e)
        {
            DataRow deleteBugRow = DM.dtBug.Rows[currencyManager.Position];
            string Status = deleteBugRow["Status"].ToString();

            if (Status == "")
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "warning", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    deleteBugRow.Delete();
                    DM.UpdateBug();
                    MessageBox.Show("Bug record deleted successfully.", "Success");
                }
            }
            else
            {
                MessageBox.Show("You may only delete a Bug Record that isn;t open.", "Error");
            }
        }

        private void btnMarkOpen_Click(object sender, EventArgs e)
        {
            DataRow MarkBugRow = DM.dtBug.Rows[currencyManager.Position];

            if (txtStatus.Text != "")
            {
                MessageBox.Show("Only not opened Bug Record can be marked as open", "Error");
            }
            else
            {
                MarkBugRow["Status"] = "Open";
                currencyManager.EndCurrentEdit();
                DM.UpdateBug();
                MessageBox.Show("Bug record marked as open.", "Success");
            }
        }
    }
}
