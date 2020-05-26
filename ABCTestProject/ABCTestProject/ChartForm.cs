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
    public partial class ChartForm : Form
    {
        private DataModule DM;
        private MainForm frmMenu;

        public ChartForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
            chart1.Left = 35;
            chart1.Top = 75;
            chart2.Left = 35;
            chart2.Top = 75;
            chart3.Left = 35;
            chart3.Top = 75;
            chart4.Left = 35;
            chart4.Top = 75;
        }

        private void btnBugAssigned_Click(object sender, EventArgs e)
        {
            int BBAssigned = 0;
            int SKAssigned = 0;
            int BBNotA = 0;
            int SKNotA = 0;

            foreach (DataRow drBug in DM.dtBug.Rows)
            {
                string BBAbb = drBug["BugAbb"].ToString();
                string SKAbb = drBug["BugAbb"].ToString();

                if(BBAbb.IndexOf("BB") == 0)
                {
                    if(drBug["Assigned"].ToString() == "Assigned")
                    {
                        BBAssigned++;
                    }
                    else
                    {
                        BBNotA++;
                    }
                }

                if(SKAbb.IndexOf("SK") == 0)
                {
                    if (drBug["Assigned"].ToString() == "Assigned")
                    {
                        SKAssigned++;
                    }
                    else
                    {
                        SKNotA++;
                    }
                }
            }

            chart1.Visible = true;
            chart2.Visible = false;
            chart3.Visible = false;
            chart4.Visible = false;
            this.chart1.Series["Assigned"].Points.AddXY("Book Brokers", BBAssigned);
            this.chart1.Series["Not Assigned"].Points.AddXY("Brokers", BBNotA);
            this.chart1.Series["Assigned"].Points.AddXY("Sky Kiwi", SKAssigned);
            this.chart1.Series["Not Assigned"].Points.AddXY("Kiwi", SKNotA);
        }

        private void btnBugStatus_Click(object sender, EventArgs e)
        {
            int BBOpen = 0;
            int SKOpen = 0;
            int BBClosed = 0;
            int SKClosed = 0;

            foreach (DataRow drBug in DM.dtBug.Rows)
            {
                string BBAbb = drBug["BugAbb"].ToString();
                string SKAbb = drBug["BugAbb"].ToString();

                if (BBAbb.IndexOf("BB") == 0)
                {
                    if (drBug["Status"].ToString() == "Open")
                    {
                        BBOpen++;
                    }
                    if (drBug["Status"].ToString() == "Closed")
                    {
                        BBClosed++;
                    }
                }

                if (SKAbb.IndexOf("SK") == 0)
                {
                    if (drBug["Status"].ToString() == "Open")
                    {
                        SKOpen++;
                    }
                    if(drBug["Status"].ToString() == "Closed")
                    {
                        SKClosed++;
                    }
                }
            }

            chart1.Visible = false;
            chart2.Visible = true;
            chart3.Visible = false;
            chart4.Visible = false;

            this.chart2.Series["Open"].Points.AddXY("Book Brokers", BBOpen);
            this.chart2.Series["Closed"].Points.AddXY("Brokers", BBClosed);
            this.chart2.Series["Open"].Points.AddXY("Sky Kiwi", SKOpen);
            this.chart2.Series["Closed"].Points.AddXY("Kiwi", SKClosed);
        }

        private void btnBugTester_Click(object sender, EventArgs e)
        {
            int Jason = 0;
            int Nick = 0;
            int Misa = 0;
            int Tony = 0;
            int William = 0;

            foreach (DataRow drBug in DM.dtBug.Rows)
            {
                if(drBug["Assigned"].ToString() == "Assigned")
                {
                    if(drBug["EmployeeID"].ToString() == "1")
                    {
                        Jason++;
                    }

                    if (drBug["EmployeeID"].ToString() == "2")
                    {
                        Nick++;
                    }

                    if (drBug["EmployeeID"].ToString() == "3")
                    {
                        Misa++;
                    }

                    if (drBug["EmployeeID"].ToString() == "4")
                    {
                        Tony++;
                    }

                    if (drBug["EmployeeID"].ToString() == "5")
                    {
                        William++;
                    }
                }
            }

            chart1.Visible = false;
            chart2.Visible = false;
            chart3.Visible = true;
            chart4.Visible = false;
            this.chart3.Series["Employee"].Points.AddXY("Jason Chan", Jason);
            this.chart3.Series["Employee"].Points.AddXY("Nick Bell", Nick);
            this.chart3.Series["Employee"].Points.AddXY("Misa Chang", Misa);
            this.chart3.Series["Employee"].Points.AddXY("Tony Wong", Tony);
            this.chart3.Series["Employee"].Points.AddXY("William Thang", William);
        }

        private void btnBugProject_Click(object sender, EventArgs e)
        {
            int BB = 0;
            int SK = 0;

            foreach (DataRow drBug in DM.dtBug.Rows)
            {
                string BBAbb = drBug["BugAbb"].ToString();
                string SKAbb = drBug["BugAbb"].ToString();

                if (BBAbb.IndexOf("BB") == 0)
                {
                    BB++;
                }

                if (BBAbb.IndexOf("SK") == 0)
                {
                    SK++;
                }
            }

            chart1.Visible = false;
            chart2.Visible = false;
            chart3.Visible = false;
            chart4.Visible = true;
            this.chart4.Series["Project"].Points.AddXY("Book Brokers", BB);
            this.chart4.Series["Project"].Points.AddXY("Sky Kiwi", SK);
        }
    }
}
