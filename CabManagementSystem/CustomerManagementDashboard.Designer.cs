namespace CabManagementSystem
{
    partial class CustomerManagementDashboard
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
            dataGridCustomers = new DataGridView();
            addCustomer = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridCustomers).BeginInit();
            SuspendLayout();
            // 
            // dataGridCustomers
            // 
            dataGridCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridCustomers.Location = new Point(12, 21);
            dataGridCustomers.Name = "dataGridCustomers";
            dataGridCustomers.RowHeadersWidth = 51;
            dataGridCustomers.Size = new Size(409, 398);
            dataGridCustomers.TabIndex = 0;
            // 
            // addCustomer
            // 
            addCustomer.Font = new Font("Segoe UI", 14F);
            addCustomer.Location = new Point(513, 111);
            addCustomer.Name = "addCustomer";
            addCustomer.Size = new Size(224, 59);
            addCustomer.TabIndex = 1;
            addCustomer.Text = "Add Customer";
            addCustomer.UseVisualStyleBackColor = true;
            addCustomer.Click += addCustomer_Click_1;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 14F);
            button3.Location = new Point(513, 214);
            button3.Name = "button3";
            button3.Size = new Size(224, 59);
            button3.TabIndex = 3;
            button3.Text = "Remove Customer";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // CustomerManagementDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(addCustomer);
            Controls.Add(dataGridCustomers);
            Name = "CustomerManagementDashboard";
            Text = "CustomerManagementDashboard";
            ((System.ComponentModel.ISupportInitialize)dataGridCustomers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridCustomers;
        private Button addCustomer;
        private Button button3;
    }
}