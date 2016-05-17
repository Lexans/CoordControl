namespace CoordControl.Forms
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
            this.listViewHistory.Location = new System.Drawing.Point(12, 95);
            this.listViewHistory.Name = "listViewHistory";
            this.listViewHistory.Size = new System.Drawing.Size(559, 179);
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
            this.label1.Location = new System.Drawing.Point(9, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 17);
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
            this.listViewNumChars.Location = new System.Drawing.Point(12, 299);
            this.listViewNumChars.Name = "listViewNumChars";
            this.listViewNumChars.Size = new System.Drawing.Size(559, 96);
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
            this.label2.Location = new System.Drawing.Point(9, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Оценки числовых характеристик";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "прямо";
            // 
            // numericUpDownDirect
            // 
            this.numericUpDownDirect.DecimalPlaces = 2;
            this.numericUpDownDirect.InterceptArrowKeys = false;
            this.numericUpDownDirect.Location = new System.Drawing.Point(61, 27);
            this.numericUpDownDirect.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownDirect.Name = "numericUpDownDirect";
            this.numericUpDownDirect.ReadOnly = true;
            this.numericUpDownDirect.Size = new System.Drawing.Size(102, 22);
            this.numericUpDownDirect.TabIndex = 6;
            // 
            // numericUpDownReverse
            // 
            this.numericUpDownReverse.DecimalPlaces = 2;
            this.numericUpDownReverse.InterceptArrowKeys = false;
            this.numericUpDownReverse.Location = new System.Drawing.Point(246, 25);
            this.numericUpDownReverse.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownReverse.Name = "numericUpDownReverse";
            this.numericUpDownReverse.ReadOnly = true;
            this.numericUpDownReverse.Size = new System.Drawing.Size(102, 22);
            this.numericUpDownReverse.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(177, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "обратно";
            // 
            // numericUpDownSum
            // 
            this.numericUpDownSum.DecimalPlaces = 2;
            this.numericUpDownSum.InterceptArrowKeys = false;
            this.numericUpDownSum.Location = new System.Drawing.Point(443, 25);
            this.numericUpDownSum.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownSum.Name = "numericUpDownSum";
            this.numericUpDownSum.ReadOnly = true;
            this.numericUpDownSum.Size = new System.Drawing.Size(102, 22);
            this.numericUpDownSum.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(365, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 17);
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
            this.groupBox1.Location = new System.Drawing.Point(12, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(559, 65);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Текущее значение, сек/авт";
            // 
            // labelMeasurePeriod
            // 
            this.labelMeasurePeriod.AutoSize = true;
            this.labelMeasurePeriod.Location = new System.Drawing.Point(150, 75);
            this.labelMeasurePeriod.Name = "labelMeasurePeriod";
            this.labelMeasurePeriod.Size = new System.Drawing.Size(182, 17);
            this.labelMeasurePeriod.TabIndex = 12;
            this.labelMeasurePeriod.Text = "(измерения каждые 0 сек)";
            // 
            // FormStatistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 405);
            this.Controls.Add(this.labelMeasurePeriod);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listViewNumChars);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listViewHistory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FormStatistic";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Средняя задержка ТС на магистрали";
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
    }
}