using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HRMS
{
    public partial class empAttendance : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=.;Initial Catalog=hrms;Integrated Security=True");
        private string userId; // Variable to store userId

        public empAttendance()
        {
            InitializeComponent();
        }

        public void SetUserId(string userId)
        {
            this.userId = userId;
        }
        private void label13_Click(object sender, EventArgs e)
        {
            // Your code here, or leave it empty if not needed.
        }

        private void empAttendance_LocationChanged(object sender, EventArgs e)
        {
            // Your code here, or leave it empty if not needed.
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Your code here, or leave it empty if not needed.
        }
        private void empAttendance_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;

            // Disable checkbox on Sundays
            guna2CustomCheckBox1.Enabled = DateTime.Now.DayOfWeek != DayOfWeek.Sunday;



          
            sdate.ValueChanged += sdate_ValueChanged;
            label8.Text = DateTime.Now.ToString("dddd, MMMM d, yyyy");


            UpdateLabel3Text();
            UpdateLabel5Text();

        }

        private void guna2CustomCheckBox1_Click(object sender, EventArgs e)
        {
            if (guna2CustomCheckBox1.Checked)
            {
                // Insert data into attendance table
                InsertAttendance();
            }
        }

        private void InsertAttendance()
        {
            try
            {
                Con.Open();

                // Check if attendance for the current day already exists
                SqlCommand cmdCheckAttendance = new SqlCommand("SELECT COUNT(*) FROM attendance WHERE uId = @uId AND CONVERT(DATE, attDateTime) = CONVERT(DATE, GETDATE())", Con);
                cmdCheckAttendance.Parameters.AddWithValue("@uId", userId);
                int existingAttendanceCount = (int)cmdCheckAttendance.ExecuteScalar();

                if (existingAttendanceCount > 0)
                {
                    MessageBox.Show("Attendance has already been marked for today.", "Duplicate Attendance", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Determine attType based on current time
                int attType;
                DateTime now = DateTime.Now;
                if (now.DayOfWeek >= DayOfWeek.Monday && now.DayOfWeek <= DayOfWeek.Saturday)
                {
                    if (now.TimeOfDay >= new TimeSpan(8, 0, 0) && now.TimeOfDay < new TimeSpan(9, 0, 0))
                    {
                        attType = 0;
                    }
                    else if (now.TimeOfDay >= new TimeSpan(9, 0, 0) && now.TimeOfDay < new TimeSpan(15, 0, 0))
                    {
                        attType = 1;
                    }
                    else
                    {
                        attType = 2;
                    }
                }
                else
                {
                    attType = 2;
                }

                // Insert into attendance table
                SqlCommand cmd = new SqlCommand("INSERT INTO attendance (uId, attDateTime, attType) VALUES (@uId, @attDateTime, @attType)", Con);
                cmd.Parameters.AddWithValue("@uId", userId);
                cmd.Parameters.AddWithValue("@attDateTime", now);
                cmd.Parameters.AddWithValue("@attType", attType);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Attendance marked successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Update label3 text
                UpdateLabel3Text();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Con.Close();
            }
        }

        private void reasonBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void ApplyLeave()
        {
            try
            {
                Con.Open();

                SqlCommand cmdCheckLeave = new SqlCommand("SELECT COUNT(*) FROM leave WHERE uId = @uId AND MONTH(leaveSdate) = MONTH(GETDATE()) AND YEAR(leaveSdate) = YEAR(GETDATE())", Con);
                cmdCheckLeave.Parameters.AddWithValue("@uId", userId);
                int existingLeaveCount = (int)cmdCheckLeave.ExecuteScalar();

                if (existingLeaveCount > 0)
                {
                    MessageBox.Show("You have already applied for leave this month.", "Duplicate Leave Application", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                SqlCommand cmdGetNextLeaveId = new SqlCommand("SELECT ISNULL(MAX(leaveid), 0) + 1 FROM leave", Con);
                int leaveid = (int)cmdGetNextLeaveId.ExecuteScalar();

                // Get leave details from UI
                string leaveReason = reasonBox.Text;
                DateTime leaveStartDate = sdate.Value.Date;
                DateTime leaveEndDate = edate.Value.Date;

                TimeSpan leaveDuration = leaveEndDate - leaveStartDate;
                if (leaveDuration.Days < 1 || leaveDuration.Days > 3)
                {
                    MessageBox.Show("Leave can be applied for a minimum of 1 day and a maximum of 3 days.", "Invalid Leave Duration", MessageBoxButtons.OK);
                    return;
                }

                // Insert into leave table
                SqlCommand cmdLeave = new SqlCommand("INSERT INTO leave (leaveid, uId, leaveSdate, leaveEdate, leaveReason, leaveStatus) VALUES (@leaveid, @uId, @leaveSdate, @leaveEdate, @leaveReason, @leaveStatus)", Con);
                cmdLeave.Parameters.AddWithValue("@leaveid", leaveid);
                cmdLeave.Parameters.AddWithValue("@uId", userId);
                cmdLeave.Parameters.AddWithValue("@leaveSdate", leaveStartDate);
                cmdLeave.Parameters.AddWithValue("@leaveEdate", leaveEndDate);
                cmdLeave.Parameters.AddWithValue("@leaveReason", leaveReason);
                cmdLeave.Parameters.AddWithValue("@leaveStatus", 0); // Set initial status to 0
                cmdLeave.ExecuteNonQuery();

                MessageBox.Show("Leave applied successfully!", "Success", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Con.Close();
            }
            UpdateLabel5Text();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void sdate_ValueChanged(object sender, EventArgs e)
        {
            // Set the text of edate to match sdate
           
        }


        private void apply_Click(object sender, EventArgs e)
        {
            ApplyLeave();
        }

        private void UpdateLabel3Text()
        {
            try
            {
                Con.Open();

                // Count records where attType is 0 or 1
                SqlCommand cmdCount = new SqlCommand("SELECT COUNT(*) FROM attendance WHERE uId = @uId AND (attType = 0 OR attType = 1)", Con);
                cmdCount.Parameters.AddWithValue("@uId", userId);
                int attendanceCount = (int)cmdCount.ExecuteScalar();

                // Update label3 text
                label3.Text = $" {attendanceCount}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Con.Close();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void UpdateLabel5Text()
        {
            try
            {

                Con.Open();

                // Fetch leaveStatus for the user
                SqlCommand cmdLeaveStatus = new SqlCommand("SELECT TOP 1 leaveStatus FROM leave WHERE uId = @uId ORDER BY leaveSdate DESC", Con);
                cmdLeaveStatus.Parameters.AddWithValue("@uId", userId);
                object leaveStatusObj = cmdLeaveStatus.ExecuteScalar();

                if (leaveStatusObj != null && leaveStatusObj != DBNull.Value)
                {
                    int leaveStatus = Convert.ToInt32(leaveStatusObj);

                    // Update label5 text based on leaveStatus
                    if (leaveStatus == 1)
                    {
                        label5.Text = "Approved";
                    }
                    else if (leaveStatus == 2)
                    {
                        label5.Text = "Rejected";
                    }
                    else
                    {
                        label5.Text = "Pending";
                    }
                }
                else
                {
                    // No leave records found
                    label5.Text = "None";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Con.Close();
            }
        }


        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            label8.Text = DateTime.Now.ToString("dddd, MMMM d, yyyy");

        }

        private void sdate_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void guna2Panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}