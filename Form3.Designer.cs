﻿namespace PlayerEq
{
    partial class Form3
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
            this.eItemNameBox = new System.Windows.Forms.TextBox();
            this.eItemBonusBox = new System.Windows.Forms.TextBox();
            this.eItemPropBox = new System.Windows.Forms.TextBox();
            this.eItemWeightBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.readItemButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label10 = new System.Windows.Forms.Label();
            this.eItemDescBox = new System.Windows.Forms.RichTextBox();
            this.editItemButton = new System.Windows.Forms.Button();
            this.selectedItemComboBox = new System.Windows.Forms.ComboBox();
            this.saveItemButton = new System.Windows.Forms.Button();
            this.dItemButton = new System.Windows.Forms.Button();
            this.createItemButton = new System.Windows.Forms.Button();
            this.itemReqBox = new System.Windows.Forms.ComboBox();
            this.itemTypeBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // eItemNameBox
            // 
            this.eItemNameBox.Location = new System.Drawing.Point(100, 49);
            this.eItemNameBox.Name = "eItemNameBox";
            this.eItemNameBox.Size = new System.Drawing.Size(100, 20);
            this.eItemNameBox.TabIndex = 69;
            // 
            // eItemBonusBox
            // 
            this.eItemBonusBox.Location = new System.Drawing.Point(100, 127);
            this.eItemBonusBox.Name = "eItemBonusBox";
            this.eItemBonusBox.Size = new System.Drawing.Size(100, 20);
            this.eItemBonusBox.TabIndex = 72;
            // 
            // eItemPropBox
            // 
            this.eItemPropBox.Location = new System.Drawing.Point(100, 153);
            this.eItemPropBox.Name = "eItemPropBox";
            this.eItemPropBox.Size = new System.Drawing.Size(100, 20);
            this.eItemPropBox.TabIndex = 73;
            // 
            // eItemWeightBox
            // 
            this.eItemWeightBox.Location = new System.Drawing.Point(100, 179);
            this.eItemWeightBox.Name = "eItemWeightBox";
            this.eItemWeightBox.Size = new System.Drawing.Size(100, 20);
            this.eItemWeightBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Requirements";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Bonus";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Properties";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Weight";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 208);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Description";
            // 
            // readItemButton
            // 
            this.readItemButton.Location = new System.Drawing.Point(257, 97);
            this.readItemButton.Name = "readItemButton";
            this.readItemButton.Size = new System.Drawing.Size(75, 44);
            this.readItemButton.TabIndex = 14;
            this.readItemButton.Text = "Read from file";
            this.readItemButton.UseVisualStyleBackColor = true;
            this.readItemButton.Click += new System.EventHandler(this.readItemButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk_1);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 13);
            this.label10.TabIndex = 52;
            this.label10.Text = "Editing/Creating";
            // 
            // eItemDescBox
            // 
            this.eItemDescBox.Location = new System.Drawing.Point(25, 229);
            this.eItemDescBox.Name = "eItemDescBox";
            this.eItemDescBox.Size = new System.Drawing.Size(175, 80);
            this.eItemDescBox.TabIndex = 53;
            this.eItemDescBox.Text = "";
            // 
            // editItemButton
            // 
            this.editItemButton.Location = new System.Drawing.Point(257, 216);
            this.editItemButton.Name = "editItemButton";
            this.editItemButton.Size = new System.Drawing.Size(75, 44);
            this.editItemButton.TabIndex = 54;
            this.editItemButton.Text = "Edit item";
            this.editItemButton.UseVisualStyleBackColor = true;
            this.editItemButton.Click += new System.EventHandler(this.editItemButton_Click);
            // 
            // selectedItemComboBox
            // 
            this.selectedItemComboBox.FormattingEnabled = true;
            this.selectedItemComboBox.Location = new System.Drawing.Point(25, 338);
            this.selectedItemComboBox.Name = "selectedItemComboBox";
            this.selectedItemComboBox.Size = new System.Drawing.Size(307, 21);
            this.selectedItemComboBox.TabIndex = 55;
            // 
            // saveItemButton
            // 
            this.saveItemButton.Location = new System.Drawing.Point(257, 47);
            this.saveItemButton.Name = "saveItemButton";
            this.saveItemButton.Size = new System.Drawing.Size(75, 44);
            this.saveItemButton.TabIndex = 56;
            this.saveItemButton.Text = "Save to file";
            this.saveItemButton.UseVisualStyleBackColor = true;
            this.saveItemButton.Click += new System.EventHandler(this.saveItemButton_Click);
            // 
            // dItemButton
            // 
            this.dItemButton.Location = new System.Drawing.Point(257, 265);
            this.dItemButton.Name = "dItemButton";
            this.dItemButton.Size = new System.Drawing.Size(75, 44);
            this.dItemButton.TabIndex = 57;
            this.dItemButton.Text = "Delete item";
            this.dItemButton.UseVisualStyleBackColor = true;
            this.dItemButton.Click += new System.EventHandler(this.dItemButton_Click);
            // 
            // createItemButton
            // 
            this.createItemButton.Location = new System.Drawing.Point(257, 166);
            this.createItemButton.Name = "createItemButton";
            this.createItemButton.Size = new System.Drawing.Size(75, 44);
            this.createItemButton.TabIndex = 58;
            this.createItemButton.Text = "Create item";
            this.createItemButton.UseVisualStyleBackColor = true;
            this.createItemButton.Click += new System.EventHandler(this.createItemButton_Click);
            // 
            // itemReqBox
            // 
            this.itemReqBox.FormattingEnabled = true;
            this.itemReqBox.Location = new System.Drawing.Point(100, 101);
            this.itemReqBox.Name = "itemReqBox";
            this.itemReqBox.Size = new System.Drawing.Size(100, 21);
            this.itemReqBox.TabIndex = 71;
            // 
            // itemTypeBox
            // 
            this.itemTypeBox.FormattingEnabled = true;
            this.itemTypeBox.Location = new System.Drawing.Point(100, 75);
            this.itemTypeBox.Name = "itemTypeBox";
            this.itemTypeBox.Size = new System.Drawing.Size(100, 21);
            this.itemTypeBox.TabIndex = 70;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 322);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 74;
            this.label8.Text = "Selected item";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 371);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.itemTypeBox);
            this.Controls.Add(this.itemReqBox);
            this.Controls.Add(this.createItemButton);
            this.Controls.Add(this.dItemButton);
            this.Controls.Add(this.saveItemButton);
            this.Controls.Add(this.selectedItemComboBox);
            this.Controls.Add(this.editItemButton);
            this.Controls.Add(this.eItemDescBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.readItemButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.eItemWeightBox);
            this.Controls.Add(this.eItemPropBox);
            this.Controls.Add(this.eItemBonusBox);
            this.Controls.Add(this.eItemNameBox);
            this.Name = "Form3";
            this.Text = "Form3";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form3_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox eItemNameBox;
        private System.Windows.Forms.TextBox eItemBonusBox;
        private System.Windows.Forms.TextBox eItemPropBox;
        private System.Windows.Forms.TextBox eItemWeightBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button readItemButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox eItemDescBox;
        private System.Windows.Forms.Button editItemButton;
        public System.Windows.Forms.ComboBox selectedItemComboBox;
        private System.Windows.Forms.Button saveItemButton;
        private System.Windows.Forms.Button dItemButton;
        private System.Windows.Forms.Button createItemButton;
        public System.Windows.Forms.ComboBox itemReqBox;
        public System.Windows.Forms.ComboBox itemTypeBox;
        private System.Windows.Forms.Label label8;
    }
}