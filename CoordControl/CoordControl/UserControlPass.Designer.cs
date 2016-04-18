namespace CoordControl
{
    partial class UserControlPass
    {
        /// <summary> 
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Обязательный метод для поддержки конструктора - не изменяйте 
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxPassName = new System.Windows.Forms.GroupBox();
            this.numericUpDownLinesN = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownLineWidth = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.numericUpDownRightPart = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownDirectPart = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownLeftPart = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownIntensity = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBoxPassName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLinesN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLineWidth)).BeginInit();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRightPart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDirectPart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLeftPart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIntensity)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxPassName
            // 
            this.groupBoxPassName.Controls.Add(this.numericUpDownLinesN);
            this.groupBoxPassName.Controls.Add(this.numericUpDownLineWidth);
            this.groupBoxPassName.Controls.Add(this.label14);
            this.groupBoxPassName.Controls.Add(this.label13);
            this.groupBoxPassName.Controls.Add(this.groupBox8);
            this.groupBoxPassName.Controls.Add(this.numericUpDownIntensity);
            this.groupBoxPassName.Controls.Add(this.label9);
            this.groupBoxPassName.Location = new System.Drawing.Point(3, -1);
            this.groupBoxPassName.Name = "groupBoxPassName";
            this.groupBoxPassName.Size = new System.Drawing.Size(283, 176);
            this.groupBoxPassName.TabIndex = 11;
            this.groupBoxPassName.TabStop = false;
            this.groupBoxPassName.Text = "Подход";
            // 
            // numericUpDownLinesN
            // 
            this.numericUpDownLinesN.Location = new System.Drawing.Point(14, 102);
            this.numericUpDownLinesN.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDownLinesN.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownLinesN.Name = "numericUpDownLinesN";
            this.numericUpDownLinesN.Size = new System.Drawing.Size(118, 22);
            this.numericUpDownLinesN.TabIndex = 6;
            this.numericUpDownLinesN.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownLinesN.ValueChanged += new System.EventHandler(this.numericUpDownLinesN_ValueChanged);
            // 
            // numericUpDownLineWidth
            // 
            this.numericUpDownLineWidth.DecimalPlaces = 2;
            this.numericUpDownLineWidth.Location = new System.Drawing.Point(14, 148);
            this.numericUpDownLineWidth.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownLineWidth.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            65536});
            this.numericUpDownLineWidth.Name = "numericUpDownLineWidth";
            this.numericUpDownLineWidth.Size = new System.Drawing.Size(118, 22);
            this.numericUpDownLineWidth.TabIndex = 5;
            this.numericUpDownLineWidth.Value = new decimal(new int[] {
            35,
            0,
            0,
            65536});
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(8, 63);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(105, 34);
            this.label14.TabIndex = 4;
            this.label14.Text = "Полос в одном\r\nнаправлении";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 127);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(129, 17);
            this.label13.TabIndex = 3;
            this.label13.Text = "Ширина полосы, м";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.label12);
            this.groupBox8.Controls.Add(this.label11);
            this.groupBox8.Controls.Add(this.label10);
            this.groupBox8.Controls.Add(this.numericUpDownRightPart);
            this.groupBox8.Controls.Add(this.numericUpDownDirectPart);
            this.groupBox8.Controls.Add(this.numericUpDownLeftPart);
            this.groupBox8.Location = new System.Drawing.Point(143, 35);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(132, 131);
            this.groupBox8.TabIndex = 2;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Части потока, %";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(2, 97);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 17);
            this.label12.TabIndex = 5;
            this.label12.Text = "направо";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(5, 61);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 17);
            this.label11.TabIndex = 4;
            this.label11.Text = "прямо";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 17);
            this.label10.TabIndex = 3;
            this.label10.Text = "налево";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // numericUpDownRightPart
            // 
            this.numericUpDownRightPart.Location = new System.Drawing.Point(66, 95);
            this.numericUpDownRightPart.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericUpDownRightPart.Name = "numericUpDownRightPart";
            this.numericUpDownRightPart.Size = new System.Drawing.Size(45, 22);
            this.numericUpDownRightPart.TabIndex = 2;
            this.numericUpDownRightPart.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numericUpDownRightPart.ValueChanged += new System.EventHandler(this.numericUpDownRightPart_ValueChanged);
            // 
            // numericUpDownDirectPart
            // 
            this.numericUpDownDirectPart.Location = new System.Drawing.Point(66, 61);
            this.numericUpDownDirectPart.Minimum = new decimal(new int[] {
            70,
            0,
            0,
            0});
            this.numericUpDownDirectPart.Name = "numericUpDownDirectPart";
            this.numericUpDownDirectPart.Size = new System.Drawing.Size(45, 22);
            this.numericUpDownDirectPart.TabIndex = 1;
            this.numericUpDownDirectPart.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            this.numericUpDownDirectPart.ValueChanged += new System.EventHandler(this.numericUpDownDirectPart_ValueChanged);
            // 
            // numericUpDownLeftPart
            // 
            this.numericUpDownLeftPart.Location = new System.Drawing.Point(66, 30);
            this.numericUpDownLeftPart.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericUpDownLeftPart.Name = "numericUpDownLeftPart";
            this.numericUpDownLeftPart.Size = new System.Drawing.Size(45, 22);
            this.numericUpDownLeftPart.TabIndex = 0;
            this.numericUpDownLeftPart.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownLeftPart.ValueChanged += new System.EventHandler(this.numericUpDownLeftPart_ValueChanged);
            // 
            // numericUpDownIntensity
            // 
            this.numericUpDownIntensity.Location = new System.Drawing.Point(12, 38);
            this.numericUpDownIntensity.Maximum = new decimal(new int[] {
            2800,
            0,
            0,
            0});
            this.numericUpDownIntensity.Minimum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numericUpDownIntensity.Name = "numericUpDownIntensity";
            this.numericUpDownIntensity.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownIntensity.TabIndex = 1;
            this.numericUpDownIntensity.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(150, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "Интенсивность, авт/ч";
            // 
            // UserControlPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxPassName);
            this.Name = "UserControlPass";
            this.Size = new System.Drawing.Size(292, 184);
            this.groupBoxPassName.ResumeLayout(false);
            this.groupBoxPassName.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLinesN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLineWidth)).EndInit();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRightPart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDirectPart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLeftPart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIntensity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxPassName;
        private System.Windows.Forms.NumericUpDown numericUpDownLinesN;
        private System.Windows.Forms.NumericUpDown numericUpDownLineWidth;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numericUpDownRightPart;
        private System.Windows.Forms.NumericUpDown numericUpDownDirectPart;
        private System.Windows.Forms.NumericUpDown numericUpDownLeftPart;
        private System.Windows.Forms.NumericUpDown numericUpDownIntensity;
        private System.Windows.Forms.Label label9;

    }
}
