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
    public partial class Employee : Form
    {
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Databases\HotelDatabase.mdf;Integrated Security=True;Connect Timeout=30";

        public Employee()
        {
            InitializeComponent();
            dataGridView1.CellClick += dataGridView1_CellClick;
            LoadLatestEmployeeID();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            FormHome formC = new FormHome();
            formC.Show();
            this.Hide();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void buttonClose_Click_1(object sender, EventArgs e)
        {
            FormHome formC = new FormHome();
            formC.Show();
            this.Hide();
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            textBoxNameC.Focus();
            LoadData();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string employeeName = textBoxNameC.Text.Trim();
            string address = textBoxA.Text.Trim();
            string cityName = textBoxCity.Text.Trim();
            string dateofBirth = DateTImePicker1.Text.Trim();
            string education = textBoxE.Text.Trim();
            string designationName = textBoxDN.Text.Trim();
            string mobileNo = textBoxM.Text.Trim();
            string aadharNo = textBoxG.Text.Trim();
            string remark = textBoxAa.Text.Trim();
            if (dataGridView1.CurrentRow != null)
            {
                // Get the unique identifier of the selected row (e.g., primary key)
                int employeeID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["employeeID"].Value);

                // Delete data from the database
                DeleteDataFromDatabase(employeeID);

                // Remove the selected row from the DataGridView
                dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            }
            dataGridView1.Visible = true;
            if (!string.IsNullOrEmpty(employeeName))
            {





                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "delete from Employee WHERE EmployeeID = @EmployeeID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@EmployeeName", employeeName);
                        command.Parameters.AddWithValue("@Address", address);
                        command.Parameters.AddWithValue("@CityName", cityName);
                        command.Parameters.AddWithValue("@DateofBirth", dateofBirth);
                        command.Parameters.AddWithValue("@Education", education);
                        command.Parameters.AddWithValue("@DesignationName", designationName);
                        command.Parameters.AddWithValue("@MobileNo", mobileNo);
                        command.Parameters.AddWithValue("@AadharNo", aadharNo);
                        command.Parameters.AddWithValue("@Remark", remark);
                        // command.Parameters.AddWithValue("@CityID", cityID);

                        connection.Open();
                        textBoxNameC.Clear();
                        textBoxA.Clear();
                        textBoxCity.Clear();
                        textBoxE.Clear();
                        textBoxDN.Clear();
                        textBoxM.Clear();
                        textBoxG.Clear();
                        textBoxAa.Clear();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select the data for delete ", "", MessageBoxButtons.OK);
            }

            LoadLatestEmployeeID();
        }
        private void DeleteDataFromDatabase(int Employee)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "DELETE FROM Employee WHERE EmployeeID = @Employee";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Employee", Employee);

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

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string employeeName = textBoxNameC.Text.Trim();
            string address = textBoxA.Text.Trim();
            string cityName = textBoxCity.Text.Trim();
            string dateofBirth = DateTImePicker1.Text.Trim();
            string education = textBoxE.Text.Trim();
            string designationName = textBoxDN.Text.Trim();
            string mobileNo = textBoxM.Text.Trim();
            string aadharNo = textBoxG.Text.Trim();
            string remark = textBoxAa.Text.Trim();
            dataGridView1.Refresh();
            dataGridView1.Visible = false;
            if (!string.IsNullOrEmpty(employeeName))
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO Employee (EmployeeName, Address, CityName, DateofBirth, Education, DesignationName, MobileNo, AadharNo, Remark) " +
                                      "VALUES (@EmployeeName, @Address, @CityName, @DateofBirth,  @Education, @DesignationName, @MobileNo, @AadharNo, @Remark);SELECT SCOPE_IDENTITY();";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@EmployeeName", employeeName);
                        command.Parameters.AddWithValue("@Address", address);
                        command.Parameters.AddWithValue("@CityName", cityName);
                        command.Parameters.AddWithValue("@DateofBirth", dateofBirth);
                        command.Parameters.AddWithValue("@Education", education);
                        command.Parameters.AddWithValue("@DesignationName", designationName);
                        command.Parameters.AddWithValue("@MobileNo", mobileNo);
                        command.Parameters.AddWithValue("@AadharNo", aadharNo);
                        command.Parameters.AddWithValue("@Remark", remark);
                        //command.Parameters.AddWithValue("@CityID", cityID);

                        connection.Open();


                        // ExecuteScalar to get the generated ID
                        int employeeID = Convert.ToInt32(command.ExecuteScalar());


                        // Display the generated ID in the textbox
                        textboxID.Text = employeeID.ToString();
                        textboxID.ReadOnly = true;

                        textboxID.Clear();
                        textBoxNameC.Clear();
                        textBoxA.Clear();
                        textBoxCity.Clear();
                        textBoxE.Clear();
                        textBoxDN.Clear();
                        textBoxM.Clear();
                        textBoxG.Clear();
                        textBoxAa.Clear();




                        MessageBox.Show($"Data  added with ID: {employeeID}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            LoadLatestEmployeeID();



        }
        private void LoadLatestEmployeeID()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT MAX(EmployeeID) FROM Employee;";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    object result = command.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        int latestEmployeeID = Convert.ToInt32(result) + 1; // Increment by 1 to get the next available ID
                        textboxID.Text = latestEmployeeID.ToString();
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
        private void LoadData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // SQL query to retrieve data
                    string query = "SELECT EmployeeID, EmployeeName, Address, CityName, DateofBirth, Education, DesignationName, MobileNo, AadharNo, Remark FROM Employee";

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
                string employeeIDValue = selectedRow.Cells["EmployeeID"].Value.ToString();
                string employeeNameValue = selectedRow.Cells["EmployeeName"].Value.ToString();
                string addressValue = selectedRow.Cells["Address"].Value.ToString();
                string cityNameValue = selectedRow.Cells["CityName"].Value.ToString();
                string dateofBirthValue = selectedRow.Cells["DateofBirth"].Value.ToString();
                string educationValue = selectedRow.Cells["Education"].Value.ToString();
                string designationNameValue = selectedRow.Cells["DesignationName"].Value.ToString();
                string MobileNoValue = selectedRow.Cells["MobileNo"].Value.ToString();
                string AadharNoValue = selectedRow.Cells["AadharNo"].Value.ToString();
                string RemarkValue = selectedRow.Cells["Remark"].Value.ToString();
                // Populate form fields with the selected row's data
                textboxID.Text = employeeIDValue;
                textBoxNameC.Text = employeeNameValue;
                textBoxA.Text = addressValue;
                textBoxCity.Text = cityNameValue;
                //DateTimePicker1.Text = dateofBirthValue;
                //textBoxAD.Text = aniversaryDateValue;
                textBoxE.Text = educationValue;
                textBoxDN.Text = designationNameValue;
                textBoxM.Text = MobileNoValue;
                textBoxG.Text = AadharNoValue;
                textBoxAa.Text = RemarkValue;

                // You can continue populating other form fields as needed
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            string employeeName = textBoxNameC.Text.Trim();
            string address = textBoxA.Text.Trim();
            string cityName = textBoxCity.Text.Trim();
            string dateofBirth = DateTImePicker1.Text.Trim();
            string education = textBoxE.Text.Trim();
            string designationName = textBoxDN.Text.Trim();
            string mobileNo = textBoxM.Text.Trim();
            string aadharNo = textBoxG.Text.Trim();
            string remark = textBoxAa.Text.Trim();

            string updatedColumn1Value = textboxID.Text;
            string updatedColumn2Value = textBoxNameC.Text;
            string updatedColumn3Value = textBoxA.Text;
            string updatedColumn4Value = textBoxCity.Text;
            string updatedColumn5Value = DateTImePicker1.Text;
            string updatedColumn6Value = textBoxE.Text;
            string updatedColumn7Value = textBoxDN.Text;
            string updatedColumn8Value = textBoxM.Text;
            string updatedColumn9Value = textBoxG.Text;
            string updatedColumn10Value = textBoxAa.Text;
            dataGridView1.Visible = true;
            if (!string.IsNullOrEmpty(employeeName))
            {
                if (dataGridView1.CurrentRow != null)
                {
                    // Update the DataGridView row with the edited data
                    dataGridView1.CurrentRow.Cells["EmployeeID"].Value = updatedColumn1Value;
                    dataGridView1.CurrentRow.Cells["EmployeeName"].Value = updatedColumn2Value;
                    dataGridView1.CurrentRow.Cells["Address"].Value = updatedColumn3Value;
                    dataGridView1.CurrentRow.Cells["CityName"].Value = updatedColumn4Value;
                    dataGridView1.CurrentRow.Cells["DateOfBirth"].Value = updatedColumn5Value;
                    dataGridView1.CurrentRow.Cells["Education"].Value = updatedColumn6Value;
                    dataGridView1.CurrentRow.Cells["DesignationName"].Value = updatedColumn7Value;
                    dataGridView1.CurrentRow.Cells["MobileNo"].Value = updatedColumn8Value;
                    dataGridView1.CurrentRow.Cells["AadharNo"].Value = updatedColumn9Value;
                    dataGridView1.CurrentRow.Cells["Remark"].Value = updatedColumn10Value;
                    // Optionally, you can also update your data source if you're using one
                    // dataSource[dataGridView1.CurrentRow.Index].ColumnName1 = updatedColumn1Value;
                    // dataSource[dataGridView1.CurrentRow.Index].ColumnName2 = updatedColumn2Value;
                }
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "UPDATE Employee SET EmployeeName = @EmployeeName, Address = @Address, CityName = @CityName, DateofBirth = @DateofBirth, Education = @Education, DesignationName = @DesigationName, MobileNo = @MobileNo, AadharNo = @AadharNo, Remark = @Remark  WHERE EmployeeID = @EmployeeID;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@EmployeeName", employeeName);
                        command.Parameters.AddWithValue("@Address", address);
                        command.Parameters.AddWithValue("@CityName", cityName);
                        command.Parameters.AddWithValue("@DateofBirth", dateofBirth);
                        command.Parameters.AddWithValue("@Education", education);
                        command.Parameters.AddWithValue("@DesignationName", designationName);
                        command.Parameters.AddWithValue("@MobileNo", mobileNo);
                        command.Parameters.AddWithValue("@AadharNo", aadharNo);
                        command.Parameters.AddWithValue("@Remark", remark);
                        //command.Parameters.AddWithValue("@CityID", cityID);

                        connection.Open();

                    }
                }

            }
            else
            {
                MessageBox.Show("Please Select the data for edit", "", MessageBoxButtons.OK);
            }

            textboxID.Clear();
            textBoxNameC.Clear();
            textBoxA.Clear();
            textBoxCity.Clear();

            //comboBoxUsername.Items.Clear();
            textBoxE.Clear();
            textBoxM.Clear();
            textBoxG.Clear();
            textBoxAa.Clear();

            LoadLatestEmployeeID();



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
                textBoxA.Focus();   // Move the focus to the password TextBox
            }
        }

        private void textBoxA_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Suppress the default Enter key behavior (newline in TextBox)
                textBoxCity.Focus();   // Move the focus to the password TextBox
            }
        }

        private void textBoxCity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Suppress the default Enter key behavior (newline in TextBox)
                DateTImePicker1.Focus();   // Move the focus to the password TextBox
            }
        }

        private void DateTImePicker1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Suppress the default Enter key behavior (newline in TextBox)
                textBoxE.Focus();   // Move the focus to the password TextBox
            }
        }

        private void textBoxE_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Suppress the default Enter key behavior (newline in TextBox)
                textBoxDN.Focus();   // Move the focus to the password TextBox
            }
        }

        private void textBoxDN_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Suppress the default Enter key behavior (newline in TextBox)
                textBoxM.Focus();   // Move the focus to the password TextBox
            }
        }

        private void textBoxM_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Suppress the default Enter key behavior (newline in TextBox)
                textBoxG.Focus();   // Move the focus to the password TextBox
            }
        }

        private void textBoxG_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxAa_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxG_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Suppress the default Enter key behavior (newline in TextBox)
                textBoxAa.Focus();   // Move the focus to the password TextBox
            }
        }

        private void textBoxAa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Suppress the default Enter key behavior (newline in TextBox)
                SaveButton.Focus();   // Move the focus to the password TextBox
            }
        }
    }
}
