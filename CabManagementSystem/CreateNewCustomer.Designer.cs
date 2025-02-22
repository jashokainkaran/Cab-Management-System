namespace CabManagementSystem
{
    partial class CreateNewCustomer
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
            destination = new TextBox();
            contactNumber = new TextBox();
            currentLocation = new TextBox();
            customerName = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            signUp = new Button();
            password = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // destination
            // 
            destination.Font = new Font("Segoe UI", 14F);
            destination.Location = new Point(419, 284);
            destination.Name = "destination";
            destination.Size = new Size(187, 39);
            destination.TabIndex = 36;
            // 
            // contactNumber
            // 
            contactNumber.Font = new Font("Segoe UI", 14F);
            contactNumber.Location = new Point(419, 152);
            contactNumber.Name = "contactNumber";
            contactNumber.Size = new Size(187, 39);
            contactNumber.TabIndex = 35;
            // 
            // currentLocation
            // 
            currentLocation.Font = new Font("Segoe UI", 14F);
            currentLocation.Location = new Point(419, 219);
            currentLocation.Name = "currentLocation";
            currentLocation.Size = new Size(187, 39);
            currentLocation.TabIndex = 34;
            // 
            // customerName
            // 
            customerName.Font = new Font("Segoe UI", 14F);
            customerName.Location = new Point(419, 37);
            customerName.Name = "customerName";
            customerName.Size = new Size(187, 39);
            customerName.TabIndex = 33;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F);
            label4.Location = new Point(202, 284);
            label4.Name = "label4";
            label4.Size = new Size(136, 32);
            label4.TabIndex = 32;
            label4.Text = "Destination";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(202, 219);
            label3.Name = "label3";
            label3.Size = new Size(191, 32);
            label3.TabIndex = 31;
            label3.Text = "Current Location";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(202, 152);
            label2.Name = "label2";
            label2.Size = new Size(191, 32);
            label2.TabIndex = 30;
            label2.Text = "Contact Number";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(202, 40);
            label1.Name = "label1";
            label1.Size = new Size(123, 32);
            label1.TabIndex = 29;
            label1.Text = "Full Name";
            // 
            // signUp
            // 
            signUp.Font = new Font("Segoe UI", 14F);
            signUp.Location = new Point(305, 356);
            signUp.Name = "signUp";
            signUp.Size = new Size(197, 49);
            signUp.TabIndex = 28;
            signUp.Text = "Sign Up";
            signUp.UseVisualStyleBackColor = true;
            signUp.Click += signUp_Click;
            // 
            // password
            // 
            password.Font = new Font("Segoe UI", 14F);
            password.Location = new Point(419, 95);
            password.Name = "password";
            password.Size = new Size(187, 39);
            password.TabIndex = 38;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F);
            label5.Location = new Point(202, 98);
            label5.Name = "label5";
            label5.Size = new Size(111, 32);
            label5.TabIndex = 37;
            label5.Text = "Password";
            // 
            // CreateNewCustomer
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
            Controls.Add(signUp);
            Name = "CreateNewCustomer";
            Text = "Create New Account";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox destination;
        private TextBox contactNumber;
        private TextBox currentLocation;
        private TextBox customerName;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button signUp;
        private TextBox password;
        private Label label5;
    }
}