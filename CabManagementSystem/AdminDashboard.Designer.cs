namespace CabManagementSystem
{
    partial class AdminDashboard
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
            viewCars = new Button();
            viewDrivers = new Button();
            viewCustomers = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // viewCars
            // 
            viewCars.Font = new Font("Segoe UI", 14F);
            viewCars.Location = new Point(311, 40);
            viewCars.Name = "viewCars";
            viewCars.Size = new Size(204, 51);
            viewCars.TabIndex = 0;
            viewCars.Text = "View Cars";
            viewCars.UseVisualStyleBackColor = true;
            viewCars.Click += viewCars_Click;
            // 
            // viewDrivers
            // 
            viewDrivers.Font = new Font("Segoe UI", 14F);
            viewDrivers.Location = new Point(311, 121);
            viewDrivers.Name = "viewDrivers";
            viewDrivers.Size = new Size(204, 53);
            viewDrivers.TabIndex = 1;
            viewDrivers.Text = "View Drivers";
            viewDrivers.UseVisualStyleBackColor = true;
            viewDrivers.Click += viewDrivers_Click;
            // 
            // viewCustomers
            // 
            viewCustomers.Font = new Font("Segoe UI", 14F);
            viewCustomers.Location = new Point(311, 222);
            viewCustomers.Name = "viewCustomers";
            viewCustomers.Size = new Size(204, 52);
            viewCustomers.TabIndex = 3;
            viewCustomers.Text = "View Customers";
            viewCustomers.UseVisualStyleBackColor = true;
            viewCustomers.Click += viewCustomers_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14F);
            button1.Location = new Point(311, 322);
            button1.Name = "button1";
            button1.Size = new Size(204, 52);
            button1.TabIndex = 4;
            button1.Text = "Log Out";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(viewCustomers);
            Controls.Add(viewDrivers);
            Controls.Add(viewCars);
            Name = "AdminDashboard";
            Text = "AdminDashboard";
            ResumeLayout(false);
        }

        #endregion

        private Button viewCars;
        private Button viewDrivers;
        private Button viewCustomers;
        private Button button1;
    }
}