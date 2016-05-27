﻿namespace CoordControl.Forms
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
            System.Windows.Forms.ListViewGroup listViewGroup4 = new System.Windows.Forms.ListViewGroup("Транспортный поток (ТП)", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup5 = new System.Windows.Forms.ListViewGroup("Участок", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup6 = new System.Windows.Forms.ListViewGroup("Элемент дорожной сети", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewItem listViewItem14 = new System.Windows.Forms.ListViewItem(new string[] {
            "Часть ТП",
            "0 авт"}, -1);
            System.Windows.Forms.ListViewItem listViewItem15 = new System.Windows.Forms.ListViewItem(new string[] {
            "Скорость",
            "0 км/ч"}, -1);
            System.Windows.Forms.ListViewItem listViewItem16 = new System.Windows.Forms.ListViewItem(new string[] {
            "Интенивность",
            "0 авт/ч"}, -1);
            System.Windows.Forms.ListViewItem listViewItem17 = new System.Windows.Forms.ListViewItem(new string[] {
            "Плотность",
            "0 авт/м"}, -1);
            System.Windows.Forms.ListViewItem listViewItem18 = new System.Windows.Forms.ListViewItem(new string[] {
            "Номер участка",
            "1 из 10"}, -1);
            System.Windows.Forms.ListViewItem listViewItem19 = new System.Windows.Forms.ListViewItem(new string[] {
            "Длина участка",
            "0 м"}, -1);
            System.Windows.Forms.ListViewItem listViewItem20 = new System.Windows.Forms.ListViewItem(new string[] {
            "Ширина участка",
            "0 м"}, -1);
            System.Windows.Forms.ListViewItem listViewItem21 = new System.Windows.Forms.ListViewItem(new string[] {
            "Тип",
            "перегон"}, -1);
            System.Windows.Forms.ListViewItem listViewItem22 = new System.Windows.Forms.ListViewItem(new string[] {
            "Движение",
            "прямо"}, -1);
            System.Windows.Forms.ListViewItem listViewItem23 = new System.Windows.Forms.ListViewItem(new string[] {
            "Число полос",
            "2"}, -1);
            System.Windows.Forms.ListViewItem listViewItem24 = new System.Windows.Forms.ListViewItem(new string[] {
            "Длина",
            "300 м"}, -1);
            System.Windows.Forms.ListViewItem listViewItem25 = new System.Windows.Forms.ListViewItem(new string[] {
            "Левый перекресток",
            "улица левая"}, -1);
            System.Windows.Forms.ListViewItem listViewItem26 = new System.Windows.Forms.ListViewItem(new string[] {
            "Правый перекресток",
            "улица правая"}, -1);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegionProp));
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
            listViewGroup4.Header = "Транспортный поток (ТП)";
            listViewGroup4.Name = "listViewGroupCarFlow";
            listViewGroup5.Header = "Участок";
            listViewGroup5.Name = "listViewGroupWay";
            listViewGroup6.Header = "Элемент дорожной сети";
            listViewGroup6.Name = "listViewGroupElem";
            this.listViewProp.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup4,
            listViewGroup5,
            listViewGroup6});
            listViewItem14.Group = listViewGroup4;
            listViewItem15.Group = listViewGroup4;
            listViewItem16.Group = listViewGroup4;
            listViewItem17.Group = listViewGroup4;
            listViewItem18.Group = listViewGroup5;
            listViewItem19.Group = listViewGroup5;
            listViewItem20.Group = listViewGroup5;
            listViewItem21.Group = listViewGroup6;
            listViewItem22.Group = listViewGroup6;
            listViewItem23.Group = listViewGroup6;
            listViewItem24.Group = listViewGroup6;
            listViewItem25.Group = listViewGroup6;
            listViewItem26.Group = listViewGroup6;
            this.listViewProp.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem14,
            listViewItem15,
            listViewItem16,
            listViewItem17,
            listViewItem18,
            listViewItem19,
            listViewItem20,
            listViewItem21,
            listViewItem22,
            listViewItem23,
            listViewItem24,
            listViewItem25,
            listViewItem26});
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "FormRegionProp";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Параметры";
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