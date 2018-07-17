namespace WebTradeC
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.tabStreams = new System.Windows.Forms.TabControl();
            this.dataStreamsPage = new System.Windows.Forms.TabPage();
            this.btnUpdateAll = new System.Windows.Forms.Button();
            this.btnUpdateStream = new System.Windows.Forms.Button();
            this.btnDeleteStream = new System.Windows.Forms.Button();
            this.dgridStreams = new System.Windows.Forms.DataGridView();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entries = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lastupdated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.display = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.isLive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnAddStream = new System.Windows.Forms.Button();
            this.chtStreams = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnSaveData = new System.Windows.Forms.Button();
            this.btnLoadTickLists = new System.Windows.Forms.Button();
            this.backtestAndOptimization = new System.Windows.Forms.TabPage();
            this.btnOptimize = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgridBTRight = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn4 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgridBTLeft = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.chtBackTest = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.liveTradingPage = new System.Windows.Forms.TabPage();
            this.openValueDialog = new System.Windows.Forms.OpenFileDialog();
            this.openWebDataDialog = new System.Windows.Forms.OpenFileDialog();
            this.openDataDialog = new System.Windows.Forms.OpenFileDialog();
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.mainBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabStreams.SuspendLayout();
            this.dataStreamsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgridStreams)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtStreams)).BeginInit();
            this.backtestAndOptimization.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgridBTRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgridBTLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtBackTest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabStreams
            // 
            this.tabStreams.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabStreams.Controls.Add(this.dataStreamsPage);
            this.tabStreams.Controls.Add(this.backtestAndOptimization);
            this.tabStreams.Controls.Add(this.liveTradingPage);
            this.tabStreams.Location = new System.Drawing.Point(5, 3);
            this.tabStreams.Name = "tabStreams";
            this.tabStreams.SelectedIndex = 0;
            this.tabStreams.Size = new System.Drawing.Size(906, 773);
            this.tabStreams.TabIndex = 3;
            // 
            // dataStreamsPage
            // 
            this.dataStreamsPage.Controls.Add(this.tableLayoutPanel1);
            this.dataStreamsPage.Location = new System.Drawing.Point(4, 22);
            this.dataStreamsPage.Name = "dataStreamsPage";
            this.dataStreamsPage.Padding = new System.Windows.Forms.Padding(3);
            this.dataStreamsPage.Size = new System.Drawing.Size(1247, 793);
            this.dataStreamsPage.TabIndex = 1;
            this.dataStreamsPage.Text = "Data streams";
            this.dataStreamsPage.UseVisualStyleBackColor = true;
            // 
            // btnUpdateAll
            // 
            this.btnUpdateAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUpdateAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateAll.Location = new System.Drawing.Point(1105, 519);
            this.btnUpdateAll.Name = "btnUpdateAll";
            this.btnUpdateAll.Size = new System.Drawing.Size(133, 27);
            this.btnUpdateAll.TabIndex = 17;
            this.btnUpdateAll.Text = "Update all";
            this.btnUpdateAll.UseVisualStyleBackColor = true;
            this.btnUpdateAll.Click += new System.EventHandler(this.btnUpdateAll_Click);
            // 
            // btnUpdateStream
            // 
            this.btnUpdateStream.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUpdateStream.Location = new System.Drawing.Point(1105, 552);
            this.btnUpdateStream.Name = "btnUpdateStream";
            this.btnUpdateStream.Size = new System.Drawing.Size(133, 62);
            this.btnUpdateStream.TabIndex = 16;
            this.btnUpdateStream.Text = "Update stream";
            this.btnUpdateStream.UseVisualStyleBackColor = true;
            this.btnUpdateStream.Click += new System.EventHandler(this.btnUpdateStream_Click);
            // 
            // btnDeleteStream
            // 
            this.btnDeleteStream.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeleteStream.Location = new System.Drawing.Point(1105, 620);
            this.btnDeleteStream.Name = "btnDeleteStream";
            this.btnDeleteStream.Size = new System.Drawing.Size(133, 135);
            this.btnDeleteStream.TabIndex = 15;
            this.btnDeleteStream.Text = "Delete stream";
            this.btnDeleteStream.UseVisualStyleBackColor = true;
            this.btnDeleteStream.Click += new System.EventHandler(this.btnDeleteStream_Click);
            // 
            // dgridStreams
            // 
            this.dgridStreams.AllowUserToAddRows = false;
            this.dgridStreams.AllowUserToDeleteRows = false;
            this.dgridStreams.AllowUserToResizeRows = false;
            this.dgridStreams.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgridStreams.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Description,
            this.entries,
            this.Lastupdated,
            this.display,
            this.isLive});
            this.tableLayoutPanel1.SetColumnSpan(this.dgridStreams, 2);
            this.dgridStreams.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgridStreams.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgridStreams.Location = new System.Drawing.Point(3, 452);
            this.dgridStreams.Name = "dgridStreams";
            this.tableLayoutPanel1.SetRowSpan(this.dgridStreams, 4);
            this.dgridStreams.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgridStreams.Size = new System.Drawing.Size(1096, 303);
            this.dgridStreams.TabIndex = 14;
            this.dgridStreams.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgridStreams_CellContentClick);
            // 
            // Description
            // 
            this.Description.DataPropertyName = "name";
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // entries
            // 
            this.entries.DataPropertyName = "count";
            this.entries.HeaderText = "# entries";
            this.entries.Name = "entries";
            this.entries.ReadOnly = true;
            // 
            // Lastupdated
            // 
            this.Lastupdated.DataPropertyName = "lastupdated";
            this.Lastupdated.HeaderText = "Last Updated";
            this.Lastupdated.Name = "Lastupdated";
            this.Lastupdated.ReadOnly = true;
            // 
            // display
            // 
            this.display.DataPropertyName = "display";
            this.display.HeaderText = "Display in Chart";
            this.display.Name = "display";
            // 
            // isLive
            // 
            this.isLive.DataPropertyName = "isLive";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.NullValue = false;
            this.isLive.DefaultCellStyle = dataGridViewCellStyle1;
            this.isLive.HeaderText = "Live";
            this.isLive.Name = "isLive";
            this.isLive.ReadOnly = true;
            // 
            // btnAddStream
            // 
            this.btnAddStream.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddStream.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStream.Location = new System.Drawing.Point(1105, 452);
            this.btnAddStream.Name = "btnAddStream";
            this.btnAddStream.Size = new System.Drawing.Size(133, 61);
            this.btnAddStream.TabIndex = 13;
            this.btnAddStream.Text = "Add stream...";
            this.btnAddStream.UseVisualStyleBackColor = true;
            this.btnAddStream.Click += new System.EventHandler(this.btnAddStream_Click);
            // 
            // chtStreams
            // 
            chartArea1.Name = "ChartArea1";
            this.chtStreams.ChartAreas.Add(chartArea1);
            this.tableLayoutPanel1.SetColumnSpan(this.chtStreams, 3);
            legend1.Name = "Legend1";
            this.chtStreams.Legends.Add(legend1);
            this.chtStreams.Location = new System.Drawing.Point(3, 3);
            this.chtStreams.Name = "chtStreams";
            this.chtStreams.Size = new System.Drawing.Size(1235, 443);
            this.chtStreams.TabIndex = 12;
            this.chtStreams.Text = "chart2";
            // 
            // btnSaveData
            // 
            this.btnSaveData.Location = new System.Drawing.Point(184, 761);
            this.btnSaveData.Name = "btnSaveData";
            this.btnSaveData.Size = new System.Drawing.Size(185, 23);
            this.btnSaveData.TabIndex = 1;
            this.btnSaveData.Text = "Save all data";
            this.btnSaveData.UseVisualStyleBackColor = true;
            this.btnSaveData.Click += new System.EventHandler(this.btnSaveData_Click);
            // 
            // btnLoadTickLists
            // 
            this.btnLoadTickLists.Location = new System.Drawing.Point(3, 761);
            this.btnLoadTickLists.Name = "btnLoadTickLists";
            this.btnLoadTickLists.Size = new System.Drawing.Size(175, 23);
            this.btnLoadTickLists.TabIndex = 0;
            this.btnLoadTickLists.Text = "Load all data from previous session";
            this.btnLoadTickLists.UseVisualStyleBackColor = true;
            this.btnLoadTickLists.Click += new System.EventHandler(this.btnLoadTickLists_Click);
            // 
            // backtestAndOptimization
            // 
            this.backtestAndOptimization.Controls.Add(this.tableLayoutPanel2);
            this.backtestAndOptimization.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.backtestAndOptimization.Location = new System.Drawing.Point(4, 22);
            this.backtestAndOptimization.Name = "backtestAndOptimization";
            this.backtestAndOptimization.Size = new System.Drawing.Size(898, 747);
            this.backtestAndOptimization.TabIndex = 0;
            this.backtestAndOptimization.Text = "Backtesting and Optimization";
            this.backtestAndOptimization.UseVisualStyleBackColor = true;
            // 
            // btnOptimize
            // 
            this.btnOptimize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOptimize.Location = new System.Drawing.Point(687, 386);
            this.btnOptimize.Name = "btnOptimize";
            this.btnOptimize.Size = new System.Drawing.Size(186, 277);
            this.btnOptimize.TabIndex = 8;
            this.btnOptimize.Text = "Find optimal settings...";
            this.btnOptimize.UseVisualStyleBackColor = true;
            this.btnOptimize.Click += new System.EventHandler(this.btnOptimize_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(345, 364);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(336, 19);
            this.label2.TabIndex = 16;
            this.label2.Text = "Select resulting stream";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 364);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(336, 19);
            this.label1.TabIndex = 16;
            this.label1.Text = "Select causal stream";
            // 
            // dgridBTRight
            // 
            this.dgridBTRight.AllowUserToAddRows = false;
            this.dgridBTRight.AllowUserToDeleteRows = false;
            this.dgridBTRight.AllowUserToResizeRows = false;
            this.dgridBTRight.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgridBTRight.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewCheckBoxColumn4});
            this.dgridBTRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgridBTRight.Location = new System.Drawing.Point(345, 386);
            this.dgridBTRight.Name = "dgridBTRight";
            this.tableLayoutPanel2.SetRowSpan(this.dgridBTRight, 5);
            this.dgridBTRight.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgridBTRight.Size = new System.Drawing.Size(336, 358);
            this.dgridBTRight.TabIndex = 15;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn4.HeaderText = "Description";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewCheckBoxColumn4
            // 
            this.dataGridViewCheckBoxColumn4.DataPropertyName = "isLive";
            this.dataGridViewCheckBoxColumn4.HeaderText = "Live";
            this.dataGridViewCheckBoxColumn4.Name = "dataGridViewCheckBoxColumn4";
            this.dataGridViewCheckBoxColumn4.ReadOnly = true;
            // 
            // dgridBTLeft
            // 
            this.dgridBTLeft.AllowUserToAddRows = false;
            this.dgridBTLeft.AllowUserToDeleteRows = false;
            this.dgridBTLeft.AllowUserToResizeRows = false;
            this.dgridBTLeft.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgridBTLeft.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewCheckBoxColumn2});
            this.dgridBTLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgridBTLeft.Location = new System.Drawing.Point(3, 386);
            this.dgridBTLeft.MultiSelect = false;
            this.dgridBTLeft.Name = "dgridBTLeft";
            this.tableLayoutPanel2.SetRowSpan(this.dgridBTLeft, 5);
            this.dgridBTLeft.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgridBTLeft.Size = new System.Drawing.Size(336, 358);
            this.dgridBTLeft.TabIndex = 15;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn1.HeaderText = "Description";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewCheckBoxColumn2
            // 
            this.dataGridViewCheckBoxColumn2.DataPropertyName = "isLive";
            this.dataGridViewCheckBoxColumn2.HeaderText = "Live";
            this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
            this.dataGridViewCheckBoxColumn2.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(687, 669);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 25);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chtBackTest
            // 
            this.chtBackTest.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea2.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea2.Name = "ChartArea1";
            this.chtBackTest.ChartAreas.Add(chartArea2);
            this.tableLayoutPanel2.SetColumnSpan(this.chtBackTest, 4);
            this.chtBackTest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chtBackTest.IsSoftShadows = false;
            legend2.Name = "Legend1";
            this.chtBackTest.Legends.Add(legend2);
            this.chtBackTest.Location = new System.Drawing.Point(0, 0);
            this.chtBackTest.Margin = new System.Windows.Forms.Padding(0);
            this.chtBackTest.Name = "chtBackTest";
            this.chtBackTest.Size = new System.Drawing.Size(898, 364);
            this.chtBackTest.TabIndex = 0;
            this.chtBackTest.Text = "chart1";
            // 
            // liveTradingPage
            // 
            this.liveTradingPage.Location = new System.Drawing.Point(4, 22);
            this.liveTradingPage.Name = "liveTradingPage";
            this.liveTradingPage.Padding = new System.Windows.Forms.Padding(3);
            this.liveTradingPage.Size = new System.Drawing.Size(1247, 793);
            this.liveTradingPage.TabIndex = 2;
            this.liveTradingPage.Text = "Live trading";
            this.liveTradingPage.UseVisualStyleBackColor = true;
            // 
            // openWebDataDialog
            // 
            this.openWebDataDialog.FileName = "openFileDialog1";
            // 
            // openDataDialog
            // 
            this.openDataDialog.FileName = "data.txt";
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.46959F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.5304F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 138F));
            this.tableLayoutPanel1.Controls.Add(this.chtStreams, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgridStreams, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnLoadTickLists, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnDeleteStream, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnUpdateStream, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnUpdateAll, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnAddStream, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnSaveData, 1, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.0155F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.9845F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 141F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1241, 787);
            this.tableLayoutPanel1.TabIndex = 18;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 192F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel2.Controls.Add(this.dgridBTLeft, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.button1, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.btnOptimize, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.dgridBTRight, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label2, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.chtBackTest, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 7;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 94.8718F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.128205F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 283F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 9F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(898, 747);
            this.tableLayoutPanel2.TabIndex = 17;
            // 
            // mainBindingSource
            // 
            this.mainBindingSource.DataSource = typeof(WebTradeC.Main);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(923, 778);
            this.Controls.Add(this.tabStreams);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Main";
            this.Text = "WebTrade 0.1";
            this.Load += new System.EventHandler(this.Main_Load);
            this.tabStreams.ResumeLayout(false);
            this.dataStreamsPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgridStreams)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtStreams)).EndInit();
            this.backtestAndOptimization.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgridBTRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgridBTLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtBackTest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabStreams;
        protected System.Windows.Forms.TabPage backtestAndOptimization;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtBackTest;
        private System.Windows.Forms.OpenFileDialog openValueDialog;
        private System.Windows.Forms.OpenFileDialog openWebDataDialog;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnOptimize;
        private System.Windows.Forms.TabPage dataStreamsPage;
        private System.Windows.Forms.TabPage liveTradingPage;
        private System.Windows.Forms.Button btnLoadTickLists;
        private System.Windows.Forms.Button btnSaveData;
        private System.Windows.Forms.OpenFileDialog openDataDialog;
        private System.Windows.Forms.Button btnAddStream;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtStreams;
        private System.Windows.Forms.DataGridView dgridStreams;
        private System.Windows.Forms.Button btnDeleteStream;
        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.Button btnUpdateAll;
        private System.Windows.Forms.Button btnUpdateStream;
        private System.Windows.Forms.BindingSource mainBindingSource;
        private System.Windows.Forms.DataGridView dgridBTRight;
        private System.Windows.Forms.DataGridView dgridBTLeft;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn entries;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lastupdated;
        private System.Windows.Forms.DataGridViewCheckBoxColumn display;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isLive;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}

