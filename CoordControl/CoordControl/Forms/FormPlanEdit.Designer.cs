namespace CoordControl.Forms
{
    partial class FormPlanEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPlanEdit));
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxCrosses = new System.Windows.Forms.ComboBox();
            this.crossBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDownOffset = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.numericUpDownP2MidInterval = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownP2MainInterval = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numericUpDownP1MidInterval = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownP1MainInterval = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownCycle = new System.Windows.Forms.NumericUpDown();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxPlanName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.crossBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOffset)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownP2MidInterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownP2MainInterval)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownP1MidInterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownP1MainInterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCycle)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(321, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Цикл регулирования, сек";
            // 
            // comboBoxCrosses
            // 
            this.comboBoxCrosses.DataSource = this.crossBindingSource;
            this.comboBoxCrosses.DisplayMember = "StreetName";
            this.comboBoxCrosses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCrosses.FormattingEnabled = true;
            this.comboBoxCrosses.Location = new System.Drawing.Point(11, 24);
            this.comboBoxCrosses.Name = "comboBoxCrosses";
            this.comboBoxCrosses.Size = new System.Drawing.Size(275, 26);
            this.comboBoxCrosses.TabIndex = 20;
            this.comboBoxCrosses.ValueMember = "ID";
            this.comboBoxCrosses.SelectedIndexChanged += new System.EventHandler(this.comboBoxCrosses_SelectedIndexChanged);
            // 
            // crossBindingSource
            // 
            this.crossBindingSource.DataSource = typeof(CoordControl.Core.Domains.Cross);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.numericUpDownOffset);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.comboBoxCrosses);
            this.groupBox1.Location = new System.Drawing.Point(17, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(594, 256);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Перекресток";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(303, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 18);
            this.label6.TabIndex = 24;
            this.label6.Text = "Сдвиг фаз";
            // 
            // numericUpDownOffset
            // 
            this.numericUpDownOffset.Location = new System.Drawing.Point(392, 26);
            this.numericUpDownOffset.Maximum = new decimal(new int[] {
            70,
            0,
            0,
            0});
            this.numericUpDownOffset.Name = "numericUpDownOffset";
            this.numericUpDownOffset.Size = new System.Drawing.Size(135, 24);
            this.numericUpDownOffset.TabIndex = 23;
            this.numericUpDownOffset.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.numericUpDownP2MidInterval);
            this.groupBox3.Controls.Add(this.numericUpDownP2MainInterval);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(292, 64);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(278, 180);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Фаза 2 (разрешение пересекающей улицы)";
            // 
            // numericUpDownP2MidInterval
            // 
            this.numericUpDownP2MidInterval.Location = new System.Drawing.Point(10, 137);
            this.numericUpDownP2MidInterval.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numericUpDownP2MidInterval.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDownP2MidInterval.Name = "numericUpDownP2MidInterval";
            this.numericUpDownP2MidInterval.Size = new System.Drawing.Size(91, 24);
            this.numericUpDownP2MidInterval.TabIndex = 7;
            this.numericUpDownP2MidInterval.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDownP2MidInterval.ValueChanged += new System.EventHandler(this.numericUpDownP2MidInterval_ValueChanged);
            // 
            // numericUpDownP2MainInterval
            // 
            this.numericUpDownP2MainInterval.Location = new System.Drawing.Point(14, 80);
            this.numericUpDownP2MainInterval.Maximum = new decimal(new int[] {
            64,
            0,
            0,
            0});
            this.numericUpDownP2MainInterval.Minimum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.numericUpDownP2MainInterval.Name = "numericUpDownP2MainInterval";
            this.numericUpDownP2MainInterval.Size = new System.Drawing.Size(88, 24);
            this.numericUpDownP2MainInterval.TabIndex = 6;
            this.numericUpDownP2MainInterval.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.numericUpDownP2MainInterval.ValueChanged += new System.EventHandler(this.numericUpDownP2MainInterval_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Промежуточный такт, сек";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Основной такт, сек";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numericUpDownP1MidInterval);
            this.groupBox2.Controls.Add(this.numericUpDownP1MainInterval);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 64);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(274, 180);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Фаза 1 (разрешение магистральной улицы)";
            // 
            // numericUpDownP1MidInterval
            // 
            this.numericUpDownP1MidInterval.Location = new System.Drawing.Point(11, 137);
            this.numericUpDownP1MidInterval.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numericUpDownP1MidInterval.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDownP1MidInterval.Name = "numericUpDownP1MidInterval";
            this.numericUpDownP1MidInterval.Size = new System.Drawing.Size(91, 24);
            this.numericUpDownP1MidInterval.TabIndex = 3;
            this.numericUpDownP1MidInterval.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDownP1MidInterval.ValueChanged += new System.EventHandler(this.numericUpDownP1MidInterval_ValueChanged);
            // 
            // numericUpDownP1MainInterval
            // 
            this.numericUpDownP1MainInterval.Location = new System.Drawing.Point(15, 80);
            this.numericUpDownP1MainInterval.Maximum = new decimal(new int[] {
            64,
            0,
            0,
            0});
            this.numericUpDownP1MainInterval.Minimum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.numericUpDownP1MainInterval.Name = "numericUpDownP1MainInterval";
            this.numericUpDownP1MainInterval.Size = new System.Drawing.Size(88, 24);
            this.numericUpDownP1MainInterval.TabIndex = 2;
            this.numericUpDownP1MainInterval.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.numericUpDownP1MainInterval.ValueChanged += new System.EventHandler(this.numericUpDownP1MainInterval_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Промежуточный такт, сек";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Основной такт, сек";
            // 
            // numericUpDownCycle
            // 
            this.numericUpDownCycle.Location = new System.Drawing.Point(327, 38);
            this.numericUpDownCycle.Maximum = new decimal(new int[] {
            70,
            0,
            0,
            0});
            this.numericUpDownCycle.Minimum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numericUpDownCycle.Name = "numericUpDownCycle";
            this.numericUpDownCycle.Size = new System.Drawing.Size(179, 24);
            this.numericUpDownCycle.TabIndex = 23;
            this.numericUpDownCycle.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numericUpDownCycle.ValueChanged += new System.EventHandler(this.numericUpDownCycle_ValueChanged);
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonSave.Location = new System.Drawing.Point(362, 339);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(118, 34);
            this.buttonSave.TabIndex = 24;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(486, 339);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(118, 34);
            this.buttonCancel.TabIndex = 25;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 18);
            this.label7.TabIndex = 26;
            this.label7.Text = "Название";
            // 
            // textBoxPlanName
            // 
            this.textBoxPlanName.Location = new System.Drawing.Point(27, 38);
            this.textBoxPlanName.MaxLength = 256;
            this.textBoxPlanName.Name = "textBoxPlanName";
            this.textBoxPlanName.Size = new System.Drawing.Size(273, 24);
            this.textBoxPlanName.TabIndex = 27;
            // 
            // FormPlanEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 385);
            this.Controls.Add(this.textBoxPlanName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.numericUpDownCycle);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPlanEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Программа координации";
            ((System.ComponentModel.ISupportInitialize)(this.crossBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOffset)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownP2MidInterval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownP2MainInterval)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownP1MidInterval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownP1MainInterval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCycle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxCrosses;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown numericUpDownP2MidInterval;
        private System.Windows.Forms.NumericUpDown numericUpDownP2MainInterval;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown numericUpDownP1MidInterval;
        private System.Windows.Forms.NumericUpDown numericUpDownP1MainInterval;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownCycle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDownOffset;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxPlanName;
        private System.Windows.Forms.BindingSource crossBindingSource;
    }
}