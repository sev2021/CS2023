namespace CarsDB
{
    partial class FormSearch
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtValue = new System.Windows.Forms.TextBox();
            this.CboOperator = new System.Windows.Forms.ComboBox();
            this.CboField = new System.Windows.Forms.ComboBox();
            this.BtnRun = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.DGVCars = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCars)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TxtValue);
            this.groupBox1.Controls.Add(this.CboOperator);
            this.groupBox1.Controls.Add(this.CboField);
            this.groupBox1.Location = new System.Drawing.Point(16, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(459, 96);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(350, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Value:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(225, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Operator:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Field:";
            // 
            // TxtValue
            // 
            this.TxtValue.Location = new System.Drawing.Point(347, 53);
            this.TxtValue.Name = "TxtValue";
            this.TxtValue.Size = new System.Drawing.Size(100, 22);
            this.TxtValue.TabIndex = 1;
            // 
            // CboOperator
            // 
            this.CboOperator.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboOperator.FormattingEnabled = true;
            this.CboOperator.Location = new System.Drawing.Point(225, 53);
            this.CboOperator.Margin = new System.Windows.Forms.Padding(4);
            this.CboOperator.Name = "CboOperator";
            this.CboOperator.Size = new System.Drawing.Size(100, 24);
            this.CboOperator.TabIndex = 0;
            // 
            // CboField
            // 
            this.CboField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboField.FormattingEnabled = true;
            this.CboField.Location = new System.Drawing.Point(13, 53);
            this.CboField.Margin = new System.Windows.Forms.Padding(4);
            this.CboField.Name = "CboField";
            this.CboField.Size = new System.Drawing.Size(190, 24);
            this.CboField.TabIndex = 0;
            // 
            // BtnRun
            // 
            this.BtnRun.AutoSize = true;
            this.BtnRun.Location = new System.Drawing.Point(526, 26);
            this.BtnRun.Name = "BtnRun";
            this.BtnRun.Padding = new System.Windows.Forms.Padding(5);
            this.BtnRun.Size = new System.Drawing.Size(106, 36);
            this.BtnRun.TabIndex = 1;
            this.BtnRun.Text = "Run";
            this.BtnRun.UseVisualStyleBackColor = true;
            // 
            // BtnClose
            // 
            this.BtnClose.AutoSize = true;
            this.BtnClose.Location = new System.Drawing.Point(526, 69);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Padding = new System.Windows.Forms.Padding(5);
            this.BtnClose.Size = new System.Drawing.Size(106, 36);
            this.BtnClose.TabIndex = 1;
            this.BtnClose.Text = "Close";
            this.BtnClose.UseVisualStyleBackColor = true;
            // 
            // DGVCars
            // 
            this.DGVCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVCars.Location = new System.Drawing.Point(16, 134);
            this.DGVCars.Name = "DGVCars";
            this.DGVCars.Size = new System.Drawing.Size(624, 197);
            this.DGVCars.TabIndex = 2;
            // 
            // FormSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 348);
            this.Controls.Add(this.DGVCars);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnRun);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormSearch";
            this.Text = "FormSearch";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCars)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox CboField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtValue;
        private System.Windows.Forms.ComboBox CboOperator;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnRun;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.DataGridView DGVCars;
    }
}