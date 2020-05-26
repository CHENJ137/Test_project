namespace ABCTestProject
{
    partial class PriorityForm
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
            this.lstPriority = new System.Windows.Forms.ListBox();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnAddPriority = new System.Windows.Forms.Button();
            this.btnUpdatePriority = new System.Windows.Forms.Button();
            this.btnDeletePriority = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtPriority = new System.Windows.Forms.TextBox();
            this.lblPriority = new System.Windows.Forms.Label();
            this.txtPriorityID = new System.Windows.Forms.TextBox();
            this.lblPriorityID = new System.Windows.Forms.Label();
            this.pnlAddPriority = new System.Windows.Forms.Panel();
            this.lblAddPID = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSaveP = new System.Windows.Forms.Button();
            this.txtAddD = new System.Windows.Forms.TextBox();
            this.lblAddD = new System.Windows.Forms.Label();
            this.txtAddP = new System.Windows.Forms.TextBox();
            this.lblAddP = new System.Windows.Forms.Label();
            this.pnlUpdateP = new System.Windows.Forms.Panel();
            this.txtUpdatePID = new System.Windows.Forms.TextBox();
            this.lblUpdatePID = new System.Windows.Forms.Label();
            this.btnCancel2 = new System.Windows.Forms.Button();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.txtUpdateD = new System.Windows.Forms.TextBox();
            this.lblUpdateD = new System.Windows.Forms.Label();
            this.txtUpdateP = new System.Windows.Forms.TextBox();
            this.lblUpdateP = new System.Windows.Forms.Label();
            this.cboAddPID = new System.Windows.Forms.ComboBox();
            this.pnlAddPriority.SuspendLayout();
            this.pnlUpdateP.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstPriority
            // 
            this.lstPriority.FormattingEnabled = true;
            this.lstPriority.ItemHeight = 12;
            this.lstPriority.Location = new System.Drawing.Point(25, 25);
            this.lstPriority.Name = "lstPriority";
            this.lstPriority.Size = new System.Drawing.Size(100, 220);
            this.lstPriority.TabIndex = 4;
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
            // btnAddPriority
            // 
            this.btnAddPriority.Location = new System.Drawing.Point(187, 264);
            this.btnAddPriority.Name = "btnAddPriority";
            this.btnAddPriority.Size = new System.Drawing.Size(105, 23);
            this.btnAddPriority.TabIndex = 12;
            this.btnAddPriority.Text = "Add Priority";
            this.btnAddPriority.UseVisualStyleBackColor = true;
            this.btnAddPriority.Click += new System.EventHandler(this.btnAddPriority_Click);
            // 
            // btnUpdatePriority
            // 
            this.btnUpdatePriority.Location = new System.Drawing.Point(293, 264);
            this.btnUpdatePriority.Name = "btnUpdatePriority";
            this.btnUpdatePriority.Size = new System.Drawing.Size(105, 23);
            this.btnUpdatePriority.TabIndex = 13;
            this.btnUpdatePriority.Text = "Update Priority";
            this.btnUpdatePriority.UseVisualStyleBackColor = true;
            this.btnUpdatePriority.Click += new System.EventHandler(this.btnUpdatePriority_Click);
            // 
            // btnDeletePriority
            // 
            this.btnDeletePriority.Location = new System.Drawing.Point(399, 264);
            this.btnDeletePriority.Name = "btnDeletePriority";
            this.btnDeletePriority.Size = new System.Drawing.Size(105, 23);
            this.btnDeletePriority.TabIndex = 14;
            this.btnDeletePriority.Text = "Delete Priority";
            this.btnDeletePriority.UseVisualStyleBackColor = true;
            this.btnDeletePriority.Click += new System.EventHandler(this.btnDeletePriority_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(258, 117);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(220, 110);
            this.txtDescription.TabIndex = 33;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(175, 120);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(77, 12);
            this.lblDescription.TabIndex = 32;
            this.lblDescription.Text = "Description:";
            // 
            // txtPriority
            // 
            this.txtPriority.Location = new System.Drawing.Point(258, 77);
            this.txtPriority.Name = "txtPriority";
            this.txtPriority.Size = new System.Drawing.Size(100, 21);
            this.txtPriority.TabIndex = 30;
            // 
            // lblPriority
            // 
            this.lblPriority.AutoSize = true;
            this.lblPriority.Location = new System.Drawing.Point(193, 80);
            this.lblPriority.Name = "lblPriority";
            this.lblPriority.Size = new System.Drawing.Size(59, 12);
            this.lblPriority.TabIndex = 26;
            this.lblPriority.Text = "Priority:";
            // 
            // txtPriorityID
            // 
            this.txtPriorityID.Location = new System.Drawing.Point(258, 37);
            this.txtPriorityID.Name = "txtPriorityID";
            this.txtPriorityID.Size = new System.Drawing.Size(50, 21);
            this.txtPriorityID.TabIndex = 25;
            // 
            // lblPriorityID
            // 
            this.lblPriorityID.AutoSize = true;
            this.lblPriorityID.Location = new System.Drawing.Point(175, 40);
            this.lblPriorityID.Name = "lblPriorityID";
            this.lblPriorityID.Size = new System.Drawing.Size(77, 12);
            this.lblPriorityID.TabIndex = 24;
            this.lblPriorityID.Text = "Priority ID:";
            // 
            // pnlAddPriority
            // 
            this.pnlAddPriority.Controls.Add(this.cboAddPID);
            this.pnlAddPriority.Controls.Add(this.lblAddPID);
            this.pnlAddPriority.Controls.Add(this.btnCancel);
            this.pnlAddPriority.Controls.Add(this.btnSaveP);
            this.pnlAddPriority.Controls.Add(this.txtAddD);
            this.pnlAddPriority.Controls.Add(this.lblAddD);
            this.pnlAddPriority.Controls.Add(this.txtAddP);
            this.pnlAddPriority.Controls.Add(this.lblAddP);
            this.pnlAddPriority.Location = new System.Drawing.Point(155, 30);
            this.pnlAddPriority.Name = "pnlAddPriority";
            this.pnlAddPriority.Size = new System.Drawing.Size(346, 213);
            this.pnlAddPriority.TabIndex = 34;
            this.pnlAddPriority.Visible = false;
            // 
            // lblAddPID
            // 
            this.lblAddPID.AutoSize = true;
            this.lblAddPID.Location = new System.Drawing.Point(17, 20);
            this.lblAddPID.Name = "lblAddPID";
            this.lblAddPID.Size = new System.Drawing.Size(77, 12);
            this.lblAddPID.TabIndex = 42;
            this.lblAddPID.Text = "Priority ID:";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(220, 173);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 23);
            this.btnCancel.TabIndex = 39;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSaveP
            // 
            this.btnSaveP.Location = new System.Drawing.Point(19, 173);
            this.btnSaveP.Name = "btnSaveP";
            this.btnSaveP.Size = new System.Drawing.Size(100, 23);
            this.btnSaveP.TabIndex = 38;
            this.btnSaveP.Text = "Save Priority";
            this.btnSaveP.UseVisualStyleBackColor = true;
            this.btnSaveP.Click += new System.EventHandler(this.btnSaveP_Click);
            // 
            // txtAddD
            // 
            this.txtAddD.Location = new System.Drawing.Point(100, 85);
            this.txtAddD.Multiline = true;
            this.txtAddD.Name = "txtAddD";
            this.txtAddD.Size = new System.Drawing.Size(220, 80);
            this.txtAddD.TabIndex = 37;
            // 
            // lblAddD
            // 
            this.lblAddD.AutoSize = true;
            this.lblAddD.Location = new System.Drawing.Point(17, 85);
            this.lblAddD.Name = "lblAddD";
            this.lblAddD.Size = new System.Drawing.Size(77, 12);
            this.lblAddD.TabIndex = 36;
            this.lblAddD.Text = "Description:";
            // 
            // txtAddP
            // 
            this.txtAddP.Location = new System.Drawing.Point(100, 51);
            this.txtAddP.Name = "txtAddP";
            this.txtAddP.Size = new System.Drawing.Size(100, 21);
            this.txtAddP.TabIndex = 35;
            // 
            // lblAddP
            // 
            this.lblAddP.AutoSize = true;
            this.lblAddP.Location = new System.Drawing.Point(35, 54);
            this.lblAddP.Name = "lblAddP";
            this.lblAddP.Size = new System.Drawing.Size(59, 12);
            this.lblAddP.TabIndex = 34;
            this.lblAddP.Text = "Priority:";
            // 
            // pnlUpdateP
            // 
            this.pnlUpdateP.Controls.Add(this.txtUpdatePID);
            this.pnlUpdateP.Controls.Add(this.lblUpdatePID);
            this.pnlUpdateP.Controls.Add(this.btnCancel2);
            this.pnlUpdateP.Controls.Add(this.btnSaveChanges);
            this.pnlUpdateP.Controls.Add(this.txtUpdateD);
            this.pnlUpdateP.Controls.Add(this.lblUpdateD);
            this.pnlUpdateP.Controls.Add(this.txtUpdateP);
            this.pnlUpdateP.Controls.Add(this.lblUpdateP);
            this.pnlUpdateP.Location = new System.Drawing.Point(52, 302);
            this.pnlUpdateP.Name = "pnlUpdateP";
            this.pnlUpdateP.Size = new System.Drawing.Size(346, 213);
            this.pnlUpdateP.TabIndex = 40;
            this.pnlUpdateP.Visible = false;
            // 
            // txtUpdatePID
            // 
            this.txtUpdatePID.Location = new System.Drawing.Point(100, 17);
            this.txtUpdatePID.Name = "txtUpdatePID";
            this.txtUpdatePID.Size = new System.Drawing.Size(50, 21);
            this.txtUpdatePID.TabIndex = 41;
            // 
            // lblUpdatePID
            // 
            this.lblUpdatePID.AutoSize = true;
            this.lblUpdatePID.Location = new System.Drawing.Point(17, 20);
            this.lblUpdatePID.Name = "lblUpdatePID";
            this.lblUpdatePID.Size = new System.Drawing.Size(77, 12);
            this.lblUpdatePID.TabIndex = 40;
            this.lblUpdatePID.Text = "Priority ID:";
            // 
            // btnCancel2
            // 
            this.btnCancel2.Location = new System.Drawing.Point(229, 173);
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
            this.txtUpdateD.Location = new System.Drawing.Point(100, 87);
            this.txtUpdateD.Multiline = true;
            this.txtUpdateD.Name = "txtUpdateD";
            this.txtUpdateD.Size = new System.Drawing.Size(210, 80);
            this.txtUpdateD.TabIndex = 37;
            // 
            // lblUpdateD
            // 
            this.lblUpdateD.AutoSize = true;
            this.lblUpdateD.Location = new System.Drawing.Point(17, 87);
            this.lblUpdateD.Name = "lblUpdateD";
            this.lblUpdateD.Size = new System.Drawing.Size(77, 12);
            this.lblUpdateD.TabIndex = 36;
            this.lblUpdateD.Text = "Description:";
            // 
            // txtUpdateP
            // 
            this.txtUpdateP.Location = new System.Drawing.Point(100, 49);
            this.txtUpdateP.Name = "txtUpdateP";
            this.txtUpdateP.Size = new System.Drawing.Size(100, 21);
            this.txtUpdateP.TabIndex = 35;
            // 
            // lblUpdateP
            // 
            this.lblUpdateP.AutoSize = true;
            this.lblUpdateP.Location = new System.Drawing.Point(35, 52);
            this.lblUpdateP.Name = "lblUpdateP";
            this.lblUpdateP.Size = new System.Drawing.Size(59, 12);
            this.lblUpdateP.TabIndex = 34;
            this.lblUpdateP.Text = "Priority:";
            // 
            // cboAddPID
            // 
            this.cboAddPID.FormattingEnabled = true;
            this.cboAddPID.Items.AddRange(new object[] {
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
            this.cboAddPID.Location = new System.Drawing.Point(100, 17);
            this.cboAddPID.Name = "cboAddPID";
            this.cboAddPID.Size = new System.Drawing.Size(50, 20);
            this.cboAddPID.TabIndex = 43;
            // 
            // PriorityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 337);
            this.Controls.Add(this.pnlUpdateP);
            this.Controls.Add(this.pnlAddPriority);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtPriority);
            this.Controls.Add(this.lblPriority);
            this.Controls.Add(this.txtPriorityID);
            this.Controls.Add(this.lblPriorityID);
            this.Controls.Add(this.btnDeletePriority);
            this.Controls.Add(this.btnUpdatePriority);
            this.Controls.Add(this.btnAddPriority);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.lstPriority);
            this.Name = "PriorityForm";
            this.Text = "Priority Maintenance";
            this.pnlAddPriority.ResumeLayout(false);
            this.pnlAddPriority.PerformLayout();
            this.pnlUpdateP.ResumeLayout(false);
            this.pnlUpdateP.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstPriority;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnAddPriority;
        private System.Windows.Forms.Button btnUpdatePriority;
        private System.Windows.Forms.Button btnDeletePriority;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtPriority;
        private System.Windows.Forms.Label lblPriority;
        private System.Windows.Forms.TextBox txtPriorityID;
        private System.Windows.Forms.Label lblPriorityID;
        private System.Windows.Forms.Panel pnlAddPriority;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSaveP;
        private System.Windows.Forms.TextBox txtAddD;
        private System.Windows.Forms.Label lblAddD;
        private System.Windows.Forms.TextBox txtAddP;
        private System.Windows.Forms.Label lblAddP;
        private System.Windows.Forms.Panel pnlUpdateP;
        private System.Windows.Forms.Button btnCancel2;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.TextBox txtUpdateD;
        private System.Windows.Forms.Label lblUpdateD;
        private System.Windows.Forms.TextBox txtUpdateP;
        private System.Windows.Forms.Label lblUpdateP;
        private System.Windows.Forms.Label lblAddPID;
        private System.Windows.Forms.TextBox txtUpdatePID;
        private System.Windows.Forms.Label lblUpdatePID;
        private System.Windows.Forms.ComboBox cboAddPID;
    }
}