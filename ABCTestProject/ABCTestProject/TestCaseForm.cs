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
    public partial class TestCaseForm : Form
    {
        private DataModule DM;
        private MainForm frmMenu;
        private CurrencyManager currencyManager;
        private CurrencyManager cmUseCase;

        public TestCaseForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
            BindControls();
            pnlAddTestCase.Left = 145;
            pnlAddTestCase.Top = 25;
            pnlUpdateTestCase.Left = 145;
            pnlUpdateTestCase.Top = 25;
        }

        private void BindControls()
        {
            txtTestCaseID.DataBindings.Add("Text", DM.dsABCTestProject, "TestCase.TestCaseID");
            txtTestCaseAbb.DataBindings.Add("Text", DM.dsABCTestProject, "TestCase.TestCaseAbb");
            txtTitle.DataBindings.Add("Text", DM.dsABCTestProject, "TestCase.Title");
            txtDescription.DataBindings.Add("Text", DM.dsABCTestProject, "TestCase.Description");
            txtUpdateTestCaseAbb.DataBindings.Add("Text", DM.dsABCTestProject, "TestCase.TestCaseAbb");
            txtUpdateTitle.DataBindings.Add("Text", DM.dsABCTestProject, "TestCase.Title");
            txtUpdateDescription.DataBindings.Add("Text", DM.dsABCTestProject, "TestCase.Description");
            txtTestCaseID.Enabled = false;
            txtTestCaseAbb.Enabled = false;
            txtTitle.Enabled = false;
            txtUseCaseAbb.Enabled = false;
            txtDescription.Enabled = false;
            txtUpdateTestCaseAbb.Enabled = false;
            txtUpdateTitle.Enabled = false;
            txtUpdateUseCaseAbb.Enabled = false;
            lstTestCase.DataSource = DM.dsABCTestProject;
            lstTestCase.DisplayMember = "TestCase.TestCaseAbb";
            lstTestCase.ValueMember = "TestCase.TestCaseAbb";
            currencyManager = (CurrencyManager)this.BindingContext[DM.dsABCTestProject, "TestCase"];
            cmUseCase = (CurrencyManager)this.BindingContext[DM.dsABCTestProject, "UseCase"];
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

        private void txtTestCaseID_TextChanged(object sender, EventArgs e)
        {
            int TestCaseID = Convert.ToInt32(txtTestCaseID.Text);
            currencyManager.Position = DM.testCaseView.Find(TestCaseID);
            DataRow drTestCase = DM.dtTestCase.Rows[currencyManager.Position];
            int UseCaseID = Convert.ToInt32(drTestCase["UseCaseID"].ToString());
            cmUseCase.Position = DM.useCaseView.Find(UseCaseID);
            DataRow drUSeCase = DM.dtUseCase.Rows[cmUseCase.Position];
            string UseCaseAbb = drUSeCase["UseCaseAbb"].ToString();
            txtUseCaseAbb.Text = UseCaseAbb;
            txtUpdateUseCaseAbb.Text = UseCaseAbb;
        }

        private void LoadUseCase()
        {
            cboAddUseCaseID.DataSource = DM.dsABCTestProject;
            cboAddUseCaseID.DisplayMember = "UseCase.UseCaseID";
            cboAddUseCaseID.ValueMember = "UseCase.UseCaseID";
            cboAddUseCaseAbb.DataSource = DM.dsABCTestProject;
            cboAddUseCaseAbb.DisplayMember = "UseCase.UseCaseAbb";
            cboAddUseCaseAbb.ValueMember = "UseCase.UseCaseAbb";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlAddTestCase.Hide();
            lstTestCase.Enabled = true;
            btnReturn.Enabled = true;
            btnDeleteTestCase.Enabled = true;
            btnNext.Enabled = true;
            btnPrevious.Enabled = true;
            btnUpdateTestCase.Enabled = true;
        }

        private void btnSaveTestCase_Click(object sender, EventArgs e)
        {
            DataRow newTestCaseRow = DM.dtTestCase.NewRow();

            if ((txtAddDescription.Text == "") || (txtAddTestCaseAbb.Text == "") || (txtAddTitle.Text == ""))
            {
                MessageBox.Show("You must type in a TestCase Abb, title and description.", "Error");
            }
            else
            {
                newTestCaseRow["TestCaseAbb"] = txtAddTestCaseAbb.Text;
                newTestCaseRow["UseCaseID"] = cboAddUseCaseID.Text;
                newTestCaseRow["Description"] = txtAddDescription.Text;
                newTestCaseRow["Title"] = txtAddTitle.Text;
                DM.dtTestCase.Rows.Add(newTestCaseRow);
                MessageBox.Show("TestCase added successfully.", "Success");
                DM.UpdateTestCase();
                pnlAddTestCase.Hide();
                lstTestCase.Enabled = true;
                btnReturn.Enabled = true;
                btnDeleteTestCase.Enabled = true;
                btnNext.Enabled = true;
                btnPrevious.Enabled = true;
                btnUpdateTestCase.Enabled = true;
            }
        }

        private void btnAddTestCase_Click(object sender, EventArgs e)
        {
            lstTestCase.Enabled = false;
            lstTestCase.SelectedItem = null;
            btnDeleteTestCase.Enabled = false;
            btnNext.Enabled = false;
            btnPrevious.Enabled = false;
            btnReturn.Enabled = false;
            btnUpdateTestCase.Enabled = false;
            pnlAddTestCase.Show();
            LoadUseCase();
        }

        private void btnCancel2_Click(object sender, EventArgs e)
        {
            pnlUpdateTestCase.Hide();
            lstTestCase.Visible = true;
            btnReturn.Enabled = true;
            btnDeleteTestCase.Enabled = true;
            btnNext.Enabled = true;
            btnPrevious.Enabled = true;
            btnAddTestCase.Enabled = true;
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            DataRow updateTestCaseRow = DM.dtTestCase.Rows[currencyManager.Position];

            if ((txtUpdateDescription.Text == ""))
            {
                MessageBox.Show("You must type in a description.", "Error");
            }
            else
            {
                updateTestCaseRow["Description"] = txtUpdateDescription.Text;
                currencyManager.EndCurrentEdit();
                DM.UpdateTestCase();
                MessageBox.Show("TestCase updated successfully.", "Success");
                pnlUpdateTestCase.Hide();
                lstTestCase.Visible = true;
                btnReturn.Enabled = true;
                btnDeleteTestCase.Enabled = true;
                btnNext.Enabled = true;
                btnPrevious.Enabled = true;
                btnAddTestCase.Enabled = true;
            }
        }

        private void btnUpdateTestCase_Click(object sender, EventArgs e)
        {
            lstTestCase.Visible = false;
            btnDeleteTestCase.Enabled = false;
            btnNext.Enabled = false;
            btnPrevious.Enabled = false;
            btnReturn.Enabled = false;
            btnAddTestCase.Enabled = false;
            pnlUpdateTestCase.Show();
        }

        private void btnDeleteTestCase_Click(object sender, EventArgs e)
        {
            DataRow deleteTestCaseRow = DM.dtTestCase.Rows[currencyManager.Position];
            double testCount = 0;

            foreach (DataRow drTest in DM.dtTest.Rows)
            {
                string testCaseID = drTest["TestCaseID"].ToString();
                if (testCaseID.Equals(txtTestCaseID.Text) == true)
                {
                    testCount += 1;
                }
            }
            if (testCount == 0)
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "warning", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    deleteTestCaseRow.Delete();
                    DM.UpdateTestCase();
                    MessageBox.Show("TestCase deleted successfully.", "Success");
                }
            }
            else
            {
                MessageBox.Show("You may only delete a TestCase that has no test.", "Error");
            }
        }
    }
}
