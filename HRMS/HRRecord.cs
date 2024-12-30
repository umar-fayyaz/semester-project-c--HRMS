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
    public partial class HRRecord : Form
    {
        public HRRecord()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=.;Initial Catalog=hrms;Integrated Security=True");

        private void HRRecord_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            LoadData();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void LoadData()
        {
            try
            {
                if (Con.State == ConnectionState.Closed)
                {
                    Con.Open();
                }

                string query = "SELECT u.uId, u.uSalary, ISNULL(CONVERT(NVARCHAR(255), sd.fAmount), '-') AS fAmount " +
                       "FROM [user] u " +
                       "LEFT JOIN sd ON u.uId = sd.uId";
                SqlDataAdapter sda = new SqlDataAdapter(query, Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                gridView.DataSource = dt;

                string amountsQuery = "SELECT TOP 1 sdAbsent, sdAmount FROM amounts"; // Assuming you only have one row in the amounts table
                SqlCommand cmd = new SqlCommand(amountsQuery, Con);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    lab1.Text = reader["sdAbsent"].ToString();
                    lab2.Text = reader["sdAmount"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Close the connection in the finally block
                if (Con.State == ConnectionState.Open)
                {
                    Con.Close();
                }
            }
        }


        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lab2_Click(object sender, EventArgs e)
        {

        }

        private void text1_TextChanged(object sender, EventArgs e)
        {


        }

        private void text2_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (Con.State == ConnectionState.Closed)
                {
                    Con.Open();
                }

                // Check if it's been more than a month since the last update
                string checkLastUpdateQuery = "SELECT DATEDIFF(MONTH, lastUpdate, GETDATE()) AS MonthsSinceLastUpdate FROM amounts";
                SqlCommand cmdCheckLastUpdate = new SqlCommand(checkLastUpdateQuery, Con);
                int monthsSinceLastUpdate = Convert.ToInt32(cmdCheckLastUpdate.ExecuteScalar());

                if (monthsSinceLastUpdate >= 1)
                {
                    // Update sdAmount
                    string updateSdAmountQuery = "UPDATE amounts SET sdAmount = @sdAmount";
                    SqlCommand cmdSdAmount = new SqlCommand(updateSdAmountQuery, Con);
                    cmdSdAmount.Parameters.AddWithValue("@sdAmount", text1.Text);
                    cmdSdAmount.ExecuteNonQuery();

                    // Update sdAbsent
                    string updateSdAbsentQuery = "UPDATE amounts SET sdAbsent = @sdAbsent";
                    SqlCommand cmdSdAbsent = new SqlCommand(updateSdAbsentQuery, Con);
                    cmdSdAbsent.Parameters.AddWithValue("@sdAbsent", text2.Text);
                    cmdSdAbsent.ExecuteNonQuery();

                    // Update lastUpdate to the current date
                    string updatelastUpdateQuery = "UPDATE amounts SET lastUpdate = GETDATE()";
                    SqlCommand cmdUpdatelastUpdate = new SqlCommand(updatelastUpdateQuery, Con);
                    cmdUpdatelastUpdate.ExecuteNonQuery();

                    // Refresh labels after the updates
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Updates are allowed only once a month.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Close the connection only if it was opened in this method
                if (Con.State == ConnectionState.Open)
                {
                    Con.Close();
                }
            }
        }


    }
}
