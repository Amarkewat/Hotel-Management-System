using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hotel_Management_System
{
    public partial class Form1 : Form
    {
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Databases\HotelDatabase.mdf;Integrated Security=True;Connect Timeout=30";
        public Form1()
        {
            InitializeComponent();
            Username_Click();
        }

        private void Username_Click()
        {
            try
            {

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("SELECT Username FROM user_table", connection);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        comboBoxUsername.Items.Add("admin");
                        comboBoxUsername.Items.Add("manager");
                        comboBoxUsername.Items.Add("owner");
                        comboBoxUsername.Items.Add("staff");



                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading usernames: " + ex.Message);
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {

            string username = comboBoxUsername.Text;
            string password = textBoxPassword.Text;

            // Implement your authentication logic here
            if (AuthenticateUser(username, password))
            {

                // MessageBox.Show("Login Successful!");
                FormHome formHome = new FormHome();
                formHome.Show();
                this.Hide();

                // Proceed to next steps after successful login
            }
            else
            {
                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                {
                    DialogResult dialogResult = MessageBox.Show("No empty fields allowed", "You cannot continue ", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Username Or Password is incorrect!", "You cannot continue ");
                }
            }


        }

        private bool AuthenticateUser(string username, string password)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM user_table WHERE Username = @Username AND Password = @Password", connection);
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);
                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error authenticating user: " + ex.Message);
                return false;
            }
        }

        private void Password_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxUsername_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //textBoxPassword.Focus();

            comboBoxUsername.Items.Clear();
            
            // Add unique usernames to the ComboBox
            AddUniqueUsername("admin");
            AddUniqueUsername("manager");
            AddUniqueUsername("owner");
            AddUniqueUsername("staff");

            textBoxPassword.Focus();
        }
        private void AddUniqueUsername(string username)
        {
            // Check if the username is already in the ComboBox
            if (!comboBoxUsername.Items.Contains(username))
            {
                // Add the username to the ComboBox
                comboBoxUsername.Items.Add(username);

            }
        }

        private void comboBoxUsername_KeyDown(object sender, KeyEventArgs e)
        {
           if (e.KeyCode == Keys.Enter)
           {
               e.SuppressKeyPress = true; // Suppress the default Enter key behavior (newline in TextBox)
                textBoxPassword.Focus();   // Move the focus to the password TextBox
           }
        }

        private void textBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Suppress the default Enter key behavior (newline in TextBox)
                buttonLogin.Focus();                           // Perform login or any other action here
            }

        }

        private void pictureBoxShow_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxShow, "Show Password");
        }

        private void pictureBoxHide_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxHide, "Hide Password");
        }

        private void pictureBoxShow_Click(object sender, EventArgs e)
        {
            pictureBoxShow.Hide();
            textBoxPassword.UseSystemPasswordChar = false;
            pictureBoxHide.Show();
        }

        private void pictureBoxHide_Click(object sender, EventArgs e)
        {
            pictureBoxHide.Hide();
            textBoxPassword.UseSystemPasswordChar = true;
            pictureBoxShow.Show();
        }
    }
}


