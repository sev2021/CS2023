namespace SalesDBApp
{
    partial class FillOrCancel
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.dtpFillDate = new System.Windows.Forms.DateTimePicker();
            this.dgvCustomersOrders = new System.Windows.Forms.DataGridView();
            this.btnFinishUpdates = new System.Windows.Forms.Button();
            this.btnFillOrder = new System.Windows.Forms.Button();
            this.btnCancelOrder = new System.Windows.Forms.Button();
            this.btnFindByOrderID = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomersOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Order ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 102);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "If filling an order, specify filled date";
            // 
            // txtOrderID
            // 
            this.txtOrderID.Location = new System.Drawing.Point(86, 31);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.Size = new System.Drawing.Size(120, 22);
            this.txtOrderID.TabIndex = 1;
            // 
            // dtpFillDate
            // 
            this.dtpFillDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFillDate.Location = new System.Drawing.Point(237, 99);
            this.dtpFillDate.Name = "dtpFillDate";
            this.dtpFillDate.Size = new System.Drawing.Size(150, 22);
            this.dtpFillDate.TabIndex = 2;
            // 
            // dgvCustomersOrders
            // 
            this.dgvCustomersOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomersOrders.Location = new System.Drawing.Point(12, 140);
            this.dgvCustomersOrders.Name = "dgvCustomersOrders";
            this.dgvCustomersOrders.Size = new System.Drawing.Size(656, 174);
            this.dgvCustomersOrders.TabIndex = 3;
            // 
            // btnFinishUpdates
            // 
            this.btnFinishUpdates.AutoSize = true;
            this.btnFinishUpdates.Location = new System.Drawing.Point(578, 342);
            this.btnFinishUpdates.Name = "btnFinishUpdates";
            this.btnFinishUpdates.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.btnFinishUpdates.Size = new System.Drawing.Size(90, 26);
            this.btnFinishUpdates.TabIndex = 4;
            this.btnFinishUpdates.Text = "Finish";
            this.btnFinishUpdates.UseVisualStyleBackColor = true;
            this.btnFinishUpdates.Click += new System.EventHandler(this.btnFinishUpdates_Click);
            // 
            // btnFillOrder
            // 
            this.btnFillOrder.AutoSize = true;
            this.btnFillOrder.Location = new System.Drawing.Point(153, 342);
            this.btnFillOrder.Name = "btnFillOrder";
            this.btnFillOrder.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnFillOrder.Size = new System.Drawing.Size(111, 26);
            this.btnFillOrder.TabIndex = 4;
            this.btnFillOrder.Text = "Fill Order";
            this.btnFillOrder.UseVisualStyleBackColor = true;
            this.btnFillOrder.Click += new System.EventHandler(this.btnFillOrder_Click);
            // 
            // btnCancelOrder
            // 
            this.btnCancelOrder.AutoSize = true;
            this.btnCancelOrder.Location = new System.Drawing.Point(12, 342);
            this.btnCancelOrder.Name = "btnCancelOrder";
            this.btnCancelOrder.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.btnCancelOrder.Size = new System.Drawing.Size(126, 26);
            this.btnCancelOrder.TabIndex = 4;
            this.btnCancelOrder.Text = "Cancel Order";
            this.btnCancelOrder.UseVisualStyleBackColor = true;
            this.btnCancelOrder.Click += new System.EventHandler(this.btnCancelOrder_Click);
            // 
            // btnFindByOrderID
            // 
            this.btnFindByOrderID.AutoSize = true;
            this.btnFindByOrderID.Location = new System.Drawing.Point(222, 29);
            this.btnFindByOrderID.Name = "btnFindByOrderID";
            this.btnFindByOrderID.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.btnFindByOrderID.Size = new System.Drawing.Size(110, 26);
            this.btnFindByOrderID.TabIndex = 4;
            this.btnFindByOrderID.Text = "Find Order";
            this.btnFindByOrderID.UseVisualStyleBackColor = true;
            this.btnFindByOrderID.Click += new System.EventHandler(this.btnFindByOrderID_Click);
            // 
            // FillOrCancel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 385);
            this.Controls.Add(this.btnFindByOrderID);
            this.Controls.Add(this.btnCancelOrder);
            this.Controls.Add(this.btnFillOrder);
            this.Controls.Add(this.btnFinishUpdates);
            this.Controls.Add(this.dgvCustomersOrders);
            this.Controls.Add(this.dtpFillDate);
            this.Controls.Add(this.txtOrderID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FillOrCancel";
            this.Text = "FillOrCancel";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomersOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.DateTimePicker dtpFillDate;
        private System.Windows.Forms.DataGridView dgvCustomersOrders;
        private System.Windows.Forms.Button btnFinishUpdates;
        private System.Windows.Forms.Button btnFillOrder;
        private System.Windows.Forms.Button btnCancelOrder;
        private System.Windows.Forms.Button btnFindByOrderID;
    }
}