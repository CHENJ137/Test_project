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
    public partial class MainForm : Form
    {
        private DataModule DM;
        private ProjectForm frmProject;
        private UseCaseForm frmUseCase;
        private TestCaseForm frmTestCase;
        private TestForm frmTest;
        private BugForm frmBug;
        private ConfigureForm frmConfigure;
        private EmployeeForm frmEmployee;
        private PriorityForm frmPriority;
        private SeverityForm frmSeverity;
        private AssignBugForm frmAssignBug;
        private ChartForm frmChart;
        private ReportForm frmReport;

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnProject_Click(object sender, EventArgs e)
        {
            if (frmProject == null)
            {
                frmProject = new ProjectForm(DM, this);
            }
            frmProject.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DM = new DataModule();
        }

        private void btnUseCase_Click(object sender, EventArgs e)
        {
            if (frmUseCase == null)
            {
                frmUseCase = new UseCaseForm(DM, this);
            }
            frmUseCase.ShowDialog();
        }

        private void btnTestCase_Click(object sender, EventArgs e)
        {
            if (frmTestCase == null)
            {
                frmTestCase = new TestCaseForm(DM, this);
            }
            frmTestCase.ShowDialog();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            if (frmTest == null)
            {
                frmTest = new TestForm(DM, this);
            }
            frmTest.ShowDialog();
        }

        private void btnBug_Click(object sender, EventArgs e)
        {
            if (frmBug == null)
            {
                frmBug = new BugForm(DM, this);
            }
            frmBug.ShowDialog();
        }

        private void btnConfigure_Click(object sender, EventArgs e)
        {
            if (frmConfigure == null)
            {
                frmConfigure = new ConfigureForm(DM, this);
            }
            frmConfigure.ShowDialog();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            if (frmEmployee == null)
            {
                frmEmployee = new EmployeeForm(DM, this);
            }
            frmEmployee.ShowDialog();
        }

        private void btnPriority_Click(object sender, EventArgs e)
        {
            if (frmPriority == null)
            {
                frmPriority = new PriorityForm(DM, this);
            }
            frmPriority.ShowDialog();
        }

        private void btnSeverity_Click(object sender, EventArgs e)
        {
            if (frmSeverity == null)
            {
                frmSeverity = new SeverityForm(DM, this);
            }
            frmSeverity.ShowDialog();
        }

        private void btnAssignBug_Click(object sender, EventArgs e)
        {
            if (frmAssignBug == null)
            {
                frmAssignBug = new AssignBugForm(DM, this);
            }
            frmAssignBug.ShowDialog();
        }

        private void btnCharts_Click(object sender, EventArgs e)
        {
            if (frmChart == null)
            {
                frmChart = new ChartForm(DM, this);
            }
            frmChart.ShowDialog();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            if (frmReport == null)
            {
                frmReport = new ReportForm(DM, this);
            }
            frmReport.ShowDialog();
        }
    }
}
