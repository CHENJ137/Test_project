namespace ABCTestProject
{
    partial class SeverityForm
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
            this.lstSeverity = new System.Windows.Forms.ListBox();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnAddSeverity = new System.Windows.Forms.Button();
            this.btnUpdateSeverity = new System.Windows.Forms.Button();
            this.btnDeleteSeverity = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtSeverity = new System.Windows.Forms.TextBox();
            this.lblSeverity = new System.Windows.Forms.Label();
            this.txtSeverityID = new System.Windows.Forms.TextBox();
            this.lblSeverityID = new System.Windows.Forms.Label();
            this.pnlAddS = new System.Windows.Forms.Panel();
            this.lblAddSID = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSaveS = new System.Windows.Forms.Button();
            this.txtAddD = new System.Windows.Forms.TextBox();
            this.lblAddD = new System.Windows.Forms.Label();
            this.txtAddS = new System.Windows.Forms.TextBox();
            this.lblAddS = new System.Windows.Forms.Label();
            this.pnlUpdateS = new System.Windows.Forms.Panel();
            this.txtUpdateSID = new System.Windows.Forms.TextBox();
            this.lblUpdateSID = new System.Windows.Forms.Label();
            this.btnCancel2 = new System.Windows.Forms.Button();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.txtUpdateD = new System.Windows.Forms.TextBox();
            this.lblUpdateD = new System.Windows.Forms.Label();
            this.txtUpdateS = new System.Windows.Forms.TextBox();
            this.lblUpdateS = new System.Windows.Forms.Label();
            this.cboAddSID = new System.Windows.Forms.ComboBox();
            this.pnlAddS.SuspendLayout();
            this.pnlUpdateS.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstSeverity
            // 
            this.lstSeverity.FormattingEnabled = true;
            this.lstSeverity.ItemHeight = 12;
            this.lstSeverity.Location = new System.Drawing.Point(25, 25);
            this.lstSeverity.Name = "lstSeverity";
            this.lstSeverity.Size = new System.Drawing.Size(100, 220);
            this.lstSeverity.TabIndex = 4;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(25, 264);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 23);
            this.btnPrevious.TabIndex = 5;
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
            // btnAddSeverity
            // 
            this.btnAddSeverity.Location = new System.Drawing.Point(187, 264);
            this.btnAddSeverity.Name = "btnAddSeverity";
            this.btnAddSeverity.Size = new System.Drawing.Size(105, 23);
            this.btnAddSeverity.TabIndex = 12;
            this.btnAddSeverity.Text = "Add Severity";
            this.btnAddSeverity.UseVisualStyleBackColor = true;
            this.btnAddSeverity.Click += new System.EventHandler(this.btnAddSeverity_Click);
            // 
            // btnUpdateSeverity
            // 
            this.btnUpdateSeverity.Location = new System.Drawing.Point(293, 264);
            this.btnUpdateSeverity.Name = "btnUpdateSeverity";
            this.btnUpdateSeverity.Size = new System.Drawing.Size(105, 23);
            this.btnUpdateSeverity.TabIndex = 13;
            this.btnUpdateSeverity.Text = "Update Severity";
            this.btnUpdateSeverity.UseVisualStyleBackColor = true;
            this.btnUpdateSeverity.Click += new System.EventHandler(this.btnUpdateSeverity_Click);
            // 
            // btnDeleteSeverity
            // 
            this.btnDeleteSeverity.Location = new System.Drawing.Point(399, 264);
            this.btnDeleteSeverity.Name = "btnDeleteSeverity";
            this.btnDeleteSeverity.Size = new System.Drawing.Size(105, 23);
            this.btnDeleteSeverity.TabIndex = 14;
            this.btnDeleteSeverity.Text = "Delete Severity";
            this.btnDeleteSeverity.UseVisualStyleBackColor = true;
            this.btnDeleteSeverity.Click += new System.EventHandler(this.btnDeleteSeverity_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(255, 117);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(220, 110);
            this.txtDescription.TabIndex = 33;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(172, 120);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(77, 12);
            this.lblDescription.TabIndex = 32;
            this.lblDescription.Text = "Description:";
            // 
            // txtSeverity
            // 
            this.txtSeverity.Location = new System.Drawing.Point(255, 77);
            this.txtSeverity.Name = "txtSeverity";
            this.txtSeverity.Size = new System.Drawing.Size(100, 21);
            this.txtSeverity.TabIndex = 30;
            // 
            // lblSeverity
            // 
            this.lblSeverity.AutoSize = true;
            this.lblSeverity.Location = new System.Drawing.Point(190, 80);
            this.lblSeverity.Name = "lblSeverity";
            this.lblSeverity.Size = new System.Drawing.Size(59, 12);
            this.lblSeverity.TabIndex = 26;
            this.lblSeverity.Text = "Severity:";
            // 
            // txtSeverityID
            // 
            this.txtSeverityID.Location = new System.Drawing.Point(255, 37);
            this.txtSeverityID.Name = "txtSeverityID";
            this.txtSeverityID.Size = new System.Drawing.Size(50, 21);
            this.txtSeverityID.TabIndex = 25;
            // 
            // lblSeverityID
            // 
            this.lblSeverityID.AutoSize = true;
            this.lblSeverityID.Location = new System.Drawing.Point(172, 40);
            this.lblSeverityID.Name = "lblSeverityID";
            this.lblSeverityID.Size = new System.Drawing.Size(77, 12);
            this.lblSeverityID.TabIndex = 24;
            this.lblSeverityID.Text = "Severity ID:";
            // 
            // pnlAddS
            // 
            this.pnlAddS.Controls.Add(this.cboAddSID);
            this.pnlAddS.Controls.Add(this.lblAddSID);
            this.pnlAddS.Controls.Add(this.btnCancel);
            this.pnlAddS.Controls.Add(this.btnSaveS);
            this.pnlAddS.Controls.Add(this.txtAddD);
            this.pnlAddS.Controls.Add(this.lblAddD);
            this.pnlAddS.Controls.Add(this.txtAddS);
            this.pnlAddS.Controls.Add(this.lblAddS);
            this.pnlAddS.Location = new System.Drawing.Point(150, 32);
            this.pnlAddS.Name = "pnlAddS";
            this.pnlAddS.Size = new System.Drawing.Size(346, 213);
            this.pnlAddS.TabIndex = 35;
            this.pnlAddS.Visible = false;
            // 
            // lblAddSID
            // 
            this.lblAddSID.AutoSize = true;
            this.lblAddSID.Location = new System.Drawing.Point(14, 20);
            this.lblAddSID.Name = "lblAddSID";
            this.lblAddSID.Size = new System.Drawing.Size(77, 12);
            this.lblAddSID.TabIndex = 40;
            this.lblAddSID.Text = "Severity ID:";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(226, 173);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 23);
            this.btnCancel.TabIndex = 39;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSaveS
            // 
            this.btnSaveS.Location = new System.Drawing.Point(19, 173);
            this.btnSaveS.Name = "btnSaveS";
            this.btnSaveS.Size = new System.Drawing.Size(100, 23);
            this.btnSaveS.TabIndex = 38;
            this.btnSaveS.Text = "Save Severity";
            this.btnSaveS.UseVisualStyleBackColor = true;
            this.btnSaveS.Click += new System.EventHandler(this.btnSaveS_Click);
            // 
            // txtAddD
            // 
            this.txtAddD.Location = new System.Drawing.Point(96, 85);
            this.txtAddD.Multiline = true;
            this.txtAddD.Name = "txtAddD";
            this.txtAddD.Size = new System.Drawing.Size(220, 80);
            this.txtAddD.TabIndex = 37;
            // 
            // lblAddD
            // 
            this.lblAddD.AutoSize = true;
            this.lblAddD.Location = new System.Drawing.Point(14, 85);
            this.lblAddD.Name = "lblAddD";
            this.lblAddD.Size = new System.Drawing.Size(77, 12);
            this.lblAddD.TabIndex = 36;
            this.lblAddD.Text = "Description:";
            // 
            // txtAddS
            // 
            this.txtAddS.Location = new System.Drawing.Point(96, 51);
            this.txtAddS.Name = "txtAddS";
            this.txtAddS.Size = new System.Drawing.Size(100, 21);
            this.txtAddS.TabIndex = 35;
            // 
            // lblAddS
            // 
            this.lblAddS.AutoSize = true;
            this.lblAddS.Location = new System.Drawing.Point(32, 54);
            this.lblAddS.Name = "lblAddS";
            this.lblAddS.Size = new System.Drawing.Size(59, 12);
            this.lblAddS.TabIndex = 34;
            this.lblAddS.Text = "Severity:";
            // 
            // pnlUpdateS
            // 
            this.pnlUpdateS.Controls.Add(this.txtUpdateSID);
            this.pnlUpdateS.Controls.Add(this.lblUpdateSID);
            this.pnlUpdateS.Controls.Add(this.btnCancel2);
            this.pnlUpdateS.Controls.Add(this.btnSaveChanges);
            this.pnlUpdateS.Controls.Add(this.txtUpdateD);
            this.pnlUpdateS.Controls.Add(this.lblUpdateD);
            this.pnlUpdateS.Controls.Add(this.txtUpdateS);
            this.pnlUpdateS.Controls.Add(this.lblUpdateS);
            this.pnlUpdateS.Location = new System.Drawing.Point(40, 314);
            this.pnlUpdateS.Name = "pnlUpdateS";
            this.pnlUpdateS.Size = new System.Drawing.Size(346, 213);
            this.pnlUpdateS.TabIndex = 40;
            this.pnlUpdateS.Visible = false;
            // 
            // txtUpdateSID
            // 
            this.txtUpdateSID.Location = new System.Drawing.Point(100, 17);
            this.txtUpdateSID.Name = "txtUpdateSID";
            this.txtUpdateSID.Size = new System.Drawing.Size(50, 21);
            this.txtUpdateSID.TabIndex = 43;
            // 
            // lblUpdateSID
            // 
            this.lblUpdateSID.AutoSize = true;
            this.lblUpdateSID.Location = new System.Drawing.Point(17, 20);
            this.lblUpdateSID.Name = "lblUpdateSID";
            this.lblUpdateSID.Size = new System.Drawing.Size(77, 12);
            this.lblUpdateSID.TabIndex = 42;
            this.lblUpdateSID.Text = "Severity ID:";
            // 
            // btnCancel2
            // 
            this.btnCancel2.Location = new System.Drawing.Point(222, 173);
            this.btnCancel2.Name = "btnCancel2";
            this.btnCancel2.Size = new System.Drawing.Size(100, 23);
            this.btnCancel2.TabIndex = 39;
            this.btnCancel2.Text = "Cancel";
            this.btnCancel2.UseVisualStyleBackColor = true;
            this.btnCancel2.Click += new System.EventHandler(this.btnCancel2_Click);
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Location = new System.Drawing.Point(19, 173);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(100, 23);
            this.btnSaveChanges.TabIndex = 38;
            this.btnSaveChanges.Text = "Save Changes";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // txtUpdateD
            // 
            this.txtUpdateD.Location = new System.Drawing.Point(100, 81);
            this.txtUpdateD.Multiline = true;
            this.txtUpdateD.Name = "txtUpdateD";
            this.txtUpdateD.Size = new System.Drawing.Size(220, 80);
            this.txtUpdateD.TabIndex = 37;
            // 
            // lblUpdateD
            // 
            this.lblUpdateD.AutoSize = true;
            this.lblUpdateD.Location = new System.Drawing.Point(17, 84);
            this.lblUpdateD.Name = "lblUpdateD";
            this.lblUpdateD.Size = new System.Drawing.Size(77, 12);
            this.lblUpdateD.TabIndex = 36;
            this.lblUpdateD.Text = "Description:";
            // 
            // txtUpdateS
            // 
            this.txtUpdateS.Location = new System.Drawing.Point(100, 48);
            this.txtUpdateS.Name = "txtUpdateS";
            this.txtUpdateS.Size = new System.Drawing.Size(100, 21);
            this.txtUpdateS.TabIndex = 35;
            // 
            // lblUpdateS
            // 
            this.lblUpdateS.AutoSize = true;
            this.lblUpdateS.Location = new System.Drawing.Point(35, 51);
            this.lblUpdateS.Name = "lblUpdateS";
            this.lblUpdateS.Size = new System.Drawing.Size(59, 12);
            this.lblUpdateS.TabIndex = 34;
            this.lblUpdateS.Text = "Severity:";
            // 
            // cboAddSID
            // 
            this.cboAddSID.FormattingEnabled = true;
            this.cboAddSID.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.cboAddSID.Location = new System.Drawing.Point(96, 17);
            this.cboAddSID.Name = "cboAddSID";
            this.cboAddSID.Size = new System.Drawing.Size(50, 20);
            this.cboAddSID.TabIndex = 41;
            // 
            // SeverityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 337);
            this.Controls.Add(this.pnlUpdateS);
            this.Controls.Add(this.pnlAddS);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtSeverity);
            this.Controls.Add(this.lblSeverity);
            this.Controls.Add(this.txtSeverityID);
            this.Controls.Add(this.lblSeverityID);
            this.Controls.Add(this.btnDeleteSeverity);
            this.Controls.Add(this.btnUpdateSeverity);
            this.Controls.Add(this.btnAddSeverity);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.lstSeverity);
            this.Name = "SeverityForm";
            this.Text = "Severity Maintenance";
            this.pnlAddS.ResumeLayout(false);
            this.pnlAddS.PerformLayout();
            this.pnlUpdateS.ResumeLayout(false);
            this.pnlUpdateS.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstSeverity;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnAddSeverity;
        private System.Windows.Forms.Button btnUpdateSeverity;
        private System.Windows.Forms.Button btnDeleteSeverity;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtSeverity;
        private System.Windows.Forms.Label lblSeverity;
        private System.Windows.Forms.TextBox txtSeverityID;
        private System.Windows.Forms.Label lblSeverityID;
        private System.Windows.Forms.Panel pnlAddS;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSaveS;
        private System.Windows.Forms.TextBox txtAddD;
        private System.Windows.Forms.Label lblAddD;
        private System.Windows.Forms.TextBox txtAddS;
        private System.Windows.Forms.Label lblAddS;
        private System.Windows.Forms.Panel pnlUpdateS;
        private System.Windows.Forms.Button btnCancel2;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.TextBox txtUpdateD;
        private System.Windows.Forms.Label lblUpdateD;
        private System.Windows.Forms.TextBox txtUpdateS;
        private System.Windows.Forms.Label lblUpdateS;
        private System.Windows.Forms.Label lblAddSID;
        private System.Windows.Forms.TextBox txtUpdateSID;
        private System.Windows.Forms.Label lblUpdateSID;
        private System.Windows.Forms.ComboBox cboAddSID;
    }
}