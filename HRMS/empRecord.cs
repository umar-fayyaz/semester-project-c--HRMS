using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRMS
{
    public partial class empRecord : Form
    {
        private string currentUserId;
        PrintDocument printDocument;
        PrintPreviewDialog printPreviewDialog;
        public empRecord()
        {
            InitializeComponent();
            printDocument = new PrintDocument();
            printDocument.PrintPage += new PrintPageEventHandler(printDocument_PrintPage);

            // Initialize PrintPreviewDialog
            printPreviewDialog = new PrintPreviewDialog();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=.;Initial Catalog=hrms;Integrated Security=True");

        public void SetUserId(string userId)
        {
            currentUserId = userId;

            LoadAttendanceRecords(userId);
            DeductSalary(userId);
            LoadSalaryDeductionRecords(userId);

        }
        private void printDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Your printing logic goes here
            // Example: e.Graphics.DrawString("Hello, World!", new Font("Arial", 12), Brushes.Black, new PointF(10, 10));

            string userId = currentUserId; // Replace with the actual user ID
            try
            {
                Con.Open();
                // Fetch user information from the database
                SqlCommand userCmd = new SqlCommand("SELECT uFName, uLName, uDesignation, uDepartment, uSalary FROM [user] WHERE uId = @uId", Con);
                userCmd.Parameters.AddWithValue("@uId", userId);
                SqlDataReader userReader = userCmd.ExecuteReader();

                if (userReader.Read())
                {
                    string uFName = userReader["uFName"].ToString();
                    string uLName = userReader["uLName"].ToString();
                    string uDesignation = userReader["uDesignation"].ToString();
                    string uDepartment = userReader["uDepartment"].ToString();
                    string uSalary = userReader["uSalary"].ToString();

                    userReader.Close();

                    // Fetch fAmount from the sd table
                    SqlCommand sdCmd = new SqlCommand("SELECT fAmount FROM sd WHERE uId = @uId", Con);
                    sdCmd.Parameters.AddWithValue("@uId", userId);
                    int fAmount = Convert.ToInt32(sdCmd.ExecuteScalar());

                    // Print the information
                    string printText = $"Employee ID: {userId}\n" +
                                       $"Employee Name: {uFName} {uLName}\n" +
                                       $"Designation: {uDesignation}\n" +
                                       $"Department: {uDepartment}\n" +
                                       $"Salary: {uSalary}\n" +
                                       $"After Deduction Amount: {fAmount}";

                    e.Graphics.DrawString(printText, new Font("Arial", 12), Brushes.Black, new PointF(10, 10));
                }
                else
                {
                    userReader.Close();
                    MessageBox.Show($"User with ID {userId} not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            finally
            {
                // Close the connection in the finally block to ensure it is closed even if an exception occurs
                if (Con.State == ConnectionState.Open)
                {
                    Con.Close();
                }
            }
        }
            private void LoadSalaryDeductionRecords(string userId)
        {
            try
            {
                Con.Open();

                // Select the required columns from the "amounts" table for a specific userId
                SqlCommand amountsCmd = new SqlCommand("SELECT sdAbsent, sdAmount FROM amounts", Con);
                SqlDataReader amountsReader = amountsCmd.ExecuteReader();

                if (amountsReader.Read())
                {
                    int sdAbsent = Convert.ToInt32(amountsReader["sdAbsent"]);
                    int sdAmount = Convert.ToInt32(amountsReader["sdAmount"]);
                    amountsReader.Close();

                    lab1.Text = sdAbsent.ToString();
                    lab2.Text = sdAmount.ToString();

                    // Create a DataTable for displaying information in the salgridview
                    DataTable dt = new DataTable();

                    // Add columns to the DataTable
                    dt.Columns.Add("Absents", typeof(int));
                    dt.Columns.Add("Original Salary", typeof(int));
                    dt.Columns.Add("After Deduction", typeof(int));

                    // Retrieve the number of absences (attType = 2) for the specified user
                    SqlCommand countCmd = new SqlCommand("SELECT COUNT(*) FROM attendance WHERE uId = @uId AND attType = 2", Con);
                    countCmd.Parameters.AddWithValue("@uId", userId);
                    int absentCount = Convert.ToInt32(countCmd.ExecuteScalar());

                    // Retrieve the current salary of the user
                    SqlCommand salaryCmd = new SqlCommand("SELECT uSalary FROM [user] WHERE uId = @uId", Con);
                    salaryCmd.Parameters.AddWithValue("@uId", userId);
                    int originalSalary = Convert.ToInt32(salaryCmd.ExecuteScalar());

                    // Calculate the deducted amount based on the absent count and absent limit
                    int deductedAmount = (absentCount > sdAbsent) ? originalSalary - sdAmount : 0;

                    // Populate the DataTable with the information
                    DataRow row = dt.NewRow();
                    row["Absents"] = absentCount;
                    row["Original Salary"] = originalSalary;
                    row["After Deduction"] = deductedAmount;
                    dt.Rows.Add(row);

                    // Display the data in the DataGridView
                    salgridview.DataSource = dt;
                }
                else
                {
                    amountsReader.Close();
                    MessageBox.Show($"No amounts found in the 'amounts' table.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private void LoadAttendanceRecords(string userId)
        {
            try
            {
                Con.Open();

                // Select the required columns from the attendance table for a specific userId
                SqlCommand cmd = new SqlCommand("SELECT attDateTime, attType FROM attendance WHERE uId = @uId", Con);
                cmd.Parameters.AddWithValue("@uId", userId);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                // Display the data in the DataGridView
                attgridView.DataSource = dt;
                attgridView.Columns["attDateTime"].HeaderText = "Date";
                attgridView.Columns["attType"].HeaderText = "Status";

                // Map attType values to display text
                foreach (DataGridViewRow row in attgridView.Rows)
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

        private void empRecord_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void gridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void DeductSalary(string userId)
        {
            try
            {
                Con.Open();

                // Check if there is already a record in the sd table for the user
                SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM sd WHERE uId = @uId", Con);
                checkCmd.Parameters.AddWithValue("@uId", userId);
                int existingRecords = Convert.ToInt32(checkCmd.ExecuteScalar());

                if (existingRecords == 0)
                {
                    // Fetch sdAbsent, sdAmount from the single row in the amounts table
                    SqlCommand amountsCmd = new SqlCommand("SELECT TOP 1 sdAbsent, sdAmount FROM amounts", Con);
                    SqlDataReader amountsReader = amountsCmd.ExecuteReader();

                    if (amountsReader.Read())
                    {
                        int sdAbsent = Convert.ToInt32(amountsReader["sdAbsent"]);
                        int sdAmount = Convert.ToInt32(amountsReader["sdAmount"]);
                        amountsReader.Close();

                        // Count the number of absences (attType = 2) for the specified user
                        SqlCommand countCmd = new SqlCommand("SELECT COUNT(*) FROM attendance WHERE uId = @uId AND attType = 2", Con);
                        countCmd.Parameters.AddWithValue("@uId", userId);
                        int absentCount = Convert.ToInt32(countCmd.ExecuteScalar());

                        // Retrieve the current salary of the user
                        SqlCommand salaryCmd = new SqlCommand("SELECT uSalary FROM [user] WHERE uId = @uId", Con);
                        salaryCmd.Parameters.AddWithValue("@uId", userId);
                        int currentSalary = Convert.ToInt32(salaryCmd.ExecuteScalar());

                        // Check if the absent count exceeds sdAbsent
                        if (absentCount > sdAbsent)
                        {
                            // Deduct sdAmount from the salary
                            int deductedAmount = currentSalary - sdAmount;

                            // Update the "sd" table with the deducted amount
                            SqlCommand updateCmd = new SqlCommand("INSERT INTO sd (uId, fAmount) VALUES (@uId, @fAmount)", Con);
                            updateCmd.Parameters.AddWithValue("@uId", userId);
                            updateCmd.Parameters.AddWithValue("@fAmount", deductedAmount);
                            updateCmd.ExecuteNonQuery();

                            //MessageBox.Show($"Salary deducted for user {userId}. Deducted Amount: {sdAmount}", "Salary Deduction", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            //MessageBox.Show($"No salary deduction for user {userId}. Absent count: {absentCount}", "Salary Deduction", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        amountsReader.Close();
                        MessageBox.Show($"No amounts found in the 'amounts' table.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    //MessageBox.Show($"Salary deduction already exists for user {userId}.", "Salary Deduction", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void salgridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void showsdAbsent_Click(object sender, EventArgs e)
        {

        }

        private void showsdAmount_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            printPreviewDialog.Document = printDocument;
            printPreviewDialog.ShowDialog();
        }
    }
}