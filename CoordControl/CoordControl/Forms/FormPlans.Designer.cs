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
            this.безСдвиговToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поВремениПроездаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.безКоррекцииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сКоррекциейToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.имитационныйЭкспериментToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оптимизацияПрямогоНаправленияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обратноеНаправлениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обаНаправленияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.аналитическийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.изменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.просмотрToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridViewCoordProgs = new System.Windows.Forms.DataGridView();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cycle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.planBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonModeling = new System.Windows.Forms.Button();
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
            this.toolStripDropDownButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(752, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.безСдвиговToolStripMenuItem,
            this.поВремениПроездаToolStripMenuItem,
            this.имитационныйЭкспериментToolStripMenuItem,
            this.аналитическийToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.ShowDropDownArrow = false;
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(58, 24);
            this.toolStripDropDownButton1.Text = "Расчет";
            // 
            // безСдвиговToolStripMenuItem
            // 
            this.безСдвиговToolStripMenuItem.Name = "безСдвиговToolStripMenuItem";
            this.безСдвиговToolStripMenuItem.Size = new System.Drawing.Size(240, 24);
            this.безСдвиговToolStripMenuItem.Text = "Без сдвигов фаз";
            this.безСдвиговToolStripMenuItem.Click += new System.EventHandler(this.безСдвиговToolStripMenuItem_Click);
            // 
            // поВремениПроездаToolStripMenuItem
            // 
            this.поВремениПроездаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.безКоррекцииToolStripMenuItem,
            this.сКоррекциейToolStripMenuItem});
            this.поВремениПроездаToolStripMenuItem.Name = "поВремениПроездаToolStripMenuItem";
            this.поВремениПроездаToolStripMenuItem.Size = new System.Drawing.Size(240, 24);
            this.поВремениПроездаToolStripMenuItem.Text = "По времени проезда";
            // 
            // безКоррекцииToolStripMenuItem
            // 
            this.безКоррекцииToolStripMenuItem.Name = "безКоррекцииToolStripMenuItem";
            this.безКоррекцииToolStripMenuItem.Size = new System.Drawing.Size(182, 24);
            this.безКоррекцииToolStripMenuItem.Text = "Без коррекции";
            this.безКоррекцииToolStripMenuItem.Click += new System.EventHandler(this.безКоррекцииToolStripMenuItem_Click);
            // 
            // сКоррекциейToolStripMenuItem
            // 
            this.сКоррекциейToolStripMenuItem.Name = "сКоррекциейToolStripMenuItem";
            this.сКоррекциейToolStripMenuItem.Size = new System.Drawing.Size(182, 24);
            this.сКоррекциейToolStripMenuItem.Text = "С коррекцией";
            this.сКоррекциейToolStripMenuItem.Click += new System.EventHandler(this.сКоррекциейToolStripMenuItem_Click);
            // 
            // имитационныйЭкспериментToolStripMenuItem
            // 
            this.имитационныйЭкспериментToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оптимизацияПрямогоНаправленияToolStripMenuItem,
            this.обратноеНаправлениеToolStripMenuItem,
            this.обаНаправленияToolStripMenuItem});
            this.имитационныйЭкспериментToolStripMenuItem.Name = "имитационныйЭкспериментToolStripMenuItem";
            this.имитационныйЭкспериментToolStripMenuItem.Size = new System.Drawing.Size(240, 24);
            this.имитационныйЭкспериментToolStripMenuItem.Text = "Имитационная модель";
            // 
            // оптимизацияПрямогоНаправленияToolStripMenuItem
            // 
            this.оптимизацияПрямогоНаправленияToolStripMenuItem.Name = "оптимизацияПрямогоНаправленияToolStripMenuItem";
            this.оптимизацияПрямогоНаправленияToolStripMenuItem.Size = new System.Drawing.Size(244, 24);
            this.оптимизацияПрямогоНаправленияToolStripMenuItem.Text = "Прямое направление";
            this.оптимизацияПрямогоНаправленияToolStripMenuItem.Click += new System.EventHandler(this.оптимизацияПрямогоНаправленияToolStripMenuItem_Click);
            // 
            // обратноеНаправлениеToolStripMenuItem
            // 
            this.обратноеНаправлениеToolStripMenuItem.Name = "обратноеНаправлениеToolStripMenuItem";
            this.обратноеНаправлениеToolStripMenuItem.Size = new System.Drawing.Size(244, 24);
            this.обратноеНаправлениеToolStripMenuItem.Text = "Обратное направление";
            this.обратноеНаправлениеToolStripMenuItem.Click += new System.EventHandler(this.обратноеНаправлениеToolStripMenuItem_Click);
            // 
            // обаНаправленияToolStripMenuItem
            // 
            this.обаНаправленияToolStripMenuItem.Name = "обаНаправленияToolStripMenuItem";
            this.обаНаправленияToolStripMenuItem.Size = new System.Drawing.Size(244, 24);
            this.обаНаправленияToolStripMenuItem.Text = "Оба направления";
            this.обаНаправленияToolStripMenuItem.Click += new System.EventHandler(this.обаНаправленияToolStripMenuItem_Click);
            // 
            // аналитическийToolStripMenuItem
            // 
            this.аналитическийToolStripMenuItem.Name = "аналитическийToolStripMenuItem";
            this.аналитическийToolStripMenuItem.Size = new System.Drawing.Size(240, 24);
            this.аналитическийToolStripMenuItem.Text = "Аналитическая модель";
            this.аналитическийToolStripMenuItem.Click += new System.EventHandler(this.аналитическийToolStripMenuItem_Click);
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.изменитьToolStripMenuItem,
            this.удалитьToolStripMenuItem,
            this.просмотрToolStripMenuItem});
            this.toolStripDropDownButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton2.Image")));
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.ShowDropDownArrow = false;
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(95, 24);
            this.toolStripDropDownButton2.Text = "Программа";
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
            // просмотрToolStripMenuItem
            // 
            this.просмотрToolStripMenuItem.Name = "просмотрToolStripMenuItem";
            this.просмотрToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            this.просмотрToolStripMenuItem.Text = "Просмотр";
            this.просмотрToolStripMenuItem.Click += new System.EventHandler(this.просмотрToolStripMenuItem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dataGridViewCoordProgs);
            this.groupBox2.Location = new System.Drawing.Point(14, 34);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(725, 372);
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
            this.dataGridViewCoordProgs.Location = new System.Drawing.Point(3, 20);
            this.dataGridViewCoordProgs.MultiSelect = false;
            this.dataGridViewCoordProgs.Name = "dataGridViewCoordProgs";
            this.dataGridViewCoordProgs.ReadOnly = true;
            this.dataGridViewCoordProgs.RowHeadersVisible = false;
            this.dataGridViewCoordProgs.RowTemplate.Height = 24;
            this.dataGridViewCoordProgs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCoordProgs.ShowEditingIcon = false;
            this.dataGridViewCoordProgs.Size = new System.Drawing.Size(719, 349);
            this.dataGridViewCoordProgs.TabIndex = 0;
            this.dataGridViewCoordProgs.CurrentCellChanged += new System.EventHandler(this.dataGridViewCoordProgs_CurrentCellChanged);
            this.dataGridViewCoordProgs.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridViewCoordProgs_RowsAdded);
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Название";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Cycle
            // 
            this.Cycle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Cycle.DataPropertyName = "Cycle";
            this.Cycle.HeaderText = "Длина цикла";
            this.Cycle.Name = "Cycle";
            this.Cycle.ReadOnly = true;
            this.Cycle.Width = 123;
            // 
            // planBindingSource
            // 
            this.planBindingSource.DataSource = typeof(CoordControl.Core.Domains.Plan);
            // 
            // buttonModeling
            // 
            this.buttonModeling.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonModeling.Location = new System.Drawing.Point(432, 413);
            this.buttonModeling.Name = "buttonModeling";
            this.buttonModeling.Size = new System.Drawing.Size(303, 37);
            this.buttonModeling.TabIndex = 3;
            this.buttonModeling.Text = "Имитационное моделирование";
            this.buttonModeling.UseVisualStyleBackColor = true;
            this.buttonModeling.Click += new System.EventHandler(this.buttonModeling_Click);
            // 
            // FormPlans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 459);
            this.Controls.Add(this.buttonModeling);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(700, 500);
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
        private System.Windows.Forms.BindingSource planBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cycle;
        private System.Windows.Forms.ToolStripMenuItem поВремениПроездаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem безСдвиговToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem просмотрToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem безКоррекцииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сКоррекциейToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оптимизацияПрямогоНаправленияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обратноеНаправлениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обаНаправленияToolStripMenuItem;
    }
}