
using Guna.UI2.WinForms;
using Microsoft.VisualBasic;
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
    public partial class HREmployees : Form
    {
        public HREmployees()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=.;Initial Catalog=hrms;Integrated Security=True");

        void populate()
        {
            try
            {
                Con.Open();
                string Myquery = "SELECT uId AS 'ID', CONCAT(uFName, ' ', uLName) AS Name, uDepartment AS 'Department',\r\n  uDesignation AS 'Designation',\r\n  uEmail AS 'Email',\r\n  uPhn AS 'Phone',\r\n  uAddress AS 'Address',\r\n  uCNIC AS 'CNIC',\r\n  uDOB AS 'Date of Birth',\r\n  uJoinDate AS 'Join Date'\r\nFROM [user];";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                gridView.DataSource = ds.Tables[0];
                Con.Close();

            }
            catch
            {

            }
        }
        private void HREmployees_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            populate();
            label7.Text = "" + GetTotalUserCount().ToString();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2CircleProgressBar1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }
        private int GetTotalUserCount()
        {
            Con.Open();
            string query = "SELECT COUNT(*) FROM [user]";
            SqlCommand cmd = new SqlCommand(query, Con);
            int count = (int)cmd.ExecuteScalar();
            Con.Close();
            return count;
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            va add = new va();
            add.Show();
            populate();
        }


        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            // Prompt user for uId
            string uIdToUpdate = Interaction.InputBox("Enter uId to update:", "Update Record", "");

            if (!string.IsNullOrEmpty(uIdToUpdate))
            {
                // Check if uId exists
                if (CheckIfIdExists(uIdToUpdate))
                {
                    // Retrieve data for the specified uId
                    Con.Open();
                    string query = "SELECT * FROM [user] WHERE uId = @uId";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.Parameters.AddWithValue("@uId", uIdToUpdate);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        // Pass the data to addemp form
                        update up = new update();
                        up.PopulateForm(reader);
                        Con.Close();
                        up.Show();
                        populate();
                    }
                }
                else
                {
                    MessageBox.Show($"Record with uId '{uIdToUpdate}' not found.");
                }
                Con.Close();
            }
        }

        private bool CheckIfIdExists(string uId)
        {
            Con.Open();
            string query = "SELECT COUNT(*) FROM [user] WHERE uId = @uId";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.Parameters.AddWithValue("@uId", uId);
            int count = (int)cmd.ExecuteScalar();
            Con.Close();
            return count > 0;
        }

        private void delete_Click(object sender, EventArgs e)
        {
            try
            {
                string uIdToDelete = Interaction.InputBox("Enter uId to delete:", "Delete Record", "");

                if (!string.IsNullOrEmpty(uIdToDelete))
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM [user] WHERE uId = @uId", Con);
                    cmd.Parameters.AddWithValue("@uId", uIdToDelete);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    Con.Close();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show($"Record with uId '{uIdToDelete}' deleted successfully.");
                        populate(); // Refresh the DataGridView
                    }
                    else
                    {
                        MessageBox.Show($"Record with uId '{uIdToDelete}' not found.");
                    }
                    Con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void ln_TextChanged(object sender, EventArgs e)
        {
            string searchKeyword = ln.Text.Trim();
            populate(searchKeyword);
        }
        void populate(string search = "")
        {
            try
            {
                Con.Open();
                string searchCondition = string.IsNullOrEmpty(search) ? "" : $" WHERE CONCAT(uFName, ' ', uLName) LIKE '%{search}%'";
                string Myquery = $"SELECT uId AS 'ID', CONCAT(uFName, ' ', uLName) AS Name, uDepartment AS 'Department',\r\n  uDesignation AS 'Designation',\r\n  uEmail AS 'Email',\r\n  uPhn AS 'Phone',\r\n  uAddress AS 'Address',\r\n  uCNIC AS 'CNIC',\r\n  uDOB AS 'Date of Birth',\r\n  uJoinDate AS 'Join Date'\r\nFROM [user]{searchCondition};";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                gridView.DataSource = ds.Tables[0];
                Con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void guna2Button2_Click_1(object sender, EventArgs e)
        {

        }
    }
}

