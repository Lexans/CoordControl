﻿namespace CoordControl.Forms
{
    partial class FormStatistic
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Мат. ожидание");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("Дисперсия");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStatistic));
            this.listViewHistory = new System.Windows.Forms.ListView();
            this.columnHeaderNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDirect = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderReverse = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderSum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.listViewNumChars = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownDirect = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownReverse = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDownSum = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelMeasurePeriod = new System.Windows.Forms.Label();
            this.buttonShowGraph = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDirect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownReverse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSum)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewHistory
            // 
            this.listViewHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewHistory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderNum,
            this.columnHeaderDirect,
            this.columnHeaderReverse,
            this.columnHeaderSum});
            this.listViewHistory.Location = new System.Drawing.Point(14, 120);
            this.listViewHistory.Name = "listViewHistory";
            this.listViewHistory.Size = new System.Drawing.Size(628, 188);
            this.listViewHistory.TabIndex = 0;
            this.listViewHistory.UseCompatibleStateImageBehavior = false;
            this.listViewHistory.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderNum
            // 
            this.columnHeaderNum.Text = "№ изм";
            this.columnHeaderNum.Width = 65;
            // 
            // columnHeaderDirect
            // 
            this.columnHeaderDirect.Text = "Прямо";
            this.columnHeaderDirect.Width = 130;
            // 
            // columnHeaderReverse
            // 
            this.columnHeaderReverse.Text = "Обратно";
            this.columnHeaderReverse.Width = 139;
            // 
            // columnHeaderSum
            // 
            this.columnHeaderSum.Text = "Суммарно";
            this.columnHeaderSum.Width = 197;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "История измерений";
            // 
            // listViewNumChars
            // 
            this.listViewNumChars.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewNumChars.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listViewNumChars.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            this.listViewNumChars.Location = new System.Drawing.Point(14, 336);
            this.listViewNumChars.Name = "listViewNumChars";
            this.listViewNumChars.Size = new System.Drawing.Size(628, 108);
            this.listViewNumChars.TabIndex = 2;
            this.listViewNumChars.UseCompatibleStateImageBehavior = false;
            this.listViewNumChars.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Характеристика";
            this.columnHeader1.Width = 169;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Прямо";
            this.columnHeader2.Width = 87;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Обратно";
            this.columnHeader3.Width = 104;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Суммарно";
            this.columnHeader4.Width = 143;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 312);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Оценки числовых характеристик";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "прямо";
            // 
            // numericUpDownDirect
            // 
            this.numericUpDownDirect.DecimalPlaces = 2;
            this.numericUpDownDirect.InterceptArrowKeys = false;
            this.numericUpDownDirect.Location = new System.Drawing.Point(69, 30);
            this.numericUpDownDirect.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownDirect.Name = "numericUpDownDirect";
            this.numericUpDownDirect.ReadOnly = true;
            this.numericUpDownDirect.Size = new System.Drawing.Size(115, 24);
            this.numericUpDownDirect.TabIndex = 6;
            // 
            // numericUpDownReverse
            // 
            this.numericUpDownReverse.DecimalPlaces = 2;
            this.numericUpDownReverse.InterceptArrowKeys = false;
            this.numericUpDownReverse.Location = new System.Drawing.Point(277, 28);
            this.numericUpDownReverse.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownReverse.Name = "numericUpDownReverse";
            this.numericUpDownReverse.ReadOnly = true;
            this.numericUpDownReverse.Size = new System.Drawing.Size(115, 24);
            this.numericUpDownReverse.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(199, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "обратно";
            // 
            // numericUpDownSum
            // 
            this.numericUpDownSum.DecimalPlaces = 2;
            this.numericUpDownSum.InterceptArrowKeys = false;
            this.numericUpDownSum.Location = new System.Drawing.Point(498, 28);
            this.numericUpDownSum.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownSum.Name = "numericUpDownSum";
            this.numericUpDownSum.ReadOnly = true;
            this.numericUpDownSum.Size = new System.Drawing.Size(115, 24);
            this.numericUpDownSum.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(411, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 18);
            this.label6.TabIndex = 9;
            this.label6.Text = "суммарно";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.numericUpDownSum);
            this.groupBox1.Controls.Add(this.numericUpDownDirect);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.numericUpDownReverse);
            this.groupBox1.Location = new System.Drawing.Point(14, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(629, 73);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Текущее значение, сек/авт";
            // 
            // labelMeasurePeriod
            // 
            this.labelMeasurePeriod.AutoSize = true;
            this.labelMeasurePeriod.Location = new System.Drawing.Point(151, 95);
            this.labelMeasurePeriod.Name = "labelMeasurePeriod";
            this.labelMeasurePeriod.Size = new System.Drawing.Size(192, 18);
            this.labelMeasurePeriod.TabIndex = 12;
            this.labelMeasurePeriod.Text = "(измерения каждые 0 сек)";
            // 
            // buttonShowGraph
            // 
            this.buttonShowGraph.Location = new System.Drawing.Point(428, 87);
            this.buttonShowGraph.Name = "buttonShowGraph";
            this.buttonShowGraph.Size = new System.Drawing.Size(204, 31);
            this.buttonShowGraph.TabIndex = 13;
            this.buttonShowGraph.Text = "Показать график";
            this.buttonShowGraph.UseVisualStyleBackColor = true;
            this.buttonShowGraph.Click += new System.EventHandler(this.buttonShowGraph_Click);
            // 
            // FormStatistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 456);
            this.Controls.Add(this.buttonShowGraph);
            this.Controls.Add(this.labelMeasurePeriod);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listViewNumChars);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listViewHistory);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "FormStatistic";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Средняя задержка автомобилей на магистрали";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormStatistic_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDirect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownReverse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSum)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewHistory;
        private System.Windows.Forms.ColumnHeader columnHeaderNum;
        private System.Windows.Forms.ColumnHeader columnHeaderDirect;
        private System.Windows.Forms.ColumnHeader columnHeaderReverse;
        private System.Windows.Forms.ColumnHeader columnHeaderSum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listViewNumChars;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownDirect;
        private System.Windows.Forms.NumericUpDown numericUpDownReverse;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDownSum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelMeasurePeriod;
        private System.Windows.Forms.Button buttonShowGraph;
    }
}