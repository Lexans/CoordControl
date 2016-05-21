namespace CoordControl.Forms
{
    partial class FormRegionProp
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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Транспортный поток (ТП)", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Участок", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("Элемент дорожной сети", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "Часть ТП",
            "0 авт"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "Скорость",
            "0 км/ч"}, -1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "Интенивность",
            "0 авт/ч"}, -1);
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            "Плотность",
            "0 авт/м"}, -1);
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem(new string[] {
            "Номер участка",
            "1 из 10"}, -1);
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem(new string[] {
            "Длина участка",
            "0 м"}, -1);
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem(new string[] {
            "Ширина участка",
            "0 м"}, -1);
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem(new string[] {
            "Тип",
            "перегон"}, -1);
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem(new string[] {
            "Движение",
            "прямо"}, -1);
            System.Windows.Forms.ListViewItem listViewItem10 = new System.Windows.Forms.ListViewItem(new string[] {
            "Число полос",
            "2"}, -1);
            System.Windows.Forms.ListViewItem listViewItem11 = new System.Windows.Forms.ListViewItem(new string[] {
            "Длина",
            "300 м"}, -1);
            System.Windows.Forms.ListViewItem listViewItem12 = new System.Windows.Forms.ListViewItem(new string[] {
            "Левый перекресток",
            "улица левая"}, -1);
            System.Windows.Forms.ListViewItem listViewItem13 = new System.Windows.Forms.ListViewItem(new string[] {
            "Правый перекресток",
            "улица правая"}, -1);
            this.listViewProp = new CoordControl.Forms.Controls.UserControlListView();
            this.columnHeaderParamName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listViewProp
            // 
            this.listViewProp.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderParamName,
            this.columnHeaderValue});
            this.listViewProp.Dock = System.Windows.Forms.DockStyle.Fill;
            listViewGroup1.Header = "Транспортный поток (ТП)";
            listViewGroup1.Name = "listViewGroupCarFlow";
            listViewGroup2.Header = "Участок";
            listViewGroup2.Name = "listViewGroupWay";
            listViewGroup3.Header = "Элемент дорожной сети";
            listViewGroup3.Name = "listViewGroupElem";
            this.listViewProp.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2,
            listViewGroup3});
            listViewItem1.Group = listViewGroup1;
            listViewItem2.Group = listViewGroup1;
            listViewItem3.Group = listViewGroup1;
            listViewItem4.Group = listViewGroup1;
            listViewItem5.Group = listViewGroup2;
            listViewItem6.Group = listViewGroup2;
            listViewItem7.Group = listViewGroup2;
            listViewItem8.Group = listViewGroup3;
            listViewItem9.Group = listViewGroup3;
            listViewItem10.Group = listViewGroup3;
            listViewItem11.Group = listViewGroup3;
            listViewItem12.Group = listViewGroup3;
            listViewItem13.Group = listViewGroup3;
            this.listViewProp.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6,
            listViewItem7,
            listViewItem8,
            listViewItem9,
            listViewItem10,
            listViewItem11,
            listViewItem12,
            listViewItem13});
            this.listViewProp.Location = new System.Drawing.Point(0, 0);
            this.listViewProp.Name = "listViewProp";
            this.listViewProp.Size = new System.Drawing.Size(292, 454);
            this.listViewProp.TabIndex = 1;
            this.listViewProp.UseCompatibleStateImageBehavior = false;
            this.listViewProp.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderParamName
            // 
            this.columnHeaderParamName.Text = "Параметр";
            this.columnHeaderParamName.Width = 121;
            // 
            // columnHeaderValue
            // 
            this.columnHeaderValue.Text = "Значение";
            this.columnHeaderValue.Width = 119;
            // 
            // FormRegionProp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 454);
            this.Controls.Add(this.listViewProp);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MinimizeBox = false;
            this.Name = "FormRegionProp";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Параметры модели";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormRegionProp_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.UserControlListView listViewProp;
        private System.Windows.Forms.ColumnHeader columnHeaderParamName;
        private System.Windows.Forms.ColumnHeader columnHeaderValue;
    }
}