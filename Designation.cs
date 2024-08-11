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
    public partial class Designation : Form
    {
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Databases\HotelDatabase.mdf;Integrated Security=True;Connect Timeout=30";

        public Designation()
        {
            InitializeComponent();
            dataGridView1.CellClick += dataGridView1_CellClick;
            LoadLatestDesignationID();
        }

        private void Designation_Load(object sender, EventArgs e)
        {
            textBoxName.Focus();
            LoadData();
        }
        private void LoadLatestDesignationID()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT MAX(DesignationID) FROM Designation;";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    object result = command.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        int latestDesignationID = Convert.ToInt32(result) + 1; // Increment by 1 to get the next available ID
                        textboxID.Text = latestDesignationID.ToString();
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
            string designationName = textBoxName.Text.Trim();
            dataGridView1.Refresh();
            dataGridView1.Visible = false;
            if (!string.IsNullOrEmpty(designationName))
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO Designation (DesignationName) VALUES (@DesignationName); SELECT SCOPE_IDENTITY();";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@DesignationName", designationName);

                        connection.Open();


                        // ExecuteScalar to get the generated ID
                        int designationID = Convert.ToInt32(command.ExecuteScalar());


                        // Display the generated ID in the textbox
                        textboxID.Text = designationID.ToString();
                        textboxID.ReadOnly = true;

                        textboxID.Clear();
                        textBoxName.Clear();





                        MessageBox.Show($"Data are added with ID: {designationID}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                // Clear the textbox after saving
                //  textboxID.Clear();
                //  textBoxName.Clear();
            }
            else
            {
                MessageBox.Show("Please enter a designation name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadLatestDesignationID();
        }
        public class DesignationItem
        {
            public int DesignationID { get; set; }
            public string DesignationName { get; set; }

            public DesignationItem(int id, string name)
            {
                DesignationID = id;
                DesignationName = name;
            }

            public override string ToString()
            {
                return DesignationName;
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            string designationName = textBoxName.Text.Trim();
            string updatedColumn1Value = textboxID.Text;
            string updatedColumn2Value = textBoxName.Text;

            dataGridView1.Visible = true;
            if (!string.IsNullOrEmpty(designationName))
            {
                if (dataGridView1.CurrentRow != null)
                {
                    // Update the DataGridView row with the edited data
                    dataGridView1.CurrentRow.Cells["DesignationID"].Value = updatedColumn1Value;
                    dataGridView1.CurrentRow.Cells["DesignationName"].Value = updatedColumn2Value;

                    // Optionally, you can also update your data source if you're using one
                    // dataSource[dataGridView1.CurrentRow.Index].ColumnName1 = updatedColumn1Value;
                    // dataSource[dataGridView1.CurrentRow.Index].ColumnName2 = updatedColumn2Value;
                }
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "UPDATE Designation SET DesignationName = @DesignationName WHERE DesignationID = @DesignationID;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@DesignationName", designationName);
                        // command.Parameters.AddWithValue("@StateID", StateID);

                        connection.Open();

                    }
                }

            }
            else
            {
                MessageBox.Show("Please Select the data for edit", "", MessageBoxButtons.OK);
            }

            textBoxName.Clear();
            LoadLatestDesignationID();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string designationName = textBoxName.Text.Trim();

            if (dataGridView1.CurrentRow != null)
            {
                // Get the unique identifier of the selected row (e.g., primary key)
                int DesignationID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["DesignationID"].Value);

                // Delete data from the database
                DeleteDataFromDatabase(DesignationID);

                // Remove the selected row from the DataGridView
                dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            }
            dataGridView1.Visible = true;
            if (!string.IsNullOrEmpty(designationName))
            {





                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "delete from Designation WHERE DesignationID = @DesignationID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@DesignationName", designationName);
                        // command.Parameters.AddWithValue("@StateID", StateID);

                        connection.Open();
                        textBoxName.Clear();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please Select the data for delete", "", MessageBoxButtons.OK);
            }

            LoadLatestDesignationID();
        }
        private void DeleteDataFromDatabase(int Designation)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "DELETE FROM Designation WHERE DesignationID = @Designation";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Designation", Designation);

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
        private void LoadData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // SQL query to retrieve data
                    string query = "SELECT DesignationID, DesignationName  FROM Designation";

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
                string designationIDValue = selectedRow.Cells["DesignationID"].Value.ToString();
                string designationNameValue = selectedRow.Cells["DesignationName"].Value.ToString();

                // Populate form fields with the selected row's data
                textboxID.Text = designationIDValue;
                textBoxName.Text = designationNameValue;

                // You can continue populating other form fields as needed
            }
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
    }
}
