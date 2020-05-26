namespace ABCTestProject
{
    partial class DataModule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataModule));
            this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
            this.ctnABCTestProject = new System.Data.OleDb.OleDbConnection();
            this.oleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDeleteCommand1 = new System.Data.OleDb.OleDbCommand();
            this.daBug = new System.Data.OleDb.OleDbDataAdapter();
            this.oleDbSelectCommand3 = new System.Data.OleDb.OleDbCommand();
            this.oleDbInsertCommand3 = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand3 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDeleteCommand3 = new System.Data.OleDb.OleDbCommand();
            this.daEmployee = new System.Data.OleDb.OleDbDataAdapter();
            this.oleDbSelectCommand4 = new System.Data.OleDb.OleDbCommand();
            this.oleDbInsertCommand4 = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand4 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDeleteCommand4 = new System.Data.OleDb.OleDbCommand();
            this.daProject = new System.Data.OleDb.OleDbDataAdapter();
            this.oleDbSelectCommand5 = new System.Data.OleDb.OleDbCommand();
            this.oleDbInsertCommand5 = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand5 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDeleteCommand5 = new System.Data.OleDb.OleDbCommand();
            this.daTest = new System.Data.OleDb.OleDbDataAdapter();
            this.oleDbSelectCommand6 = new System.Data.OleDb.OleDbCommand();
            this.oleDbInsertCommand6 = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand6 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDeleteCommand6 = new System.Data.OleDb.OleDbCommand();
            this.daTestCase = new System.Data.OleDb.OleDbDataAdapter();
            this.oleDbSelectCommand7 = new System.Data.OleDb.OleDbCommand();
            this.oleDbInsertCommand7 = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand7 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDeleteCommand7 = new System.Data.OleDb.OleDbCommand();
            this.daUseCase = new System.Data.OleDb.OleDbDataAdapter();
            this.oleDbSelectCommand8 = new System.Data.OleDb.OleDbCommand();
            this.oleDbInsertCommand8 = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand8 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDeleteCommand8 = new System.Data.OleDb.OleDbCommand();
            this.daCategory = new System.Data.OleDb.OleDbDataAdapter();
            this.oleDbSelectCommand9 = new System.Data.OleDb.OleDbCommand();
            this.oleDbInsertCommand9 = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand9 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDeleteCommand9 = new System.Data.OleDb.OleDbCommand();
            this.daPriority = new System.Data.OleDb.OleDbDataAdapter();
            this.oleDbSelectCommand10 = new System.Data.OleDb.OleDbCommand();
            this.oleDbInsertCommand10 = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand10 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDeleteCommand10 = new System.Data.OleDb.OleDbCommand();
            this.daSeverity = new System.Data.OleDb.OleDbDataAdapter();
            this.oleDbSelectCommand2 = new System.Data.OleDb.OleDbCommand();
            this.oleDbInsertCommand2 = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand2 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDeleteCommand2 = new System.Data.OleDb.OleDbCommand();
            this.daConfigure = new System.Data.OleDb.OleDbDataAdapter();
            this.dsABCTestProject = new ABCTestProject.DSABCTestProject();
            ((System.ComponentModel.ISupportInitialize)(this.dsABCTestProject)).BeginInit();
            this.SuspendLayout();
            // 
            // oleDbSelectCommand1
            // 
            this.oleDbSelectCommand1.CommandText = "SELECT        Bug.*\r\nFROM            Bug\r\nORDER BY BugID";
            this.oleDbSelectCommand1.Connection = this.ctnABCTestProject;
            // 
            // ctnABCTestProject
            // 
            this.ctnABCTestProject.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Temp\\ABCTestProject.accdb";
            // 
            // oleDbInsertCommand1
            // 
            this.oleDbInsertCommand1.CommandText = resources.GetString("oleDbInsertCommand1.CommandText");
            this.oleDbInsertCommand1.Connection = this.ctnABCTestProject;
            this.oleDbInsertCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("TestID", System.Data.OleDb.OleDbType.Integer, 0, "TestID"),
            new System.Data.OleDb.OleDbParameter("Status", System.Data.OleDb.OleDbType.VarWChar, 0, "Status"),
            new System.Data.OleDb.OleDbParameter("Assigned", System.Data.OleDb.OleDbType.VarWChar, 0, "Assigned"),
            new System.Data.OleDb.OleDbParameter("EmployeeID", System.Data.OleDb.OleDbType.Integer, 0, "EmployeeID"),
            new System.Data.OleDb.OleDbParameter("SeverityID", System.Data.OleDb.OleDbType.Integer, 0, "SeverityID"),
            new System.Data.OleDb.OleDbParameter("PriorityID", System.Data.OleDb.OleDbType.Integer, 0, "PriorityID"),
            new System.Data.OleDb.OleDbParameter("DateDetected", System.Data.OleDb.OleDbType.Date, 0, "DateDetected"),
            new System.Data.OleDb.OleDbParameter("DateFinished", System.Data.OleDb.OleDbType.Date, 0, "DateFinished"),
            new System.Data.OleDb.OleDbParameter("Comment", System.Data.OleDb.OleDbType.LongVarWChar, 0, "Comment"),
            new System.Data.OleDb.OleDbParameter("BugAbb", System.Data.OleDb.OleDbType.VarWChar, 0, "BugAbb"),
            new System.Data.OleDb.OleDbParameter("ActualDate", System.Data.OleDb.OleDbType.Date, 0, "ActualDate"),
            new System.Data.OleDb.OleDbParameter("Rating", System.Data.OleDb.OleDbType.Integer, 0, "Rating")});
            // 
            // oleDbUpdateCommand1
            // 
            this.oleDbUpdateCommand1.CommandText = resources.GetString("oleDbUpdateCommand1.CommandText");
            this.oleDbUpdateCommand1.Connection = this.ctnABCTestProject;
            this.oleDbUpdateCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("TestID", System.Data.OleDb.OleDbType.Integer, 0, "TestID"),
            new System.Data.OleDb.OleDbParameter("Status", System.Data.OleDb.OleDbType.VarWChar, 0, "Status"),
            new System.Data.OleDb.OleDbParameter("Assigned", System.Data.OleDb.OleDbType.VarWChar, 0, "Assigned"),
            new System.Data.OleDb.OleDbParameter("EmployeeID", System.Data.OleDb.OleDbType.Integer, 0, "EmployeeID"),
            new System.Data.OleDb.OleDbParameter("SeverityID", System.Data.OleDb.OleDbType.Integer, 0, "SeverityID"),
            new System.Data.OleDb.OleDbParameter("PriorityID", System.Data.OleDb.OleDbType.Integer, 0, "PriorityID"),
            new System.Data.OleDb.OleDbParameter("DateDetected", System.Data.OleDb.OleDbType.Date, 0, "DateDetected"),
            new System.Data.OleDb.OleDbParameter("DateFinished", System.Data.OleDb.OleDbType.Date, 0, "DateFinished"),
            new System.Data.OleDb.OleDbParameter("Comment", System.Data.OleDb.OleDbType.LongVarWChar, 0, "Comment"),
            new System.Data.OleDb.OleDbParameter("BugAbb", System.Data.OleDb.OleDbType.VarWChar, 0, "BugAbb"),
            new System.Data.OleDb.OleDbParameter("ActualDate", System.Data.OleDb.OleDbType.Date, 0, "ActualDate"),
            new System.Data.OleDb.OleDbParameter("Rating", System.Data.OleDb.OleDbType.Integer, 0, "Rating"),
            new System.Data.OleDb.OleDbParameter("IsNull_TestID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "TestID", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_TestID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "TestID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Status", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Status", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Status", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Status", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Assigned", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Assigned", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Assigned", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Assigned", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_EmployeeID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "EmployeeID", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_EmployeeID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "EmployeeID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_SeverityID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "SeverityID", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_SeverityID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "SeverityID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_PriorityID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PriorityID", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_PriorityID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PriorityID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_DateDetected", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "DateDetected", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_DateDetected", System.Data.OleDb.OleDbType.Date, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "DateDetected", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_DateFinished", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "DateFinished", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_DateFinished", System.Data.OleDb.OleDbType.Date, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "DateFinished", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_BugAbb", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "BugAbb", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_BugAbb", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "BugAbb", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_ActualDate", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ActualDate", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_ActualDate", System.Data.OleDb.OleDbType.Date, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ActualDate", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Rating", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Rating", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Rating", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Rating", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_BugID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "BugID", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDeleteCommand1
            // 
            this.oleDbDeleteCommand1.CommandText = resources.GetString("oleDbDeleteCommand1.CommandText");
            this.oleDbDeleteCommand1.Connection = this.ctnABCTestProject;
            this.oleDbDeleteCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("IsNull_TestID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "TestID", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_TestID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "TestID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Status", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Status", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Status", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Status", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Assigned", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Assigned", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Assigned", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Assigned", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_EmployeeID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "EmployeeID", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_EmployeeID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "EmployeeID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_SeverityID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "SeverityID", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_SeverityID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "SeverityID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_PriorityID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PriorityID", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_PriorityID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PriorityID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_DateDetected", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "DateDetected", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_DateDetected", System.Data.OleDb.OleDbType.Date, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "DateDetected", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_DateFinished", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "DateFinished", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_DateFinished", System.Data.OleDb.OleDbType.Date, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "DateFinished", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_BugAbb", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "BugAbb", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_BugAbb", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "BugAbb", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_ActualDate", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ActualDate", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_ActualDate", System.Data.OleDb.OleDbType.Date, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ActualDate", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Rating", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Rating", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Rating", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Rating", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_BugID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "BugID", System.Data.DataRowVersion.Original, null)});
            // 
            // daBug
            // 
            this.daBug.DeleteCommand = this.oleDbDeleteCommand1;
            this.daBug.InsertCommand = this.oleDbInsertCommand1;
            this.daBug.SelectCommand = this.oleDbSelectCommand1;
            this.daBug.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Bug", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("TestID", "TestID"),
                        new System.Data.Common.DataColumnMapping("Status", "Status"),
                        new System.Data.Common.DataColumnMapping("Assigned", "Assigned"),
                        new System.Data.Common.DataColumnMapping("EmployeeID", "EmployeeID"),
                        new System.Data.Common.DataColumnMapping("SeverityID", "SeverityID"),
                        new System.Data.Common.DataColumnMapping("PriorityID", "PriorityID"),
                        new System.Data.Common.DataColumnMapping("DateDetected", "DateDetected"),
                        new System.Data.Common.DataColumnMapping("DateFinished", "DateFinished"),
                        new System.Data.Common.DataColumnMapping("Comment", "Comment"),
                        new System.Data.Common.DataColumnMapping("BugAbb", "BugAbb"),
                        new System.Data.Common.DataColumnMapping("ActualDate", "ActualDate"),
                        new System.Data.Common.DataColumnMapping("Rating", "Rating"),
                        new System.Data.Common.DataColumnMapping("BugID", "BugID")})});
            this.daBug.UpdateCommand = this.oleDbUpdateCommand1;
            this.daBug.RowUpdated += new System.Data.OleDb.OleDbRowUpdatedEventHandler(this.daBug_RowUpdated);
            // 
            // oleDbSelectCommand3
            // 
            this.oleDbSelectCommand3.CommandText = "SELECT        Employee.*\r\nFROM            Employee\r\nORDER BY EmployeeID";
            this.oleDbSelectCommand3.Connection = this.ctnABCTestProject;
            // 
            // oleDbInsertCommand3
            // 
            this.oleDbInsertCommand3.CommandText = "INSERT INTO `Employee` (`FirstName`, `LastName`, `JobTitle`, `Ext`, `Email`) VALU" +
    "ES (?, ?, ?, ?, ?)";
            this.oleDbInsertCommand3.Connection = this.ctnABCTestProject;
            this.oleDbInsertCommand3.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("FirstName", System.Data.OleDb.OleDbType.VarWChar, 0, "FirstName"),
            new System.Data.OleDb.OleDbParameter("LastName", System.Data.OleDb.OleDbType.VarWChar, 0, "LastName"),
            new System.Data.OleDb.OleDbParameter("JobTitle", System.Data.OleDb.OleDbType.VarWChar, 0, "JobTitle"),
            new System.Data.OleDb.OleDbParameter("Ext", System.Data.OleDb.OleDbType.Integer, 0, "Ext"),
            new System.Data.OleDb.OleDbParameter("Email", System.Data.OleDb.OleDbType.VarWChar, 0, "Email")});
            // 
            // oleDbUpdateCommand3
            // 
            this.oleDbUpdateCommand3.CommandText = resources.GetString("oleDbUpdateCommand3.CommandText");
            this.oleDbUpdateCommand3.Connection = this.ctnABCTestProject;
            this.oleDbUpdateCommand3.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("FirstName", System.Data.OleDb.OleDbType.VarWChar, 0, "FirstName"),
            new System.Data.OleDb.OleDbParameter("LastName", System.Data.OleDb.OleDbType.VarWChar, 0, "LastName"),
            new System.Data.OleDb.OleDbParameter("JobTitle", System.Data.OleDb.OleDbType.VarWChar, 0, "JobTitle"),
            new System.Data.OleDb.OleDbParameter("Ext", System.Data.OleDb.OleDbType.Integer, 0, "Ext"),
            new System.Data.OleDb.OleDbParameter("Email", System.Data.OleDb.OleDbType.VarWChar, 0, "Email"),
            new System.Data.OleDb.OleDbParameter("Original_EmployeeID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "EmployeeID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_FirstName", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "FirstName", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_FirstName", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "FirstName", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_LastName", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "LastName", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_LastName", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "LastName", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_JobTitle", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "JobTitle", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_JobTitle", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "JobTitle", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Ext", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Ext", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Ext", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Ext", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Email", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Email", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Email", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Email", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDeleteCommand3
            // 
            this.oleDbDeleteCommand3.CommandText = resources.GetString("oleDbDeleteCommand3.CommandText");
            this.oleDbDeleteCommand3.Connection = this.ctnABCTestProject;
            this.oleDbDeleteCommand3.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Original_EmployeeID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "EmployeeID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_FirstName", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "FirstName", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_FirstName", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "FirstName", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_LastName", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "LastName", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_LastName", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "LastName", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_JobTitle", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "JobTitle", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_JobTitle", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "JobTitle", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Ext", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Ext", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Ext", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Ext", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Email", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Email", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Email", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Email", System.Data.DataRowVersion.Original, null)});
            // 
            // daEmployee
            // 
            this.daEmployee.DeleteCommand = this.oleDbDeleteCommand3;
            this.daEmployee.InsertCommand = this.oleDbInsertCommand3;
            this.daEmployee.SelectCommand = this.oleDbSelectCommand3;
            this.daEmployee.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Employee", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("EmployeeID", "EmployeeID"),
                        new System.Data.Common.DataColumnMapping("FirstName", "FirstName"),
                        new System.Data.Common.DataColumnMapping("LastName", "LastName"),
                        new System.Data.Common.DataColumnMapping("JobTitle", "JobTitle"),
                        new System.Data.Common.DataColumnMapping("Ext", "Ext"),
                        new System.Data.Common.DataColumnMapping("Email", "Email")})});
            this.daEmployee.UpdateCommand = this.oleDbUpdateCommand3;
            this.daEmployee.RowUpdated += new System.Data.OleDb.OleDbRowUpdatedEventHandler(this.daEmployee_RowUpdated);
            // 
            // oleDbSelectCommand4
            // 
            this.oleDbSelectCommand4.CommandText = "SELECT        Project.*\r\nFROM            Project\r\nORDER BY ProjectID";
            this.oleDbSelectCommand4.Connection = this.ctnABCTestProject;
            // 
            // oleDbInsertCommand4
            // 
            this.oleDbInsertCommand4.CommandText = "INSERT INTO `Project` (`ProjectName`, `DateStart`, `DateEnd`, `Description`, `Pro" +
    "jectAbb`) VALUES (?, ?, ?, ?, ?)";
            this.oleDbInsertCommand4.Connection = this.ctnABCTestProject;
            this.oleDbInsertCommand4.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("ProjectName", System.Data.OleDb.OleDbType.VarWChar, 0, "ProjectName"),
            new System.Data.OleDb.OleDbParameter("DateStart", System.Data.OleDb.OleDbType.Date, 0, "DateStart"),
            new System.Data.OleDb.OleDbParameter("DateEnd", System.Data.OleDb.OleDbType.Date, 0, "DateEnd"),
            new System.Data.OleDb.OleDbParameter("Description", System.Data.OleDb.OleDbType.LongVarWChar, 0, "Description"),
            new System.Data.OleDb.OleDbParameter("ProjectAbb", System.Data.OleDb.OleDbType.VarWChar, 0, "ProjectAbb")});
            // 
            // oleDbUpdateCommand4
            // 
            this.oleDbUpdateCommand4.CommandText = resources.GetString("oleDbUpdateCommand4.CommandText");
            this.oleDbUpdateCommand4.Connection = this.ctnABCTestProject;
            this.oleDbUpdateCommand4.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("ProjectName", System.Data.OleDb.OleDbType.VarWChar, 0, "ProjectName"),
            new System.Data.OleDb.OleDbParameter("DateStart", System.Data.OleDb.OleDbType.Date, 0, "DateStart"),
            new System.Data.OleDb.OleDbParameter("DateEnd", System.Data.OleDb.OleDbType.Date, 0, "DateEnd"),
            new System.Data.OleDb.OleDbParameter("Description", System.Data.OleDb.OleDbType.LongVarWChar, 0, "Description"),
            new System.Data.OleDb.OleDbParameter("ProjectAbb", System.Data.OleDb.OleDbType.VarWChar, 0, "ProjectAbb"),
            new System.Data.OleDb.OleDbParameter("Original_ProjectID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ProjectID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_ProjectName", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ProjectName", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_ProjectName", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ProjectName", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_DateStart", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "DateStart", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_DateStart", System.Data.OleDb.OleDbType.Date, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "DateStart", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_DateEnd", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "DateEnd", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_DateEnd", System.Data.OleDb.OleDbType.Date, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "DateEnd", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_ProjectAbb", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ProjectAbb", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_ProjectAbb", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ProjectAbb", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDeleteCommand4
            // 
            this.oleDbDeleteCommand4.CommandText = resources.GetString("oleDbDeleteCommand4.CommandText");
            this.oleDbDeleteCommand4.Connection = this.ctnABCTestProject;
            this.oleDbDeleteCommand4.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Original_ProjectID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ProjectID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_ProjectName", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ProjectName", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_ProjectName", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ProjectName", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_DateStart", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "DateStart", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_DateStart", System.Data.OleDb.OleDbType.Date, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "DateStart", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_DateEnd", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "DateEnd", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_DateEnd", System.Data.OleDb.OleDbType.Date, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "DateEnd", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_ProjectAbb", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ProjectAbb", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_ProjectAbb", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ProjectAbb", System.Data.DataRowVersion.Original, null)});
            // 
            // daProject
            // 
            this.daProject.DeleteCommand = this.oleDbDeleteCommand4;
            this.daProject.InsertCommand = this.oleDbInsertCommand4;
            this.daProject.SelectCommand = this.oleDbSelectCommand4;
            this.daProject.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Project", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("ProjectID", "ProjectID"),
                        new System.Data.Common.DataColumnMapping("ProjectName", "ProjectName"),
                        new System.Data.Common.DataColumnMapping("DateStart", "DateStart"),
                        new System.Data.Common.DataColumnMapping("DateEnd", "DateEnd"),
                        new System.Data.Common.DataColumnMapping("Description", "Description"),
                        new System.Data.Common.DataColumnMapping("ProjectAbb", "ProjectAbb")})});
            this.daProject.UpdateCommand = this.oleDbUpdateCommand4;
            this.daProject.RowUpdated += new System.Data.OleDb.OleDbRowUpdatedEventHandler(this.daProject_RowUpdated);
            // 
            // oleDbSelectCommand5
            // 
            this.oleDbSelectCommand5.CommandText = "SELECT        Test.*\r\nFROM            Test\r\nORDER BY TestID";
            this.oleDbSelectCommand5.Connection = this.ctnABCTestProject;
            // 
            // oleDbInsertCommand5
            // 
            this.oleDbInsertCommand5.CommandText = "INSERT INTO `Test` (`TestCaseID`, `DateStart`, `DateEnd`, `Steps`, `EmployeeID`, " +
    "`ConfigureID`, `TestAbb`, `Status`, `Comment`, `CategoryID`) VALUES (?, ?, ?, ?," +
    " ?, ?, ?, ?, ?, ?)";
            this.oleDbInsertCommand5.Connection = this.ctnABCTestProject;
            this.oleDbInsertCommand5.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("TestCaseID", System.Data.OleDb.OleDbType.Integer, 0, "TestCaseID"),
            new System.Data.OleDb.OleDbParameter("DateStart", System.Data.OleDb.OleDbType.Date, 0, "DateStart"),
            new System.Data.OleDb.OleDbParameter("DateEnd", System.Data.OleDb.OleDbType.Date, 0, "DateEnd"),
            new System.Data.OleDb.OleDbParameter("Steps", System.Data.OleDb.OleDbType.LongVarWChar, 0, "Steps"),
            new System.Data.OleDb.OleDbParameter("EmployeeID", System.Data.OleDb.OleDbType.Integer, 0, "EmployeeID"),
            new System.Data.OleDb.OleDbParameter("ConfigureID", System.Data.OleDb.OleDbType.Integer, 0, "ConfigureID"),
            new System.Data.OleDb.OleDbParameter("TestAbb", System.Data.OleDb.OleDbType.VarWChar, 0, "TestAbb"),
            new System.Data.OleDb.OleDbParameter("Status", System.Data.OleDb.OleDbType.VarWChar, 0, "Status"),
            new System.Data.OleDb.OleDbParameter("Comment", System.Data.OleDb.OleDbType.LongVarWChar, 0, "Comment"),
            new System.Data.OleDb.OleDbParameter("CategoryID", System.Data.OleDb.OleDbType.Integer, 0, "CategoryID")});
            // 
            // oleDbUpdateCommand5
            // 
            this.oleDbUpdateCommand5.CommandText = resources.GetString("oleDbUpdateCommand5.CommandText");
            this.oleDbUpdateCommand5.Connection = this.ctnABCTestProject;
            this.oleDbUpdateCommand5.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("TestCaseID", System.Data.OleDb.OleDbType.Integer, 0, "TestCaseID"),
            new System.Data.OleDb.OleDbParameter("DateStart", System.Data.OleDb.OleDbType.Date, 0, "DateStart"),
            new System.Data.OleDb.OleDbParameter("DateEnd", System.Data.OleDb.OleDbType.Date, 0, "DateEnd"),
            new System.Data.OleDb.OleDbParameter("Steps", System.Data.OleDb.OleDbType.LongVarWChar, 0, "Steps"),
            new System.Data.OleDb.OleDbParameter("EmployeeID", System.Data.OleDb.OleDbType.Integer, 0, "EmployeeID"),
            new System.Data.OleDb.OleDbParameter("ConfigureID", System.Data.OleDb.OleDbType.Integer, 0, "ConfigureID"),
            new System.Data.OleDb.OleDbParameter("TestAbb", System.Data.OleDb.OleDbType.VarWChar, 0, "TestAbb"),
            new System.Data.OleDb.OleDbParameter("Status", System.Data.OleDb.OleDbType.VarWChar, 0, "Status"),
            new System.Data.OleDb.OleDbParameter("Comment", System.Data.OleDb.OleDbType.LongVarWChar, 0, "Comment"),
            new System.Data.OleDb.OleDbParameter("CategoryID", System.Data.OleDb.OleDbType.Integer, 0, "CategoryID"),
            new System.Data.OleDb.OleDbParameter("Original_TestID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "TestID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_TestCaseID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "TestCaseID", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_TestCaseID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "TestCaseID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_DateStart", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "DateStart", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_DateStart", System.Data.OleDb.OleDbType.Date, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "DateStart", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_DateEnd", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "DateEnd", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_DateEnd", System.Data.OleDb.OleDbType.Date, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "DateEnd", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_EmployeeID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "EmployeeID", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_EmployeeID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "EmployeeID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_ConfigureID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ConfigureID", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_ConfigureID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ConfigureID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_TestAbb", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "TestAbb", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_TestAbb", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "TestAbb", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Status", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Status", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Status", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Status", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_CategoryID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "CategoryID", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_CategoryID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CategoryID", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDeleteCommand5
            // 
            this.oleDbDeleteCommand5.CommandText = resources.GetString("oleDbDeleteCommand5.CommandText");
            this.oleDbDeleteCommand5.Connection = this.ctnABCTestProject;
            this.oleDbDeleteCommand5.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Original_TestID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "TestID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_TestCaseID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "TestCaseID", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_TestCaseID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "TestCaseID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_DateStart", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "DateStart", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_DateStart", System.Data.OleDb.OleDbType.Date, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "DateStart", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_DateEnd", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "DateEnd", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_DateEnd", System.Data.OleDb.OleDbType.Date, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "DateEnd", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_EmployeeID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "EmployeeID", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_EmployeeID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "EmployeeID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_ConfigureID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ConfigureID", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_ConfigureID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ConfigureID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_TestAbb", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "TestAbb", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_TestAbb", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "TestAbb", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Status", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Status", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Status", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Status", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_CategoryID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "CategoryID", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_CategoryID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CategoryID", System.Data.DataRowVersion.Original, null)});
            // 
            // daTest
            // 
            this.daTest.DeleteCommand = this.oleDbDeleteCommand5;
            this.daTest.InsertCommand = this.oleDbInsertCommand5;
            this.daTest.SelectCommand = this.oleDbSelectCommand5;
            this.daTest.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Test", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("TestID", "TestID"),
                        new System.Data.Common.DataColumnMapping("TestCaseID", "TestCaseID"),
                        new System.Data.Common.DataColumnMapping("DateStart", "DateStart"),
                        new System.Data.Common.DataColumnMapping("DateEnd", "DateEnd"),
                        new System.Data.Common.DataColumnMapping("Steps", "Steps"),
                        new System.Data.Common.DataColumnMapping("EmployeeID", "EmployeeID"),
                        new System.Data.Common.DataColumnMapping("ConfigureID", "ConfigureID"),
                        new System.Data.Common.DataColumnMapping("TestAbb", "TestAbb"),
                        new System.Data.Common.DataColumnMapping("Status", "Status"),
                        new System.Data.Common.DataColumnMapping("Comment", "Comment"),
                        new System.Data.Common.DataColumnMapping("CategoryID", "CategoryID")})});
            this.daTest.UpdateCommand = this.oleDbUpdateCommand5;
            this.daTest.RowUpdated += new System.Data.OleDb.OleDbRowUpdatedEventHandler(this.daTest_RowUpdated);
            // 
            // oleDbSelectCommand6
            // 
            this.oleDbSelectCommand6.CommandText = "SELECT        TestCase.*\r\nFROM            TestCase\r\nORDER BY TestCaseID";
            this.oleDbSelectCommand6.Connection = this.ctnABCTestProject;
            // 
            // oleDbInsertCommand6
            // 
            this.oleDbInsertCommand6.CommandText = "INSERT INTO `TestCase` (`UseCaseID`, `Description`, `TestCaseAbb`, `Title`) VALUE" +
    "S (?, ?, ?, ?)";
            this.oleDbInsertCommand6.Connection = this.ctnABCTestProject;
            this.oleDbInsertCommand6.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("UseCaseID", System.Data.OleDb.OleDbType.Integer, 0, "UseCaseID"),
            new System.Data.OleDb.OleDbParameter("Description", System.Data.OleDb.OleDbType.LongVarWChar, 0, "Description"),
            new System.Data.OleDb.OleDbParameter("TestCaseAbb", System.Data.OleDb.OleDbType.VarWChar, 0, "TestCaseAbb"),
            new System.Data.OleDb.OleDbParameter("Title", System.Data.OleDb.OleDbType.VarWChar, 0, "Title")});
            // 
            // oleDbUpdateCommand6
            // 
            this.oleDbUpdateCommand6.CommandText = resources.GetString("oleDbUpdateCommand6.CommandText");
            this.oleDbUpdateCommand6.Connection = this.ctnABCTestProject;
            this.oleDbUpdateCommand6.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("UseCaseID", System.Data.OleDb.OleDbType.Integer, 0, "UseCaseID"),
            new System.Data.OleDb.OleDbParameter("Description", System.Data.OleDb.OleDbType.LongVarWChar, 0, "Description"),
            new System.Data.OleDb.OleDbParameter("TestCaseAbb", System.Data.OleDb.OleDbType.VarWChar, 0, "TestCaseAbb"),
            new System.Data.OleDb.OleDbParameter("Title", System.Data.OleDb.OleDbType.VarWChar, 0, "Title"),
            new System.Data.OleDb.OleDbParameter("Original_TestCaseID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "TestCaseID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_UseCaseID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "UseCaseID", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_UseCaseID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "UseCaseID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_TestCaseAbb", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "TestCaseAbb", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_TestCaseAbb", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "TestCaseAbb", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Title", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Title", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Title", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Title", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDeleteCommand6
            // 
            this.oleDbDeleteCommand6.CommandText = resources.GetString("oleDbDeleteCommand6.CommandText");
            this.oleDbDeleteCommand6.Connection = this.ctnABCTestProject;
            this.oleDbDeleteCommand6.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Original_TestCaseID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "TestCaseID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_UseCaseID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "UseCaseID", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_UseCaseID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "UseCaseID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_TestCaseAbb", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "TestCaseAbb", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_TestCaseAbb", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "TestCaseAbb", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Title", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Title", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Title", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Title", System.Data.DataRowVersion.Original, null)});
            // 
            // daTestCase
            // 
            this.daTestCase.DeleteCommand = this.oleDbDeleteCommand6;
            this.daTestCase.InsertCommand = this.oleDbInsertCommand6;
            this.daTestCase.SelectCommand = this.oleDbSelectCommand6;
            this.daTestCase.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "TestCase", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("TestCaseID", "TestCaseID"),
                        new System.Data.Common.DataColumnMapping("UseCaseID", "UseCaseID"),
                        new System.Data.Common.DataColumnMapping("Description", "Description"),
                        new System.Data.Common.DataColumnMapping("TestCaseAbb", "TestCaseAbb"),
                        new System.Data.Common.DataColumnMapping("Title", "Title")})});
            this.daTestCase.UpdateCommand = this.oleDbUpdateCommand6;
            this.daTestCase.RowUpdated += new System.Data.OleDb.OleDbRowUpdatedEventHandler(this.daTestCase_RowUpdated);
            // 
            // oleDbSelectCommand7
            // 
            this.oleDbSelectCommand7.CommandText = "SELECT        UseCase.*\r\nFROM            UseCase\r\nORDER BY UseCaseID";
            this.oleDbSelectCommand7.Connection = this.ctnABCTestProject;
            // 
            // oleDbInsertCommand7
            // 
            this.oleDbInsertCommand7.CommandText = "INSERT INTO `UseCase` (`ProjectID`, `Description`, `UseCaseAbb`) VALUES (?, ?, ?)" +
    "";
            this.oleDbInsertCommand7.Connection = this.ctnABCTestProject;
            this.oleDbInsertCommand7.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("ProjectID", System.Data.OleDb.OleDbType.Integer, 0, "ProjectID"),
            new System.Data.OleDb.OleDbParameter("Description", System.Data.OleDb.OleDbType.VarWChar, 0, "Description"),
            new System.Data.OleDb.OleDbParameter("UseCaseAbb", System.Data.OleDb.OleDbType.VarWChar, 0, "UseCaseAbb")});
            // 
            // oleDbUpdateCommand7
            // 
            this.oleDbUpdateCommand7.CommandText = resources.GetString("oleDbUpdateCommand7.CommandText");
            this.oleDbUpdateCommand7.Connection = this.ctnABCTestProject;
            this.oleDbUpdateCommand7.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("ProjectID", System.Data.OleDb.OleDbType.Integer, 0, "ProjectID"),
            new System.Data.OleDb.OleDbParameter("Description", System.Data.OleDb.OleDbType.VarWChar, 0, "Description"),
            new System.Data.OleDb.OleDbParameter("UseCaseAbb", System.Data.OleDb.OleDbType.VarWChar, 0, "UseCaseAbb"),
            new System.Data.OleDb.OleDbParameter("Original_UseCaseID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "UseCaseID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_ProjectID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ProjectID", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_ProjectID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ProjectID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Description", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Description", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Description", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Description", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_UseCaseAbb", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "UseCaseAbb", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_UseCaseAbb", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "UseCaseAbb", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDeleteCommand7
            // 
            this.oleDbDeleteCommand7.CommandText = resources.GetString("oleDbDeleteCommand7.CommandText");
            this.oleDbDeleteCommand7.Connection = this.ctnABCTestProject;
            this.oleDbDeleteCommand7.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Original_UseCaseID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "UseCaseID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_ProjectID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ProjectID", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_ProjectID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ProjectID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Description", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Description", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Description", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Description", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_UseCaseAbb", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "UseCaseAbb", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_UseCaseAbb", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "UseCaseAbb", System.Data.DataRowVersion.Original, null)});
            // 
            // daUseCase
            // 
            this.daUseCase.DeleteCommand = this.oleDbDeleteCommand7;
            this.daUseCase.InsertCommand = this.oleDbInsertCommand7;
            this.daUseCase.SelectCommand = this.oleDbSelectCommand7;
            this.daUseCase.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "UseCase", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("UseCaseID", "UseCaseID"),
                        new System.Data.Common.DataColumnMapping("ProjectID", "ProjectID"),
                        new System.Data.Common.DataColumnMapping("Description", "Description"),
                        new System.Data.Common.DataColumnMapping("UseCaseAbb", "UseCaseAbb")})});
            this.daUseCase.UpdateCommand = this.oleDbUpdateCommand7;
            this.daUseCase.RowUpdated += new System.Data.OleDb.OleDbRowUpdatedEventHandler(this.daUseCase_RowUpdated);
            // 
            // oleDbSelectCommand8
            // 
            this.oleDbSelectCommand8.CommandText = "SELECT        CategoryID, CategoryName, Description\r\nFROM            Category\r\nOR" +
    "DER BY CategoryID";
            this.oleDbSelectCommand8.Connection = this.ctnABCTestProject;
            // 
            // oleDbInsertCommand8
            // 
            this.oleDbInsertCommand8.CommandText = "INSERT INTO `Category` (`CategoryName`, `Description`) VALUES (?, ?)";
            this.oleDbInsertCommand8.Connection = this.ctnABCTestProject;
            this.oleDbInsertCommand8.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("CategoryName", System.Data.OleDb.OleDbType.VarWChar, 0, "CategoryName"),
            new System.Data.OleDb.OleDbParameter("Description", System.Data.OleDb.OleDbType.LongVarWChar, 0, "Description")});
            // 
            // oleDbUpdateCommand8
            // 
            this.oleDbUpdateCommand8.CommandText = "UPDATE `Category` SET `CategoryName` = ?, `Description` = ? WHERE ((`CategoryID` " +
    "= ?) AND ((? = 1 AND `CategoryName` IS NULL) OR (`CategoryName` = ?)))";
            this.oleDbUpdateCommand8.Connection = this.ctnABCTestProject;
            this.oleDbUpdateCommand8.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("CategoryName", System.Data.OleDb.OleDbType.VarWChar, 0, "CategoryName"),
            new System.Data.OleDb.OleDbParameter("Description", System.Data.OleDb.OleDbType.LongVarWChar, 0, "Description"),
            new System.Data.OleDb.OleDbParameter("Original_CategoryID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CategoryID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_CategoryName", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "CategoryName", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_CategoryName", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CategoryName", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDeleteCommand8
            // 
            this.oleDbDeleteCommand8.CommandText = "DELETE FROM `Category` WHERE ((`CategoryID` = ?) AND ((? = 1 AND `CategoryName` I" +
    "S NULL) OR (`CategoryName` = ?)))";
            this.oleDbDeleteCommand8.Connection = this.ctnABCTestProject;
            this.oleDbDeleteCommand8.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Original_CategoryID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CategoryID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_CategoryName", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "CategoryName", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_CategoryName", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CategoryName", System.Data.DataRowVersion.Original, null)});
            // 
            // daCategory
            // 
            this.daCategory.DeleteCommand = this.oleDbDeleteCommand8;
            this.daCategory.InsertCommand = this.oleDbInsertCommand8;
            this.daCategory.SelectCommand = this.oleDbSelectCommand8;
            this.daCategory.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Category", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("CategoryID", "CategoryID"),
                        new System.Data.Common.DataColumnMapping("CategoryName", "CategoryName"),
                        new System.Data.Common.DataColumnMapping("Description", "Description")})});
            this.daCategory.UpdateCommand = this.oleDbUpdateCommand8;
            // 
            // oleDbSelectCommand9
            // 
            this.oleDbSelectCommand9.CommandText = "SELECT        PriorityID, Priority, Description\r\nFROM            Priority\r\nORDER " +
    "BY PriorityID";
            this.oleDbSelectCommand9.Connection = this.ctnABCTestProject;
            // 
            // oleDbInsertCommand9
            // 
            this.oleDbInsertCommand9.CommandText = "INSERT INTO `Priority` (`Priority`, `Description`) VALUES (?, ?)";
            this.oleDbInsertCommand9.Connection = this.ctnABCTestProject;
            this.oleDbInsertCommand9.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Priority", System.Data.OleDb.OleDbType.VarWChar, 0, "Priority"),
            new System.Data.OleDb.OleDbParameter("Description", System.Data.OleDb.OleDbType.LongVarWChar, 0, "Description")});
            // 
            // oleDbUpdateCommand9
            // 
            this.oleDbUpdateCommand9.CommandText = "UPDATE `Priority` SET `Priority` = ?, `Description` = ? WHERE ((`PriorityID` = ?)" +
    " AND ((? = 1 AND `Priority` IS NULL) OR (`Priority` = ?)))";
            this.oleDbUpdateCommand9.Connection = this.ctnABCTestProject;
            this.oleDbUpdateCommand9.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Priority", System.Data.OleDb.OleDbType.VarWChar, 0, "Priority"),
            new System.Data.OleDb.OleDbParameter("Description", System.Data.OleDb.OleDbType.LongVarWChar, 0, "Description"),
            new System.Data.OleDb.OleDbParameter("Original_PriorityID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PriorityID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Priority", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Priority", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Priority", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Priority", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDeleteCommand9
            // 
            this.oleDbDeleteCommand9.CommandText = "DELETE FROM `Priority` WHERE ((`PriorityID` = ?) AND ((? = 1 AND `Priority` IS NU" +
    "LL) OR (`Priority` = ?)))";
            this.oleDbDeleteCommand9.Connection = this.ctnABCTestProject;
            this.oleDbDeleteCommand9.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Original_PriorityID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PriorityID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Priority", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Priority", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Priority", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Priority", System.Data.DataRowVersion.Original, null)});
            // 
            // daPriority
            // 
            this.daPriority.DeleteCommand = this.oleDbDeleteCommand9;
            this.daPriority.InsertCommand = this.oleDbInsertCommand9;
            this.daPriority.SelectCommand = this.oleDbSelectCommand9;
            this.daPriority.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Priority", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("PriorityID", "PriorityID"),
                        new System.Data.Common.DataColumnMapping("Priority", "Priority"),
                        new System.Data.Common.DataColumnMapping("Description", "Description")})});
            this.daPriority.UpdateCommand = this.oleDbUpdateCommand9;
            this.daPriority.RowUpdated += new System.Data.OleDb.OleDbRowUpdatedEventHandler(this.daPriority_RowUpdated);
            // 
            // oleDbSelectCommand10
            // 
            this.oleDbSelectCommand10.CommandText = "SELECT        SeverityID, Severity, Description\r\nFROM            Severity\r\nORDER " +
    "BY SeverityID";
            this.oleDbSelectCommand10.Connection = this.ctnABCTestProject;
            // 
            // oleDbInsertCommand10
            // 
            this.oleDbInsertCommand10.CommandText = "INSERT INTO `Severity` (`Severity`, `Description`) VALUES (?, ?)";
            this.oleDbInsertCommand10.Connection = this.ctnABCTestProject;
            this.oleDbInsertCommand10.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Severity", System.Data.OleDb.OleDbType.VarWChar, 0, "Severity"),
            new System.Data.OleDb.OleDbParameter("Description", System.Data.OleDb.OleDbType.LongVarWChar, 0, "Description")});
            // 
            // oleDbUpdateCommand10
            // 
            this.oleDbUpdateCommand10.CommandText = "UPDATE `Severity` SET `Severity` = ?, `Description` = ? WHERE ((`SeverityID` = ?)" +
    " AND ((? = 1 AND `Severity` IS NULL) OR (`Severity` = ?)))";
            this.oleDbUpdateCommand10.Connection = this.ctnABCTestProject;
            this.oleDbUpdateCommand10.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Severity", System.Data.OleDb.OleDbType.VarWChar, 0, "Severity"),
            new System.Data.OleDb.OleDbParameter("Description", System.Data.OleDb.OleDbType.LongVarWChar, 0, "Description"),
            new System.Data.OleDb.OleDbParameter("Original_SeverityID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "SeverityID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Severity", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Severity", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Severity", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Severity", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDeleteCommand10
            // 
            this.oleDbDeleteCommand10.CommandText = "DELETE FROM `Severity` WHERE ((`SeverityID` = ?) AND ((? = 1 AND `Severity` IS NU" +
    "LL) OR (`Severity` = ?)))";
            this.oleDbDeleteCommand10.Connection = this.ctnABCTestProject;
            this.oleDbDeleteCommand10.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Original_SeverityID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "SeverityID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Severity", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Severity", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Severity", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Severity", System.Data.DataRowVersion.Original, null)});
            // 
            // daSeverity
            // 
            this.daSeverity.DeleteCommand = this.oleDbDeleteCommand10;
            this.daSeverity.InsertCommand = this.oleDbInsertCommand10;
            this.daSeverity.SelectCommand = this.oleDbSelectCommand10;
            this.daSeverity.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Severity", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("SeverityID", "SeverityID"),
                        new System.Data.Common.DataColumnMapping("Severity", "Severity"),
                        new System.Data.Common.DataColumnMapping("Description", "Description")})});
            this.daSeverity.UpdateCommand = this.oleDbUpdateCommand10;
            this.daSeverity.RowUpdated += new System.Data.OleDb.OleDbRowUpdatedEventHandler(this.daSeverity_RowUpdated);
            // 
            // oleDbSelectCommand2
            // 
            this.oleDbSelectCommand2.CommandText = "SELECT        ConfigureID, HardwareName, OperatingSystem, Options, Description\r\nF" +
    "ROM            Configure\r\nORDER BY ConfigureID";
            this.oleDbSelectCommand2.Connection = this.ctnABCTestProject;
            // 
            // oleDbInsertCommand2
            // 
            this.oleDbInsertCommand2.CommandText = "INSERT INTO `Configure` (`HardwareName`, `OperatingSystem`, `Options`, `Descripti" +
    "on`) VALUES (?, ?, ?, ?)";
            this.oleDbInsertCommand2.Connection = this.ctnABCTestProject;
            this.oleDbInsertCommand2.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("HardwareName", System.Data.OleDb.OleDbType.VarWChar, 0, "HardwareName"),
            new System.Data.OleDb.OleDbParameter("OperatingSystem", System.Data.OleDb.OleDbType.VarWChar, 0, "OperatingSystem"),
            new System.Data.OleDb.OleDbParameter("Options", System.Data.OleDb.OleDbType.VarWChar, 0, "Options"),
            new System.Data.OleDb.OleDbParameter("Description", System.Data.OleDb.OleDbType.LongVarWChar, 0, "Description")});
            // 
            // oleDbUpdateCommand2
            // 
            this.oleDbUpdateCommand2.CommandText = resources.GetString("oleDbUpdateCommand2.CommandText");
            this.oleDbUpdateCommand2.Connection = this.ctnABCTestProject;
            this.oleDbUpdateCommand2.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("HardwareName", System.Data.OleDb.OleDbType.VarWChar, 0, "HardwareName"),
            new System.Data.OleDb.OleDbParameter("OperatingSystem", System.Data.OleDb.OleDbType.VarWChar, 0, "OperatingSystem"),
            new System.Data.OleDb.OleDbParameter("Options", System.Data.OleDb.OleDbType.VarWChar, 0, "Options"),
            new System.Data.OleDb.OleDbParameter("Description", System.Data.OleDb.OleDbType.LongVarWChar, 0, "Description"),
            new System.Data.OleDb.OleDbParameter("Original_ConfigureID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ConfigureID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_HardwareName", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "HardwareName", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_HardwareName", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "HardwareName", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_OperatingSystem", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "OperatingSystem", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_OperatingSystem", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "OperatingSystem", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Options", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Options", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Options", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Options", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDeleteCommand2
            // 
            this.oleDbDeleteCommand2.CommandText = resources.GetString("oleDbDeleteCommand2.CommandText");
            this.oleDbDeleteCommand2.Connection = this.ctnABCTestProject;
            this.oleDbDeleteCommand2.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Original_ConfigureID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ConfigureID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_HardwareName", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "HardwareName", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_HardwareName", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "HardwareName", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_OperatingSystem", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "OperatingSystem", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_OperatingSystem", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "OperatingSystem", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Options", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Options", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Options", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Options", System.Data.DataRowVersion.Original, null)});
            // 
            // daConfigure
            // 
            this.daConfigure.DeleteCommand = this.oleDbDeleteCommand2;
            this.daConfigure.InsertCommand = this.oleDbInsertCommand2;
            this.daConfigure.SelectCommand = this.oleDbSelectCommand2;
            this.daConfigure.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Configure", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("ConfigureID", "ConfigureID"),
                        new System.Data.Common.DataColumnMapping("HardwareName", "HardwareName"),
                        new System.Data.Common.DataColumnMapping("OperatingSystem", "OperatingSystem"),
                        new System.Data.Common.DataColumnMapping("Options", "Options"),
                        new System.Data.Common.DataColumnMapping("Description", "Description")})});
            this.daConfigure.UpdateCommand = this.oleDbUpdateCommand2;
            this.daConfigure.RowUpdated += new System.Data.OleDb.OleDbRowUpdatedEventHandler(this.daConfigure_RowUpdated);
            // 
            // dsABCTestProject
            // 
            this.dsABCTestProject.DataSetName = "DSABCTestProject";
            this.dsABCTestProject.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DataModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 241);
            this.Name = "DataModule";
            this.Text = "DataModule";
            ((System.ComponentModel.ISupportInitialize)(this.dsABCTestProject)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
        private System.Data.OleDb.OleDbConnection ctnABCTestProject;
        private System.Data.OleDb.OleDbCommand oleDbInsertCommand1;
        private System.Data.OleDb.OleDbCommand oleDbUpdateCommand1;
        private System.Data.OleDb.OleDbCommand oleDbDeleteCommand1;
        private System.Data.OleDb.OleDbDataAdapter daBug;
        private System.Data.OleDb.OleDbCommand oleDbSelectCommand3;
        private System.Data.OleDb.OleDbCommand oleDbInsertCommand3;
        private System.Data.OleDb.OleDbCommand oleDbUpdateCommand3;
        private System.Data.OleDb.OleDbCommand oleDbDeleteCommand3;
        private System.Data.OleDb.OleDbDataAdapter daEmployee;
        private System.Data.OleDb.OleDbCommand oleDbSelectCommand4;
        private System.Data.OleDb.OleDbCommand oleDbInsertCommand4;
        private System.Data.OleDb.OleDbCommand oleDbUpdateCommand4;
        private System.Data.OleDb.OleDbCommand oleDbDeleteCommand4;
        private System.Data.OleDb.OleDbDataAdapter daProject;
        private System.Data.OleDb.OleDbCommand oleDbSelectCommand5;
        private System.Data.OleDb.OleDbCommand oleDbInsertCommand5;
        private System.Data.OleDb.OleDbCommand oleDbUpdateCommand5;
        private System.Data.OleDb.OleDbCommand oleDbDeleteCommand5;
        private System.Data.OleDb.OleDbDataAdapter daTest;
        private System.Data.OleDb.OleDbCommand oleDbSelectCommand6;
        private System.Data.OleDb.OleDbCommand oleDbInsertCommand6;
        private System.Data.OleDb.OleDbCommand oleDbUpdateCommand6;
        private System.Data.OleDb.OleDbCommand oleDbDeleteCommand6;
        private System.Data.OleDb.OleDbDataAdapter daTestCase;
        private System.Data.OleDb.OleDbCommand oleDbSelectCommand7;
        private System.Data.OleDb.OleDbCommand oleDbInsertCommand7;
        private System.Data.OleDb.OleDbCommand oleDbUpdateCommand7;
        private System.Data.OleDb.OleDbCommand oleDbDeleteCommand7;
        private System.Data.OleDb.OleDbDataAdapter daUseCase;
        public DSABCTestProject dsABCTestProject;
        private System.Data.OleDb.OleDbCommand oleDbSelectCommand8;
        private System.Data.OleDb.OleDbCommand oleDbInsertCommand8;
        private System.Data.OleDb.OleDbCommand oleDbUpdateCommand8;
        private System.Data.OleDb.OleDbCommand oleDbDeleteCommand8;
        private System.Data.OleDb.OleDbDataAdapter daCategory;
        private System.Data.OleDb.OleDbCommand oleDbSelectCommand9;
        private System.Data.OleDb.OleDbCommand oleDbInsertCommand9;
        private System.Data.OleDb.OleDbCommand oleDbUpdateCommand9;
        private System.Data.OleDb.OleDbCommand oleDbDeleteCommand9;
        private System.Data.OleDb.OleDbDataAdapter daPriority;
        private System.Data.OleDb.OleDbCommand oleDbSelectCommand10;
        private System.Data.OleDb.OleDbCommand oleDbInsertCommand10;
        private System.Data.OleDb.OleDbCommand oleDbUpdateCommand10;
        private System.Data.OleDb.OleDbCommand oleDbDeleteCommand10;
        private System.Data.OleDb.OleDbDataAdapter daSeverity;
        private System.Data.OleDb.OleDbCommand oleDbSelectCommand2;
        private System.Data.OleDb.OleDbCommand oleDbInsertCommand2;
        private System.Data.OleDb.OleDbCommand oleDbUpdateCommand2;
        private System.Data.OleDb.OleDbCommand oleDbDeleteCommand2;
        private System.Data.OleDb.OleDbDataAdapter daConfigure;
    }
}