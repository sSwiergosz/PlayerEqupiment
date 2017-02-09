namespace PlayerEq
{
    partial class Form2
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
            this.readButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.eCharacterButton = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.saveButton = new System.Windows.Forms.Button();
            this.dCharacterButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cCharDescriptBox = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.createCharButton = new System.Windows.Forms.Button();
            this.cCharLevelBox = new System.Windows.Forms.TextBox();
            this.cCharStrengthBox = new System.Windows.Forms.TextBox();
            this.cCharDefenceBox = new System.Windows.Forms.TextBox();
            this.cCharMagicBox = new System.Windows.Forms.TextBox();
            this.cCharCapacityBox = new System.Windows.Forms.TextBox();
            this.cCharNameBox = new System.Windows.Forms.TextBox();
            this.cCharClassBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // readButton
            // 
            this.readButton.Location = new System.Drawing.Point(235, 271);
            this.readButton.Name = "readButton";
            this.readButton.Size = new System.Drawing.Size(81, 50);
            this.readButton.TabIndex = 8;
            this.readButton.Text = "Read from file";
            this.readButton.UseVisualStyleBackColor = true;
            this.readButton.Click += new System.EventHandler(this.readButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // eCharacterButton
            // 
            this.eCharacterButton.Location = new System.Drawing.Point(235, 102);
            this.eCharacterButton.Name = "eCharacterButton";
            this.eCharacterButton.Size = new System.Drawing.Size(169, 50);
            this.eCharacterButton.TabIndex = 41;
            this.eCharacterButton.Text = "Edit character";
            this.eCharacterButton.UseVisualStyleBackColor = true;
            this.eCharacterButton.Click += new System.EventHandler(this.eCharacterButton_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(323, 271);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(81, 50);
            this.saveButton.TabIndex = 52;
            this.saveButton.Text = "Save to file";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // dCharacterButton
            // 
            this.dCharacterButton.Location = new System.Drawing.Point(235, 168);
            this.dCharacterButton.Name = "dCharacterButton";
            this.dCharacterButton.Size = new System.Drawing.Size(169, 50);
            this.dCharacterButton.TabIndex = 55;
            this.dCharacterButton.Text = "Delete character";
            this.dCharacterButton.UseVisualStyleBackColor = true;
            this.dCharacterButton.Click += new System.EventHandler(this.dCharacterButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 73;
            this.label1.Text = "Creating/Editing";
            // 
            // cCharDescriptBox
            // 
            this.cCharDescriptBox.Location = new System.Drawing.Point(34, 241);
            this.cCharDescriptBox.Name = "cCharDescriptBox";
            this.cCharDescriptBox.Size = new System.Drawing.Size(169, 80);
            this.cCharDescriptBox.TabIndex = 72;
            this.cCharDescriptBox.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 71;
            this.label2.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 70;
            this.label3.Text = "Class";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 69;
            this.label4.Text = "Capacity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 68;
            this.label5.Text = "Magic";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 67;
            this.label6.Text = "Defence";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 66;
            this.label7.Text = "Strength";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 65;
            this.label8.Text = "Level";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(31, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 64;
            this.label9.Text = "Name";
            // 
            // createCharButton
            // 
            this.createCharButton.Location = new System.Drawing.Point(235, 40);
            this.createCharButton.Name = "createCharButton";
            this.createCharButton.Size = new System.Drawing.Size(169, 50);
            this.createCharButton.TabIndex = 63;
            this.createCharButton.Text = "Create character";
            this.createCharButton.UseVisualStyleBackColor = true;
            this.createCharButton.Click += new System.EventHandler(this.createCharButton_Click);
            // 
            // cCharLevelBox
            // 
            this.cCharLevelBox.Location = new System.Drawing.Point(103, 66);
            this.cCharLevelBox.Name = "cCharLevelBox";
            this.cCharLevelBox.Size = new System.Drawing.Size(100, 20);
            this.cCharLevelBox.TabIndex = 62;
            // 
            // cCharStrengthBox
            // 
            this.cCharStrengthBox.Location = new System.Drawing.Point(103, 92);
            this.cCharStrengthBox.Name = "cCharStrengthBox";
            this.cCharStrengthBox.Size = new System.Drawing.Size(100, 20);
            this.cCharStrengthBox.TabIndex = 61;
            // 
            // cCharDefenceBox
            // 
            this.cCharDefenceBox.Location = new System.Drawing.Point(103, 118);
            this.cCharDefenceBox.Name = "cCharDefenceBox";
            this.cCharDefenceBox.Size = new System.Drawing.Size(100, 20);
            this.cCharDefenceBox.TabIndex = 60;
            // 
            // cCharMagicBox
            // 
            this.cCharMagicBox.Location = new System.Drawing.Point(103, 144);
            this.cCharMagicBox.Name = "cCharMagicBox";
            this.cCharMagicBox.Size = new System.Drawing.Size(100, 20);
            this.cCharMagicBox.TabIndex = 59;
            // 
            // cCharCapacityBox
            // 
            this.cCharCapacityBox.Location = new System.Drawing.Point(103, 170);
            this.cCharCapacityBox.Name = "cCharCapacityBox";
            this.cCharCapacityBox.Size = new System.Drawing.Size(100, 20);
            this.cCharCapacityBox.TabIndex = 58;
            // 
            // cCharNameBox
            // 
            this.cCharNameBox.Location = new System.Drawing.Point(103, 40);
            this.cCharNameBox.Name = "cCharNameBox";
            this.cCharNameBox.Size = new System.Drawing.Size(100, 20);
            this.cCharNameBox.TabIndex = 56;
            // 
            // cCharClassBox
            // 
            this.cCharClassBox.FormattingEnabled = true;
            this.cCharClassBox.Location = new System.Drawing.Point(103, 197);
            this.cCharClassBox.Name = "cCharClassBox";
            this.cCharClassBox.Size = new System.Drawing.Size(100, 21);
            this.cCharClassBox.TabIndex = 74;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 400);
            this.Controls.Add(this.cCharClassBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cCharDescriptBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.createCharButton);
            this.Controls.Add(this.cCharLevelBox);
            this.Controls.Add(this.cCharStrengthBox);
            this.Controls.Add(this.cCharDefenceBox);
            this.Controls.Add(this.cCharMagicBox);
            this.Controls.Add(this.cCharCapacityBox);
            this.Controls.Add(this.cCharNameBox);
            this.Controls.Add(this.dCharacterButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.eCharacterButton);
            this.Controls.Add(this.readButton);
            this.Name = "Form2";
            this.Text = "      ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button readButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button eCharacterButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button dCharacterButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button createCharButton;
        public System.Windows.Forms.ComboBox cCharClassBox;
        public System.Windows.Forms.TextBox cCharStrengthBox;
        public System.Windows.Forms.TextBox cCharDefenceBox;
        public System.Windows.Forms.TextBox cCharMagicBox;
        public System.Windows.Forms.TextBox cCharCapacityBox;
        public System.Windows.Forms.TextBox cCharLevelBox;
        public System.Windows.Forms.TextBox cCharNameBox;
        public System.Windows.Forms.RichTextBox cCharDescriptBox;
    }
}