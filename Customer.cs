using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hotel_Management_System
{
    public partial class Customer : Form
    {
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Databases\HotelDatabase.mdf;Integrated Security=True;Connect Timeout=30";

        public Customer()
        {
            InitializeComponent();
            dataGridView1.CellClick += dataGridView1_CellClick;
            LoadLatestCustomerID();
        }


        private void button2_Click(object sender, EventArgs e)
        {


            string customerName = textBoxNameC.Text.Trim();
            string address = textBoxA.Text.Trim();
            string cityName = textBoxS.Text.Trim();
            string dateofBirth = textBoxAa.Text.Trim();
            string aniversaryDate = textBoxS.Text.Trim();
            string CustomerType = comboBoxUsername.Text.Trim();
            string whatsappNo = textBoxS.Text.Trim();
            string alternateNo = textBoxS.Text.Trim();
            string gstNo = textBoxS.Text.Trim();
            string aadharNo = textBoxS.Text.Trim();
            string remark = textBoxS.Text.Trim();
            if (dataGridView1.CurrentRow != null)
            {
                // Get the unique identifier of the selected row (e.g., primary key)
                int customerID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["customerID"].Value);

                // Delete data from the database
                DeleteDataFromDatabase(customerID);

                // Remove the selected row from the DataGridView
                dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            }
            dataGridView1.Visible = true;
            if (!string.IsNullOrEmpty(customerName))
            {





                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "delete from Customer WHERE CustomerID = @CustomerID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CustomerName", customerName);
                        command.Parameters.AddWithValue("@Address", address);
                        command.Parameters.AddWithValue("@CityName", cityName);
                        command.Parameters.AddWithValue("@DateofBirth", dateofBirth);
                        command.Parameters.AddWithValue("@AniversaryDate", aniversaryDate);
                        command.Parameters.AddWithValue("@CustomerType", CustomerType);
                        command.Parameters.AddWithValue("@WhatsappNo", whatsappNo);
                        command.Parameters.AddWithValue("@AlternateNo", alternateNo);
                        command.Parameters.AddWithValue("@GstNo", gstNo);
                        command.Parameters.AddWithValue("@AadharNo", aadharNo);
                        command.Parameters.AddWithValue("@Remark", remark);
                        // command.Parameters.AddWithValue("@CityID", cityID);

                        connection.Open();
                        textBoxNameC.Clear();
                        textBoxA.Clear();
                        textBoxCity.Clear();
                        comboBoxUsername.Items.Clear();
                        textBoxW.Clear();
                        textBoxM.Clear();
                        textBoxG.Clear();
                        textBoxAa.Clear();
                        textBoxR.Clear();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select the data for delete ", "", MessageBoxButtons.OK);
            }

            LoadLatestCustomerID();

        }
        private void DeleteDataFromDatabase(int Customer)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "DELETE FROM Customer WHERE CustomerID = @Customer";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Customer", Customer);

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



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            FormHome formC = new FormHome();
            formC.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Customer_Load(object sender, EventArgs e)
        {
            textBoxNameC.Focus();
            LoadData();


            //textBoxPassword.Focus();

            comboBoxUsername.Items.Clear();

            // Add unique usernames to the ComboBox
            AddUniqueUsername("Golden");
            AddUniqueUsername("Diamond");
            AddUniqueUsername("Silver");
            AddUniqueUsername("Platinium");

            textBoxNameC.Focus();

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

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string CustomerName = textBoxNameC.Text.Trim();
            string Address = textBoxA.Text.Trim();
            string CityName = textBoxCity.Text.Trim();
            string DateofBirth = DateTImePicker1.Text.Trim();
            string AniversaryDate = AD.Text.Trim();
            string CustomerType = comboBoxUsername.Text.Trim();
            string WhatsappNo = textBoxW.Text.Trim();
            string AlternateMobileNo = textBoxM.Text.Trim();
            string GSTNo = textBoxG.Text.Trim();
            string AadharNo = textBoxAa.Text.Trim();
            string Remark = textBoxR.Text.Trim();
            dataGridView1.Refresh();
            dataGridView1.Visible = false;
            if (!string.IsNullOrEmpty(CustomerName))
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO Customer (CustomerName, Address, CityName, DateofBirth, AniversaryDate, CustomerType, WhatsappNo, AlternateMobileNo, GSTNo, AadharNo, Remark) " +
                                      "VALUES (@CustomerName, @Address, @CityName, @DateofBirth, @AniversaryDate, @CustomerType, @WhatsappNo, @AlternateMobileNo, @GSTNo, @AadharNo, @Remark);SELECT SCOPE_IDENTITY();";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CustomerName", CustomerName);
                        command.Parameters.AddWithValue("@Address", Address);
                        command.Parameters.AddWithValue("@CityName", CityName);
                        command.Parameters.AddWithValue("@DateofBirth", DateofBirth);
                        command.Parameters.AddWithValue("@AniversaryDate", AniversaryDate);
                        command.Parameters.AddWithValue("@CustomerType", CustomerType);
                        command.Parameters.AddWithValue("@WhatsappNo", WhatsappNo);
                        command.Parameters.AddWithValue("@AlternateMobileNo", AlternateMobileNo);
                        command.Parameters.AddWithValue("@GstNo", GSTNo);
                        command.Parameters.AddWithValue("@AadharNo", AadharNo);
                        command.Parameters.AddWithValue("@Remark", Remark);
                        //command.Parameters.AddWithValue("@CityID", cityID);

                        connection.Open();


                        // ExecuteScalar to get the generated ID
                        int customerID = Convert.ToInt32(command.ExecuteScalar());


                        // Display the generated ID in the textbox
                        textboxID.Text = customerID.ToString();
                        textboxID.ReadOnly = true;

                        textboxID.Clear();
                        textBoxNameC.Clear();
                        textBoxA.Clear();
                        textBoxCity.Clear();
                        comboBoxUsername.Items.Clear(); ;
                        textBoxW.Clear();
                        textBoxM.Clear();
                        textBoxG.Clear();
                        textBoxAa.Clear();
                        textBoxR.Clear();





                        MessageBox.Show($"Data  added with ID: {customerID}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            LoadLatestCustomerID();



        }
        private void LoadLatestCustomerID()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT MAX(CustomerID) FROM Customer;";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    object result = command.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        int latestCustomerID = Convert.ToInt32(result) + 1; // Increment by 1 to get the next available ID
                        textboxID.Text = latestCustomerID.ToString();
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
                    string query = "SELECT CustomerID, CustomerName, Address, CityName, DateofBirth, AniversaryDate, CustomerType, WhatsappNo, AlternateMobileNo, GSTNo, AadharNo, Remark FROM Customer";

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
                string customerIDValue = selectedRow.Cells["CustomerID"].Value.ToString();
                string customerNameValue = selectedRow.Cells["CustomerName"].Value.ToString();
                string addressValue = selectedRow.Cells["Address"].Value.ToString();
                string cityNameValue = selectedRow.Cells["CityName"].Value.ToString();
                string dateofBirthValue = selectedRow.Cells["DateofBirth"].Value.ToString();
                string aniversaryDateValue = selectedRow.Cells["AniversaryDate"].Value.ToString();
                string customerTypeValue = selectedRow.Cells["CustomerType"].Value.ToString();
                string whatsappNoValue = selectedRow.Cells["WhatsappNo"].Value.ToString();
                string alternateMobileNoValue = selectedRow.Cells["alternateMobileNo"].Value.ToString();
                string GSTNoValue = selectedRow.Cells["GSTNo"].Value.ToString();
                string AadharNoValue = selectedRow.Cells["AadharNo"].Value.ToString();
                string RemarkValue = selectedRow.Cells["Remark"].Value.ToString();
                // Populate form fields with the selected row's data
                textboxID.Text = customerIDValue;
                textBoxNameC.Text = customerNameValue;
                textBoxA.Text = addressValue;
                textBoxCity.Text = cityNameValue;
                //DateTimePicker1.Text = dateofBirthValue;
                //textBoxAD.Text = aniversaryDateValue;

                comboBoxUsername.Text = customerTypeValue;
                textBoxW.Text = whatsappNoValue;
                textBoxM.Text = alternateMobileNoValue;
                textBoxG.Text = GSTNoValue;
                textBoxAa.Text = AadharNoValue;
                textBoxR.Text = RemarkValue;

                // You can continue populating other form fields as needed
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            string CustomerName = textBoxNameC.Text.Trim();
            string Address = textBoxA.Text.Trim();
            string CityName = textBoxCity.Text.Trim();
            string DateofBirth = DateTImePicker1.Text.Trim();
            string AniversaryDate = AD.Text.Trim();
            string CustomerType = comboBoxUsername.Text.Trim();
            string WhatsappNo = textBoxW.Text.Trim();
            string AlternateMobileNo = textBoxM.Text.Trim();
            string GSTNo = textBoxG.Text.Trim();
            string AadharNo = textBoxAa.Text.Trim();
            string Remark = textBoxR.Text.Trim();

            string updatedColumn1Value = textboxID.Text;
            string updatedColumn2Value = textBoxNameC.Text;
            string updatedColumn3Value = textBoxA.Text;
            string updatedColumn4Value = textBoxCity.Text;
            string updatedColumn5Value = DateTImePicker1.Text;
            string updatedColumn6Value = AD.Text;
            string updatedColumn7Value = comboBoxUsername.Text;
            string updatedColumn8Value = textBoxW.Text;
            string updatedColumn9Value = textBoxM.Text;
            string updatedColumn10Value = textBoxG.Text;
            string updatedColumn11Value = textBoxAa.Text;
            string updatedColumn12Value = textBoxR.Text;
            dataGridView1.Visible = true;
            if (!string.IsNullOrEmpty(CustomerName))
            {
                if (dataGridView1.CurrentRow != null)
                {
                    // Update the DataGridView row with the edited data
                    dataGridView1.CurrentRow.Cells["CustomerID"].Value = updatedColumn1Value;
                    dataGridView1.CurrentRow.Cells["CustomerName"].Value = updatedColumn2Value;
                    dataGridView1.CurrentRow.Cells["Address"].Value = updatedColumn3Value;
                    dataGridView1.CurrentRow.Cells["CityName"].Value = updatedColumn4Value;
                    dataGridView1.CurrentRow.Cells["DateOfBirth"].Value = updatedColumn5Value;
                    dataGridView1.CurrentRow.Cells["AniversaryDate"].Value = updatedColumn6Value;
                    dataGridView1.CurrentRow.Cells["CustomerType"].Value = updatedColumn7Value;
                    dataGridView1.CurrentRow.Cells["WhatsappNo"].Value = updatedColumn8Value;
                    dataGridView1.CurrentRow.Cells["AlternateMobileNo"].Value = updatedColumn9Value;
                    dataGridView1.CurrentRow.Cells["GSTNo"].Value = updatedColumn10Value;
                    dataGridView1.CurrentRow.Cells["AadharNo"].Value = updatedColumn11Value;
                    dataGridView1.CurrentRow.Cells["Remark"].Value = updatedColumn12Value;
                    // Optionally, you can also update your data source if you're using one
                    // dataSource[dataGridView1.CurrentRow.Index].ColumnName1 = updatedColumn1Value;
                    // dataSource[dataGridView1.CurrentRow.Index].ColumnName2 = updatedColumn2Value;
                }
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "UPDATE Customer SET CustomerName = @CustomerName, Address = @Address, CityName = @CityName, DateofBirth = @DateofBirth, AniversaryDate = @AniversaryDate, CustomerType = @CustomerType, WhatsappNo = @WhatsappNo, AlternateMobileNo = @AlternateMobileNo, GSTNo = @GSTNo, AadharNo = @AadharNo, Remark = @Remark  WHERE CustomerID = @CustomerID;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CustomerName", CustomerName);
                        command.Parameters.AddWithValue("@Address", Address);
                        command.Parameters.AddWithValue("@CityName", CityName);
                        command.Parameters.AddWithValue("@DateofBirth", DateofBirth);
                        command.Parameters.AddWithValue("@AniversaryDate", AniversaryDate);
                        command.Parameters.AddWithValue("@CustomerType", CustomerType);
                        command.Parameters.AddWithValue("@WhatsappNo", WhatsappNo);
                        command.Parameters.AddWithValue("@AlternateMobileNo", AlternateMobileNo);
                        command.Parameters.AddWithValue("@GstNo", GSTNo);
                        command.Parameters.AddWithValue("@AadharNo", AadharNo);
                        command.Parameters.AddWithValue("@Remark", Remark);
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
            textBoxW.Clear();
            textBoxM.Clear();
            textBoxG.Clear();
            textBoxAa.Clear();
            textBoxR.Clear();

            LoadLatestCustomerID();



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBoxUsername_SelectedIndexChanged(object sender, EventArgs e)
        {

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
                AD.Focus();   // Move the focus to the password TextBox
            }
        }

        private void AD_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Suppress the default Enter key behavior (newline in TextBox)
                comboBoxUsername.Focus();   // Move the focus to the password TextBox
            }
        }

        private void comboBoxUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Suppress the default Enter key behavior (newline in TextBox)
                textBoxW.Focus();   // Move the focus to the password TextBox
            }
        }

        private void textBoxW_KeyDown(object sender, KeyEventArgs e)
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
                textBoxR.Focus();   // Move the focus to the password TextBox
            }
        }

        private void textBoxR_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Suppress the default Enter key behavior (newline in TextBox)
                SaveButton.Focus();   // Move the focus to the password TextBox
            }
        }
    }
}
