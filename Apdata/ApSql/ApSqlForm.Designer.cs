namespace ApSql
{
    partial class ApSqlForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApSqlForm));
            menu = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            loadToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            settingsToolStripMenuItem = new ToolStripMenuItem();
            serverToolStripMenuItem = new ToolStripMenuItem();
            queryToolStripMenuItem = new ToolStripMenuItem();
            runToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            viewHelpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            mainTabControl = new TabControl();
            serverTabPage = new TabPage();
            moveAllServerButton = new Button();
            newClusterButton = new Button();
            moveSelectedServerButton = new Button();
            instanceListGroupBox = new GroupBox();
            clearInstanceListDGVButton = new Button();
            instanceDataGridView = new DataGridView();
            databaseGroupBox = new GroupBox();
            filterTextBox = new TextBox();
            clusterLabel = new Label();
            clusterComboBox = new ComboBox();
            databaseDataGridView = new DataGridView();
            queryTabPage = new TabPage();
            addQueryButton = new Button();
            commandListGroupBox = new GroupBox();
            clearCommandListDGVButton = new Button();
            commandDataGridView = new DataGridView();
            queryGroupBox = new GroupBox();
            queryTextBox = new TextBox();
            runTabPage = new TabPage();
            logGroupBox = new GroupBox();
            clipRunButton = new Button();
            logTextBox = new TextBox();
            overviewGroupBox = new GroupBox();
            runButton = new Button();
            runGroupBox = new GroupBox();
            commandCountLabel = new Label();
            instanceCountLabel = new Label();
            commandProgressBar = new ProgressBar();
            instanceProgressBar = new ProgressBar();
            timer = new System.Windows.Forms.Timer(components);
            backgroundWorker = new System.ComponentModel.BackgroundWorker();
            menu.SuspendLayout();
            mainTabControl.SuspendLayout();
            serverTabPage.SuspendLayout();
            instanceListGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)instanceDataGridView).BeginInit();
            databaseGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)databaseDataGridView).BeginInit();
            queryTabPage.SuspendLayout();
            commandListGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)commandDataGridView).BeginInit();
            queryGroupBox.SuspendLayout();
            runTabPage.SuspendLayout();
            logGroupBox.SuspendLayout();
            overviewGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // menu
            // 
            menu.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            menu.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, settingsToolStripMenuItem, helpToolStripMenuItem });
            menu.Location = new Point(0, 0);
            menu.Name = "menu";
            menu.Padding = new Padding(7, 2, 0, 2);
            menu.Size = new Size(884, 25);
            menu.TabIndex = 0;
            menu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { loadToolStripMenuItem, saveToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(42, 21);
            fileToolStripMenuItem.Text = "File";
            // 
            // loadToolStripMenuItem
            // 
            loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            loadToolStripMenuItem.Size = new Size(108, 22);
            loadToolStripMenuItem.Text = "Load";
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(108, 22);
            saveToolStripMenuItem.Text = "Save";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(108, 22);
            exitToolStripMenuItem.Text = "Exit";
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { serverToolStripMenuItem, queryToolStripMenuItem, runToolStripMenuItem });
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new Size(71, 21);
            settingsToolStripMenuItem.Text = "Settings";
            // 
            // serverToolStripMenuItem
            // 
            serverToolStripMenuItem.Name = "serverToolStripMenuItem";
            serverToolStripMenuItem.Size = new Size(118, 22);
            serverToolStripMenuItem.Text = "Server";
            // 
            // queryToolStripMenuItem
            // 
            queryToolStripMenuItem.Name = "queryToolStripMenuItem";
            queryToolStripMenuItem.Size = new Size(118, 22);
            queryToolStripMenuItem.Text = "Query";
            // 
            // runToolStripMenuItem
            // 
            runToolStripMenuItem.Name = "runToolStripMenuItem";
            runToolStripMenuItem.Size = new Size(118, 22);
            runToolStripMenuItem.Text = "Run";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { viewHelpToolStripMenuItem, aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(49, 21);
            helpToolStripMenuItem.Text = "Help";
            // 
            // viewHelpToolStripMenuItem
            // 
            viewHelpToolStripMenuItem.Name = "viewHelpToolStripMenuItem";
            viewHelpToolStripMenuItem.Size = new Size(136, 22);
            viewHelpToolStripMenuItem.Text = "View help";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(136, 22);
            aboutToolStripMenuItem.Text = "About";
            // 
            // mainTabControl
            // 
            mainTabControl.Controls.Add(serverTabPage);
            mainTabControl.Controls.Add(queryTabPage);
            mainTabControl.Controls.Add(runTabPage);
            mainTabControl.Dock = DockStyle.Fill;
            mainTabControl.Location = new Point(0, 25);
            mainTabControl.Name = "mainTabControl";
            mainTabControl.SelectedIndex = 0;
            mainTabControl.Size = new Size(884, 436);
            mainTabControl.SizeMode = TabSizeMode.Fixed;
            mainTabControl.TabIndex = 0;
            // 
            // serverTabPage
            // 
            serverTabPage.Controls.Add(moveAllServerButton);
            serverTabPage.Controls.Add(newClusterButton);
            serverTabPage.Controls.Add(moveSelectedServerButton);
            serverTabPage.Controls.Add(instanceListGroupBox);
            serverTabPage.Controls.Add(databaseGroupBox);
            serverTabPage.Location = new Point(4, 25);
            serverTabPage.Name = "serverTabPage";
            serverTabPage.Padding = new Padding(3);
            serverTabPage.Size = new Size(876, 407);
            serverTabPage.TabIndex = 0;
            serverTabPage.Text = "Server";
            serverTabPage.UseVisualStyleBackColor = true;
            // 
            // moveAllServerButton
            // 
            moveAllServerButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            moveAllServerButton.FlatStyle = FlatStyle.Popup;
            moveAllServerButton.Font = new Font("Microsoft Sans Serif", 6.75F, FontStyle.Bold, GraphicsUnit.Point);
            moveAllServerButton.Location = new Point(419, 179);
            moveAllServerButton.Name = "moveAllServerButton";
            moveAllServerButton.Size = new Size(38, 35);
            moveAllServerButton.TabIndex = 4;
            moveAllServerButton.Text = ">>";
            moveAllServerButton.UseVisualStyleBackColor = true;
            moveAllServerButton.Click += moveAllServerButton_Click;
            // 
            // newClusterButton
            // 
            newClusterButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            newClusterButton.Enabled = false;
            newClusterButton.FlatStyle = FlatStyle.Popup;
            newClusterButton.Font = new Font("Microsoft Sans Serif", 6.75F, FontStyle.Bold, GraphicsUnit.Point);
            newClusterButton.Location = new Point(419, 378);
            newClusterButton.Name = "newClusterButton";
            newClusterButton.Size = new Size(38, 20);
            newClusterButton.TabIndex = 150;
            newClusterButton.Text = "+";
            newClusterButton.UseVisualStyleBackColor = true;
            newClusterButton.Visible = false;
            newClusterButton.Click += newClusterButton_Click;
            // 
            // moveSelectedServerButton
            // 
            moveSelectedServerButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            moveSelectedServerButton.FlatStyle = FlatStyle.Popup;
            moveSelectedServerButton.Font = new Font("Microsoft Sans Serif", 6.75F, FontStyle.Bold, GraphicsUnit.Point);
            moveSelectedServerButton.Location = new Point(419, 138);
            moveSelectedServerButton.Name = "moveSelectedServerButton";
            moveSelectedServerButton.Size = new Size(38, 35);
            moveSelectedServerButton.TabIndex = 3;
            moveSelectedServerButton.Text = ">";
            moveSelectedServerButton.UseVisualStyleBackColor = true;
            moveSelectedServerButton.Click += moveSelectedServerButton_Click;
            // 
            // instanceListGroupBox
            // 
            instanceListGroupBox.Controls.Add(clearInstanceListDGVButton);
            instanceListGroupBox.Controls.Add(instanceDataGridView);
            instanceListGroupBox.Dock = DockStyle.Right;
            instanceListGroupBox.Location = new Point(463, 3);
            instanceListGroupBox.Name = "instanceListGroupBox";
            instanceListGroupBox.Size = new Size(410, 401);
            instanceListGroupBox.TabIndex = 1;
            instanceListGroupBox.TabStop = false;
            instanceListGroupBox.Text = "Instance list";
            // 
            // clearInstanceListDGVButton
            // 
            clearInstanceListDGVButton.FlatStyle = FlatStyle.Popup;
            clearInstanceListDGVButton.Font = new Font("Microsoft Sans Serif", 6.75F, FontStyle.Bold, GraphicsUnit.Point);
            clearInstanceListDGVButton.Location = new Point(378, 372);
            clearInstanceListDGVButton.Name = "clearInstanceListDGVButton";
            clearInstanceListDGVButton.Size = new Size(26, 23);
            clearInstanceListDGVButton.TabIndex = 6;
            clearInstanceListDGVButton.Text = "X";
            clearInstanceListDGVButton.UseVisualStyleBackColor = true;
            clearInstanceListDGVButton.Click += clearInstanceListDGVButton_Click;
            // 
            // instanceDataGridView
            // 
            instanceDataGridView.AllowUserToAddRows = false;
            instanceDataGridView.AllowUserToDeleteRows = false;
            instanceDataGridView.AllowUserToResizeColumns = false;
            instanceDataGridView.AllowUserToResizeRows = false;
            instanceDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            instanceDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            instanceDataGridView.Location = new Point(6, 22);
            instanceDataGridView.Name = "instanceDataGridView";
            instanceDataGridView.RowTemplate.Height = 25;
            instanceDataGridView.RowTemplate.Resizable = DataGridViewTriState.False;
            instanceDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            instanceDataGridView.Size = new Size(398, 373);
            instanceDataGridView.TabIndex = 5;
            // 
            // databaseGroupBox
            // 
            databaseGroupBox.Controls.Add(filterTextBox);
            databaseGroupBox.Controls.Add(clusterLabel);
            databaseGroupBox.Controls.Add(clusterComboBox);
            databaseGroupBox.Controls.Add(databaseDataGridView);
            databaseGroupBox.Dock = DockStyle.Left;
            databaseGroupBox.Location = new Point(3, 3);
            databaseGroupBox.Name = "databaseGroupBox";
            databaseGroupBox.Size = new Size(410, 401);
            databaseGroupBox.TabIndex = 0;
            databaseGroupBox.TabStop = false;
            databaseGroupBox.Text = "Database";
            // 
            // filterTextBox
            // 
            filterTextBox.Location = new Point(192, 23);
            filterTextBox.Name = "filterTextBox";
            filterTextBox.PlaceholderText = "Filter";
            filterTextBox.Size = new Size(212, 23);
            filterTextBox.TabIndex = 1;
            filterTextBox.TextChanged += filterTextBox_TextChanged;
            // 
            // clusterLabel
            // 
            clusterLabel.AutoSize = true;
            clusterLabel.Location = new Point(6, 25);
            clusterLabel.Name = "clusterLabel";
            clusterLabel.Size = new Size(52, 17);
            clusterLabel.TabIndex = 8;
            clusterLabel.Text = "Cluster";
            // 
            // clusterComboBox
            // 
            clusterComboBox.FormattingEnabled = true;
            clusterComboBox.Location = new Point(64, 22);
            clusterComboBox.Name = "clusterComboBox";
            clusterComboBox.Size = new Size(122, 24);
            clusterComboBox.TabIndex = 0;
            clusterComboBox.SelectedIndexChanged += clusterComboBox_SelectedIndexChanged;
            // 
            // databaseDataGridView
            // 
            databaseDataGridView.AllowUserToAddRows = false;
            databaseDataGridView.AllowUserToDeleteRows = false;
            databaseDataGridView.AllowUserToResizeColumns = false;
            databaseDataGridView.AllowUserToResizeRows = false;
            databaseDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            databaseDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            databaseDataGridView.Location = new Point(6, 52);
            databaseDataGridView.Name = "databaseDataGridView";
            databaseDataGridView.RowTemplate.Height = 25;
            databaseDataGridView.RowTemplate.Resizable = DataGridViewTriState.False;
            databaseDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            databaseDataGridView.Size = new Size(398, 343);
            databaseDataGridView.TabIndex = 2;
            // 
            // queryTabPage
            // 
            queryTabPage.Controls.Add(addQueryButton);
            queryTabPage.Controls.Add(commandListGroupBox);
            queryTabPage.Controls.Add(queryGroupBox);
            queryTabPage.Location = new Point(4, 25);
            queryTabPage.Name = "queryTabPage";
            queryTabPage.Padding = new Padding(3);
            queryTabPage.Size = new Size(876, 407);
            queryTabPage.TabIndex = 1;
            queryTabPage.Text = "Query";
            queryTabPage.UseVisualStyleBackColor = true;
            // 
            // addQueryButton
            // 
            addQueryButton.FlatStyle = FlatStyle.Popup;
            addQueryButton.Font = new Font("Microsoft Sans Serif", 6.75F, FontStyle.Bold, GraphicsUnit.Point);
            addQueryButton.Location = new Point(419, 179);
            addQueryButton.Name = "addQueryButton";
            addQueryButton.Size = new Size(38, 35);
            addQueryButton.TabIndex = 1;
            addQueryButton.Text = ">>";
            addQueryButton.UseVisualStyleBackColor = true;
            addQueryButton.Click += addQueryButton_Click;
            // 
            // commandListGroupBox
            // 
            commandListGroupBox.Controls.Add(clearCommandListDGVButton);
            commandListGroupBox.Controls.Add(commandDataGridView);
            commandListGroupBox.Dock = DockStyle.Right;
            commandListGroupBox.Location = new Point(463, 3);
            commandListGroupBox.Name = "commandListGroupBox";
            commandListGroupBox.Size = new Size(410, 401);
            commandListGroupBox.TabIndex = 7;
            commandListGroupBox.TabStop = false;
            commandListGroupBox.Text = "Command list";
            // 
            // clearCommandListDGVButton
            // 
            clearCommandListDGVButton.FlatStyle = FlatStyle.Popup;
            clearCommandListDGVButton.Font = new Font("Microsoft Sans Serif", 6.75F, FontStyle.Bold, GraphicsUnit.Point);
            clearCommandListDGVButton.Location = new Point(378, 372);
            clearCommandListDGVButton.Name = "clearCommandListDGVButton";
            clearCommandListDGVButton.Size = new Size(26, 23);
            clearCommandListDGVButton.TabIndex = 3;
            clearCommandListDGVButton.Text = "X";
            clearCommandListDGVButton.UseVisualStyleBackColor = true;
            clearCommandListDGVButton.Click += clearCommandListDGVButton_Click;
            // 
            // commandDataGridView
            // 
            commandDataGridView.AllowUserToAddRows = false;
            commandDataGridView.AllowUserToResizeColumns = false;
            commandDataGridView.AllowUserToResizeRows = false;
            commandDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            commandDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            commandDataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            commandDataGridView.Location = new Point(6, 22);
            commandDataGridView.Name = "commandDataGridView";
            commandDataGridView.RowTemplate.Height = 25;
            commandDataGridView.Size = new Size(398, 373);
            commandDataGridView.TabIndex = 2;
            // 
            // queryGroupBox
            // 
            queryGroupBox.Controls.Add(queryTextBox);
            queryGroupBox.Dock = DockStyle.Left;
            queryGroupBox.Location = new Point(3, 3);
            queryGroupBox.Name = "queryGroupBox";
            queryGroupBox.Size = new Size(410, 401);
            queryGroupBox.TabIndex = 6;
            queryGroupBox.TabStop = false;
            queryGroupBox.Text = "Query";
            // 
            // queryTextBox
            // 
            queryTextBox.Location = new Point(6, 22);
            queryTextBox.Multiline = true;
            queryTextBox.Name = "queryTextBox";
            queryTextBox.ScrollBars = ScrollBars.Both;
            queryTextBox.Size = new Size(398, 373);
            queryTextBox.TabIndex = 0;
            // 
            // runTabPage
            // 
            runTabPage.Controls.Add(logGroupBox);
            runTabPage.Controls.Add(overviewGroupBox);
            runTabPage.Location = new Point(4, 24);
            runTabPage.Name = "runTabPage";
            runTabPage.Padding = new Padding(3);
            runTabPage.Size = new Size(876, 408);
            runTabPage.TabIndex = 2;
            runTabPage.Text = "Run";
            runTabPage.UseVisualStyleBackColor = true;
            // 
            // logGroupBox
            // 
            logGroupBox.Controls.Add(clipRunButton);
            logGroupBox.Controls.Add(logTextBox);
            logGroupBox.Dock = DockStyle.Right;
            logGroupBox.Location = new Point(463, 3);
            logGroupBox.Name = "logGroupBox";
            logGroupBox.Size = new Size(410, 402);
            logGroupBox.TabIndex = 7;
            logGroupBox.TabStop = false;
            logGroupBox.Text = "Log";
            // 
            // clipRunButton
            // 
            clipRunButton.FlatAppearance.BorderSize = 0;
            clipRunButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            clipRunButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            clipRunButton.FlatStyle = FlatStyle.Popup;
            clipRunButton.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            clipRunButton.Location = new Point(6, 372);
            clipRunButton.Name = "clipRunButton";
            clipRunButton.Size = new Size(398, 23);
            clipRunButton.TabIndex = 1;
            clipRunButton.Text = "📋 Copy to clipboard";
            clipRunButton.TextAlign = ContentAlignment.TopCenter;
            clipRunButton.UseVisualStyleBackColor = true;
            clipRunButton.Click += clipRunButton_Click;
            // 
            // logTextBox
            // 
            logTextBox.Location = new Point(6, 22);
            logTextBox.Multiline = true;
            logTextBox.Name = "logTextBox";
            logTextBox.ReadOnly = true;
            logTextBox.ScrollBars = ScrollBars.Both;
            logTextBox.Size = new Size(398, 344);
            logTextBox.TabIndex = 4;
            // 
            // overviewGroupBox
            // 
            overviewGroupBox.Controls.Add(runButton);
            overviewGroupBox.Controls.Add(runGroupBox);
            overviewGroupBox.Controls.Add(commandCountLabel);
            overviewGroupBox.Controls.Add(instanceCountLabel);
            overviewGroupBox.Controls.Add(commandProgressBar);
            overviewGroupBox.Controls.Add(instanceProgressBar);
            overviewGroupBox.Dock = DockStyle.Left;
            overviewGroupBox.Location = new Point(3, 3);
            overviewGroupBox.Name = "overviewGroupBox";
            overviewGroupBox.Size = new Size(410, 402);
            overviewGroupBox.TabIndex = 6;
            overviewGroupBox.TabStop = false;
            overviewGroupBox.Text = "Overview";
            // 
            // runButton
            // 
            runButton.FlatStyle = FlatStyle.Popup;
            runButton.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            runButton.Location = new Point(6, 277);
            runButton.Name = "runButton";
            runButton.Size = new Size(398, 23);
            runButton.TabIndex = 0;
            runButton.Text = "⚙️ Run";
            runButton.TextAlign = ContentAlignment.TopCenter;
            runButton.UseVisualStyleBackColor = true;
            runButton.Click += runButton_Click;
            // 
            // runGroupBox
            // 
            runGroupBox.Location = new Point(6, 22);
            runGroupBox.Name = "runGroupBox";
            runGroupBox.Size = new Size(398, 249);
            runGroupBox.TabIndex = 14;
            runGroupBox.TabStop = false;
            // 
            // commandCountLabel
            // 
            commandCountLabel.AutoSize = true;
            commandCountLabel.Font = new Font("Microsoft Sans Serif", 7F, FontStyle.Regular, GraphicsUnit.Point);
            commandCountLabel.Location = new Point(6, 359);
            commandCountLabel.Name = "commandCountLabel";
            commandCountLabel.Size = new Size(16, 13);
            commandCountLabel.TabIndex = 13;
            commandCountLabel.Text = "...";
            // 
            // instanceCountLabel
            // 
            instanceCountLabel.AutoSize = true;
            instanceCountLabel.Font = new Font("Microsoft Sans Serif", 7F, FontStyle.Regular, GraphicsUnit.Point);
            instanceCountLabel.Location = new Point(6, 319);
            instanceCountLabel.Name = "instanceCountLabel";
            instanceCountLabel.Size = new Size(16, 13);
            instanceCountLabel.TabIndex = 12;
            instanceCountLabel.Text = "...";
            // 
            // commandProgressBar
            // 
            commandProgressBar.BackColor = Color.FromArgb(192, 192, 255);
            commandProgressBar.Location = new Point(6, 346);
            commandProgressBar.Name = "commandProgressBar";
            commandProgressBar.Size = new Size(398, 10);
            commandProgressBar.TabIndex = 11;
            // 
            // instanceProgressBar
            // 
            instanceProgressBar.BackColor = Color.FromArgb(192, 192, 255);
            instanceProgressBar.Location = new Point(6, 306);
            instanceProgressBar.Name = "instanceProgressBar";
            instanceProgressBar.Size = new Size(398, 10);
            instanceProgressBar.TabIndex = 10;
            // 
            // timer
            // 
            timer.Enabled = true;
            timer.Interval = 1000;
            timer.Tick += timer_Tick;
            // 
            // backgroundWorker
            // 
            backgroundWorker.DoWork += backgroundWorker_DoWork;
            // 
            // ApSqlForm
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 461);
            Controls.Add(mainTabControl);
            Controls.Add(menu);
            Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menu;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ApSqlForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ApSql";
            Load += ApSqlForm_Load;
            KeyDown += ApSqlForm_KeyDown;
            menu.ResumeLayout(false);
            menu.PerformLayout();
            mainTabControl.ResumeLayout(false);
            serverTabPage.ResumeLayout(false);
            instanceListGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)instanceDataGridView).EndInit();
            databaseGroupBox.ResumeLayout(false);
            databaseGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)databaseDataGridView).EndInit();
            queryTabPage.ResumeLayout(false);
            commandListGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)commandDataGridView).EndInit();
            queryGroupBox.ResumeLayout(false);
            queryGroupBox.PerformLayout();
            runTabPage.ResumeLayout(false);
            logGroupBox.ResumeLayout(false);
            logGroupBox.PerformLayout();
            overviewGroupBox.ResumeLayout(false);
            overviewGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menu;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem loadToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem serverToolStripMenuItem;
        private ToolStripMenuItem queryToolStripMenuItem;
        private ToolStripMenuItem runToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem viewHelpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private TabPage runTabPage;
        private GroupBox instanceListGroupBox;
        private GroupBox databaseGroupBox;
        private Button moveAllQueryButton;
        private GroupBox commandListGroupBox;
        private GroupBox queryGroupBox;
        private Button clearQueryDGVButton;
        private DataGridView queryDataGridView;
        private GroupBox logGroupBox;
        private GroupBox overviewGroupBox;
        private Label clusterLabel;
        private System.Windows.Forms.Timer timer;
        private GroupBox runGroupBox;
        internal DataGridView databaseDataGridView;
        internal Button clearInstanceListDGVButton;
        internal DataGridView instanceDataGridView;
        internal Button moveAllServerButton;
        internal ComboBox clusterComboBox;
        internal Button newClusterButton;
        internal Button moveSelectedServerButton;
        internal TabControl mainTabControl;
        internal Button addQueryButton;
        internal Button clearCommandListDGVButton;
        internal DataGridView commandDataGridView;
        internal TextBox queryTextBox;
        internal Button clipRunButton;
        internal Button runButton;
        internal ProgressBar commandProgressBar;
        internal ProgressBar instanceProgressBar;
        internal Label commandCountLabel;
        internal Label instanceCountLabel;
        internal TextBox filterTextBox;
        internal TabPage queryTabPage;
        internal TabPage serverTabPage;
        internal TextBox logTextBox;
        internal System.ComponentModel.BackgroundWorker backgroundWorker;
    }
}