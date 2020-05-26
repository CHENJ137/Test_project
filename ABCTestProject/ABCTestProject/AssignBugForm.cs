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
    public partial class AssignBugForm : Form
    {
        private DataModule DM;
        private MainForm frmMenu;
        private CurrencyManager cmEmployee;
        private CurrencyManager cmBug;
        private CurrencyManager cmAssignedBug;

        public AssignBugForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
            BindControls();
            cmEmployee = (CurrencyManager)this.BindingContext[DM.dsABCTestProject, "Employee"];
            cmBug = (CurrencyManager)this.BindingContext[DM.dsABCTestProject, "Bug"];
            cmAssignedBug = (CurrencyManager)this.BindingContext[DM.dsABCTestProject, "Employee.Employee_Bug"];
        }

        private void BindControls()
        {
            txtFirstName.Enabled = false;
            txtLastName.Enabled = false;
            txtBugAbb.Enabled = false;

            dgvEmplyee.DataSource = DM.dsABCTestProject;
            dgvEmplyee.DataMember = "Employee";

            dgvEmplyee.Columns["EmployeeID"].Width = 40;
            dgvEmplyee.Columns["FirstName"].Width = 70;
            dgvEmplyee.Columns["LastName"].Width = 70;
            dgvEmplyee.Columns["JobTitle"].Width = 70;
            dgvEmplyee.Columns["Ext"].Width = 40;

            dgvAssignedBug.DataSource = DM.dsABCTestProject;
            dgvAssignedBug.DataMember = "Employee.Employee_Bug";

            dgvAssignedBug.Columns["BugID"].Width = 40;
            dgvAssignedBug.Columns["TestID"].Width = 40;
            dgvAssignedBug.Columns["Status"].Width = 40;
            dgvAssignedBug.Columns["Assigned"].Width = 60;
            dgvAssignedBug.Columns["EmployeeID"].Width = 40;
            dgvAssignedBug.Columns["SeverityID"].Width = 40;
            dgvAssignedBug.Columns["PriorityID"].Width = 40;
            dgvAssignedBug.Columns["Rating"].Width = 40;
            dgvAssignedBug.Columns["DateDetected"].Width = 70;
            dgvAssignedBug.Columns["DateFinished"].Width = 70;
            dgvAssignedBug.Columns["ActualDate"].Width = 70;


            DataView dv;
            dv = new DataView(DM.dsABCTestProject.Bug, "EmployeeID is null", "BugID Asc", DataViewRowState.CurrentRows);
            dgvBug.DataSource = dv;

            this.dgvBug.Columns[4].Visible = false;
            this.dgvBug.Columns["ActualDate"].Visible = false;
            dgvBug.Columns["Assigned"].Width = 80;
            dgvBug.Columns["BugID"].Width = 40;
            dgvBug.Columns["TestID"].Width = 40;
            dgvBug.Columns["Status"].Width = 40;
            dgvBug.Columns["SeverityID"].Width = 40;
            dgvBug.Columns["PriorityID"].Width = 40;
            dgvBug.Columns["Rating"].Width = 40;
            dgvBug.Columns["DateDetected"].Width = 70;
            dgvBug.Columns["DateFinished"].Width = 70;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SetName()
        {
            if (cmEmployee != null)
            {
                DataRow currentEmployeeRow = DM.dtEmployee.Rows[cmEmployee.Position];
                txtLastName.Text = currentEmployeeRow["LastName"].ToString();
                txtFirstName.Text = currentEmployeeRow["FirstName"].ToString();
            }

            if (dgvAssignedBug.CurrentRow != null)
            {
                DataRow currentAssignedBugRow = DM.dtBug.Rows[cmAssignedBug.Position];
                txtBugAbb.Text = currentAssignedBugRow["BugAbb"].ToString();
            }
        }

        private void dgvEmplyee_SelectionChanged(object sender, EventArgs e)
        {
            if (cmEmployee != null)
            {
                DataRow currentEmployeeRow = DM.dtEmployee.Rows[cmEmployee.Position];
                txtLastName.Text = currentEmployeeRow["LastName"].ToString();
                txtFirstName.Text = currentEmployeeRow["FirstName"].ToString();
            }
        }

        private void dgvAssignedBug_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvAssignedBug.CurrentRow != null)
            {
                DataRow currentAssignedBugRow = DM.dtBug.Rows[cmAssignedBug.Position];
                txtBugAbb.Text = currentAssignedBugRow["BugAbb"].ToString();
            }
        }

        private void dgvBug_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvBug.CurrentRow != null)
            {
                DataRow currentBugRow = DM.dtBug.Rows[cmBug.Position];
                txtBugAbb.Text = currentBugRow["BugAbb"].ToString();
            }
        }
    }
}
