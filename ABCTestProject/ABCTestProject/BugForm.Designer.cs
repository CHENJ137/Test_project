namespace ABCTestProject
{
    partial class BugForm
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
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnAddBug = new System.Windows.Forms.Button();
            this.btnUpdateBug = new System.Windows.Forms.Button();
            this.btnDeleteBug = new System.Windows.Forms.Button();
            this.lblBugID = new System.Windows.Forms.Label();
            this.lblTestAbb = new System.Windows.Forms.Label();
            this.lblBugAbb = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.lblPriority = new System.Windows.Forms.Label();
            this.lblSeverity = new System.Windows.Forms.Label();
            this.lblRating = new System.Windows.Forms.Label();
            this.lblDateDetected = new System.Windows.Forms.Label();
            this.lblDateFinish = new System.Windows.Forms.Label();
            this.lblActualDate = new System.Windows.Forms.Label();
            this.lblComment = new System.Windows.Forms.Label();
            this.txtBugID = new System.Windows.Forms.TextBox();
            this.txtEmployee = new System.Windows.Forms.TextBox();
            this.txtActualDate = new System.Windows.Forms.TextBox();
            this.txtDateDetected = new System.Windows.Forms.TextBox();
            this.txtDateFinish = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.txtTestAbb = new System.Windows.Forms.TextBox();
            this.txtBugAbb = new System.Windows.Forms.TextBox();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.txtSeverityID = new System.Windows.Forms.TextBox();
            this.txtPriorityID = new System.Windows.Forms.TextBox();
            this.txtRating = new System.Windows.Forms.TextBox();
            this.txtPriorityDescription = new System.Windows.Forms.TextBox();
            this.txtSeverityDescription = new System.Windows.Forms.TextBox();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.pnlAddBug = new System.Windows.Forms.Panel();
            this.cboAddSeverity = new System.Windows.Forms.ComboBox();
            this.cboAddPriority = new System.Windows.Forms.ComboBox();
            this.cboAddTestAbb = new System.Windows.Forms.ComboBox();
            this.cboAddPriorityID = new System.Windows.Forms.ComboBox();
            this.cboAddSeverityID = new System.Windows.Forms.ComboBox();
            this.cboAddTestID = new System.Windows.Forms.ComboBox();
            this.dtpAddDFinish = new System.Windows.Forms.DateTimePicker();
            this.dtpAddDDetected = new System.Windows.Forms.DateTimePicker();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSaveTest = new System.Windows.Forms.Button();
            this.txtAddComment = new System.Windows.Forms.TextBox();
            this.txtAddBugAbb = new System.Windows.Forms.TextBox();
            this.lblAddComment = new System.Windows.Forms.Label();
            this.lblAddDFinish = new System.Windows.Forms.Label();
            this.lblAddDDetected = new System.Windows.Forms.Label();
            this.lblAddSeverity = new System.Windows.Forms.Label();
            this.lblAddPriority = new System.Windows.Forms.Label();
            this.lblAddTestAbb = new System.Windows.Forms.Label();
            this.lblAddBugAbb = new System.Windows.Forms.Label();
            this.pnlUpdateBug = new System.Windows.Forms.Panel();
            this.cboUpdateStatus = new System.Windows.Forms.ComboBox();
            this.txtUpdateSverity = new System.Windows.Forms.TextBox();
            this.txtUpdatePriority = new System.Windows.Forms.TextBox();
            this.txtUpdateDFinish = new System.Windows.Forms.TextBox();
            this.txtUpdateDDetected = new System.Windows.Forms.TextBox();
            this.txtUpdateTestAbb = new System.Windows.Forms.TextBox();
            this.lblUpdateStatus = new System.Windows.Forms.Label();
            this.lblUpdateEmployee = new System.Windows.Forms.Label();
            this.lblUpdateActualD = new System.Windows.Forms.Label();
            this.cboUpdateLastN = new System.Windows.Forms.ComboBox();
            this.cboUpdateFirstN = new System.Windows.Forms.ComboBox();
            this.cboUpdateEmployeeID = new System.Windows.Forms.ComboBox();
            this.dtpUpdateActualD = new System.Windows.Forms.DateTimePicker();
            this.btnCancel2 = new System.Windows.Forms.Button();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.txtUpdateComment = new System.Windows.Forms.TextBox();
            this.txtUpdateBugAbb = new System.Windows.Forms.TextBox();
            this.lblUpdateComment = new System.Windows.Forms.Label();
            this.lblUpdateDFinish = new System.Windows.Forms.Label();
            this.lblUpdateDDetected = new System.Windows.Forms.Label();
            this.lblUpdateSeverity = new System.Windows.Forms.Label();
            this.lblUpdatePriority = new System.Windows.Forms.Label();
            this.lblUpdateTestAbb = new System.Windows.Forms.Label();
            this.lblUpdateBugAbb = new System.Windows.Forms.Label();
            this.btnMarkOpen = new System.Windows.Forms.Button();
            this.lstBug = new System.Windows.Forms.ListBox();
            this.pnlAddBug.SuspendLayout();
            this.pnlUpdateBug.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(25, 265);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 23);
            this.btnPrevious.TabIndex = 14;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(106, 265);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 15;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(433, 302);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 23);
            this.btnReturn.TabIndex = 16;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnAddBug
            // 
            this.btnAddBug.Location = new System.Drawing.Point(196, 265);
            this.btnAddBug.Name = "btnAddBug";
            this.btnAddBug.Size = new System.Drawing.Size(100, 23);
            this.btnAddBug.TabIndex = 39;
            this.btnAddBug.Text = "Add Bug";
            this.btnAddBug.UseVisualStyleBackColor = true;
            this.btnAddBug.Click += new System.EventHandler(this.btnAddBug_Click);
            // 
            // btnUpdateBug
            // 
            this.btnUpdateBug.Location = new System.Drawing.Point(302, 265);
            this.btnUpdateBug.Name = "btnUpdateBug";
            this.btnUpdateBug.Size = new System.Drawing.Size(100, 23);
            this.btnUpdateBug.TabIndex = 40;
            this.btnUpdateBug.Text = "Update Bug";
            this.btnUpdateBug.UseVisualStyleBackColor = true;
            this.btnUpdateBug.Click += new System.EventHandler(this.btnUpdateBug_Click);
            // 
            // btnDeleteBug
            // 
            this.btnDeleteBug.Location = new System.Drawing.Point(408, 265);
            this.btnDeleteBug.Name = "btnDeleteBug";
            this.btnDeleteBug.Size = new System.Drawing.Size(100, 23);
            this.btnDeleteBug.TabIndex = 41;
            this.btnDeleteBug.Text = "Delete Bug";
            this.btnDeleteBug.UseVisualStyleBackColor = true;
            this.btnDeleteBug.Click += new System.EventHandler(this.btnDeleteBug_Click);
            // 
            // lblBugID
            // 
            this.lblBugID.AutoSize = true;
            this.lblBugID.Location = new System.Drawing.Point(173, 30);
            this.lblBugID.Name = "lblBugID";
            this.lblBugID.Size = new System.Drawing.Size(47, 12);
            this.lblBugID.TabIndex = 42;
            this.lblBugID.Text = "Bug ID:";
            // 
            // lblTestAbb
            // 
            this.lblTestAbb.AutoSize = true;
            this.lblTestAbb.Location = new System.Drawing.Point(343, 30);
            this.lblTestAbb.Name = "lblTestAbb";
            this.lblTestAbb.Size = new System.Drawing.Size(59, 12);
            this.lblTestAbb.TabIndex = 43;
            this.lblTestAbb.Text = "Test Abb:";
            // 
            // lblBugAbb
            // 
            this.lblBugAbb.AutoSize = true;
            this.lblBugAbb.Location = new System.Drawing.Point(167, 55);
            this.lblBugAbb.Name = "lblBugAbb";
            this.lblBugAbb.Size = new System.Drawing.Size(53, 12);
            this.lblBugAbb.TabIndex = 44;
            this.lblBugAbb.Text = "Bug Abb:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(355, 55);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(47, 12);
            this.lblStatus.TabIndex = 45;
            this.lblStatus.Text = "Status:";
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Location = new System.Drawing.Point(143, 105);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(77, 12);
            this.lblEmployee.TabIndex = 46;
            this.lblEmployee.Text = "Assigned to:";
            // 
            // lblPriority
            // 
            this.lblPriority.AutoSize = true;
            this.lblPriority.Location = new System.Drawing.Point(161, 130);
            this.lblPriority.Name = "lblPriority";
            this.lblPriority.Size = new System.Drawing.Size(59, 12);
            this.lblPriority.TabIndex = 47;
            this.lblPriority.Text = "Priority:";
            // 
            // lblSeverity
            // 
            this.lblSeverity.AutoSize = true;
            this.lblSeverity.Location = new System.Drawing.Point(161, 155);
            this.lblSeverity.Name = "lblSeverity";
            this.lblSeverity.Size = new System.Drawing.Size(59, 12);
            this.lblSeverity.TabIndex = 48;
            this.lblSeverity.Text = "Severity:";
            // 
            // lblRating
            // 
            this.lblRating.AutoSize = true;
            this.lblRating.Location = new System.Drawing.Point(173, 180);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new System.Drawing.Size(47, 12);
            this.lblRating.TabIndex = 49;
            this.lblRating.Text = "Rating:";
            // 
            // lblDateDetected
            // 
            this.lblDateDetected.AutoSize = true;
            this.lblDateDetected.Location = new System.Drawing.Point(131, 80);
            this.lblDateDetected.Name = "lblDateDetected";
            this.lblDateDetected.Size = new System.Drawing.Size(89, 12);
            this.lblDateDetected.TabIndex = 50;
            this.lblDateDetected.Text = "Date Detected:";
            // 
            // lblDateFinish
            // 
            this.lblDateFinish.AutoSize = true;
            this.lblDateFinish.Location = new System.Drawing.Point(325, 80);
            this.lblDateFinish.Name = "lblDateFinish";
            this.lblDateFinish.Size = new System.Drawing.Size(77, 12);
            this.lblDateFinish.TabIndex = 51;
            this.lblDateFinish.Text = "Date Finish:";
            // 
            // lblActualDate
            // 
            this.lblActualDate.AutoSize = true;
            this.lblActualDate.Location = new System.Drawing.Point(325, 105);
            this.lblActualDate.Name = "lblActualDate";
            this.lblActualDate.Size = new System.Drawing.Size(77, 12);
            this.lblActualDate.TabIndex = 52;
            this.lblActualDate.Text = "Actual Date:";
            // 
            // lblComment
            // 
            this.lblComment.AutoSize = true;
            this.lblComment.Location = new System.Drawing.Point(167, 205);
            this.lblComment.Name = "lblComment";
            this.lblComment.Size = new System.Drawing.Size(53, 12);
            this.lblComment.TabIndex = 53;
            this.lblComment.Text = "Comment:";
            // 
            // txtBugID
            // 
            this.txtBugID.Location = new System.Drawing.Point(226, 25);
            this.txtBugID.Name = "txtBugID";
            this.txtBugID.Size = new System.Drawing.Size(40, 21);
            this.txtBugID.TabIndex = 54;
            this.txtBugID.TextChanged += new System.EventHandler(this.txtBugID_TextChanged);
            // 
            // txtEmployee
            // 
            this.txtEmployee.Location = new System.Drawing.Point(226, 102);
            this.txtEmployee.Name = "txtEmployee";
            this.txtEmployee.Size = new System.Drawing.Size(90, 21);
            this.txtEmployee.TabIndex = 55;
            // 
            // txtActualDate
            // 
            this.txtActualDate.Location = new System.Drawing.Point(406, 100);
            this.txtActualDate.Name = "txtActualDate";
            this.txtActualDate.Size = new System.Drawing.Size(80, 21);
            this.txtActualDate.TabIndex = 56;
            // 
            // txtDateDetected
            // 
            this.txtDateDetected.Location = new System.Drawing.Point(226, 77);
            this.txtDateDetected.Name = "txtDateDetected";
            this.txtDateDetected.Size = new System.Drawing.Size(80, 21);
            this.txtDateDetected.TabIndex = 57;
            // 
            // txtDateFinish
            // 
            this.txtDateFinish.Location = new System.Drawing.Point(406, 75);
            this.txtDateFinish.Name = "txtDateFinish";
            this.txtDateFinish.Size = new System.Drawing.Size(80, 21);
            this.txtDateFinish.TabIndex = 58;
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(406, 51);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(60, 21);
            this.txtStatus.TabIndex = 59;
            // 
            // txtTestAbb
            // 
            this.txtTestAbb.Location = new System.Drawing.Point(406, 25);
            this.txtTestAbb.Name = "txtTestAbb";
            this.txtTestAbb.Size = new System.Drawing.Size(60, 21);
            this.txtTestAbb.TabIndex = 60;
            // 
            // txtBugAbb
            // 
            this.txtBugAbb.Location = new System.Drawing.Point(226, 51);
            this.txtBugAbb.Name = "txtBugAbb";
            this.txtBugAbb.Size = new System.Drawing.Size(79, 21);
            this.txtBugAbb.TabIndex = 61;
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(226, 202);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(260, 43);
            this.txtComment.TabIndex = 62;
            // 
            // txtSeverityID
            // 
            this.txtSeverityID.Location = new System.Drawing.Point(226, 152);
            this.txtSeverityID.Name = "txtSeverityID";
            this.txtSeverityID.Size = new System.Drawing.Size(40, 21);
            this.txtSeverityID.TabIndex = 63;
            // 
            // txtPriorityID
            // 
            this.txtPriorityID.Location = new System.Drawing.Point(226, 127);
            this.txtPriorityID.Name = "txtPriorityID";
            this.txtPriorityID.Size = new System.Drawing.Size(40, 21);
            this.txtPriorityID.TabIndex = 64;
            // 
            // txtRating
            // 
            this.txtRating.Location = new System.Drawing.Point(226, 177);
            this.txtRating.Name = "txtRating";
            this.txtRating.Size = new System.Drawing.Size(40, 21);
            this.txtRating.TabIndex = 65;
            // 
            // txtPriorityDescription
            // 
            this.txtPriorityDescription.Location = new System.Drawing.Point(282, 127);
            this.txtPriorityDescription.Name = "txtPriorityDescription";
            this.txtPriorityDescription.Size = new System.Drawing.Size(204, 21);
            this.txtPriorityDescription.TabIndex = 66;
            // 
            // txtSeverityDescription
            // 
            this.txtSeverityDescription.Location = new System.Drawing.Point(282, 152);
            this.txtSeverityDescription.Name = "txtSeverityDescription";
            this.txtSeverityDescription.Size = new System.Drawing.Size(204, 21);
            this.txtSeverityDescription.TabIndex = 67;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(269, 157);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(11, 12);
            this.lbl2.TabIndex = 68;
            this.lbl2.Text = "-";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(269, 132);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(11, 12);
            this.lbl1.TabIndex = 69;
            this.lbl1.Text = "-";
            // 
            // pnlAddBug
            // 
            this.pnlAddBug.Controls.Add(this.cboAddSeverity);
            this.pnlAddBug.Controls.Add(this.cboAddPriority);
            this.pnlAddBug.Controls.Add(this.cboAddTestAbb);
            this.pnlAddBug.Controls.Add(this.cboAddPriorityID);
            this.pnlAddBug.Controls.Add(this.cboAddSeverityID);
            this.pnlAddBug.Controls.Add(this.cboAddTestID);
            this.pnlAddBug.Controls.Add(this.dtpAddDFinish);
            this.pnlAddBug.Controls.Add(this.dtpAddDDetected);
            this.pnlAddBug.Controls.Add(this.btnCancel);
            this.pnlAddBug.Controls.Add(this.btnSaveTest);
            this.pnlAddBug.Controls.Add(this.txtAddComment);
            this.pnlAddBug.Controls.Add(this.txtAddBugAbb);
            this.pnlAddBug.Controls.Add(this.lblAddComment);
            this.pnlAddBug.Controls.Add(this.lblAddDFinish);
            this.pnlAddBug.Controls.Add(this.lblAddDDetected);
            this.pnlAddBug.Controls.Add(this.lblAddSeverity);
            this.pnlAddBug.Controls.Add(this.lblAddPriority);
            this.pnlAddBug.Controls.Add(this.lblAddTestAbb);
            this.pnlAddBug.Controls.Add(this.lblAddBugAbb);
            this.pnlAddBug.Location = new System.Drawing.Point(70, 331);
            this.pnlAddBug.Name = "pnlAddBug";
            this.pnlAddBug.Size = new System.Drawing.Size(380, 234);
            this.pnlAddBug.TabIndex = 70;
            this.pnlAddBug.Visible = false;
            // 
            // cboAddSeverity
            // 
            this.cboAddSeverity.FormattingEnabled = true;
            this.cboAddSeverity.Location = new System.Drawing.Point(151, 137);
            this.cboAddSeverity.Name = "cboAddSeverity";
            this.cboAddSeverity.Size = new System.Drawing.Size(80, 20);
            this.cboAddSeverity.TabIndex = 73;
            // 
            // cboAddPriority
            // 
            this.cboAddPriority.FormattingEnabled = true;
            this.cboAddPriority.Location = new System.Drawing.Point(151, 112);
            this.cboAddPriority.Name = "cboAddPriority";
            this.cboAddPriority.Size = new System.Drawing.Size(80, 20);
            this.cboAddPriority.TabIndex = 72;
            // 
            // cboAddTestAbb
            // 
            this.cboAddTestAbb.FormattingEnabled = true;
            this.cboAddTestAbb.Location = new System.Drawing.Point(151, 37);
            this.cboAddTestAbb.Name = "cboAddTestAbb";
            this.cboAddTestAbb.Size = new System.Drawing.Size(80, 20);
            this.cboAddTestAbb.TabIndex = 71;
            // 
            // cboAddPriorityID
            // 
            this.cboAddPriorityID.FormattingEnabled = true;
            this.cboAddPriorityID.Location = new System.Drawing.Point(105, 112);
            this.cboAddPriorityID.Name = "cboAddPriorityID";
            this.cboAddPriorityID.Size = new System.Drawing.Size(40, 20);
            this.cboAddPriorityID.TabIndex = 70;
            // 
            // cboAddSeverityID
            // 
            this.cboAddSeverityID.FormattingEnabled = true;
            this.cboAddSeverityID.Location = new System.Drawing.Point(105, 137);
            this.cboAddSeverityID.Name = "cboAddSeverityID";
            this.cboAddSeverityID.Size = new System.Drawing.Size(40, 20);
            this.cboAddSeverityID.TabIndex = 69;
            // 
            // cboAddTestID
            // 
            this.cboAddTestID.FormattingEnabled = true;
            this.cboAddTestID.Location = new System.Drawing.Point(105, 37);
            this.cboAddTestID.Name = "cboAddTestID";
            this.cboAddTestID.Size = new System.Drawing.Size(40, 20);
            this.cboAddTestID.TabIndex = 68;
            // 
            // dtpAddDFinish
            // 
            this.dtpAddDFinish.Location = new System.Drawing.Point(105, 86);
            this.dtpAddDFinish.Name = "dtpAddDFinish";
            this.dtpAddDFinish.Size = new System.Drawing.Size(100, 21);
            this.dtpAddDFinish.TabIndex = 67;
            // 
            // dtpAddDDetected
            // 
            this.dtpAddDDetected.Location = new System.Drawing.Point(105, 59);
            this.dtpAddDDetected.Name = "dtpAddDDetected";
            this.dtpAddDDetected.Size = new System.Drawing.Size(100, 21);
            this.dtpAddDDetected.TabIndex = 66;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(265, 207);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 23);
            this.btnCancel.TabIndex = 65;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSaveTest
            // 
            this.btnSaveTest.Location = new System.Drawing.Point(25, 205);
            this.btnSaveTest.Name = "btnSaveTest";
            this.btnSaveTest.Size = new System.Drawing.Size(90, 23);
            this.btnSaveTest.TabIndex = 64;
            this.btnSaveTest.Text = "Save Bug";
            this.btnSaveTest.UseVisualStyleBackColor = true;
            this.btnSaveTest.Click += new System.EventHandler(this.btnSaveTest_Click);
            // 
            // txtAddComment
            // 
            this.txtAddComment.Location = new System.Drawing.Point(105, 162);
            this.txtAddComment.Multiline = true;
            this.txtAddComment.Name = "txtAddComment";
            this.txtAddComment.Size = new System.Drawing.Size(260, 42);
            this.txtAddComment.TabIndex = 63;
            // 
            // txtAddBugAbb
            // 
            this.txtAddBugAbb.Location = new System.Drawing.Point(105, 12);
            this.txtAddBugAbb.Name = "txtAddBugAbb";
            this.txtAddBugAbb.Size = new System.Drawing.Size(80, 21);
            this.txtAddBugAbb.TabIndex = 61;
            // 
            // lblAddComment
            // 
            this.lblAddComment.AutoSize = true;
            this.lblAddComment.Location = new System.Drawing.Point(46, 165);
            this.lblAddComment.Name = "lblAddComment";
            this.lblAddComment.Size = new System.Drawing.Size(53, 12);
            this.lblAddComment.TabIndex = 54;
            this.lblAddComment.Text = "Comment:";
            // 
            // lblAddDFinish
            // 
            this.lblAddDFinish.AutoSize = true;
            this.lblAddDFinish.Location = new System.Drawing.Point(22, 90);
            this.lblAddDFinish.Name = "lblAddDFinish";
            this.lblAddDFinish.Size = new System.Drawing.Size(77, 12);
            this.lblAddDFinish.TabIndex = 52;
            this.lblAddDFinish.Text = "Date Finish:";
            // 
            // lblAddDDetected
            // 
            this.lblAddDDetected.AutoSize = true;
            this.lblAddDDetected.Location = new System.Drawing.Point(10, 65);
            this.lblAddDDetected.Name = "lblAddDDetected";
            this.lblAddDDetected.Size = new System.Drawing.Size(89, 12);
            this.lblAddDDetected.TabIndex = 51;
            this.lblAddDDetected.Text = "Date Detected:";
            // 
            // lblAddSeverity
            // 
            this.lblAddSeverity.AutoSize = true;
            this.lblAddSeverity.Location = new System.Drawing.Point(40, 140);
            this.lblAddSeverity.Name = "lblAddSeverity";
            this.lblAddSeverity.Size = new System.Drawing.Size(59, 12);
            this.lblAddSeverity.TabIndex = 49;
            this.lblAddSeverity.Text = "Severity:";
            // 
            // lblAddPriority
            // 
            this.lblAddPriority.AutoSize = true;
            this.lblAddPriority.Location = new System.Drawing.Point(40, 115);
            this.lblAddPriority.Name = "lblAddPriority";
            this.lblAddPriority.Size = new System.Drawing.Size(59, 12);
            this.lblAddPriority.TabIndex = 48;
            this.lblAddPriority.Text = "Priority:";
            // 
            // lblAddTestAbb
            // 
            this.lblAddTestAbb.AutoSize = true;
            this.lblAddTestAbb.Location = new System.Drawing.Point(40, 40);
            this.lblAddTestAbb.Name = "lblAddTestAbb";
            this.lblAddTestAbb.Size = new System.Drawing.Size(59, 12);
            this.lblAddTestAbb.TabIndex = 46;
            this.lblAddTestAbb.Text = "Test Abb:";
            // 
            // lblAddBugAbb
            // 
            this.lblAddBugAbb.AutoSize = true;
            this.lblAddBugAbb.Location = new System.Drawing.Point(46, 15);
            this.lblAddBugAbb.Name = "lblAddBugAbb";
            this.lblAddBugAbb.Size = new System.Drawing.Size(53, 12);
            this.lblAddBugAbb.TabIndex = 45;
            this.lblAddBugAbb.Text = "Bug Abb:";
            // 
            // pnlUpdateBug
            // 
            this.pnlUpdateBug.Controls.Add(this.cboUpdateStatus);
            this.pnlUpdateBug.Controls.Add(this.txtUpdateSverity);
            this.pnlUpdateBug.Controls.Add(this.txtUpdatePriority);
            this.pnlUpdateBug.Controls.Add(this.txtUpdateDFinish);
            this.pnlUpdateBug.Controls.Add(this.txtUpdateDDetected);
            this.pnlUpdateBug.Controls.Add(this.txtUpdateTestAbb);
            this.pnlUpdateBug.Controls.Add(this.lblUpdateStatus);
            this.pnlUpdateBug.Controls.Add(this.lblUpdateEmployee);
            this.pnlUpdateBug.Controls.Add(this.lblUpdateActualD);
            this.pnlUpdateBug.Controls.Add(this.cboUpdateLastN);
            this.pnlUpdateBug.Controls.Add(this.cboUpdateFirstN);
            this.pnlUpdateBug.Controls.Add(this.cboUpdateEmployeeID);
            this.pnlUpdateBug.Controls.Add(this.dtpUpdateActualD);
            this.pnlUpdateBug.Controls.Add(this.btnCancel2);
            this.pnlUpdateBug.Controls.Add(this.btnSaveChanges);
            this.pnlUpdateBug.Controls.Add(this.txtUpdateComment);
            this.pnlUpdateBug.Controls.Add(this.txtUpdateBugAbb);
            this.pnlUpdateBug.Controls.Add(this.lblUpdateComment);
            this.pnlUpdateBug.Controls.Add(this.lblUpdateDFinish);
            this.pnlUpdateBug.Controls.Add(this.lblUpdateDDetected);
            this.pnlUpdateBug.Controls.Add(this.lblUpdateSeverity);
            this.pnlUpdateBug.Controls.Add(this.lblUpdatePriority);
            this.pnlUpdateBug.Controls.Add(this.lblUpdateTestAbb);
            this.pnlUpdateBug.Controls.Add(this.lblUpdateBugAbb);
            this.pnlUpdateBug.Location = new System.Drawing.Point(133, 25);
            this.pnlUpdateBug.Name = "pnlUpdateBug";
            this.pnlUpdateBug.Size = new System.Drawing.Size(380, 234);
            this.pnlUpdateBug.TabIndex = 74;
            this.pnlUpdateBug.Visible = false;
            // 
            // cboUpdateStatus
            // 
            this.cboUpdateStatus.FormattingEnabled = true;
            this.cboUpdateStatus.Items.AddRange(new object[] {
            "Open",
            "Closed"});
            this.cboUpdateStatus.Location = new System.Drawing.Point(105, 37);
            this.cboUpdateStatus.Name = "cboUpdateStatus";
            this.cboUpdateStatus.Size = new System.Drawing.Size(80, 20);
            this.cboUpdateStatus.TabIndex = 82;
            // 
            // txtUpdateSverity
            // 
            this.txtUpdateSverity.Location = new System.Drawing.Point(278, 136);
            this.txtUpdateSverity.Name = "txtUpdateSverity";
            this.txtUpdateSverity.Size = new System.Drawing.Size(55, 21);
            this.txtUpdateSverity.TabIndex = 81;
            // 
            // txtUpdatePriority
            // 
            this.txtUpdatePriority.Location = new System.Drawing.Point(105, 136);
            this.txtUpdatePriority.Name = "txtUpdatePriority";
            this.txtUpdatePriority.Size = new System.Drawing.Size(55, 21);
            this.txtUpdatePriority.TabIndex = 80;
            // 
            // txtUpdateDFinish
            // 
            this.txtUpdateDFinish.Location = new System.Drawing.Point(278, 59);
            this.txtUpdateDFinish.Name = "txtUpdateDFinish";
            this.txtUpdateDFinish.Size = new System.Drawing.Size(70, 21);
            this.txtUpdateDFinish.TabIndex = 79;
            // 
            // txtUpdateDDetected
            // 
            this.txtUpdateDDetected.Location = new System.Drawing.Point(105, 62);
            this.txtUpdateDDetected.Name = "txtUpdateDDetected";
            this.txtUpdateDDetected.Size = new System.Drawing.Size(70, 21);
            this.txtUpdateDDetected.TabIndex = 78;
            // 
            // txtUpdateTestAbb
            // 
            this.txtUpdateTestAbb.Location = new System.Drawing.Point(278, 12);
            this.txtUpdateTestAbb.Name = "txtUpdateTestAbb";
            this.txtUpdateTestAbb.Size = new System.Drawing.Size(60, 21);
            this.txtUpdateTestAbb.TabIndex = 77;
            // 
            // lblUpdateStatus
            // 
            this.lblUpdateStatus.AutoSize = true;
            this.lblUpdateStatus.Location = new System.Drawing.Point(52, 40);
            this.lblUpdateStatus.Name = "lblUpdateStatus";
            this.lblUpdateStatus.Size = new System.Drawing.Size(47, 12);
            this.lblUpdateStatus.TabIndex = 76;
            this.lblUpdateStatus.Text = "Status:";
            // 
            // lblUpdateEmployee
            // 
            this.lblUpdateEmployee.AutoSize = true;
            this.lblUpdateEmployee.Location = new System.Drawing.Point(22, 115);
            this.lblUpdateEmployee.Name = "lblUpdateEmployee";
            this.lblUpdateEmployee.Size = new System.Drawing.Size(77, 12);
            this.lblUpdateEmployee.TabIndex = 75;
            this.lblUpdateEmployee.Text = "Assigned to:";
            // 
            // lblUpdateActualD
            // 
            this.lblUpdateActualD.AutoSize = true;
            this.lblUpdateActualD.Location = new System.Drawing.Point(22, 90);
            this.lblUpdateActualD.Name = "lblUpdateActualD";
            this.lblUpdateActualD.Size = new System.Drawing.Size(77, 12);
            this.lblUpdateActualD.TabIndex = 74;
            this.lblUpdateActualD.Text = "Actual Date:";
            // 
            // cboUpdateLastN
            // 
            this.cboUpdateLastN.FormattingEnabled = true;
            this.cboUpdateLastN.Location = new System.Drawing.Point(237, 112);
            this.cboUpdateLastN.Name = "cboUpdateLastN";
            this.cboUpdateLastN.Size = new System.Drawing.Size(80, 20);
            this.cboUpdateLastN.TabIndex = 73;
            // 
            // cboUpdateFirstN
            // 
            this.cboUpdateFirstN.FormattingEnabled = true;
            this.cboUpdateFirstN.Location = new System.Drawing.Point(151, 112);
            this.cboUpdateFirstN.Name = "cboUpdateFirstN";
            this.cboUpdateFirstN.Size = new System.Drawing.Size(80, 20);
            this.cboUpdateFirstN.TabIndex = 72;
            // 
            // cboUpdateEmployeeID
            // 
            this.cboUpdateEmployeeID.FormattingEnabled = true;
            this.cboUpdateEmployeeID.Location = new System.Drawing.Point(105, 112);
            this.cboUpdateEmployeeID.Name = "cboUpdateEmployeeID";
            this.cboUpdateEmployeeID.Size = new System.Drawing.Size(40, 20);
            this.cboUpdateEmployeeID.TabIndex = 70;
            // 
            // dtpUpdateActualD
            // 
            this.dtpUpdateActualD.Location = new System.Drawing.Point(105, 86);
            this.dtpUpdateActualD.Name = "dtpUpdateActualD";
            this.dtpUpdateActualD.Size = new System.Drawing.Size(100, 21);
            this.dtpUpdateActualD.TabIndex = 67;
            // 
            // btnCancel2
            // 
            this.btnCancel2.Location = new System.Drawing.Point(265, 207);
            this.btnCancel2.Name = "btnCancel2";
            this.btnCancel2.Size = new System.Drawing.Size(90, 23);
            this.btnCancel2.TabIndex = 65;
            this.btnCancel2.Text = "Cancel";
            this.btnCancel2.UseVisualStyleBackColor = true;
            this.btnCancel2.Click += new System.EventHandler(this.btnCancel2_Click);
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Location = new System.Drawing.Point(25, 205);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(90, 23);
            this.btnSaveChanges.TabIndex = 64;
            this.btnSaveChanges.Text = "Save Changes";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // txtUpdateComment
            // 
            this.txtUpdateComment.Location = new System.Drawing.Point(105, 162);
            this.txtUpdateComment.Multiline = true;
            this.txtUpdateComment.Name = "txtUpdateComment";
            this.txtUpdateComment.Size = new System.Drawing.Size(260, 42);
            this.txtUpdateComment.TabIndex = 63;
            // 
            // txtUpdateBugAbb
            // 
            this.txtUpdateBugAbb.Location = new System.Drawing.Point(105, 12);
            this.txtUpdateBugAbb.Name = "txtUpdateBugAbb";
            this.txtUpdateBugAbb.Size = new System.Drawing.Size(80, 21);
            this.txtUpdateBugAbb.TabIndex = 61;
            // 
            // lblUpdateComment
            // 
            this.lblUpdateComment.AutoSize = true;
            this.lblUpdateComment.Location = new System.Drawing.Point(46, 165);
            this.lblUpdateComment.Name = "lblUpdateComment";
            this.lblUpdateComment.Size = new System.Drawing.Size(53, 12);
            this.lblUpdateComment.TabIndex = 54;
            this.lblUpdateComment.Text = "Comment:";
            // 
            // lblUpdateDFinish
            // 
            this.lblUpdateDFinish.AutoSize = true;
            this.lblUpdateDFinish.Location = new System.Drawing.Point(197, 65);
            this.lblUpdateDFinish.Name = "lblUpdateDFinish";
            this.lblUpdateDFinish.Size = new System.Drawing.Size(77, 12);
            this.lblUpdateDFinish.TabIndex = 52;
            this.lblUpdateDFinish.Text = "Date Finish:";
            // 
            // lblUpdateDDetected
            // 
            this.lblUpdateDDetected.AutoSize = true;
            this.lblUpdateDDetected.Location = new System.Drawing.Point(10, 65);
            this.lblUpdateDDetected.Name = "lblUpdateDDetected";
            this.lblUpdateDDetected.Size = new System.Drawing.Size(89, 12);
            this.lblUpdateDDetected.TabIndex = 51;
            this.lblUpdateDDetected.Text = "Date Detected:";
            // 
            // lblUpdateSeverity
            // 
            this.lblUpdateSeverity.AutoSize = true;
            this.lblUpdateSeverity.Location = new System.Drawing.Point(215, 141);
            this.lblUpdateSeverity.Name = "lblUpdateSeverity";
            this.lblUpdateSeverity.Size = new System.Drawing.Size(59, 12);
            this.lblUpdateSeverity.TabIndex = 49;
            this.lblUpdateSeverity.Text = "Severity:";
            // 
            // lblUpdatePriority
            // 
            this.lblUpdatePriority.AutoSize = true;
            this.lblUpdatePriority.Location = new System.Drawing.Point(39, 140);
            this.lblUpdatePriority.Name = "lblUpdatePriority";
            this.lblUpdatePriority.Size = new System.Drawing.Size(59, 12);
            this.lblUpdatePriority.TabIndex = 48;
            this.lblUpdatePriority.Text = "Priority:";
            // 
            // lblUpdateTestAbb
            // 
            this.lblUpdateTestAbb.AutoSize = true;
            this.lblUpdateTestAbb.Location = new System.Drawing.Point(215, 15);
            this.lblUpdateTestAbb.Name = "lblUpdateTestAbb";
            this.lblUpdateTestAbb.Size = new System.Drawing.Size(59, 12);
            this.lblUpdateTestAbb.TabIndex = 46;
            this.lblUpdateTestAbb.Text = "Test Abb:";
            // 
            // lblUpdateBugAbb
            // 
            this.lblUpdateBugAbb.AutoSize = true;
            this.lblUpdateBugAbb.Location = new System.Drawing.Point(46, 15);
            this.lblUpdateBugAbb.Name = "lblUpdateBugAbb";
            this.lblUpdateBugAbb.Size = new System.Drawing.Size(53, 12);
            this.lblUpdateBugAbb.TabIndex = 45;
            this.lblUpdateBugAbb.Text = "Bug Abb:";
            // 
            // btnMarkOpen
            // 
            this.btnMarkOpen.Location = new System.Drawing.Point(24, 302);
            this.btnMarkOpen.Name = "btnMarkOpen";
            this.btnMarkOpen.Size = new System.Drawing.Size(157, 23);
            this.btnMarkOpen.TabIndex = 75;
            this.btnMarkOpen.Text = "Mark Bug As Open";
            this.btnMarkOpen.UseVisualStyleBackColor = true;
            this.btnMarkOpen.Click += new System.EventHandler(this.btnMarkOpen_Click);
            // 
            // lstBug
            // 
            this.lstBug.FormattingEnabled = true;
            this.lstBug.ItemHeight = 12;
            this.lstBug.Location = new System.Drawing.Point(25, 25);
            this.lstBug.Name = "lstBug";
            this.lstBug.Size = new System.Drawing.Size(100, 232);
            this.lstBug.TabIndex = 76;
            // 
            // BugForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 337);
            this.Controls.Add(this.lstBug);
            this.Controls.Add(this.btnMarkOpen);
            this.Controls.Add(this.pnlUpdateBug);
            this.Controls.Add(this.pnlAddBug);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.txtSeverityDescription);
            this.Controls.Add(this.txtPriorityDescription);
            this.Controls.Add(this.txtRating);
            this.Controls.Add(this.txtPriorityID);
            this.Controls.Add(this.txtSeverityID);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.txtBugAbb);
            this.Controls.Add(this.txtTestAbb);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.txtDateFinish);
            this.Controls.Add(this.txtDateDetected);
            this.Controls.Add(this.txtActualDate);
            this.Controls.Add(this.txtEmployee);
            this.Controls.Add(this.txtBugID);
            this.Controls.Add(this.lblComment);
            this.Controls.Add(this.lblActualDate);
            this.Controls.Add(this.lblDateFinish);
            this.Controls.Add(this.lblDateDetected);
            this.Controls.Add(this.lblRating);
            this.Controls.Add(this.lblSeverity);
            this.Controls.Add(this.lblPriority);
            this.Controls.Add(this.lblEmployee);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblBugAbb);
            this.Controls.Add(this.lblTestAbb);
            this.Controls.Add(this.lblBugID);
            this.Controls.Add(this.btnDeleteBug);
            this.Controls.Add(this.btnUpdateBug);
            this.Controls.Add(this.btnAddBug);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Name = "BugForm";
            this.Text = "Bug Maintenance";
            this.pnlAddBug.ResumeLayout(false);
            this.pnlAddBug.PerformLayout();
            this.pnlUpdateBug.ResumeLayout(false);
            this.pnlUpdateBug.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnAddBug;
        private System.Windows.Forms.Button btnUpdateBug;
        private System.Windows.Forms.Button btnDeleteBug;
        private System.Windows.Forms.Label lblBugID;
        private System.Windows.Forms.Label lblTestAbb;
        private System.Windows.Forms.Label lblBugAbb;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.Label lblPriority;
        private System.Windows.Forms.Label lblSeverity;
        private System.Windows.Forms.Label lblRating;
        private System.Windows.Forms.Label lblDateDetected;
        private System.Windows.Forms.Label lblDateFinish;
        private System.Windows.Forms.Label lblActualDate;
        private System.Windows.Forms.Label lblComment;
        private System.Windows.Forms.TextBox txtBugID;
        private System.Windows.Forms.TextBox txtEmployee;
        private System.Windows.Forms.TextBox txtActualDate;
        private System.Windows.Forms.TextBox txtDateDetected;
        private System.Windows.Forms.TextBox txtDateFinish;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TextBox txtTestAbb;
        private System.Windows.Forms.TextBox txtBugAbb;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.TextBox txtSeverityID;
        private System.Windows.Forms.TextBox txtPriorityID;
        private System.Windows.Forms.TextBox txtRating;
        private System.Windows.Forms.TextBox txtPriorityDescription;
        private System.Windows.Forms.TextBox txtSeverityDescription;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Panel pnlAddBug;
        private System.Windows.Forms.Label lblAddBugAbb;
        private System.Windows.Forms.Label lblAddTestAbb;
        private System.Windows.Forms.Label lblAddComment;
        private System.Windows.Forms.Label lblAddDFinish;
        private System.Windows.Forms.Label lblAddDDetected;
        private System.Windows.Forms.Label lblAddSeverity;
        private System.Windows.Forms.Label lblAddPriority;
        private System.Windows.Forms.TextBox txtAddComment;
        private System.Windows.Forms.TextBox txtAddBugAbb;
        private System.Windows.Forms.Button btnSaveTest;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cboAddSeverity;
        private System.Windows.Forms.ComboBox cboAddPriority;
        private System.Windows.Forms.ComboBox cboAddTestAbb;
        private System.Windows.Forms.ComboBox cboAddPriorityID;
        private System.Windows.Forms.ComboBox cboAddSeverityID;
        private System.Windows.Forms.ComboBox cboAddTestID;
        private System.Windows.Forms.DateTimePicker dtpAddDFinish;
        private System.Windows.Forms.DateTimePicker dtpAddDDetected;
        private System.Windows.Forms.Panel pnlUpdateBug;
        private System.Windows.Forms.Label lblUpdateStatus;
        private System.Windows.Forms.Label lblUpdateEmployee;
        private System.Windows.Forms.Label lblUpdateActualD;
        private System.Windows.Forms.ComboBox cboUpdateLastN;
        private System.Windows.Forms.ComboBox cboUpdateFirstN;
        private System.Windows.Forms.ComboBox cboUpdateEmployeeID;
        private System.Windows.Forms.DateTimePicker dtpUpdateActualD;
        private System.Windows.Forms.Button btnCancel2;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.TextBox txtUpdateComment;
        private System.Windows.Forms.TextBox txtUpdateBugAbb;
        private System.Windows.Forms.Label lblUpdateComment;
        private System.Windows.Forms.Label lblUpdateDFinish;
        private System.Windows.Forms.Label lblUpdateDDetected;
        private System.Windows.Forms.Label lblUpdateSeverity;
        private System.Windows.Forms.Label lblUpdatePriority;
        private System.Windows.Forms.Label lblUpdateTestAbb;
        private System.Windows.Forms.Label lblUpdateBugAbb;
        private System.Windows.Forms.TextBox txtUpdateSverity;
        private System.Windows.Forms.TextBox txtUpdatePriority;
        private System.Windows.Forms.TextBox txtUpdateDFinish;
        private System.Windows.Forms.TextBox txtUpdateDDetected;
        private System.Windows.Forms.TextBox txtUpdateTestAbb;
        private System.Windows.Forms.ComboBox cboUpdateStatus;
        private System.Windows.Forms.Button btnMarkOpen;
        private System.Windows.Forms.ListBox lstBug;
    }
}