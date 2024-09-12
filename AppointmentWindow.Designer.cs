namespace HMSAppUsingEF
{
    partial class AppointmentWindow
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
            label1 = new Label();
            PatientName = new Label();
            label3 = new Label();
            DoctorName = new Label();
            AppointmentTime = new Label();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.Location = new Point(247, 18);
            label1.Name = "label1";
            label1.Size = new Size(270, 32);
            label1.TabIndex = 0;
            label1.Text = "Book An Appointment";
            label1.Click += this.label1_Click;
            // 
            // PatientName
            // 
            PatientName.AutoSize = true;
            PatientName.Location = new Point(150, 96);
            PatientName.Name = "PatientName";
            PatientName.Size = new Size(98, 20);
            PatientName.TabIndex = 1;
            PatientName.Text = "Patient Name";
            PatientName.Click += this.label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(150, 278);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 2;
            label3.Text = "label3";
            // 
            // DoctorName
            // 
            DoctorName.AutoSize = true;
            DoctorName.Location = new Point(150, 135);
            DoctorName.Name = "DoctorName";
            DoctorName.Size = new Size(99, 20);
            DoctorName.TabIndex = 3;
            DoctorName.Text = "Doctor Name";
            // 
            // AppointmentTime
            // 
            AppointmentTime.AutoSize = true;
            AppointmentTime.Location = new Point(150, 174);
            AppointmentTime.Name = "AppointmentTime";
            AppointmentTime.Size = new Size(99, 20);
            AppointmentTime.TabIndex = 4;
            AppointmentTime.Text = "Select Timing";
            AppointmentTime.Click += this.label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(150, 210);
            label6.Name = "label6";
            label6.Size = new Size(59, 20);
            label6.TabIndex = 5;
            label6.Text = "Doctor ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(150, 247);
            label7.Name = "label7";
            label7.Size = new Size(50, 20);
            label7.TabIndex = 6;
            label7.Text = "label7";
            // 
            // AppointmentWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(AppointmentTime);
            Controls.Add(DoctorName);
            Controls.Add(label3);
            Controls.Add(PatientName);
            Controls.Add(label1);
            Name = "AppointmentWindow";
            Text = "HMS";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label PatientName;
        private Label label3;
        private Label DoctorName;
        private Label AppointmentTime;
        private Label label6;
        private Label label7;
    }
}