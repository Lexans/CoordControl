namespace CoordControl
{
    partial class FormRoute
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDown8 = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.userControlPassRight = new CoordControl.UserControlPass();
            this.userControlPassDown = new CoordControl.UserControlPass();
            this.userControlPassUp = new CoordControl.UserControlPass();
            this.userControlPassLeft = new CoordControl.UserControlPass();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 48);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(296, 22);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Название магистральной улицы";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Количество перекерестков";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(12, 105);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(115, 22);
            this.numericUpDown1.TabIndex = 4;
            this.numericUpDown1.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.userControlPassRight);
            this.groupBox1.Controls.Add(this.userControlPassDown);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.userControlPassUp);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.userControlPassLeft);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(12, 158);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1064, 420);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Перекрестки";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(31, 106);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(245, 22);
            this.textBox3.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(220, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "Название пересекающей улицы";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(31, 50);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(245, 24);
            this.comboBox1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numericUpDown4);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.numericUpDown8);
            this.groupBox2.Location = new System.Drawing.Point(875, 168);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(181, 161);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Перегон";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Длина, м";
            // 
            // numericUpDown8
            // 
            this.numericUpDown8.Location = new System.Drawing.Point(11, 40);
            this.numericUpDown8.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown8.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDown8.Name = "numericUpDown8";
            this.numericUpDown8.Size = new System.Drawing.Size(128, 22);
            this.numericUpDown8.TabIndex = 5;
            this.numericUpDown8.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(201, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "Редактируемый перекресток";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(933, 594);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 30);
            this.button1.TabIndex = 8;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(786, 594);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 30);
            this.button2.TabIndex = 9;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Location = new System.Drawing.Point(11, 95);
            this.numericUpDown4.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.numericUpDown4.Minimum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(128, 22);
            this.numericUpDown4.TabIndex = 8;
            this.numericUpDown4.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(0, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(178, 17);
            this.label9.TabIndex = 7;
            this.label9.Text = "Расчетная скорость, км/ч";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.textBox1);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.numericUpDown1);
            this.groupBox4.Location = new System.Drawing.Point(12, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(323, 140);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Магистраль";
            // 
            // userControlPassRight
            // 
            this.userControlPassRight.DirectPart = 80;
            this.userControlPassRight.Intensity = 300;
            this.userControlPassRight.IsReadOnly = false;
            this.userControlPassRight.LeftPart = 5;
            this.userControlPassRight.LineCount = 2;
            this.userControlPassRight.LineWidth = 3.5D;
            this.userControlPassRight.Location = new System.Drawing.Point(582, 157);
            this.userControlPassRight.Name = "userControlPassRight";
            this.userControlPassRight.RightPart = 15;
            this.userControlPassRight.Size = new System.Drawing.Size(294, 177);
            this.userControlPassRight.TabIndex = 24;
            this.userControlPassRight.Title = "Правый подход";
            // 
            // userControlPassDown
            // 
            this.userControlPassDown.DirectPart = 80;
            this.userControlPassDown.Intensity = 300;
            this.userControlPassDown.IsReadOnly = false;
            this.userControlPassDown.LeftPart = 5;
            this.userControlPassDown.LineCount = 2;
            this.userControlPassDown.LineWidth = 3.5D;
            this.userControlPassDown.Location = new System.Drawing.Point(289, 225);
            this.userControlPassDown.Name = "userControlPassDown";
            this.userControlPassDown.RightPart = 15;
            this.userControlPassDown.Size = new System.Drawing.Size(290, 187);
            this.userControlPassDown.TabIndex = 23;
            this.userControlPassDown.Title = "Нижний подход";
            // 
            // userControlPassUp
            // 
            this.userControlPassUp.DirectPart = 80;
            this.userControlPassUp.Intensity = 300;
            this.userControlPassUp.IsReadOnly = false;
            this.userControlPassUp.LeftPart = 5;
            this.userControlPassUp.LineCount = 2;
            this.userControlPassUp.LineWidth = 3.5D;
            this.userControlPassUp.Location = new System.Drawing.Point(289, 43);
            this.userControlPassUp.Name = "userControlPassUp";
            this.userControlPassUp.RightPart = 15;
            this.userControlPassUp.Size = new System.Drawing.Size(290, 176);
            this.userControlPassUp.TabIndex = 22;
            this.userControlPassUp.Title = "Верхний подход";
            this.userControlPassUp.Load += new System.EventHandler(this.userControlPassUp_Load);
            // 
            // userControlPassLeft
            // 
            this.userControlPassLeft.DirectPart = 80;
            this.userControlPassLeft.Intensity = 300;
            this.userControlPassLeft.IsReadOnly = false;
            this.userControlPassLeft.LeftPart = 5;
            this.userControlPassLeft.LineCount = 2;
            this.userControlPassLeft.LineWidth = 3.5D;
            this.userControlPassLeft.Location = new System.Drawing.Point(0, 157);
            this.userControlPassLeft.Name = "userControlPassLeft";
            this.userControlPassLeft.RightPart = 15;
            this.userControlPassLeft.Size = new System.Drawing.Size(298, 184);
            this.userControlPassLeft.TabIndex = 21;
            this.userControlPassLeft.Title = "Левый подход";
            // 
            // FormRoute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 632);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormRoute";
            this.Text = "Магистраль";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDown8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private UserControlPass userControlPassLeft;
        private UserControlPass userControlPassRight;
        private UserControlPass userControlPassDown;
        private UserControlPass userControlPassUp;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}