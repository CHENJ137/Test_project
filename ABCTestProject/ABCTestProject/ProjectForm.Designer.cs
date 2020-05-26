namespace ABCTestProject
{
    partial class ProjectForm
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
            this.lstProject = new System.Windows.Forms.ListBox();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnDeleteProject = new System.Windows.Forms.Button();
            this.btnUpdateProject = new System.Windows.Forms.Button();
            this.btnAddProject = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblProjectID = new System.Windows.Forms.Label();
            this.lblProjectName = new System.Windows.Forms.Label();
            this.lblDateEnd = new System.Windows.Forms.Label();
            this.lblDateStart = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtProjectID = new System.Windows.Forms.TextBox();
            this.txtDateEnd = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtDateStart = new System.Windows.Forms.TextBox();
            this.txtProjectName = new System.Windows.Forms.TextBox();
            this.txtProjectAbb = new System.Windows.Forms.TextBox();
            this.pnlAddProject = new System.Windows.Forms.Panel();
            this.txtAddProjectAbb = new System.Windows.Forms.TextBox();
            this.lblAddDescription = new System.Windows.Forms.Label();
            this.lblAddDateEnd = new System.Windows.Forms.Label();
            this.lblAddDateStart = new System.Windows.Forms.Label();
            this.lblAddProjectName = new System.Windows.Forms.Label();
            this.dtpAddDateEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpAddDateStart = new System.Windows.Forms.DateTimePicker();
            this.txtAddDescription = new System.Windows.Forms.TextBox();
            this.txtAddProjectName = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSaveProject = new System.Windows.Forms.Button();
            this.pnlUpdateProject = new System.Windows.Forms.Panel();
            this.txtUpdateProjectAbb = new System.Windows.Forms.TextBox();
            this.lblUpdateDescription = new System.Windows.Forms.Label();
            this.lblUpdateDateEnd = new System.Windows.Forms.Label();
            this.lblUpdateDateStart = new System.Windows.Forms.Label();
            this.lblUpdateProjectName = new System.Windows.Forms.Label();
            this.dtpUpdateDateEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpUpdateDateStart = new System.Windows.Forms.DateTimePicker();
            this.txtUpdateDescription = new System.Windows.Forms.TextBox();
            this.txtUpdateProjectName = new System.Windows.Forms.TextBox();
            this.btnCancel2 = new System.Windows.Forms.Button();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.pnlAddProject.SuspendLayout();
            this.pnlUpdateProject.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstProject
            // 
            this.lstProject.FormattingEnabled = true;
            this.lstProject.ItemHeight = 12;
            this.lstProject.Location = new System.Drawing.Point(25, 25);
            this.lstProject.Name = "lstProject";
            this.lstProject.Size = new System.Drawing.Size(100, 220);
            this.lstProject.TabIndex = 0;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(25, 264);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 23);
            this.btnPrevious.TabIndex = 1;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnDeleteProject
            // 
            this.btnDeleteProject.Location = new System.Drawing.Point(399, 264);
            this.btnDeleteProject.Name = "btnDeleteProject";
            this.btnDeleteProject.Size = new System.Drawing.Size(100, 23);
            this.btnDeleteProject.TabIndex = 2;
            this.btnDeleteProject.Text = "Delete Project";
            this.btnDeleteProject.UseVisualStyleBackColor = true;
            this.btnDeleteProject.Click += new System.EventHandler(this.btnDeleteProject_Click);
            // 
            // btnUpdateProject
            // 
            this.btnUpdateProject.Location = new System.Drawing.Point(293, 264);
            this.btnUpdateProject.Name = "btnUpdateProject";
            this.btnUpdateProject.Size = new System.Drawing.Size(100, 23);
            this.btnUpdateProject.TabIndex = 3;
            this.btnUpdateProject.Text = "Update Project";
            this.btnUpdateProject.UseVisualStyleBackColor = true;
            this.btnUpdateProject.Click += new System.EventHandler(this.btnUpdateProject_Click);
            // 
            // btnAddProject
            // 
            this.btnAddProject.Location = new System.Drawing.Point(187, 264);
            this.btnAddProject.Name = "btnAddProject";
            this.btnAddProject.Size = new System.Drawing.Size(100, 23);
            this.btnAddProject.TabIndex = 4;
            this.btnAddProject.Text = "Add Project";
            this.btnAddProject.UseVisualStyleBackColor = true;
            this.btnAddProject.Click += new System.EventHandler(this.btnAddProject_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(424, 300);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 23);
            this.btnReturn.TabIndex = 5;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(106, 264);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblProjectID
            // 
            this.lblProjectID.AutoSize = true;
            this.lblProjectID.Location = new System.Drawing.Point(175, 40);
            this.lblProjectID.Name = "lblProjectID";
            this.lblProjectID.Size = new System.Drawing.Size(71, 12);
            this.lblProjectID.TabIndex = 7;
            this.lblProjectID.Text = "Project ID:";
            // 
            // lblProjectName
            // 
            this.lblProjectName.AutoSize = true;
            this.lblProjectName.Location = new System.Drawing.Point(161, 70);
            this.lblProjectName.Name = "lblProjectName";
            this.lblProjectName.Size = new System.Drawing.Size(83, 12);
            this.lblProjectName.TabIndex = 8;
            this.lblProjectName.Text = "Project Name:";
            // 
            // lblDateEnd
            // 
            this.lblDateEnd.AutoSize = true;
            this.lblDateEnd.Location = new System.Drawing.Point(185, 130);
            this.lblDateEnd.Name = "lblDateEnd";
            this.lblDateEnd.Size = new System.Drawing.Size(59, 12);
            this.lblDateEnd.TabIndex = 9;
            this.lblDateEnd.Text = "Date End:";
            // 
            // lblDateStart
            // 
            this.lblDateStart.AutoSize = true;
            this.lblDateStart.Location = new System.Drawing.Point(173, 100);
            this.lblDateStart.Name = "lblDateStart";
            this.lblDateStart.Size = new System.Drawing.Size(71, 12);
            this.lblDateStart.TabIndex = 10;
            this.lblDateStart.Text = "Date Start:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(167, 160);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(77, 12);
            this.lblDescription.TabIndex = 12;
            this.lblDescription.Text = "Description:";
            // 
            // txtProjectID
            // 
            this.txtProjectID.Location = new System.Drawing.Point(252, 37);
            this.txtProjectID.Name = "txtProjectID";
            this.txtProjectID.Size = new System.Drawing.Size(49, 21);
            this.txtProjectID.TabIndex = 13;
            // 
            // txtDateEnd
            // 
            this.txtDateEnd.Location = new System.Drawing.Point(252, 127);
            this.txtDateEnd.Name = "txtDateEnd";
            this.txtDateEnd.Size = new System.Drawing.Size(100, 21);
            this.txtDateEnd.TabIndex = 15;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(252, 160);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(247, 71);
            this.txtDescription.TabIndex = 16;
            // 
            // txtDateStart
            // 
            this.txtDateStart.Location = new System.Drawing.Point(252, 97);
            this.txtDateStart.Name = "txtDateStart";
            this.txtDateStart.Size = new System.Drawing.Size(100, 21);
            this.txtDateStart.TabIndex = 17;
            // 
            // txtProjectName
            // 
            this.txtProjectName.Location = new System.Drawing.Point(252, 67);
            this.txtProjectName.Name = "txtProjectName";
            this.txtProjectName.Size = new System.Drawing.Size(159, 21);
            this.txtProjectName.TabIndex = 18;
            // 
            // txtProjectAbb
            // 
            this.txtProjectAbb.Location = new System.Drawing.Point(417, 67);
            this.txtProjectAbb.Name = "txtProjectAbb";
            this.txtProjectAbb.Size = new System.Drawing.Size(65, 21);
            this.txtProjectAbb.TabIndex = 20;
            // 
            // pnlAddProject
            // 
            this.pnlAddProject.Controls.Add(this.txtAddProjectAbb);
            this.pnlAddProject.Controls.Add(this.lblAddDescription);
            this.pnlAddProject.Controls.Add(this.lblAddDateEnd);
            this.pnlAddProject.Controls.Add(this.lblAddDateStart);
            this.pnlAddProject.Controls.Add(this.lblAddProjectName);
            this.pnlAddProject.Controls.Add(this.dtpAddDateEnd);
            this.pnlAddProject.Controls.Add(this.dtpAddDateStart);
            this.pnlAddProject.Controls.Add(this.txtAddDescription);
            this.pnlAddProject.Controls.Add(this.txtAddProjectName);
            this.pnlAddProject.Controls.Add(this.btnCancel);
            this.pnlAddProject.Controls.Add(this.btnSaveProject);
            this.pnlAddProject.Location = new System.Drawing.Point(12, 306);
            this.pnlAddProject.Name = "pnlAddProject";
            this.pnlAddProject.Size = new System.Drawing.Size(355, 220);
            this.pnlAddProject.TabIndex = 21;
            this.pnlAddProject.Visible = false;
            this.pnlAddProject.Click += new System.EventHandler(this.btnSaveProject_Click);
            // 
            // txtAddProjectAbb
            // 
            this.txtAddProjectAbb.Location = new System.Drawing.Point(277, 15);
            this.txtAddProjectAbb.Name = "txtAddProjectAbb";
            this.txtAddProjectAbb.Size = new System.Drawing.Size(61, 21);
            this.txtAddProjectAbb.TabIndex = 30;
            // 
            // lblAddDescription
            // 
            this.lblAddDescription.AutoSize = true;
            this.lblAddDescription.Location = new System.Drawing.Point(34, 110);
            this.lblAddDescription.Name = "lblAddDescription";
            this.lblAddDescription.Size = new System.Drawing.Size(77, 12);
            this.lblAddDescription.TabIndex = 29;
            this.lblAddDescription.Text = "Description:";
            // 
            // lblAddDateEnd
            // 
            this.lblAddDateEnd.AutoSize = true;
            this.lblAddDateEnd.Location = new System.Drawing.Point(52, 80);
            this.lblAddDateEnd.Name = "lblAddDateEnd";
            this.lblAddDateEnd.Size = new System.Drawing.Size(59, 12);
            this.lblAddDateEnd.TabIndex = 28;
            this.lblAddDateEnd.Text = "Date End:";
            // 
            // lblAddDateStart
            // 
            this.lblAddDateStart.AutoSize = true;
            this.lblAddDateStart.Location = new System.Drawing.Point(40, 50);
            this.lblAddDateStart.Name = "lblAddDateStart";
            this.lblAddDateStart.Size = new System.Drawing.Size(71, 12);
            this.lblAddDateStart.TabIndex = 27;
            this.lblAddDateStart.Text = "Date Start:";
            // 
            // lblAddProjectName
            // 
            this.lblAddProjectName.AutoSize = true;
            this.lblAddProjectName.Location = new System.Drawing.Point(28, 20);
            this.lblAddProjectName.Name = "lblAddProjectName";
            this.lblAddProjectName.Size = new System.Drawing.Size(83, 12);
            this.lblAddProjectName.TabIndex = 26;
            this.lblAddProjectName.Text = "Project Name:";
            // 
            // dtpAddDateEnd
            // 
            this.dtpAddDateEnd.Location = new System.Drawing.Point(117, 75);
            this.dtpAddDateEnd.Name = "dtpAddDateEnd";
            this.dtpAddDateEnd.Size = new System.Drawing.Size(100, 21);
            this.dtpAddDateEnd.TabIndex = 25;
            // 
            // dtpAddDateStart
            // 
            this.dtpAddDateStart.Location = new System.Drawing.Point(117, 45);
            this.dtpAddDateStart.Name = "dtpAddDateStart";
            this.dtpAddDateStart.Size = new System.Drawing.Size(100, 21);
            this.dtpAddDateStart.TabIndex = 24;
            // 
            // txtAddDescription
            // 
            this.txtAddDescription.Location = new System.Drawing.Point(117, 105);
            this.txtAddDescription.Multiline = true;
            this.txtAddDescription.Name = "txtAddDescription";
            this.txtAddDescription.Size = new System.Drawing.Size(221, 69);
            this.txtAddDescription.TabIndex = 23;
            // 
            // txtAddProjectName
            // 
            this.txtAddProjectName.Location = new System.Drawing.Point(117, 15);
            this.txtAddProjectName.Name = "txtAddProjectName";
            this.txtAddProjectName.Size = new System.Drawing.Size(149, 21);
            this.txtAddProjectName.TabIndex = 22;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(248, 180);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 23);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSaveProject
            // 
            this.btnSaveProject.Location = new System.Drawing.Point(18, 180);
            this.btnSaveProject.Name = "btnSaveProject";
            this.btnSaveProject.Size = new System.Drawing.Size(90, 23);
            this.btnSaveProject.TabIndex = 20;
            this.btnSaveProject.Text = "Save Project";
            this.btnSaveProject.UseVisualStyleBackColor = true;
            this.btnSaveProject.Click += new System.EventHandler(this.btnSaveProject_Click);
            // 
            // pnlUpdateProject
            // 
            this.pnlUpdateProject.Controls.Add(this.txtUpdateProjectAbb);
            this.pnlUpdateProject.Controls.Add(this.lblUpdateDescription);
            this.pnlUpdateProject.Controls.Add(this.lblUpdateDateEnd);
            this.pnlUpdateProject.Controls.Add(this.lblUpdateDateStart);
            this.pnlUpdateProject.Controls.Add(this.lblUpdateProjectName);
            this.pnlUpdateProject.Controls.Add(this.dtpUpdateDateEnd);
            this.pnlUpdateProject.Controls.Add(this.dtpUpdateDateStart);
            this.pnlUpdateProject.Controls.Add(this.txtUpdateDescription);
            this.pnlUpdateProject.Controls.Add(this.txtUpdateProjectName);
            this.pnlUpdateProject.Controls.Add(this.btnCancel2);
            this.pnlUpdateProject.Controls.Add(this.btnSaveChanges);
            this.pnlUpdateProject.Location = new System.Drawing.Point(66, 289);
            this.pnlUpdateProject.Name = "pnlUpdateProject";
            this.pnlUpdateProject.Size = new System.Drawing.Size(355, 220);
            this.pnlUpdateProject.TabIndex = 31;
            this.pnlUpdateProject.Visible = false;
            // 
            // txtUpdateProjectAbb
            // 
            this.txtUpdateProjectAbb.Location = new System.Drawing.Point(277, 15);
            this.txtUpdateProjectAbb.Name = "txtUpdateProjectAbb";
            this.txtUpdateProjectAbb.Size = new System.Drawing.Size(61, 21);
            this.txtUpdateProjectAbb.TabIndex = 30;
            // 
            // lblUpdateDescription
            // 
            this.lblUpdateDescription.AutoSize = true;
            this.lblUpdateDescription.Location = new System.Drawing.Point(34, 110);
            this.lblUpdateDescription.Name = "lblUpdateDescription";
            this.lblUpdateDescription.Size = new System.Drawing.Size(77, 12);
            this.lblUpdateDescription.TabIndex = 29;
            this.lblUpdateDescription.Text = "Description:";
            // 
            // lblUpdateDateEnd
            // 
            this.lblUpdateDateEnd.AutoSize = true;
            this.lblUpdateDateEnd.Location = new System.Drawing.Point(52, 80);
            this.lblUpdateDateEnd.Name = "lblUpdateDateEnd";
            this.lblUpdateDateEnd.Size = new System.Drawing.Size(59, 12);
            this.lblUpdateDateEnd.TabIndex = 28;
            this.lblUpdateDateEnd.Text = "Date End:";
            // 
            // lblUpdateDateStart
            // 
            this.lblUpdateDateStart.AutoSize = true;
            this.lblUpdateDateStart.Location = new System.Drawing.Point(40, 50);
            this.lblUpdateDateStart.Name = "lblUpdateDateStart";
            this.lblUpdateDateStart.Size = new System.Drawing.Size(71, 12);
            this.lblUpdateDateStart.TabIndex = 27;
            this.lblUpdateDateStart.Text = "Date Start:";
            // 
            // lblUpdateProjectName
            // 
            this.lblUpdateProjectName.AutoSize = true;
            this.lblUpdateProjectName.Location = new System.Drawing.Point(28, 20);
            this.lblUpdateProjectName.Name = "lblUpdateProjectName";
            this.lblUpdateProjectName.Size = new System.Drawing.Size(83, 12);
            this.lblUpdateProjectName.TabIndex = 26;
            this.lblUpdateProjectName.Text = "Project Name:";
            // 
            // dtpUpdateDateEnd
            // 
            this.dtpUpdateDateEnd.Location = new System.Drawing.Point(117, 75);
            this.dtpUpdateDateEnd.Name = "dtpUpdateDateEnd";
            this.dtpUpdateDateEnd.Size = new System.Drawing.Size(100, 21);
            this.dtpUpdateDateEnd.TabIndex = 25;
            // 
            // dtpUpdateDateStart
            // 
            this.dtpUpdateDateStart.Location = new System.Drawing.Point(117, 45);
            this.dtpUpdateDateStart.Name = "dtpUpdateDateStart";
            this.dtpUpdateDateStart.Size = new System.Drawing.Size(100, 21);
            this.dtpUpdateDateStart.TabIndex = 24;
            // 
            // txtUpdateDescription
            // 
            this.txtUpdateDescription.Location = new System.Drawing.Point(117, 105);
            this.txtUpdateDescription.Multiline = true;
            this.txtUpdateDescription.Name = "txtUpdateDescription";
            this.txtUpdateDescription.Size = new System.Drawing.Size(221, 69);
            this.txtUpdateDescription.TabIndex = 23;
            // 
            // txtUpdateProjectName
            // 
            this.txtUpdateProjectName.Location = new System.Drawing.Point(117, 15);
            this.txtUpdateProjectName.Name = "txtUpdateProjectName";
            this.txtUpdateProjectName.Size = new System.Drawing.Size(149, 21);
            this.txtUpdateProjectName.TabIndex = 22;
            // 
            // btnCancel2
            // 
            this.btnCancel2.Location = new System.Drawing.Point(248, 180);
            this.btnCancel2.Name = "btnCancel2";
            this.btnCancel2.Size = new System.Drawing.Size(90, 23);
            this.btnCancel2.TabIndex = 21;
            this.btnCancel2.Text = "Cancel";
            this.btnCancel2.UseVisualStyleBackColor = true;
            this.btnCancel2.Click += new System.EventHandler(this.btnCancel2_Click);
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Location = new System.Drawing.Point(18, 180);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(90, 23);
            this.btnSaveChanges.TabIndex = 20;
            this.btnSaveChanges.Text = "Save Changes";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // ProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 337);
            this.Controls.Add(this.pnlUpdateProject);
            this.Controls.Add(this.pnlAddProject);
            this.Controls.Add(this.txtProjectAbb);
            this.Controls.Add(this.txtProjectName);
            this.Controls.Add(this.txtDateStart);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtDateEnd);
            this.Controls.Add(this.txtProjectID);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblDateStart);
            this.Controls.Add(this.lblDateEnd);
            this.Controls.Add(this.lblProjectName);
            this.Controls.Add(this.lblProjectID);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnAddProject);
            this.Controls.Add(this.btnUpdateProject);
            this.Controls.Add(this.btnDeleteProject);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.lstProject);
            this.Name = "ProjectForm";
            this.Text = "Project Maintenance";
            this.pnlAddProject.ResumeLayout(false);
            this.pnlAddProject.PerformLayout();
            this.pnlUpdateProject.ResumeLayout(false);
            this.pnlUpdateProject.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstProject;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnDeleteProject;
        private System.Windows.Forms.Button btnUpdateProject;
        private System.Windows.Forms.Button btnAddProject;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblProjectID;
        private System.Windows.Forms.Label lblProjectName;
        private System.Windows.Forms.Label lblDateEnd;
        private System.Windows.Forms.Label lblDateStart;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtProjectID;
        private System.Windows.Forms.TextBox txtDateEnd;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtDateStart;
        private System.Windows.Forms.TextBox txtProjectName;
        private System.Windows.Forms.TextBox txtProjectAbb;
        private System.Windows.Forms.Panel pnlAddProject;
        private System.Windows.Forms.TextBox txtAddProjectAbb;
        private System.Windows.Forms.Label lblAddDescription;
        private System.Windows.Forms.Label lblAddDateEnd;
        private System.Windows.Forms.Label lblAddDateStart;
        private System.Windows.Forms.Label lblAddProjectName;
        private System.Windows.Forms.DateTimePicker dtpAddDateEnd;
        private System.Windows.Forms.DateTimePicker dtpAddDateStart;
        private System.Windows.Forms.TextBox txtAddDescription;
        private System.Windows.Forms.TextBox txtAddProjectName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSaveProject;
        private System.Windows.Forms.Panel pnlUpdateProject;
        private System.Windows.Forms.TextBox txtUpdateProjectAbb;
        private System.Windows.Forms.Label lblUpdateDescription;
        private System.Windows.Forms.Label lblUpdateDateEnd;
        private System.Windows.Forms.Label lblUpdateDateStart;
        private System.Windows.Forms.Label lblUpdateProjectName;
        private System.Windows.Forms.DateTimePicker dtpUpdateDateEnd;
        private System.Windows.Forms.DateTimePicker dtpUpdateDateStart;
        private System.Windows.Forms.TextBox txtUpdateDescription;
        private System.Windows.Forms.TextBox txtUpdateProjectName;
        private System.Windows.Forms.Button btnCancel2;
        private System.Windows.Forms.Button btnSaveChanges;
    }
}