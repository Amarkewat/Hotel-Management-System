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

namespace Hotel_Management_System
{
    public partial class District : Form
    {
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Databases\HotelDatabase.mdf;Integrated Security=True;Connect Timeout=30";

        public District()
        {
            InitializeComponent();
            dataGridView1.CellClick += dataGridView1_CellClick;
            LoadLatestDistrictID();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void District_Load(object sender, EventArgs e)
        {
            textBoxName.Focus();
            LoadData();

        }
        private void LoadLatestDistrictID()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT MAX(DistrictID) FROM District;";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    object result = command.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        int latestStateID = Convert.ToInt32(result) + 1; // Increment by 1 to get the next available ID
                        textboxID.Text = latestStateID.ToString();
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
            string districtName = textBoxName.Text.Trim();
            dataGridView1.Refresh();
            dataGridView1.Visible = false;
            if (!string.IsNullOrEmpty(districtName))
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO District (DistrictName) VALUES (@DistrictName); SELECT SCOPE_IDENTITY();";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@DistrictName", districtName);

                        connection.Open();


                        // ExecuteScalar to get the generated ID
                        int districtID = Convert.ToInt32(command.ExecuteScalar());


                        // Display the generated ID in the textbox
                        textboxID.Text = districtID.ToString();
                        textboxID.ReadOnly = true;

                        textboxID.Clear();
                        textBoxName.Clear();





                        MessageBox.Show($"District '{districtName}' added with ID: {districtID}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                // Clear the textbox after saving
                //  textboxID.Clear();
                //  textBoxName.Clear();
            }
            else
            {
                MessageBox.Show("Please enter a district name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadLatestDistrictID();
        }
        // Define a custom class to hold country ID and name
        public class DistrictItem
        {
            public int DistrictID { get; set; }
            public string DistrictName { get; set; }

            public DistrictItem(int id, string name)
            {
                DistrictID = id;
                DistrictName = name;
            }

            public override string ToString()
            {
                return DistrictName;
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {

            string districtName = textBoxName.Text.Trim();
            string updatedColumn1Value = textboxID.Text;
            string updatedColumn2Value = textBoxName.Text;

            dataGridView1.Visible = true;
            if (!string.IsNullOrEmpty(districtName))
            {
                if (dataGridView1.CurrentRow != null)
                {
                    // Update the DataGridView row with the edited data
                    dataGridView1.CurrentRow.Cells["DistrictID"].Value = updatedColumn1Value;
                    dataGridView1.CurrentRow.Cells["DistrictName"].Value = updatedColumn2Value;

                    // Optionally, you can also update your data source if you're using one
                    // dataSource[dataGridView1.CurrentRow.Index].ColumnName1 = updatedColumn1Value;
                    // dataSource[dataGridView1.CurrentRow.Index].ColumnName2 = updatedColumn2Value;
                }
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "UPDATE District SET DistrictName = @DistrictName WHERE DistrictID = @DistrictID;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@DistrictName", districtName);
                        // command.Parameters.AddWithValue("@DistrictID", districtID);

                        connection.Open();

                    }
                }

            }
            else
            {
                MessageBox.Show("Please Select the data for edit", "", MessageBoxButtons.OK);
            }

            textBoxName.Clear();
            LoadLatestDistrictID();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string districtName = textBoxName.Text.Trim();

            if (dataGridView1.CurrentRow != null)
            {
                // Get the unique identifier of the selected row (e.g., primary key)
                int districtID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["DistrictID"].Value);

                // Delete data from the database
                DeleteDataFromDatabase(districtID);

                // Remove the selected row from the DataGridView
                dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            }
            dataGridView1.Visible = true;
            if (!string.IsNullOrEmpty(districtName))
            {





                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "delete from District WHERE DistrictID = @DistrictID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@DistrictName", districtName);
                        // command.Parameters.AddWithValue("@DistrictID", DistrictID);

                        connection.Open();
                        textBoxName.Clear();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select the data for delete", "", MessageBoxButtons.OK);
            }

            LoadLatestDistrictID();
        }
        private void DeleteDataFromDatabase(int District)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "DELETE FROM District WHERE DistrictID = @District";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@District", District);

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
        private void LoadData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // SQL query to retrieve data
                    string query = "SELECT DistrictID, DistrictName  FROM District";

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
                string districtIDValue = selectedRow.Cells["DistrictID"].Value.ToString();
                string districtNameValue = selectedRow.Cells["DistrictName"].Value.ToString();

                // Populate form fields with the selected row's data
                textboxID.Text = districtIDValue;
                textBoxName.Text = districtNameValue;

                // You can continue populating other form fields as needed
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

