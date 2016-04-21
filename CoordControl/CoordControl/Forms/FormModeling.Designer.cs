namespace CoordControl.Forms
{
    partial class FormModeling
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormModeling));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonStart = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonPause = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonReset = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelCurrentTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericUpDownDelay = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownRegionIntensity = new System.Windows.Forms.NumericUpDown();
            this.comboBoxViewParam = new System.Windows.Forms.ComboBox();
            this.numericUpDownRegionVelocity = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownRegionDensity = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownRegionFlowPart = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.trackBarModelingSpeed = new System.Windows.Forms.TrackBar();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panelCanvas = new System.Windows.Forms.Panel();
            this.trackBarScale = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDelay)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRegionIntensity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRegionVelocity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRegionDensity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRegionFlowPart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarModelingSpeed)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarScale)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonStart,
            this.toolStripButtonPause,
            this.toolStripButtonReset});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1119, 27);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonStart
            // 
            this.toolStripButtonStart.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonStart.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonStart.Image")));
            this.toolStripButtonStart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonStart.Name = "toolStripButtonStart";
            this.toolStripButtonStart.Size = new System.Drawing.Size(51, 24);
            this.toolStripButtonStart.Text = "Старт";
            this.toolStripButtonStart.Click += new System.EventHandler(this.toolStripButtonStart_Click);
            // 
            // toolStripButtonPause
            // 
            this.toolStripButtonPause.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonPause.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonPause.Image")));
            this.toolStripButtonPause.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonPause.Name = "toolStripButtonPause";
            this.toolStripButtonPause.Size = new System.Drawing.Size(54, 24);
            this.toolStripButtonPause.Text = "Пауза";
            this.toolStripButtonPause.Click += new System.EventHandler(this.toolStripButtonPause_Click);
            // 
            // toolStripButtonReset
            // 
            this.toolStripButtonReset.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonReset.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonReset.Image")));
            this.toolStripButtonReset.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonReset.Name = "toolStripButtonReset";
            this.toolStripButtonReset.Size = new System.Drawing.Size(56, 24);
            this.toolStripButtonReset.Text = "Сброс";
            this.toolStripButtonReset.Click += new System.EventHandler(this.toolStripButtonReset_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabelCurrentTime,
            this.toolStripStatusLabel3});
            this.statusStrip1.Location = new System.Drawing.Point(0, 723);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1119, 25);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(197, 20);
            this.toolStripStatusLabel1.Text = "Текущее модельное время";
            // 
            // toolStripStatusLabelCurrentTime
            // 
            this.toolStripStatusLabelCurrentTime.Name = "toolStripStatusLabelCurrentTime";
            this.toolStripStatusLabelCurrentTime.Size = new System.Drawing.Size(17, 20);
            this.toolStripStatusLabelCurrentTime.Text = "0";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(31, 20);
            this.toolStripStatusLabel3.Text = "сек";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.numericUpDownDelay);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(894, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(208, 93);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Статистика магистрали";
            // 
            // numericUpDownDelay
            // 
            this.numericUpDownDelay.DecimalPlaces = 2;
            this.numericUpDownDelay.InterceptArrowKeys = false;
            this.numericUpDownDelay.Location = new System.Drawing.Point(18, 50);
            this.numericUpDownDelay.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownDelay.Name = "numericUpDownDelay";
            this.numericUpDownDelay.ReadOnly = true;
            this.numericUpDownDelay.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownDelay.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Средняя задержка, сек/авт";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.numericUpDownRegionIntensity);
            this.groupBox2.Controls.Add(this.comboBoxViewParam);
            this.groupBox2.Controls.Add(this.numericUpDownRegionVelocity);
            this.groupBox2.Controls.Add(this.numericUpDownRegionDensity);
            this.groupBox2.Controls.Add(this.numericUpDownRegionFlowPart);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(898, 128);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(204, 328);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Характеристики участка";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 34);
            this.label3.TabIndex = 8;
            this.label3.Text = "(необходимо выбрать\r\nучасток на схеме)";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "отображение цветом:";
            // 
            // numericUpDownRegionIntensity
            // 
            this.numericUpDownRegionIntensity.DecimalPlaces = 2;
            this.numericUpDownRegionIntensity.InterceptArrowKeys = false;
            this.numericUpDownRegionIntensity.Location = new System.Drawing.Point(26, 235);
            this.numericUpDownRegionIntensity.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownRegionIntensity.Name = "numericUpDownRegionIntensity";
            this.numericUpDownRegionIntensity.ReadOnly = true;
            this.numericUpDownRegionIntensity.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownRegionIntensity.TabIndex = 7;
            // 
            // comboBoxViewParam
            // 
            this.comboBoxViewParam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxViewParam.FormattingEnabled = true;
            this.comboBoxViewParam.Items.AddRange(new object[] {
            "Часть потока",
            "Интенсивность",
            "Плотность",
            "Скорость"});
            this.comboBoxViewParam.Location = new System.Drawing.Point(16, 289);
            this.comboBoxViewParam.Name = "comboBoxViewParam";
            this.comboBoxViewParam.Size = new System.Drawing.Size(159, 24);
            this.comboBoxViewParam.TabIndex = 6;
            // 
            // numericUpDownRegionVelocity
            // 
            this.numericUpDownRegionVelocity.DecimalPlaces = 2;
            this.numericUpDownRegionVelocity.InterceptArrowKeys = false;
            this.numericUpDownRegionVelocity.Location = new System.Drawing.Point(26, 187);
            this.numericUpDownRegionVelocity.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownRegionVelocity.Name = "numericUpDownRegionVelocity";
            this.numericUpDownRegionVelocity.ReadOnly = true;
            this.numericUpDownRegionVelocity.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownRegionVelocity.TabIndex = 6;
            // 
            // numericUpDownRegionDensity
            // 
            this.numericUpDownRegionDensity.DecimalPlaces = 2;
            this.numericUpDownRegionDensity.InterceptArrowKeys = false;
            this.numericUpDownRegionDensity.Location = new System.Drawing.Point(26, 139);
            this.numericUpDownRegionDensity.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownRegionDensity.Name = "numericUpDownRegionDensity";
            this.numericUpDownRegionDensity.ReadOnly = true;
            this.numericUpDownRegionDensity.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownRegionDensity.TabIndex = 5;
            // 
            // numericUpDownRegionFlowPart
            // 
            this.numericUpDownRegionFlowPart.DecimalPlaces = 2;
            this.numericUpDownRegionFlowPart.InterceptArrowKeys = false;
            this.numericUpDownRegionFlowPart.Location = new System.Drawing.Point(26, 90);
            this.numericUpDownRegionFlowPart.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownRegionFlowPart.Name = "numericUpDownRegionFlowPart";
            this.numericUpDownRegionFlowPart.ReadOnly = true;
            this.numericUpDownRegionFlowPart.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownRegionFlowPart.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 215);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 17);
            this.label8.TabIndex = 3;
            this.label8.Text = "интенсивность, авт/ч";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "скорость, км/ч";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "плотность, авт/м";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "часть ТП, авт";
            // 
            // trackBarModelingSpeed
            // 
            this.trackBarModelingSpeed.Location = new System.Drawing.Point(7, 23);
            this.trackBarModelingSpeed.Maximum = 999;
            this.trackBarModelingSpeed.Name = "trackBarModelingSpeed";
            this.trackBarModelingSpeed.Size = new System.Drawing.Size(191, 56);
            this.trackBarModelingSpeed.TabIndex = 5;
            this.trackBarModelingSpeed.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarModelingSpeed.Value = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(134, 49);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 17);
            this.label10.TabIndex = 9;
            this.label10.Text = "быстро";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 49);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 17);
            this.label11.TabIndex = 10;
            this.label11.Text = "медленно";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.trackBarModelingSpeed);
            this.groupBox3.Location = new System.Drawing.Point(898, 462);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(204, 86);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Скорость моделирования";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // panelCanvas
            // 
            this.panelCanvas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelCanvas.Location = new System.Drawing.Point(13, 31);
            this.panelCanvas.Name = "panelCanvas";
            this.panelCanvas.Size = new System.Drawing.Size(879, 681);
            this.panelCanvas.TabIndex = 5;
            this.panelCanvas.Scroll += new System.Windows.Forms.ScrollEventHandler(this.panelCanvas_Scroll);
            this.panelCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCanvas_Paint_1);
            this.panelCanvas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelCanvas_MouseClick_1);
            // 
            // trackBarScale
            // 
            this.trackBarScale.Location = new System.Drawing.Point(10, 21);
            this.trackBarScale.Maximum = 30;
            this.trackBarScale.Minimum = 3;
            this.trackBarScale.Name = "trackBarScale";
            this.trackBarScale.Size = new System.Drawing.Size(188, 56);
            this.trackBarScale.TabIndex = 0;
            this.trackBarScale.Value = 15;
            this.trackBarScale.ValueChanged += new System.EventHandler(this.trackBarScale_ValueChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "3 пикс/метр";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 58);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 17);
            this.label9.TabIndex = 2;
            this.label9.Text = "0.3 пикс/метр";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.trackBarScale);
            this.groupBox4.Location = new System.Drawing.Point(898, 554);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(204, 92);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Масштаб схемы";
            // 
            // FormModeling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 748);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.panelCanvas);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.MinimumSize = new System.Drawing.Size(894, 733);
            this.Name = "FormModeling";
            this.Text = "Моделирование";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormModeling_Load);
            this.SizeChanged += new System.EventHandler(this.FormModeling_SizeChanged);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDelay)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRegionIntensity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRegionVelocity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRegionDensity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRegionFlowPart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarModelingSpeed)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarScale)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelCurrentTime;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDownDelay;
        private System.Windows.Forms.NumericUpDown numericUpDownRegionIntensity;
        private System.Windows.Forms.NumericUpDown numericUpDownRegionVelocity;
        private System.Windows.Forms.NumericUpDown numericUpDownRegionDensity;
        private System.Windows.Forms.NumericUpDown numericUpDownRegionFlowPart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripButton toolStripButtonStart;
        private System.Windows.Forms.ToolStripButton toolStripButtonPause;
        private System.Windows.Forms.ToolStripButton toolStripButtonReset;
        private System.Windows.Forms.TrackBar trackBarModelingSpeed;
        private System.Windows.Forms.ComboBox comboBoxViewParam;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Panel panelCanvas;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar trackBarScale;
    }
}