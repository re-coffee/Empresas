namespace ApCom
{
    partial class ApCom
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblResultServer = new Label();
            btClearServer = new Button();
            btClearResultServer = new Button();
            gbServerInstance = new GroupBox();
            tbServerInstance = new TextBox();
            btAddServer = new Button();
            btMoveAllDatabase = new Button();
            btMoveSelectedDatabase = new Button();
            btProcessList = new Button();
            dgResultServer = new DataGridView();
            dgServersAndDatabases = new DataGridView();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            importXmlToolStripMenuItem = new ToolStripMenuItem();
            saveXmlToolStripMenuItem = new ToolStripMenuItem();
            settingsToolStripMenuItem = new ToolStripMenuItem();
            patternToolStripMenuItem = new ToolStripMenuItem();
            tcApCom = new TabControl();
            tpServerInstance = new TabPage();
            lblQueryForDatabases = new Label();
            btSetQueryForDatabases = new Button();
            tbQueryForDatabases = new TextBox();
            pbLoadServer = new ProgressBar();
            tpQuery = new TabPage();
            btClearResultQuery = new Button();
            lblResultQuery = new Label();
            dgResultQuery = new DataGridView();
            gbQuery = new GroupBox();
            btAddQuery = new Button();
            tbQueries = new TextBox();
            tpOverview = new TabPage();
            lblQuery = new Label();
            lblDatabaseOverview = new Label();
            dgDatabaseOverview = new DataGridView();
            dgQueryOverview = new DataGridView();
            tpExecute = new TabPage();
            lblRuntime = new Label();
            colon7 = new Label();
            colon6 = new Label();
            lblQueryProgressValue = new Label();
            lblDatabaseProgressValue = new Label();
            lblQueryProgress = new Label();
            lblDatabaseProgress = new Label();
            progressBar2 = new ProgressBar();
            gbStatistics = new GroupBox();
            lblErrorValue = new Label();
            lblSuccessValue = new Label();
            lblRunValue = new Label();
            lblQueryValue = new Label();
            lblDatabaseValue = new Label();
            colon5 = new Label();
            colon4 = new Label();
            colon3 = new Label();
            colon2 = new Label();
            btCancel = new Button();
            colon1 = new Label();
            lblSuccess = new Label();
            btExecute = new Button();
            lblError = new Label();
            lblDatabase = new Label();
            lblRun = new Label();
            lblQueryStatistic = new Label();
            lblOutput = new Label();
            progressBar1 = new ProgressBar();
            tbOutput = new TextBox();
            tmrCronometer = new System.Windows.Forms.Timer(components);
            gbServerInstance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgResultServer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgServersAndDatabases).BeginInit();
            menuStrip1.SuspendLayout();
            tcApCom.SuspendLayout();
            tpServerInstance.SuspendLayout();
            tpQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgResultQuery).BeginInit();
            gbQuery.SuspendLayout();
            tpOverview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgDatabaseOverview).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgQueryOverview).BeginInit();
            tpExecute.SuspendLayout();
            gbStatistics.SuspendLayout();
            SuspendLayout();
            // 
            // lblResultServer
            // 
            lblResultServer.AutoSize = true;
            lblResultServer.Location = new Point(405, 3);
            lblResultServer.Name = "lblResultServer";
            lblResultServer.Size = new Size(112, 14);
            lblResultServer.TabIndex = 18;
            lblResultServer.Text = "Database result";
            // 
            // btClearServer
            // 
            btClearServer.Location = new Point(6, 340);
            btClearServer.Name = "btClearServer";
            btClearServer.Size = new Size(67, 22);
            btClearServer.TabIndex = 14;
            btClearServer.Text = "Clear";
            btClearServer.UseVisualStyleBackColor = true;
            btClearServer.Click += btClearServer_Click;
            // 
            // btClearResultServer
            // 
            btClearResultServer.Enabled = false;
            btClearResultServer.Location = new Point(405, 340);
            btClearResultServer.Name = "btClearResultServer";
            btClearResultServer.Size = new Size(67, 22);
            btClearResultServer.TabIndex = 16;
            btClearResultServer.Text = "Clear";
            btClearResultServer.UseVisualStyleBackColor = true;
            btClearResultServer.Click += btClearResultServer_Click;
            // 
            // gbServerInstance
            // 
            gbServerInstance.Controls.Add(tbServerInstance);
            gbServerInstance.Controls.Add(btAddServer);
            gbServerInstance.Location = new Point(6, 48);
            gbServerInstance.Name = "gbServerInstance";
            gbServerInstance.Size = new Size(347, 50);
            gbServerInstance.TabIndex = 15;
            gbServerInstance.TabStop = false;
            gbServerInstance.Text = "Server Instance";
            // 
            // tbServerInstance
            // 
            tbServerInstance.Location = new Point(6, 23);
            tbServerInstance.Name = "tbServerInstance";
            tbServerInstance.Size = new Size(276, 22);
            tbServerInstance.TabIndex = 11;
            // 
            // btAddServer
            // 
            btAddServer.Location = new Point(288, 23);
            btAddServer.Name = "btAddServer";
            btAddServer.Size = new Size(53, 21);
            btAddServer.TabIndex = 6;
            btAddServer.Text = "Add";
            btAddServer.UseVisualStyleBackColor = true;
            btAddServer.Click += btAddServer_Click;
            // 
            // btMoveAllDatabase
            // 
            btMoveAllDatabase.Enabled = false;
            btMoveAllDatabase.Location = new Point(359, 206);
            btMoveAllDatabase.Name = "btMoveAllDatabase";
            btMoveAllDatabase.Size = new Size(40, 32);
            btMoveAllDatabase.TabIndex = 5;
            btMoveAllDatabase.Text = ">>";
            btMoveAllDatabase.UseVisualStyleBackColor = true;
            btMoveAllDatabase.Click += btMoveAllDatabase_Click;
            // 
            // btMoveSelectedDatabase
            // 
            btMoveSelectedDatabase.Enabled = false;
            btMoveSelectedDatabase.Location = new Point(359, 169);
            btMoveSelectedDatabase.Name = "btMoveSelectedDatabase";
            btMoveSelectedDatabase.Size = new Size(40, 32);
            btMoveSelectedDatabase.TabIndex = 4;
            btMoveSelectedDatabase.Text = ">";
            btMoveSelectedDatabase.UseVisualStyleBackColor = true;
            btMoveSelectedDatabase.Click += btMoveSelectedDatabase_Click;
            // 
            // btProcessList
            // 
            btProcessList.Enabled = false;
            btProcessList.Location = new Point(6, 111);
            btProcessList.Name = "btProcessList";
            btProcessList.Size = new Size(109, 21);
            btProcessList.TabIndex = 2;
            btProcessList.Text = "Process list";
            btProcessList.UseVisualStyleBackColor = true;
            btProcessList.Click += btProcessList_Click;
            // 
            // dgResultServer
            // 
            dgResultServer.AllowUserToAddRows = false;
            dgResultServer.AllowUserToDeleteRows = false;
            dgResultServer.AllowUserToOrderColumns = true;
            dgResultServer.AllowUserToResizeColumns = false;
            dgResultServer.AllowUserToResizeRows = false;
            dgResultServer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgResultServer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgResultServer.Location = new Point(405, 20);
            dgResultServer.Name = "dgResultServer";
            dgResultServer.ReadOnly = true;
            dgResultServer.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgResultServer.Size = new Size(347, 315);
            dgResultServer.TabIndex = 1;
            // 
            // dgServersAndDatabases
            // 
            dgServersAndDatabases.AllowUserToAddRows = false;
            dgServersAndDatabases.AllowUserToOrderColumns = true;
            dgServersAndDatabases.AllowUserToResizeColumns = false;
            dgServersAndDatabases.AllowUserToResizeRows = false;
            dgServersAndDatabases.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgServersAndDatabases.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgServersAndDatabases.Location = new Point(6, 138);
            dgServersAndDatabases.Name = "dgServersAndDatabases";
            dgServersAndDatabases.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgServersAndDatabases.Size = new Size(347, 196);
            dgServersAndDatabases.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, settingsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(784, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "msSettings";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { importXmlToolStripMenuItem, saveXmlToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(47, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // importXmlToolStripMenuItem
            // 
            importXmlToolStripMenuItem.Name = "importXmlToolStripMenuItem";
            importXmlToolStripMenuItem.Size = new Size(102, 22);
            importXmlToolStripMenuItem.Text = "Load";
            // 
            // saveXmlToolStripMenuItem
            // 
            saveXmlToolStripMenuItem.Name = "saveXmlToolStripMenuItem";
            saveXmlToolStripMenuItem.Size = new Size(102, 22);
            saveXmlToolStripMenuItem.Text = "Save";
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { patternToolStripMenuItem });
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new Size(75, 20);
            settingsToolStripMenuItem.Text = "Settings";
            // 
            // patternToolStripMenuItem
            // 
            patternToolStripMenuItem.Name = "patternToolStripMenuItem";
            patternToolStripMenuItem.Size = new Size(123, 22);
            patternToolStripMenuItem.Text = "Pattern";
            // 
            // tcApCom
            // 
            tcApCom.Controls.Add(tpServerInstance);
            tcApCom.Controls.Add(tpQuery);
            tcApCom.Controls.Add(tpOverview);
            tcApCom.Controls.Add(tpExecute);
            tcApCom.Location = new Point(12, 24);
            tcApCom.Name = "tcApCom";
            tcApCom.SelectedIndex = 0;
            tcApCom.Size = new Size(766, 394);
            tcApCom.TabIndex = 4;
            tcApCom.Click += tcApCom_Click;
            // 
            // tpServerInstance
            // 
            tpServerInstance.Controls.Add(lblQueryForDatabases);
            tpServerInstance.Controls.Add(btSetQueryForDatabases);
            tpServerInstance.Controls.Add(tbQueryForDatabases);
            tpServerInstance.Controls.Add(pbLoadServer);
            tpServerInstance.Controls.Add(btClearResultServer);
            tpServerInstance.Controls.Add(lblResultServer);
            tpServerInstance.Controls.Add(btClearServer);
            tpServerInstance.Controls.Add(gbServerInstance);
            tpServerInstance.Controls.Add(btMoveAllDatabase);
            tpServerInstance.Controls.Add(btProcessList);
            tpServerInstance.Controls.Add(btMoveSelectedDatabase);
            tpServerInstance.Controls.Add(dgServersAndDatabases);
            tpServerInstance.Controls.Add(dgResultServer);
            tpServerInstance.Location = new Point(4, 23);
            tpServerInstance.Name = "tpServerInstance";
            tpServerInstance.Padding = new Padding(3);
            tpServerInstance.Size = new Size(758, 367);
            tpServerInstance.TabIndex = 0;
            tpServerInstance.Text = "Server";
            tpServerInstance.UseVisualStyleBackColor = true;
            // 
            // lblQueryForDatabases
            // 
            lblQueryForDatabases.AutoSize = true;
            lblQueryForDatabases.Location = new Point(6, 3);
            lblQueryForDatabases.Name = "lblQueryForDatabases";
            lblQueryForDatabases.Size = new Size(140, 14);
            lblQueryForDatabases.TabIndex = 21;
            lblQueryForDatabases.Text = "Query for databases";
            // 
            // btSetQueryForDatabases
            // 
            btSetQueryForDatabases.Location = new Point(294, 21);
            btSetQueryForDatabases.Name = "btSetQueryForDatabases";
            btSetQueryForDatabases.Size = new Size(53, 21);
            btSetQueryForDatabases.TabIndex = 20;
            btSetQueryForDatabases.Text = "Set";
            btSetQueryForDatabases.UseVisualStyleBackColor = true;
            btSetQueryForDatabases.Click += btSetQueryForDatabases_Click;
            // 
            // tbQueryForDatabases
            // 
            tbQueryForDatabases.Location = new Point(12, 20);
            tbQueryForDatabases.Name = "tbQueryForDatabases";
            tbQueryForDatabases.Size = new Size(276, 22);
            tbQueryForDatabases.TabIndex = 12;
            // 
            // pbLoadServer
            // 
            pbLoadServer.Location = new Point(121, 117);
            pbLoadServer.Name = "pbLoadServer";
            pbLoadServer.Size = new Size(232, 9);
            pbLoadServer.Style = ProgressBarStyle.Continuous;
            pbLoadServer.TabIndex = 19;
            // 
            // tpQuery
            // 
            tpQuery.Controls.Add(btClearResultQuery);
            tpQuery.Controls.Add(lblResultQuery);
            tpQuery.Controls.Add(dgResultQuery);
            tpQuery.Controls.Add(gbQuery);
            tpQuery.Location = new Point(4, 24);
            tpQuery.Name = "tpQuery";
            tpQuery.Padding = new Padding(3);
            tpQuery.Size = new Size(758, 366);
            tpQuery.TabIndex = 1;
            tpQuery.Text = "Query";
            tpQuery.UseVisualStyleBackColor = true;
            // 
            // btClearResultQuery
            // 
            btClearResultQuery.Location = new Point(405, 340);
            btClearResultQuery.Name = "btClearResultQuery";
            btClearResultQuery.Size = new Size(67, 22);
            btClearResultQuery.TabIndex = 21;
            btClearResultQuery.Text = "Clear";
            btClearResultQuery.UseVisualStyleBackColor = true;
            btClearResultQuery.Click += btClearResultQuery_Click;
            // 
            // lblResultQuery
            // 
            lblResultQuery.AutoSize = true;
            lblResultQuery.Location = new Point(405, 3);
            lblResultQuery.Name = "lblResultQuery";
            lblResultQuery.Size = new Size(91, 14);
            lblResultQuery.TabIndex = 20;
            lblResultQuery.Text = "Query result";
            // 
            // dgResultQuery
            // 
            dgResultQuery.AllowUserToAddRows = false;
            dgResultQuery.AllowUserToDeleteRows = false;
            dgResultQuery.AllowUserToOrderColumns = true;
            dgResultQuery.AllowUserToResizeColumns = false;
            dgResultQuery.AllowUserToResizeRows = false;
            dgResultQuery.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgResultQuery.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgResultQuery.Location = new Point(405, 20);
            dgResultQuery.Name = "dgResultQuery";
            dgResultQuery.ReadOnly = true;
            dgResultQuery.Size = new Size(347, 315);
            dgResultQuery.TabIndex = 19;
            // 
            // gbQuery
            // 
            gbQuery.Controls.Add(btAddQuery);
            gbQuery.Controls.Add(tbQueries);
            gbQuery.Location = new Point(6, 6);
            gbQuery.Name = "gbQuery";
            gbQuery.Size = new Size(393, 357);
            gbQuery.TabIndex = 16;
            gbQuery.TabStop = false;
            gbQuery.Text = "Queries";
            // 
            // btAddQuery
            // 
            btAddQuery.Location = new Point(353, 175);
            btAddQuery.Name = "btAddQuery";
            btAddQuery.Size = new Size(34, 28);
            btAddQuery.TabIndex = 12;
            btAddQuery.Text = "+";
            btAddQuery.UseVisualStyleBackColor = true;
            btAddQuery.Click += btAddQuery_Click;
            // 
            // tbQueries
            // 
            tbQueries.Location = new Point(6, 23);
            tbQueries.Multiline = true;
            tbQueries.Name = "tbQueries";
            tbQueries.Size = new Size(341, 306);
            tbQueries.TabIndex = 11;
            // 
            // tpOverview
            // 
            tpOverview.Controls.Add(lblQuery);
            tpOverview.Controls.Add(lblDatabaseOverview);
            tpOverview.Controls.Add(dgDatabaseOverview);
            tpOverview.Controls.Add(dgQueryOverview);
            tpOverview.Location = new Point(4, 24);
            tpOverview.Name = "tpOverview";
            tpOverview.Padding = new Padding(3);
            tpOverview.Size = new Size(758, 366);
            tpOverview.TabIndex = 2;
            tpOverview.Text = "Overview";
            tpOverview.UseVisualStyleBackColor = true;
            // 
            // lblQuery
            // 
            lblQuery.AutoSize = true;
            lblQuery.Location = new Point(405, 3);
            lblQuery.Name = "lblQuery";
            lblQuery.Size = new Size(91, 14);
            lblQuery.TabIndex = 23;
            lblQuery.Text = "Query result";
            // 
            // lblDatabaseOverview
            // 
            lblDatabaseOverview.AutoSize = true;
            lblDatabaseOverview.Location = new Point(6, 3);
            lblDatabaseOverview.Name = "lblDatabaseOverview";
            lblDatabaseOverview.Size = new Size(112, 14);
            lblDatabaseOverview.TabIndex = 22;
            lblDatabaseOverview.Text = "Database result";
            // 
            // dgDatabaseOverview
            // 
            dgDatabaseOverview.AllowUserToAddRows = false;
            dgDatabaseOverview.AllowUserToDeleteRows = false;
            dgDatabaseOverview.AllowUserToOrderColumns = true;
            dgDatabaseOverview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgDatabaseOverview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgDatabaseOverview.Location = new Point(6, 20);
            dgDatabaseOverview.Name = "dgDatabaseOverview";
            dgDatabaseOverview.ReadOnly = true;
            dgDatabaseOverview.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgDatabaseOverview.RowTemplate.ReadOnly = true;
            dgDatabaseOverview.Size = new Size(347, 315);
            dgDatabaseOverview.TabIndex = 21;
            // 
            // dgQueryOverview
            // 
            dgQueryOverview.AllowUserToAddRows = false;
            dgQueryOverview.AllowUserToDeleteRows = false;
            dgQueryOverview.AllowUserToOrderColumns = true;
            dgQueryOverview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgQueryOverview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgQueryOverview.Location = new Point(405, 20);
            dgQueryOverview.Name = "dgQueryOverview";
            dgQueryOverview.ReadOnly = true;
            dgQueryOverview.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgQueryOverview.RowTemplate.ReadOnly = true;
            dgQueryOverview.Size = new Size(347, 315);
            dgQueryOverview.TabIndex = 20;
            // 
            // tpExecute
            // 
            tpExecute.Controls.Add(lblRuntime);
            tpExecute.Controls.Add(colon7);
            tpExecute.Controls.Add(colon6);
            tpExecute.Controls.Add(lblQueryProgressValue);
            tpExecute.Controls.Add(lblDatabaseProgressValue);
            tpExecute.Controls.Add(lblQueryProgress);
            tpExecute.Controls.Add(lblDatabaseProgress);
            tpExecute.Controls.Add(progressBar2);
            tpExecute.Controls.Add(gbStatistics);
            tpExecute.Controls.Add(lblOutput);
            tpExecute.Controls.Add(progressBar1);
            tpExecute.Controls.Add(tbOutput);
            tpExecute.Location = new Point(4, 24);
            tpExecute.Name = "tpExecute";
            tpExecute.Padding = new Padding(3);
            tpExecute.Size = new Size(758, 366);
            tpExecute.TabIndex = 3;
            tpExecute.Text = "Execute";
            tpExecute.UseVisualStyleBackColor = true;
            // 
            // lblRuntime
            // 
            lblRuntime.AutoSize = true;
            lblRuntime.Location = new Point(512, 299);
            lblRuntime.Name = "lblRuntime";
            lblRuntime.Size = new Size(0, 14);
            lblRuntime.TabIndex = 35;
            // 
            // colon7
            // 
            colon7.AutoSize = true;
            colon7.Location = new Point(75, 329);
            colon7.Name = "colon7";
            colon7.Size = new Size(14, 14);
            colon7.TabIndex = 34;
            colon7.Text = ":";
            // 
            // colon6
            // 
            colon6.AutoSize = true;
            colon6.Location = new Point(75, 299);
            colon6.Name = "colon6";
            colon6.Size = new Size(14, 14);
            colon6.TabIndex = 33;
            colon6.Text = ":";
            // 
            // lblQueryProgressValue
            // 
            lblQueryProgressValue.AutoSize = true;
            lblQueryProgressValue.Location = new Point(95, 329);
            lblQueryProgressValue.Name = "lblQueryProgressValue";
            lblQueryProgressValue.Size = new Size(0, 14);
            lblQueryProgressValue.TabIndex = 32;
            // 
            // lblDatabaseProgressValue
            // 
            lblDatabaseProgressValue.AutoSize = true;
            lblDatabaseProgressValue.Location = new Point(95, 299);
            lblDatabaseProgressValue.Name = "lblDatabaseProgressValue";
            lblDatabaseProgressValue.Size = new Size(0, 14);
            lblDatabaseProgressValue.TabIndex = 31;
            // 
            // lblQueryProgress
            // 
            lblQueryProgress.AutoSize = true;
            lblQueryProgress.Location = new Point(6, 329);
            lblQueryProgress.Name = "lblQueryProgress";
            lblQueryProgress.Size = new Size(42, 14);
            lblQueryProgress.TabIndex = 30;
            lblQueryProgress.Text = "Query";
            // 
            // lblDatabaseProgress
            // 
            lblDatabaseProgress.AutoSize = true;
            lblDatabaseProgress.Location = new Point(6, 299);
            lblDatabaseProgress.Name = "lblDatabaseProgress";
            lblDatabaseProgress.Size = new Size(63, 14);
            lblDatabaseProgress.TabIndex = 28;
            lblDatabaseProgress.Text = "Database";
            // 
            // progressBar2
            // 
            progressBar2.Location = new Point(6, 346);
            progressBar2.Name = "progressBar2";
            progressBar2.Size = new Size(569, 9);
            progressBar2.TabIndex = 29;
            // 
            // gbStatistics
            // 
            gbStatistics.Controls.Add(lblErrorValue);
            gbStatistics.Controls.Add(lblSuccessValue);
            gbStatistics.Controls.Add(lblRunValue);
            gbStatistics.Controls.Add(lblQueryValue);
            gbStatistics.Controls.Add(lblDatabaseValue);
            gbStatistics.Controls.Add(colon5);
            gbStatistics.Controls.Add(colon4);
            gbStatistics.Controls.Add(colon3);
            gbStatistics.Controls.Add(colon2);
            gbStatistics.Controls.Add(btCancel);
            gbStatistics.Controls.Add(colon1);
            gbStatistics.Controls.Add(lblSuccess);
            gbStatistics.Controls.Add(btExecute);
            gbStatistics.Controls.Add(lblError);
            gbStatistics.Controls.Add(lblDatabase);
            gbStatistics.Controls.Add(lblRun);
            gbStatistics.Controls.Add(lblQueryStatistic);
            gbStatistics.Location = new Point(581, 6);
            gbStatistics.Name = "gbStatistics";
            gbStatistics.Size = new Size(171, 355);
            gbStatistics.TabIndex = 28;
            gbStatistics.TabStop = false;
            gbStatistics.Text = "Statistics";
            // 
            // lblErrorValue
            // 
            lblErrorValue.AutoSize = true;
            lblErrorValue.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblErrorValue.Location = new Point(106, 94);
            lblErrorValue.Name = "lblErrorValue";
            lblErrorValue.Size = new Size(0, 15);
            lblErrorValue.TabIndex = 37;
            lblErrorValue.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSuccessValue
            // 
            lblSuccessValue.AutoSize = true;
            lblSuccessValue.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblSuccessValue.Location = new Point(106, 76);
            lblSuccessValue.Name = "lblSuccessValue";
            lblSuccessValue.Size = new Size(0, 15);
            lblSuccessValue.TabIndex = 36;
            lblSuccessValue.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRunValue
            // 
            lblRunValue.AutoSize = true;
            lblRunValue.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblRunValue.Location = new Point(106, 58);
            lblRunValue.Name = "lblRunValue";
            lblRunValue.Size = new Size(0, 15);
            lblRunValue.TabIndex = 35;
            lblRunValue.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblQueryValue
            // 
            lblQueryValue.AutoSize = true;
            lblQueryValue.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblQueryValue.Location = new Point(106, 38);
            lblQueryValue.Name = "lblQueryValue";
            lblQueryValue.Size = new Size(0, 15);
            lblQueryValue.TabIndex = 34;
            lblQueryValue.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDatabaseValue
            // 
            lblDatabaseValue.AutoSize = true;
            lblDatabaseValue.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblDatabaseValue.Location = new Point(106, 18);
            lblDatabaseValue.Name = "lblDatabaseValue";
            lblDatabaseValue.Size = new Size(0, 15);
            lblDatabaseValue.TabIndex = 33;
            lblDatabaseValue.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // colon5
            // 
            colon5.AutoSize = true;
            colon5.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            colon5.Location = new Point(84, 94);
            colon5.Name = "colon5";
            colon5.Size = new Size(10, 15);
            colon5.TabIndex = 32;
            colon5.Text = ":";
            // 
            // colon4
            // 
            colon4.AutoSize = true;
            colon4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            colon4.Location = new Point(84, 76);
            colon4.Name = "colon4";
            colon4.Size = new Size(10, 15);
            colon4.TabIndex = 31;
            colon4.Text = ":";
            // 
            // colon3
            // 
            colon3.AutoSize = true;
            colon3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            colon3.Location = new Point(84, 58);
            colon3.Name = "colon3";
            colon3.Size = new Size(10, 15);
            colon3.TabIndex = 30;
            colon3.Text = ":";
            // 
            // colon2
            // 
            colon2.AutoSize = true;
            colon2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            colon2.Location = new Point(84, 38);
            colon2.Name = "colon2";
            colon2.Size = new Size(10, 15);
            colon2.TabIndex = 29;
            colon2.Text = ":";
            // 
            // btCancel
            // 
            btCancel.Location = new Point(6, 325);
            btCancel.Name = "btCancel";
            btCancel.Size = new Size(159, 24);
            btCancel.TabIndex = 28;
            btCancel.Text = "Cancel";
            btCancel.UseVisualStyleBackColor = true;
            // 
            // colon1
            // 
            colon1.AutoSize = true;
            colon1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            colon1.Location = new Point(84, 18);
            colon1.Name = "colon1";
            colon1.Size = new Size(10, 15);
            colon1.TabIndex = 27;
            colon1.Text = ":";
            // 
            // lblSuccess
            // 
            lblSuccess.AutoSize = true;
            lblSuccess.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblSuccess.Location = new Point(6, 76);
            lblSuccess.Name = "lblSuccess";
            lblSuccess.Size = new Size(53, 15);
            lblSuccess.TabIndex = 26;
            lblSuccess.Text = "Success";
            // 
            // btExecute
            // 
            btExecute.Location = new Point(6, 295);
            btExecute.Name = "btExecute";
            btExecute.Size = new Size(159, 24);
            btExecute.TabIndex = 10;
            btExecute.Text = "Execute";
            btExecute.UseVisualStyleBackColor = true;
            btExecute.Click += btExecute_Click;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblError.Location = new Point(6, 96);
            lblError.Name = "lblError";
            lblError.Size = new Size(34, 15);
            lblError.TabIndex = 23;
            lblError.Text = "Error";
            // 
            // lblDatabase
            // 
            lblDatabase.AutoSize = true;
            lblDatabase.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblDatabase.Location = new Point(6, 18);
            lblDatabase.Name = "lblDatabase";
            lblDatabase.Size = new Size(60, 15);
            lblDatabase.TabIndex = 18;
            lblDatabase.Text = "Database";
            // 
            // lblRun
            // 
            lblRun.AutoSize = true;
            lblRun.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblRun.Location = new Point(6, 58);
            lblRun.Name = "lblRun";
            lblRun.Size = new Size(30, 15);
            lblRun.TabIndex = 22;
            lblRun.Text = "Run";
            // 
            // lblQueryStatistic
            // 
            lblQueryStatistic.AutoSize = true;
            lblQueryStatistic.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblQueryStatistic.Location = new Point(6, 38);
            lblQueryStatistic.Name = "lblQueryStatistic";
            lblQueryStatistic.Size = new Size(39, 15);
            lblQueryStatistic.TabIndex = 19;
            lblQueryStatistic.Text = "Query";
            // 
            // lblOutput
            // 
            lblOutput.AutoSize = true;
            lblOutput.Location = new Point(6, 3);
            lblOutput.Name = "lblOutput";
            lblOutput.Size = new Size(49, 14);
            lblOutput.TabIndex = 13;
            lblOutput.Text = "Output";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(6, 316);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(569, 9);
            progressBar1.TabIndex = 15;
            // 
            // tbOutput
            // 
            tbOutput.Location = new Point(6, 20);
            tbOutput.Multiline = true;
            tbOutput.Name = "tbOutput";
            tbOutput.ReadOnly = true;
            tbOutput.ScrollBars = ScrollBars.Vertical;
            tbOutput.Size = new Size(569, 276);
            tbOutput.TabIndex = 11;
            // 
            // tmrCronometer
            // 
            tmrCronometer.Interval = 500;
            tmrCronometer.Tick += tmrCronometer_Tick;
            // 
            // ApCom
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 430);
            Controls.Add(tcApCom);
            Controls.Add(menuStrip1);
            Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            Name = "ApCom";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ApCom";
            Load += ApCom_Load;
            gbServerInstance.ResumeLayout(false);
            gbServerInstance.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgResultServer).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgServersAndDatabases).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tcApCom.ResumeLayout(false);
            tpServerInstance.ResumeLayout(false);
            tpServerInstance.PerformLayout();
            tpQuery.ResumeLayout(false);
            tpQuery.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgResultQuery).EndInit();
            gbQuery.ResumeLayout(false);
            gbQuery.PerformLayout();
            tpOverview.ResumeLayout(false);
            tpOverview.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgDatabaseOverview).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgQueryOverview).EndInit();
            tpExecute.ResumeLayout(false);
            tpExecute.PerformLayout();
            gbStatistics.ResumeLayout(false);
            gbStatistics.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgServersAndDatabases;
        private TextBox tbServerInstance;
        private Button btAddServer;
        private Button btMoveAllDatabase;
        private Button btMoveSelectedDatabase;
        private Button btProcessList;
        private DataGridView dgResultServer;
        private Button btClearServer;
        private Button btClearResultServer;
        private GroupBox gbServerInstance;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private Label lblResultServer;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem patternToolStripMenuItem;
        private ToolStripMenuItem importXmlToolStripMenuItem;
        private ToolStripMenuItem saveXmlToolStripMenuItem;
        private TabControl tcApCom;
        private TabPage tpServerInstance;
        private TabPage tpQuery;
        private Button btClearResultQuery;
        private Label lblResultQuery;
        private DataGridView dgResultQuery;
        private GroupBox gbQuery;
        private Button btAddQuery;
        private TextBox tbQueries;
        private TabPage tpOverview;
        private TabPage tpExecute;
        private Button btExecute;
        private Label lblQuery;
        private Label lblDatabaseOverview;
        private DataGridView dgDatabaseOverview;
        private DataGridView dgQueryOverview;
        private ProgressBar pbLoadServer;
        private Label lblOutput;
        private Label colon1;
        private Label lblSuccess;
        private Label lblError;
        private Label lblRun;
        private Label lblQueryStatistic;
        private Label lblDatabase;
        private ProgressBar progressBar1;
        private GroupBox gbStatistics;
        private Label lblQueryProgress;
        private Label lblDatabaseProgress;
        private ProgressBar progressBar2;
        private Button btCancel;
        private Label lblErrorValue;
        private Label lblSuccessValue;
        private Label lblRunValue;
        private Label lblQueryValue;
        private Label lblDatabaseValue;
        private Label colon5;
        private Label colon4;
        private Label colon3;
        private Label colon2;
        private Label colon7;
        private Label colon6;
        private Label lblQueryProgressValue;
        private Label lblDatabaseProgressValue;
        private TextBox tbOutput;
        private Label lblRuntime;
        private System.Windows.Forms.Timer tmrCronometer;
        private TextBox tbQueryForDatabases;
        private Label lblQueryForDatabases;
        private Button btSetQueryForDatabases;
    }
}