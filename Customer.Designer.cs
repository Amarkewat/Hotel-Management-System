namespace Hotel_Management_System
{
    partial class Customer
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
            panel1 = new Panel();
            comboBoxUsername = new ComboBox();
            AD = new DateTimePicker();
            DateTImePicker1 = new DateTimePicker();
            label12 = new Label();
            label13 = new Label();
            textBoxR = new TextBox();
            textBoxM = new TextBox();
            textBoxW = new TextBox();
            textBoxCT = new TextBox();
            label11 = new Label();
            label9 = new Label();
            label8 = new Label();
            textBoxCity = new TextBox();
            textBox2 = new TextBox();
            textBoxG = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            textBoxAa = new TextBox();
            textBoxS = new TextBox();
            textBoxA = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            CountryID = new Label();
            CountryName = new Label();
            buttonClose = new Button();
            textboxID = new TextBox();
            button2 = new Button();
            textBoxNameC = new TextBox();
            buttonUpdate = new Button();
            SaveButton = new Button();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(724, 19);
            label1.Name = "label1";
            label1.Size = new Size(513, 56);
            label1.TabIndex = 12;
            label1.Text = "Customer Information";
            label1.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(comboBoxUsername);
            panel1.Controls.Add(AD);
            panel1.Controls.Add(DateTImePicker1);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(textBoxR);
            panel1.Controls.Add(textBoxM);
            panel1.Controls.Add(textBoxW);
            panel1.Controls.Add(textBoxCT);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(textBoxCity);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBoxG);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(textBoxAa);
            panel1.Controls.Add(textBoxS);
            panel1.Controls.Add(textBoxA);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(CountryID);
            panel1.Controls.Add(CountryName);
            panel1.Controls.Add(buttonClose);
            panel1.Controls.Add(textboxID);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(textBoxNameC);
            panel1.Controls.Add(buttonUpdate);
            panel1.Controls.Add(SaveButton);
            panel1.ForeColor = Color.FromArgb(255, 128, 0);
            panel1.Location = new Point(312, 91);
            panel1.Name = "panel1";
            panel1.Size = new Size(1233, 606);
            panel1.TabIndex = 13;
            panel1.Paint += panel1_Paint;
            // 
            // comboBoxUsername
            // 
            comboBoxUsername.Cursor = Cursors.Hand;
            comboBoxUsername.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxUsername.Font = new Font("Segoe UI", 9F);
            comboBoxUsername.FormattingEnabled = true;
            comboBoxUsername.Items.AddRange(new object[] { "admin", "manager", "owner" });
            comboBoxUsername.Location = new Point(963, 49);
            comboBoxUsername.Name = "comboBoxUsername";
            comboBoxUsername.Size = new Size(244, 28);
            comboBoxUsername.TabIndex = 33;
            comboBoxUsername.SelectedIndexChanged += comboBoxUsername_SelectedIndexChanged;
            comboBoxUsername.KeyDown += comboBoxUsername_KeyDown;
            // 
            // AD
            // 
            AD.Location = new Point(383, 475);
            AD.Name = "AD";
            AD.Size = new Size(250, 27);
            AD.TabIndex = 32;
            AD.KeyDown += AD_KeyDown;
            // 
            // DateTImePicker1
            // 
            DateTImePicker1.Location = new Point(383, 386);
            DateTImePicker1.Name = "DateTImePicker1";
            DateTImePicker1.Size = new Size(250, 27);
            DateTImePicker1.TabIndex = 31;
            DateTImePicker1.KeyDown += DateTImePicker1_KeyDown;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.FromArgb(255, 128, 0);
            label12.Location = new Point(741, 386);
            label12.Name = "label12";
            label12.Size = new Size(183, 34);
            label12.TabIndex = 30;
            label12.Text = "Aadhar No *";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.FromArgb(255, 128, 0);
            label13.Location = new Point(117, 304);
            label13.Name = "label13";
            label13.Size = new Size(179, 34);
            label13.TabIndex = 25;
            label13.Text = "City Name *";
            // 
            // textBoxR
            // 
            textBoxR.Location = new Point(963, 475);
            textBoxR.Name = "textBoxR";
            textBoxR.Size = new Size(244, 27);
            textBoxR.TabIndex = 29;
            textBoxR.KeyDown += textBoxR_KeyDown;
            // 
            // textBoxM
            // 
            textBoxM.Location = new Point(963, 219);
            textBoxM.Name = "textBoxM";
            textBoxM.Size = new Size(244, 27);
            textBoxM.TabIndex = 28;
            textBoxM.KeyDown += textBoxM_KeyDown;
            // 
            // textBoxW
            // 
            textBoxW.Location = new Point(963, 136);
            textBoxW.Name = "textBoxW";
            textBoxW.Size = new Size(244, 27);
            textBoxW.TabIndex = 27;
            textBoxW.KeyDown += textBoxW_KeyDown;
            // 
            // textBoxCT
            // 
            textBoxCT.Location = new Point(963, 50);
            textBoxCT.Name = "textBoxCT";
            textBoxCT.Size = new Size(244, 27);
            textBoxCT.TabIndex = 26;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.FromArgb(255, 128, 0);
            label11.Location = new Point(701, 50);
            label11.Name = "label11";
            label11.Size = new Size(237, 34);
            label11.TabIndex = 25;
            label11.Text = "Customer Type *";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(255, 128, 0);
            label9.Location = new Point(722, 136);
            label9.Name = "label9";
            label9.Size = new Size(216, 34);
            label9.TabIndex = 23;
            label9.Text = "Whatsapp No *";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(255, 128, 0);
            label8.Location = new Point(117, 386);
            label8.Name = "label8";
            label8.Size = new Size(198, 34);
            label8.TabIndex = 22;
            label8.Text = "Date of Birth *";
            label8.Click += label8_Click;
            // 
            // textBoxCity
            // 
            textBoxCity.Location = new Point(383, 304);
            textBoxCity.Name = "textBoxCity";
            textBoxCity.Size = new Size(244, 27);
            textBoxCity.TabIndex = 21;
            textBoxCity.KeyDown += textBoxCity_KeyDown;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(383, 475);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(244, 27);
            textBox2.TabIndex = 20;
            // 
            // textBoxG
            // 
            textBoxG.Location = new Point(963, 304);
            textBoxG.Name = "textBoxG";
            textBoxG.Size = new Size(244, 27);
            textBoxG.TabIndex = 19;
            textBoxG.KeyDown += textBoxG_KeyDown;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(255, 255, 128);
            label7.Location = new Point(749, 468);
            label7.Name = "label7";
            label7.Size = new Size(118, 34);
            label7.TabIndex = 18;
            label7.Text = "Remark";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(255, 255, 128);
            label6.Location = new Point(749, 304);
            label6.Name = "label6";
            label6.Size = new Size(113, 34);
            label6.TabIndex = 17;
            label6.Text = "GST No";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(255, 255, 192);
            label5.Location = new Point(124, 512);
            label5.Name = "label5";
            label5.Size = new Size(0, 34);
            label5.TabIndex = 16;
            // 
            // textBoxAa
            // 
            textBoxAa.Location = new Point(963, 386);
            textBoxAa.Name = "textBoxAa";
            textBoxAa.Size = new Size(244, 27);
            textBoxAa.TabIndex = 15;
            textBoxAa.KeyDown += textBoxAa_KeyDown;
            // 
            // textBoxS
            // 
            textBoxS.Location = new Point(383, 386);
            textBoxS.Name = "textBoxS";
            textBoxS.Size = new Size(244, 27);
            textBoxS.TabIndex = 14;
            // 
            // textBoxA
            // 
            textBoxA.Location = new Point(383, 219);
            textBoxA.Name = "textBoxA";
            textBoxA.Size = new Size(244, 27);
            textBoxA.TabIndex = 13;
            textBoxA.KeyDown += textBoxA_KeyDown;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(255, 128, 255);
            label4.Location = new Point(667, 219);
            label4.Name = "label4";
            label4.Size = new Size(287, 34);
            label4.TabIndex = 12;
            label4.Text = "Alternate Mobile No";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(255, 128, 255);
            label3.Location = new Point(112, 478);
            label3.Name = "label3";
            label3.Size = new Size(230, 34);
            label3.TabIndex = 11;
            label3.Text = "Aniversary Date";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(255, 128, 0);
            label2.Location = new Point(120, 219);
            label2.Name = "label2";
            label2.Size = new Size(143, 34);
            label2.TabIndex = 10;
            label2.Text = "Address *";
            label2.Click += label2_Click;
            // 
            // CountryID
            // 
            CountryID.AutoSize = true;
            CountryID.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CountryID.ForeColor = Color.White;
            CountryID.Location = new Point(117, 50);
            CountryID.Name = "CountryID";
            CountryID.Size = new Size(181, 34);
            CountryID.TabIndex = 0;
            CountryID.Text = "Customer ID";
            // 
            // CountryName
            // 
            CountryName.AutoSize = true;
            CountryName.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CountryName.ForeColor = Color.FromArgb(255, 128, 0);
            CountryName.Location = new Point(112, 143);
            CountryName.Name = "CountryName";
            CountryName.Size = new Size(256, 34);
            CountryName.TabIndex = 1;
            CountryName.Text = "Customer Name *";
            // 
            // buttonClose
            // 
            buttonClose.BackColor = Color.White;
            buttonClose.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonClose.ForeColor = Color.Black;
            buttonClose.Location = new Point(845, 543);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(113, 48);
            buttonClose.TabIndex = 9;
            buttonClose.Text = "Close";
            buttonClose.UseVisualStyleBackColor = false;
            buttonClose.Click += buttonClose_Click;
            // 
            // textboxID
            // 
            textboxID.Location = new Point(383, 50);
            textboxID.Name = "textboxID";
            textboxID.Size = new Size(244, 27);
            textboxID.TabIndex = 2;
            textboxID.KeyDown += textboxID_KeyDown;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(667, 543);
            button2.Name = "button2";
            button2.Size = new Size(113, 48);
            button2.TabIndex = 8;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // textBoxNameC
            // 
            textBoxNameC.Location = new Point(383, 143);
            textBoxNameC.Name = "textBoxNameC";
            textBoxNameC.Size = new Size(244, 27);
            textBoxNameC.TabIndex = 3;
            textBoxNameC.KeyDown += textBoxNameC_KeyDown;
            // 
            // buttonUpdate
            // 
            buttonUpdate.BackColor = Color.White;
            buttonUpdate.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonUpdate.ForeColor = Color.Black;
            buttonUpdate.Location = new Point(496, 543);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(113, 48);
            buttonUpdate.TabIndex = 7;
            buttonUpdate.Text = "Edit";
            buttonUpdate.UseVisualStyleBackColor = false;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // SaveButton
            // 
            SaveButton.BackColor = Color.White;
            SaveButton.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SaveButton.ForeColor = Color.Black;
            SaveButton.Location = new Point(309, 543);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(113, 48);
            SaveButton.TabIndex = 4;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = false;
            SaveButton.Click += SaveButton_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(160, 703);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 70;
            dataGridView1.Size = new Size(1612, 373);
            dataGridView1.TabIndex = 14;
            dataGridView1.Visible = false;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Customer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Goldenrod;
            ClientSize = new Size(1345, 1014);
            ControlBox = false;
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "Customer";
            Text = "Customer";
            WindowState = FormWindowState.Maximized;
            Load += Customer_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private TextBox textBoxAa;
        private TextBox textBoxS;
        private TextBox textBoxA;
        private Label label3;
        private Label label2;
        private Label CountryID;
        private Label CountryName;
        private Button buttonClose;
        private TextBox textboxID;
        private Button button2;
        private TextBox textBoxNameC;
        private Button buttonUpdate;
        private Button SaveButton;
        private Label label4;
        private Label label8;
        private TextBox textBoxCity;
        private TextBox textBox2;
        private TextBox textBoxG;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label9;
        private Label label12;
        private TextBox textBoxR;
        private TextBox textBoxM;
        private TextBox textBoxW;
        private TextBox textBoxCT;
        private Label label11;
        private Label label13;
        private DateTimePicker DateTImePicker1;
        private DateTimePicker AD;
        private DataGridView dataGridView1;
        private ComboBox comboBoxUsername;
    }
}