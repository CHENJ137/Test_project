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
    public partial class PriorityForm : Form
    {
        private DataModule DM;
        private MainForm frmMenu;
        private CurrencyManager currencyManager;

        public PriorityForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
            BindControls();
            pnlAddPriority.Left = 155;
            pnlAddPriority.Top = 30;
            pnlUpdateP.Left = 155;
            pnlUpdateP.Top = 30;
        }

        private void BindControls()
        {
            txtPriorityID.DataBindings.Add("Text", DM.dsABCTestProject, "Priority.PriorityID");
            txtPriority.DataBindings.Add("Text", DM.dsABCTestProject, "Priority.Priority");
            txtDescription.DataBindings.Add("Text", DM.dsABCTestProject, "Priority.Description");
            txtUpdatePID.DataBindings.Add("Text", DM.dsABCTestProject, "Priority.PriorityID");
            txtUpdateP.DataBindings.Add("Text", DM.dsABCTestProject, "Priority.Priority");
            txtUpdateD.DataBindings.Add("Text", DM.dsABCTestProject, "Priority.Description");
            txtPriorityID.Enabled = false;
            txtPriority.Enabled = false;
            txtDescription.Enabled = false;
            txtUpdatePID.Enabled = false;
            txtUpdateP.Enabled = false;
            lstPriority.DataSource = DM.dsABCTestProject;
            lstPriority.DisplayMember = "Priority.PriorityID";
            lstPriority.ValueMember= "Priority.PriorityID";
            currencyManager = (CurrencyManager)this.BindingContext[DM.dsABCTestProject, "Priority"];
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
            pnlAddPriority.Hide();
            lstPriority.Visible = true;
            btnReturn.Enabled = true;
            btnDeletePriority.Enabled = true;
            btnNext.Enabled = true;
            btnPrevious.Enabled = true;
            btnUpdatePriority.Enabled = true;
        }

        private void btnSaveP_Click(object sender, EventArgs e)
        {
            DataRow newPriorityRow = DM.dtPriority.NewRow();

            if ((txtAddP.Text == "") || (txtAddD.Text == ""))
            {
                MessageBox.Show("You must type in a priority, priority ID and description.", "Error");
            }
            else
            {
                newPriorityRow["PriorityID"] = cboAddPID.Text;
                newPriorityRow["Priority"] = txtAddP.Text;
                newPriorityRow["Description"] = txtAddD.Text;
                DM.dtPriority.Rows.Add(newPriorityRow);
                MessageBox.Show("Priority added successfully.", "Success");
                DM.UpdatePriority();
                pnlAddPriority.Hide();
                lstPriority.Visible = true;
                btnReturn.Enabled = true;
                btnDeletePriority.Enabled = true;
                btnNext.Enabled = true;
                btnPrevious.Enabled = true;
                btnUpdatePriority.Enabled = true;
            }
        }

        private void btnAddPriority_Click(object sender, EventArgs e)
        {
            lstPriority.Visible = false;
            btnDeletePriority.Enabled = false;
            btnNext.Enabled = false;
            btnPrevious.Enabled = false;
            btnReturn.Enabled = false;
            btnUpdatePriority.Enabled = false;
            pnlAddPriority.Show();
        }

        private void btnCancel2_Click(object sender, EventArgs e)
        {
            pnlUpdateP.Hide();
            lstPriority.Visible = true;
            btnReturn.Enabled = true;
            btnDeletePriority.Enabled = true;
            btnNext.Enabled = true;
            btnPrevious.Enabled = true;
            btnAddPriority.Enabled = true;
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            DataRow updatePriorityRow = DM.dtPriority.Rows[currencyManager.Position];

            if ((txtUpdateD.Text == ""))
            {
                MessageBox.Show("You must type in a description.", "Error");
            }
            else
            {
                updatePriorityRow["Description"] = txtUpdateD.Text;
                currencyManager.EndCurrentEdit();
                DM.UpdatePriority();
                MessageBox.Show("Priority updated successfully.", "Success");
                pnlUpdateP.Hide();
                lstPriority.Visible = true;
                btnReturn.Enabled = true;
                btnDeletePriority.Enabled = true;
                btnNext.Enabled = true;
                btnPrevious.Enabled = true;
                btnAddPriority.Enabled = true;
            }
        }

        private void btnUpdatePriority_Click(object sender, EventArgs e)
        {
            lstPriority.Visible = false;
            btnDeletePriority.Enabled = false;
            btnNext.Enabled = false;
            btnPrevious.Enabled = false;
            btnReturn.Enabled = false;
            btnAddPriority.Enabled = false;
            pnlUpdateP.Show();
        }

        private void btnDeletePriority_Click(object sender, EventArgs e)
        {
            DataRow deletePriorityRow = DM.dtPriority.Rows[currencyManager.Position];
            double priorityCount = 0;

            foreach (DataRow drBug in DM.dtBug.Rows)
            {
                string priorityID = drBug["PriorityID"].ToString();
                if (priorityID.Equals(txtPriorityID.Text) == true)
                {
                    priorityCount += 1;
                }
            }

            if (priorityCount == 0)
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "warning", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    deletePriorityRow.Delete();
                    DM.UpdatePriority();
                    MessageBox.Show("Priority deleted successfully.", "Success");
                }
            }
            else
            {
                MessageBox.Show("You can not delete this priority.", "Error");
            }
        }
    }
}
