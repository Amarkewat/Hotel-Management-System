namespace Hotel_Management_System
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            comboBoxUsername = new ComboBox();
            Password = new Label();
            textBoxPassword = new TextBox();
            buttonLogin = new Button();
            panel1 = new Panel();
            pictureBoxShow = new PictureBox();
            label1 = new Label();
            Username = new Label();
            pictureBoxHide = new PictureBox();
            label2 = new Label();
            toolTip1 = new ToolTip(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxShow).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHide).BeginInit();
            SuspendLayout();
            // 
            // comboBoxUsername
            // 
            comboBoxUsername.Cursor = Cursors.Hand;
            comboBoxUsername.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxUsername.Font = new Font("Segoe UI", 9F);
            comboBoxUsername.FormattingEnabled = true;
            comboBoxUsername.Items.AddRange(new object[] { "admin", "manager", "owner" });
            comboBoxUsername.Location = new Point(238, 72);
            comboBoxUsername.Name = "comboBoxUsername";
            comboBoxUsername.Size = new Size(277, 28);
            comboBoxUsername.TabIndex = 2;
            comboBoxUsername.SelectedIndexChanged += comboBoxUsername_SelectedIndexChanged;
            comboBoxUsername.KeyDown += comboBoxUsername_KeyDown;
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Password.ForeColor = Color.FromArgb(255, 255, 192);
            Password.Location = new Point(64, 168);
            Password.Name = "Password";
            Password.Size = new Size(168, 34);
            Password.TabIndex = 1;
            Password.Text = "Password :-";
            Password.Click += Password_Click;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(238, 175);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(246, 27);
            textBoxPassword.TabIndex = 3;
            textBoxPassword.UseSystemPasswordChar = true;
            textBoxPassword.KeyDown += textBoxPassword_KeyDown;
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = Color.Black;
            buttonLogin.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonLogin.ForeColor = Color.White;
            buttonLogin.Location = new Point(238, 265);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(277, 39);
            buttonLogin.TabIndex = 4;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(pictureBoxShow);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(Username);
            panel1.Controls.Add(comboBoxUsername);
            panel1.Controls.Add(buttonLogin);
            panel1.Controls.Add(textBoxPassword);
            panel1.Controls.Add(Password);
            panel1.Controls.Add(pictureBoxHide);
            panel1.Location = new Point(311, 159);
            panel1.Name = "panel1";
            panel1.Size = new Size(570, 408);
            panel1.TabIndex = 5;
            // 
            // pictureBoxShow
            // 
            pictureBoxShow.BackColor = Color.White;
            pictureBoxShow.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxShow.Cursor = Cursors.Hand;
            pictureBoxShow.Image = (Image)resources.GetObject("pictureBoxShow.Image");
            pictureBoxShow.Location = new Point(481, 175);
            pictureBoxShow.Name = "pictureBoxShow";
            pictureBoxShow.Size = new Size(34, 27);
            pictureBoxShow.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxShow.TabIndex = 7;
            pictureBoxShow.TabStop = false;
            pictureBoxShow.Click += pictureBoxShow_Click;
            pictureBoxShow.MouseHover += pictureBoxShow_MouseHover;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(154, 0);
            label1.Name = "label1";
            label1.Size = new Size(251, 23);
            label1.TabIndex = 6;
            label1.Text = "Please Login to Continue";
            // 
            // Username
            // 
            Username.AutoSize = true;
            Username.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Username.ForeColor = Color.FromArgb(255, 255, 192);
            Username.Location = new Point(53, 65);
            Username.Name = "Username";
            Username.Size = new Size(179, 34);
            Username.TabIndex = 5;
            Username.Text = "Username :-";
            // 
            // pictureBoxHide
            // 
            pictureBoxHide.BackColor = Color.White;
            pictureBoxHide.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxHide.Cursor = Cursors.Hand;
            pictureBoxHide.Image = (Image)resources.GetObject("pictureBoxHide.Image");
            pictureBoxHide.Location = new Point(481, 175);
            pictureBoxHide.Name = "pictureBoxHide";
            pictureBoxHide.Size = new Size(34, 27);
            pictureBoxHide.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxHide.TabIndex = 8;
            pictureBoxHide.TabStop = false;
            pictureBoxHide.Click += pictureBoxHide_Click;
            pictureBoxHide.MouseHover += pictureBoxHide_MouseHover;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Century Gothic", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(173, 46);
            label2.Name = "label2";
            label2.Size = new Size(864, 51);
            label2.TabIndex = 7;
            label2.Text = "Welcome to Hotel Management System";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Goldenrod;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1186, 688);
            ControlBox = false;
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Hotel Management System";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxShow).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHide).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxUsername;
        private Label Password;
        private TextBox textBoxPassword;
        private Button buttonLogin;
        private Panel panel1;
        private Label Username;
        private Label label1;
        private Label label2;
        private PictureBox pictureBoxShow;
        private PictureBox pictureBoxHide;
        private ToolTip toolTip1;
    }
}