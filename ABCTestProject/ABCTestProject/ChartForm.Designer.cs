namespace ABCTestProject
{
    partial class ChartForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnBugAssigned = new System.Windows.Forms.Button();
            this.btnBugStatus = new System.Windows.Forms.Button();
            this.btnBugProject = new System.Windows.Forms.Button();
            this.btnBugTester = new System.Windows.Forms.Button();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart4 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart4)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(35, 75);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Assigned";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Not Assigned";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(462, 250);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "Bug Assigned Per Project";
            title1.Name = "Title1";
            title1.Text = "Bug Assigned Per Project";
            this.chart1.Titles.Add(title1);
            this.chart1.Visible = false;
            // 
            // btnBugAssigned
            // 
            this.btnBugAssigned.Location = new System.Drawing.Point(24, 23);
            this.btnBugAssigned.Name = "btnBugAssigned";
            this.btnBugAssigned.Size = new System.Drawing.Size(100, 23);
            this.btnBugAssigned.TabIndex = 1;
            this.btnBugAssigned.Text = "Bug Assigned";
            this.btnBugAssigned.UseVisualStyleBackColor = true;
            this.btnBugAssigned.Click += new System.EventHandler(this.btnBugAssigned_Click);
            // 
            // btnBugStatus
            // 
            this.btnBugStatus.Location = new System.Drawing.Point(152, 23);
            this.btnBugStatus.Name = "btnBugStatus";
            this.btnBugStatus.Size = new System.Drawing.Size(100, 23);
            this.btnBugStatus.TabIndex = 2;
            this.btnBugStatus.Text = "Bug Status";
            this.btnBugStatus.UseVisualStyleBackColor = true;
            this.btnBugStatus.Click += new System.EventHandler(this.btnBugStatus_Click);
            // 
            // btnBugProject
            // 
            this.btnBugProject.Location = new System.Drawing.Point(408, 23);
            this.btnBugProject.Name = "btnBugProject";
            this.btnBugProject.Size = new System.Drawing.Size(100, 23);
            this.btnBugProject.TabIndex = 3;
            this.btnBugProject.Text = "Bug to Project";
            this.btnBugProject.UseVisualStyleBackColor = true;
            this.btnBugProject.Click += new System.EventHandler(this.btnBugProject_Click);
            // 
            // btnBugTester
            // 
            this.btnBugTester.Location = new System.Drawing.Point(280, 23);
            this.btnBugTester.Name = "btnBugTester";
            this.btnBugTester.Size = new System.Drawing.Size(100, 23);
            this.btnBugTester.TabIndex = 4;
            this.btnBugTester.Text = "Bug to Tester";
            this.btnBugTester.UseVisualStyleBackColor = true;
            this.btnBugTester.Click += new System.EventHandler(this.btnBugTester_Click);
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(24, 129);
            this.chart2.Name = "chart2";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Open";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Closed";
            this.chart2.Series.Add(series3);
            this.chart2.Series.Add(series4);
            this.chart2.Size = new System.Drawing.Size(462, 250);
            this.chart2.TabIndex = 5;
            this.chart2.Text = "chart2";
            title2.Name = "Title1";
            title2.Text = "Bug Status Per Project";
            this.chart2.Titles.Add(title2);
            this.chart2.Visible = false;
            // 
            // chart3
            // 
            chartArea3.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart3.Legends.Add(legend3);
            this.chart3.Location = new System.Drawing.Point(60, 213);
            this.chart3.Name = "chart3";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Employee";
            this.chart3.Series.Add(series5);
            this.chart3.Size = new System.Drawing.Size(462, 250);
            this.chart3.TabIndex = 6;
            this.chart3.Text = "chart3";
            title3.Name = "Title1";
            title3.Text = "Bugs Assigned to Employee";
            this.chart3.Titles.Add(title3);
            this.chart3.Visible = false;
            // 
            // chart4
            // 
            chartArea4.Name = "ChartArea1";
            this.chart4.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart4.Legends.Add(legend4);
            this.chart4.Location = new System.Drawing.Point(-2, 213);
            this.chart4.Name = "chart4";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Project";
            this.chart4.Series.Add(series6);
            this.chart4.Size = new System.Drawing.Size(462, 250);
            this.chart4.TabIndex = 7;
            this.chart4.Text = "chart4";
            title4.Name = "Title1";
            title4.Text = "Bugs to Project";
            this.chart4.Titles.Add(title4);
            this.chart4.Visible = false;
            // 
            // ChartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 337);
            this.Controls.Add(this.chart4);
            this.Controls.Add(this.chart3);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.btnBugTester);
            this.Controls.Add(this.btnBugProject);
            this.Controls.Add(this.btnBugStatus);
            this.Controls.Add(this.btnBugAssigned);
            this.Controls.Add(this.chart1);
            this.Name = "ChartForm";
            this.Text = "Chart";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button btnBugAssigned;
        private System.Windows.Forms.Button btnBugStatus;
        private System.Windows.Forms.Button btnBugProject;
        private System.Windows.Forms.Button btnBugTester;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart4;
    }
}