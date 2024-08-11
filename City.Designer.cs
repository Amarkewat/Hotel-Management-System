namespace Hotel_Management_System
{
    partial class City
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
            textBox3 = new TextBox();
            textBoxS = new TextBox();
            textBoxD = new TextBox();
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
            label1.Location = new Point(660, 109);
            label1.Name = "label1";
            label1.Size = new Size(383, 56);
            label1.TabIndex = 11;
            label1.Text = "City Information";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(textBoxS);
            panel1.Controls.Add(textBoxD);
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
            panel1.Location = new Point(445, 195);
            panel1.Name = "panel1";
            panel1.Size = new Size(822, 575);
            panel1.TabIndex = 12;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(383, 424);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(171, 27);
            textBox3.TabIndex = 15;
            textBox3.KeyDown += textBox3_KeyDown;
            // 
            // textBoxS
            // 
            textBoxS.Location = new Point(383, 328);
            textBoxS.Name = "textBoxS";
            textBoxS.Size = new Size(171, 27);
            textBoxS.TabIndex = 14;
            textBoxS.KeyDown += textBoxS_KeyDown;
            // 
            // textBoxD
            // 
            textBoxD.Location = new Point(383, 243);
            textBoxD.Name = "textBoxD";
            textBoxD.Size = new Size(171, 27);
            textBoxD.TabIndex = 13;
            textBoxD.KeyDown += textBoxD_KeyDown;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(255, 255, 192);
            label4.Location = new Point(121, 417);
            label4.Name = "label4";
            label4.Size = new Size(213, 34);
            label4.TabIndex = 12;
            label4.Text = "Country Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(255, 255, 192);
            label3.Location = new Point(121, 328);
            label3.Name = "label3";
            label3.Size = new Size(173, 34);
            label3.TabIndex = 11;
            label3.Text = "State Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(255, 255, 192);
            label2.Location = new Point(121, 243);
            label2.Name = "label2";
            label2.Size = new Size(195, 34);
            label2.TabIndex = 10;
            label2.Text = "District Name";
            // 
            // CountryID
            // 
            CountryID.AutoSize = true;
            CountryID.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CountryID.ForeColor = Color.FromArgb(255, 255, 192);
            CountryID.Location = new Point(121, 50);
            CountryID.Name = "CountryID";
            CountryID.Size = new Size(104, 34);
            CountryID.TabIndex = 0;
            CountryID.Text = "City ID";
            // 
            // CountryName
            // 
            CountryName.AutoSize = true;
            CountryName.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CountryName.ForeColor = Color.FromArgb(255, 255, 192);
            CountryName.Location = new Point(121, 150);
            CountryName.Name = "CountryName";
            CountryName.Size = new Size(159, 34);
            CountryName.TabIndex = 1;
            CountryName.Text = "City Name";
            // 
            // buttonClose
            // 
            buttonClose.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonClose.Location = new Point(699, 507);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(113, 48);
            buttonClose.TabIndex = 9;
            buttonClose.Text = "Close";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // textboxID
            // 
            textboxID.Location = new Point(383, 50);
            textboxID.Name = "textboxID";
            textboxID.Size = new Size(171, 27);
            textboxID.TabIndex = 2;
            textboxID.KeyDown += textboxID_KeyDown;
            // 
            // button2
            // 
            button2.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(497, 507);
            button2.Name = "button2";
            button2.Size = new Size(113, 48);
            button2.TabIndex = 8;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBoxNameC
            // 
            textBoxNameC.Location = new Point(383, 150);
            textBoxNameC.Name = "textBoxNameC";
            textBoxNameC.Size = new Size(171, 27);
            textBoxNameC.TabIndex = 3;
            textBoxNameC.KeyDown += textBoxNameC_KeyDown;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonUpdate.Location = new Point(320, 507);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(113, 48);
            buttonUpdate.TabIndex = 7;
            buttonUpdate.Text = "Edit";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // SaveButton
            // 
            SaveButton.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SaveButton.Location = new Point(121, 507);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(113, 48);
            SaveButton.TabIndex = 4;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(1290, 43);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(703, 793);
            dataGridView1.TabIndex = 13;
            dataGridView1.Visible = false;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // City
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Goldenrod;
            ClientSize = new Size(1339, 782);
            ControlBox = false;
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "City";
            Text = "City";
            WindowState = FormWindowState.Maximized;
            Load += City_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label CountryID;
        private Label CountryName;
        private Button buttonClose;
        private TextBox textboxID;
        private Button button2;
        private TextBox textBoxNameC;
        private Button buttonUpdate;
        private Button SaveButton;
        private Label label4;
        private Label label3;
        private Label label2;
        private DataGridView dataGridView1;
        private TextBox textBox3;
        private TextBox textBoxS;
        private TextBox textBoxD;
    }
}