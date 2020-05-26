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
    public partial class UseCaseForm : Form
    {
        private DataModule DM;
        private MainForm frmMenu;
        private CurrencyManager currencyManager;
        private CurrencyManager cmProject;

        public UseCaseForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
            BindControls();
            pnlAddUseCase.Left = 145;
            pnlAddUseCase.Top = 25;
            pnlUpdateUseCase.Left = 145;
            pnlUpdateUseCase.Top = 25;
        }

        private void BindControls()
        {
            txtUseCaseID.DataBindings.Add("Text", DM.dsABCTestProject, "UseCase.UseCaseID");
            txtUseCaseAbb.DataBindings.Add("Text", DM.dsABCTestProject, "UseCase.UseCaseAbb");
            txtDescription.DataBindings.Add("Text", DM.dsABCTestProject, "UseCase.Description");
            txtUpdateUseCaseAbb.DataBindings.Add("Text", DM.dsABCTestProject, "UseCase.UseCaseAbb");
            txtUpdateDescription.DataBindings.Add("Text", DM.dsABCTestProject, "UseCase.Description");
            txtUseCaseID.Enabled = false;
            txtUseCaseAbb.Enabled = false;
            txtProjectName.Enabled = false;
            txtDescription.Enabled = false;
            txtUpdateUseCaseAbb.Enabled = false;
            txtUpdateProjectName.Enabled = false;
            lstUseCase.DataSource = DM.dsABCTestProject;
            lstUseCase.DisplayMember = "UseCase.UseCaseAbb";
            lstUseCase.ValueMember = "UseCase.UseCaseAbb";
            currencyManager = (CurrencyManager)this.BindingContext[DM.dsABCTestProject, "UseCase"];
            cmProject = (CurrencyManager)this.BindingContext[DM.dsABCTestProject, "Project"];
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

        private void txtUseCaseID_TextChanged(object sender, EventArgs e)
        {
            int UseCaseID = Convert.ToInt32(txtUseCaseID.Text);
            currencyManager.Position = DM.useCaseView.Find(UseCaseID);
            DataRow drUseCase = DM.dtUseCase.Rows[currencyManager.Position];
            int ProjectID = Convert.ToInt32(drUseCase["ProjectID"].ToString());
            cmProject.Position = DM.projectView.Find(ProjectID);
            DataRow drProject = DM.dtProject.Rows[cmProject.Position];
            string ProjectName = drProject["ProjectName"].ToString();
            txtProjectName.Text = ProjectName;
            txtUpdateProjectName.Text = ProjectName;
        }

        private void LoadProject()
        {
            cboAddProjectID.DataSource = DM.dsABCTestProject;
            cboAddProjectID.DisplayMember = "Project.ProjectID";
            cboAddProjectID.ValueMember = "Project.ProjectID";
            cboAddProjectName.DataSource = DM.dsABCTestProject;
            cboAddProjectName.DisplayMember = "Project.ProjectName";
            cboAddProjectName.ValueMember = "Project.ProjectName";
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            pnlAddUseCase.Hide();
            lstUseCase.Enabled = true;
            btnReturn.Enabled = true;
            btnDeleteUseCase.Enabled = true;
            btnNext.Enabled = true;
            btnPrevious.Enabled = true;
            btnUpdateUseCase.Enabled = true;
        }

        private void btnSaveUseCase_Click(object sender, EventArgs e)
        {
            DataRow newUseCaseRow = DM.dtUseCase.NewRow();

            if ((txtAddDescription.Text == "") || (txtAddUseCaseAbb.Text == ""))
            {
                MessageBox.Show("You must type in a UseCase Abb and description.", "Error");
            }
            else
            {
                newUseCaseRow["UseCaseAbb"] = txtAddUseCaseAbb.Text;
                newUseCaseRow["ProjectID"] = cboAddProjectID.Text;
                newUseCaseRow["Description"] = txtAddDescription.Text;
                DM.dtUseCase.Rows.Add(newUseCaseRow);
                MessageBox.Show("UseCase added successfully.", "Success");
                DM.UpdateUseCase();
                pnlAddUseCase.Hide();
                lstUseCase.Enabled = true;
                btnReturn.Enabled = true;
                btnDeleteUseCase.Enabled = true;
                btnNext.Enabled = true;
                btnPrevious.Enabled = true;
                btnUpdateUseCase.Enabled = true;
            }
        }

        private void btnAddUseCase_Click(object sender, EventArgs e)
        {
            lstUseCase.Enabled = false;
            lstUseCase.SelectedItem = null;
            btnDeleteUseCase.Enabled = false;
            btnNext.Enabled = false;
            btnPrevious.Enabled = false;
            btnReturn.Enabled = false;
            btnUpdateUseCase.Enabled = false;
            pnlAddUseCase.Show();
            LoadProject();
        }

        private void btnCancel2_Click(object sender, EventArgs e)
        {
            pnlUpdateUseCase.Hide();
            lstUseCase.Visible = true;
            btnReturn.Enabled = true;
            btnDeleteUseCase.Enabled = true;
            btnNext.Enabled = true;
            btnPrevious.Enabled = true;
            btnAddUseCase.Enabled = true;
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            DataRow updateUseCaseRow = DM.dtUseCase.Rows[currencyManager.Position];

            if ((txtUpdateDescription.Text == ""))
            {
                MessageBox.Show("You must type in a description.", "Error");
            }
            else
            {
                updateUseCaseRow["Description"] = txtUpdateDescription.Text;
                currencyManager.EndCurrentEdit();
                DM.UpdateUseCase();
                MessageBox.Show("UseCase updated successfully.", "Success");
                pnlUpdateUseCase.Hide();
                lstUseCase.Visible = true;
                btnReturn.Enabled = true;
                btnDeleteUseCase.Enabled = true;
                btnNext.Enabled = true;
                btnPrevious.Enabled = true;
                btnAddUseCase.Enabled = true;
            }
        }

        private void btnUpdateUseCase_Click(object sender, EventArgs e)
        {
            lstUseCase.Visible = false;
            btnDeleteUseCase.Enabled = false;
            btnNext.Enabled = false;
            btnPrevious.Enabled = false;
            btnReturn.Enabled = false;
            btnAddUseCase.Enabled = false;
            pnlUpdateUseCase.Show();
        }

        private void btnDeleteUseCase_Click(object sender, EventArgs e)
        {
            DataRow deleteUseCaseRow = DM.dtUseCase.Rows[currencyManager.Position];
            double testCaseCount = 0;

            foreach (DataRow drTestCase in DM.dtTestCase.Rows)
            {
                string useCaseID = drTestCase["TestCaseID"].ToString();
                if (useCaseID.Equals(txtUseCaseID.Text) == true)
                {
                    testCaseCount += 1;
                }
            }
            if (testCaseCount == 0)
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "warning", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    deleteUseCaseRow.Delete();
                    DM.UpdateUseCase();
                    MessageBox.Show("UseCase deleted successfully.", "Success");
                }
            }
            else
            {
                MessageBox.Show("You may only delete a UseCase that has no test case.", "Error");
            }
        }
    }
}
