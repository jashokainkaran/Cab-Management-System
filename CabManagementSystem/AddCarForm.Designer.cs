namespace CabManagementSystem
{
    partial class AddCarForm
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
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            carId = new TextBox();
            carNumber = new TextBox();
            carModel = new TextBox();
            available = new CheckBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14F);
            button1.Location = new Point(353, 337);
            button1.Name = "button1";
            button1.Size = new Size(148, 49);
            button1.TabIndex = 0;
            button1.Text = "Add Car";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(199, 64);
            label1.Name = "label1";
            label1.Size = new Size(79, 32);
            label1.TabIndex = 1;
            label1.Text = "Car ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(199, 124);
            label2.Name = "label2";
            label2.Size = new Size(83, 32);
            label2.TabIndex = 2;
            label2.Text = "Model";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(199, 191);
            label3.Name = "label3";
            label3.Size = new Size(161, 32);
            label3.TabIndex = 3;
            label3.Text = "Plate Number";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F);
            label4.Location = new Point(199, 256);
            label4.Name = "label4";
            label4.Size = new Size(129, 32);
            label4.TabIndex = 4;
            label4.Text = "Availability";
            // 
            // carId
            // 
            carId.Font = new Font("Segoe UI", 14F);
            carId.Location = new Point(416, 61);
            carId.Name = "carId";
            carId.Size = new Size(187, 39);
            carId.TabIndex = 5;
            // 
            // carNumber
            // 
            carNumber.Font = new Font("Segoe UI", 14F);
            carNumber.Location = new Point(416, 191);
            carNumber.Name = "carNumber";
            carNumber.Size = new Size(187, 39);
            carNumber.TabIndex = 6;
            // 
            // carModel
            // 
            carModel.Font = new Font("Segoe UI", 14F);
            carModel.Location = new Point(416, 124);
            carModel.Name = "carModel";
            carModel.Size = new Size(187, 39);
            carModel.TabIndex = 8;
            // 
            // available
            // 
            available.AutoSize = true;
            available.Font = new Font("Segoe UI", 10F);
            available.Location = new Point(416, 256);
            available.Name = "available";
            available.Size = new Size(100, 27);
            available.TabIndex = 9;
            available.Text = "Available";
            available.UseVisualStyleBackColor = true;
            // 
            // AddCarForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(available);
            Controls.Add(carModel);
            Controls.Add(carNumber);
            Controls.Add(carId);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "AddCarForm";
            Text = "AddCarForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox carId;
        private TextBox carNumber;
        private TextBox carModel;
        private CheckBox available;
    }
}