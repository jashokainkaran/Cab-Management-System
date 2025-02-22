namespace CabManagementSystem
{
    partial class CustomerDashboard
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
            welcomeLabel = new Label();
            carComboBox = new ComboBox();
            driverComboBox = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            placeOrder = new Button();
            logOut = new Button();
            SuspendLayout();
            // 
            // welcomeLabel
            // 
            welcomeLabel.AutoSize = true;
            welcomeLabel.Font = new Font("Times New Roman", 15F, FontStyle.Bold);
            welcomeLabel.Location = new Point(31, 30);
            welcomeLabel.Name = "welcomeLabel";
            welcomeLabel.Size = new Size(0, 29);
            welcomeLabel.TabIndex = 0;
            // 
            // carComboBox
            // 
            carComboBox.Font = new Font("Segoe UI", 14F);
            carComboBox.FormattingEnabled = true;
            carComboBox.Location = new Point(447, 103);
            carComboBox.Name = "carComboBox";
            carComboBox.Size = new Size(233, 39);
            carComboBox.TabIndex = 1;
            carComboBox.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // driverComboBox
            // 
            driverComboBox.Font = new Font("Segoe UI", 14F);
            driverComboBox.FormattingEnabled = true;
            driverComboBox.Location = new Point(447, 184);
            driverComboBox.Name = "driverComboBox";
            driverComboBox.Size = new Size(233, 39);
            driverComboBox.TabIndex = 2;
            driverComboBox.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 14F);
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(447, 269);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.RightToLeft = RightToLeft.No;
            dateTimePicker1.Size = new Size(233, 39);
            dateTimePicker1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(242, 110);
            label1.Name = "label1";
            label1.Size = new Size(120, 32);
            label1.TabIndex = 4;
            label1.Text = "Select Car";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(242, 191);
            label2.Name = "label2";
            label2.Size = new Size(149, 32);
            label2.TabIndex = 5;
            label2.Text = "Select Driver";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(242, 276);
            label3.Name = "label3";
            label3.Size = new Size(135, 32);
            label3.TabIndex = 6;
            label3.Text = "Select Date";
            // 
            // placeOrder
            // 
            placeOrder.Font = new Font("Segoe UI", 14F);
            placeOrder.Location = new Point(336, 353);
            placeOrder.Name = "placeOrder";
            placeOrder.Size = new Size(196, 53);
            placeOrder.TabIndex = 7;
            placeOrder.Text = "Place Order";
            placeOrder.UseVisualStyleBackColor = true;
            placeOrder.Click += placeOrder_Click;
            // 
            // logOut
            // 
            logOut.Font = new Font("Segoe UI", 14F);
            logOut.Location = new Point(336, 435);
            logOut.Name = "logOut";
            logOut.Size = new Size(196, 51);
            logOut.TabIndex = 8;
            logOut.Text = "Log Out";
            logOut.UseVisualStyleBackColor = true;
            logOut.Click += logOut_Click;
            // 
            // CustomerDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(867, 545);
            Controls.Add(logOut);
            Controls.Add(placeOrder);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dateTimePicker1);
            Controls.Add(driverComboBox);
            Controls.Add(carComboBox);
            Controls.Add(welcomeLabel);
            Name = "CustomerDashboard";
            Text = "CustomerDashboard";
            Load += CustomerDashboard_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label welcomeLabel;
        private ComboBox carComboBox;
        private ComboBox driverComboBox;
        private DateTimePicker dateTimePicker1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button placeOrder;
        private Button logOut;
    }
}