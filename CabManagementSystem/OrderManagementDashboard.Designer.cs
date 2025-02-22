namespace CabManagementSystem
{
    partial class OrderManagementDashboard
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
            removeOrder = new Button();
            addOrder = new Button();
            dataGridOrders = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridOrders).BeginInit();
            SuspendLayout();
            // 
            // removeOrder
            // 
            removeOrder.Font = new Font("Segoe UI", 14F);
            removeOrder.Location = new Point(539, 219);
            removeOrder.Name = "removeOrder";
            removeOrder.Size = new Size(224, 59);
            removeOrder.TabIndex = 6;
            removeOrder.Text = "Remove Order";
            removeOrder.UseVisualStyleBackColor = true;
            // 
            // addOrder
            // 
            addOrder.Font = new Font("Segoe UI", 14F);
            addOrder.Location = new Point(539, 116);
            addOrder.Name = "addOrder";
            addOrder.Size = new Size(224, 59);
            addOrder.TabIndex = 5;
            addOrder.Text = "Add Order";
            addOrder.UseVisualStyleBackColor = true;
            // 
            // dataGridOrders
            // 
            dataGridOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridOrders.Location = new Point(38, 26);
            dataGridOrders.Name = "dataGridOrders";
            dataGridOrders.RowHeadersWidth = 51;
            dataGridOrders.Size = new Size(409, 398);
            dataGridOrders.TabIndex = 4;
            // 
            // OrderManagementDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(removeOrder);
            Controls.Add(addOrder);
            Controls.Add(dataGridOrders);
            Name = "OrderManagementDashboard";
            Text = "OrderManagementDashboard";
            ((System.ComponentModel.ISupportInitialize)dataGridOrders).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button removeOrder;
        private Button addOrder;
        private DataGridView dataGridOrders;
    }
}