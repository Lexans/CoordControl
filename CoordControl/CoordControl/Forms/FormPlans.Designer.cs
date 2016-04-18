namespace CoordControl.Forms
{
    partial class FormPlans
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPlans));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.аналитическийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.имитационныйЭкспериментToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.изменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButtonView = new System.Windows.Forms.ToolStripButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridViewCoordProgs = new System.Windows.Forms.DataGridView();
            this.Cycle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonModeling = new System.Windows.Forms.Button();
            this.простойМетодToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.planBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCoordProgs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.planBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripDropDownButton2,
            this.toolStripButtonView});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(895, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.простойМетодToolStripMenuItem,
            this.аналитическийToolStripMenuItem,
            this.имитационныйЭкспериментToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(67, 24);
            this.toolStripDropDownButton1.Text = "Расчет";
            // 
            // аналитическийToolStripMenuItem
            // 
            this.аналитическийToolStripMenuItem.Name = "аналитическийToolStripMenuItem";
            this.аналитическийToolStripMenuItem.Size = new System.Drawing.Size(240, 24);
            this.аналитическийToolStripMenuItem.Text = "Аналитическая модель";
            this.аналитическийToolStripMenuItem.Click += new System.EventHandler(this.аналитическийToolStripMenuItem_Click);
            // 
            // имитационныйЭкспериментToolStripMenuItem
            // 
            this.имитационныйЭкспериментToolStripMenuItem.Name = "имитационныйЭкспериментToolStripMenuItem";
            this.имитационныйЭкспериментToolStripMenuItem.Size = new System.Drawing.Size(240, 24);
            this.имитационныйЭкспериментToolStripMenuItem.Text = "Имитационная модель";
            this.имитационныйЭкспериментToolStripMenuItem.Click += new System.EventHandler(this.имитационныйЭкспериментToolStripMenuItem_Click);
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.изменитьToolStripMenuItem,
            this.удалитьToolStripMenuItem});
            this.toolStripDropDownButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton2.Image")));
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(73, 24);
            this.toolStripDropDownButton2.Text = "Правка";
            // 
            // изменитьToolStripMenuItem
            // 
            this.изменитьToolStripMenuItem.Name = "изменитьToolStripMenuItem";
            this.изменитьToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            this.изменитьToolStripMenuItem.Text = "Изменить";
            this.изменитьToolStripMenuItem.Click += new System.EventHandler(this.изменитьToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // toolStripButtonView
            // 
            this.toolStripButtonView.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonView.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonView.Image")));
            this.toolStripButtonView.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonView.Name = "toolStripButtonView";
            this.toolStripButtonView.Size = new System.Drawing.Size(84, 24);
            this.toolStripButtonView.Text = "Просмотр";
            this.toolStripButtonView.Click += new System.EventHandler(this.toolStripButtonView_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dataGridViewCoordProgs);
            this.groupBox2.Location = new System.Drawing.Point(12, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(871, 500);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Выберите программу координации";
            // 
            // dataGridViewCoordProgs
            // 
            this.dataGridViewCoordProgs.AllowUserToAddRows = false;
            this.dataGridViewCoordProgs.AllowUserToDeleteRows = false;
            this.dataGridViewCoordProgs.AllowUserToOrderColumns = true;
            this.dataGridViewCoordProgs.AllowUserToResizeRows = false;
            this.dataGridViewCoordProgs.AutoGenerateColumns = false;
            this.dataGridViewCoordProgs.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewCoordProgs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCoordProgs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titleDataGridViewTextBoxColumn,
            this.Cycle});
            this.dataGridViewCoordProgs.DataSource = this.planBindingSource;
            this.dataGridViewCoordProgs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewCoordProgs.Location = new System.Drawing.Point(3, 18);
            this.dataGridViewCoordProgs.MultiSelect = false;
            this.dataGridViewCoordProgs.Name = "dataGridViewCoordProgs";
            this.dataGridViewCoordProgs.ReadOnly = true;
            this.dataGridViewCoordProgs.RowHeadersVisible = false;
            this.dataGridViewCoordProgs.RowTemplate.Height = 24;
            this.dataGridViewCoordProgs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCoordProgs.ShowEditingIcon = false;
            this.dataGridViewCoordProgs.Size = new System.Drawing.Size(865, 479);
            this.dataGridViewCoordProgs.TabIndex = 0;
            this.dataGridViewCoordProgs.CurrentCellChanged += new System.EventHandler(this.dataGridViewCoordProgs_CurrentCellChanged);
            // 
            // Cycle
            // 
            this.Cycle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Cycle.DataPropertyName = "Cycle";
            this.Cycle.HeaderText = "Длина цикла";
            this.Cycle.Name = "Cycle";
            this.Cycle.ReadOnly = true;
            this.Cycle.Width = 119;
            // 
            // buttonModeling
            // 
            this.buttonModeling.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonModeling.Location = new System.Drawing.Point(611, 536);
            this.buttonModeling.Name = "buttonModeling";
            this.buttonModeling.Size = new System.Drawing.Size(269, 33);
            this.buttonModeling.TabIndex = 3;
            this.buttonModeling.Text = "Имитационное моделирование";
            this.buttonModeling.UseVisualStyleBackColor = true;
            this.buttonModeling.Click += new System.EventHandler(this.buttonModeling_Click);
            // 
            // простойМетодToolStripMenuItem
            // 
            this.простойМетодToolStripMenuItem.Name = "простойМетодToolStripMenuItem";
            this.простойМетодToolStripMenuItem.Size = new System.Drawing.Size(240, 24);
            this.простойМетодToolStripMenuItem.Text = "Простой метод";
            this.простойМетодToolStripMenuItem.Click += new System.EventHandler(this.простойМетодToolStripMenuItem_Click);
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Название";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // planBindingSource
            // 
            this.planBindingSource.DataSource = typeof(CoordControl.Core.Domains.Plan);
            // 
            // FormPlans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 577);
            this.Controls.Add(this.buttonModeling);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FormPlans";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Программы координации магистрали";
            this.Load += new System.EventHandler(this.FormPlans_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCoordProgs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.planBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridViewCoordProgs;
        private System.Windows.Forms.Button buttonModeling;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem аналитическийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem имитационныйЭкспериментToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripMenuItem изменитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButtonView;
        private System.Windows.Forms.BindingSource planBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cycle;
        private System.Windows.Forms.ToolStripMenuItem простойМетодToolStripMenuItem;
    }
}