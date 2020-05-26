namespace ABCTestProject
{
    partial class TestCaseForm
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
            this.lstTestCase = new System.Windows.Forms.ListBox();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnAddTestCase = new System.Windows.Forms.Button();
            this.btnUpdateTestCase = new System.Windows.Forms.Button();
            this.btnDeleteTestCase = new System.Windows.Forms.Button();
            this.lblTestCaseID = new System.Windows.Forms.Label();
            this.txtTestCaseID = new System.Windows.Forms.TextBox();
            this.lblTestCaseAbb = new System.Windows.Forms.Label();
            this.lblUseCaseAbb = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtTestCaseAbb = new System.Windows.Forms.TextBox();
            this.txtUseCaseAbb = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.pnlAddTestCase = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSaveTestCase = new System.Windows.Forms.Button();
            this.cboAddUseCaseAbb = new System.Windows.Forms.ComboBox();
            this.cboAddUseCaseID = new System.Windows.Forms.ComboBox();
            this.txtAddDescription = new System.Windows.Forms.TextBox();
            this.txtAddTestCaseAbb = new System.Windows.Forms.TextBox();
            this.lblAddDescription = new System.Windows.Forms.Label();
            this.lblAddUseCaseAbb = new System.Windows.Forms.Label();
            this.lblAddTestCaseAbb = new System.Windows.Forms.Label();
            this.lblAddTitle = new System.Windows.Forms.Label();
            this.txtAddTitle = new System.Windows.Forms.TextBox();
            this.pnlUpdateTestCase = new System.Windows.Forms.Panel();
            this.txtUpdateTitle = new System.Windows.Forms.TextBox();
            this.lblUpdateTitle = new System.Windows.Forms.Label();
            this.btnCancel2 = new System.Windows.Forms.Button();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.txtUpdateDescription = new System.Windows.Forms.TextBox();
            this.txtUpdateTestCaseAbb = new System.Windows.Forms.TextBox();
            this.lblUpdateDescription = new System.Windows.Forms.Label();
            this.lblUpdateUseCaseAbb = new System.Windows.Forms.Label();
            this.lblUpdateTestCaseAbb = new System.Windows.Forms.Label();
            this.txtUpdateUseCaseAbb = new System.Windows.Forms.TextBox();
            this.pnlAddTestCase.SuspendLayout();
            this.pnlUpdateTestCase.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstTestCase
            // 
            this.lstTestCase.FormattingEnabled = true;
            this.lstTestCase.ItemHeight = 12;
            this.lstTestCase.Location = new System.Drawing.Point(25, 25);
            this.lstTestCase.Name = "lstTestCase";
            this.lstTestCase.Size = new System.Drawing.Size(100, 220);
            this.lstTestCase.TabIndex = 2;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(25, 264);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 23);
            this.btnPrevious.TabIndex = 3;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(106, 264);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 8;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(439, 302);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 23);
            this.btnReturn.TabIndex = 10;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnAddTestCase
            // 
            this.btnAddTestCase.Location = new System.Drawing.Point(187, 264);
            this.btnAddTestCase.Name = "btnAddTestCase";
            this.btnAddTestCase.Size = new System.Drawing.Size(105, 23);
            this.btnAddTestCase.TabIndex = 11;
            this.btnAddTestCase.Text = "Add TestCase";
            this.btnAddTestCase.UseVisualStyleBackColor = true;
            this.btnAddTestCase.Click += new System.EventHandler(this.btnAddTestCase_Click);
            // 
            // btnUpdateTestCase
            // 
            this.btnUpdateTestCase.Location = new System.Drawing.Point(298, 264);
            this.btnUpdateTestCase.Name = "btnUpdateTestCase";
            this.btnUpdateTestCase.Size = new System.Drawing.Size(105, 23);
            this.btnUpdateTestCase.TabIndex = 12;
            this.btnUpdateTestCase.Text = "Update TestCase";
            this.btnUpdateTestCase.UseVisualStyleBackColor = true;
            this.btnUpdateTestCase.Click += new System.EventHandler(this.btnUpdateTestCase_Click);
            // 
            // btnDeleteTestCase
            // 
            this.btnDeleteTestCase.Location = new System.Drawing.Point(409, 264);
            this.btnDeleteTestCase.Name = "btnDeleteTestCase";
            this.btnDeleteTestCase.Size = new System.Drawing.Size(105, 23);
            this.btnDeleteTestCase.TabIndex = 13;
            this.btnDeleteTestCase.Text = "Delete TestCase";
            this.btnDeleteTestCase.UseVisualStyleBackColor = true;
            this.btnDeleteTestCase.Click += new System.EventHandler(this.btnDeleteTestCase_Click);
            // 
            // lblTestCaseID
            // 
            this.lblTestCaseID.AutoSize = true;
            this.lblTestCaseID.Location = new System.Drawing.Point(150, 30);
            this.lblTestCaseID.Name = "lblTestCaseID";
            this.lblTestCaseID.Size = new System.Drawing.Size(77, 12);
            this.lblTestCaseID.TabIndex = 14;
            this.lblTestCaseID.Text = "TestCase ID:";
            // 
            // txtTestCaseID
            // 
            this.txtTestCaseID.Location = new System.Drawing.Point(233, 27);
            this.txtTestCaseID.Name = "txtTestCaseID";
            this.txtTestCaseID.Size = new System.Drawing.Size(40, 21);
            this.txtTestCaseID.TabIndex = 15;
            this.txtTestCaseID.TextChanged += new System.EventHandler(this.txtTestCaseID_TextChanged);
            // 
            // lblTestCaseAbb
            // 
            this.lblTestCaseAbb.AutoSize = true;
            this.lblTestCaseAbb.Location = new System.Drawing.Point(143, 60);
            this.lblTestCaseAbb.Name = "lblTestCaseAbb";
            this.lblTestCaseAbb.Size = new System.Drawing.Size(83, 12);
            this.lblTestCaseAbb.TabIndex = 16;
            this.lblTestCaseAbb.Text = "TestCase Abb:";
            // 
            // lblUseCaseAbb
            // 
            this.lblUseCaseAbb.AutoSize = true;
            this.lblUseCaseAbb.Location = new System.Drawing.Point(150, 120);
            this.lblUseCaseAbb.Name = "lblUseCaseAbb";
            this.lblUseCaseAbb.Size = new System.Drawing.Size(77, 12);
            this.lblUseCaseAbb.TabIndex = 17;
            this.lblUseCaseAbb.Text = "UseCase Abb:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(185, 90);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(41, 12);
            this.lblTitle.TabIndex = 18;
            this.lblTitle.Text = "Title:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(150, 150);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(77, 12);
            this.lblDescription.TabIndex = 19;
            this.lblDescription.Text = "Description:";
            // 
            // txtTestCaseAbb
            // 
            this.txtTestCaseAbb.Location = new System.Drawing.Point(233, 57);
            this.txtTestCaseAbb.Name = "txtTestCaseAbb";
            this.txtTestCaseAbb.Size = new System.Drawing.Size(60, 21);
            this.txtTestCaseAbb.TabIndex = 20;
            // 
            // txtUseCaseAbb
            // 
            this.txtUseCaseAbb.Location = new System.Drawing.Point(233, 117);
            this.txtUseCaseAbb.Name = "txtUseCaseAbb";
            this.txtUseCaseAbb.Size = new System.Drawing.Size(60, 21);
            this.txtUseCaseAbb.TabIndex = 21;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(233, 87);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(170, 21);
            this.txtTitle.TabIndex = 22;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(233, 147);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(270, 90);
            this.txtDescription.TabIndex = 23;
            // 
            // pnlAddTestCase
            // 
            this.pnlAddTestCase.Controls.Add(this.txtAddTitle);
            this.pnlAddTestCase.Controls.Add(this.lblAddTitle);
            this.pnlAddTestCase.Controls.Add(this.btnCancel);
            this.pnlAddTestCase.Controls.Add(this.btnSaveTestCase);
            this.pnlAddTestCase.Controls.Add(this.cboAddUseCaseAbb);
            this.pnlAddTestCase.Controls.Add(this.cboAddUseCaseID);
            this.pnlAddTestCase.Controls.Add(this.txtAddDescription);
            this.pnlAddTestCase.Controls.Add(this.txtAddTestCaseAbb);
            this.pnlAddTestCase.Controls.Add(this.lblAddDescription);
            this.pnlAddTestCase.Controls.Add(this.lblAddUseCaseAbb);
            this.pnlAddTestCase.Controls.Add(this.lblAddTestCaseAbb);
            this.pnlAddTestCase.Location = new System.Drawing.Point(12, 302);
            this.pnlAddTestCase.Name = "pnlAddTestCase";
            this.pnlAddTestCase.Size = new System.Drawing.Size(360, 220);
            this.pnlAddTestCase.TabIndex = 24;
            this.pnlAddTestCase.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(233, 183);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSaveTestCase
            // 
            this.btnSaveTestCase.Location = new System.Drawing.Point(22, 183);
            this.btnSaveTestCase.Name = "btnSaveTestCase";
            this.btnSaveTestCase.Size = new System.Drawing.Size(100, 23);
            this.btnSaveTestCase.TabIndex = 7;
            this.btnSaveTestCase.Text = "Save TestCase";
            this.btnSaveTestCase.UseVisualStyleBackColor = true;
            this.btnSaveTestCase.Click += new System.EventHandler(this.btnSaveTestCase_Click);
            // 
            // cboAddUseCaseAbb
            // 
            this.cboAddUseCaseAbb.FormattingEnabled = true;
            this.cboAddUseCaseAbb.Location = new System.Drawing.Point(178, 57);
            this.cboAddUseCaseAbb.Name = "cboAddUseCaseAbb";
            this.cboAddUseCaseAbb.Size = new System.Drawing.Size(105, 20);
            this.cboAddUseCaseAbb.TabIndex = 6;
            // 
            // cboAddUseCaseID
            // 
            this.cboAddUseCaseID.FormattingEnabled = true;
            this.cboAddUseCaseID.Location = new System.Drawing.Point(109, 57);
            this.cboAddUseCaseID.Name = "cboAddUseCaseID";
            this.cboAddUseCaseID.Size = new System.Drawing.Size(63, 20);
            this.cboAddUseCaseID.TabIndex = 5;
            // 
            // txtAddDescription
            // 
            this.txtAddDescription.Location = new System.Drawing.Point(109, 85);
            this.txtAddDescription.Multiline = true;
            this.txtAddDescription.Name = "txtAddDescription";
            this.txtAddDescription.Size = new System.Drawing.Size(235, 90);
            this.txtAddDescription.TabIndex = 4;
            // 
            // txtAddTestCaseAbb
            // 
            this.txtAddTestCaseAbb.Location = new System.Drawing.Point(109, 7);
            this.txtAddTestCaseAbb.Name = "txtAddTestCaseAbb";
            this.txtAddTestCaseAbb.Size = new System.Drawing.Size(100, 21);
            this.txtAddTestCaseAbb.TabIndex = 3;
            // 
            // lblAddDescription
            // 
            this.lblAddDescription.AutoSize = true;
            this.lblAddDescription.Location = new System.Drawing.Point(26, 85);
            this.lblAddDescription.Name = "lblAddDescription";
            this.lblAddDescription.Size = new System.Drawing.Size(77, 12);
            this.lblAddDescription.TabIndex = 2;
            this.lblAddDescription.Text = "Description:";
            // 
            // lblAddUseCaseAbb
            // 
            this.lblAddUseCaseAbb.AutoSize = true;
            this.lblAddUseCaseAbb.Location = new System.Drawing.Point(26, 60);
            this.lblAddUseCaseAbb.Name = "lblAddUseCaseAbb";
            this.lblAddUseCaseAbb.Size = new System.Drawing.Size(77, 12);
            this.lblAddUseCaseAbb.TabIndex = 1;
            this.lblAddUseCaseAbb.Text = "UseCase Abb:";
            // 
            // lblAddTestCaseAbb
            // 
            this.lblAddTestCaseAbb.AutoSize = true;
            this.lblAddTestCaseAbb.Location = new System.Drawing.Point(20, 10);
            this.lblAddTestCaseAbb.Name = "lblAddTestCaseAbb";
            this.lblAddTestCaseAbb.Size = new System.Drawing.Size(83, 12);
            this.lblAddTestCaseAbb.TabIndex = 0;
            this.lblAddTestCaseAbb.Text = "TestCase Abb:";
            // 
            // lblAddTitle
            // 
            this.lblAddTitle.AutoSize = true;
            this.lblAddTitle.Location = new System.Drawing.Point(62, 35);
            this.lblAddTitle.Name = "lblAddTitle";
            this.lblAddTitle.Size = new System.Drawing.Size(41, 12);
            this.lblAddTitle.TabIndex = 9;
            this.lblAddTitle.Text = "Title:";
            // 
            // txtAddTitle
            // 
            this.txtAddTitle.Location = new System.Drawing.Point(109, 32);
            this.txtAddTitle.Name = "txtAddTitle";
            this.txtAddTitle.Size = new System.Drawing.Size(175, 21);
            this.txtAddTitle.TabIndex = 10;
            // 
            // pnlUpdateTestCase
            // 
            this.pnlUpdateTestCase.Controls.Add(this.txtUpdateUseCaseAbb);
            this.pnlUpdateTestCase.Controls.Add(this.txtUpdateTitle);
            this.pnlUpdateTestCase.Controls.Add(this.lblUpdateTitle);
            this.pnlUpdateTestCase.Controls.Add(this.btnCancel2);
            this.pnlUpdateTestCase.Controls.Add(this.btnSaveChanges);
            this.pnlUpdateTestCase.Controls.Add(this.txtUpdateDescription);
            this.pnlUpdateTestCase.Controls.Add(this.txtUpdateTestCaseAbb);
            this.pnlUpdateTestCase.Controls.Add(this.lblUpdateDescription);
            this.pnlUpdateTestCase.Controls.Add(this.lblUpdateUseCaseAbb);
            this.pnlUpdateTestCase.Controls.Add(this.lblUpdateTestCaseAbb);
            this.pnlUpdateTestCase.Location = new System.Drawing.Point(145, 25);
            this.pnlUpdateTestCase.Name = "pnlUpdateTestCase";
            this.pnlUpdateTestCase.Size = new System.Drawing.Size(360, 220);
            this.pnlUpdateTestCase.TabIndex = 25;
            this.pnlUpdateTestCase.Visible = false;
            // 
            // txtUpdateTitle
            // 
            this.txtUpdateTitle.Location = new System.Drawing.Point(109, 32);
            this.txtUpdateTitle.Name = "txtUpdateTitle";
            this.txtUpdateTitle.Size = new System.Drawing.Size(175, 21);
            this.txtUpdateTitle.TabIndex = 10;
            // 
            // lblUpdateTitle
            // 
            this.lblUpdateTitle.AutoSize = true;
            this.lblUpdateTitle.Location = new System.Drawing.Point(62, 35);
            this.lblUpdateTitle.Name = "lblUpdateTitle";
            this.lblUpdateTitle.Size = new System.Drawing.Size(41, 12);
            this.lblUpdateTitle.TabIndex = 9;
            this.lblUpdateTitle.Text = "Title:";
            // 
            // btnCancel2
            // 
            this.btnCancel2.Location = new System.Drawing.Point(233, 183);
            this.btnCancel2.Name = "btnCancel2";
            this.btnCancel2.Size = new System.Drawing.Size(100, 23);
            this.btnCancel2.TabIndex = 8;
            this.btnCancel2.Text = "Cancel";
            this.btnCancel2.UseVisualStyleBackColor = true;
            this.btnCancel2.Click += new System.EventHandler(this.btnCancel2_Click);
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Location = new System.Drawing.Point(22, 183);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(100, 23);
            this.btnSaveChanges.TabIndex = 7;
            this.btnSaveChanges.Text = "Save Changes";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // txtUpdateDescription
            // 
            this.txtUpdateDescription.Location = new System.Drawing.Point(109, 85);
            this.txtUpdateDescription.Multiline = true;
            this.txtUpdateDescription.Name = "txtUpdateDescription";
            this.txtUpdateDescription.Size = new System.Drawing.Size(235, 90);
            this.txtUpdateDescription.TabIndex = 4;
            // 
            // txtUpdateTestCaseAbb
            // 
            this.txtUpdateTestCaseAbb.Location = new System.Drawing.Point(109, 7);
            this.txtUpdateTestCaseAbb.Name = "txtUpdateTestCaseAbb";
            this.txtUpdateTestCaseAbb.Size = new System.Drawing.Size(100, 21);
            this.txtUpdateTestCaseAbb.TabIndex = 3;
            // 
            // lblUpdateDescription
            // 
            this.lblUpdateDescription.AutoSize = true;
            this.lblUpdateDescription.Location = new System.Drawing.Point(26, 85);
            this.lblUpdateDescription.Name = "lblUpdateDescription";
            this.lblUpdateDescription.Size = new System.Drawing.Size(77, 12);
            this.lblUpdateDescription.TabIndex = 2;
            this.lblUpdateDescription.Text = "Description:";
            // 
            // lblUpdateUseCaseAbb
            // 
            this.lblUpdateUseCaseAbb.AutoSize = true;
            this.lblUpdateUseCaseAbb.Location = new System.Drawing.Point(26, 60);
            this.lblUpdateUseCaseAbb.Name = "lblUpdateUseCaseAbb";
            this.lblUpdateUseCaseAbb.Size = new System.Drawing.Size(77, 12);
            this.lblUpdateUseCaseAbb.TabIndex = 1;
            this.lblUpdateUseCaseAbb.Text = "UseCase Abb:";
            // 
            // lblUpdateTestCaseAbb
            // 
            this.lblUpdateTestCaseAbb.AutoSize = true;
            this.lblUpdateTestCaseAbb.Location = new System.Drawing.Point(20, 10);
            this.lblUpdateTestCaseAbb.Name = "lblUpdateTestCaseAbb";
            this.lblUpdateTestCaseAbb.Size = new System.Drawing.Size(83, 12);
            this.lblUpdateTestCaseAbb.TabIndex = 0;
            this.lblUpdateTestCaseAbb.Text = "TestCase Abb:";
            // 
            // txtUpdateUseCaseAbb
            // 
            this.txtUpdateUseCaseAbb.Location = new System.Drawing.Point(109, 58);
            this.txtUpdateUseCaseAbb.Name = "txtUpdateUseCaseAbb";
            this.txtUpdateUseCaseAbb.Size = new System.Drawing.Size(100, 21);
            this.txtUpdateUseCaseAbb.TabIndex = 11;
            // 
            // TestCaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 337);
            this.Controls.Add(this.pnlUpdateTestCase);
            this.Controls.Add(this.pnlAddTestCase);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.txtUseCaseAbb);
            this.Controls.Add(this.txtTestCaseAbb);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblUseCaseAbb);
            this.Controls.Add(this.lblTestCaseAbb);
            this.Controls.Add(this.txtTestCaseID);
            this.Controls.Add(this.lblTestCaseID);
            this.Controls.Add(this.btnDeleteTestCase);
            this.Controls.Add(this.btnUpdateTestCase);
            this.Controls.Add(this.btnAddTestCase);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.lstTestCase);
            this.Name = "TestCaseForm";
            this.Text = "TestCase Maintenance";
            this.pnlAddTestCase.ResumeLayout(false);
            this.pnlAddTestCase.PerformLayout();
            this.pnlUpdateTestCase.ResumeLayout(false);
            this.pnlUpdateTestCase.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstTestCase;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnAddTestCase;
        private System.Windows.Forms.Button btnUpdateTestCase;
        private System.Windows.Forms.Button btnDeleteTestCase;
        private System.Windows.Forms.Label lblTestCaseID;
        private System.Windows.Forms.TextBox txtTestCaseID;
        private System.Windows.Forms.Label lblTestCaseAbb;
        private System.Windows.Forms.Label lblUseCaseAbb;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtTestCaseAbb;
        private System.Windows.Forms.TextBox txtUseCaseAbb;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Panel pnlAddTestCase;
        private System.Windows.Forms.TextBox txtAddTitle;
        private System.Windows.Forms.Label lblAddTitle;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSaveTestCase;
        private System.Windows.Forms.ComboBox cboAddUseCaseAbb;
        private System.Windows.Forms.ComboBox cboAddUseCaseID;
        private System.Windows.Forms.TextBox txtAddDescription;
        private System.Windows.Forms.TextBox txtAddTestCaseAbb;
        private System.Windows.Forms.Label lblAddDescription;
        private System.Windows.Forms.Label lblAddUseCaseAbb;
        private System.Windows.Forms.Label lblAddTestCaseAbb;
        private System.Windows.Forms.Panel pnlUpdateTestCase;
        private System.Windows.Forms.TextBox txtUpdateTitle;
        private System.Windows.Forms.Label lblUpdateTitle;
        private System.Windows.Forms.Button btnCancel2;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.TextBox txtUpdateDescription;
        private System.Windows.Forms.TextBox txtUpdateTestCaseAbb;
        private System.Windows.Forms.Label lblUpdateDescription;
        private System.Windows.Forms.Label lblUpdateUseCaseAbb;
        private System.Windows.Forms.Label lblUpdateTestCaseAbb;
        private System.Windows.Forms.TextBox txtUpdateUseCaseAbb;
    }
}