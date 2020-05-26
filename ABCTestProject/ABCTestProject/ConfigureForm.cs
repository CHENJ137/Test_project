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
    public partial class ConfigureForm : Form
    {
        private DataModule DM;
        private MainForm frmMenu;
        private CurrencyManager currencyManager;

        public ConfigureForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
            BindControls();
            pnlAddConfigure.Left = 133;
            pnlAddConfigure.Top = 25;
            pnlUpdateConfigure.Left = 133;
            pnlUpdateConfigure.Top = 25;
        }

        private void BindControls()
        {
            txtConfigureID.DataBindings.Add("Text", DM.dsABCTestProject, "Configure.ConfigureID");
            txtHardware.DataBindings.Add("Text", DM.dsABCTestProject, "Configure.HardwareName");
            txtSystem.DataBindings.Add("Text", DM.dsABCTestProject, "Configure.OperatingSystem");
            txtOptions.DataBindings.Add("Text", DM.dsABCTestProject, "Configure.Options");
            txtDescription.DataBindings.Add("Text", DM.dsABCTestProject, "Configure.Description");
            txtUpdateHardware.DataBindings.Add("Text", DM.dsABCTestProject, "Configure.HardwareName");
            txtUpdateSystem.DataBindings.Add("Text", DM.dsABCTestProject, "Configure.OperatingSystem");
            txtUpdateOptions.DataBindings.Add("Text", DM.dsABCTestProject, "Configure.Options");
            txtUpdateDescription.DataBindings.Add("Text", DM.dsABCTestProject, "Configure.Description");
            txtConfigureID.Enabled = false;
            txtHardware.Enabled = false;
            txtSystem.Enabled = false;
            txtOptions.Enabled = false;
            txtDescription.Enabled = false;
            txtUpdateHardware.Enabled = false;
            txtUpdateSystem.Enabled = false;
            lstConfigure.DataSource = DM.dsABCTestProject;
            lstConfigure.DisplayMember = "Configure.ConfigureID";
            lstConfigure.ValueMember = "Configure.ConfigureID";
            currencyManager = (CurrencyManager)this.BindingContext[DM.dsABCTestProject, "Configure"];
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
            pnlAddConfigure.Hide();
            lstConfigure.Visible = true;
            btnReturn.Enabled = true;
            btnDeleteConfigure.Enabled = true;
            btnNext.Enabled = true;
            btnPrevious.Enabled = true;
            btnUpdateConfigure.Enabled = true;
        }

        private void btnSaveConfigure_Click(object sender, EventArgs e)
        {
            DataRow newConfigureRow = DM.dtConfigure.NewRow();

            if ((txtAddDescription.Text == "") || (txtHardware.Text == "") || (txtAddSystem.Text == ""))
            {
                MessageBox.Show("You must type in a hardware name, operating system and description.", "Error");
            }
            else
            {
                newConfigureRow["HardwareName"] = txtAddHardware.Text;
                newConfigureRow["OperatingSystem"] = txtAddSystem.Text;
                newConfigureRow["Options"] = txtAddOptions.Text;
                newConfigureRow["Description"] = txtAddDescription.Text;
                DM.dtConfigure.Rows.Add(newConfigureRow);
                MessageBox.Show("Configure added successfully.", "Success");
                DM.UpdateConfigure();
                pnlAddConfigure.Hide();
                lstConfigure.Visible = true;
                btnReturn.Enabled = true;
                btnDeleteConfigure.Enabled = true;
                btnNext.Enabled = true;
                btnPrevious.Enabled = true;
                btnUpdateConfigure.Enabled = true;
            }
        }

        private void btnAddConfigure_Click(object sender, EventArgs e)
        {
            lstConfigure.Visible = false;
            btnDeleteConfigure.Enabled = false;
            btnNext.Enabled = false;
            btnPrevious.Enabled = false;
            btnReturn.Enabled = false;
            btnUpdateConfigure.Enabled = false;
            pnlAddConfigure.Show();
        }

        private void btnCancel2_Click(object sender, EventArgs e)
        {
            pnlUpdateConfigure.Hide();
            lstConfigure.Visible = true;
            btnReturn.Enabled = true;
            btnDeleteConfigure.Enabled = true;
            btnNext.Enabled = true;
            btnPrevious.Enabled = true;
            btnAddConfigure.Enabled = true;
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            DataRow updateConfigureRow = DM.dtConfigure.Rows[currencyManager.Position];

            if ((txtUpdateDescription.Text == ""))
            {
                MessageBox.Show("You must type in a description.", "Error");
            }
            else
            {
                updateConfigureRow["Options"] = txtUpdateOptions.Text;
                updateConfigureRow["Description"] = txtUpdateDescription.Text;
                currencyManager.EndCurrentEdit();
                DM.UpdateConfigure();
                MessageBox.Show("Configure updated successfully.", "Success");
                pnlUpdateConfigure.Hide();
                lstConfigure.Visible = true;
                btnReturn.Enabled = true;
                btnDeleteConfigure.Enabled = true;
                btnNext.Enabled = true;
                btnPrevious.Enabled = true;
                btnAddConfigure.Enabled = true;
            }
        }

        private void btnUpdateConfigure_Click(object sender, EventArgs e)
        {
            lstConfigure.Visible = false;
            btnDeleteConfigure.Enabled = false;
            btnNext.Enabled = false;
            btnPrevious.Enabled = false;
            btnReturn.Enabled = false;
            btnAddConfigure.Enabled = false;
            pnlUpdateConfigure.Show();
        }

        private void btnDeleteConfigure_Click(object sender, EventArgs e)
        {
            DataRow deleteConfigureRow = DM.dtConfigure.Rows[currencyManager.Position];
            double configureCount = 0;

            foreach (DataRow drTest in DM.dtTest.Rows)
            {
                string ConfigureID = drTest["ConfigureID"].ToString();
                if (ConfigureID.Equals(txtConfigureID.Text) == true)
                {
                    configureCount += 1;
                }
            }
            if (configureCount == 0)
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "warning", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    deleteConfigureRow.Delete();
                    DM.UpdateConfigure();
                    MessageBox.Show("Configure deleted successfully.", "Success");
                }
            }
            else
            {
                MessageBox.Show("You may only delete a Configure that is not in any test.", "Error");
            }
        }
    }
}
