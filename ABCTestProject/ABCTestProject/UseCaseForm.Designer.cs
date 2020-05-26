namespace ABCTestProject
{
    partial class UseCaseForm
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
            this.lstUseCase = new System.Windows.Forms.ListBox();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnAddUseCase = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnUpdateUseCase = new System.Windows.Forms.Button();
            this.btnDeleteUseCase = new System.Windows.Forms.Button();
            this.lblUseCaseID = new System.Windows.Forms.Label();
            this.lblUseCaseAbb = new System.Windows.Forms.Label();
            this.lblProjectName = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtUseCaseID = new System.Windows.Forms.TextBox();
            this.txtProjectName = new System.Windows.Forms.TextBox();
            this.txtUseCaseAbb = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.pnlAddUseCase = new System.Windows.Forms.Panel();
            this.Cancel = new System.Windows.Forms.Button();
            this.btnSaveUseCase = new System.Windows.Forms.Button();
            this.cboAddProjectName = new System.Windows.Forms.ComboBox();
            this.cboAddProjectID = new System.Windows.Forms.ComboBox();
            this.txtAddDescription = new System.Windows.Forms.TextBox();
            this.txtAddUseCaseAbb = new System.Windows.Forms.TextBox();
            this.lblAddDescription = new System.Windows.Forms.Label();
            this.lblAddProject = new System.Windows.Forms.Label();
            this.lblAddUseCaseAbb = new System.Windows.Forms.Label();
            this.pnlUpdateUseCase = new System.Windows.Forms.Panel();
            this.txtUpdateProjectName = new System.Windows.Forms.TextBox();
            this.btnCancel2 = new System.Windows.Forms.Button();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.txtUpdateDescription = new System.Windows.Forms.TextBox();
            this.txtUpdateUseCaseAbb = new System.Windows.Forms.TextBox();
            this.lblUpdateDescription = new System.Windows.Forms.Label();
            this.lblUpdateProjectName = new System.Windows.Forms.Label();
            this.lblUpdateUseCaseAbb = new System.Windows.Forms.Label();
            this.pnlAddUseCase.SuspendLayout();
            this.pnlUpdateUseCase.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstUseCase
            // 
            this.lstUseCase.FormattingEnabled = true;
            this.lstUseCase.ItemHeight = 12;
            this.lstUseCase.Location = new System.Drawing.Point(25, 25);
            this.lstUseCase.Name = "lstUseCase";
            this.lstUseCase.Size = new System.Drawing.Size(100, 220);
            this.lstUseCase.TabIndex = 1;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(25, 264);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 23);
            this.btnPrevious.TabIndex = 2;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(106, 264);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 7;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnAddUseCase
            // 
            this.btnAddUseCase.Location = new System.Drawing.Point(187, 264);
            this.btnAddUseCase.Name = "btnAddUseCase";
            this.btnAddUseCase.Size = new System.Drawing.Size(100, 23);
            this.btnAddUseCase.TabIndex = 8;
            this.btnAddUseCase.Text = "Add UseCase";
            this.btnAddUseCase.UseVisualStyleBackColor = true;
            this.btnAddUseCase.Click += new System.EventHandler(this.btnAddUseCase_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(424, 300);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 23);
            this.btnReturn.TabIndex = 9;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnUpdateUseCase
            // 
            this.btnUpdateUseCase.Location = new System.Drawing.Point(293, 264);
            this.btnUpdateUseCase.Name = "btnUpdateUseCase";
            this.btnUpdateUseCase.Size = new System.Drawing.Size(100, 23);
            this.btnUpdateUseCase.TabIndex = 10;
            this.btnUpdateUseCase.Text = "Update UseCase";
            this.btnUpdateUseCase.UseVisualStyleBackColor = true;
            this.btnUpdateUseCase.Click += new System.EventHandler(this.btnUpdateUseCase_Click);
            // 
            // btnDeleteUseCase
            // 
            this.btnDeleteUseCase.Location = new System.Drawing.Point(399, 264);
            this.btnDeleteUseCase.Name = "btnDeleteUseCase";
            this.btnDeleteUseCase.Size = new System.Drawing.Size(100, 23);
            this.btnDeleteUseCase.TabIndex = 11;
            this.btnDeleteUseCase.Text = "Delete UseCase";
            this.btnDeleteUseCase.UseVisualStyleBackColor = true;
            this.btnDeleteUseCase.Click += new System.EventHandler(this.btnDeleteUseCase_Click);
            // 
            // lblUseCaseID
            // 
            this.lblUseCaseID.AutoSize = true;
            this.lblUseCaseID.Location = new System.Drawing.Point(155, 50);
            this.lblUseCaseID.Name = "lblUseCaseID";
            this.lblUseCaseID.Size = new System.Drawing.Size(71, 12);
            this.lblUseCaseID.TabIndex = 12;
            this.lblUseCaseID.Text = "UseCase ID:";
            // 
            // lblUseCaseAbb
            // 
            this.lblUseCaseAbb.AutoSize = true;
            this.lblUseCaseAbb.Location = new System.Drawing.Point(149, 80);
            this.lblUseCaseAbb.Name = "lblUseCaseAbb";
            this.lblUseCaseAbb.Size = new System.Drawing.Size(77, 12);
            this.lblUseCaseAbb.TabIndex = 13;
            this.lblUseCaseAbb.Text = "UseCase Abb:";
            // 
            // lblProjectName
            // 
            this.lblProjectName.AutoSize = true;
            this.lblProjectName.Location = new System.Drawing.Point(143, 110);
            this.lblProjectName.Name = "lblProjectName";
            this.lblProjectName.Size = new System.Drawing.Size(83, 12);
            this.lblProjectName.TabIndex = 14;
            this.lblProjectName.Text = "Project Name:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(149, 140);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(77, 12);
            this.lblDescription.TabIndex = 15;
            this.lblDescription.Text = "Description:";
            // 
            // txtUseCaseID
            // 
            this.txtUseCaseID.Location = new System.Drawing.Point(232, 47);
            this.txtUseCaseID.Name = "txtUseCaseID";
            this.txtUseCaseID.Size = new System.Drawing.Size(40, 21);
            this.txtUseCaseID.TabIndex = 16;
            this.txtUseCaseID.TextChanged += new System.EventHandler(this.txtUseCaseID_TextChanged);
            // 
            // txtProjectName
            // 
            this.txtProjectName.Location = new System.Drawing.Point(232, 107);
            this.txtProjectName.Name = "txtProjectName";
            this.txtProjectName.Size = new System.Drawing.Size(150, 21);
            this.txtProjectName.TabIndex = 17;
            // 
            // txtUseCaseAbb
            // 
            this.txtUseCaseAbb.Location = new System.Drawing.Point(232, 77);
            this.txtUseCaseAbb.Name = "txtUseCaseAbb";
            this.txtUseCaseAbb.Size = new System.Drawing.Size(60, 21);
            this.txtUseCaseAbb.TabIndex = 18;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(232, 137);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(267, 95);
            this.txtDescription.TabIndex = 19;
            // 
            // pnlAddUseCase
            // 
            this.pnlAddUseCase.Controls.Add(this.Cancel);
            this.pnlAddUseCase.Controls.Add(this.btnSaveUseCase);
            this.pnlAddUseCase.Controls.Add(this.cboAddProjectName);
            this.pnlAddUseCase.Controls.Add(this.cboAddProjectID);
            this.pnlAddUseCase.Controls.Add(this.txtAddDescription);
            this.pnlAddUseCase.Controls.Add(this.txtAddUseCaseAbb);
            this.pnlAddUseCase.Controls.Add(this.lblAddDescription);
            this.pnlAddUseCase.Controls.Add(this.lblAddProject);
            this.pnlAddUseCase.Controls.Add(this.lblAddUseCaseAbb);
            this.pnlAddUseCase.Location = new System.Drawing.Point(12, 300);
            this.pnlAddUseCase.Name = "pnlAddUseCase";
            this.pnlAddUseCase.Size = new System.Drawing.Size(354, 220);
            this.pnlAddUseCase.TabIndex = 20;
            this.pnlAddUseCase.Visible = false;
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(239, 184);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(90, 23);
            this.Cancel.TabIndex = 8;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // btnSaveUseCase
            // 
            this.btnSaveUseCase.Location = new System.Drawing.Point(28, 183);
            this.btnSaveUseCase.Name = "btnSaveUseCase";
            this.btnSaveUseCase.Size = new System.Drawing.Size(90, 23);
            this.btnSaveUseCase.TabIndex = 7;
            this.btnSaveUseCase.Text = "Save UseCase";
            this.btnSaveUseCase.UseVisualStyleBackColor = true;
            this.btnSaveUseCase.Click += new System.EventHandler(this.btnSaveUseCase_Click);
            // 
            // cboAddProjectName
            // 
            this.cboAddProjectName.FormattingEnabled = true;
            this.cboAddProjectName.Location = new System.Drawing.Point(178, 51);
            this.cboAddProjectName.Name = "cboAddProjectName";
            this.cboAddProjectName.Size = new System.Drawing.Size(164, 20);
            this.cboAddProjectName.TabIndex = 6;
            // 
            // cboAddProjectID
            // 
            this.cboAddProjectID.FormattingEnabled = true;
            this.cboAddProjectID.Location = new System.Drawing.Point(109, 49);
            this.cboAddProjectID.Name = "cboAddProjectID";
            this.cboAddProjectID.Size = new System.Drawing.Size(63, 20);
            this.cboAddProjectID.TabIndex = 5;
            // 
            // txtAddDescription
            // 
            this.txtAddDescription.Location = new System.Drawing.Point(109, 77);
            this.txtAddDescription.Multiline = true;
            this.txtAddDescription.Name = "txtAddDescription";
            this.txtAddDescription.Size = new System.Drawing.Size(233, 94);
            this.txtAddDescription.TabIndex = 4;
            // 
            // txtAddUseCaseAbb
            // 
            this.txtAddUseCaseAbb.Location = new System.Drawing.Point(109, 17);
            this.txtAddUseCaseAbb.Name = "txtAddUseCaseAbb";
            this.txtAddUseCaseAbb.Size = new System.Drawing.Size(100, 21);
            this.txtAddUseCaseAbb.TabIndex = 3;
            // 
            // lblAddDescription
            // 
            this.lblAddDescription.AutoSize = true;
            this.lblAddDescription.Location = new System.Drawing.Point(26, 80);
            this.lblAddDescription.Name = "lblAddDescription";
            this.lblAddDescription.Size = new System.Drawing.Size(77, 12);
            this.lblAddDescription.TabIndex = 2;
            this.lblAddDescription.Text = "Description:";
            // 
            // lblAddProject
            // 
            this.lblAddProject.AutoSize = true;
            this.lblAddProject.Location = new System.Drawing.Point(50, 50);
            this.lblAddProject.Name = "lblAddProject";
            this.lblAddProject.Size = new System.Drawing.Size(53, 12);
            this.lblAddProject.TabIndex = 1;
            this.lblAddProject.Text = "Project:";
            // 
            // lblAddUseCaseAbb
            // 
            this.lblAddUseCaseAbb.AutoSize = true;
            this.lblAddUseCaseAbb.Location = new System.Drawing.Point(26, 20);
            this.lblAddUseCaseAbb.Name = "lblAddUseCaseAbb";
            this.lblAddUseCaseAbb.Size = new System.Drawing.Size(77, 12);
            this.lblAddUseCaseAbb.TabIndex = 0;
            this.lblAddUseCaseAbb.Text = "UseCase Abb:";
            // 
            // pnlUpdateUseCase
            // 
            this.pnlUpdateUseCase.Controls.Add(this.txtUpdateProjectName);
            this.pnlUpdateUseCase.Controls.Add(this.btnCancel2);
            this.pnlUpdateUseCase.Controls.Add(this.btnSaveChanges);
            this.pnlUpdateUseCase.Controls.Add(this.txtUpdateDescription);
            this.pnlUpdateUseCase.Controls.Add(this.txtUpdateUseCaseAbb);
            this.pnlUpdateUseCase.Controls.Add(this.lblUpdateDescription);
            this.pnlUpdateUseCase.Controls.Add(this.lblUpdateProjectName);
            this.pnlUpdateUseCase.Controls.Add(this.lblUpdateUseCaseAbb);
            this.pnlUpdateUseCase.Location = new System.Drawing.Point(145, 25);
            this.pnlUpdateUseCase.Name = "pnlUpdateUseCase";
            this.pnlUpdateUseCase.Size = new System.Drawing.Size(354, 220);
            this.pnlUpdateUseCase.TabIndex = 21;
            this.pnlUpdateUseCase.Visible = false;
            // 
            // txtUpdateProjectName
            // 
            this.txtUpdateProjectName.Location = new System.Drawing.Point(109, 49);
            this.txtUpdateProjectName.Name = "txtUpdateProjectName";
            this.txtUpdateProjectName.Size = new System.Drawing.Size(160, 21);
            this.txtUpdateProjectName.TabIndex = 9;
            // 
            // btnCancel2
            // 
            this.btnCancel2.Location = new System.Drawing.Point(239, 184);
            this.btnCancel2.Name = "btnCancel2";
            this.btnCancel2.Size = new System.Drawing.Size(90, 23);
            this.btnCancel2.TabIndex = 8;
            this.btnCancel2.Text = "Cancel";
            this.btnCancel2.UseVisualStyleBackColor = true;
            this.btnCancel2.Click += new System.EventHandler(this.btnCancel2_Click);
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Location = new System.Drawing.Point(28, 183);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(90, 23);
            this.btnSaveChanges.TabIndex = 7;
            this.btnSaveChanges.Text = "Save Changes";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // txtUpdateDescription
            // 
            this.txtUpdateDescription.Location = new System.Drawing.Point(109, 77);
            this.txtUpdateDescription.Multiline = true;
            this.txtUpdateDescription.Name = "txtUpdateDescription";
            this.txtUpdateDescription.Size = new System.Drawing.Size(233, 94);
            this.txtUpdateDescription.TabIndex = 4;
            // 
            // txtUpdateUseCaseAbb
            // 
            this.txtUpdateUseCaseAbb.Location = new System.Drawing.Point(109, 17);
            this.txtUpdateUseCaseAbb.Name = "txtUpdateUseCaseAbb";
            this.txtUpdateUseCaseAbb.Size = new System.Drawing.Size(100, 21);
            this.txtUpdateUseCaseAbb.TabIndex = 3;
            // 
            // lblUpdateDescription
            // 
            this.lblUpdateDescription.AutoSize = true;
            this.lblUpdateDescription.Location = new System.Drawing.Point(26, 80);
            this.lblUpdateDescription.Name = "lblUpdateDescription";
            this.lblUpdateDescription.Size = new System.Drawing.Size(77, 12);
            this.lblUpdateDescription.TabIndex = 2;
            this.lblUpdateDescription.Text = "Description:";
            // 
            // lblUpdateProjectName
            // 
            this.lblUpdateProjectName.AutoSize = true;
            this.lblUpdateProjectName.Location = new System.Drawing.Point(20, 52);
            this.lblUpdateProjectName.Name = "lblUpdateProjectName";
            this.lblUpdateProjectName.Size = new System.Drawing.Size(83, 12);
            this.lblUpdateProjectName.TabIndex = 1;
            this.lblUpdateProjectName.Text = "Project Name:";
            // 
            // lblUpdateUseCaseAbb
            // 
            this.lblUpdateUseCaseAbb.AutoSize = true;
            this.lblUpdateUseCaseAbb.Location = new System.Drawing.Point(26, 20);
            this.lblUpdateUseCaseAbb.Name = "lblUpdateUseCaseAbb";
            this.lblUpdateUseCaseAbb.Size = new System.Drawing.Size(77, 12);
            this.lblUpdateUseCaseAbb.TabIndex = 0;
            this.lblUpdateUseCaseAbb.Text = "UseCase Abb:";
            // 
            // UseCaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 337);
            this.Controls.Add(this.pnlUpdateUseCase);
            this.Controls.Add(this.pnlAddUseCase);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtUseCaseAbb);
            this.Controls.Add(this.txtProjectName);
            this.Controls.Add(this.txtUseCaseID);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblProjectName);
            this.Controls.Add(this.lblUseCaseAbb);
            this.Controls.Add(this.lblUseCaseID);
            this.Controls.Add(this.btnDeleteUseCase);
            this.Controls.Add(this.btnUpdateUseCase);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnAddUseCase);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.lstUseCase);
            this.Name = "UseCaseForm";
            this.Text = "UseCase Maintenance";
            this.pnlAddUseCase.ResumeLayout(false);
            this.pnlAddUseCase.PerformLayout();
            this.pnlUpdateUseCase.ResumeLayout(false);
            this.pnlUpdateUseCase.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstUseCase;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnAddUseCase;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnUpdateUseCase;
        private System.Windows.Forms.Button btnDeleteUseCase;
        private System.Windows.Forms.Label lblUseCaseID;
        private System.Windows.Forms.Label lblUseCaseAbb;
        private System.Windows.Forms.Label lblProjectName;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtUseCaseID;
        private System.Windows.Forms.TextBox txtProjectName;
        private System.Windows.Forms.TextBox txtUseCaseAbb;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Panel pnlAddUseCase;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button btnSaveUseCase;
        private System.Windows.Forms.ComboBox cboAddProjectName;
        private System.Windows.Forms.ComboBox cboAddProjectID;
        private System.Windows.Forms.TextBox txtAddDescription;
        private System.Windows.Forms.TextBox txtAddUseCaseAbb;
        private System.Windows.Forms.Label lblAddDescription;
        private System.Windows.Forms.Label lblAddProject;
        private System.Windows.Forms.Label lblAddUseCaseAbb;
        private System.Windows.Forms.Panel pnlUpdateUseCase;
        private System.Windows.Forms.Button btnCancel2;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.TextBox txtUpdateDescription;
        private System.Windows.Forms.TextBox txtUpdateUseCaseAbb;
        private System.Windows.Forms.Label lblUpdateDescription;
        private System.Windows.Forms.Label lblUpdateProjectName;
        private System.Windows.Forms.Label lblUpdateUseCaseAbb;
        private System.Windows.Forms.TextBox txtUpdateProjectName;
    }
}