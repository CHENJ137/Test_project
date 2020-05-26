namespace ABCTestProject
{
    partial class AssignBugForm
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
            this.dgvEmplyee = new System.Windows.Forms.DataGridView();
            this.dgvAssignedBug = new System.Windows.Forms.DataGridView();
            this.dgvBug = new System.Windows.Forms.DataGridView();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblBugAbb = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtBugAbb = new System.Windows.Forms.TextBox();
            this.btnAssignBug = new System.Windows.Forms.Button();
            this.btnRemoveBug = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmplyee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssignedBug)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBug)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEmplyee
            // 
            this.dgvEmplyee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmplyee.Location = new System.Drawing.Point(12, 12);
            this.dgvEmplyee.Name = "dgvEmplyee";
            this.dgvEmplyee.RowTemplate.Height = 23;
            this.dgvEmplyee.Size = new System.Drawing.Size(320, 160);
            this.dgvEmplyee.TabIndex = 0;
            this.dgvEmplyee.SelectionChanged += new System.EventHandler(this.dgvEmplyee_SelectionChanged);
            // 
            // dgvAssignedBug
            // 
            this.dgvAssignedBug.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAssignedBug.Location = new System.Drawing.Point(12, 205);
            this.dgvAssignedBug.MultiSelect = false;
            this.dgvAssignedBug.Name = "dgvAssignedBug";
            this.dgvAssignedBug.ReadOnly = true;
            this.dgvAssignedBug.RowTemplate.Height = 23;
            this.dgvAssignedBug.Size = new System.Drawing.Size(320, 160);
            this.dgvAssignedBug.TabIndex = 1;
            this.dgvAssignedBug.SelectionChanged += new System.EventHandler(this.dgvAssignedBug_SelectionChanged);
            // 
            // dgvBug
            // 
            this.dgvBug.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBug.Location = new System.Drawing.Point(352, 205);
            this.dgvBug.MultiSelect = false;
            this.dgvBug.Name = "dgvBug";
            this.dgvBug.ReadOnly = true;
            this.dgvBug.RowTemplate.Height = 23;
            this.dgvBug.Size = new System.Drawing.Size(320, 160);
            this.dgvBug.TabIndex = 2;
            this.dgvBug.SelectionChanged += new System.EventHandler(this.dgvBug_SelectionChanged);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(377, 64);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(125, 12);
            this.lblFirstName.TabIndex = 3;
            this.lblFirstName.Text = "Employee First Name:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(383, 120);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(119, 12);
            this.lblLastName.TabIndex = 4;
            this.lblLastName.Text = "Employee Last Name:";
            // 
            // lblBugAbb
            // 
            this.lblBugAbb.AutoSize = true;
            this.lblBugAbb.Location = new System.Drawing.Point(239, 389);
            this.lblBugAbb.Name = "lblBugAbb";
            this.lblBugAbb.Size = new System.Drawing.Size(53, 12);
            this.lblBugAbb.TabIndex = 5;
            this.lblBugAbb.Text = "Bug Abb:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(508, 61);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 21);
            this.txtFirstName.TabIndex = 6;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(508, 117);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 21);
            this.txtLastName.TabIndex = 7;
            // 
            // txtBugAbb
            // 
            this.txtBugAbb.Location = new System.Drawing.Point(298, 386);
            this.txtBugAbb.Name = "txtBugAbb";
            this.txtBugAbb.Size = new System.Drawing.Size(100, 21);
            this.txtBugAbb.TabIndex = 8;
            // 
            // btnAssignBug
            // 
            this.btnAssignBug.Location = new System.Drawing.Point(12, 427);
            this.btnAssignBug.Name = "btnAssignBug";
            this.btnAssignBug.Size = new System.Drawing.Size(100, 23);
            this.btnAssignBug.TabIndex = 9;
            this.btnAssignBug.Text = "Assign Bug";
            this.btnAssignBug.UseVisualStyleBackColor = true;
            // 
            // btnRemoveBug
            // 
            this.btnRemoveBug.Location = new System.Drawing.Point(295, 427);
            this.btnRemoveBug.Name = "btnRemoveBug";
            this.btnRemoveBug.Size = new System.Drawing.Size(100, 23);
            this.btnRemoveBug.TabIndex = 10;
            this.btnRemoveBug.Text = "Remove Bug";
            this.btnRemoveBug.UseVisualStyleBackColor = true;
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(572, 427);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(100, 23);
            this.btnReturn.TabIndex = 11;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // AssignBugForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 462);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnRemoveBug);
            this.Controls.Add(this.btnAssignBug);
            this.Controls.Add(this.txtBugAbb);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblBugAbb);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.dgvBug);
            this.Controls.Add(this.dgvAssignedBug);
            this.Controls.Add(this.dgvEmplyee);
            this.Name = "AssignBugForm";
            this.Text = "Assign Bug to Employee";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmplyee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssignedBug)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBug)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEmplyee;
        private System.Windows.Forms.DataGridView dgvAssignedBug;
        private System.Windows.Forms.DataGridView dgvBug;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblBugAbb;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtBugAbb;
        private System.Windows.Forms.Button btnAssignBug;
        private System.Windows.Forms.Button btnRemoveBug;
        private System.Windows.Forms.Button btnReturn;
    }
}