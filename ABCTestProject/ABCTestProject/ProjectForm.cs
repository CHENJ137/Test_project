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
    public partial class ProjectForm : Form
    {
        private DataModule DM;
        private MainForm frmMenu;
        private CurrencyManager currencyManager;

        public ProjectForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
            BindControls();
            pnlAddProject.Left = 145;
            pnlAddProject.Top = 25;
            pnlUpdateProject.Left = 145;
            pnlUpdateProject.Top = 25;
        }

        public void BindControls()
        {
            txtProjectID.DataBindings.Add("Text", DM.dsABCTestProject, "Project.ProjectID");
            txtProjectName.DataBindings.Add("Text", DM.dsABCTestProject, "Project.ProjectName");
            txtDateStart.DataBindings.Add("Text", DM.dsABCTestProject, "Project.DateStart");
            txtDateEnd.DataBindings.Add("Text", DM.dsABCTestProject, "Project.DateEnd");
            txtDescription.DataBindings.Add("Text", DM.dsABCTestProject, "Project.Description");
            txtProjectAbb.DataBindings.Add("Text", DM.dsABCTestProject, "Project.ProjectAbb");
            txtUpdateProjectName.DataBindings.Add("Text", DM.dsABCTestProject, "Project.ProjectName");
            txtUpdateProjectAbb.DataBindings.Add("Text", DM.dsABCTestProject, "Project.ProjectAbb");
            dtpUpdateDateStart.DataBindings.Add("Text", DM.dsABCTestProject, "Project.DateStart");
            dtpUpdateDateEnd.DataBindings.Add("Text", DM.dsABCTestProject, "Project.DateEnd");
            txtUpdateDescription.DataBindings.Add("Text", DM.dsABCTestProject, "Project.Description");
            txtProjectID.Enabled = false;
            txtProjectName.Enabled = false;
            txtDateStart.Enabled = false;
            txtDateEnd.Enabled = false;
            txtDescription.Enabled = false;
            txtProjectAbb.Enabled = false;
            txtUpdateProjectName.Enabled = false;
            txtUpdateProjectAbb.Enabled = false;
            lstProject.DataSource = DM.dsABCTestProject;
            lstProject.DisplayMember = "Project.ProjectName";
            lstProject.ValueMember = "Project.ProjectName";
            currencyManager = (CurrencyManager)this.BindingContext[DM.dsABCTestProject, "Project"];
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
            pnlAddProject.Hide();
            lstProject.Visible = true;
            btnReturn.Enabled = true;
            btnDeleteProject.Enabled = true;
            btnNext.Enabled = true;
            btnPrevious.Enabled = true;
            btnUpdateProject.Enabled = true;
        }

        private void btnSaveProject_Click(object sender, EventArgs e)
        {
            DataRow newProjectRow = DM.dtProject.NewRow();

            if ((txtAddProjectName.Text == "") || (txtAddProjectAbb.Text == ""))
            {
                MessageBox.Show("You must type in a Project Name, Project Abb.", "Error");
            }
            else
            {
                newProjectRow["ProjectName"] = txtAddProjectName.Text;
                newProjectRow["ProjectAbb"] = txtAddProjectAbb.Text;
                newProjectRow["DateStart"] = dtpAddDateStart.Text;
                newProjectRow["DateEnd"] = dtpAddDateEnd.Text;
                newProjectRow["Description"] = txtAddDescription.Text;
                DM.dtProject.Rows.Add(newProjectRow);
                MessageBox.Show("Project added successfully.", "Success");
                DM.UpdateProject();
                pnlAddProject.Hide();
                lstProject.Visible = true;
                btnReturn.Enabled = true;
                btnDeleteProject.Enabled = true;
                btnNext.Enabled = true;
                btnPrevious.Enabled = true;
                btnUpdateProject.Enabled = true;
            }
        }

        private void btnAddProject_Click(object sender, EventArgs e)
        {
            lstProject.Visible = false;
            btnDeleteProject.Enabled = false;
            btnNext.Enabled = false;
            btnPrevious.Enabled = false;
            btnReturn.Enabled = false;
            btnUpdateProject.Enabled = false;
            pnlAddProject.Show();
        }

        private void btnCancel2_Click(object sender, EventArgs e)
        {
            pnlUpdateProject.Hide();
            lstProject.Visible = true;
            btnReturn.Enabled = true;
            btnDeleteProject.Enabled = true;
            btnNext.Enabled = true;
            btnPrevious.Enabled = true;
            btnAddProject.Enabled = true;
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            DataRow updateProjectRow = DM.dtProject.Rows[currencyManager.Position];

            updateProjectRow["DateStart"] = dtpUpdateDateStart.Text;
            updateProjectRow["DateEnd"] = dtpUpdateDateEnd.Text;
            updateProjectRow["Description"] = txtUpdateDescription.Text;
            currencyManager.EndCurrentEdit();
            DM.UpdateProject();
            MessageBox.Show("Project updated successfully.", "Success");
            pnlUpdateProject.Hide();
            lstProject.Visible = true;
            btnReturn.Enabled = true;
            btnDeleteProject.Enabled = true;
            btnNext.Enabled = true;
            btnPrevious.Enabled = true;
            btnAddProject.Enabled = true;
        }

        private void btnUpdateProject_Click(object sender, EventArgs e)
        {
            lstProject.Visible = false;
            btnDeleteProject.Enabled = false;
            btnNext.Enabled = false;
            btnPrevious.Enabled = false;
            btnReturn.Enabled = false;
            btnAddProject.Enabled = false;
            pnlUpdateProject.Show();
        }

        private void btnDeleteProject_Click(object sender, EventArgs e)
        {
            DataRow deleteProjectRow = DM.dtProject.Rows[currencyManager.Position];
            double useCaseCount = 0;

            foreach (DataRow drUseCase in DM.dtUseCase.Rows)
            {
                string projectID = drUseCase["ProjectID"].ToString();
                if (projectID.Equals(txtProjectID.Text) == true)
                {
                    useCaseCount += 1;
                }
            }
            if (useCaseCount == 0)
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "warning", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    deleteProjectRow.Delete();
                    DM.UpdateProject();
                    MessageBox.Show("Project deleted successfully.", "Success");
                }
            }
            else
            {
                MessageBox.Show("You may only delete a Project that has no use case.", "Error");
            }
        }
    }
}
