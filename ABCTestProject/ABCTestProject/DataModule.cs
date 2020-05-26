using System.Data.OleDb;
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
    public partial class DataModule : Form
    {
        public DataTable dtProject;
        public DataTable dtUseCase;
        public DataTable dtTestCase;
        public DataTable dtTest;
        public DataTable dtBug;
        public DataTable dtEmployee;
        public DataTable dtConfigure;
        public DataTable dtCategory;
        public DataTable dtPriority;
        public DataTable dtSeverity;

        public DataView projectView;
        public DataView useCaseView;
        public DataView testCaseView;
        public DataView testView;
        public DataView bugView;
        public DataView employeeView;
        public DataView configureView;
        public DataView categoryView;
        public DataView priorityView;
        public DataView severityView;

        public DataModule()
        {
            InitializeComponent();
            dsABCTestProject.EnforceConstraints = false;

            daProject.Fill(dsABCTestProject);
            daUseCase.Fill(dsABCTestProject);
            daTestCase.Fill(dsABCTestProject);
            daTest.Fill(dsABCTestProject);
            daBug.Fill(dsABCTestProject);
            daEmployee.Fill(dsABCTestProject);
            daConfigure.Fill(dsABCTestProject);
            daCategory.Fill(dsABCTestProject);
            daPriority.Fill(dsABCTestProject);
            daSeverity.Fill(dsABCTestProject);
            dtProject = dsABCTestProject.Tables["Project"];
            dtUseCase = dsABCTestProject.Tables["UseCase"];
            dtTestCase = dsABCTestProject.Tables["TestCase"];
            dtTest = dsABCTestProject.Tables["Test"];
            dtBug = dsABCTestProject.Tables["Bug"];
            dtEmployee = dsABCTestProject.Tables["Employee"];
            dtConfigure = dsABCTestProject.Tables["Configure"];
            dtCategory = dsABCTestProject.Tables["Category"];
            dtPriority = dsABCTestProject.Tables["Priority"];
            dtSeverity = dsABCTestProject.Tables["Severity"];

            projectView = new DataView(dtProject);
            projectView.Sort = "ProjectID";
            useCaseView = new DataView(dtUseCase);
            useCaseView.Sort = "UseCaseID";
            testCaseView = new DataView(dtTestCase);
            testCaseView.Sort = "TestCaseID";
            testView = new DataView(dtTest);
            testView.Sort = "TestID";
            bugView = new DataView(dtBug);
            bugView.Sort = "BugID";
            employeeView = new DataView(dtEmployee);
            employeeView.Sort = "EmployeeID";
            configureView = new DataView(dtConfigure);
            configureView.Sort = "ConfigureID";
            categoryView = new DataView(dtCategory);
            categoryView.Sort = "CategoryID";
            priorityView = new DataView(dtPriority);
            priorityView.Sort = "PriorityID";
            severityView = new DataView(dtSeverity);
            severityView.Sort = "SeverityID";

            dsABCTestProject.EnforceConstraints = true;
        }

        public void UpdateProject()
        {
            daProject.Update(dtProject);
        }

        private void daProject_RowUpdated(object sender, OleDbRowUpdatedEventArgs e)
        {
            int newID = 0;
            OleDbCommand idCMD = new OleDbCommand("SELECT @@IDENTITY", ctnABCTestProject);
            if (e.StatementType == StatementType.Insert)
            {
                newID = (int)idCMD.ExecuteScalar();
                e.Row["ProjectID"] = newID;
            }
        }

        public void UpdateUseCase()
        {
            daUseCase.Update(dtUseCase);
        }

        private void daUseCase_RowUpdated(object sender, OleDbRowUpdatedEventArgs e)
        {
            int newID = 0;
            OleDbCommand idCMD = new OleDbCommand("SELECT @@IDENTITY", ctnABCTestProject);
            if (e.StatementType == StatementType.Insert)
            {
                newID = (int)idCMD.ExecuteScalar();
                e.Row["UseCaseID"] = newID;
            }
        }

        public void UpdateTestCase()
        {
            daTestCase.Update(dtTestCase);
        }

        private void daTestCase_RowUpdated(object sender, OleDbRowUpdatedEventArgs e)
        {
            int newID = 0;
            OleDbCommand idCMD = new OleDbCommand("SELECT @@IDENTITY", ctnABCTestProject);
            if (e.StatementType == StatementType.Insert)
            {
                newID = (int)idCMD.ExecuteScalar();
                e.Row["TestCaseID"] = newID;
            }
        }

        public void UpdateTest()
        {
            daTest.Update(dtTest);
        }

        private void daTest_RowUpdated(object sender, OleDbRowUpdatedEventArgs e)
        {
            int newID = 0;
            OleDbCommand idCMD = new OleDbCommand("SELECT @@IDENTITY", ctnABCTestProject);
            if (e.StatementType == StatementType.Insert)
            {
                newID = (int)idCMD.ExecuteScalar();
                e.Row["TestID"] = newID;
            }
        }

        public void UpdateBug()
        {
            daBug.Update(dtBug);
        }

        private void daBug_RowUpdated(object sender, OleDbRowUpdatedEventArgs e)
        {
            int newID = 0;
            OleDbCommand idCMD = new OleDbCommand("SELECT @@IDENTITY", ctnABCTestProject);
            if (e.StatementType == StatementType.Insert)
            {
                newID = (int)idCMD.ExecuteScalar();
                e.Row["BugID"] = newID;
            }
        }

        public void UpdateConfigure()
        {
            daConfigure.Update(dtConfigure);
        }

        private void daConfigure_RowUpdated(object sender, OleDbRowUpdatedEventArgs e)
        {
            int newID = 0;
            OleDbCommand idCMD = new OleDbCommand("SELECT @@IDENTITY", ctnABCTestProject);
            if (e.StatementType == StatementType.Insert)
            {
                newID = (int)idCMD.ExecuteScalar();
                e.Row["ConfigureID"] = newID;
            }
        }

        public void UpdateEmployee()
        {
            daEmployee.Update(dtEmployee);
        }

        private void daEmployee_RowUpdated(object sender, OleDbRowUpdatedEventArgs e)
        {
            int newID = 0;
            OleDbCommand idCMD = new OleDbCommand("SELECT @@IDENTITY", ctnABCTestProject);
            if (e.StatementType == StatementType.Insert)
            {
                newID = (int)idCMD.ExecuteScalar();
                e.Row["EmployeeID"] = newID;
            }
        }

        public void UpdatePriority()
        {
            daPriority.Update(dtPriority);
        }

        private void daPriority_RowUpdated(object sender, OleDbRowUpdatedEventArgs e)
        {
            int newID = 0;
            OleDbCommand idCMD = new OleDbCommand("SELECT @@IDENTITY", ctnABCTestProject);
            if (e.StatementType == StatementType.Insert)
            {
                newID = (int)idCMD.ExecuteScalar();
                e.Row["PriorityID"] = newID;
            }
        }

        public void UpdateSeverity()
        {
            daSeverity.Update(dtSeverity);
        }

        private void daSeverity_RowUpdated(object sender, OleDbRowUpdatedEventArgs e)
        {
            int newID = 0;
            OleDbCommand idCMD = new OleDbCommand("SELECT @@IDENTITY", ctnABCTestProject);
            if (e.StatementType == StatementType.Insert)
            {
                newID = (int)idCMD.ExecuteScalar();
                e.Row["SeverityID"] = newID;
            }
        }
    }
}
