namespace CabManagementSystem
{
    partial class DriverManagementDashboard
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
            addDriver = new Button();
            removeDriver = new Button();
            dataGridDrivers = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridDrivers).BeginInit();
            SuspendLayout();
            // 
            // addDriver
            // 
            addDriver.Font = new Font("Segoe UI", 14F);
            addDriver.Location = new Point(520, 103);
            addDriver.Name = "addDriver";
            addDriver.Size = new Size(190, 51);
            addDriver.TabIndex = 0;
            addDriver.Text = "Add Driver";
            addDriver.UseVisualStyleBackColor = true;
            addDriver.Click += addDriver_Click;
            // 
            // removeDriver
            // 
            removeDriver.Font = new Font("Segoe UI", 14F);
            removeDriver.Location = new Point(520, 229);
            removeDriver.Name = "removeDriver";
            removeDriver.Size = new Size(190, 51);
            removeDriver.TabIndex = 1;
            removeDriver.Text = "Remove Driver";
            removeDriver.UseVisualStyleBackColor = true;
            removeDriver.Click += removeDriver_Click;
            // 
            // dataGridDrivers
            // 
            dataGridDrivers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridDrivers.Location = new Point(21, 21);
            dataGridDrivers.Name = "dataGridDrivers";
            dataGridDrivers.RowHeadersWidth = 51;
            dataGridDrivers.Size = new Size(401, 402);
            dataGridDrivers.TabIndex = 2;
            // 
            // DriverManagementDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridDrivers);
            Controls.Add(removeDriver);
            Controls.Add(addDriver);
            Name = "DriverManagementDashboard";
            Text = "DriverManagementDashboard";
            ((System.ComponentModel.ISupportInitialize)dataGridDrivers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button addDriver;
        private Button removeDriver;
        private DataGridView dataGridDrivers;
    }
}