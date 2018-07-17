namespace WebTradeC
{
    partial class Optimize
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
            this.surface1 = new ChartDirector.WinChartViewer();
            this.numChangeMax = new System.Windows.Forms.NumericUpDown();
            this.numChangeMin = new System.Windows.Forms.NumericUpDown();
            this.rad_1 = new System.Windows.Forms.RadioButton();
            this.rad_01 = new System.Windows.Forms.RadioButton();
            this.rad_001 = new System.Windows.Forms.RadioButton();
            this.rad_0001 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkChangeRel = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numTimeMax = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radMonths = new System.Windows.Forms.RadioButton();
            this.radHours = new System.Windows.Forms.RadioButton();
            this.radDays = new System.Windows.Forms.RadioButton();
            this.radWeeks = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.numTimeMin = new System.Windows.Forms.NumericUpDown();
            this.btnRunBacktests = new System.Windows.Forms.Button();
            this.btnCloseOptimize = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAcceptStrategy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.surface1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numChangeMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numChangeMin)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTimeMax)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTimeMin)).BeginInit();
            this.SuspendLayout();
            // 
            // surface1
            // 
            this.surface1.Location = new System.Drawing.Point(12, 12);
            this.surface1.Name = "surface1";
            this.surface1.Size = new System.Drawing.Size(1004, 626);
            this.surface1.TabIndex = 0;
            this.surface1.TabStop = false;
            // 
            // numChangeMax
            // 
            this.numChangeMax.Location = new System.Drawing.Point(60, 36);
            this.numChangeMax.Name = "numChangeMax";
            this.numChangeMax.Size = new System.Drawing.Size(37, 20);
            this.numChangeMax.TabIndex = 2;
            this.numChangeMax.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // numChangeMin
            // 
            this.numChangeMin.Location = new System.Drawing.Point(11, 36);
            this.numChangeMin.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numChangeMin.Name = "numChangeMin";
            this.numChangeMin.Size = new System.Drawing.Size(39, 20);
            this.numChangeMin.TabIndex = 1;
            this.numChangeMin.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // rad_1
            // 
            this.rad_1.AutoSize = true;
            this.rad_1.Location = new System.Drawing.Point(3, 3);
            this.rad_1.Name = "rad_1";
            this.rad_1.Size = new System.Drawing.Size(31, 17);
            this.rad_1.TabIndex = 6;
            this.rad_1.TabStop = true;
            this.rad_1.Text = "1";
            this.rad_1.UseVisualStyleBackColor = true;
            // 
            // rad_01
            // 
            this.rad_01.AutoSize = true;
            this.rad_01.Checked = true;
            this.rad_01.Location = new System.Drawing.Point(3, 26);
            this.rad_01.Name = "rad_01";
            this.rad_01.Size = new System.Drawing.Size(40, 17);
            this.rad_01.TabIndex = 8;
            this.rad_01.TabStop = true;
            this.rad_01.Text = "0.1";
            this.rad_01.UseVisualStyleBackColor = true;
            // 
            // rad_001
            // 
            this.rad_001.AutoSize = true;
            this.rad_001.Location = new System.Drawing.Point(3, 49);
            this.rad_001.Name = "rad_001";
            this.rad_001.Size = new System.Drawing.Size(46, 17);
            this.rad_001.TabIndex = 9;
            this.rad_001.TabStop = true;
            this.rad_001.Text = "0.01";
            this.rad_001.UseVisualStyleBackColor = true;
            // 
            // rad_0001
            // 
            this.rad_0001.AutoSize = true;
            this.rad_0001.Location = new System.Drawing.Point(3, 72);
            this.rad_0001.Name = "rad_0001";
            this.rad_0001.Size = new System.Drawing.Size(52, 17);
            this.rad_0001.TabIndex = 10;
            this.rad_0001.TabStop = true;
            this.rad_0001.Text = "0.001";
            this.rad_0001.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Controls.Add(this.chkChangeRel);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.numChangeMin);
            this.groupBox2.Controls.Add(this.numChangeMax);
            this.groupBox2.Location = new System.Drawing.Point(1022, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(107, 214);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Change";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Step size";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rad_0001);
            this.panel1.Controls.Add(this.rad_1);
            this.panel1.Controls.Add(this.rad_01);
            this.panel1.Controls.Add(this.rad_001);
            this.panel1.Location = new System.Drawing.Point(14, 109);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(83, 99);
            this.panel1.TabIndex = 11;
            // 
            // chkChangeRel
            // 
            this.chkChangeRel.AutoSize = true;
            this.chkChangeRel.Checked = true;
            this.chkChangeRel.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkChangeRel.Location = new System.Drawing.Point(12, 62);
            this.chkChangeRel.Name = "chkChangeRel";
            this.chkChangeRel.Size = new System.Drawing.Size(65, 17);
            this.chkChangeRel.TabIndex = 10;
            this.chkChangeRel.Text = "Relative";
            this.chkChangeRel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Range";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.numTimeMax);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.numTimeMin);
            this.groupBox1.Location = new System.Drawing.Point(1022, 232);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(107, 191);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hold time";
            // 
            // numTimeMax
            // 
            this.numTimeMax.Location = new System.Drawing.Point(60, 36);
            this.numTimeMax.Name = "numTimeMax";
            this.numTimeMax.Size = new System.Drawing.Size(38, 20);
            this.numTimeMax.TabIndex = 13;
            this.numTimeMax.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Unit";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radMonths);
            this.panel2.Controls.Add(this.radHours);
            this.panel2.Controls.Add(this.radDays);
            this.panel2.Controls.Add(this.radWeeks);
            this.panel2.Location = new System.Drawing.Point(12, 79);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(83, 99);
            this.panel2.TabIndex = 11;
            // 
            // radMonths
            // 
            this.radMonths.AutoSize = true;
            this.radMonths.Location = new System.Drawing.Point(3, 72);
            this.radMonths.Name = "radMonths";
            this.radMonths.Size = new System.Drawing.Size(60, 17);
            this.radMonths.TabIndex = 10;
            this.radMonths.TabStop = true;
            this.radMonths.Text = "Months";
            this.radMonths.UseVisualStyleBackColor = true;
            // 
            // radHours
            // 
            this.radHours.AutoSize = true;
            this.radHours.Location = new System.Drawing.Point(3, 3);
            this.radHours.Name = "radHours";
            this.radHours.Size = new System.Drawing.Size(53, 17);
            this.radHours.TabIndex = 6;
            this.radHours.TabStop = true;
            this.radHours.Text = "Hours";
            this.radHours.UseVisualStyleBackColor = true;
            // 
            // radDays
            // 
            this.radDays.AutoSize = true;
            this.radDays.Location = new System.Drawing.Point(3, 26);
            this.radDays.Name = "radDays";
            this.radDays.Size = new System.Drawing.Size(49, 17);
            this.radDays.TabIndex = 8;
            this.radDays.TabStop = true;
            this.radDays.Text = "Days";
            this.radDays.UseVisualStyleBackColor = true;
            // 
            // radWeeks
            // 
            this.radWeeks.AutoSize = true;
            this.radWeeks.Checked = true;
            this.radWeeks.Location = new System.Drawing.Point(3, 49);
            this.radWeeks.Name = "radWeeks";
            this.radWeeks.Size = new System.Drawing.Size(59, 17);
            this.radWeeks.TabIndex = 9;
            this.radWeeks.TabStop = true;
            this.radWeeks.Text = "Weeks";
            this.radWeeks.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Range";
            // 
            // numTimeMin
            // 
            this.numTimeMin.Location = new System.Drawing.Point(11, 36);
            this.numTimeMin.Name = "numTimeMin";
            this.numTimeMin.Size = new System.Drawing.Size(39, 20);
            this.numTimeMin.TabIndex = 1;
            this.numTimeMin.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnRunBacktests
            // 
            this.btnRunBacktests.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRunBacktests.Location = new System.Drawing.Point(1023, 430);
            this.btnRunBacktests.Name = "btnRunBacktests";
            this.btnRunBacktests.Size = new System.Drawing.Size(106, 97);
            this.btnRunBacktests.TabIndex = 14;
            this.btnRunBacktests.Text = "Run backtests";
            this.btnRunBacktests.UseVisualStyleBackColor = true;
            this.btnRunBacktests.Click += new System.EventHandler(this.btnRunBacktests_Click);
            // 
            // btnCloseOptimize
            // 
            this.btnCloseOptimize.Location = new System.Drawing.Point(1023, 614);
            this.btnCloseOptimize.Name = "btnCloseOptimize";
            this.btnCloseOptimize.Size = new System.Drawing.Size(106, 23);
            this.btnCloseOptimize.TabIndex = 15;
            this.btnCloseOptimize.Text = "Close";
            this.btnCloseOptimize.UseVisualStyleBackColor = true;
            this.btnCloseOptimize.Click += new System.EventHandler(this.btnCloseOptimize_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1024, 576);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAcceptStrategy
            // 
            this.btnAcceptStrategy.Location = new System.Drawing.Point(1022, 533);
            this.btnAcceptStrategy.Name = "btnAcceptStrategy";
            this.btnAcceptStrategy.Size = new System.Drawing.Size(107, 23);
            this.btnAcceptStrategy.TabIndex = 17;
            this.btnAcceptStrategy.Text = "Accept";
            this.btnAcceptStrategy.UseVisualStyleBackColor = true;
            // 
            // Optimize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 648);
            this.Controls.Add(this.btnAcceptStrategy);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCloseOptimize);
            this.Controls.Add(this.btnRunBacktests);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.surface1);
            this.Name = "Optimize";
            this.Text = "Optimize";
            this.Load += new System.EventHandler(this.form_load);
            ((System.ComponentModel.ISupportInitialize)(this.surface1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numChangeMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numChangeMin)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTimeMax)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTimeMin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ChartDirector.WinChartViewer surface1;
        private System.Windows.Forms.NumericUpDown numChangeMax;
        private System.Windows.Forms.NumericUpDown numChangeMin;
        private System.Windows.Forms.RadioButton rad_1;
        private System.Windows.Forms.RadioButton rad_01;
        private System.Windows.Forms.RadioButton rad_001;
        private System.Windows.Forms.RadioButton rad_0001;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chkChangeRel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radMonths;
        private System.Windows.Forms.RadioButton radHours;
        private System.Windows.Forms.RadioButton radDays;
        private System.Windows.Forms.RadioButton radWeeks;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numTimeMin;
        private System.Windows.Forms.Button btnRunBacktests;
        private System.Windows.Forms.Button btnCloseOptimize;
        private System.Windows.Forms.NumericUpDown numTimeMax;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAcceptStrategy;



    }
}