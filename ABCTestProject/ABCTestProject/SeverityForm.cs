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
    public partial class SeverityForm : Form
    {
        private DataModule DM;
        private MainForm frmMenu;
        private CurrencyManager currencyManager;

        public SeverityForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
            BindControls();
            pnlAddS.Left = 150;
            pnlAddS.Top = 32;
            pnlUpdateS.Left = 150;
            pnlUpdateS.Top = 32;
        }

        private void BindControls()
        {
            txtSeverityID.DataBindings.Add("Text", DM.dsABCTestProject, "Severity.SeverityID");
            txtSeverity.DataBindings.Add("Text", DM.dsABCTestProject, "Severity.Severity");
            txtDescription.DataBindings.Add("Text", DM.dsABCTestProject, "Severity.Description");
            txtUpdateSID.DataBindings.Add("Text", DM.dsABCTestProject, "Severity.SeverityID");
            txtUpdateS.DataBindings.Add("Text", DM.dsABCTestProject, "Severity.Severity");
            txtUpdateD.DataBindings.Add("Text", DM.dsABCTestProject, "Severity.Description");
            txtSeverityID.Enabled = false;
            txtSeverity.Enabled = false;
            txtDescription.Enabled = false;
            txtUpdateSID.Enabled = false;
            txtUpdateS.Enabled = false;
            lstSeverity.DataSource = DM.dsABCTestProject;
            lstSeverity.DisplayMember = "Severity.SeverityID";
            lstSeverity.ValueMember = "Severity.SeverityID";
            currencyManager = (CurrencyManager)this.BindingContext[DM.dsABCTestProject, "Severity"];
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
            pnlAddS.Hide();
            lstSeverity.Visible = true;
            btnReturn.Enabled = true;
            btnDeleteSeverity.Enabled = true;
            btnNext.Enabled = true;
            btnPrevious.Enabled = true;
            btnUpdateSeverity.Enabled = true;
        }

        private void btnSaveS_Click(object sender, EventArgs e)
        {
            DataRow newSeverityRow = DM.dtSeverity.NewRow();

            if ((txtAddS.Text == "") || (txtAddD.Text == ""))
            {
                MessageBox.Show("You must type in a severity, severity ID and description.", "Error");
            }
            else
            {
                newSeverityRow["SeverityID"] = cboAddSID.Text;
                newSeverityRow["Severity"] = txtAddS.Text;
                newSeverityRow["Description"] = txtAddD.Text;
                DM.dtSeverity.Rows.Add(newSeverityRow);
                MessageBox.Show("Severity added successfully.", "Success");
                DM.UpdateSeverity();
                pnlAddS.Hide();
                lstSeverity.Visible = true;
                btnReturn.Enabled = true;
                btnDeleteSeverity.Enabled = true;
                btnNext.Enabled = true;
                btnPrevious.Enabled = true;
                btnUpdateSeverity.Enabled = true;
            }
        }

        private void btnAddSeverity_Click(object sender, EventArgs e)
        {
            lstSeverity.Visible = false;
            btnDeleteSeverity.Enabled = false;
            btnNext.Enabled = false;
            btnPrevious.Enabled = false;
            btnReturn.Enabled = false;
            btnUpdateSeverity.Enabled = false;
            pnlAddS.Show();
        }

        private void btnCancel2_Click(object sender, EventArgs e)
        {
            pnlUpdateS.Hide();
            lstSeverity.Visible = true;
            btnReturn.Enabled = true;
            btnDeleteSeverity.Enabled = true;
            btnNext.Enabled = true;
            btnPrevious.Enabled = true;
            btnUpdateSeverity.Enabled = true;
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            DataRow updateSeverityRow = DM.dtSeverity.Rows[currencyManager.Position];

            if ((txtUpdateD.Text == ""))
            {
                MessageBox.Show("You must type in a description.", "Error");
            }
            else
            {
                updateSeverityRow["Description"] = txtUpdateD.Text;
                currencyManager.EndCurrentEdit();
                DM.UpdateSeverity();
                MessageBox.Show("Severity updated successfully.", "Success");
                pnlUpdateS.Hide();
                lstSeverity.Visible = true;
                btnReturn.Enabled = true;
                btnDeleteSeverity.Enabled = true;
                btnNext.Enabled = true;
                btnPrevious.Enabled = true;
                btnUpdateSeverity.Enabled = true;
            }
        }

        private void btnUpdateSeverity_Click(object sender, EventArgs e)
        {
            lstSeverity.Visible = false;
            btnDeleteSeverity.Enabled = false;
            btnNext.Enabled = false;
            btnPrevious.Enabled = false;
            btnReturn.Enabled = false;
            btnAddSeverity.Enabled = false;
            pnlUpdateS.Show();
        }

        private void btnDeleteSeverity_Click(object sender, EventArgs e)
        {
            DataRow deleteSeverityRow = DM.dtSeverity.Rows[currencyManager.Position];
            double severityCount = 0;

            foreach (DataRow drBug in DM.dtBug.Rows)
            {
                string severityID = drBug["SeverityID"].ToString();
                if (severityID.Equals(txtSeverityID.Text) == true)
                {
                    severityCount += 1;
                }
            }

            if (severityCount == 0)
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "warning", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    deleteSeverityRow.Delete();
                    DM.UpdateSeverity();
                    MessageBox.Show("Severity deleted successfully.", "Success");
                }
            }
            else
            {
                MessageBox.Show("You can not delete this severity.", "Error");
            }
        }
    }
}
