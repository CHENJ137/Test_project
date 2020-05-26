namespace ABCTestProject
{
    partial class ConfigureForm
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
            this.lstConfigure = new System.Windows.Forms.ListBox();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnAddConfigure = new System.Windows.Forms.Button();
            this.btnUpdateConfigure = new System.Windows.Forms.Button();
            this.btnDeleteConfigure = new System.Windows.Forms.Button();
            this.lblConfigureID = new System.Windows.Forms.Label();
            this.txtConfigureID = new System.Windows.Forms.TextBox();
            this.lblHardware = new System.Windows.Forms.Label();
            this.lblSystem = new System.Windows.Forms.Label();
            this.lblOptions = new System.Windows.Forms.Label();
            this.txtSystem = new System.Windows.Forms.TextBox();
            this.txtHardware = new System.Windows.Forms.TextBox();
            this.txtOptions = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.pnlAddConfigure = new System.Windows.Forms.Panel();
            this.txtAddDescription = new System.Windows.Forms.TextBox();
            this.lblAddDescription = new System.Windows.Forms.Label();
            this.txtAddOptions = new System.Windows.Forms.TextBox();
            this.txtAddHardware = new System.Windows.Forms.TextBox();
            this.txtAddSystem = new System.Windows.Forms.TextBox();
            this.lblAddOptions = new System.Windows.Forms.Label();
            this.lblAddSystem = new System.Windows.Forms.Label();
            this.lblAddHardware = new System.Windows.Forms.Label();
            this.btnSaveConfigure = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnlUpdateConfigure = new System.Windows.Forms.Panel();
            this.btnCancel2 = new System.Windows.Forms.Button();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.txtUpdateDescription = new System.Windows.Forms.TextBox();
            this.lblUpdateDescription = new System.Windows.Forms.Label();
            this.txtUpdateOptions = new System.Windows.Forms.TextBox();
            this.txtUpdateHardware = new System.Windows.Forms.TextBox();
            this.txtUpdateSystem = new System.Windows.Forms.TextBox();
            this.lblUpdateOptions = new System.Windows.Forms.Label();
            this.lblUpdateSystem = new System.Windows.Forms.Label();
            this.lblUpdateHardware = new System.Windows.Forms.Label();
            this.pnlAddConfigure.SuspendLayout();
            this.pnlUpdateConfigure.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstConfigure
            // 
            this.lstConfigure.FormattingEnabled = true;
            this.lstConfigure.ItemHeight = 12;
            this.lstConfigure.Location = new System.Drawing.Point(25, 25);
            this.lstConfigure.Name = "lstConfigure";
            this.lstConfigure.Size = new System.Drawing.Size(100, 220);
            this.lstConfigure.TabIndex = 2;
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
            // btnAddConfigure
            // 
            this.btnAddConfigure.Location = new System.Drawing.Point(187, 264);
            this.btnAddConfigure.Name = "btnAddConfigure";
            this.btnAddConfigure.Size = new System.Drawing.Size(105, 23);
            this.btnAddConfigure.TabIndex = 11;
            this.btnAddConfigure.Text = "Add Configure";
            this.btnAddConfigure.UseVisualStyleBackColor = true;
            this.btnAddConfigure.Click += new System.EventHandler(this.btnAddConfigure_Click);
            // 
            // btnUpdateConfigure
            // 
            this.btnUpdateConfigure.Location = new System.Drawing.Point(293, 264);
            this.btnUpdateConfigure.Name = "btnUpdateConfigure";
            this.btnUpdateConfigure.Size = new System.Drawing.Size(110, 23);
            this.btnUpdateConfigure.TabIndex = 12;
            this.btnUpdateConfigure.Text = "Update Configure";
            this.btnUpdateConfigure.UseVisualStyleBackColor = true;
            this.btnUpdateConfigure.Click += new System.EventHandler(this.btnUpdateConfigure_Click);
            // 
            // btnDeleteConfigure
            // 
            this.btnDeleteConfigure.Location = new System.Drawing.Point(404, 264);
            this.btnDeleteConfigure.Name = "btnDeleteConfigure";
            this.btnDeleteConfigure.Size = new System.Drawing.Size(110, 23);
            this.btnDeleteConfigure.TabIndex = 13;
            this.btnDeleteConfigure.Text = "Delete Configure";
            this.btnDeleteConfigure.UseVisualStyleBackColor = true;
            this.btnDeleteConfigure.Click += new System.EventHandler(this.btnDeleteConfigure_Click);
            // 
            // lblConfigureID
            // 
            this.lblConfigureID.AutoSize = true;
            this.lblConfigureID.Location = new System.Drawing.Point(156, 35);
            this.lblConfigureID.Name = "lblConfigureID";
            this.lblConfigureID.Size = new System.Drawing.Size(83, 12);
            this.lblConfigureID.TabIndex = 14;
            this.lblConfigureID.Text = "Configure ID:";
            // 
            // txtConfigureID
            // 
            this.txtConfigureID.Location = new System.Drawing.Point(245, 32);
            this.txtConfigureID.Name = "txtConfigureID";
            this.txtConfigureID.Size = new System.Drawing.Size(50, 21);
            this.txtConfigureID.TabIndex = 15;
            // 
            // lblHardware
            // 
            this.lblHardware.AutoSize = true;
            this.lblHardware.Location = new System.Drawing.Point(180, 70);
            this.lblHardware.Name = "lblHardware";
            this.lblHardware.Size = new System.Drawing.Size(59, 12);
            this.lblHardware.TabIndex = 16;
            this.lblHardware.Text = "Hardware:";
            // 
            // lblSystem
            // 
            this.lblSystem.AutoSize = true;
            this.lblSystem.Location = new System.Drawing.Point(132, 105);
            this.lblSystem.Name = "lblSystem";
            this.lblSystem.Size = new System.Drawing.Size(107, 12);
            this.lblSystem.TabIndex = 17;
            this.lblSystem.Text = "Operating System:";
            // 
            // lblOptions
            // 
            this.lblOptions.AutoSize = true;
            this.lblOptions.Location = new System.Drawing.Point(185, 140);
            this.lblOptions.Name = "lblOptions";
            this.lblOptions.Size = new System.Drawing.Size(53, 12);
            this.lblOptions.TabIndex = 18;
            this.lblOptions.Text = "Options:";
            // 
            // txtSystem
            // 
            this.txtSystem.Location = new System.Drawing.Point(245, 102);
            this.txtSystem.Name = "txtSystem";
            this.txtSystem.Size = new System.Drawing.Size(100, 21);
            this.txtSystem.TabIndex = 19;
            // 
            // txtHardware
            // 
            this.txtHardware.Location = new System.Drawing.Point(245, 67);
            this.txtHardware.Name = "txtHardware";
            this.txtHardware.Size = new System.Drawing.Size(100, 21);
            this.txtHardware.TabIndex = 20;
            // 
            // txtOptions
            // 
            this.txtOptions.Location = new System.Drawing.Point(245, 137);
            this.txtOptions.Name = "txtOptions";
            this.txtOptions.Size = new System.Drawing.Size(180, 21);
            this.txtOptions.TabIndex = 21;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(161, 170);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(77, 12);
            this.lblDescription.TabIndex = 22;
            this.lblDescription.Text = "Description:";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(245, 167);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(240, 75);
            this.txtDescription.TabIndex = 23;
            // 
            // pnlAddConfigure
            // 
            this.pnlAddConfigure.Controls.Add(this.btnCancel);
            this.pnlAddConfigure.Controls.Add(this.btnSaveConfigure);
            this.pnlAddConfigure.Controls.Add(this.txtAddDescription);
            this.pnlAddConfigure.Controls.Add(this.lblAddDescription);
            this.pnlAddConfigure.Controls.Add(this.txtAddOptions);
            this.pnlAddConfigure.Controls.Add(this.txtAddHardware);
            this.pnlAddConfigure.Controls.Add(this.txtAddSystem);
            this.pnlAddConfigure.Controls.Add(this.lblAddOptions);
            this.pnlAddConfigure.Controls.Add(this.lblAddSystem);
            this.pnlAddConfigure.Controls.Add(this.lblAddHardware);
            this.pnlAddConfigure.Location = new System.Drawing.Point(45, 302);
            this.pnlAddConfigure.Name = "pnlAddConfigure";
            this.pnlAddConfigure.Size = new System.Drawing.Size(380, 220);
            this.pnlAddConfigure.TabIndex = 24;
            this.pnlAddConfigure.Visible = false;
            // 
            // txtAddDescription
            // 
            this.txtAddDescription.Location = new System.Drawing.Point(126, 107);
            this.txtAddDescription.Multiline = true;
            this.txtAddDescription.Name = "txtAddDescription";
            this.txtAddDescription.Size = new System.Drawing.Size(240, 70);
            this.txtAddDescription.TabIndex = 31;
            // 
            // lblAddDescription
            // 
            this.lblAddDescription.AutoSize = true;
            this.lblAddDescription.Location = new System.Drawing.Point(42, 110);
            this.lblAddDescription.Name = "lblAddDescription";
            this.lblAddDescription.Size = new System.Drawing.Size(77, 12);
            this.lblAddDescription.TabIndex = 30;
            this.lblAddDescription.Text = "Description:";
            // 
            // txtAddOptions
            // 
            this.txtAddOptions.Location = new System.Drawing.Point(126, 77);
            this.txtAddOptions.Name = "txtAddOptions";
            this.txtAddOptions.Size = new System.Drawing.Size(180, 21);
            this.txtAddOptions.TabIndex = 29;
            // 
            // txtAddHardware
            // 
            this.txtAddHardware.Location = new System.Drawing.Point(126, 7);
            this.txtAddHardware.Name = "txtAddHardware";
            this.txtAddHardware.Size = new System.Drawing.Size(100, 21);
            this.txtAddHardware.TabIndex = 28;
            // 
            // txtAddSystem
            // 
            this.txtAddSystem.Location = new System.Drawing.Point(126, 42);
            this.txtAddSystem.Name = "txtAddSystem";
            this.txtAddSystem.Size = new System.Drawing.Size(100, 21);
            this.txtAddSystem.TabIndex = 27;
            // 
            // lblAddOptions
            // 
            this.lblAddOptions.AutoSize = true;
            this.lblAddOptions.Location = new System.Drawing.Point(66, 80);
            this.lblAddOptions.Name = "lblAddOptions";
            this.lblAddOptions.Size = new System.Drawing.Size(53, 12);
            this.lblAddOptions.TabIndex = 26;
            this.lblAddOptions.Text = "Options:";
            // 
            // lblAddSystem
            // 
            this.lblAddSystem.AutoSize = true;
            this.lblAddSystem.Location = new System.Drawing.Point(13, 45);
            this.lblAddSystem.Name = "lblAddSystem";
            this.lblAddSystem.Size = new System.Drawing.Size(107, 12);
            this.lblAddSystem.TabIndex = 25;
            this.lblAddSystem.Text = "Operating System:";
            // 
            // lblAddHardware
            // 
            this.lblAddHardware.AutoSize = true;
            this.lblAddHardware.Location = new System.Drawing.Point(61, 10);
            this.lblAddHardware.Name = "lblAddHardware";
            this.lblAddHardware.Size = new System.Drawing.Size(59, 12);
            this.lblAddHardware.TabIndex = 24;
            this.lblAddHardware.Text = "Hardware:";
            // 
            // btnSaveConfigure
            // 
            this.btnSaveConfigure.Location = new System.Drawing.Point(15, 185);
            this.btnSaveConfigure.Name = "btnSaveConfigure";
            this.btnSaveConfigure.Size = new System.Drawing.Size(100, 23);
            this.btnSaveConfigure.TabIndex = 32;
            this.btnSaveConfigure.Text = "Save Configure";
            this.btnSaveConfigure.UseVisualStyleBackColor = true;
            this.btnSaveConfigure.Click += new System.EventHandler(this.btnSaveConfigure_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(266, 185);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 23);
            this.btnCancel.TabIndex = 33;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pnlUpdateConfigure
            // 
            this.pnlUpdateConfigure.Controls.Add(this.btnCancel2);
            this.pnlUpdateConfigure.Controls.Add(this.btnSaveChanges);
            this.pnlUpdateConfigure.Controls.Add(this.txtUpdateDescription);
            this.pnlUpdateConfigure.Controls.Add(this.lblUpdateDescription);
            this.pnlUpdateConfigure.Controls.Add(this.txtUpdateOptions);
            this.pnlUpdateConfigure.Controls.Add(this.txtUpdateHardware);
            this.pnlUpdateConfigure.Controls.Add(this.txtUpdateSystem);
            this.pnlUpdateConfigure.Controls.Add(this.lblUpdateOptions);
            this.pnlUpdateConfigure.Controls.Add(this.lblUpdateSystem);
            this.pnlUpdateConfigure.Controls.Add(this.lblUpdateHardware);
            this.pnlUpdateConfigure.Location = new System.Drawing.Point(134, 25);
            this.pnlUpdateConfigure.Name = "pnlUpdateConfigure";
            this.pnlUpdateConfigure.Size = new System.Drawing.Size(380, 220);
            this.pnlUpdateConfigure.TabIndex = 34;
            this.pnlUpdateConfigure.Visible = false;
            // 
            // btnCancel2
            // 
            this.btnCancel2.Location = new System.Drawing.Point(266, 185);
            this.btnCancel2.Name = "btnCancel2";
            this.btnCancel2.Size = new System.Drawing.Size(100, 23);
            this.btnCancel2.TabIndex = 33;
            this.btnCancel2.Text = "Cancel";
            this.btnCancel2.UseVisualStyleBackColor = true;
            this.btnCancel2.Click += new System.EventHandler(this.btnCancel2_Click);
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Location = new System.Drawing.Point(15, 185);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(100, 23);
            this.btnSaveChanges.TabIndex = 32;
            this.btnSaveChanges.Text = "Save Changes";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // txtUpdateDescription
            // 
            this.txtUpdateDescription.Location = new System.Drawing.Point(126, 107);
            this.txtUpdateDescription.Multiline = true;
            this.txtUpdateDescription.Name = "txtUpdateDescription";
            this.txtUpdateDescription.Size = new System.Drawing.Size(240, 70);
            this.txtUpdateDescription.TabIndex = 31;
            // 
            // lblUpdateDescription
            // 
            this.lblUpdateDescription.AutoSize = true;
            this.lblUpdateDescription.Location = new System.Drawing.Point(42, 110);
            this.lblUpdateDescription.Name = "lblUpdateDescription";
            this.lblUpdateDescription.Size = new System.Drawing.Size(77, 12);
            this.lblUpdateDescription.TabIndex = 30;
            this.lblUpdateDescription.Text = "Description:";
            // 
            // txtUpdateOptions
            // 
            this.txtUpdateOptions.Location = new System.Drawing.Point(126, 77);
            this.txtUpdateOptions.Name = "txtUpdateOptions";
            this.txtUpdateOptions.Size = new System.Drawing.Size(180, 21);
            this.txtUpdateOptions.TabIndex = 29;
            // 
            // txtUpdateHardware
            // 
            this.txtUpdateHardware.Location = new System.Drawing.Point(126, 7);
            this.txtUpdateHardware.Name = "txtUpdateHardware";
            this.txtUpdateHardware.Size = new System.Drawing.Size(100, 21);
            this.txtUpdateHardware.TabIndex = 28;
            // 
            // txtUpdateSystem
            // 
            this.txtUpdateSystem.Location = new System.Drawing.Point(126, 42);
            this.txtUpdateSystem.Name = "txtUpdateSystem";
            this.txtUpdateSystem.Size = new System.Drawing.Size(100, 21);
            this.txtUpdateSystem.TabIndex = 27;
            // 
            // lblUpdateOptions
            // 
            this.lblUpdateOptions.AutoSize = true;
            this.lblUpdateOptions.Location = new System.Drawing.Point(66, 80);
            this.lblUpdateOptions.Name = "lblUpdateOptions";
            this.lblUpdateOptions.Size = new System.Drawing.Size(53, 12);
            this.lblUpdateOptions.TabIndex = 26;
            this.lblUpdateOptions.Text = "Options:";
            // 
            // lblUpdateSystem
            // 
            this.lblUpdateSystem.AutoSize = true;
            this.lblUpdateSystem.Location = new System.Drawing.Point(13, 45);
            this.lblUpdateSystem.Name = "lblUpdateSystem";
            this.lblUpdateSystem.Size = new System.Drawing.Size(107, 12);
            this.lblUpdateSystem.TabIndex = 25;
            this.lblUpdateSystem.Text = "Operating System:";
            // 
            // lblUpdateHardware
            // 
            this.lblUpdateHardware.AutoSize = true;
            this.lblUpdateHardware.Location = new System.Drawing.Point(61, 10);
            this.lblUpdateHardware.Name = "lblUpdateHardware";
            this.lblUpdateHardware.Size = new System.Drawing.Size(59, 12);
            this.lblUpdateHardware.TabIndex = 24;
            this.lblUpdateHardware.Text = "Hardware:";
            // 
            // ConfigureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 337);
            this.Controls.Add(this.pnlUpdateConfigure);
            this.Controls.Add(this.pnlAddConfigure);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtOptions);
            this.Controls.Add(this.txtHardware);
            this.Controls.Add(this.txtSystem);
            this.Controls.Add(this.lblOptions);
            this.Controls.Add(this.lblSystem);
            this.Controls.Add(this.lblHardware);
            this.Controls.Add(this.txtConfigureID);
            this.Controls.Add(this.lblConfigureID);
            this.Controls.Add(this.btnDeleteConfigure);
            this.Controls.Add(this.btnUpdateConfigure);
            this.Controls.Add(this.btnAddConfigure);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.lstConfigure);
            this.Name = "ConfigureForm";
            this.Text = "Configure Maintenance";
            this.pnlAddConfigure.ResumeLayout(false);
            this.pnlAddConfigure.PerformLayout();
            this.pnlUpdateConfigure.ResumeLayout(false);
            this.pnlUpdateConfigure.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstConfigure;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnAddConfigure;
        private System.Windows.Forms.Button btnUpdateConfigure;
        private System.Windows.Forms.Button btnDeleteConfigure;
        private System.Windows.Forms.Label lblConfigureID;
        private System.Windows.Forms.TextBox txtConfigureID;
        private System.Windows.Forms.Label lblHardware;
        private System.Windows.Forms.Label lblSystem;
        private System.Windows.Forms.Label lblOptions;
        private System.Windows.Forms.TextBox txtSystem;
        private System.Windows.Forms.TextBox txtHardware;
        private System.Windows.Forms.TextBox txtOptions;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Panel pnlAddConfigure;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSaveConfigure;
        private System.Windows.Forms.TextBox txtAddDescription;
        private System.Windows.Forms.Label lblAddDescription;
        private System.Windows.Forms.TextBox txtAddOptions;
        private System.Windows.Forms.TextBox txtAddHardware;
        private System.Windows.Forms.TextBox txtAddSystem;
        private System.Windows.Forms.Label lblAddOptions;
        private System.Windows.Forms.Label lblAddSystem;
        private System.Windows.Forms.Label lblAddHardware;
        private System.Windows.Forms.Panel pnlUpdateConfigure;
        private System.Windows.Forms.Button btnCancel2;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.TextBox txtUpdateDescription;
        private System.Windows.Forms.Label lblUpdateDescription;
        private System.Windows.Forms.TextBox txtUpdateOptions;
        private System.Windows.Forms.TextBox txtUpdateHardware;
        private System.Windows.Forms.TextBox txtUpdateSystem;
        private System.Windows.Forms.Label lblUpdateOptions;
        private System.Windows.Forms.Label lblUpdateSystem;
        private System.Windows.Forms.Label lblUpdateHardware;
    }
}