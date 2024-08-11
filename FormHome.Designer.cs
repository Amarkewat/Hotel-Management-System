namespace Hotel_Management_System
{
    partial class FormHome
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
            panel1 = new Panel();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            Employee = new Button();
            Registration = new Button();
            Room = new Button();
            panel2 = new Panel();
            label2 = new Label();
            panel3 = new Panel();
            label1 = new Label();
            panel4 = new Panel();
            label3 = new Label();
            button5 = new Button();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(1652, 39);
            button1.Name = "button1";
            button1.Size = new Size(108, 42);
            button1.TabIndex = 0;
            button1.Text = "Logout";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(Employee);
            panel1.Controls.Add(Registration);
            panel1.Controls.Add(Room);
            panel1.Location = new Point(24, 121);
            panel1.Name = "panel1";
            panel1.Size = new Size(189, 544);
            panel1.TabIndex = 1;
            // 
            // button4
            // 
            button4.BackColor = Color.Teal;
            button4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(14, 470);
            button4.Name = "button4";
            button4.Size = new Size(175, 71);
            button4.TabIndex = 4;
            button4.Text = "Employee";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Teal;
            button3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(11, 285);
            button3.Name = "button3";
            button3.Size = new Size(175, 71);
            button3.TabIndex = 5;
            button3.Text = "City Information";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Teal;
            button2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(14, 195);
            button2.Name = "button2";
            button2.Size = new Size(175, 71);
            button2.TabIndex = 4;
            button2.Text = "District Information";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Employee
            // 
            Employee.BackColor = Color.Teal;
            Employee.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Employee.Location = new Point(14, 378);
            Employee.Name = "Employee";
            Employee.Size = new Size(175, 69);
            Employee.TabIndex = 1;
            Employee.Text = "Customer";
            Employee.UseVisualStyleBackColor = false;
            Employee.Click += Employee_Click;
            // 
            // Registration
            // 
            Registration.BackColor = Color.Teal;
            Registration.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Registration.ForeColor = Color.White;
            Registration.Location = new Point(14, 105);
            Registration.Name = "Registration";
            Registration.Size = new Size(175, 71);
            Registration.TabIndex = 3;
            Registration.Text = "State Information";
            Registration.UseVisualStyleBackColor = false;
            Registration.Click += Registration_Click;
            // 
            // Room
            // 
            Room.BackColor = Color.Teal;
            Room.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Room.ForeColor = SystemColors.ButtonFace;
            Room.Location = new Point(11, 18);
            Room.Name = "Room";
            Room.Size = new Size(175, 71);
            Room.TabIndex = 0;
            Room.Text = "Country Information ";
            Room.UseVisualStyleBackColor = false;
            Room.Click += Room_Click;
            // 
            // panel2
            // 
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 100);
            panel2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(37, 19);
            label2.Name = "label2";
            label2.Size = new Size(736, 27);
            label2.TabIndex = 0;
            label2.Text = "Copyright @ 2024, All Rights Reserved By Perfect Software Solution";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.Controls.Add(label1);
            panel3.Controls.Add(button1);
            panel3.Location = new Point(0, 1);
            panel3.Name = "panel3";
            panel3.Size = new Size(1799, 132);
            panel3.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Yellow;
            label1.Location = new Point(660, 29);
            label1.Name = "label1";
            label1.Size = new Size(469, 81);
            label1.TabIndex = 0;
            label1.Text = "Kohinoor Hotel";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(192, 64, 0);
            panel4.Controls.Add(label3);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 714);
            panel4.Name = "panel4";
            panel4.Size = new Size(1760, 60);
            panel4.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(12, 24);
            label3.Name = "label3";
            label3.Size = new Size(672, 27);
            label3.TabIndex = 0;
            label3.Text = "Copyright @ All Rights Reserved By Perfect Software Solution";
            // 
            // button5
            // 
            button5.BackColor = Color.Teal;
            button5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.White;
            button5.Location = new Point(38, 671);
            button5.Name = "button5";
            button5.Size = new Size(175, 64);
            button5.TabIndex = 6;
            button5.Text = "Designation";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // FormHome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Goldenrod;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1760, 774);
            Controls.Add(button5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormHome";
            Text = "FormHome";
            WindowState = FormWindowState.Maximized;
            Load += FormHome_Load;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Panel panel1;
        private Button Room;
        private Button Employee;
        private Button Registration;
        private Panel panel2;
        private Label label2;
        private Panel panel3;
        private Label label1;
        private Panel panel4;
        private Label label3;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}