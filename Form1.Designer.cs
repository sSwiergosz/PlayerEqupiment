﻿namespace PlayerEq
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.charactersWindowButton = new System.Windows.Forms.Button();
            this.characterBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.descriptionBox = new System.Windows.Forms.RichTextBox();
            this.readCharItemsButton = new System.Windows.Forms.Button();
            this.saveCharItemsButton = new System.Windows.Forms.Button();
            this.usingItems = new System.Windows.Forms.ListBox();
            this.itemsWindowOpen = new System.Windows.Forms.Button();
            this.capacityBoxMax = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.classBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.capacityBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.magicBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.defenceBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.strengthBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.levelBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.addItem = new System.Windows.Forms.Button();
            this.addingItemBox = new System.Windows.Forms.ComboBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // charactersWindowButton
            // 
            this.charactersWindowButton.Location = new System.Drawing.Point(234, 191);
            this.charactersWindowButton.Name = "charactersWindowButton";
            this.charactersWindowButton.Size = new System.Drawing.Size(162, 52);
            this.charactersWindowButton.TabIndex = 15;
            this.charactersWindowButton.Text = "Characters window";
            this.charactersWindowButton.UseVisualStyleBackColor = true;
            this.charactersWindowButton.Click += new System.EventHandler(this.CharacterWindowOpen);
            // 
            // characterBox
            // 
            this.characterBox.FormattingEnabled = true;
            this.characterBox.Location = new System.Drawing.Point(69, 6);
            this.characterBox.Name = "characterBox";
            this.characterBox.Size = new System.Drawing.Size(501, 21);
            this.characterBox.TabIndex = 1;
            this.characterBox.SelectedIndexChanged += new System.EventHandler(this.CharacterChoice);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Character";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(1, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(594, 355);
            this.tabControl1.TabIndex = 16;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.descriptionBox);
            this.tabPage1.Controls.Add(this.readCharItemsButton);
            this.tabPage1.Controls.Add(this.saveCharItemsButton);
            this.tabPage1.Controls.Add(this.usingItems);
            this.tabPage1.Controls.Add(this.itemsWindowOpen);
            this.tabPage1.Controls.Add(this.capacityBoxMax);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.classBox);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.capacityBox);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.magicBox);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.defenceBox);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.strengthBox);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.levelBox);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.nameBox);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.characterBox);
            this.tabPage1.Controls.Add(this.charactersWindowButton);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(586, 329);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(231, 45);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "List of items";
            // 
            // descriptionBox
            // 
            this.descriptionBox.Location = new System.Drawing.Point(14, 249);
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.ReadOnly = true;
            this.descriptionBox.Size = new System.Drawing.Size(197, 61);
            this.descriptionBox.TabIndex = 10;
            this.descriptionBox.Text = "";
            // 
            // readCharItemsButton
            // 
            this.readCharItemsButton.Location = new System.Drawing.Point(408, 258);
            this.readCharItemsButton.Name = "readCharItemsButton";
            this.readCharItemsButton.Size = new System.Drawing.Size(162, 52);
            this.readCharItemsButton.TabIndex = 13;
            this.readCharItemsButton.Text = "Read character with items";
            this.readCharItemsButton.UseVisualStyleBackColor = true;
            this.readCharItemsButton.Click += new System.EventHandler(this.readCharItemsButton_Click);
            // 
            // saveCharItemsButton
            // 
            this.saveCharItemsButton.Location = new System.Drawing.Point(234, 258);
            this.saveCharItemsButton.Name = "saveCharItemsButton";
            this.saveCharItemsButton.Size = new System.Drawing.Size(162, 52);
            this.saveCharItemsButton.TabIndex = 12;
            this.saveCharItemsButton.Text = "Save character with items";
            this.saveCharItemsButton.UseVisualStyleBackColor = true;
            this.saveCharItemsButton.Click += new System.EventHandler(this.saveCharItemsButton_Click);
            // 
            // usingItems
            // 
            this.usingItems.FormattingEnabled = true;
            this.usingItems.Location = new System.Drawing.Point(234, 70);
            this.usingItems.Name = "usingItems";
            this.usingItems.Size = new System.Drawing.Size(336, 95);
            this.usingItems.TabIndex = 11;
            // 
            // itemsWindowOpen
            // 
            this.itemsWindowOpen.Location = new System.Drawing.Point(408, 191);
            this.itemsWindowOpen.Name = "itemsWindowOpen";
            this.itemsWindowOpen.Size = new System.Drawing.Size(162, 52);
            this.itemsWindowOpen.TabIndex = 14;
            this.itemsWindowOpen.Text = "Items window";
            this.itemsWindowOpen.UseVisualStyleBackColor = true;
            this.itemsWindowOpen.Click += new System.EventHandler(this.itemsWindowOpen_Click);
            // 
            // capacityBoxMax
            // 
            this.capacityBoxMax.Location = new System.Drawing.Point(126, 175);
            this.capacityBoxMax.Name = "capacityBoxMax";
            this.capacityBoxMax.ReadOnly = true;
            this.capacityBoxMax.Size = new System.Drawing.Size(85, 20);
            this.capacityBoxMax.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 230);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Description";
            // 
            // classBox
            // 
            this.classBox.Location = new System.Drawing.Point(69, 201);
            this.classBox.Name = "classBox";
            this.classBox.ReadOnly = true;
            this.classBox.Size = new System.Drawing.Size(142, 20);
            this.classBox.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 204);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Class";
            // 
            // capacityBox
            // 
            this.capacityBox.Location = new System.Drawing.Point(69, 175);
            this.capacityBox.Name = "capacityBox";
            this.capacityBox.ReadOnly = true;
            this.capacityBox.Size = new System.Drawing.Size(38, 20);
            this.capacityBox.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Capacity";
            // 
            // magicBox
            // 
            this.magicBox.Location = new System.Drawing.Point(69, 149);
            this.magicBox.Name = "magicBox";
            this.magicBox.ReadOnly = true;
            this.magicBox.Size = new System.Drawing.Size(142, 20);
            this.magicBox.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Magic";
            // 
            // defenceBox
            // 
            this.defenceBox.Location = new System.Drawing.Point(69, 123);
            this.defenceBox.Name = "defenceBox";
            this.defenceBox.ReadOnly = true;
            this.defenceBox.Size = new System.Drawing.Size(142, 20);
            this.defenceBox.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Defence";
            // 
            // strengthBox
            // 
            this.strengthBox.Location = new System.Drawing.Point(69, 97);
            this.strengthBox.Name = "strengthBox";
            this.strengthBox.ReadOnly = true;
            this.strengthBox.Size = new System.Drawing.Size(142, 20);
            this.strengthBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Strength";
            // 
            // levelBox
            // 
            this.levelBox.Location = new System.Drawing.Point(69, 71);
            this.levelBox.Name = "levelBox";
            this.levelBox.ReadOnly = true;
            this.levelBox.Size = new System.Drawing.Size(142, 20);
            this.levelBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Level";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(69, 45);
            this.nameBox.Name = "nameBox";
            this.nameBox.ReadOnly = true;
            this.nameBox.Size = new System.Drawing.Size(142, 20);
            this.nameBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Name";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.chart1);
            this.tabPage2.Controls.Add(this.addItem);
            this.tabPage2.Controls.Add(this.addingItemBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(586, 329);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(120, 35);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Before";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "After";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(393, 280);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            // 
            // addItem
            // 
            this.addItem.Location = new System.Drawing.Point(343, 6);
            this.addItem.Name = "addItem";
            this.addItem.Size = new System.Drawing.Size(75, 23);
            this.addItem.TabIndex = 1;
            this.addItem.Text = "Add item";
            this.addItem.UseVisualStyleBackColor = true;
            this.addItem.Click += new System.EventHandler(this.addItem_Click);
            // 
            // addingItemBox
            // 
            this.addingItemBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.addingItemBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.addingItemBox.FormattingEnabled = true;
            this.addingItemBox.Location = new System.Drawing.Point(7, 6);
            this.addingItemBox.Name = "addingItemBox";
            this.addingItemBox.Size = new System.Drawing.Size(321, 21);
            this.addingItemBox.TabIndex = 0;
            this.addingItemBox.SelectedIndexChanged += new System.EventHandler(this.SelectItem);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 346);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button charactersWindowButton;
        public System.Windows.Forms.ComboBox characterBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox levelBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox classBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox capacityBoxMax;
        public System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Button itemsWindowOpen;
        public System.Windows.Forms.ListBox usingItems;
        public System.Windows.Forms.ComboBox addingItemBox;
        private System.Windows.Forms.Button addItem;
        public System.Windows.Forms.TextBox capacityBox;
        private System.Windows.Forms.Button readCharItemsButton;
        private System.Windows.Forms.Button saveCharItemsButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        public System.Windows.Forms.TextBox strengthBox;
        public System.Windows.Forms.TextBox magicBox;
        public System.Windows.Forms.TextBox defenceBox;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        public System.Windows.Forms.RichTextBox descriptionBox;
        private System.Windows.Forms.Label label10;
    }
}

