using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management_System
{
    public partial class City : Form
    {
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Databases\HotelDatabase.mdf;Integrated Security=True;Connect Timeout=30";

        public City()
        {
            InitializeComponent();
            dataGridView1.CellClick += dataGridView1_CellClick;
            LoadLatestCityID();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string cityName = textBoxNameC.Text.Trim();
            string districtName = textBoxD.Text.Trim();
            string stateName = textBoxS.Text.Trim();
            string countryName = textBox3.Text.Trim();

            if (dataGridView1.CurrentRow != null)
            {
                // Get the unique identifier of the selected row (e.g., primary key)
                int cityID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["cityID"].Value);

                // Delete data from the database
                DeleteDataFromDatabase(cityID);

                // Remove the selected row from the DataGridView
                dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            }
            dataGridView1.Visible = true;
            if (!string.IsNullOrEmpty(cityName))
            {





                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "delete from City WHERE CityID = @CityID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CityName", cityName);
                        command.Parameters.AddWithValue("@DistrictName", districtName);
                        command.Parameters.AddWithValue("@StateName", stateName);
                        command.Parameters.AddWithValue("@CountryName", countryName);
                        // command.Parameters.AddWithValue("@CityID", cityID);

                        connection.Open();
                        textBoxNameC.Clear();
                        textBoxD.Clear();
                        textBoxS.Clear();
                        textBox3.Clear();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select the data for delete ", "", MessageBoxButtons.OK);
            }

            LoadLatestCityID();

        }
        private void DeleteDataFromDatabase(int City)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "DELETE FROM City WHERE CityID = @city";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@City", City);

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


        private void City_Load(object sender, EventArgs e)
        {
            textBoxNameC.Focus();
            LoadData();
        }


        private void SaveButton_Click(object sender, EventArgs e)
        {

            string cityName = textBoxNameC.Text.Trim();
            string districtName = textBoxD.Text.Trim();
            string stateName = textBoxS.Text.Trim();
            string countryName = textBox3.Text.Trim();
            dataGridView1.Refresh();
            dataGridView1.Visible = false;
            if (!string.IsNullOrEmpty(cityName))
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO City (CityName, DistrictName, StateName, CountryName) " +
                                      "VALUES (@CityName, @DistrictName, @StateName, @CountryName);SELECT SCOPE_IDENTITY();";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CityName", cityName);
                        command.Parameters.AddWithValue("@DistrictName", districtName);
                        command.Parameters.AddWithValue("@StateName", stateName);
                        command.Parameters.AddWithValue("@CountryName", countryName);
                        //command.Parameters.AddWithValue("@CityID", cityID);

                        connection.Open();


                        // ExecuteScalar to get the generated ID
                        int cityID = Convert.ToInt32(command.ExecuteScalar());


                        // Display the generated ID in the textbox
                        textboxID.Text = cityID.ToString();
                        textboxID.ReadOnly = true;

                        textboxID.Clear();
                        textBoxNameC.Clear();
                        textBoxD.Clear();
                        textBoxS.Clear();
                        textBox3.Clear();




                        MessageBox.Show($"Data  added with ID: {cityID}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                // Clear the textbox after saving
                //  textboxID.Clear();
                //  textBoxName.Clear();
            }
            else
            {
                MessageBox.Show("Please Fill the all Fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadLatestCityID();



        }
        private void LoadLatestCityID()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT MAX(CityID) FROM City;";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    object result = command.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        int latestCityID = Convert.ToInt32(result) + 1; // Increment by 1 to get the next available ID
                        textboxID.Text = latestCityID.ToString();
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

        private void buttonUpdate_Click(object sender, EventArgs e)
        {

            string cityName = textBoxNameC.Text.Trim();
            string districtName = textBoxD.Text.Trim();
            string stateName = textBoxS.Text.Trim();
            string countryName = textBox3.Text.Trim();

            string updatedColumn1Value = textboxID.Text;
            string updatedColumn2Value = textBoxNameC.Text;
            string updatedColumn3Value = textBoxD.Text;
            string updatedColumn4Value = textBoxS.Text;
            string updatedColumn5Value = textBox3.Text;

            dataGridView1.Visible = true;
            if (!string.IsNullOrEmpty(cityName))
            {
                if (dataGridView1.CurrentRow != null)
                {
                    // Update the DataGridView row with the edited data
                    dataGridView1.CurrentRow.Cells["CityID"].Value = updatedColumn1Value;
                    dataGridView1.CurrentRow.Cells["CityName"].Value = updatedColumn2Value;
                    dataGridView1.CurrentRow.Cells["DistrictName"].Value = updatedColumn3Value;
                    dataGridView1.CurrentRow.Cells["StateName"].Value = updatedColumn4Value;
                    dataGridView1.CurrentRow.Cells["CountryName"].Value = updatedColumn5Value;
                    // Optionally, you can also update your data source if you're using one
                    // dataSource[dataGridView1.CurrentRow.Index].ColumnName1 = updatedColumn1Value;
                    // dataSource[dataGridView1.CurrentRow.Index].ColumnName2 = updatedColumn2Value;
                }
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "UPDATE City SET CityName = @CityName, DistrictName = @DistrictName, StateName = @StateName, CountryName = @CountryName  WHERE CityID = @CityID;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CityName", cityName);
                        command.Parameters.AddWithValue("@DistrictName", districtName);
                        command.Parameters.AddWithValue("@StateName", stateName);
                        command.Parameters.AddWithValue("@CountryName", countryName);
                        //command.Parameters.AddWithValue("@CityID", cityID);

                        connection.Open();

                    }
                }

            }
            else
            {
                MessageBox.Show("Please Select the data for edit", "", MessageBoxButtons.OK);
            }

            textBoxNameC.Clear();
            textBoxD.Clear();
            textBoxS.Clear();
            textBox3.Clear();

            LoadLatestCityID();




        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            FormHome formHome = new FormHome();
            formHome.Show();
            this.Hide();
        }

        private void LoadData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // SQL query to retrieve data
                    string query = "SELECT CityID, CityName, DistrictName, StateName, CountryName  FROM City";

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
                string cityIDValue = selectedRow.Cells["CityID"].Value.ToString();
                string cityNameValue = selectedRow.Cells["CityName"].Value.ToString();
                string districtNameValue = selectedRow.Cells["DistrictName"].Value.ToString();
                string stateNameValue = selectedRow.Cells["StateName"].Value.ToString();
                string countryNameValue = selectedRow.Cells["CountryName"].Value.ToString();

                // Populate form fields with the selected row's data
                textboxID.Text = cityIDValue;
                textBoxNameC.Text = cityNameValue;
                textBoxD.Text = districtNameValue;
                textBoxS.Text = stateNameValue;
                textBox3.Text = countryNameValue;

                // You can continue populating other form fields as needed
            }
        }
        public class CityItem
        {
            public int CityID { get; set; }
            public string CityName { get; set; }
            public string DistrictName { get; set; }
            public string StateName { get; set; }
            public string CountryName { get; set; }
            public CityItem(int id, string name)
            {
                CityID = id;
                CityName = name;
                DistrictName = name;
                StateName = name;
                CountryName = name;
            }

            public override string ToString()
            {
                return CityName;
                return DistrictName;
                return StateName;
                return CountryName;
            }
        }

        private void textboxID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Suppress the default Enter key behavior (newline in TextBox)
                textBoxNameC.Focus();   // Move the focus to the password TextBox
            }
        }

        private void textBoxNameC_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Suppress the default Enter key behavior (newline in TextBox)
                textBoxD.Focus();   // Move the focus to the password TextBox
            }
        }

        private void textBoxD_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Suppress the default Enter key behavior (newline in TextBox)
                textBoxS.Focus();   // Move the focus to the password TextBox
            }
        }

        private void textBoxS_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Suppress the default Enter key behavior (newline in TextBox)
                textBox3.Focus();   // Move the focus to the password TextBox
            }
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Suppress the default Enter key behavior (newline in TextBox)
                SaveButton.Focus();   // Move the focus to the password TextBox
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
