﻿namespace CoordControl.Forms
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
            this.components = new System.ComponentModel.Container();
            this.textBoxStreetNameMagistral = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownCrossCount = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.userControlPassRight = new CoordControl.Forms.Controls.UserControlPass();
            this.userControlPassDown = new CoordControl.Forms.Controls.UserControlPass();
            this.label7 = new System.Windows.Forms.Label();
            this.userControlPassUp = new CoordControl.Forms.Controls.UserControlPass();
            this.groupBoxRoad = new System.Windows.Forms.GroupBox();
            this.numericUpDownRoadSpeed = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDownRoadLength = new System.Windows.Forms.NumericUpDown();
            this.comboBoxCrosses = new System.Windows.Forms.ComboBox();
            this.crossBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userControlPassLeft = new CoordControl.Forms.Controls.UserControlPass();
            this.textBoxStreetNameCross = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCrossCount)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBoxRoad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRoadSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRoadLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crossBindingSource)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxStreetNameMagistral
            // 
            this.textBoxStreetNameMagistral.Location = new System.Drawing.Point(12, 48);
            this.textBoxStreetNameMagistral.MaxLength = 256;
            this.textBoxStreetNameMagistral.Name = "textBoxStreetNameMagistral";
            this.textBoxStreetNameMagistral.Size = new System.Drawing.Size(296, 22);
            this.textBoxStreetNameMagistral.TabIndex = 0;
            this.textBoxStreetNameMagistral.TextChanged += new System.EventHandler(this.textBoxStreetNameMagistral_TextChanged);
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
            // numericUpDownCrossCount
            // 
            this.numericUpDownCrossCount.Location = new System.Drawing.Point(12, 105);
            this.numericUpDownCrossCount.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownCrossCount.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownCrossCount.Name = "numericUpDownCrossCount";
            this.numericUpDownCrossCount.Size = new System.Drawing.Size(115, 22);
            this.numericUpDownCrossCount.TabIndex = 4;
            this.numericUpDownCrossCount.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownCrossCount.ValueChanged += new System.EventHandler(this.numericUpDownCrossCount_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.userControlPassRight);
            this.groupBox1.Controls.Add(this.userControlPassDown);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.userControlPassUp);
            this.groupBox1.Controls.Add(this.groupBoxRoad);
            this.groupBox1.Controls.Add(this.comboBoxCrosses);
            this.groupBox1.Controls.Add(this.userControlPassLeft);
            this.groupBox1.Controls.Add(this.textBoxStreetNameCross);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(12, 158);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1064, 420);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Перекрестки";
            // 
            // userControlPassRight
            // 
            this.userControlPassRight.DirectPart = 80;
            this.userControlPassRight.Intensity = 300;
            this.userControlPassRight.IsIntensityReadOnly = false;
            this.userControlPassRight.LeftPart = 5;
            this.userControlPassRight.LineCount = 2;
            this.userControlPassRight.LineWidth = 3.5D;
            this.userControlPassRight.Location = new System.Drawing.Point(590, 154);
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
            this.userControlPassDown.IsIntensityReadOnly = false;
            this.userControlPassDown.LeftPart = 5;
            this.userControlPassDown.LineCount = 2;
            this.userControlPassDown.LineWidth = 3.5D;
            this.userControlPassDown.Location = new System.Drawing.Point(297, 222);
            this.userControlPassDown.Name = "userControlPassDown";
            this.userControlPassDown.RightPart = 15;
            this.userControlPassDown.Size = new System.Drawing.Size(290, 187);
            this.userControlPassDown.TabIndex = 23;
            this.userControlPassDown.Title = "Нижний подход";
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
            // userControlPassUp
            // 
            this.userControlPassUp.DirectPart = 80;
            this.userControlPassUp.Intensity = 300;
            this.userControlPassUp.IsIntensityReadOnly = false;
            this.userControlPassUp.LeftPart = 5;
            this.userControlPassUp.LineCount = 2;
            this.userControlPassUp.LineWidth = 3.5D;
            this.userControlPassUp.Location = new System.Drawing.Point(297, 40);
            this.userControlPassUp.Name = "userControlPassUp";
            this.userControlPassUp.RightPart = 15;
            this.userControlPassUp.Size = new System.Drawing.Size(290, 176);
            this.userControlPassUp.TabIndex = 22;
            this.userControlPassUp.Title = "Верхний подход";
            // 
            // groupBoxRoad
            // 
            this.groupBoxRoad.Controls.Add(this.numericUpDownRoadSpeed);
            this.groupBoxRoad.Controls.Add(this.label9);
            this.groupBoxRoad.Controls.Add(this.label6);
            this.groupBoxRoad.Controls.Add(this.numericUpDownRoadLength);
            this.groupBoxRoad.Location = new System.Drawing.Point(883, 166);
            this.groupBoxRoad.Name = "groupBoxRoad";
            this.groupBoxRoad.Size = new System.Drawing.Size(181, 161);
            this.groupBoxRoad.TabIndex = 6;
            this.groupBoxRoad.TabStop = false;
            this.groupBoxRoad.Text = "Перегон";
            // 
            // numericUpDownRoadSpeed
            // 
            this.numericUpDownRoadSpeed.Location = new System.Drawing.Point(11, 95);
            this.numericUpDownRoadSpeed.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.numericUpDownRoadSpeed.Minimum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numericUpDownRoadSpeed.Name = "numericUpDownRoadSpeed";
            this.numericUpDownRoadSpeed.Size = new System.Drawing.Size(128, 22);
            this.numericUpDownRoadSpeed.TabIndex = 8;
            this.numericUpDownRoadSpeed.Value = new decimal(new int[] {
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Длина, м";
            // 
            // numericUpDownRoadLength
            // 
            this.numericUpDownRoadLength.Location = new System.Drawing.Point(11, 40);
            this.numericUpDownRoadLength.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownRoadLength.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownRoadLength.Name = "numericUpDownRoadLength";
            this.numericUpDownRoadLength.Size = new System.Drawing.Size(128, 22);
            this.numericUpDownRoadLength.TabIndex = 5;
            this.numericUpDownRoadLength.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // comboBoxCrosses
            // 
            this.comboBoxCrosses.DataSource = this.crossBindingSource;
            this.comboBoxCrosses.DisplayMember = "StreetName";
            this.comboBoxCrosses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCrosses.FormattingEnabled = true;
            this.comboBoxCrosses.Location = new System.Drawing.Point(31, 50);
            this.comboBoxCrosses.Name = "comboBoxCrosses";
            this.comboBoxCrosses.Size = new System.Drawing.Size(245, 24);
            this.comboBoxCrosses.TabIndex = 0;
            this.comboBoxCrosses.SelectedIndexChanged += new System.EventHandler(this.comboBoxCrosses_SelectedIndexChanged);
            // 
            // crossBindingSource
            // 
            this.crossBindingSource.DataSource = typeof(CoordControl.Core.Domains.Cross);
            // 
            // userControlPassLeft
            // 
            this.userControlPassLeft.DirectPart = 80;
            this.userControlPassLeft.Intensity = 300;
            this.userControlPassLeft.IsIntensityReadOnly = false;
            this.userControlPassLeft.LeftPart = 5;
            this.userControlPassLeft.LineCount = 2;
            this.userControlPassLeft.LineWidth = 3.5D;
            this.userControlPassLeft.Location = new System.Drawing.Point(8, 154);
            this.userControlPassLeft.Name = "userControlPassLeft";
            this.userControlPassLeft.RightPart = 15;
            this.userControlPassLeft.Size = new System.Drawing.Size(298, 184);
            this.userControlPassLeft.TabIndex = 21;
            this.userControlPassLeft.Title = "Левый подход";
            // 
            // textBoxStreetNameCross
            // 
            this.textBoxStreetNameCross.Location = new System.Drawing.Point(31, 106);
            this.textBoxStreetNameCross.MaxLength = 256;
            this.textBoxStreetNameCross.Name = "textBoxStreetNameCross";
            this.textBoxStreetNameCross.Size = new System.Drawing.Size(245, 22);
            this.textBoxStreetNameCross.TabIndex = 20;
            this.textBoxStreetNameCross.TextChanged += new System.EventHandler(this.textBoxStreetNameCross_TextChanged);
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
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonSave.Location = new System.Drawing.Point(945, 601);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(141, 30);
            this.buttonSave.TabIndex = 8;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(798, 601);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(141, 30);
            this.buttonCancel.TabIndex = 9;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.textBoxStreetNameMagistral);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.numericUpDownCrossCount);
            this.groupBox4.Location = new System.Drawing.Point(12, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(351, 140);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Магистраль";
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // FormRoute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 639);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormRoute";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Магистраль";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCrossCount)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxRoad.ResumeLayout(false);
            this.groupBoxRoad.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRoadSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRoadLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crossBindingSource)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxStreetNameMagistral;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownCrossCount;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxCrosses;
        private System.Windows.Forms.GroupBox groupBoxRoad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDownRoadLength;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxStreetNameCross;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private CoordControl.Forms.Controls.UserControlPass userControlPassLeft;
        private CoordControl.Forms.Controls.UserControlPass userControlPassRight;
        private CoordControl.Forms.Controls.UserControlPass userControlPassDown;
        private CoordControl.Forms.Controls.UserControlPass userControlPassUp;
        private System.Windows.Forms.NumericUpDown numericUpDownRoadSpeed;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.BindingSource crossBindingSource;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}