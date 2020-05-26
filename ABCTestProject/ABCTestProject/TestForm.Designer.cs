namespace ABCTestProject
{
    partial class TestForm
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
            this.lstTest = new System.Windows.Forms.ListBox();
            this.lblTestAbb = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblHardware = new System.Windows.Forms.Label();
            this.lblSystem = new System.Windows.Forms.Label();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.lblSteps = new System.Windows.Forms.Label();
            this.lblTestID = new System.Windows.Forms.Label();
            this.lblTestCaseAbb = new System.Windows.Forms.Label();
            this.lblDateStart = new System.Windows.Forms.Label();
            this.lblDateEnd = new System.Windows.Forms.Label();
            this.lblComment = new System.Windows.Forms.Label();
            this.groConfigure = new System.Windows.Forms.GroupBox();
            this.txtHardware = new System.Windows.Forms.TextBox();
            this.txtSystem = new System.Windows.Forms.TextBox();
            this.txtDateStart = new System.Windows.Forms.TextBox();
            this.txtSteps = new System.Windows.Forms.TextBox();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.txtDateEnd = new System.Windows.Forms.TextBox();
            this.txtEmployee = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.txtTestAbb = new System.Windows.Forms.TextBox();
            this.txtTestCaseAbb = new System.Windows.Forms.TextBox();
            this.txtTestID = new System.Windows.Forms.TextBox();
            this.btnAddTest = new System.Windows.Forms.Button();
            this.btnUpdateTest = new System.Windows.Forms.Button();
            this.btnDeleteTest = new System.Windows.Forms.Button();
            this.pnlAddTest = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSaveTest = new System.Windows.Forms.Button();
            this.cboAddSystem = new System.Windows.Forms.ComboBox();
            this.cboAddHardware = new System.Windows.Forms.ComboBox();
            this.cboAddConfigureID = new System.Windows.Forms.ComboBox();
            this.cboAddCategoryName = new System.Windows.Forms.ComboBox();
            this.cboAddCategoryID = new System.Windows.Forms.ComboBox();
            this.cboAddTCAbb = new System.Windows.Forms.ComboBox();
            this.cboAddTCID = new System.Windows.Forms.ComboBox();
            this.cboAddLastN = new System.Windows.Forms.ComboBox();
            this.cboAddFirstN = new System.Windows.Forms.ComboBox();
            this.cboAddEmployeeID = new System.Windows.Forms.ComboBox();
            this.dtpAddDStart = new System.Windows.Forms.DateTimePicker();
            this.txtAddTestAbb = new System.Windows.Forms.TextBox();
            this.txtAddSteps = new System.Windows.Forms.TextBox();
            this.lblAddSteps = new System.Windows.Forms.Label();
            this.lblAddDateStart = new System.Windows.Forms.Label();
            this.lblAddEmployee = new System.Windows.Forms.Label();
            this.lblAddConfigure = new System.Windows.Forms.Label();
            this.lblAddCategory = new System.Windows.Forms.Label();
            this.lblAddTestCaseAbb = new System.Windows.Forms.Label();
            this.lblAddTestAbb = new System.Windows.Forms.Label();
            this.pnlUpdateTest = new System.Windows.Forms.Panel();
            this.txtUpdateCategory = new System.Windows.Forms.TextBox();
            this.txtUpdateComment = new System.Windows.Forms.TextBox();
            this.lblUpdateComment = new System.Windows.Forms.Label();
            this.lblUpdateDEnd = new System.Windows.Forms.Label();
            this.txtUpdateEmployee = new System.Windows.Forms.TextBox();
            this.txtUpdateDStart = new System.Windows.Forms.TextBox();
            this.grpUpdateConfigure = new System.Windows.Forms.GroupBox();
            this.lblUpdateHardware = new System.Windows.Forms.Label();
            this.lblUpdateSystem = new System.Windows.Forms.Label();
            this.txtUpdateHardware = new System.Windows.Forms.TextBox();
            this.txtUpdateSystem = new System.Windows.Forms.TextBox();
            this.txtUpdateTCAbb = new System.Windows.Forms.TextBox();
            this.btnCancel2 = new System.Windows.Forms.Button();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.cboUpdateStatus = new System.Windows.Forms.ComboBox();
            this.dtpDEnd = new System.Windows.Forms.DateTimePicker();
            this.txtUpdateTestAbb = new System.Windows.Forms.TextBox();
            this.txtUpdateSteps = new System.Windows.Forms.TextBox();
            this.lblUpdateSteps = new System.Windows.Forms.Label();
            this.lblUpdateDStart = new System.Windows.Forms.Label();
            this.lblUpdateEmployee = new System.Windows.Forms.Label();
            this.lblUpdateStatus = new System.Windows.Forms.Label();
            this.lblUpdateCategory = new System.Windows.Forms.Label();
            this.lblUpdateTCAbb = new System.Windows.Forms.Label();
            this.lblUpdateTestAbb = new System.Windows.Forms.Label();
            this.groConfigure.SuspendLayout();
            this.pnlAddTest.SuspendLayout();
            this.pnlUpdateTest.SuspendLayout();
            this.grpUpdateConfigure.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(25, 265);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 23);
            this.btnPrevious.TabIndex = 4;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(106, 265);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 9;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(424, 302);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 23);
            this.btnReturn.TabIndex = 11;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // lstTest
            // 
            this.lstTest.FormattingEnabled = true;
            this.lstTest.ItemHeight = 12;
            this.lstTest.Location = new System.Drawing.Point(25, 25);
            this.lstTest.Name = "lstTest";
            this.lstTest.Size = new System.Drawing.Size(100, 220);
            this.lstTest.TabIndex = 12;
            // 
            // lblTestAbb
            // 
            this.lblTestAbb.AutoSize = true;
            this.lblTestAbb.Location = new System.Drawing.Point(148, 50);
            this.lblTestAbb.Name = "lblTestAbb";
            this.lblTestAbb.Size = new System.Drawing.Size(59, 12);
            this.lblTestAbb.TabIndex = 13;
            this.lblTestAbb.Text = "Test Abb:";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(148, 75);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(59, 12);
            this.lblCategory.TabIndex = 14;
            this.lblCategory.Text = "Category:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(160, 100);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(47, 12);
            this.lblStatus.TabIndex = 15;
            this.lblStatus.Text = "Status:";
            // 
            // lblHardware
            // 
            this.lblHardware.AutoSize = true;
            this.lblHardware.Location = new System.Drawing.Point(23, 15);
            this.lblHardware.Name = "lblHardware";
            this.lblHardware.Size = new System.Drawing.Size(89, 12);
            this.lblHardware.TabIndex = 16;
            this.lblHardware.Text = "Hardware Name:";
            // 
            // lblSystem
            // 
            this.lblSystem.AutoSize = true;
            this.lblSystem.Location = new System.Drawing.Point(5, 40);
            this.lblSystem.Name = "lblSystem";
            this.lblSystem.Size = new System.Drawing.Size(107, 12);
            this.lblSystem.TabIndex = 17;
            this.lblSystem.Text = "Operating System:";
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Location = new System.Drawing.Point(142, 125);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(65, 12);
            this.lblEmployee.TabIndex = 18;
            this.lblEmployee.Text = "Tested By:";
            // 
            // lblSteps
            // 
            this.lblSteps.AutoSize = true;
            this.lblSteps.Location = new System.Drawing.Point(166, 175);
            this.lblSteps.Name = "lblSteps";
            this.lblSteps.Size = new System.Drawing.Size(41, 12);
            this.lblSteps.TabIndex = 19;
            this.lblSteps.Text = "Steps:";
            // 
            // lblTestID
            // 
            this.lblTestID.AutoSize = true;
            this.lblTestID.Location = new System.Drawing.Point(154, 25);
            this.lblTestID.Name = "lblTestID";
            this.lblTestID.Size = new System.Drawing.Size(53, 12);
            this.lblTestID.TabIndex = 20;
            this.lblTestID.Text = "Test ID:";
            // 
            // lblTestCaseAbb
            // 
            this.lblTestCaseAbb.AutoSize = true;
            this.lblTestCaseAbb.Location = new System.Drawing.Point(324, 25);
            this.lblTestCaseAbb.Name = "lblTestCaseAbb";
            this.lblTestCaseAbb.Size = new System.Drawing.Size(83, 12);
            this.lblTestCaseAbb.TabIndex = 21;
            this.lblTestCaseAbb.Text = "TestCase Abb:";
            // 
            // lblDateStart
            // 
            this.lblDateStart.AutoSize = true;
            this.lblDateStart.Location = new System.Drawing.Point(136, 150);
            this.lblDateStart.Name = "lblDateStart";
            this.lblDateStart.Size = new System.Drawing.Size(71, 12);
            this.lblDateStart.TabIndex = 22;
            this.lblDateStart.Text = "Date Start:";
            // 
            // lblDateEnd
            // 
            this.lblDateEnd.AutoSize = true;
            this.lblDateEnd.Location = new System.Drawing.Point(347, 151);
            this.lblDateEnd.Name = "lblDateEnd";
            this.lblDateEnd.Size = new System.Drawing.Size(59, 12);
            this.lblDateEnd.TabIndex = 23;
            this.lblDateEnd.Text = "Date End:";
            // 
            // lblComment
            // 
            this.lblComment.AutoSize = true;
            this.lblComment.Location = new System.Drawing.Point(154, 236);
            this.lblComment.Name = "lblComment";
            this.lblComment.Size = new System.Drawing.Size(53, 12);
            this.lblComment.TabIndex = 24;
            this.lblComment.Text = "Comment:";
            // 
            // groConfigure
            // 
            this.groConfigure.Controls.Add(this.lblHardware);
            this.groConfigure.Controls.Add(this.lblSystem);
            this.groConfigure.Controls.Add(this.txtHardware);
            this.groConfigure.Controls.Add(this.txtSystem);
            this.groConfigure.Location = new System.Drawing.Point(294, 59);
            this.groConfigure.Name = "groConfigure";
            this.groConfigure.Size = new System.Drawing.Size(200, 63);
            this.groConfigure.TabIndex = 25;
            this.groConfigure.TabStop = false;
            this.groConfigure.Text = "Configure";
            // 
            // txtHardware
            // 
            this.txtHardware.Location = new System.Drawing.Point(112, 12);
            this.txtHardware.Name = "txtHardware";
            this.txtHardware.Size = new System.Drawing.Size(82, 21);
            this.txtHardware.TabIndex = 32;
            // 
            // txtSystem
            // 
            this.txtSystem.Location = new System.Drawing.Point(112, 37);
            this.txtSystem.Name = "txtSystem";
            this.txtSystem.Size = new System.Drawing.Size(82, 21);
            this.txtSystem.TabIndex = 26;
            // 
            // txtDateStart
            // 
            this.txtDateStart.Location = new System.Drawing.Point(213, 147);
            this.txtDateStart.Name = "txtDateStart";
            this.txtDateStart.Size = new System.Drawing.Size(90, 21);
            this.txtDateStart.TabIndex = 27;
            // 
            // txtSteps
            // 
            this.txtSteps.Location = new System.Drawing.Point(213, 172);
            this.txtSteps.Multiline = true;
            this.txtSteps.Name = "txtSteps";
            this.txtSteps.Size = new System.Drawing.Size(281, 55);
            this.txtSteps.TabIndex = 28;
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(213, 233);
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(281, 21);
            this.txtComment.TabIndex = 29;
            // 
            // txtDateEnd
            // 
            this.txtDateEnd.Location = new System.Drawing.Point(405, 148);
            this.txtDateEnd.Name = "txtDateEnd";
            this.txtDateEnd.Size = new System.Drawing.Size(88, 21);
            this.txtDateEnd.TabIndex = 30;
            // 
            // txtEmployee
            // 
            this.txtEmployee.Location = new System.Drawing.Point(213, 122);
            this.txtEmployee.Name = "txtEmployee";
            this.txtEmployee.Size = new System.Drawing.Size(90, 21);
            this.txtEmployee.TabIndex = 31;
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(213, 97);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(59, 21);
            this.txtStatus.TabIndex = 33;
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(213, 72);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(83, 21);
            this.txtCategory.TabIndex = 34;
            // 
            // txtTestAbb
            // 
            this.txtTestAbb.Location = new System.Drawing.Point(213, 47);
            this.txtTestAbb.Name = "txtTestAbb";
            this.txtTestAbb.Size = new System.Drawing.Size(70, 21);
            this.txtTestAbb.TabIndex = 35;
            // 
            // txtTestCaseAbb
            // 
            this.txtTestCaseAbb.Location = new System.Drawing.Point(406, 22);
            this.txtTestCaseAbb.Name = "txtTestCaseAbb";
            this.txtTestCaseAbb.Size = new System.Drawing.Size(59, 21);
            this.txtTestCaseAbb.TabIndex = 36;
            // 
            // txtTestID
            // 
            this.txtTestID.Location = new System.Drawing.Point(213, 22);
            this.txtTestID.Name = "txtTestID";
            this.txtTestID.Size = new System.Drawing.Size(40, 21);
            this.txtTestID.TabIndex = 37;
            this.txtTestID.TextChanged += new System.EventHandler(this.txtTestID_TextChanged);
            // 
            // btnAddTest
            // 
            this.btnAddTest.Location = new System.Drawing.Point(187, 265);
            this.btnAddTest.Name = "btnAddTest";
            this.btnAddTest.Size = new System.Drawing.Size(100, 23);
            this.btnAddTest.TabIndex = 38;
            this.btnAddTest.Text = "Add Test";
            this.btnAddTest.UseVisualStyleBackColor = true;
            this.btnAddTest.Click += new System.EventHandler(this.btnAddTest_Click);
            // 
            // btnUpdateTest
            // 
            this.btnUpdateTest.Location = new System.Drawing.Point(293, 265);
            this.btnUpdateTest.Name = "btnUpdateTest";
            this.btnUpdateTest.Size = new System.Drawing.Size(100, 23);
            this.btnUpdateTest.TabIndex = 39;
            this.btnUpdateTest.Text = "Update Test";
            this.btnUpdateTest.UseVisualStyleBackColor = true;
            this.btnUpdateTest.Click += new System.EventHandler(this.btnUpdateTest_Click);
            // 
            // btnDeleteTest
            // 
            this.btnDeleteTest.Location = new System.Drawing.Point(399, 265);
            this.btnDeleteTest.Name = "btnDeleteTest";
            this.btnDeleteTest.Size = new System.Drawing.Size(100, 23);
            this.btnDeleteTest.TabIndex = 40;
            this.btnDeleteTest.Text = "Delete Test";
            this.btnDeleteTest.UseVisualStyleBackColor = true;
            this.btnDeleteTest.Click += new System.EventHandler(this.btnDeleteTest_Click);
            // 
            // pnlAddTest
            // 
            this.pnlAddTest.Controls.Add(this.btnCancel);
            this.pnlAddTest.Controls.Add(this.btnSaveTest);
            this.pnlAddTest.Controls.Add(this.cboAddSystem);
            this.pnlAddTest.Controls.Add(this.cboAddHardware);
            this.pnlAddTest.Controls.Add(this.cboAddConfigureID);
            this.pnlAddTest.Controls.Add(this.cboAddCategoryName);
            this.pnlAddTest.Controls.Add(this.cboAddCategoryID);
            this.pnlAddTest.Controls.Add(this.cboAddTCAbb);
            this.pnlAddTest.Controls.Add(this.cboAddTCID);
            this.pnlAddTest.Controls.Add(this.cboAddLastN);
            this.pnlAddTest.Controls.Add(this.cboAddFirstN);
            this.pnlAddTest.Controls.Add(this.cboAddEmployeeID);
            this.pnlAddTest.Controls.Add(this.dtpAddDStart);
            this.pnlAddTest.Controls.Add(this.txtAddTestAbb);
            this.pnlAddTest.Controls.Add(this.txtAddSteps);
            this.pnlAddTest.Controls.Add(this.lblAddSteps);
            this.pnlAddTest.Controls.Add(this.lblAddDateStart);
            this.pnlAddTest.Controls.Add(this.lblAddEmployee);
            this.pnlAddTest.Controls.Add(this.lblAddConfigure);
            this.pnlAddTest.Controls.Add(this.lblAddCategory);
            this.pnlAddTest.Controls.Add(this.lblAddTestCaseAbb);
            this.pnlAddTest.Controls.Add(this.lblAddTestAbb);
            this.pnlAddTest.Location = new System.Drawing.Point(162, 121);
            this.pnlAddTest.Name = "pnlAddTest";
            this.pnlAddTest.Size = new System.Drawing.Size(361, 245);
            this.pnlAddTest.TabIndex = 41;
            this.pnlAddTest.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(249, 213);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 23);
            this.btnCancel.TabIndex = 50;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSaveTest
            // 
            this.btnSaveTest.Location = new System.Drawing.Point(19, 213);
            this.btnSaveTest.Name = "btnSaveTest";
            this.btnSaveTest.Size = new System.Drawing.Size(90, 23);
            this.btnSaveTest.TabIndex = 42;
            this.btnSaveTest.Text = "Save Test";
            this.btnSaveTest.UseVisualStyleBackColor = true;
            this.btnSaveTest.Click += new System.EventHandler(this.btnSaveTest_Click);
            // 
            // cboAddSystem
            // 
            this.cboAddSystem.FormattingEnabled = true;
            this.cboAddSystem.Location = new System.Drawing.Point(226, 62);
            this.cboAddSystem.Name = "cboAddSystem";
            this.cboAddSystem.Size = new System.Drawing.Size(80, 20);
            this.cboAddSystem.TabIndex = 49;
            // 
            // cboAddHardware
            // 
            this.cboAddHardware.FormattingEnabled = true;
            this.cboAddHardware.Location = new System.Drawing.Point(140, 63);
            this.cboAddHardware.Name = "cboAddHardware";
            this.cboAddHardware.Size = new System.Drawing.Size(80, 20);
            this.cboAddHardware.TabIndex = 48;
            // 
            // cboAddConfigureID
            // 
            this.cboAddConfigureID.FormattingEnabled = true;
            this.cboAddConfigureID.Location = new System.Drawing.Point(94, 62);
            this.cboAddConfigureID.Name = "cboAddConfigureID";
            this.cboAddConfigureID.Size = new System.Drawing.Size(40, 20);
            this.cboAddConfigureID.TabIndex = 47;
            // 
            // cboAddCategoryName
            // 
            this.cboAddCategoryName.FormattingEnabled = true;
            this.cboAddCategoryName.Location = new System.Drawing.Point(270, 11);
            this.cboAddCategoryName.Name = "cboAddCategoryName";
            this.cboAddCategoryName.Size = new System.Drawing.Size(85, 20);
            this.cboAddCategoryName.TabIndex = 46;
            // 
            // cboAddCategoryID
            // 
            this.cboAddCategoryID.FormattingEnabled = true;
            this.cboAddCategoryID.Location = new System.Drawing.Point(224, 11);
            this.cboAddCategoryID.Name = "cboAddCategoryID";
            this.cboAddCategoryID.Size = new System.Drawing.Size(40, 20);
            this.cboAddCategoryID.TabIndex = 45;
            // 
            // cboAddTCAbb
            // 
            this.cboAddTCAbb.FormattingEnabled = true;
            this.cboAddTCAbb.Location = new System.Drawing.Point(140, 37);
            this.cboAddTCAbb.Name = "cboAddTCAbb";
            this.cboAddTCAbb.Size = new System.Drawing.Size(80, 20);
            this.cboAddTCAbb.TabIndex = 44;
            // 
            // cboAddTCID
            // 
            this.cboAddTCID.FormattingEnabled = true;
            this.cboAddTCID.Location = new System.Drawing.Point(94, 37);
            this.cboAddTCID.Name = "cboAddTCID";
            this.cboAddTCID.Size = new System.Drawing.Size(40, 20);
            this.cboAddTCID.TabIndex = 43;
            // 
            // cboAddLastN
            // 
            this.cboAddLastN.FormattingEnabled = true;
            this.cboAddLastN.Location = new System.Drawing.Point(211, 87);
            this.cboAddLastN.Name = "cboAddLastN";
            this.cboAddLastN.Size = new System.Drawing.Size(65, 20);
            this.cboAddLastN.TabIndex = 42;
            // 
            // cboAddFirstN
            // 
            this.cboAddFirstN.FormattingEnabled = true;
            this.cboAddFirstN.Location = new System.Drawing.Point(140, 87);
            this.cboAddFirstN.Name = "cboAddFirstN";
            this.cboAddFirstN.Size = new System.Drawing.Size(65, 20);
            this.cboAddFirstN.TabIndex = 41;
            // 
            // cboAddEmployeeID
            // 
            this.cboAddEmployeeID.FormattingEnabled = true;
            this.cboAddEmployeeID.Location = new System.Drawing.Point(94, 87);
            this.cboAddEmployeeID.Name = "cboAddEmployeeID";
            this.cboAddEmployeeID.Size = new System.Drawing.Size(40, 20);
            this.cboAddEmployeeID.TabIndex = 40;
            // 
            // dtpAddDStart
            // 
            this.dtpAddDStart.Location = new System.Drawing.Point(94, 110);
            this.dtpAddDStart.Name = "dtpAddDStart";
            this.dtpAddDStart.Size = new System.Drawing.Size(111, 21);
            this.dtpAddDStart.TabIndex = 39;
            // 
            // txtAddTestAbb
            // 
            this.txtAddTestAbb.Location = new System.Drawing.Point(94, 11);
            this.txtAddTestAbb.Name = "txtAddTestAbb";
            this.txtAddTestAbb.Size = new System.Drawing.Size(59, 21);
            this.txtAddTestAbb.TabIndex = 38;
            // 
            // txtAddSteps
            // 
            this.txtAddSteps.Location = new System.Drawing.Point(94, 137);
            this.txtAddSteps.Multiline = true;
            this.txtAddSteps.Name = "txtAddSteps";
            this.txtAddSteps.Size = new System.Drawing.Size(262, 70);
            this.txtAddSteps.TabIndex = 29;
            // 
            // lblAddSteps
            // 
            this.lblAddSteps.AutoSize = true;
            this.lblAddSteps.Location = new System.Drawing.Point(47, 140);
            this.lblAddSteps.Name = "lblAddSteps";
            this.lblAddSteps.Size = new System.Drawing.Size(41, 12);
            this.lblAddSteps.TabIndex = 20;
            this.lblAddSteps.Text = "Steps:";
            // 
            // lblAddDateStart
            // 
            this.lblAddDateStart.AutoSize = true;
            this.lblAddDateStart.Location = new System.Drawing.Point(17, 115);
            this.lblAddDateStart.Name = "lblAddDateStart";
            this.lblAddDateStart.Size = new System.Drawing.Size(71, 12);
            this.lblAddDateStart.TabIndex = 19;
            this.lblAddDateStart.Text = "Date Start:";
            // 
            // lblAddEmployee
            // 
            this.lblAddEmployee.AutoSize = true;
            this.lblAddEmployee.Location = new System.Drawing.Point(23, 90);
            this.lblAddEmployee.Name = "lblAddEmployee";
            this.lblAddEmployee.Size = new System.Drawing.Size(65, 12);
            this.lblAddEmployee.TabIndex = 18;
            this.lblAddEmployee.Text = "Tested By:";
            // 
            // lblAddConfigure
            // 
            this.lblAddConfigure.AutoSize = true;
            this.lblAddConfigure.Location = new System.Drawing.Point(23, 65);
            this.lblAddConfigure.Name = "lblAddConfigure";
            this.lblAddConfigure.Size = new System.Drawing.Size(65, 12);
            this.lblAddConfigure.TabIndex = 17;
            this.lblAddConfigure.Text = "Configure:";
            // 
            // lblAddCategory
            // 
            this.lblAddCategory.AutoSize = true;
            this.lblAddCategory.Location = new System.Drawing.Point(159, 15);
            this.lblAddCategory.Name = "lblAddCategory";
            this.lblAddCategory.Size = new System.Drawing.Size(59, 12);
            this.lblAddCategory.TabIndex = 16;
            this.lblAddCategory.Text = "Category:";
            // 
            // lblAddTestCaseAbb
            // 
            this.lblAddTestCaseAbb.AutoSize = true;
            this.lblAddTestCaseAbb.Location = new System.Drawing.Point(5, 40);
            this.lblAddTestCaseAbb.Name = "lblAddTestCaseAbb";
            this.lblAddTestCaseAbb.Size = new System.Drawing.Size(83, 12);
            this.lblAddTestCaseAbb.TabIndex = 15;
            this.lblAddTestCaseAbb.Text = "TestCase Abb:";
            // 
            // lblAddTestAbb
            // 
            this.lblAddTestAbb.AutoSize = true;
            this.lblAddTestAbb.Location = new System.Drawing.Point(29, 15);
            this.lblAddTestAbb.Name = "lblAddTestAbb";
            this.lblAddTestAbb.Size = new System.Drawing.Size(59, 12);
            this.lblAddTestAbb.TabIndex = 14;
            this.lblAddTestAbb.Text = "Test Abb:";
            // 
            // pnlUpdateTest
            // 
            this.pnlUpdateTest.Controls.Add(this.txtUpdateCategory);
            this.pnlUpdateTest.Controls.Add(this.txtUpdateComment);
            this.pnlUpdateTest.Controls.Add(this.lblUpdateComment);
            this.pnlUpdateTest.Controls.Add(this.lblUpdateDEnd);
            this.pnlUpdateTest.Controls.Add(this.txtUpdateEmployee);
            this.pnlUpdateTest.Controls.Add(this.txtUpdateDStart);
            this.pnlUpdateTest.Controls.Add(this.grpUpdateConfigure);
            this.pnlUpdateTest.Controls.Add(this.txtUpdateTCAbb);
            this.pnlUpdateTest.Controls.Add(this.btnCancel2);
            this.pnlUpdateTest.Controls.Add(this.btnSaveChanges);
            this.pnlUpdateTest.Controls.Add(this.cboUpdateStatus);
            this.pnlUpdateTest.Controls.Add(this.dtpDEnd);
            this.pnlUpdateTest.Controls.Add(this.txtUpdateTestAbb);
            this.pnlUpdateTest.Controls.Add(this.txtUpdateSteps);
            this.pnlUpdateTest.Controls.Add(this.lblUpdateSteps);
            this.pnlUpdateTest.Controls.Add(this.lblUpdateDStart);
            this.pnlUpdateTest.Controls.Add(this.lblUpdateEmployee);
            this.pnlUpdateTest.Controls.Add(this.lblUpdateStatus);
            this.pnlUpdateTest.Controls.Add(this.lblUpdateCategory);
            this.pnlUpdateTest.Controls.Add(this.lblUpdateTCAbb);
            this.pnlUpdateTest.Controls.Add(this.lblUpdateTestAbb);
            this.pnlUpdateTest.Location = new System.Drawing.Point(12, 302);
            this.pnlUpdateTest.Name = "pnlUpdateTest";
            this.pnlUpdateTest.Size = new System.Drawing.Size(370, 245);
            this.pnlUpdateTest.TabIndex = 51;
            this.pnlUpdateTest.Visible = false;
            // 
            // txtUpdateCategory
            // 
            this.txtUpdateCategory.Location = new System.Drawing.Point(94, 60);
            this.txtUpdateCategory.Name = "txtUpdateCategory";
            this.txtUpdateCategory.Size = new System.Drawing.Size(59, 21);
            this.txtUpdateCategory.TabIndex = 58;
            // 
            // txtUpdateComment
            // 
            this.txtUpdateComment.Location = new System.Drawing.Point(94, 192);
            this.txtUpdateComment.Name = "txtUpdateComment";
            this.txtUpdateComment.Size = new System.Drawing.Size(265, 21);
            this.txtUpdateComment.TabIndex = 57;
            // 
            // lblUpdateComment
            // 
            this.lblUpdateComment.AutoSize = true;
            this.lblUpdateComment.Location = new System.Drawing.Point(35, 195);
            this.lblUpdateComment.Name = "lblUpdateComment";
            this.lblUpdateComment.Size = new System.Drawing.Size(53, 12);
            this.lblUpdateComment.TabIndex = 56;
            this.lblUpdateComment.Text = "Comment:";
            // 
            // lblUpdateDEnd
            // 
            this.lblUpdateDEnd.AutoSize = true;
            this.lblUpdateDEnd.Location = new System.Drawing.Point(171, 115);
            this.lblUpdateDEnd.Name = "lblUpdateDEnd";
            this.lblUpdateDEnd.Size = new System.Drawing.Size(59, 12);
            this.lblUpdateDEnd.TabIndex = 55;
            this.lblUpdateDEnd.Text = "Date End:";
            // 
            // txtUpdateEmployee
            // 
            this.txtUpdateEmployee.Location = new System.Drawing.Point(236, 65);
            this.txtUpdateEmployee.Name = "txtUpdateEmployee";
            this.txtUpdateEmployee.Size = new System.Drawing.Size(111, 21);
            this.txtUpdateEmployee.TabIndex = 54;
            // 
            // txtUpdateDStart
            // 
            this.txtUpdateDStart.Location = new System.Drawing.Point(94, 110);
            this.txtUpdateDStart.Name = "txtUpdateDStart";
            this.txtUpdateDStart.Size = new System.Drawing.Size(70, 21);
            this.txtUpdateDStart.TabIndex = 53;
            // 
            // grpUpdateConfigure
            // 
            this.grpUpdateConfigure.Controls.Add(this.lblUpdateHardware);
            this.grpUpdateConfigure.Controls.Add(this.lblUpdateSystem);
            this.grpUpdateConfigure.Controls.Add(this.txtUpdateHardware);
            this.grpUpdateConfigure.Controls.Add(this.txtUpdateSystem);
            this.grpUpdateConfigure.Location = new System.Drawing.Point(159, 1);
            this.grpUpdateConfigure.Name = "grpUpdateConfigure";
            this.grpUpdateConfigure.Size = new System.Drawing.Size(200, 63);
            this.grpUpdateConfigure.TabIndex = 52;
            this.grpUpdateConfigure.TabStop = false;
            this.grpUpdateConfigure.Text = "Configure";
            // 
            // lblUpdateHardware
            // 
            this.lblUpdateHardware.AutoSize = true;
            this.lblUpdateHardware.Location = new System.Drawing.Point(23, 15);
            this.lblUpdateHardware.Name = "lblUpdateHardware";
            this.lblUpdateHardware.Size = new System.Drawing.Size(89, 12);
            this.lblUpdateHardware.TabIndex = 16;
            this.lblUpdateHardware.Text = "Hardware Name:";
            // 
            // lblUpdateSystem
            // 
            this.lblUpdateSystem.AutoSize = true;
            this.lblUpdateSystem.Location = new System.Drawing.Point(5, 40);
            this.lblUpdateSystem.Name = "lblUpdateSystem";
            this.lblUpdateSystem.Size = new System.Drawing.Size(107, 12);
            this.lblUpdateSystem.TabIndex = 17;
            this.lblUpdateSystem.Text = "Operating System:";
            // 
            // txtUpdateHardware
            // 
            this.txtUpdateHardware.Location = new System.Drawing.Point(112, 12);
            this.txtUpdateHardware.Name = "txtUpdateHardware";
            this.txtUpdateHardware.Size = new System.Drawing.Size(82, 21);
            this.txtUpdateHardware.TabIndex = 32;
            // 
            // txtUpdateSystem
            // 
            this.txtUpdateSystem.Location = new System.Drawing.Point(112, 37);
            this.txtUpdateSystem.Name = "txtUpdateSystem";
            this.txtUpdateSystem.Size = new System.Drawing.Size(82, 21);
            this.txtUpdateSystem.TabIndex = 26;
            // 
            // txtUpdateTCAbb
            // 
            this.txtUpdateTCAbb.Location = new System.Drawing.Point(94, 33);
            this.txtUpdateTCAbb.Name = "txtUpdateTCAbb";
            this.txtUpdateTCAbb.Size = new System.Drawing.Size(59, 21);
            this.txtUpdateTCAbb.TabIndex = 51;
            // 
            // btnCancel2
            // 
            this.btnCancel2.Location = new System.Drawing.Point(260, 216);
            this.btnCancel2.Name = "btnCancel2";
            this.btnCancel2.Size = new System.Drawing.Size(90, 23);
            this.btnCancel2.TabIndex = 50;
            this.btnCancel2.Text = "Cancel";
            this.btnCancel2.UseVisualStyleBackColor = true;
            this.btnCancel2.Click += new System.EventHandler(this.btnCancel2_Click);
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Location = new System.Drawing.Point(20, 215);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(90, 23);
            this.btnSaveChanges.TabIndex = 42;
            this.btnSaveChanges.Text = "Save Changes";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // cboUpdateStatus
            // 
            this.cboUpdateStatus.FormattingEnabled = true;
            this.cboUpdateStatus.Items.AddRange(new object[] {
            "Passed",
            "Blocked",
            "Retest",
            "Failed"});
            this.cboUpdateStatus.Location = new System.Drawing.Point(94, 86);
            this.cboUpdateStatus.Name = "cboUpdateStatus";
            this.cboUpdateStatus.Size = new System.Drawing.Size(80, 20);
            this.cboUpdateStatus.TabIndex = 46;
            // 
            // dtpDEnd
            // 
            this.dtpDEnd.Location = new System.Drawing.Point(236, 109);
            this.dtpDEnd.Name = "dtpDEnd";
            this.dtpDEnd.Size = new System.Drawing.Size(111, 21);
            this.dtpDEnd.TabIndex = 39;
            // 
            // txtUpdateTestAbb
            // 
            this.txtUpdateTestAbb.Location = new System.Drawing.Point(94, 8);
            this.txtUpdateTestAbb.Name = "txtUpdateTestAbb";
            this.txtUpdateTestAbb.Size = new System.Drawing.Size(59, 21);
            this.txtUpdateTestAbb.TabIndex = 38;
            // 
            // txtUpdateSteps
            // 
            this.txtUpdateSteps.Location = new System.Drawing.Point(94, 137);
            this.txtUpdateSteps.Multiline = true;
            this.txtUpdateSteps.Name = "txtUpdateSteps";
            this.txtUpdateSteps.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtUpdateSteps.Size = new System.Drawing.Size(265, 50);
            this.txtUpdateSteps.TabIndex = 29;
            // 
            // lblUpdateSteps
            // 
            this.lblUpdateSteps.AutoSize = true;
            this.lblUpdateSteps.Location = new System.Drawing.Point(47, 140);
            this.lblUpdateSteps.Name = "lblUpdateSteps";
            this.lblUpdateSteps.Size = new System.Drawing.Size(41, 12);
            this.lblUpdateSteps.TabIndex = 20;
            this.lblUpdateSteps.Text = "Steps:";
            // 
            // lblUpdateDStart
            // 
            this.lblUpdateDStart.AutoSize = true;
            this.lblUpdateDStart.Location = new System.Drawing.Point(17, 115);
            this.lblUpdateDStart.Name = "lblUpdateDStart";
            this.lblUpdateDStart.Size = new System.Drawing.Size(71, 12);
            this.lblUpdateDStart.TabIndex = 19;
            this.lblUpdateDStart.Text = "Date Start:";
            // 
            // lblUpdateEmployee
            // 
            this.lblUpdateEmployee.AutoSize = true;
            this.lblUpdateEmployee.Location = new System.Drawing.Point(165, 69);
            this.lblUpdateEmployee.Name = "lblUpdateEmployee";
            this.lblUpdateEmployee.Size = new System.Drawing.Size(65, 12);
            this.lblUpdateEmployee.TabIndex = 18;
            this.lblUpdateEmployee.Text = "Tested By:";
            // 
            // lblUpdateStatus
            // 
            this.lblUpdateStatus.AutoSize = true;
            this.lblUpdateStatus.Location = new System.Drawing.Point(41, 90);
            this.lblUpdateStatus.Name = "lblUpdateStatus";
            this.lblUpdateStatus.Size = new System.Drawing.Size(47, 12);
            this.lblUpdateStatus.TabIndex = 17;
            this.lblUpdateStatus.Text = "Status:";
            // 
            // lblUpdateCategory
            // 
            this.lblUpdateCategory.AutoSize = true;
            this.lblUpdateCategory.Location = new System.Drawing.Point(29, 65);
            this.lblUpdateCategory.Name = "lblUpdateCategory";
            this.lblUpdateCategory.Size = new System.Drawing.Size(59, 12);
            this.lblUpdateCategory.TabIndex = 16;
            this.lblUpdateCategory.Text = "Category:";
            // 
            // lblUpdateTCAbb
            // 
            this.lblUpdateTCAbb.AutoSize = true;
            this.lblUpdateTCAbb.Location = new System.Drawing.Point(5, 40);
            this.lblUpdateTCAbb.Name = "lblUpdateTCAbb";
            this.lblUpdateTCAbb.Size = new System.Drawing.Size(83, 12);
            this.lblUpdateTCAbb.TabIndex = 15;
            this.lblUpdateTCAbb.Text = "TestCase Abb:";
            // 
            // lblUpdateTestAbb
            // 
            this.lblUpdateTestAbb.AutoSize = true;
            this.lblUpdateTestAbb.Location = new System.Drawing.Point(29, 15);
            this.lblUpdateTestAbb.Name = "lblUpdateTestAbb";
            this.lblUpdateTestAbb.Size = new System.Drawing.Size(59, 12);
            this.lblUpdateTestAbb.TabIndex = 14;
            this.lblUpdateTestAbb.Text = "Test Abb:";
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 337);
            this.Controls.Add(this.pnlUpdateTest);
            this.Controls.Add(this.pnlAddTest);
            this.Controls.Add(this.btnDeleteTest);
            this.Controls.Add(this.btnUpdateTest);
            this.Controls.Add(this.btnAddTest);
            this.Controls.Add(this.txtTestID);
            this.Controls.Add(this.txtTestCaseAbb);
            this.Controls.Add(this.txtTestAbb);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.txtEmployee);
            this.Controls.Add(this.txtDateEnd);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.txtSteps);
            this.Controls.Add(this.txtDateStart);
            this.Controls.Add(this.groConfigure);
            this.Controls.Add(this.lblComment);
            this.Controls.Add(this.lblDateEnd);
            this.Controls.Add(this.lblDateStart);
            this.Controls.Add(this.lblTestCaseAbb);
            this.Controls.Add(this.lblTestID);
            this.Controls.Add(this.lblSteps);
            this.Controls.Add(this.lblEmployee);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lblTestAbb);
            this.Controls.Add(this.lstTest);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Name = "TestForm";
            this.Text = "Test Maintenance";
            this.groConfigure.ResumeLayout(false);
            this.groConfigure.PerformLayout();
            this.pnlAddTest.ResumeLayout(false);
            this.pnlAddTest.PerformLayout();
            this.pnlUpdateTest.ResumeLayout(false);
            this.pnlUpdateTest.PerformLayout();
            this.grpUpdateConfigure.ResumeLayout(false);
            this.grpUpdateConfigure.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.ListBox lstTest;
        private System.Windows.Forms.Label lblTestAbb;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblHardware;
        private System.Windows.Forms.Label lblSystem;
        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.Label lblSteps;
        private System.Windows.Forms.Label lblTestID;
        private System.Windows.Forms.Label lblTestCaseAbb;
        private System.Windows.Forms.Label lblDateStart;
        private System.Windows.Forms.Label lblDateEnd;
        private System.Windows.Forms.Label lblComment;
        private System.Windows.Forms.GroupBox groConfigure;
        private System.Windows.Forms.TextBox txtHardware;
        private System.Windows.Forms.TextBox txtSystem;
        private System.Windows.Forms.TextBox txtDateStart;
        private System.Windows.Forms.TextBox txtSteps;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.TextBox txtDateEnd;
        private System.Windows.Forms.TextBox txtEmployee;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.TextBox txtTestAbb;
        private System.Windows.Forms.TextBox txtTestCaseAbb;
        private System.Windows.Forms.TextBox txtTestID;
        private System.Windows.Forms.Button btnAddTest;
        private System.Windows.Forms.Button btnUpdateTest;
        private System.Windows.Forms.Button btnDeleteTest;
        private System.Windows.Forms.Panel pnlAddTest;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSaveTest;
        private System.Windows.Forms.ComboBox cboAddSystem;
        private System.Windows.Forms.ComboBox cboAddHardware;
        private System.Windows.Forms.ComboBox cboAddConfigureID;
        private System.Windows.Forms.ComboBox cboAddCategoryName;
        private System.Windows.Forms.ComboBox cboAddCategoryID;
        private System.Windows.Forms.ComboBox cboAddTCAbb;
        private System.Windows.Forms.ComboBox cboAddTCID;
        private System.Windows.Forms.ComboBox cboAddLastN;
        private System.Windows.Forms.ComboBox cboAddFirstN;
        private System.Windows.Forms.ComboBox cboAddEmployeeID;
        private System.Windows.Forms.DateTimePicker dtpAddDStart;
        private System.Windows.Forms.TextBox txtAddTestAbb;
        private System.Windows.Forms.TextBox txtAddSteps;
        private System.Windows.Forms.Label lblAddSteps;
        private System.Windows.Forms.Label lblAddDateStart;
        private System.Windows.Forms.Label lblAddEmployee;
        private System.Windows.Forms.Label lblAddConfigure;
        private System.Windows.Forms.Label lblAddCategory;
        private System.Windows.Forms.Label lblAddTestCaseAbb;
        private System.Windows.Forms.Label lblAddTestAbb;
        private System.Windows.Forms.Panel pnlUpdateTest;
        private System.Windows.Forms.Button btnCancel2;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.ComboBox cboUpdateStatus;
        private System.Windows.Forms.DateTimePicker dtpDEnd;
        private System.Windows.Forms.TextBox txtUpdateTestAbb;
        private System.Windows.Forms.TextBox txtUpdateSteps;
        private System.Windows.Forms.Label lblUpdateSteps;
        private System.Windows.Forms.Label lblUpdateDStart;
        private System.Windows.Forms.Label lblUpdateEmployee;
        private System.Windows.Forms.Label lblUpdateStatus;
        private System.Windows.Forms.Label lblUpdateCategory;
        private System.Windows.Forms.Label lblUpdateTCAbb;
        private System.Windows.Forms.Label lblUpdateTestAbb;
        private System.Windows.Forms.TextBox txtUpdateCategory;
        private System.Windows.Forms.TextBox txtUpdateComment;
        private System.Windows.Forms.Label lblUpdateComment;
        private System.Windows.Forms.Label lblUpdateDEnd;
        private System.Windows.Forms.TextBox txtUpdateEmployee;
        private System.Windows.Forms.TextBox txtUpdateDStart;
        private System.Windows.Forms.GroupBox grpUpdateConfigure;
        private System.Windows.Forms.Label lblUpdateHardware;
        private System.Windows.Forms.Label lblUpdateSystem;
        private System.Windows.Forms.TextBox txtUpdateHardware;
        private System.Windows.Forms.TextBox txtUpdateSystem;
        private System.Windows.Forms.TextBox txtUpdateTCAbb;
    }
}