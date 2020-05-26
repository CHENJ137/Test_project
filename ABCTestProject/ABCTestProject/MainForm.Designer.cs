namespace ABCTestProject
{
    partial class MainForm
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
            this.btnProject = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnUseCase = new System.Windows.Forms.Button();
            this.btnTestCase = new System.Windows.Forms.Button();
            this.btnTest = new System.Windows.Forms.Button();
            this.btnBug = new System.Windows.Forms.Button();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.grpMaintenance = new System.Windows.Forms.GroupBox();
            this.btnAssignBug = new System.Windows.Forms.Button();
            this.grpOrthers = new System.Windows.Forms.GroupBox();
            this.btnSeverity = new System.Windows.Forms.Button();
            this.btnConfigure = new System.Windows.Forms.Button();
            this.btnPriority = new System.Windows.Forms.Button();
            this.groupReports = new System.Windows.Forms.GroupBox();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnCharts = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.grpMaintenance.SuspendLayout();
            this.grpOrthers.SuspendLayout();
            this.groupReports.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnProject
            // 
            this.btnProject.Location = new System.Drawing.Point(6, 20);
            this.btnProject.Name = "btnProject";
            this.btnProject.Size = new System.Drawing.Size(139, 21);
            this.btnProject.TabIndex = 0;
            this.btnProject.Text = "Project";
            this.btnProject.UseVisualStyleBackColor = true;
            this.btnProject.Click += new System.EventHandler(this.btnProject_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(402, 221);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 21);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnUseCase
            // 
            this.btnUseCase.Location = new System.Drawing.Point(6, 50);
            this.btnUseCase.Name = "btnUseCase";
            this.btnUseCase.Size = new System.Drawing.Size(139, 21);
            this.btnUseCase.TabIndex = 2;
            this.btnUseCase.Text = "Use Case";
            this.btnUseCase.UseVisualStyleBackColor = true;
            this.btnUseCase.Click += new System.EventHandler(this.btnUseCase_Click);
            // 
            // btnTestCase
            // 
            this.btnTestCase.Location = new System.Drawing.Point(6, 80);
            this.btnTestCase.Name = "btnTestCase";
            this.btnTestCase.Size = new System.Drawing.Size(139, 21);
            this.btnTestCase.TabIndex = 3;
            this.btnTestCase.Text = "Test Case";
            this.btnTestCase.UseVisualStyleBackColor = true;
            this.btnTestCase.Click += new System.EventHandler(this.btnTestCase_Click);
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(6, 110);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(139, 21);
            this.btnTest.TabIndex = 4;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // btnBug
            // 
            this.btnBug.Location = new System.Drawing.Point(6, 140);
            this.btnBug.Name = "btnBug";
            this.btnBug.Size = new System.Drawing.Size(139, 21);
            this.btnBug.TabIndex = 5;
            this.btnBug.Text = "Bug";
            this.btnBug.UseVisualStyleBackColor = true;
            this.btnBug.Click += new System.EventHandler(this.btnBug_Click);
            // 
            // btnEmployee
            // 
            this.btnEmployee.Location = new System.Drawing.Point(6, 70);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(139, 21);
            this.btnEmployee.TabIndex = 6;
            this.btnEmployee.Text = "Employee";
            this.btnEmployee.UseVisualStyleBackColor = true;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // grpMaintenance
            // 
            this.grpMaintenance.Controls.Add(this.btnProject);
            this.grpMaintenance.Controls.Add(this.btnUseCase);
            this.grpMaintenance.Controls.Add(this.btnBug);
            this.grpMaintenance.Controls.Add(this.btnTestCase);
            this.grpMaintenance.Controls.Add(this.btnAssignBug);
            this.grpMaintenance.Controls.Add(this.btnTest);
            this.grpMaintenance.Location = new System.Drawing.Point(12, 12);
            this.grpMaintenance.Name = "grpMaintenance";
            this.grpMaintenance.Size = new System.Drawing.Size(151, 203);
            this.grpMaintenance.TabIndex = 7;
            this.grpMaintenance.TabStop = false;
            this.grpMaintenance.Text = "Test Track";
            // 
            // btnAssignBug
            // 
            this.btnAssignBug.Location = new System.Drawing.Point(6, 170);
            this.btnAssignBug.Name = "btnAssignBug";
            this.btnAssignBug.Size = new System.Drawing.Size(139, 21);
            this.btnAssignBug.TabIndex = 3;
            this.btnAssignBug.Text = "Assign Bug";
            this.btnAssignBug.UseVisualStyleBackColor = true;
            this.btnAssignBug.Click += new System.EventHandler(this.btnAssignBug_Click);
            // 
            // grpOrthers
            // 
            this.grpOrthers.Controls.Add(this.btnSeverity);
            this.grpOrthers.Controls.Add(this.btnConfigure);
            this.grpOrthers.Controls.Add(this.btnEmployee);
            this.grpOrthers.Controls.Add(this.btnPriority);
            this.grpOrthers.Location = new System.Drawing.Point(169, 12);
            this.grpOrthers.Name = "grpOrthers";
            this.grpOrthers.Size = new System.Drawing.Size(151, 203);
            this.grpOrthers.TabIndex = 8;
            this.grpOrthers.TabStop = false;
            this.grpOrthers.Text = "Others";
            // 
            // btnSeverity
            // 
            this.btnSeverity.Location = new System.Drawing.Point(6, 170);
            this.btnSeverity.Name = "btnSeverity";
            this.btnSeverity.Size = new System.Drawing.Size(139, 21);
            this.btnSeverity.TabIndex = 0;
            this.btnSeverity.Text = "Severity";
            this.btnSeverity.UseVisualStyleBackColor = true;
            this.btnSeverity.Click += new System.EventHandler(this.btnSeverity_Click);
            // 
            // btnConfigure
            // 
            this.btnConfigure.Location = new System.Drawing.Point(6, 20);
            this.btnConfigure.Name = "btnConfigure";
            this.btnConfigure.Size = new System.Drawing.Size(139, 21);
            this.btnConfigure.TabIndex = 7;
            this.btnConfigure.Text = "Configure";
            this.btnConfigure.UseVisualStyleBackColor = true;
            this.btnConfigure.Click += new System.EventHandler(this.btnConfigure_Click);
            // 
            // btnPriority
            // 
            this.btnPriority.Location = new System.Drawing.Point(6, 120);
            this.btnPriority.Name = "btnPriority";
            this.btnPriority.Size = new System.Drawing.Size(139, 21);
            this.btnPriority.TabIndex = 2;
            this.btnPriority.Text = "Priority";
            this.btnPriority.UseVisualStyleBackColor = true;
            this.btnPriority.Click += new System.EventHandler(this.btnPriority_Click);
            // 
            // groupReports
            // 
            this.groupReports.Controls.Add(this.btnReports);
            this.groupReports.Controls.Add(this.btnCharts);
            this.groupReports.Controls.Add(this.btnSort);
            this.groupReports.Location = new System.Drawing.Point(326, 12);
            this.groupReports.Name = "groupReports";
            this.groupReports.Size = new System.Drawing.Size(151, 203);
            this.groupReports.TabIndex = 9;
            this.groupReports.TabStop = false;
            this.groupReports.Text = "Reports";
            // 
            // btnReports
            // 
            this.btnReports.Location = new System.Drawing.Point(6, 20);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(139, 21);
            this.btnReports.TabIndex = 0;
            this.btnReports.Text = "Reports";
            this.btnReports.UseVisualStyleBackColor = true;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnCharts
            // 
            this.btnCharts.Location = new System.Drawing.Point(6, 95);
            this.btnCharts.Name = "btnCharts";
            this.btnCharts.Size = new System.Drawing.Size(139, 21);
            this.btnCharts.TabIndex = 2;
            this.btnCharts.Text = "Charts";
            this.btnCharts.UseVisualStyleBackColor = true;
            this.btnCharts.Click += new System.EventHandler(this.btnCharts_Click);
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(6, 170);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(139, 21);
            this.btnSort.TabIndex = 3;
            this.btnSort.Text = "Dynamic Sorting";
            this.btnSort.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 254);
            this.Controls.Add(this.groupReports);
            this.Controls.Add(this.grpOrthers);
            this.Controls.Add(this.grpMaintenance);
            this.Controls.Add(this.btnExit);
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.grpMaintenance.ResumeLayout(false);
            this.grpOrthers.ResumeLayout(false);
            this.groupReports.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProject;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnUseCase;
        private System.Windows.Forms.Button btnTestCase;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Button btnBug;
        private System.Windows.Forms.Button btnEmployee;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox grpMaintenance;
        private System.Windows.Forms.GroupBox grpOrthers;
        private System.Windows.Forms.Button btnSeverity;
        private System.Windows.Forms.Button btnPriority;
        private System.Windows.Forms.Button btnAssignBug;
        private System.Windows.Forms.Button btnConfigure;
        private System.Windows.Forms.GroupBox groupReports;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnCharts;
        private System.Windows.Forms.Button btnSort;
    }
}

