
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
    public partial class va : Form
    {
        public va()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=.;Initial Catalog=hrms;Integrated Security=True");

        int check(string id)
        {
            Con.Open();
            string query = "select count(*) from [user] where uId='" + id + "' ";
            SqlCommand command = new SqlCommand(query, Con);
            int v = (int)command.ExecuteScalar();

            Con.Close();
            return v;
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    if (id.Text != "" && pass.Text != "" && rl.Text != "" && ln.Text != "" && email.Text != "" && pn.Text != "" && address.Text != "" && role.Text != "" && dep1.Text != "" && dp.Text != "" && gn.Text != "" && cnic.Text != "" && dob.Text != "" && joindate.Text != "" && salary.Text != "")
                    {
                        int v = check(id.Text);
                        if (v != 1)
                        {
                            Con.Open();
                            SqlCommand cmd = new SqlCommand("insert into [user] values(@uId,@uPass,@uFName,@uLName," +
                                "@uEmail,@uPhn,@uAddress,@roleId,@uDepartment,@uDesignation,@uGender,@uCNIC," +
                                "" + "@uDOB," + "@uJoinDate,@uSalary) ", Con);
                            cmd.Parameters.AddWithValue("@uId", id.Text);
                            cmd.Parameters.AddWithValue("@uPass", pass.Text);
                            int roleId = (rl.Text == "HR") ? 1 : 2;

                            cmd.Parameters.AddWithValue("@uFName", roleId);
                            cmd.Parameters.AddWithValue("@uLName", ln.Text);
                            cmd.Parameters.AddWithValue("@uEmail", email.Text);
                            cmd.Parameters.AddWithValue("@uPhn", pn.Text);
                            cmd.Parameters.AddWithValue("@uAddress", address.Text);
                            cmd.Parameters.AddWithValue("@roleId", role.Text);
                            cmd.Parameters.AddWithValue("@uDepartment", dep1.Text);
                            cmd.Parameters.AddWithValue("@uDesignation", dp.Text);
                            cmd.Parameters.AddWithValue("@uGender", gn.Text);
                            cmd.Parameters.AddWithValue("@uCNIC", cnic.Text);
                            cmd.Parameters.AddWithValue("@uDOB", Convert.ToDateTime(dob.Text));
                            cmd.Parameters.AddWithValue("@uJoinDate", Convert.ToDateTime(joindate.Text));
                            cmd.Parameters.AddWithValue("@uSalary", salary.Text);
                            foreach (SqlParameter parameter in cmd.Parameters)
                            {
                                Console.WriteLine($"{parameter.ParameterName}: {parameter.Value} (Type: {parameter.SqlDbType})");
                            }
                            cmd.ExecuteNonQuery();
                            Con.Close();
                            MessageBox.Show("Registered Successfully");
                            id.Text = "";
                            pass.Text = "";
                            rl.Text = "";
                            ln.Text = "";
                            email.Text = "";
                            pn.Text = "";
                            address.Text = "";
                            role.Text = "";
                            dep1.Text = "";
                            dp.Text = "";
                            gn.Text = "";
                            cnic.Text = "";
                            salary.Text = "";

                        }
                        else
                        {
                            MessageBox.Show("You are already Registered");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Fill in the blanks!");

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    Con.Close();
                }
            }

        }

        private void addemp_Load(object sender, EventArgs e)
        {
            // Populate the dep1 ComboBox
            dep1.Items.AddRange(new object[] { "Admin", "HR", "HOD", "Teacher" });
            dp.Items.AddRange(new object[] { "CS", "EE", "CE" });
            gn.Items.AddRange(new object[] { "Male", "Female" });
            rl.Items.AddRange(new object[] { "HR", "Employee" });
        }


        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fn_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void email_TextChanged(object sender, EventArgs e)
        {

        }

        private void ln_TextChanged(object sender, EventArgs e)
        {

        }

        private void dep_TextChanged(object sender, EventArgs e)
        {

        }

        private void dep1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dp_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rl_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void gn_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}