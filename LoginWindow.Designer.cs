namespace HMSAppUsingEF
{
    partial class LoginWindow
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
            textBox1 = new TextBox();
            User = new Label();
            Password = new Label();
            textBox2 = new TextBox();
            HMS = new Label();
            Login = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(348, 137);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(148, 27);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // User
            // 
            User.AutoSize = true;
            User.Location = new Point(241, 140);
            User.Name = "User";
            User.Size = new Size(38, 20);
            User.TabIndex = 1;
            User.Text = "User";
            User.Click += label1_Click;
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.Location = new Point(241, 184);
            Password.Name = "Password";
            Password.Size = new Size(70, 20);
            Password.TabIndex = 2;
            Password.Text = "Password";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(348, 177);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(148, 27);
            textBox2.TabIndex = 3;
            // 
            // HMS
            // 
            HMS.AutoSize = true;
            HMS.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            HMS.Location = new Point(209, 72);
            HMS.Name = "HMS";
            HMS.Size = new Size(354, 32);
            HMS.TabIndex = 4;
            HMS.Text = "Hospital Management System";
            HMS.Click += label1_Click_1;
            // 
            // Login
            // 
            Login.BackColor = SystemColors.ActiveCaption;
            Login.Location = new Point(333, 241);
            Login.Name = "Login";
            Login.Size = new Size(119, 29);
            Login.TabIndex = 5;
            Login.Text = "Login";
            Login.UseVisualStyleBackColor = false;
            // 
            // LoginWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Login);
            Controls.Add(HMS);
            Controls.Add(textBox2);
            Controls.Add(Password);
            Controls.Add(User);
            Controls.Add(textBox1);
            Name = "LoginWindow";
            Text = "HMS";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label User;
        private Label Password;
        private TextBox textBox2;
        private Label HMS;
        private Button Login;
    }
}
