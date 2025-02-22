namespace CabManagementSystem
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            username = new TextBox();
            password = new TextBox();
            label1 = new Label();
            label2 = new Label();
            login = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // username
            // 
            username.Font = new Font("Segoe UI", 14F);
            username.Location = new Point(377, 89);
            username.Name = "username";
            username.Size = new Size(216, 39);
            username.TabIndex = 0;
            // 
            // password
            // 
            password.Font = new Font("Segoe UI", 14F);
            password.Location = new Point(377, 197);
            password.Name = "password";
            password.Size = new Size(216, 39);
            password.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(195, 92);
            label1.Name = "label1";
            label1.Size = new Size(132, 32);
            label1.TabIndex = 2;
            label1.Text = "User Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(216, 197);
            label2.Name = "label2";
            label2.Size = new Size(111, 32);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // login
            // 
            login.Font = new Font("Segoe UI", 14F);
            login.Location = new Point(301, 293);
            login.Name = "login";
            login.Size = new Size(158, 50);
            login.TabIndex = 4;
            login.Text = "Login";
            login.UseVisualStyleBackColor = true;
            login.Click += login_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14F);
            button1.Location = new Point(301, 371);
            button1.Name = "button1";
            button1.Size = new Size(158, 51);
            button1.TabIndex = 5;
            button1.Text = "Sign Up";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(788, 450);
            Controls.Add(button1);
            Controls.Add(login);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(password);
            Controls.Add(username);
            Name = "Form1";
            Text = "Login";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox username;
        private TextBox password;
        private Label label1;
        private Label label2;
        private Button login;
        private Button button1;
    }
}
