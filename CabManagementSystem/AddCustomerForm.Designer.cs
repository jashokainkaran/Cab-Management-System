namespace CabManagementSystem
{
    partial class AddCustomerForm
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
            contactNumber = new TextBox();
            currentLocation = new TextBox();
            customerName = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            destination = new TextBox();
            password = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // contactNumber
            // 
            contactNumber.Font = new Font("Segoe UI", 14F);
            contactNumber.Location = new Point(420, 161);
            contactNumber.Name = "contactNumber";
            contactNumber.Size = new Size(187, 39);
            contactNumber.TabIndex = 26;
            // 
            // currentLocation
            // 
            currentLocation.Font = new Font("Segoe UI", 14F);
            currentLocation.Location = new Point(420, 228);
            currentLocation.Name = "currentLocation";
            currentLocation.Size = new Size(187, 39);
            currentLocation.TabIndex = 25;
            // 
            // customerName
            // 
            customerName.Font = new Font("Segoe UI", 14F);
            customerName.Location = new Point(420, 42);
            customerName.Name = "customerName";
            customerName.Size = new Size(187, 39);
            customerName.TabIndex = 24;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F);
            label4.Location = new Point(203, 293);
            label4.Name = "label4";
            label4.Size = new Size(136, 32);
            label4.TabIndex = 23;
            label4.Text = "Destination";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(203, 228);
            label3.Name = "label3";
            label3.Size = new Size(191, 32);
            label3.TabIndex = 22;
            label3.Text = "Current Location";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(203, 161);
            label2.Name = "label2";
            label2.Size = new Size(191, 32);
            label2.TabIndex = 21;
            label2.Text = "Contact Number";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(203, 45);
            label1.Name = "label1";
            label1.Size = new Size(188, 32);
            label1.TabIndex = 20;
            label1.Text = "Customer Name";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14F);
            button1.Location = new Point(300, 359);
            button1.Name = "button1";
            button1.Size = new Size(197, 49);
            button1.TabIndex = 19;
            button1.Text = "Add Customer";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // destination
            // 
            destination.Font = new Font("Segoe UI", 14F);
            destination.Location = new Point(420, 293);
            destination.Name = "destination";
            destination.Size = new Size(187, 39);
            destination.TabIndex = 27;
            // 
            // password
            // 
            password.Font = new Font("Segoe UI", 14F);
            password.Location = new Point(420, 100);
            password.Name = "password";
            password.Size = new Size(187, 39);
            password.TabIndex = 29;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F);
            label5.Location = new Point(203, 103);
            label5.Name = "label5";
            label5.Size = new Size(111, 32);
            label5.TabIndex = 28;
            label5.Text = "Password";
            // 
            // AddCustomerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(password);
            Controls.Add(label5);
            Controls.Add(destination);
            Controls.Add(contactNumber);
            Controls.Add(currentLocation);
            Controls.Add(customerName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "AddCustomerForm";
            Text = "AddCustomerForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox contactNumber;
        private TextBox currentLocation;
        private TextBox customerName;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button1;
        private TextBox destination;
        private TextBox password;
        private Label label5;
    }
}