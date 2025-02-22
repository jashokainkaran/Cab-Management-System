namespace CabManagementSystem
{
    partial class CarManagementDashboard
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
            dataGridViewCars = new DataGridView();
            addCar = new Button();
            removeCar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCars).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewCars
            // 
            dataGridViewCars.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCars.Location = new Point(12, 12);
            dataGridViewCars.Name = "dataGridViewCars";
            dataGridViewCars.RowHeadersWidth = 51;
            dataGridViewCars.Size = new Size(431, 426);
            dataGridViewCars.TabIndex = 0;
            // 
            // addCar
            // 
            addCar.Font = new Font("Segoe UI", 14F);
            addCar.Location = new Point(535, 121);
            addCar.Name = "addCar";
            addCar.Size = new Size(192, 52);
            addCar.TabIndex = 1;
            addCar.Text = "Add Car";
            addCar.UseVisualStyleBackColor = true;
            addCar.Click += addCar_Click;
            // 
            // removeCar
            // 
            removeCar.Font = new Font("Segoe UI", 14F);
            removeCar.Location = new Point(535, 204);
            removeCar.Name = "removeCar";
            removeCar.Size = new Size(192, 59);
            removeCar.TabIndex = 2;
            removeCar.Text = "Remove Car";
            removeCar.UseVisualStyleBackColor = true;
            removeCar.Click += removeCar_Click;
            // 
            // CarManagementDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(removeCar);
            Controls.Add(addCar);
            Controls.Add(dataGridViewCars);
            Name = "CarManagementDashboard";
            Text = "CarManagementDashboard";
            Load += CarManagementDashboard_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewCars).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewCars;
        private Button addCar;
        private Button removeCar;
    }
}