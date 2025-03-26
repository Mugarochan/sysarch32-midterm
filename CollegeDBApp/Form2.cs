using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace CollegeDBApp
{
    public partial class Form2 : Form
    {
        string connectionString = "Server=localhost;Database=CollegeDB;User ID=root;Password=root;";
        MySqlConnection connection;

        public Form2()
        {
            InitializeComponent();
            connection = new MySqlConnection(connectionString);
        }

        private void Form2_Load_1(object sender, EventArgs e)
        {

            
            LoadColleges();  // Load colleges into the dropdown
            LoadDepartments();  // Load department list

        }

        private void OpenConnection()
        {
            if (connection.State == ConnectionState.Closed)
                connection.Open();
        }

        private void CloseConnection()
        {
            if (connection.State == ConnectionState.Open)
                connection.Close();
        }

        // Load Colleges into Dropdown
        private void LoadColleges()
        {
            try
            {
                string query = "SELECT CollegeID, CollegeName FROM College WHERE IsActive = 1"; // Only active colleges
                MySqlDataAdapter da = new MySqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    // Add a placeholder row
                    DataRow placeholderRow = dt.NewRow();
                    placeholderRow["CollegeID"] = DBNull.Value;
                    placeholderRow["CollegeName"] = "Select a College"; // Placeholder text
                    dt.Rows.InsertAt(placeholderRow, 0); // Insert the placeholder at the top

                    cmbCollege.DataSource = dt;
                    cmbCollege.DisplayMember = "CollegeName";  // Display CollegeName in ComboBox
                    cmbCollege.ValueMember = "CollegeID";     // Set CollegeID as the value of ComboBox
                    cmbCollege.SelectedIndex = 0;  // Set the default selection to the placeholder
                }
                else
                {
                    MessageBox.Show("No active colleges found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading colleges: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Load Departments into DataGridView
        private void LoadDepartments()
        {
            try
            {
                // Updated query to include CollegeID
                string query = "SELECT d.DepartmentID, d.DepartmentName, d.DepartmentCode, c.CollegeID, c.CollegeName, d.IsActive " +
                               "FROM Department d INNER JOIN College c ON d.CollegeID = c.CollegeID WHERE d.IsActive = 1";
                MySqlDataAdapter da = new MySqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvDepartments.DataSource = dt;

                // Optional: Log column names (for debugging purposes)
                foreach (DataGridViewColumn column in dgvDepartments.Columns)
                {
                    Console.WriteLine("Column Name: " + column.Name);  // This will print to the console for debugging
                }

                if (dgvDepartments.Columns["CollegeID"] != null)
                {
                    dgvDepartments.Columns["CollegeID"].Visible = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading departments: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Add Department
        private void AddDepartment()
        {
            if (!ValidateInput()) return;

            try
            {
                // Notice that we do not include DepartmentID in the query
                string query = "INSERT INTO Department (DepartmentName, DepartmentCode, CollegeID, IsActive) " +
                               "VALUES (@DepartmentName, @DepartmentCode, @CollegeID, @IsActive)";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@DepartmentName", txtDepartmentName.Text);
                cmd.Parameters.AddWithValue("@DepartmentCode", txtDepartmentCode.Text);
                cmd.Parameters.AddWithValue("@CollegeID", cmbCollege.SelectedValue);
                cmd.Parameters.AddWithValue("@IsActive", chkDepartmentActive.Checked);

                OpenConnection();
                cmd.ExecuteNonQuery();
                CloseConnection();

                MessageBox.Show("Department added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDepartments();  // Reload departments after adding
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding department: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Update Department
        private void UpdateDepartment()
        {
            if (!ValidateInput()) return;
            if (string.IsNullOrEmpty(txtDepartmentID.Text))
            {
                MessageBox.Show("Please select a department to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string query = "UPDATE Department SET DepartmentName = @DepartmentName, DepartmentCode = @DepartmentCode, CollegeID = @CollegeID, IsActive = @IsActive WHERE DepartmentID = @DepartmentID";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@DepartmentID", txtDepartmentID.Text);
                cmd.Parameters.AddWithValue("@DepartmentName", txtDepartmentName.Text);
                cmd.Parameters.AddWithValue("@DepartmentCode", txtDepartmentCode.Text);
                cmd.Parameters.AddWithValue("@CollegeID", cmbCollege.SelectedValue);
                cmd.Parameters.AddWithValue("@IsActive", chkDepartmentActive.Checked);

                OpenConnection();
                cmd.ExecuteNonQuery();
                CloseConnection();

                MessageBox.Show("Department updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDepartments();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating department: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Soft Delete Department
        private void DeleteDepartment()
        {
            if (string.IsNullOrEmpty(txtDepartmentID.Text))
            {
                MessageBox.Show("Please select a department to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirmResult = MessageBox.Show("Are you sure you want to delete this department?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmResult == DialogResult.No) return;

            try
            {
                string query = "UPDATE Department SET IsActive = 0 WHERE DepartmentID = @DepartmentID";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@DepartmentID", txtDepartmentID.Text);

                OpenConnection();
                cmd.ExecuteNonQuery();
                CloseConnection();

                MessageBox.Show("Department deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDepartments();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting department: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Validate Inputs
        private bool ValidateInput()
        {
            // Check that the department name, department code, and college selection are filled
            if (string.IsNullOrEmpty(txtDepartmentName.Text) || string.IsNullOrEmpty(txtDepartmentCode.Text) || cmbCollege.SelectedIndex == -1)
            {
                MessageBox.Show("Please enter all required fields.", "Input Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

    private void chkDepartmentActive_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtDepartmentName_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtDepartmentCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbCollege_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAddDepartment_Click_1(object sender, EventArgs e)
        {

            // Validate if a College is selected
            if (cmbCollege.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a college from the dropdown list.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Stop further execution
            }

            // If validation passes, proceed with adding the record
           
            AddDepartment(); 


        }

        private void btnUpdateDepartment_Click_1(object sender, EventArgs e)
        {
            // Validate if a College is selected
            if (cmbCollege.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a college from the dropdown list.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Stop further execution
            }
            UpdateDepartment();
                
        }

        private void btnDeleteDepartment_Click(object sender, EventArgs e)
        {
            // Validate if a College is selected
            
            DeleteDepartment();
            LoadDepartments();
        }

        private void btnViewDepartment_Click(object sender, EventArgs e)
        {
            LoadDepartments();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Get the selected row from the DataGridView
                DataGridViewRow row = dgvDepartments.Rows[e.RowIndex];

                // Populate the TextBoxes with values from the selected row
                txtDepartmentID.Text = row.Cells["DepartmentID"].Value.ToString();
                txtDepartmentName.Text = row.Cells["DepartmentName"].Value.ToString();
                txtDepartmentCode.Text = row.Cells["DepartmentCode"].Value.ToString();

                // Populate the ComboBox with the College Name
                cmbCollege.Text = row.Cells["CollegeName"].Value.ToString();

                // Set the selected CollegeID in the ComboBox (this is important)
                cmbCollege.SelectedValue = row.Cells["CollegeID"].Value;

                // Set the check-box for IsActive status
                chkDepartmentActive.Checked = Convert.ToBoolean(row.Cells["IsActive"].Value);
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}

