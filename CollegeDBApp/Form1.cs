using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CollegeDBApp
{
    public partial class Form1 : Form
    {
        string connectionString = "Server=localhost;Database=CollegeDB;User ID=root;Password=root;";
        MySqlConnection connection;

        public Form1()
        {
            InitializeComponent();
            connection = new MySqlConnection(connectionString);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadColleges();
        }

        // Open DB Connection
        private void OpenConnection()
        {
            if (connection.State == ConnectionState.Closed)
                connection.Open();
        }

        // Close DB Connection
        private void CloseConnection()
        {
            if (connection.State == ConnectionState.Open)
                connection.Close();
        }

        // Load Colleges into DataGridView
        private void LoadColleges()
        {
            try
            {
                string query = "SELECT * FROM College WHERE IsActive = 1"; // Show only active colleges
                MySqlDataAdapter da = new MySqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvColleges.DataSource = dt;
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Add College
        private void AddCollege()
        {
            if (!ValidateInput()) return;

            string query = "INSERT INTO College (CollegeName, CollegeCode, IsActive) VALUES (@CollegeName, @CollegeCode, @IsActive)";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@CollegeName", txtCollegeName.Text);
            cmd.Parameters.AddWithValue("@CollegeCode", txtCollegeCode.Text);
            cmd.Parameters.AddWithValue("@IsActive", chkCollegeActive.Checked);

            try
            {
                OpenConnection();
                cmd.ExecuteNonQuery();
                MessageBox.Show("College added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding college: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                CloseConnection();
            }

            LoadColleges(); // Refresh DataGridView
        }

        // Update College
        private void UpdateCollege()
        {
            if (!ValidateInput()) return;

            // Store the current scroll position (first displayed row)
            int scrollPosition = dgvColleges.FirstDisplayedScrollingRowIndex;

            // Store the currently selected row index
            int selectedIndex = dgvColleges.SelectedRows.Count > 0 ? dgvColleges.SelectedRows[0].Index : -1;

            string query = "UPDATE College SET CollegeName = @CollegeName, CollegeCode = @CollegeCode, IsActive = @IsActive WHERE CollegeID = @CollegeID";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@CollegeID", txtCollegeID.Text);
            cmd.Parameters.AddWithValue("@CollegeName", txtCollegeName.Text);
            cmd.Parameters.AddWithValue("@CollegeCode", txtCollegeCode.Text);
            cmd.Parameters.AddWithValue("@IsActive", chkCollegeActive.Checked);

            try
            {
                OpenConnection();
                cmd.ExecuteNonQuery();
                MessageBox.Show("College updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating college: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                CloseConnection();
            }

            // Refresh DataGridView
            LoadColleges();

            // Restore the scroll position after the grid reloads
            dgvColleges.FirstDisplayedScrollingRowIndex = scrollPosition;

            // Reselect the previously selected row
            if (selectedIndex >= 0 && selectedIndex < dgvColleges.Rows.Count)
            {
                dgvColleges.Rows[selectedIndex].Selected = true;
            }


        }

        // Soft Delete College
        private void DeleteCollege()
        {
            if (string.IsNullOrEmpty(txtCollegeID.Text))
            {
                MessageBox.Show("Please select a college to delete.", "Input Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this college?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                string query = "UPDATE College SET IsActive = 0 WHERE CollegeID = @CollegeID"; // Soft delete
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@CollegeID", txtCollegeID.Text);

                try
                {
                    OpenConnection();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("College soft deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting college: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    CloseConnection();
                }

                LoadColleges(); // Refresh DataGridView
            }
        }

        // Validate Inputs
        private bool ValidateInput()
        {
            if (string.IsNullOrEmpty(txtCollegeName.Text) || string.IsNullOrEmpty(txtCollegeCode.Text))
            {
                MessageBox.Show("Please enter all required fields.", "Input Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }        

        

        // Select College from DataGridView and Display in Fields
       

        

        private void txtCollegeID_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtCollegeName_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtCollegeCode_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void chkCollegeActive_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void dgvColleges_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvColleges.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvColleges.SelectedRows[0];
                txtCollegeID.Text = row.Cells["CollegeID"].Value.ToString();  // Populate CollegeID
                txtCollegeName.Text = row.Cells["CollegeName"].Value.ToString();
                txtCollegeCode.Text = row.Cells["CollegeCode"].Value.ToString();
                chkCollegeActive.Checked = Convert.ToBoolean(row.Cells["IsActive"].Value);
            }
        }

        private void btnAddCollege_Click(object sender, EventArgs e)
        {
                AddCollege();
        }

        private void btnDeleteCollege_Click(object sender, EventArgs e)
        {
            DeleteCollege();
        }

        private void btnUpdateCollege_Click(object sender, EventArgs e)
        {
                UpdateCollege();
        }

        private void btnReadCollege_Click(object sender, EventArgs e)
        {
            LoadColleges();
        }

        private void btnOpenForm2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}




