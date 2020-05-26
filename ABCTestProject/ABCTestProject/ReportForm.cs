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
    public partial class ReportForm : Form
    {
        private DataModule DM;
        private MainForm frmMenu;
        CurrencyManager cmProject;
        CurrencyManager cmUseCase;
        CurrencyManager cmTestCase;
        CurrencyManager cmTest;
        CurrencyManager cmEmployee;
        CurrencyManager cmBug;
        CurrencyManager cmPriority;
        CurrencyManager cmSeverity;

        public ReportForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
            cmTest = (CurrencyManager)this.BindingContext[DM.dsABCTestProject, "Test"];
            cmEmployee = (CurrencyManager)this.BindingContext[DM.dsABCTestProject, "Employee"];
            cmPriority = (CurrencyManager)this.BindingContext[DM.dsABCTestProject, "Priority"];
            cmSeverity = (CurrencyManager)this.BindingContext[DM.dsABCTestProject, "Severity"];
            cmUseCase = (CurrencyManager)this.BindingContext[DM.dsABCTestProject, "UseCase"];
            cmTestCase = (CurrencyManager)this.BindingContext[DM.dsABCTestProject, "TestCase"];
            cmProject = (CurrencyManager)this.BindingContext[DM.dsABCTestProject, "Project"];
            cmBug = (CurrencyManager)this.BindingContext[DM.dsABCTestProject, "Bug"];
        }

        private void btnBugRating_Click(object sender, EventArgs e)
        {
            string BugRatingb = "";
            string BugRatings = "";
            string BugRating15b = "";
            string BugRating12b = "";
            string BugRating10b = "";
            string BugRating9b = "";
            string BugRating8b = "";
            string BugRating6b = "";
            string BugRating5b = "";
            string BugRating4b = "";
            string BugRating3b = "";
            string BugRating2b = "";
            string BugRating1b = "";
            string BugRating15s = "";
            string BugRating12s = "";
            string BugRating10s = "";
            string BugRating9s = "";
            string BugRating8s = "";
            string BugRating6s = "";
            string BugRating5s = "";
            string BugRating4s = "";
            string BugRating3s = "";
            string BugRating2s = "";
            string BugRating1s = "";
            string ProjectBB = "Project Name: Book Brokers" + "\r\n";
            string ProjectSK = "\r\n" + "\r\n" + "\r\n" + "Project Name: Skykiwi" + "\r\n";
            string Rating15 = "\r\n" + "\r\n" + "Bug Rating: 15" + "\r\n";
            string Rating12 = "\r\n" + "\r\n" + "Bug Rating: 12" + "\r\n";
            string Rating10 = "\r\n" + "\r\n" + "Bug Rating: 10" + "\r\n";
            string Rating9 = "\r\n" + "\r\n" + "Bug Rating: 9" + "\r\n";
            string Rating8 = "\r\n" + "\r\n" + "Bug Rating: 8" + "\r\n";
            string Rating6 = "\r\n" + "\r\n" + "Bug Rating: 6" + "\r\n";
            string Rating5 = "\r\n" + "\r\n" + "Bug Rating: 5" + "\r\n";
            string Rating4 = "\r\n" + "\r\n" + "Bug Rating: 4" + "\r\n";
            string Rating3 = "\r\n" + "\r\n" + "Bug Rating: 3" + "\r\n";
            string Rating2 = "\r\n" + "\r\n" + "Bug Rating: 2" + "\r\n";
            string Rating1 = "\r\n" + "\r\n" + "Bug Rating: 1" + "\r\n";
            string Title = "Severity" + "         " + "Priority" + "         " + "Bug ID" + "\r\n";
            double bugTotalb = 0;
            string bug15tb = "";
            string bug12tb = "";
            string bug10tb = "";
            string bug9tb = "";
            string bug8tb = "";
            string bug6tb = "";
            string bug5tb = "";
            string bug4tb = "";
            string bug3tb = "";
            string bug2tb = "";
            string bug1tb = "";
            string bugTotaltb = "";
            double bug15b = 0;
            double bug12b = 0;
            double bug10b = 0;
            double bug9b = 0;
            double bug8b = 0;
            double bug6b = 0;
            double bug5b = 0;
            double bug4b = 0;
            double bug3b = 0;
            double bug2b = 0;
            double bug1b = 0;
            double bugTotals = 0;
            string bug15ts = "";
            string bug12ts = "";
            string bug10ts = "";
            string bug9ts = "";
            string bug8ts = "";
            string bug6ts = "";
            string bug5ts = "";
            string bug4ts = "";
            string bug3ts = "";
            string bug2ts = "";
            string bug1ts = "";
            string bugTotalts = "";
            double bug15s = 0;
            double bug12s = 0;
            double bug10s = 0;
            double bug9s = 0;
            double bug8s = 0;
            double bug6s = 0;
            double bug5s = 0;
            double bug4s = 0;
            double bug3s = 0;
            double bug2s = 0;
            double bug1s = 0;

            foreach (DataRow drBug in DM.dtBug.Rows)
            {
                int TestID = Convert.ToInt32(drBug["TestID"].ToString());
                cmTest.Position = DM.testCaseView.Find(TestID);
                DataRow drTest = DM.dtTest.Rows[cmTest.Position];
                int TestCaseID = Convert.ToInt32(drTest["TestCaseID"].ToString());
                cmTestCase.Position = DM.testCaseView.Find(TestCaseID);
                DataRow drTestCase = DM.dtTestCase.Rows[cmTestCase.Position];
                int UseCaseID = Convert.ToInt32(drTestCase["UseCaseID"].ToString());
                cmUseCase.Position = DM.useCaseView.Find(UseCaseID);
                DataRow drUseCase = DM.dtUseCase.Rows[cmUseCase.Position];
                int ProjectID = Convert.ToInt32(drUseCase["ProjectID"].ToString());
                cmProject.Position = DM.projectView.Find(ProjectID);
                DataRow drProject = DM.dtProject.Rows[cmProject.Position];

                string rating = drBug["Rating"].ToString();
                string BBAbb = drBug["BugAbb"].ToString();
                string SKAbb = drBug["BugAbb"].ToString();

                if (BBAbb.IndexOf("BB") == 0)
                {
                    if (rating == "15")
                    {
                        BugRating15b += drBug["SeverityID"] + "                " + drBug["PriorityID"] + "                 " + drBug["BugID"] +"\r\n";
                        bug15b++;
                        bugTotalb++;
                        bug15tb = "Number of Bugs: " + bug15b.ToString();
                    }

                    if (rating == "12")
                    {
                        BugRating12b += drBug["SeverityID"] + "                " + drBug["PriorityID"] + "                 " + drBug["BugID"] + "\r\n";
                        bug12b++;
                        bugTotalb++;
                        bug12tb = "Number of Bugs: " + bug12b.ToString();
                    }

                    if (rating == "10")
                    {
                        BugRating10b += drBug["SeverityID"] + "                " + drBug["PriorityID"] + "                 " + drBug["BugID"] + "\r\n";
                        bug10b++;
                        bugTotalb++;
                        bug10tb = "Number of Bugs: " + bug10b.ToString();
                    }

                    if (rating == "9")
                    {
                        BugRating9b += drBug["SeverityID"] + "                " + drBug["PriorityID"] + "                 " + drBug["BugID"] + "\r\n";
                        bug9b++;
                        bugTotalb++;
                        bug9tb = "Number of Bugs: " + bug9b.ToString();
                    }

                    if (rating == "8")
                    {
                        BugRating8b += drBug["SeverityID"] + "                " + drBug["PriorityID"] + "                 " + drBug["BugID"] + "\r\n";
                        bug8b++;
                        bugTotalb++;
                        bug8tb = "Number of Bugs: " + bug8b.ToString();
                    }

                    if (rating == "6")
                    {
                        BugRating6b += drBug["SeverityID"] + "                " + drBug["PriorityID"] + "                 " + drBug["BugID"] + "\r\n";
                        bug6b++;
                        bugTotalb++;
                        bug6tb = "Number of Bugs: " + bug6b.ToString();
                    }

                    if (rating == "5")
                    {
                        BugRating5b += drBug["SeverityID"] + "                " + drBug["PriorityID"] + "                 " + drBug["BugID"] + "\r\n";
                        bug5b++;
                        bugTotalb++;
                        bug5tb = "Number of Bugs: " + bug5b.ToString();
                    }

                    if (rating == "4")
                    {
                        BugRating4b += drBug["SeverityID"] + "                " + drBug["PriorityID"] + "                 " + drBug["BugID"] + "\r\n";
                        bug4b++;
                        bugTotalb++;
                        bug4tb = "Number of Bugs: " + bug4b.ToString();
                    }

                    if (rating == "3")
                    {
                        BugRating3b += drBug["SeverityID"] + "                " + drBug["PriorityID"] + "                 " + drBug["BugID"] + "\r\n";
                        bug3b++;
                        bugTotalb++;
                        bug3tb = "Number of Bugs: " + bug3b.ToString();
                    }

                    if (rating == "2")
                    {
                        BugRating2b += drBug["SeverityID"] + "                " + drBug["PriorityID"] + "                 " + drBug["BugID"] + "\r\n";
                        bug2b++;
                        bugTotalb++;
                        bug2tb = "Number of Bugs: " + bug2b.ToString();
                    }

                    if (rating == "1")
                    {
                        BugRating1b += drBug["SeverityID"] + "                " + drBug["PriorityID"] + "                 " + drBug["BugID"] + "\r\n";
                        bug1b++;
                        bugTotalb++;
                        bug1tb = "Number of Bugs: " + bug1b.ToString();
                    }
                    bugTotaltb = "\r\n" + "\r\n" + "Total Bugs: " + bugTotalb.ToString() + "\r\n";
                    BugRatingb = ProjectBB + Rating15 + Title + BugRating15b + bug15tb
                + Rating12 + Title + BugRating12b + bug12tb
                 + Rating10 + Title + BugRating10b + bug10tb
                  + Rating9 + Title + BugRating9b + bug9tb
                   + Rating8 + Title + BugRating8b + bug8tb
                    + Rating6 + Title + BugRating6b + bug6tb
                     + Rating5 + Title + BugRating5b + bug5tb
                      + Rating4 + Title + BugRating4b + bug4tb
                       + Rating3 + Title + BugRating3b + bug3tb
                        + Rating2 + Title + BugRating2b + bug2tb
                         + Rating1 + Title + BugRating1b + bug1tb + bugTotaltb;
                }

                if (BBAbb.IndexOf("SK") == 0)
                {
                    if (rating == "15")
                    {
                        BugRating15s += drBug["SeverityID"] + "                " + drBug["PriorityID"] + "                 " + drBug["BugID"] + "\r\n";
                        bug15s++;
                        bugTotals++;
                        bug15ts = "Number of Bugs: " + bug15s.ToString();
                    }

                    if (rating == "12")
                    {
                        BugRating12s += drBug["SeverityID"] + "                " + drBug["PriorityID"] + "                 " + drBug["BugID"] + "\r\n";
                        bug12s++;
                        bugTotals++;
                        bug12ts = "Number of Bugs: " + bug12s.ToString();
                    }

                    if (rating == "10")
                    {
                        BugRating10s += drBug["SeverityID"] + "                " + drBug["PriorityID"] + "                 " + drBug["BugID"] + "\r\n";
                        bug10s++;
                        bugTotals++;
                        bug10ts = "Number of Bugs: " + bug10s.ToString();
                    }

                    if (rating == "9")
                    {
                        BugRating9s += drBug["SeverityID"] + "                " + drBug["PriorityID"] + "                 " + drBug["BugID"] + "\r\n";
                        bug9s++;
                        bugTotals++;
                        bug9ts = "Number of Bugs: " + bug9s.ToString();
                    }

                    if (rating == "8")
                    {
                        BugRating8s += drBug["SeverityID"] + "                " + drBug["PriorityID"] + "                 " + drBug["BugID"] + "\r\n";
                        bug8s++;
                        bugTotals++;
                        bug8ts = "Number of Bugs: " + bug8s.ToString();
                    }

                    if (rating == "6")
                    {
                        BugRating6s += drBug["SeverityID"] + "                " + drBug["PriorityID"] + "                 " + drBug["BugID"] + "\r\n";
                        bug6s++;
                        bugTotals++;
                        bug6ts = "Number of Bugs: " + bug6s.ToString();
                    }

                    if (rating == "5")
                    {
                        BugRating5s += drBug["SeverityID"] + "                " + drBug["PriorityID"] + "                 " + drBug["BugID"] + "\r\n";
                        bug5s++;
                        bugTotals++;
                        bug5ts = "Number of Bugs: " + bug5s.ToString();
                    }

                    if (rating == "4")
                    {
                        BugRating4s += drBug["SeverityID"] + "                " + drBug["PriorityID"] + "                 " + drBug["BugID"] + "\r\n";
                        bug4s++;
                        bugTotals++;
                        bug4ts = "Number of Bugs: " + bug4s.ToString();
                    }

                    if (rating == "3")
                    {
                        BugRating3s += drBug["SeverityID"] + "                " + drBug["PriorityID"] + "                 " + drBug["BugID"] + "\r\n";
                        bug3s++;
                        bugTotals++;
                        bug3ts = "Number of Bugs: " + bug3s.ToString();
                    }

                    if (rating == "2")
                    {
                        BugRating2s += drBug["SeverityID"] + "                " + drBug["PriorityID"] + "                 " + drBug["BugID"] + "\r\n";
                        bug2s++;
                        bugTotals++;
                        bug2ts = "Number of Bugs: " + bug2s.ToString();
                    }

                    if (rating == "1")
                    {
                        BugRating1s += drBug["SeverityID"] + "                " + drBug["PriorityID"] + "                 " + drBug["BugID"] + "\r\n";
                        bug1s++;
                        bugTotals++;
                        bug1ts = "Number of Bugs: " + bug1s.ToString();
                    }
                    bugTotalts = "\r\n" + "\r\n" + "Total Bugs: " + bugTotals.ToString() + "\r\n";
                    BugRatings = ProjectSK + Rating15 + Title + BugRating15s + bug15ts
                + Rating12 + Title + BugRating12s + bug12ts
                 + Rating10 + Title + BugRating10s + bug10ts
                  + Rating9 + Title + BugRating9s + bug9ts
                   + Rating8 + Title + BugRating8s + bug8ts
                    + Rating6 + Title + BugRating6s + bug6ts
                     + Rating5 + Title + BugRating5s + bug5ts
                      + Rating4 + Title + BugRating4s + bug4ts
                       + Rating3 + Title + BugRating3s + bug3ts
                        + Rating2 + Title + BugRating2s + bug2ts
                         + Rating1 + Title + BugRating1s + bug1ts + bugTotalts;
                }
            }
            txtReport.Text = BugRatingb + BugRatings;
        }

        private void btnBugStatus_Click(object sender, EventArgs e)
        {
            string BugStatusb = "";
            string BugStatuss = "";
            string ProjectBB = "Project Name: Book Brokers" + "\r\n";
            string ProjectSK = "\r\n" + "\r\n" + "\r\n" + "Project Name: Skykiwi" + "\r\n";
            string Open = "\r\n" + "\r\n" + "Bug Status: Open" + "\r\n";
            string Closed = "\r\n" + "\r\n" + "Bug Status: Closed" + "\r\n";
            string Title = "Bug Rating" + "              " + "Number of Bugs" + "\r\n";
            double bugOpenb = 0;
            string bugOpentb = "";
            double bugClosedb = 0;
            string bugClosedtb = "";
            double bugOpens = 0;
            string bugOpents = "";
            double bugCloseds = 0;
            string bugClosedts = "";
            
            double bug15Openb = 0;
            string bug15Opentb = "";
            double bug12Openb = 0;
            string bug12Opentb = "";
            double bug10Openb = 0;
            string bug10Opentb = "";
            double bug9Openb = 0;
            string bug9Opentb = "";
            double bug8Openb = 0;
            string bug8Opentb = "";
            double bug6Openb = 0;
            string bug6Opentb = "";
            double bug5Openb = 0;
            string bug5Opentb = "";
            double bug4Openb = 0;
            string bug4Opentb = "";
            double bug3Openb = 0;
            string bug3Opentb = "";
            double bug2Openb = 0;
            string bug2Opentb = "";
            double bug1Openb = 0;
            string bug1Opentb = "";
            double bug15Closedb = 0;
            string bug15Closedtb = "";
            double bug12Closedb = 0;
            string bug12Closedtb = "";
            double bug10Closedb = 0;
            string bug10Closedtb = "";
            double bug9Closedb = 0;
            string bug9Closedtb = "";
            double bug8Closedb = 0;
            string bug8Closedtb = "";
            double bug6Closedb = 0;
            string bug6Closedtb = "";
            double bug5Closedb = 0;
            string bug5Closedtb = "";
            double bug4Closedb = 0;
            string bug4Closedtb = "";
            double bug3Closedb = 0;
            string bug3Closedtb = "";
            double bug2Closedb = 0;
            string bug2Closedtb = "";
            double bug1Closedb = 0;
            string bug1Closedtb = "";

            double bug15Opens = 0;
            string bug15Opents = "";
            double bug12Opens = 0;
            string bug12Opents = "";
            double bug10Opens = 0;
            string bug10Opents = "";
            double bug9Opens = 0;
            string bug9Opents = "";
            double bug8Opens = 0;
            string bug8Opents = "";
            double bug6Opens = 0;
            string bug6Opents = "";
            double bug5Opens = 0;
            string bug5Opents = "";
            double bug4Opens = 0;
            string bug4Opents = "";
            double bug3Opens = 0;
            string bug3Opents = "";
            double bug2Opens = 0;
            string bug2Opents = "";
            double bug1Opens = 0;
            string bug1Opents = "";
            double bug15Closeds = 0;
            string bug15Closedts = "";
            double bug12Closeds = 0;
            string bug12Closedts = "";
            double bug10Closeds = 0;
            string bug10Closedts = "";
            double bug9Closeds = 0;
            string bug9Closedts = "";
            double bug8Closeds = 0;
            string bug8Closedts = "";
            double bug6Closeds = 0;
            string bug6Closedts = "";
            double bug5Closeds = 0;
            string bug5Closedts = "";
            double bug4Closeds = 0;
            string bug4Closedts = "";
            double bug3Closeds = 0;
            string bug3Closedts = "";
            double bug2Closeds = 0;
            string bug2Closedts = "";
            double bug1Closeds = 0;
            string bug1Closedts = "";

            foreach (DataRow drBug in DM.dtBug.Rows)
            {
                string status = drBug["Status"].ToString();
                string BBAbb = drBug["BugAbb"].ToString();
                string SKAbb = drBug["BugAbb"].ToString();
                string rating = drBug["Rating"].ToString();

                if (BBAbb.IndexOf("BB") == 0)
                {
                    if(status == "Open")
                    {
                        if(rating == "15")
                        {
                            bug15Openb++;
                            bugOpenb++;
                            bug15Opentb = "15" + "                            " + bug15Openb.ToString()+ "\r\n";
                        }

                        if (rating == "12")
                        {
                            bug12Openb++;
                            bugOpenb++;
                            bug12Opentb = "12" + "                            " + bug12Openb.ToString() + "\r\n";
                        }
                        if (rating == "10")
                        {
                            bug10Openb++;
                            bugOpenb++;
                            bug10Opentb = "10" + "                            " + bug10Openb.ToString() + "\r\n";
                        }

                        if (rating == "9")
                        {
                            bug9Openb++;
                            bugOpenb++;
                            bug9Opentb = "9" + "                             " + bug9Openb.ToString() + "\r\n";
                        }
                        if (rating == "8")
                        {
                            bug8Openb++;
                            bugOpenb++;
                            bug8Opentb = "8" + "                             " + bug8Openb.ToString() + "\r\n";
                        }
                        if (rating == "6")
                        {
                            bug6Openb++;
                            bugOpenb++;
                            bug6Opentb = "6" + "                             " + bug6Openb.ToString() + "\r\n";
                        }
                        if (rating == "5")
                        {
                            bug5Openb++;
                            bugOpenb++;
                            bug5Opentb = "5" + "                             " + bug5Openb.ToString() + "\r\n";
                        }
                        if (rating == "4")
                        {
                            bug4Openb++;
                            bugOpenb++;
                            bug4Opentb = "4" + "                             " + bug4Openb.ToString() + "\r\n";
                        }
                        if (rating == "3")
                        {
                            bug3Openb++;
                            bugOpenb++;
                            bug3Opentb = "3" + "                             " + bug3Openb.ToString() + "\r\n";
                        }
                        if (rating == "2")
                        {
                            bug2Openb++;
                            bugOpenb++;
                            bug2Opentb = "2" + "                             " + bug2Openb.ToString() + "\r\n";
                        }
                        if (rating == "1")
                        {
                            bug1Openb++;
                            bugOpenb++;
                            bug1Opentb = "1" + "                             " + bug1Openb.ToString() + "\r\n";
                        }
                        bugOpentb = "\r\n" + "Total Bugs: " + bugOpenb.ToString() + "\r\n";
                    }

                    if (status == "Closed")
                    {
                        if (rating == "15")
                        {
                            bug15Closedb++;
                            bugClosedb++;
                            bug15Closedtb = "15" + "                            " + bug15Closedb.ToString() + "\r\n";
                        }

                        if (rating == "12")
                        {
                            bug12Closedb++;
                            bugClosedb++;
                            bug12Closedtb = "12" + "                            " + bug12Closedb.ToString() + "\r\n";
                        }
                        if (rating == "10")
                        {
                            bug10Closedb++;
                            bugClosedb++;
                            bug10Closedtb = "10" + "                            " + bug10Closedb.ToString() + "\r\n";
                        }

                        if (rating == "9")
                        {
                            bug9Closedb++;
                            bugClosedb++;
                            bug9Closedtb = "9" + "                             " + bug9Closedb.ToString() + "\r\n";
                        }
                        if (rating == "8")
                        {
                            bug8Closedb++;
                            bugClosedb++;
                            bug8Closedtb = "8" + "                             " + bug8Closedb.ToString() + "\r\n";
                        }
                        if (rating == "6")
                        {
                            bug6Closedb++;
                            bugClosedb++;
                            bug6Closedtb = "6" + "                             " + bug6Closedb.ToString() + "\r\n";
                        }
                        if (rating == "5")
                        {
                            bug5Closedb++;
                            bugClosedb++;
                            bug5Closedtb = "5" + "                             " + bug5Closedb.ToString() + "\r\n";
                        }
                        if (rating == "4")
                        {
                            bug4Closedb++;
                            bugClosedb++;
                            bug4Closedtb = "4" + "                             " + bug4Closedb.ToString() + "\r\n";
                        }
                        if (rating == "3")
                        {
                            bug3Closedb++;
                            bugClosedb++;
                            bug3Closedtb = "3" + "                             " + bug3Closedb.ToString() + "\r\n";
                        }
                        if (rating == "2")
                        {
                            bug2Closedb++;
                            bugClosedb++;
                            bug2Closedtb = "2" + "                             " + bug2Closedb.ToString() + "\r\n";
                        }
                        if (rating == "1")
                        {
                            bug1Closedb++;
                            bugClosedb++;
                            bug1Closedtb = "1" + "                             " + bug1Closedb.ToString() + "\r\n";
                        }
                        bugClosedtb = "\r\n" + "Total Bugs: " + bugClosedb.ToString() + "\r\n";
                    }

                    BugStatusb = ProjectBB + Open + Title + bug15Opentb + bug12Opentb + bug10Opentb + bug9Opentb
                         + bug8Opentb + bug6Opentb + bug5Opentb + bug4Opentb + bug3Opentb + bug2Opentb + bug1Opentb + bugOpentb +
                         Closed + Title + bug15Closedtb + bug12Closedtb + bug10Closedtb + bug9Closedtb
                         + bug8Closedtb + bug6Closedtb + bug5Closedtb + bug4Closedtb + bug3Closedtb + bug2Closedtb + bug1Closedtb + bugClosedtb;
                }

                if (BBAbb.IndexOf("SK") == 0)
                {
                    if (status == "Open")
                    {
                        if (rating == "15")
                        {
                            bug15Opens++;
                            bugOpens++;
                            bug15Opents = "15" + "                            " + bug15Opens.ToString() + "\r\n";
                        }

                        if (rating == "12")
                        {
                            bug12Opens++;
                            bugOpens++;
                            bug12Opents = "12" + "                            " + bug12Opens.ToString() + "\r\n";
                        }
                        if (rating == "10")
                        {
                            bug10Opens++;
                            bugOpens++;
                            bug10Opents = "10" + "                            " + bug10Opens.ToString() + "\r\n";
                        }

                        if (rating == "9")
                        {
                            bug9Opens++;
                            bugOpens++;
                            bug9Opents = "9" + "                             " + bug9Opens.ToString() + "\r\n";
                        }
                        if (rating == "8")
                        {
                            bug8Opens++;
                            bugOpens++;
                            bug8Opents = "8" + "                             " + bug8Opens.ToString() + "\r\n";
                        }
                        if (rating == "6")
                        {
                            bug6Opens++;
                            bugOpens++;
                            bug6Opents = "6" + "                             " + bug6Opens.ToString() + "\r\n";
                        }
                        if (rating == "5")
                        {
                            bug5Opens++;
                            bugOpens++;
                            bug5Opents = "5" + "                             " + bug5Opens.ToString() + "\r\n";
                        }
                        if (rating == "4")
                        {
                            bug4Opens++;
                            bugOpens++;
                            bug4Opents = "4" + "                             " + bug4Opens.ToString() + "\r\n";
                        }
                        if (rating == "3")
                        {
                            bug3Opens++;
                            bugOpens++;
                            bug3Opents = "3" + "                             " + bug3Opens.ToString() + "\r\n";
                        }
                        if (rating == "2")
                        {
                            bug2Opens++;
                            bugOpens++;
                            bug2Opents = "2" + "                             " + bug2Opens.ToString() + "\r\n";
                        }
                        if (rating == "1")
                        {
                            bug1Opens++;
                            bugOpens++;
                            bug1Opents = "1" + "                             " + bug1Opens.ToString() + "\r\n";
                        }
                        bugOpents = "\r\n" + "Total Bugs: " + bugOpens.ToString() + "\r\n";
                    }

                    if (status == "Closed")
                    {
                        if (rating == "15")
                        {
                            bug15Closeds++;
                            bugCloseds++;
                            bug15Closedts = "15" + "                            " + bug15Closeds.ToString() + "\r\n";
                        }

                        if (rating == "12")
                        {
                            bug12Closeds++;
                            bugCloseds++;
                            bug12Closedts = "12" + "                            " + bug12Closeds.ToString() + "\r\n";
                        }
                        if (rating == "10")
                        {
                            bug10Closeds++;
                            bugCloseds++;
                            bug10Closedts = "10" + "                            " + bug10Closeds.ToString() + "\r\n";
                        }

                        if (rating == "9")
                        {
                            bug9Closeds++;
                            bugCloseds++;
                            bug9Closedts = "9" + "                             " + bug9Closeds.ToString() + "\r\n";
                        }
                        if (rating == "8")
                        {
                            bug8Closeds++;
                            bugCloseds++;
                            bug8Closedts = "8" + "                             " + bug8Closeds.ToString() + "\r\n";
                        }
                        if (rating == "6")
                        {
                            bug6Closeds++;
                            bugCloseds++;
                            bug6Closedts = "6" + "                             " + bug6Closeds.ToString() + "\r\n";
                        }
                        if (rating == "5")
                        {
                            bug5Closeds++;
                            bugCloseds++;
                            bug5Closedts = "5" + "                             " + bug5Closeds.ToString() + "\r\n";
                        }
                        if (rating == "4")
                        {
                            bug4Closeds++;
                            bugCloseds++;
                            bug4Closedts = "4" + "                             " + bug4Closeds.ToString() + "\r\n";
                        }
                        if (rating == "3")
                        {
                            bug3Closeds++;
                            bugCloseds++;
                            bug3Closedts = "3" + "                             " + bug3Closeds.ToString() + "\r\n";
                        }
                        if (rating == "2")
                        {
                            bug2Closeds++;
                            bugCloseds++;
                            bug2Closedts = "2" + "                             " + bug2Closeds.ToString() + "\r\n";
                        }
                        if (rating == "1")
                        {
                            bug1Closeds++;
                            bugCloseds++;
                            bug1Closedts = "1" + "                             " + bug1Closeds.ToString() + "\r\n";
                        }
                        bugClosedts = "\r\n" + "Total Bugs: " + bugCloseds.ToString() + "\r\n";
                    }

                    BugStatuss = ProjectSK + Open + Title + bug15Opents + bug12Opents + bug10Opents + bug9Opents
                         + bug8Opents + bug6Opents + bug5Opents + bug4Opents + bug3Opents + bug2Opents + bug1Opents + bugOpents +
                         Closed + Title + bug15Closedts + bug12Closedts + bug10Closedts + bug9Closedts
                         + bug8Closedts + bug6Closedts + bug5Closedts + bug4Closedts + bug3Closedts + bug2Closedts + bug1Closedts + bugClosedts;
                }
            }
            txtReport.Text = BugStatusb + BugStatuss;
        }

        private void btnBugAssigned_Click(object sender, EventArgs e)
        {
            string Title = "\r\n" + "Bug ID" + "       " + "Bug Rating" + "       " + "Date Detected" + "              " + "Date Finished" + "\r\n";
            string Employee1 = "Employee Name: Jason Chan" + "\r\n";
            string Employee2 = "Employee Name: Nick Bell" + "\r\n";
            string Employee3 = "Employee Name: Misa Chang" + "\r\n";
            string Employee4 = "Employee Name: Tony Wong" + "\r\n";
            string Employee5 = "Employee Name: William Thang" + "\r\n";
            string bugEmployee1 = "";
            string bugEmployee2 = "";
            string bugEmployee3 = "";
            string bugEmployee4 = "";
            string bugEmployee5 = "";
            string bugAssigned = "";

            string bugATotalt1 = "";
            double bugATotal1 = 0;
            string bugATotalt2 = "";
            double bugATotal2 = 0;
            string bugATotalt3 = "";
            double bugATotal3 = 0;
            string bugATotalt4 = "";
            double bugATotal4 = 0;
            string bugATotalt5 = "";
            double bugATotal5 = 0;
            string Bug1 = "";
            string Bug2 = "";
            string Bug3 = "";
            string Bug4 = "";
            string Bug5 = "";

            foreach (DataRow drBug in DM.dtBug.Rows)
            {
                int TestID = Convert.ToInt32(drBug["TestID"].ToString());
                cmTest.Position = DM.testCaseView.Find(TestID);
                DataRow drTest = DM.dtTest.Rows[cmTest.Position];

                string assigned = drBug["Assigned"].ToString();
                string employee = drBug["EmployeeID"].ToString();

                if (assigned == "Assigned" && employee == "1")
                {
                    bugATotal1++;
                    bugEmployee1 += drBug["BugID"] + "               " + drBug["Rating"] + "           " + drBug["DateDetected"] + "           " + drBug["DateFinished"] + "\r\n";
                }
                bugATotalt1 = "\r\n" + "Total Bugs: " + bugATotal1.ToString() + "\r\n" + "\r\n" + "\r\n";

                if (assigned == "Assigned" && employee == "2")
                {
                    bugATotal2++;
                    bugEmployee2 += drBug["BugID"] + "               " + drBug["Rating"] + "           " + drBug["DateDetected"] + "           " + drBug["DateFinished"] + "\r\n";
                }
                bugATotalt2 = "\r\n" + "Total Bugs: " + bugATotal2.ToString() + "\r\n" + "\r\n" + "\r\n";

                if (assigned == "Assigned" && employee == "3")
                {
                    bugATotal3++;
                    bugEmployee3 += drBug["BugID"] + "               " + drBug["Rating"] + "           " + drBug["DateDetected"] + "           " + drBug["DateFinished"] + "\r\n";
                }
                bugATotalt3 = "\r\n" + "Total Bugs: " + bugATotal3.ToString() + "\r\n" + "\r\n" + "\r\n";

                if (assigned == "Assigned" && employee == "4")
                {
                    bugATotal4++;
                    bugEmployee4 += drBug["BugID"] + "               " + drBug["Rating"] + "           " + drBug["DateDetected"] + "           " + drBug["DateFinished"] + "\r\n";
                }
                bugATotalt4 = "\r\n" + "Total Bugs: " + bugATotal4.ToString() + "\r\n" + "\r\n" + "\r\n";

                if (assigned == "Assigned" && employee == "5")
                {
                    bugATotal5++;
                    bugEmployee5 += drBug["BugID"] + "               " + drBug["Rating"] + "           " + drBug["DateDetected"] + "           " + drBug["DateFinished"] + "\r\n";
                }
                bugATotalt5 = "\r\n" + "Total Bugs: " + bugATotal5.ToString() + "\r\n" + "\r\n" + "\r\n";

                bugAssigned = Employee1 + Title + bugEmployee1 + bugATotalt1 +
                      Employee2 + Title + bugEmployee2 + bugATotalt2 +
                       Employee3 + Title + bugEmployee3 + bugATotalt3 +
                        Employee4 + Title + bugEmployee4 + bugATotalt4 +
                         Employee5 + Title + bugEmployee5 + bugATotalt5;
            }
            txtReport.Text = bugAssigned;
        }

        private void btnBugNotA_Click(object sender, EventArgs e)
        {
            string BugAssignedb = "";
            string BugAssigneds = "";
            string ProjectBB = "Project Name: Book Brokers" + "\r\n";
            string ProjectSK = "\r\n" + "\r\n" + "\r\n" + "Project Name: Skykiwi" + "\r\n";
            string Open = "\r\n" + "\r\n" + "Bug Status: Open" + "\r\n";
            string Title = "Bug Rating" + "              " + "Number of Bugs" + "\r\n";

            double bugTotalb = 0;
            string bug15tb = "";
            string bug12tb = "";
            string bug10tb = "";
            string bug9tb = "";
            string bug8tb = "";
            string bug6tb = "";
            string bug5tb = "";
            string bug4tb = "";
            string bug3tb = "";
            string bug2tb = "";
            string bug1tb = "";
            string bugTotaltb = "";
            double bug15b = 0;
            double bug12b = 0;
            double bug10b = 0;
            double bug9b = 0;
            double bug8b = 0;
            double bug6b = 0;
            double bug5b = 0;
            double bug4b = 0;
            double bug3b = 0;
            double bug2b = 0;
            double bug1b = 0;
            double bugTotals = 0;
            string bug15ts = "";
            string bug12ts = "";
            string bug10ts = "";
            string bug9ts = "";
            string bug8ts = "";
            string bug6ts = "";
            string bug5ts = "";
            string bug4ts = "";
            string bug3ts = "";
            string bug2ts = "";
            string bug1ts = "";
            string bugTotalts = "";
            double bug15s = 0;
            double bug12s = 0;
            double bug10s = 0;
            double bug9s = 0;
            double bug8s = 0;
            double bug6s = 0;
            double bug5s = 0;
            double bug4s = 0;
            double bug3s = 0;
            double bug2s = 0;
            double bug1s = 0;

            foreach (DataRow drBug in DM.dtBug.Rows)
            {
                string status = drBug["Status"].ToString();
                string BBAbb = drBug["BugAbb"].ToString();
                string SKAbb = drBug["BugAbb"].ToString();
                string rating = drBug["Rating"].ToString();
                string assigned = drBug["Assigned"].ToString();

                if (BBAbb.IndexOf("BB") == 0 && assigned == "Not Assigned" && status == "Open")
                {
                    if (rating == "15")
                    {
                        bug15b++;
                        bugTotalb++;
                        bug15tb = "15" + "                           " + bug15b.ToString() + "\r\n";
                    }
                    if (rating == "12")
                    {
                        bug12b++;
                        bugTotalb++;
                        bug12tb = "12" + "                           " + bug12b.ToString() + "\r\n";
                    }
                    if (rating == "10")
                    {
                        bug10b++;
                        bugTotalb++;
                        bug10tb = "10" + "                           " + bug10b.ToString() + "\r\n";
                    }
                    if (rating == "9")
                    {
                        bug9b++;
                        bugTotalb++;
                        bug9tb = "9" + "                            " + bug9b.ToString() + "\r\n";
                    }
                    if (rating == "8")
                    {
                        bug8b++;
                        bugTotalb++;
                        bug8tb = "8" + "                            " + bug8b.ToString() + "\r\n";
                    }
                    if (rating == "6")
                    {
                        bug6b++;
                        bugTotalb++;
                        bug6tb = "6" + "                            " + bug6b.ToString() + "\r\n";
                    }
                    if (rating == "5")
                    {
                        bug5b++;
                        bugTotalb++;
                        bug5tb = "5" + "                            " + bug5b.ToString() + "\r\n";
                    }
                    if (rating == "4")
                    {
                        bug4b++;
                        bugTotalb++;
                        bug4tb = "4" + "                            " + bug4b.ToString() + "\r\n";
                    }
                    if (rating == "3")
                    {
                        bug3b++;
                        bugTotalb++;
                        bug3tb = "3" + "                            " + bug3b.ToString() + "\r\n";
                    }
                    if (rating == "2")
                    {
                        bug2b++;
                        bugTotalb++;
                        bug2tb = "2" + "                            " + bug2b.ToString() + "\r\n";
                    }
                    if (rating == "1")
                    {
                        bug1b++;
                        bugTotalb++;
                        bug1tb = "1" + "                            " + bug1b.ToString() + "\r\n";
                    }
                    bugTotaltb = "\r\n" + "Total Bugs: " + bugTotalb.ToString() + "\r\n";

                    BugAssignedb = ProjectBB + Open + Title + bug15tb + bug12tb + bug10tb + bug9tb + bug8tb + bug6tb + bug5tb
                        + bug4tb + bug3tb + bug2tb + bug1tb + bugTotaltb;
                }

                if (BBAbb.IndexOf("SK") == 0 && assigned == "Not Assigned" && status == "Open")
                {
                    if (rating == "15")
                    {
                        bug15s++;
                        bugTotals++;
                        bug15ts = "15" + "                           " + bug15s.ToString() + "\r\n";
                    }
                    if (rating == "12")
                    {
                        bug12s++;
                        bugTotals++;
                        bug12ts = "12" + "                           " + bug12s.ToString() + "\r\n";
                    }
                    if (rating == "10")
                    {
                        bug10s++;
                        bugTotals++;
                        bug10ts = "10" + "                           " + bug10s.ToString() + "\r\n";
                    }
                    if (rating == "9")
                    {
                        bug9s++;
                        bugTotals++;
                        bug9ts = "9" + "                            " + bug9s.ToString() + "\r\n";
                    }
                    if (rating == "8")
                    {
                        bug8s++;
                        bugTotals++;
                        bug8ts = "8" + "                            " + bug8s.ToString() + "\r\n";
                    }
                    if (rating == "6")
                    {
                        bug6s++;
                        bugTotals++;
                        bug6ts = "6" + "                            " + bug6s.ToString() + "\r\n";
                    }
                    if (rating == "5")
                    {
                        bug5s++;
                        bugTotals++;
                        bug5ts = "5" + "                            " + bug5s.ToString() + "\r\n";
                    }
                    if (rating == "4")
                    {
                        bug4s++;
                        bugTotals++;
                        bug4ts = "4" + "                            " + bug4s.ToString() + "\r\n";
                    }
                    if (rating == "3")
                    {
                        bug3s++;
                        bugTotals++;
                        bug3ts = "3" + "                            " + bug3s.ToString() + "\r\n";
                    }
                    if (rating == "2")
                    {
                        bug2s++;
                        bugTotals++;
                        bug2ts = "2" + "                            " + bug2s.ToString() + "\r\n";
                    }
                    if (rating == "1")
                    {
                        bug1s++;
                        bugTotals++;
                        bug1ts = "1" + "                            " + bug1s.ToString() + "\r\n";
                    }
                    bugTotalts = "\r\n" + "Total Bugs: " + bugTotals.ToString() + "\r\n";

                    BugAssigneds = ProjectSK + Open + Title + bug15ts + bug12ts + bug10ts + bug9ts + bug8ts + bug6ts + bug5ts
                        + bug4ts + bug3ts + bug2ts + bug1ts + bugTotalts;
                }
            }
            txtReport.Text = BugAssignedb + BugAssigneds;
        }
    }
}
