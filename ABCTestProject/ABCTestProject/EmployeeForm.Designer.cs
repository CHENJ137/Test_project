namespace ABCTestProject
{
    partial class EmployeeForm
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
            this.lstEmployee = new System.Windows.Forms.ListBox();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.btnUpdateEmployee = new System.Windows.Forms.Button();
            this.btnDeleteEmployee = new System.Windows.Forms.Button();
            this.txtExt = new System.Windows.Forms.TextBox();
            this.lblExt = new System.Windows.Forms.Label();
            this.txtJob = new System.Windows.Forms.TextBox();
            this.txtFirstN = new System.Windows.Forms.TextBox();
            this.txtLastN = new System.Windows.Forms.TextBox();
            this.lblJob = new System.Windows.Forms.Label();
            this.lblLastN = new System.Windows.Forms.Label();
            this.lblFirstN = new System.Windows.Forms.Label();
            this.txtEmployeeID = new System.Windows.Forms.TextBox();
            this.lblEmployeeID = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.pnlAddEmployee = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSaveEmployee = new System.Windows.Forms.Button();
            this.txtAddEmail = new System.Windows.Forms.TextBox();
            this.lblAddEmail = new System.Windows.Forms.Label();
            this.txtAddExt = new System.Windows.Forms.TextBox();
            this.lblAddExt = new System.Windows.Forms.Label();
            this.txtAddJob = new System.Windows.Forms.TextBox();
            this.txtAddFirstN = new System.Windows.Forms.TextBox();
            this.txtAddLastN = new System.Windows.Forms.TextBox();
            this.lblAddJob = new System.Windows.Forms.Label();
            this.lblAddLastN = new System.Windows.Forms.Label();
            this.lblAddFirstN = new System.Windows.Forms.Label();
            this.pnlUpdateEmployee = new System.Windows.Forms.Panel();
            this.btnCancel2 = new System.Windows.Forms.Button();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.txtUpdateEmail = new System.Windows.Forms.TextBox();
            this.lblUpdateEmail = new System.Windows.Forms.Label();
            this.txtUpdateExt = new System.Windows.Forms.TextBox();
            this.lblUpdateExt = new System.Windows.Forms.Label();
            this.txtUpdateJob = new System.Windows.Forms.TextBox();
            this.txtUpdateFirstN = new System.Windows.Forms.TextBox();
            this.txtUpdateLastN = new System.Windows.Forms.TextBox();
            this.lblUpdateJob = new System.Windows.Forms.Label();
            this.lblUpdateLastN = new System.Windows.Forms.Label();
            this.lblUpdateFirstN = new System.Windows.Forms.Label();
            this.pnlAddEmployee.SuspendLayout();
            this.pnlUpdateEmployee.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstEmployee
            // 
            this.lstEmployee.FormattingEnabled = true;
            this.lstEmployee.ItemHeight = 12;
            this.lstEmployee.Location = new System.Drawing.Point(25, 25);
            this.lstEmployee.Name = "lstEmployee";
            this.lstEmployee.Size = new System.Drawing.Size(100, 220);
            this.lstEmployee.TabIndex = 3;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(25, 264);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 23);
            this.btnPrevious.TabIndex = 4;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(106, 264);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 9;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(429, 302);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 23);
            this.btnReturn.TabIndex = 11;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Location = new System.Drawing.Point(187, 264);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(105, 23);
            this.btnAddEmployee.TabIndex = 12;
            this.btnAddEmployee.Text = "Add Employee";
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // btnUpdateEmployee
            // 
            this.btnUpdateEmployee.Location = new System.Drawing.Point(293, 264);
            this.btnUpdateEmployee.Name = "btnUpdateEmployee";
            this.btnUpdateEmployee.Size = new System.Drawing.Size(105, 23);
            this.btnUpdateEmployee.TabIndex = 13;
            this.btnUpdateEmployee.Text = "Update Employee";
            this.btnUpdateEmployee.UseVisualStyleBackColor = true;
            this.btnUpdateEmployee.Click += new System.EventHandler(this.btnUpdateEmployee_Click);
            // 
            // btnDeleteEmployee
            // 
            this.btnDeleteEmployee.Location = new System.Drawing.Point(399, 264);
            this.btnDeleteEmployee.Name = "btnDeleteEmployee";
            this.btnDeleteEmployee.Size = new System.Drawing.Size(105, 23);
            this.btnDeleteEmployee.TabIndex = 14;
            this.btnDeleteEmployee.Text = "Delete Employee";
            this.btnDeleteEmployee.UseVisualStyleBackColor = true;
            this.btnDeleteEmployee.Click += new System.EventHandler(this.btnDeleteEmployee_Click);
            // 
            // txtExt
            // 
            this.txtExt.Location = new System.Drawing.Point(239, 172);
            this.txtExt.Name = "txtExt";
            this.txtExt.Size = new System.Drawing.Size(100, 21);
            this.txtExt.TabIndex = 33;
            // 
            // lblExt
            // 
            this.lblExt.AutoSize = true;
            this.lblExt.Location = new System.Drawing.Point(156, 175);
            this.lblExt.Name = "lblExt";
            this.lblExt.Size = new System.Drawing.Size(77, 12);
            this.lblExt.TabIndex = 32;
            this.lblExt.Text = "Ext. Number:";
            // 
            // txtJob
            // 
            this.txtJob.Location = new System.Drawing.Point(239, 137);
            this.txtJob.Name = "txtJob";
            this.txtJob.Size = new System.Drawing.Size(100, 21);
            this.txtJob.TabIndex = 31;
            // 
            // txtFirstN
            // 
            this.txtFirstN.Location = new System.Drawing.Point(239, 67);
            this.txtFirstN.Name = "txtFirstN";
            this.txtFirstN.Size = new System.Drawing.Size(100, 21);
            this.txtFirstN.TabIndex = 30;
            // 
            // txtLastN
            // 
            this.txtLastN.Location = new System.Drawing.Point(239, 102);
            this.txtLastN.Name = "txtLastN";
            this.txtLastN.Size = new System.Drawing.Size(100, 21);
            this.txtLastN.TabIndex = 29;
            // 
            // lblJob
            // 
            this.lblJob.AutoSize = true;
            this.lblJob.Location = new System.Drawing.Point(168, 140);
            this.lblJob.Name = "lblJob";
            this.lblJob.Size = new System.Drawing.Size(65, 12);
            this.lblJob.TabIndex = 28;
            this.lblJob.Text = "Job Title:";
            // 
            // lblLastN
            // 
            this.lblLastN.AutoSize = true;
            this.lblLastN.Location = new System.Drawing.Point(168, 105);
            this.lblLastN.Name = "lblLastN";
            this.lblLastN.Size = new System.Drawing.Size(65, 12);
            this.lblLastN.TabIndex = 27;
            this.lblLastN.Text = "Last Name:";
            // 
            // lblFirstN
            // 
            this.lblFirstN.AutoSize = true;
            this.lblFirstN.Location = new System.Drawing.Point(162, 70);
            this.lblFirstN.Name = "lblFirstN";
            this.lblFirstN.Size = new System.Drawing.Size(71, 12);
            this.lblFirstN.TabIndex = 26;
            this.lblFirstN.Text = "First Name:";
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.Location = new System.Drawing.Point(239, 32);
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.Size = new System.Drawing.Size(50, 21);
            this.txtEmployeeID.TabIndex = 25;
            // 
            // lblEmployeeID
            // 
            this.lblEmployeeID.AutoSize = true;
            this.lblEmployeeID.Location = new System.Drawing.Point(156, 35);
            this.lblEmployeeID.Name = "lblEmployeeID";
            this.lblEmployeeID.Size = new System.Drawing.Size(77, 12);
            this.lblEmployeeID.TabIndex = 24;
            this.lblEmployeeID.Text = "Employee ID:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(192, 210);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(41, 12);
            this.lblEmail.TabIndex = 34;
            this.lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(239, 207);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(200, 21);
            this.txtEmail.TabIndex = 35;
            // 
            // pnlAddEmployee
            // 
            this.pnlAddEmployee.Controls.Add(this.btnCancel);
            this.pnlAddEmployee.Controls.Add(this.btnSaveEmployee);
            this.pnlAddEmployee.Controls.Add(this.txtAddEmail);
            this.pnlAddEmployee.Controls.Add(this.lblAddEmail);
            this.pnlAddEmployee.Controls.Add(this.txtAddExt);
            this.pnlAddEmployee.Controls.Add(this.lblAddExt);
            this.pnlAddEmployee.Controls.Add(this.txtAddJob);
            this.pnlAddEmployee.Controls.Add(this.txtAddFirstN);
            this.pnlAddEmployee.Controls.Add(this.txtAddLastN);
            this.pnlAddEmployee.Controls.Add(this.lblAddJob);
            this.pnlAddEmployee.Controls.Add(this.lblAddLastN);
            this.pnlAddEmployee.Controls.Add(this.lblAddFirstN);
            this.pnlAddEmployee.Location = new System.Drawing.Point(25, 302);
            this.pnlAddEmployee.Name = "pnlAddEmployee";
            this.pnlAddEmployee.Size = new System.Drawing.Size(356, 220);
            this.pnlAddEmployee.TabIndex = 36;
            this.pnlAddEmployee.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(231, 185);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 23);
            this.btnCancel.TabIndex = 47;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSaveEmployee
            // 
            this.btnSaveEmployee.Location = new System.Drawing.Point(22, 185);
            this.btnSaveEmployee.Name = "btnSaveEmployee";
            this.btnSaveEmployee.Size = new System.Drawing.Size(100, 23);
            this.btnSaveEmployee.TabIndex = 46;
            this.btnSaveEmployee.Text = "Save Employee";
            this.btnSaveEmployee.UseVisualStyleBackColor = true;
            this.btnSaveEmployee.Click += new System.EventHandler(this.btnSaveEmployee_Click);
            // 
            // txtAddEmail
            // 
            this.txtAddEmail.Location = new System.Drawing.Point(114, 153);
            this.txtAddEmail.Name = "txtAddEmail";
            this.txtAddEmail.Size = new System.Drawing.Size(200, 21);
            this.txtAddEmail.TabIndex = 45;
            // 
            // lblAddEmail
            // 
            this.lblAddEmail.AutoSize = true;
            this.lblAddEmail.Location = new System.Drawing.Point(67, 156);
            this.lblAddEmail.Name = "lblAddEmail";
            this.lblAddEmail.Size = new System.Drawing.Size(41, 12);
            this.lblAddEmail.TabIndex = 44;
            this.lblAddEmail.Text = "Email:";
            // 
            // txtAddExt
            // 
            this.txtAddExt.Location = new System.Drawing.Point(114, 118);
            this.txtAddExt.Name = "txtAddExt";
            this.txtAddExt.Size = new System.Drawing.Size(100, 21);
            this.txtAddExt.TabIndex = 43;
            // 
            // lblAddExt
            // 
            this.lblAddExt.AutoSize = true;
            this.lblAddExt.Location = new System.Drawing.Point(31, 121);
            this.lblAddExt.Name = "lblAddExt";
            this.lblAddExt.Size = new System.Drawing.Size(77, 12);
            this.lblAddExt.TabIndex = 42;
            this.lblAddExt.Text = "Ext. Number:";
            // 
            // txtAddJob
            // 
            this.txtAddJob.Location = new System.Drawing.Point(114, 83);
            this.txtAddJob.Name = "txtAddJob";
            this.txtAddJob.Size = new System.Drawing.Size(100, 21);
            this.txtAddJob.TabIndex = 41;
            // 
            // txtAddFirstN
            // 
            this.txtAddFirstN.Location = new System.Drawing.Point(114, 13);
            this.txtAddFirstN.Name = "txtAddFirstN";
            this.txtAddFirstN.Size = new System.Drawing.Size(100, 21);
            this.txtAddFirstN.TabIndex = 40;
            // 
            // txtAddLastN
            // 
            this.txtAddLastN.Location = new System.Drawing.Point(114, 48);
            this.txtAddLastN.Name = "txtAddLastN";
            this.txtAddLastN.Size = new System.Drawing.Size(100, 21);
            this.txtAddLastN.TabIndex = 39;
            // 
            // lblAddJob
            // 
            this.lblAddJob.AutoSize = true;
            this.lblAddJob.Location = new System.Drawing.Point(43, 86);
            this.lblAddJob.Name = "lblAddJob";
            this.lblAddJob.Size = new System.Drawing.Size(65, 12);
            this.lblAddJob.TabIndex = 38;
            this.lblAddJob.Text = "Job Title:";
            // 
            // lblAddLastN
            // 
            this.lblAddLastN.AutoSize = true;
            this.lblAddLastN.Location = new System.Drawing.Point(43, 51);
            this.lblAddLastN.Name = "lblAddLastN";
            this.lblAddLastN.Size = new System.Drawing.Size(65, 12);
            this.lblAddLastN.TabIndex = 37;
            this.lblAddLastN.Text = "Last Name:";
            // 
            // lblAddFirstN
            // 
            this.lblAddFirstN.AutoSize = true;
            this.lblAddFirstN.Location = new System.Drawing.Point(37, 16);
            this.lblAddFirstN.Name = "lblAddFirstN";
            this.lblAddFirstN.Size = new System.Drawing.Size(71, 12);
            this.lblAddFirstN.TabIndex = 36;
            this.lblAddFirstN.Text = "First Name:";
            // 
            // pnlUpdateEmployee
            // 
            this.pnlUpdateEmployee.Controls.Add(this.btnCancel2);
            this.pnlUpdateEmployee.Controls.Add(this.btnSaveChanges);
            this.pnlUpdateEmployee.Controls.Add(this.txtUpdateEmail);
            this.pnlUpdateEmployee.Controls.Add(this.lblUpdateEmail);
            this.pnlUpdateEmployee.Controls.Add(this.txtUpdateExt);
            this.pnlUpdateEmployee.Controls.Add(this.lblUpdateExt);
            this.pnlUpdateEmployee.Controls.Add(this.txtUpdateJob);
            this.pnlUpdateEmployee.Controls.Add(this.txtUpdateFirstN);
            this.pnlUpdateEmployee.Controls.Add(this.txtUpdateLastN);
            this.pnlUpdateEmployee.Controls.Add(this.lblUpdateJob);
            this.pnlUpdateEmployee.Controls.Add(this.lblUpdateLastN);
            this.pnlUpdateEmployee.Controls.Add(this.lblUpdateFirstN);
            this.pnlUpdateEmployee.Location = new System.Drawing.Point(148, 25);
            this.pnlUpdateEmployee.Name = "pnlUpdateEmployee";
            this.pnlUpdateEmployee.Size = new System.Drawing.Size(356, 220);
            this.pnlUpdateEmployee.TabIndex = 48;
            this.pnlUpdateEmployee.Visible = false;
            // 
            // btnCancel2
            // 
            this.btnCancel2.Location = new System.Drawing.Point(234, 185);
            this.btnCancel2.Name = "btnCancel2";
            this.btnCancel2.Size = new System.Drawing.Size(100, 23);
            this.btnCancel2.TabIndex = 47;
            this.btnCancel2.Text = "Cancel";
            this.btnCancel2.UseVisualStyleBackColor = true;
            this.btnCancel2.Click += new System.EventHandler(this.btnCancel2_Click);
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Location = new System.Drawing.Point(22, 185);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(100, 23);
            this.btnSaveChanges.TabIndex = 46;
            this.btnSaveChanges.Text = "Save Changes";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // txtUpdateEmail
            // 
            this.txtUpdateEmail.Location = new System.Drawing.Point(114, 153);
            this.txtUpdateEmail.Name = "txtUpdateEmail";
            this.txtUpdateEmail.Size = new System.Drawing.Size(200, 21);
            this.txtUpdateEmail.TabIndex = 45;
            // 
            // lblUpdateEmail
            // 
            this.lblUpdateEmail.AutoSize = true;
            this.lblUpdateEmail.Location = new System.Drawing.Point(67, 156);
            this.lblUpdateEmail.Name = "lblUpdateEmail";
            this.lblUpdateEmail.Size = new System.Drawing.Size(41, 12);
            this.lblUpdateEmail.TabIndex = 44;
            this.lblUpdateEmail.Text = "Email:";
            // 
            // txtUpdateExt
            // 
            this.txtUpdateExt.Location = new System.Drawing.Point(114, 118);
            this.txtUpdateExt.Name = "txtUpdateExt";
            this.txtUpdateExt.Size = new System.Drawing.Size(100, 21);
            this.txtUpdateExt.TabIndex = 43;
            // 
            // lblUpdateExt
            // 
            this.lblUpdateExt.AutoSize = true;
            this.lblUpdateExt.Location = new System.Drawing.Point(31, 121);
            this.lblUpdateExt.Name = "lblUpdateExt";
            this.lblUpdateExt.Size = new System.Drawing.Size(77, 12);
            this.lblUpdateExt.TabIndex = 42;
            this.lblUpdateExt.Text = "Ext. Number:";
            // 
            // txtUpdateJob
            // 
            this.txtUpdateJob.Location = new System.Drawing.Point(114, 83);
            this.txtUpdateJob.Name = "txtUpdateJob";
            this.txtUpdateJob.Size = new System.Drawing.Size(100, 21);
            this.txtUpdateJob.TabIndex = 41;
            // 
            // txtUpdateFirstN
            // 
            this.txtUpdateFirstN.Location = new System.Drawing.Point(114, 13);
            this.txtUpdateFirstN.Name = "txtUpdateFirstN";
            this.txtUpdateFirstN.Size = new System.Drawing.Size(100, 21);
            this.txtUpdateFirstN.TabIndex = 40;
            // 
            // txtUpdateLastN
            // 
            this.txtUpdateLastN.Location = new System.Drawing.Point(114, 48);
            this.txtUpdateLastN.Name = "txtUpdateLastN";
            this.txtUpdateLastN.Size = new System.Drawing.Size(100, 21);
            this.txtUpdateLastN.TabIndex = 39;
            // 
            // lblUpdateJob
            // 
            this.lblUpdateJob.AutoSize = true;
            this.lblUpdateJob.Location = new System.Drawing.Point(43, 86);
            this.lblUpdateJob.Name = "lblUpdateJob";
            this.lblUpdateJob.Size = new System.Drawing.Size(65, 12);
            this.lblUpdateJob.TabIndex = 38;
            this.lblUpdateJob.Text = "Job Title:";
            // 
            // lblUpdateLastN
            // 
            this.lblUpdateLastN.AutoSize = true;
            this.lblUpdateLastN.Location = new System.Drawing.Point(43, 51);
            this.lblUpdateLastN.Name = "lblUpdateLastN";
            this.lblUpdateLastN.Size = new System.Drawing.Size(65, 12);
            this.lblUpdateLastN.TabIndex = 37;
            this.lblUpdateLastN.Text = "Last Name:";
            // 
            // lblUpdateFirstN
            // 
            this.lblUpdateFirstN.AutoSize = true;
            this.lblUpdateFirstN.Location = new System.Drawing.Point(37, 16);
            this.lblUpdateFirstN.Name = "lblUpdateFirstN";
            this.lblUpdateFirstN.Size = new System.Drawing.Size(71, 12);
            this.lblUpdateFirstN.TabIndex = 36;
            this.lblUpdateFirstN.Text = "First Name:";
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 337);
            this.Controls.Add(this.pnlUpdateEmployee);
            this.Controls.Add(this.pnlAddEmployee);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtExt);
            this.Controls.Add(this.lblExt);
            this.Controls.Add(this.txtJob);
            this.Controls.Add(this.txtFirstN);
            this.Controls.Add(this.txtLastN);
            this.Controls.Add(this.lblJob);
            this.Controls.Add(this.lblLastN);
            this.Controls.Add(this.lblFirstN);
            this.Controls.Add(this.txtEmployeeID);
            this.Controls.Add(this.lblEmployeeID);
            this.Controls.Add(this.btnDeleteEmployee);
            this.Controls.Add(this.btnUpdateEmployee);
            this.Controls.Add(this.btnAddEmployee);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.lstEmployee);
            this.Name = "EmployeeForm";
            this.Text = "Employee Maintenance";
            this.pnlAddEmployee.ResumeLayout(false);
            this.pnlAddEmployee.PerformLayout();
            this.pnlUpdateEmployee.ResumeLayout(false);
            this.pnlUpdateEmployee.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstEmployee;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.Button btnUpdateEmployee;
        private System.Windows.Forms.Button btnDeleteEmployee;
        private System.Windows.Forms.TextBox txtExt;
        private System.Windows.Forms.Label lblExt;
        private System.Windows.Forms.TextBox txtJob;
        private System.Windows.Forms.TextBox txtFirstN;
        private System.Windows.Forms.TextBox txtLastN;
        private System.Windows.Forms.Label lblJob;
        private System.Windows.Forms.Label lblLastN;
        private System.Windows.Forms.Label lblFirstN;
        private System.Windows.Forms.TextBox txtEmployeeID;
        private System.Windows.Forms.Label lblEmployeeID;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Panel pnlAddEmployee;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSaveEmployee;
        private System.Windows.Forms.TextBox txtAddEmail;
        private System.Windows.Forms.Label lblAddEmail;
        private System.Windows.Forms.TextBox txtAddExt;
        private System.Windows.Forms.Label lblAddExt;
        private System.Windows.Forms.TextBox txtAddJob;
        private System.Windows.Forms.TextBox txtAddFirstN;
        private System.Windows.Forms.TextBox txtAddLastN;
        private System.Windows.Forms.Label lblAddJob;
        private System.Windows.Forms.Label lblAddLastN;
        private System.Windows.Forms.Label lblAddFirstN;
        private System.Windows.Forms.Panel pnlUpdateEmployee;
        private System.Windows.Forms.Button btnCancel2;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.TextBox txtUpdateEmail;
        private System.Windows.Forms.Label lblUpdateEmail;
        private System.Windows.Forms.TextBox txtUpdateExt;
        private System.Windows.Forms.Label lblUpdateExt;
        private System.Windows.Forms.TextBox txtUpdateJob;
        private System.Windows.Forms.TextBox txtUpdateFirstN;
        private System.Windows.Forms.TextBox txtUpdateLastN;
        private System.Windows.Forms.Label lblUpdateJob;
        private System.Windows.Forms.Label lblUpdateLastN;
        private System.Windows.Forms.Label lblUpdateFirstN;
    }
}