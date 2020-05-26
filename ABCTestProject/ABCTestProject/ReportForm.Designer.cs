namespace ABCTestProject
{
    partial class ReportForm
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
            this.txtReport = new System.Windows.Forms.TextBox();
            this.btnBugRating = new System.Windows.Forms.Button();
            this.btnBugNotA = new System.Windows.Forms.Button();
            this.btnBugStatus = new System.Windows.Forms.Button();
            this.btnBugAssigned = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtReport
            // 
            this.txtReport.Location = new System.Drawing.Point(12, 12);
            this.txtReport.Multiline = true;
            this.txtReport.Name = "txtReport";
            this.txtReport.ReadOnly = true;
            this.txtReport.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtReport.Size = new System.Drawing.Size(510, 275);
            this.txtReport.TabIndex = 0;
            // 
            // btnBugRating
            // 
            this.btnBugRating.Location = new System.Drawing.Point(12, 302);
            this.btnBugRating.Name = "btnBugRating";
            this.btnBugRating.Size = new System.Drawing.Size(100, 23);
            this.btnBugRating.TabIndex = 1;
            this.btnBugRating.Text = "Bug Rating";
            this.btnBugRating.UseVisualStyleBackColor = true;
            this.btnBugRating.Click += new System.EventHandler(this.btnBugRating_Click);
            // 
            // btnBugNotA
            // 
            this.btnBugNotA.Location = new System.Drawing.Point(412, 302);
            this.btnBugNotA.Name = "btnBugNotA";
            this.btnBugNotA.Size = new System.Drawing.Size(110, 23);
            this.btnBugNotA.TabIndex = 2;
            this.btnBugNotA.Text = "Bug Not Assigned";
            this.btnBugNotA.UseVisualStyleBackColor = true;
            this.btnBugNotA.Click += new System.EventHandler(this.btnBugNotA_Click);
            // 
            // btnBugStatus
            // 
            this.btnBugStatus.Location = new System.Drawing.Point(146, 302);
            this.btnBugStatus.Name = "btnBugStatus";
            this.btnBugStatus.Size = new System.Drawing.Size(100, 23);
            this.btnBugStatus.TabIndex = 3;
            this.btnBugStatus.Text = "Bug Status";
            this.btnBugStatus.UseVisualStyleBackColor = true;
            this.btnBugStatus.Click += new System.EventHandler(this.btnBugStatus_Click);
            // 
            // btnBugAssigned
            // 
            this.btnBugAssigned.Location = new System.Drawing.Point(279, 302);
            this.btnBugAssigned.Name = "btnBugAssigned";
            this.btnBugAssigned.Size = new System.Drawing.Size(100, 23);
            this.btnBugAssigned.TabIndex = 4;
            this.btnBugAssigned.Text = "Bug Assigned";
            this.btnBugAssigned.UseVisualStyleBackColor = true;
            this.btnBugAssigned.Click += new System.EventHandler(this.btnBugAssigned_Click);
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 337);
            this.Controls.Add(this.btnBugAssigned);
            this.Controls.Add(this.btnBugStatus);
            this.Controls.Add(this.btnBugNotA);
            this.Controls.Add(this.btnBugRating);
            this.Controls.Add(this.txtReport);
            this.Name = "ReportForm";
            this.Text = "ReportForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtReport;
        private System.Windows.Forms.Button btnBugRating;
        private System.Windows.Forms.Button btnBugNotA;
        private System.Windows.Forms.Button btnBugStatus;
        private System.Windows.Forms.Button btnBugAssigned;
    }
}