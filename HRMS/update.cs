using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRMS
{
    public partial class update : Form
    {
        public update()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=.;Initial Catalog=hrms;Integrated Security=True");


        private void email_TextChanged(object sender, EventArgs e)
        {

        }
        public void PopulateForm(SqlDataReader reader)
        {
            // Populate form fields with data from the database
            id.Text = reader["uId"].ToString();
            pass.Text = reader["uPass"].ToString();
            fn.Text = reader["uFName"].ToString();
            ln.Text = reader["uLName"].ToString();
            email.Text = reader["uEmail"].ToString();
            pn.Text = reader["uPhn"].ToString();
            address.Text = reader["uAddress"].ToString();
            role.Text = reader["roleId"].ToString();
            dep.Text = reader["uDepartment"].ToString();
            desig.Text = reader["uDesignation"].ToString();
            gender.Text = reader["uGender"].ToString();
            cnic.Text = reader["uCNIC"].ToString();
            dob.Text = reader["uDOB"].ToString(); // You might need to format the date
            joindate.Text = reader["uJoinDate"].ToString(); // You might need to format the date
            salary.Text = reader["uSalary"].ToString();
        }

        private void ln_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Update data in the database
                Con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE [user] SET uPass = @uPass, uFName = @uFName, uLName = @uLName, " +
                    "uEmail = @uEmail, uPhn = @uPhn, uAddress = @uAddress, roleId = @roleId, uDepartment = @uDepartment, " +
                    "uDesignation = @uDesignation, uGender = @uGender, uCNIC = @uCNIC, uDOB = @uDOB, uJoinDate = @uJoinDate, " +
                    "uSalary = @uSalary WHERE uId = @uId", Con);

                // Add parameters
                cmd.Parameters.AddWithValue("@uId", id.Text);
                cmd.Parameters.AddWithValue("@uPass", pass.Text);
                cmd.Parameters.AddWithValue("@uFName", fn.Text);
                cmd.Parameters.AddWithValue("@uLName", ln.Text);
                cmd.Parameters.AddWithValue("@uEmail", email.Text);
                cmd.Parameters.AddWithValue("@uPhn", pn.Text);
                cmd.Parameters.AddWithValue("@uAddress", address.Text);
                cmd.Parameters.AddWithValue("@roleId", role.Text);
                cmd.Parameters.AddWithValue("@uDepartment", dep.Text);
                cmd.Parameters.AddWithValue("@uDesignation", desig.Text);
                cmd.Parameters.AddWithValue("@uGender", gender.Text);
                cmd.Parameters.AddWithValue("@uCNIC", cnic.Text);
                cmd.Parameters.AddWithValue("@uDOB", Convert.ToDateTime(dob.Text));
                cmd.Parameters.AddWithValue("@uJoinDate", Convert.ToDateTime(joindate.Text));
                cmd.Parameters.AddWithValue("@uSalary", salary.Text);

                cmd.ExecuteNonQuery();
                Con.Close();
                MessageBox.Show("Record updated successfully.");

                // Close the form
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fn_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
