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
            this.label10 = new System.Windows.Forms.Label();
            this.eTextBoxDescription = new System.Windows.Forms.RichTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.eCharacterButton = new System.Windows.Forms.Button();
            this.eTextBoxLevel = new System.Windows.Forms.TextBox();
            this.eTextBoxStrength = new System.Windows.Forms.TextBox();
            this.eTextBoxDefence = new System.Windows.Forms.TextBox();
            this.eTextBoxMagic = new System.Windows.Forms.TextBox();
            this.eTextBoxCapacity = new System.Windows.Forms.TextBox();
            this.eTextBoxClass = new System.Windows.Forms.TextBox();
            this.eTextBoxName = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.saveButton = new System.Windows.Forms.Button();
            this.dCharacterButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // readButton
            // 
            this.readButton.Location = new System.Drawing.Point(12, 67);
            this.readButton.Name = "readButton";
            this.readButton.Size = new System.Drawing.Size(169, 50);
            this.readButton.TabIndex = 8;
            this.readButton.Text = "Read from file";
            this.readButton.UseVisualStyleBackColor = true;
            this.readButton.Click += new System.EventHandler(this.readButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(298, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 13);
            this.label10.TabIndex = 51;
            this.label10.Text = "Editing";
            // 
            // eTextBoxDescription
            // 
            this.eTextBoxDescription.Location = new System.Drawing.Point(302, 239);
            this.eTextBoxDescription.Name = "eTextBoxDescription";
            this.eTextBoxDescription.Size = new System.Drawing.Size(169, 80);
            this.eTextBoxDescription.TabIndex = 50;
            this.eTextBoxDescription.Text = "";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(299, 223);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 13);
            this.label11.TabIndex = 49;
            this.label11.Text = "Description";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(299, 197);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(32, 13);
            this.label12.TabIndex = 48;
            this.label12.Text = "Class";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(299, 171);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 13);
            this.label13.TabIndex = 47;
            this.label13.Text = "Capacity";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(299, 145);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(36, 13);
            this.label14.TabIndex = 46;
            this.label14.Text = "Magic";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(299, 119);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(48, 13);
            this.label15.TabIndex = 45;
            this.label15.Text = "Defence";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(299, 93);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(47, 13);
            this.label16.TabIndex = 44;
            this.label16.Text = "Strength";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(299, 67);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(33, 13);
            this.label17.TabIndex = 43;
            this.label17.Text = "Level";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(299, 41);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(35, 13);
            this.label18.TabIndex = 42;
            this.label18.Text = "Name";
            // 
            // eCharacterButton
            // 
            this.eCharacterButton.Location = new System.Drawing.Point(302, 325);
            this.eCharacterButton.Name = "eCharacterButton";
            this.eCharacterButton.Size = new System.Drawing.Size(169, 50);
            this.eCharacterButton.TabIndex = 41;
            this.eCharacterButton.Text = "Edit character";
            this.eCharacterButton.UseVisualStyleBackColor = true;
            this.eCharacterButton.Click += new System.EventHandler(this.eCharacterButton_Click);
            // 
            // eTextBoxLevel
            // 
            this.eTextBoxLevel.Location = new System.Drawing.Point(371, 64);
            this.eTextBoxLevel.Name = "eTextBoxLevel";
            this.eTextBoxLevel.Size = new System.Drawing.Size(100, 20);
            this.eTextBoxLevel.TabIndex = 40;
            // 
            // eTextBoxStrength
            // 
            this.eTextBoxStrength.Location = new System.Drawing.Point(371, 90);
            this.eTextBoxStrength.Name = "eTextBoxStrength";
            this.eTextBoxStrength.Size = new System.Drawing.Size(100, 20);
            this.eTextBoxStrength.TabIndex = 39;
            // 
            // eTextBoxDefence
            // 
            this.eTextBoxDefence.Location = new System.Drawing.Point(371, 116);
            this.eTextBoxDefence.Name = "eTextBoxDefence";
            this.eTextBoxDefence.Size = new System.Drawing.Size(100, 20);
            this.eTextBoxDefence.TabIndex = 38;
            // 
            // eTextBoxMagic
            // 
            this.eTextBoxMagic.Location = new System.Drawing.Point(371, 142);
            this.eTextBoxMagic.Name = "eTextBoxMagic";
            this.eTextBoxMagic.Size = new System.Drawing.Size(100, 20);
            this.eTextBoxMagic.TabIndex = 37;
            // 
            // eTextBoxCapacity
            // 
            this.eTextBoxCapacity.Location = new System.Drawing.Point(371, 168);
            this.eTextBoxCapacity.Name = "eTextBoxCapacity";
            this.eTextBoxCapacity.Size = new System.Drawing.Size(100, 20);
            this.eTextBoxCapacity.TabIndex = 36;
            // 
            // eTextBoxClass
            // 
            this.eTextBoxClass.Location = new System.Drawing.Point(371, 194);
            this.eTextBoxClass.Name = "eTextBoxClass";
            this.eTextBoxClass.Size = new System.Drawing.Size(100, 20);
            this.eTextBoxClass.TabIndex = 35;
            // 
            // eTextBoxName
            // 
            this.eTextBoxName.Location = new System.Drawing.Point(371, 38);
            this.eTextBoxName.Name = "eTextBoxName";
            this.eTextBoxName.Size = new System.Drawing.Size(100, 20);
            this.eTextBoxName.TabIndex = 34;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(587, 36);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 52;
            this.saveButton.Text = "Save to file";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // dCharacterButton
            // 
            this.dCharacterButton.Location = new System.Drawing.Point(12, 145);
            this.dCharacterButton.Name = "dCharacterButton";
            this.dCharacterButton.Size = new System.Drawing.Size(169, 50);
            this.dCharacterButton.TabIndex = 55;
            this.dCharacterButton.Text = "Delete character";
            this.dCharacterButton.UseVisualStyleBackColor = true;
            this.dCharacterButton.Click += new System.EventHandler(this.dCharacterButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 400);
            this.Controls.Add(this.dCharacterButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.eTextBoxDescription);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.eCharacterButton);
            this.Controls.Add(this.eTextBoxLevel);
            this.Controls.Add(this.eTextBoxStrength);
            this.Controls.Add(this.eTextBoxDefence);
            this.Controls.Add(this.eTextBoxMagic);
            this.Controls.Add(this.eTextBoxCapacity);
            this.Controls.Add(this.eTextBoxClass);
            this.Controls.Add(this.eTextBoxName);
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
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox eTextBoxDescription;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button eCharacterButton;
        private System.Windows.Forms.TextBox eTextBoxLevel;
        private System.Windows.Forms.TextBox eTextBoxStrength;
        private System.Windows.Forms.TextBox eTextBoxDefence;
        private System.Windows.Forms.TextBox eTextBoxMagic;
        private System.Windows.Forms.TextBox eTextBoxCapacity;
        private System.Windows.Forms.TextBox eTextBoxClass;
        private System.Windows.Forms.TextBox eTextBoxName;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button dCharacterButton;
    }
}