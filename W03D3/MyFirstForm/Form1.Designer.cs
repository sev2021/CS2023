namespace MyFirstForm
{
    partial class MyFirstForm
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
            this.BtnClose = new System.Windows.Forms.Button();
            this.TxtUser = new System.Windows.Forms.TextBox();
            this.LabName = new System.Windows.Forms.Label();
            this.BtnGo = new System.Windows.Forms.Button();
            this.TxtPass = new System.Windows.Forms.TextBox();
            this.LabPass = new System.Windows.Forms.Label();
            this.LabResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.Color.DarkRed;
            this.BtnClose.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.ForeColor = System.Drawing.Color.Honeydew;
            this.BtnClose.Location = new System.Drawing.Point(433, 517);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(120, 40);
            this.BtnClose.TabIndex = 0;
            this.BtnClose.Text = "Close";
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // TxtUser
            // 
            this.TxtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUser.Location = new System.Drawing.Point(228, 146);
            this.TxtUser.Name = "TxtUser";
            this.TxtUser.Size = new System.Drawing.Size(264, 22);
            this.TxtUser.TabIndex = 2;
            // 
            // LabName
            // 
            this.LabName.AutoSize = true;
            this.LabName.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabName.Location = new System.Drawing.Point(104, 143);
            this.LabName.Name = "LabName";
            this.LabName.Size = new System.Drawing.Size(111, 25);
            this.LabName.TabIndex = 3;
            this.LabName.Text = "Username: ";
            // 
            // BtnGo
            // 
            this.BtnGo.BackColor = System.Drawing.Color.GreenYellow;
            this.BtnGo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGo.Location = new System.Drawing.Point(43, 517);
            this.BtnGo.Name = "BtnGo";
            this.BtnGo.Size = new System.Drawing.Size(120, 40);
            this.BtnGo.TabIndex = 0;
            this.BtnGo.Text = "Go";
            this.BtnGo.UseVisualStyleBackColor = false;
            this.BtnGo.Click += new System.EventHandler(this.BtnGo_Click);
            // 
            // TxtPass
            // 
            this.TxtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPass.Location = new System.Drawing.Point(228, 189);
            this.TxtPass.Name = "TxtPass";
            this.TxtPass.PasswordChar = '*';
            this.TxtPass.Size = new System.Drawing.Size(171, 22);
            this.TxtPass.TabIndex = 2;
            // 
            // LabPass
            // 
            this.LabPass.AutoSize = true;
            this.LabPass.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabPass.Location = new System.Drawing.Point(104, 187);
            this.LabPass.Name = "LabPass";
            this.LabPass.Size = new System.Drawing.Size(103, 25);
            this.LabPass.TabIndex = 3;
            this.LabPass.Text = "Password:";
            // 
            // LabResult
            // 
            this.LabResult.AutoEllipsis = true;
            this.LabResult.BackColor = System.Drawing.Color.Silver;
            this.LabResult.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabResult.ForeColor = System.Drawing.Color.Red;
            this.LabResult.Location = new System.Drawing.Point(113, 249);
            this.LabResult.Name = "LabResult";
            this.LabResult.Size = new System.Drawing.Size(388, 154);
            this.LabResult.TabIndex = 3;
            this.LabResult.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MyFirstForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(598, 585);
            this.Controls.Add(this.LabResult);
            this.Controls.Add(this.LabPass);
            this.Controls.Add(this.LabName);
            this.Controls.Add(this.TxtPass);
            this.Controls.Add(this.TxtUser);
            this.Controls.Add(this.BtnGo);
            this.Controls.Add(this.BtnClose);
            this.Name = "MyFirstForm";
            this.Text = "My First Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.TextBox TxtUser;
        private System.Windows.Forms.Label LabName;
        private System.Windows.Forms.Button BtnGo;
        private System.Windows.Forms.TextBox TxtPass;
        private System.Windows.Forms.Label LabPass;
        private System.Windows.Forms.Label LabResult;
    }
}

