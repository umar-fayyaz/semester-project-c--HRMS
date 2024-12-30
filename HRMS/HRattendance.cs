using Guna.UI2.WinForms;
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

namespace HRMS
{
    public partial class HRattendance : Form
    {
        public HRattendance()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=.;Initial Catalog=hrms;Integrated Security=True");

        private void HRattendance_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            LoadAttendanceRecords();
            LoadLeaveRecords();
            UpdatePendingLeaveCount();
            LoadPendingLeaveIds();
        }
        private void LoadAttendanceRecords()
        {
            try
            {
                Con.Open();

                // Select the required columns from the attendance table
                SqlCommand cmd = new SqlCommand("SELECT uId, attDateTime, attType FROM attendance", Con);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                // Display the data in the DataGridView
                gridView.DataSource = dt;

                // Customize column headers
                gridView.Columns["uId"].HeaderText = "User ID";
                gridView.Columns["attDateTime"].HeaderText = "Attendance Date";
                gridView.Columns["attType"].HeaderText = "Attendance Status";


                // Map attType values to display text
                foreach (DataGridViewRow row in gridView.Rows)
                {
                    int attTypeValue = Convert.ToInt32(row.Cells["attType"].Value);

                    switch (attTypeValue)
                    {
                        case 0:
                            row.Cells["attType"].Value = "Present";
                            break;
                        case 1:
                            row.Cells["attType"].Value = "Late";
                            break;
                        case 2:
                            row.Cells["attType"].Value = "Absent";
                            break;
                        case 3:
                            row.Cells["attType"].Value = "Leave";
                            break;
                        default:
                            // Handle other values if needed
                            break;
                    }
                }

                // Hide the attId column
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Con.Close();
            }
        }
        private void guna2CircleProgressBar2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            UpdateLeaveStatus(1);
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            UpdateLeaveStatus(2);
        }

        private void UpdateLeaveStatus(int newStatus)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(@"Data Source=.;Initial Catalog=hrms;Integrated Security=True"))
                {
                    connection.Open();

                    // Check if an item is selected in the combo box
                    if (selectId.SelectedItem != null)
                    {
                        // Get the selected leave ID
                        int selectedLeaveId = Convert.ToInt32(selectId.SelectedItem.ToString());

                        // Update the leaveStatus in the database
                        using (SqlCommand updateCmd = new SqlCommand("UPDATE leave SET leaveStatus = @newStatus WHERE leaveId = @selectedLeaveId", connection))
                        {
                            updateCmd.Parameters.AddWithValue("@newStatus", newStatus);
                            updateCmd.Parameters.AddWithValue("@selectedLeaveId", selectedLeaveId);
                            updateCmd.ExecuteNonQuery();
                        }

                        // Reload the leave records and update the pending leave count and combo box
                        LoadLeaveRecords();
                        UpdatePendingLeaveCount();
                        LoadPendingLeaveIds();

                        // Optional: Display a message indicating the update was successful
                        MessageBox.Show("Leave status updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        // Display a message if no leave ID is selected
                        MessageBox.Show("Please select a leave ID", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LoadLeaveRecords()
        {
            try
            {
                Con.Open();

                // Select the required columns from the leave table
                SqlCommand cmd = new SqlCommand("SELECT leaveId, uId, leaveSdate, leaveEdate, leaveReason, leaveStatus FROM leave", Con);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                // Display the data in the attgridView
                attgridView.DataSource = dt;

                // Customize column headers
                attgridView.Columns["leaveId"].HeaderText = "Leave ID";
                attgridView.Columns["uId"].HeaderText = "User ID";
                attgridView.Columns["leaveSdate"].HeaderText = "Start Date";
                attgridView.Columns["leaveEdate"].HeaderText = "End Date";
                attgridView.Columns["leaveReason"].HeaderText = "Reason";
                attgridView.Columns["leaveStatus"].HeaderText = "Leave Status";

                // Map leaveStatus values to display text
                foreach (DataGridViewRow row in attgridView.Rows)
                {
                    string leaveStatusValue = row.Cells["leaveStatus"].Value.ToString().Trim(); // Convert to string and trim to handle any extra spaces

                    switch (leaveStatusValue)
                    {
                        case "0":
                            row.Cells["leaveStatus"].Value = "Pending";
                            break;
                        case "1":
                            row.Cells["leaveStatus"].Value = "Approved";
                            break;
                        case "2":
                            row.Cells["leaveStatus"].Value = "Rejected";
                            break;
                        default:
                            // Handle other values if needed
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Con.Close();
            }
        }

        private void attgridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void UpdatePendingLeaveCount()
        {
            try
            {
                Con.Open();

                // Count the pending leave records
                SqlCommand countCmd = new SqlCommand("SELECT COUNT(*) FROM leave WHERE leaveStatus = 0", Con);
                int pendingLeaveCount = Convert.ToInt32(countCmd.ExecuteScalar());

                // Update label5 text with the count
                label5.Text = "" + pendingLeaveCount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Con.Close();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void LoadPendingLeaveIds()
        {
            try
            {
                Con.Open();

                // Select pending leave IDs from the leave table
                SqlCommand cmd = new SqlCommand("SELECT leaveId FROM leave WHERE leaveStatus = 0", Con);

                SqlDataReader reader = cmd.ExecuteReader();

                // Clear existing items in the combo box
                selectId.Items.Clear();

                // Add pending leave IDs to the combo box
                while (reader.Read())
                {
                    selectId.Items.Add(reader["leaveId"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Con.Close();
            }
        }


        private void selectId_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
