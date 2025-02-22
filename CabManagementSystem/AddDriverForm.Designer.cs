namespace CabManagementSystem
{
    partial class AddDriverForm
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
            available = new CheckBox();
            driverName = new TextBox();
            contactNumber = new TextBox();
            driverId = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // available
            // 
            available.AutoSize = true;
            available.Font = new Font("Segoe UI", 10F);
            available.Location = new Point(415, 258);
            available.Name = "available";
            available.Size = new Size(100, 27);
            available.TabIndex = 18;
            available.Text = "Available";
            available.UseVisualStyleBackColor = true;
            // 
            // driverName
            // 
            driverName.Font = new Font("Segoe UI", 14F);
            driverName.Location = new Point(415, 126);
            driverName.Name = "driverName";
            driverName.Size = new Size(187, 39);
            driverName.TabIndex = 17;
            // 
            // contactNumber
            // 
            contactNumber.Font = new Font("Segoe UI", 14F);
            contactNumber.Location = new Point(415, 193);
            contactNumber.Name = "contactNumber";
            contactNumber.Size = new Size(187, 39);
            contactNumber.TabIndex = 16;
            // 
            // driverId
            // 
            driverId.Font = new Font("Segoe UI", 14F);
            driverId.Location = new Point(415, 63);
            driverId.Name = "driverId";
            driverId.Size = new Size(187, 39);
            driverId.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F);
            label4.Location = new Point(198, 258);
            label4.Name = "label4";
            label4.Size = new Size(129, 32);
            label4.TabIndex = 14;
            label4.Text = "Availability";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(198, 193);
            label3.Name = "label3";
            label3.Size = new Size(191, 32);
            label3.TabIndex = 13;
            label3.Text = "Contact Number";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(198, 126);
            label2.Name = "label2";
            label2.Size = new Size(78, 32);
            label2.TabIndex = 12;
            label2.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(198, 66);
            label1.Name = "label1";
            label1.Size = new Size(108, 32);
            label1.TabIndex = 11;
            label1.Text = "Driver ID";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14F);
            button1.Location = new Point(334, 340);
            button1.Name = "button1";
            button1.Size = new Size(148, 49);
            button1.TabIndex = 10;
            button1.Text = "Add Driver";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // AddDriverForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(available);
            Controls.Add(driverName);
            Controls.Add(contactNumber);
            Controls.Add(driverId);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "AddDriverForm";
            Text = "AddDriverForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox available;
        private TextBox driverName;
        private TextBox contactNumber;
        private TextBox driverId;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button1;
    }
}