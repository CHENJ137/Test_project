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
    public partial class TestForm : Form
    {
        private DataModule DM;
        private MainForm frmMenu;
        private CurrencyManager currencyManager;
        private CurrencyManager cmTestCase;
        private CurrencyManager cmCategory;
        private CurrencyManager cmConfigure;
        private CurrencyManager cmEmployee;

        public TestForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
            BindControls();
            pnlAddTest.Left = 138;
            pnlAddTest.Top = 14;
            pnlUpdateTest.Left = 138;
            pnlUpdateTest.Top = 14;
        }

        private void BindControls()
        {
            txtTestID.DataBindings.Add("Text", DM.dsABCTestProject, "Test.TestID");
            txtTestAbb.DataBindings.Add("Text", DM.dsABCTestProject, "Test.TestAbb");
            txtStatus.DataBindings.Add("Text", DM.dsABCTestProject, "Test.Status");
            txtDateStart.DataBindings.Add("Text", DM.dsABCTestProject, "Test.DateStart");
            txtDateEnd.DataBindings.Add("Text", DM.dsABCTestProject, "Test.DateEnd");
            txtSteps.DataBindings.Add("Text", DM.dsABCTestProject, "Test.Steps");
            txtComment.DataBindings.Add("Text", DM.dsABCTestProject, "Test.Comment");
            txtUpdateTestAbb.DataBindings.Add("Text", DM.dsABCTestProject, "Test.TestAbb");
            txtUpdateDStart.DataBindings.Add("Text", DM.dsABCTestProject, "Test.DateStart");
            txtUpdateSteps.DataBindings.Add("Text", DM.dsABCTestProject, "Test.Steps");
            txtTestID.Enabled = false;
            txtTestCaseAbb.Enabled = false;
            txtTestAbb.Enabled = false;
            txtCategory.Enabled = false;
            txtStatus.Enabled = false;
            txtHardware.Enabled = false;
            txtSystem.Enabled = false;
            txtEmployee.Enabled = false;
            txtDateStart.Enabled = false;
            txtDateEnd.Enabled = false;
            txtSteps.Enabled = false;
            txtComment.Enabled = false;
            txtUpdateTestAbb.Enabled = false;
            txtUpdateTCAbb.Enabled = false;
            txtUpdateCategory.Enabled = false;
            txtUpdateEmployee.Enabled = false;
            txtUpdateHardware.Enabled = false;
            txtUpdateSystem.Enabled = false;
            txtUpdateDStart.Enabled = false;
            txtUpdateSteps.Enabled = false;
            lstTest.DataSource = DM.dsABCTestProject;
            lstTest.DisplayMember = "Test.TestAbb";
            lstTest.ValueMember = "Test.TestAbb";
            currencyManager = (CurrencyManager)this.BindingContext[DM.dsABCTestProject, "Test"];
            cmTestCase = (CurrencyManager)this.BindingContext[DM.dsABCTestProject, "TestCase"];
            cmCategory = (CurrencyManager)this.BindingContext[DM.dsABCTestProject, "Category"];
            cmConfigure = (CurrencyManager)this.BindingContext[DM.dsABCTestProject, "Configure"];
            cmEmployee = (CurrencyManager)this.BindingContext[DM.dsABCTestProject, "Employee"];
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

        private void txtTestID_TextChanged(object sender, EventArgs e)
        {
            int TestID = Convert.ToInt32(txtTestID.Text);
            currencyManager.Position = DM.testView.Find(TestID);
            DataRow drTest = DM.dtTest.Rows[currencyManager.Position];
            int TestCaseID = Convert.ToInt32(drTest["TestCaseID"].ToString());
            cmTestCase.Position = DM.testCaseView.Find(TestCaseID);
            DataRow drTestCase = DM.dtTestCase.Rows[cmTestCase.Position];
            string TestCaseAbb = drTestCase["TestCaseAbb"].ToString();
            txtTestCaseAbb.Text = TestCaseAbb;
            txtUpdateTCAbb.Text = TestCaseAbb;

            int CategoryID = Convert.ToInt32(drTest["CategoryID"].ToString());
            cmCategory.Position = DM.categoryView.Find(CategoryID);
            DataRow drCategory = DM.dtCategory.Rows[cmCategory.Position];
            string Category = drCategory["CategoryName"].ToString();
            txtCategory.Text = Category;
            txtUpdateCategory.Text = Category;

            int ConfigureID = Convert.ToInt32(drTest["ConfigureID"].ToString());
            cmConfigure.Position = DM.categoryView.Find(ConfigureID);
            DataRow drConfigure = DM.dtConfigure.Rows[cmConfigure.Position];
            string Hardware = drConfigure["HardwareName"].ToString();
            string System = drConfigure["OperatingSystem"].ToString();
            txtHardware.Text = Hardware;
            txtSystem.Text = System;
            txtUpdateHardware.Text = Hardware;
            txtUpdateSystem.Text = System;

            int EmployeeID = Convert.ToInt32(drTest["EmployeeID"].ToString());
            cmEmployee.Position = DM.employeeView.Find(EmployeeID);
            DataRow drEmployee = DM.dtEmployee.Rows[cmEmployee.Position];
            string firstName = drEmployee["FirstName"].ToString();
            string lastName = drEmployee["LastName"].ToString();
            txtEmployee.Text = firstName + " " + lastName;
            txtUpdateEmployee.Text = firstName + " " + lastName;
        }

        private void LoadAdd()
        {
            cboAddCategoryID.DataSource = DM.dsABCTestProject;
            cboAddCategoryID.DisplayMember = "Category.CategoryID";
            cboAddCategoryID.ValueMember = "Category.CategoryID";

            cboAddCategoryName.DataSource = DM.dsABCTestProject;
            cboAddCategoryName.DisplayMember = "Category.CategoryName";
            cboAddCategoryName.ValueMember = "Category.CategoryName";

            cboAddTCID.DataSource = DM.dsABCTestProject;
            cboAddTCID.DisplayMember = "TestCase.TestCaseID";
            cboAddTCID.ValueMember = "TestCase.TestCaseID";

            cboAddTCAbb.DataSource = DM.dsABCTestProject;
            cboAddTCAbb.DisplayMember = "TestCase.TestCaseAbb";
            cboAddTCAbb.ValueMember = "TestCase.TestCaseAbb";

            cboAddConfigureID.DataSource = DM.dsABCTestProject;
            cboAddConfigureID.DisplayMember = "Configure.ConfigureID";
            cboAddConfigureID.ValueMember = "Configure.ConfigureID";

            cboAddHardware.DataSource = DM.dsABCTestProject;
            cboAddHardware.DisplayMember = "Configure.HardwareName";
            cboAddHardware.ValueMember = "Configure.HardwareName";

            cboAddSystem.DataSource = DM.dsABCTestProject;
            cboAddSystem.DisplayMember = "Configure.OperatingSystem";
            cboAddSystem.ValueMember = "Configure.OperatingSystem";

            cboAddEmployeeID.DataSource = DM.dsABCTestProject;
            cboAddEmployeeID.DisplayMember = "Employee.EmployeeID";
            cboAddEmployeeID.ValueMember = "Employee.EmployeeID";

            cboAddFirstN.DataSource = DM.dsABCTestProject;
            cboAddFirstN.DisplayMember = "Employee.FirstName";
            cboAddFirstN.ValueMember = "Employee.FirstName";

            cboAddLastN.DataSource = DM.dsABCTestProject;
            cboAddLastN.DisplayMember = "Employee.LastName";
            cboAddLastN.ValueMember = "Employee.LastName";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlAddTest.Hide();
            lstTest.Enabled = true;
            btnReturn.Enabled = true;
            btnDeleteTest.Enabled = true;
            btnNext.Enabled = true;
            btnPrevious.Enabled = true;
            btnUpdateTest.Enabled = true;
        }

        private void btnSaveTest_Click(object sender, EventArgs e)
        {
            DataRow newTestRow = DM.dtTest.NewRow();

            if ((txtAddSteps.Text == "") || (txtAddTestAbb.Text == ""))
            {
                MessageBox.Show("You must type in a Test Abb and steps.", "Error");
            }
            else
            {
                newTestRow["TestAbb"] = txtAddTestAbb.Text;
                newTestRow["TestCaseID"] = cboAddTCID.Text;
                newTestRow["CategoryID"] = cboAddCategoryID.Text;
                newTestRow["ConfigureID"] = cboAddConfigureID.Text;
                newTestRow["EmployeeID"] = cboAddEmployeeID.Text;
                newTestRow["DateStart"] = dtpAddDStart.Text;
                newTestRow["Steps"] = txtAddSteps.Text;
                DM.dtTest.Rows.Add(newTestRow);
                MessageBox.Show("Test added successfully.", "Success");
                DM.UpdateTest();
                pnlAddTest.Hide();
                lstTest.Enabled = true;
                btnReturn.Enabled = true;
                btnDeleteTest.Enabled = true;
                btnNext.Enabled = true;
                btnPrevious.Enabled = true;
                btnUpdateTest.Enabled = true;
            }
        }

        private void btnAddTest_Click(object sender, EventArgs e)
        {
            lstTest.Enabled = false;
            lstTest.SelectedItem = null;
            btnDeleteTest.Enabled = false;
            btnNext.Enabled = false;
            btnPrevious.Enabled = false;
            btnReturn.Enabled = false;
            btnUpdateTest.Enabled = false;
            pnlAddTest.Show();
            LoadAdd();
        }

        private void btnCancel2_Click(object sender, EventArgs e)
        {
            pnlUpdateTest.Hide();
            lstTest.Visible = true;
            btnReturn.Enabled = true;
            btnDeleteTest.Enabled = true;
            btnNext.Enabled = true;
            btnPrevious.Enabled = true;
            btnAddTest.Enabled = true;
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            DataRow updateTestRow = DM.dtTest.Rows[currencyManager.Position];

            if ((txtUpdateComment.Text == ""))
            {
                MessageBox.Show("You must type in a comment.", "Error");
            }
            else
            {
                updateTestRow["Status"] = cboUpdateStatus.Text;
                updateTestRow["DateEnd"] = dtpDEnd.Text;
                updateTestRow["Comment"] = txtUpdateComment.Text;
                currencyManager.EndCurrentEdit();
                DM.UpdateTest();
                MessageBox.Show("Test updated successfully.", "Success");
                pnlUpdateTest.Hide();
                lstTest.Visible = true;
                btnReturn.Enabled = true;
                btnDeleteTest.Enabled = true;
                btnNext.Enabled = true;
                btnPrevious.Enabled = true;
                btnAddTest.Enabled = true;
            }
        }

        private void btnUpdateTest_Click(object sender, EventArgs e)
        {
            lstTest.Visible = false;
            btnDeleteTest.Enabled = false;
            btnNext.Enabled = false;
            btnPrevious.Enabled = false;
            btnReturn.Enabled = false;
            btnAddTest.Enabled = false;
            pnlUpdateTest.Show();
        }

        private void btnDeleteTest_Click(object sender, EventArgs e)
        {
            DataRow deleteTestRow = DM.dtTest.Rows[currencyManager.Position];
            string Status = deleteTestRow["Status"].ToString();

            if ( Status == "" )
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "warning", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    deleteTestRow.Delete();
                    DM.UpdateTest();
                    MessageBox.Show("Test deleted successfully.", "Success");
                }
            }
            else
            {
                MessageBox.Show("You may only delete a Test that haven't been tested.", "Error");
            }
        }
    }
}
