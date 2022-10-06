namespace Compnents
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
            this.LabHeader = new System.Windows.Forms.Label();
            this.TxtFirstName = new System.Windows.Forms.TextBox();
            this.LabFirstName = new System.Windows.Forms.Label();
            this.LabLastName = new System.Windows.Forms.Label();
            this.TxtLastName = new System.Windows.Forms.TextBox();
            this.LabAge = new System.Windows.Forms.Label();
            this.TxtAge = new System.Windows.Forms.TextBox();
            this.LabPhone = new System.Windows.Forms.Label();
            this.TxtPhone = new System.Windows.Forms.TextBox();
            this.LabEmail = new System.Windows.Forms.Label();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.ChbxA = new System.Windows.Forms.CheckBox();
            this.LabAgree = new System.Windows.Forms.Label();
            this.LabTitle = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabHeader
            // 
            this.LabHeader.AutoSize = true;
            this.LabHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabHeader.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.LabHeader.Location = new System.Drawing.Point(248, 21);
            this.LabHeader.Name = "LabHeader";
            this.LabHeader.Size = new System.Drawing.Size(137, 29);
            this.LabHeader.TabIndex = 0;
            this.LabHeader.Text = "Admissions";
            this.LabHeader.Click += new System.EventHandler(this.LabTitle_Click);
            // 
            // TxtFirstName
            // 
            this.TxtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFirstName.Location = new System.Drawing.Point(141, 135);
            this.TxtFirstName.Name = "TxtFirstName";
            this.TxtFirstName.Size = new System.Drawing.Size(177, 22);
            this.TxtFirstName.TabIndex = 1;
            // 
            // LabFirstName
            // 
            this.LabFirstName.AutoSize = true;
            this.LabFirstName.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.LabFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabFirstName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LabFirstName.Location = new System.Drawing.Point(45, 135);
            this.LabFirstName.Name = "LabFirstName";
            this.LabFirstName.Size = new System.Drawing.Size(90, 20);
            this.LabFirstName.TabIndex = 0;
            this.LabFirstName.Text = "First Name:";
            this.LabFirstName.Click += new System.EventHandler(this.LabTitle_Click);
            // 
            // LabLastName
            // 
            this.LabLastName.AutoSize = true;
            this.LabLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabLastName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LabLastName.Location = new System.Drawing.Point(45, 179);
            this.LabLastName.Name = "LabLastName";
            this.LabLastName.Size = new System.Drawing.Size(90, 20);
            this.LabLastName.TabIndex = 0;
            this.LabLastName.Text = "Last Name:";
            this.LabLastName.Click += new System.EventHandler(this.LabTitle_Click);
            // 
            // TxtLastName
            // 
            this.TxtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtLastName.Location = new System.Drawing.Point(141, 179);
            this.TxtLastName.Name = "TxtLastName";
            this.TxtLastName.Size = new System.Drawing.Size(177, 22);
            this.TxtLastName.TabIndex = 2;
            // 
            // LabAge
            // 
            this.LabAge.AutoSize = true;
            this.LabAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabAge.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LabAge.Location = new System.Drawing.Point(45, 223);
            this.LabAge.Name = "LabAge";
            this.LabAge.Size = new System.Drawing.Size(42, 20);
            this.LabAge.TabIndex = 0;
            this.LabAge.Text = "Age:";
            this.LabAge.Click += new System.EventHandler(this.LabTitle_Click);
            // 
            // TxtAge
            // 
            this.TxtAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAge.Location = new System.Drawing.Point(141, 223);
            this.TxtAge.Name = "TxtAge";
            this.TxtAge.Size = new System.Drawing.Size(177, 22);
            this.TxtAge.TabIndex = 3;
            // 
            // LabPhone
            // 
            this.LabPhone.AutoSize = true;
            this.LabPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabPhone.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LabPhone.Location = new System.Drawing.Point(45, 266);
            this.LabPhone.Name = "LabPhone";
            this.LabPhone.Size = new System.Drawing.Size(59, 20);
            this.LabPhone.TabIndex = 0;
            this.LabPhone.Text = "Phone:";
            this.LabPhone.Click += new System.EventHandler(this.LabTitle_Click);
            // 
            // TxtPhone
            // 
            this.TxtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPhone.Location = new System.Drawing.Point(141, 266);
            this.TxtPhone.Name = "TxtPhone";
            this.TxtPhone.Size = new System.Drawing.Size(177, 22);
            this.TxtPhone.TabIndex = 4;
            // 
            // LabEmail
            // 
            this.LabEmail.AutoSize = true;
            this.LabEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabEmail.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LabEmail.Location = new System.Drawing.Point(45, 309);
            this.LabEmail.Name = "LabEmail";
            this.LabEmail.Size = new System.Drawing.Size(52, 20);
            this.LabEmail.TabIndex = 0;
            this.LabEmail.Text = "Email:";
            this.LabEmail.Click += new System.EventHandler(this.LabTitle_Click);
            // 
            // TxtEmail
            // 
            this.TxtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEmail.Location = new System.Drawing.Point(141, 309);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(177, 22);
            this.TxtEmail.TabIndex = 5;
            // 
            // ChbxA
            // 
            this.ChbxA.AutoSize = true;
            this.ChbxA.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ChbxA.Checked = true;
            this.ChbxA.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChbxA.Location = new System.Drawing.Point(141, 361);
            this.ChbxA.Name = "ChbxA";
            this.ChbxA.Size = new System.Drawing.Size(15, 14);
            this.ChbxA.TabIndex = 6;
            this.ChbxA.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ChbxA.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ChbxA.UseVisualStyleBackColor = true;
            // 
            // LabAgree
            // 
            this.LabAgree.AutoSize = true;
            this.LabAgree.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabAgree.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LabAgree.Location = new System.Drawing.Point(45, 357);
            this.LabAgree.Name = "LabAgree";
            this.LabAgree.Size = new System.Drawing.Size(52, 20);
            this.LabAgree.TabIndex = 0;
            this.LabAgree.Text = "Agree";
            this.LabAgree.Click += new System.EventHandler(this.LabTitle_Click);
            // 
            // LabTitle
            // 
            this.LabTitle.AutoSize = true;
            this.LabTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabTitle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LabTitle.Location = new System.Drawing.Point(45, 89);
            this.LabTitle.Name = "LabTitle";
            this.LabTitle.Size = new System.Drawing.Size(42, 20);
            this.LabTitle.TabIndex = 0;
            this.LabTitle.Text = "Title:";
            this.LabTitle.Click += new System.EventHandler(this.LabTitle_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ItemHeight = 13;
            this.comboBox1.Items.AddRange(new object[] {
            "as",
            "da",
            "sf",
            "a",
            "sf",
            "asg",
            "jk"});
            this.comboBox1.Location = new System.Drawing.Point(141, 91);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 7;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Aaaa",
            "Bbb",
            "Dccc",
            "FFff"});
            this.listBox1.Location = new System.Drawing.Point(384, 89);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 56);
            this.listBox1.TabIndex = 8;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "PPpp",
            "KKkk",
            "HJJ",
            "VG"});
            this.checkedListBox1.Location = new System.Drawing.Point(384, 166);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(120, 64);
            this.checkedListBox1.TabIndex = 9;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(384, 250);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(48, 17);
            this.radioButton1.TabIndex = 10;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Male";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(384, 273);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(59, 17);
            this.radioButton2.TabIndex = 10;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Female";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(384, 296);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(51, 17);
            this.radioButton3.TabIndex = 10;
            this.radioButton3.Tag = "";
            this.radioButton3.Text = "Other";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton6);
            this.groupBox1.Controls.Add(this.radioButton5);
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Location = new System.Drawing.Point(384, 347);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gender";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(3, 16);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(85, 17);
            this.radioButton4.TabIndex = 0;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "radioButton4";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(3, 39);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(85, 17);
            this.radioButton5.TabIndex = 0;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "radioButton4";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(3, 62);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(85, 17);
            this.radioButton6.TabIndex = 0;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "radioButton4";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(49, 409);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(318, 112);
            this.tabControl1.TabIndex = 12;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Silver;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(310, 86);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ccc";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(310, 86);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(310, 86);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(310, 86);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Aa";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(261, 86);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "tabPage5";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(275, 545);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Continue";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 591);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.ChbxA);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.LabAgree);
            this.Controls.Add(this.LabEmail);
            this.Controls.Add(this.TxtPhone);
            this.Controls.Add(this.LabPhone);
            this.Controls.Add(this.TxtAge);
            this.Controls.Add(this.LabAge);
            this.Controls.Add(this.TxtLastName);
            this.Controls.Add(this.LabTitle);
            this.Controls.Add(this.LabLastName);
            this.Controls.Add(this.TxtFirstName);
            this.Controls.Add(this.LabFirstName);
            this.Controls.Add(this.LabHeader);
            this.Name = "Form1";
            this.Text = "Admissions";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabHeader;
        private System.Windows.Forms.TextBox TxtFirstName;
        private System.Windows.Forms.Label LabFirstName;
        private System.Windows.Forms.Label LabLastName;
        private System.Windows.Forms.TextBox TxtLastName;
        private System.Windows.Forms.Label LabAge;
        private System.Windows.Forms.TextBox TxtAge;
        private System.Windows.Forms.Label LabPhone;
        private System.Windows.Forms.TextBox TxtPhone;
        private System.Windows.Forms.Label LabEmail;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.CheckBox ChbxA;
        private System.Windows.Forms.Label LabAgree;
        private System.Windows.Forms.Label LabTitle;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button button1;
    }
}

