namespace Hotel_Management_System
{
    partial class Designation
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
            CountryID = new Label();
            CountryName = new Label();
            buttonClose = new Button();
            textboxID = new TextBox();
            button2 = new Button();
            textBoxName = new TextBox();
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
            label1.Location = new Point(544, 75);
            label1.Name = "label1";
            label1.Size = new Size(562, 56);
            label1.TabIndex = 12;
            label1.Text = "Designation Information";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(CountryID);
            panel1.Controls.Add(CountryName);
            panel1.Controls.Add(buttonClose);
            panel1.Controls.Add(textboxID);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(textBoxName);
            panel1.Controls.Add(buttonUpdate);
            panel1.Controls.Add(SaveButton);
            panel1.Location = new Point(350, 190);
            panel1.Name = "panel1";
            panel1.Size = new Size(905, 360);
            panel1.TabIndex = 13;
            // 
            // CountryID
            // 
            CountryID.AutoSize = true;
            CountryID.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CountryID.ForeColor = Color.FromArgb(255, 255, 192);
            CountryID.Location = new Point(121, 50);
            CountryID.Name = "CountryID";
            CountryID.Size = new Size(140, 34);
            CountryID.TabIndex = 0;
            CountryID.Text = "District ID";
            // 
            // CountryName
            // 
            CountryName.AutoSize = true;
            CountryName.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CountryName.ForeColor = Color.FromArgb(255, 255, 192);
            CountryName.Location = new Point(121, 150);
            CountryName.Name = "CountryName";
            CountryName.Size = new Size(195, 34);
            CountryName.TabIndex = 1;
            CountryName.Text = "District Name";
            // 
            // buttonClose
            // 
            buttonClose.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonClose.Location = new Point(720, 255);
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
            textboxID.Size = new Size(222, 27);
            textboxID.TabIndex = 2;
            // 
            // button2
            // 
            button2.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(528, 255);
            button2.Name = "button2";
            button2.Size = new Size(113, 48);
            button2.TabIndex = 8;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(383, 150);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(222, 27);
            textBoxName.TabIndex = 3;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonUpdate.Location = new Point(334, 255);
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
            SaveButton.Location = new Point(134, 255);
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
            dataGridView1.Location = new Point(1274, 75);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(350, 856);
            dataGridView1.TabIndex = 14;
            dataGridView1.Visible = false;
            // 
            // Designation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Goldenrod;
            ClientSize = new Size(1378, 770);
            ControlBox = false;
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "Designation";
            Text = "Designation";
            WindowState = FormWindowState.Maximized;
            Load += Designation_Load;
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
        private TextBox textBoxName;
        private Button buttonUpdate;
        private Button SaveButton;
        private DataGridView dataGridView1;
    }
}