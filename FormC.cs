using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics.PerformanceData;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hotel_Management_System
{
    public partial class FormC : Form
    {
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Databases\HotelDatabase.mdf;Integrated Security=True;Connect Timeout=30";
        
        public FormC()
        {
            InitializeComponent();
            dataGridView1.CellClick += dataGridView1_CellClick;
            LoadLatestCountryID();
        }
        


        private void FormC_Load(object sender, EventArgs e)
        {
            textBoxName.Focus();
            LoadData();
           



        }
        private void LoadLatestCountryID()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT MAX(CountryID) FROM Countries;";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    object result = command.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        int latestCountryID = Convert.ToInt32(result) + 1; // Increment by 1 to get the next available ID
                        textboxID.Text = latestCountryID.ToString();
                        textboxID.ReadOnly = true;
                    }
                    else
                    {
                        // If no records found, start from 1
                        textboxID.Text = "1";
                        textboxID.ReadOnly = true;

                    }
                }
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string countryName = textBoxName.Text.Trim();
            dataGridView1.Refresh();
            dataGridView1.Visible = false;
            if (!string.IsNullOrEmpty(countryName))
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO Countries (CountryName) VALUES (@CountryName); SELECT SCOPE_IDENTITY();";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CountryName", countryName);

                        connection.Open();
                        

                        // ExecuteScalar to get the generated ID
                        int countryID = Convert.ToInt32(command.ExecuteScalar());


                        // Display the generated ID in the textbox
                        textboxID.Text = countryID.ToString();
                        textboxID.ReadOnly = true;

                        

                        textboxID.Clear();
                        textBoxName.Clear();
                        
                        
                        


                        MessageBox.Show($"Country '{countryName}' added with ID: {countryID}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                // Clear the textbox after saving
                //  textboxID.Clear();
                //  textBoxName.Clear();
            }
            else
            {
                MessageBox.Show("Please enter a country name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadLatestCountryID();
            
        }



       
        // Define a custom class to hold country ID and name
        public class CountryItem
        {
            public int CountryID { get; set; }
            public string CountryName { get; set; }

            public CountryItem(int id, string name)
            {
                CountryID = id;
                CountryName = name;
            }

            public override string ToString()
            {
                return CountryName;
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)

        {
           
            string countryName = textBoxName.Text.Trim();
            string updatedColumn1Value = textboxID.Text;
            string updatedColumn2Value = textBoxName.Text;

            dataGridView1.Visible = true;
            if (!string.IsNullOrEmpty(countryName))
            {
                if (dataGridView1.CurrentRow != null)
                {
                    // Update the DataGridView row with the edited data
                    dataGridView1.CurrentRow.Cells["CountryID"].Value = updatedColumn1Value;
                    dataGridView1.CurrentRow.Cells["CountryName"].Value = updatedColumn2Value;
                   
                    // Optionally, you can also update your data source if you're using one
                    // dataSource[dataGridView1.CurrentRow.Index].ColumnName1 = updatedColumn1Value;
                    // dataSource[dataGridView1.CurrentRow.Index].ColumnName2 = updatedColumn2Value;
                }
                using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        string query = "UPDATE Countries SET CountryName = @CountryName WHERE CountryID = @CountryID;";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@CountryName", countryName);
                            command.Parameters.AddWithValue("@CountryID", CountryID);

                            connection.Open();
                           
                        }
                    }
               
            }
            else
            {
                MessageBox.Show("Please Select the data for Edit", "", MessageBoxButtons.OK);
            }

            textBoxName.Clear();
            LoadLatestCountryID();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            string countryName = textBoxName.Text.Trim();
           
            if (dataGridView1.CurrentRow != null)
            {
                // Get the unique identifier of the selected row (e.g., primary key)
                int countryID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["CountryID"].Value);

                // Delete data from the database
                DeleteDataFromDatabase(countryID);

                // Remove the selected row from the DataGridView
                dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            }
            dataGridView1.Visible = true;
            if (!string.IsNullOrEmpty(countryName))
            {
               




                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "delete from Countries WHERE CountryID = @CountryID";
                    
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CountryName", countryName);
                        command.Parameters.AddWithValue("@CountryID", CountryID);

                        connection.Open();
                        textBoxName.Clear();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select the data for delete", "", MessageBoxButtons.OK);
            }
           
            LoadLatestCountryID();
        }
        private void DeleteDataFromDatabase(int Countries)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "DELETE FROM Countries WHERE CountryID = @Countries";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Countries", Countries);

                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting data from the database: " + ex.Message);
            }
        }
        private void RefreshDataGridView()
        {
            // Reload data into DataGridView from the database to reflect changes
            // This step depends on how you bind data to your DataGridView
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            FormHome formHome = new FormHome();
            formHome.Show();
            this.Hide();
        }

        private void textboxID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Suppress the default Enter key behavior (newline in TextBox)
                textBoxName.Focus();
                // Move the focus to the password TextBox
            }
        }

        private void textBoxName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Suppress the default Enter key behavior (newline in TextBox)
                SaveButton.Focus();   // Move the focus to the password TextBox
            }
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void CountryID_Click(object sender, EventArgs e)
        {

        }

        private void textboxID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void LoadData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // SQL query to retrieve data
                    string query = "SELECT CountryID, CountryName  FROM Countries";

                    // Create a SqlCommand object
                    SqlCommand command = new SqlCommand(query, connection);

                    // Open the connection
                    connection.Open();

                    // Create a DataTable to hold the data
                    DataTable dataTable = new DataTable();

                    // Create a SqlDataAdapter to execute the query and fill the DataTable
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }

                    // Bind the DataTable to the DataGridView
                    dataGridView1.DataSource = dataTable;

                    // Close the connection
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.Visible = false;
            // Check if the clicked cell is in a valid row
            if (e.RowIndex >= 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                // Retrieve data from the selected row
                string countryIDValue = selectedRow.Cells["CountryID"].Value.ToString();
                string countryNameValue = selectedRow.Cells["CountryName"].Value.ToString();

                // Populate form fields with the selected row's data
                textboxID.Text = countryIDValue;
                textBoxName.Text = countryNameValue;

                // You can continue populating other form fields as needed
            }
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
      

    }
}




