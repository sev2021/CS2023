namespace CarsDB
{
    partial class FrmCars
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
            this.TxtRegNo = new System.Windows.Forms.TextBox();
            this.TxtMake = new System.Windows.Forms.TextBox();
            this.TxtEngine = new System.Windows.Forms.TextBox();
            this.TxtRegDate = new System.Windows.Forms.TextBox();
            this.TxtRate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtRegNo
            // 
            this.TxtRegNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRegNo.Location = new System.Drawing.Point(186, 12);
            this.TxtRegNo.Name = "TxtRegNo";
            this.TxtRegNo.Size = new System.Drawing.Size(150, 26);
            this.TxtRegNo.TabIndex = 0;
            // 
            // TxtMake
            // 
            this.TxtMake.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMake.Location = new System.Drawing.Point(186, 57);
            this.TxtMake.Name = "TxtMake";
            this.TxtMake.Size = new System.Drawing.Size(165, 26);
            this.TxtMake.TabIndex = 0;
            // 
            // TxtEngine
            // 
            this.TxtEngine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEngine.Location = new System.Drawing.Point(186, 104);
            this.TxtEngine.Name = "TxtEngine";
            this.TxtEngine.Size = new System.Drawing.Size(150, 26);
            this.TxtEngine.TabIndex = 0;
            // 
            // TxtRegDate
            // 
            this.TxtRegDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRegDate.Location = new System.Drawing.Point(186, 150);
            this.TxtRegDate.Name = "TxtRegDate";
            this.TxtRegDate.Size = new System.Drawing.Size(150, 26);
            this.TxtRegDate.TabIndex = 0;
            // 
            // TxtRate
            // 
            this.TxtRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRate.Location = new System.Drawing.Point(186, 196);
            this.TxtRate.Name = "TxtRate";
            this.TxtRate.Size = new System.Drawing.Size(150, 26);
            this.TxtRate.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "RegNo";
            // 
            // FrmCars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtRate);
            this.Controls.Add(this.TxtRegDate);
            this.Controls.Add(this.TxtEngine);
            this.Controls.Add(this.TxtMake);
            this.Controls.Add(this.TxtRegNo);
            this.Name = "FrmCars";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtRegNo;
        private System.Windows.Forms.TextBox TxtMake;
        private System.Windows.Forms.TextBox TxtEngine;
        private System.Windows.Forms.TextBox TxtRegDate;
        private System.Windows.Forms.TextBox TxtRate;
        private System.Windows.Forms.Label label1;
    }
}

