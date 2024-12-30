using Microsoft.VisualBasic;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;

namespace HRMS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            DoubleBuffered = true;


        }
        SqlConnection Con = new SqlConnection(@"Data Source=.;Initial Catalog=hrms;Integrated Security=True");


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "" && txtpassword.Text != "")
            {
                string query = "select count(*) from [user] where uId='" + txtId.Text + "' and " +
                    "uPass='" + txtpassword.Text + "'";
                Con.Open();
                SqlCommand cmd = new SqlCommand(query, Con);
                int v = (int)cmd.ExecuteScalar();
                if (v != 1)
                {
                    MessageBox.Show("Invalid ID or Password!");
                    txtpassword.Clear();
                    txtId.Clear();
                    txtId.Focus();
                }


                else
                {
                    // Now, check the roleId
                    query = "SELECT roleId FROM [user] WHERE uId='" + txtId.Text + "'";
                    cmd = new SqlCommand(query, Con);
                    int roleId = (int)cmd.ExecuteScalar();

                    // Redirect based on roleId
                    if (roleId == 1)
                    {
                        new HRdashboard().Show();
                    }
                    else if (roleId == 2)
                    {

                        string q = "select * from [user] where uId='" + txtId.Text + "' and uPass='" + txtpassword.Text + "'  ";
                        SqlCommand command = new SqlCommand(q, Con);
                        SqlDataReader dataReader;
                        dataReader = command.ExecuteReader();
                        if (dataReader.HasRows)
                        {
                            Dashboard dashboard = new Dashboard(txtId.Text); // Pass txtId to Dashboard
                            this.Hide();
                            dashboard.Show();
                        }
                        else
                        {
                            MessageBox.Show("Invalid ID or Password!");
                        }
                    }
                    else
                    {

                        MessageBox.Show("Invalid roleId!");  // Handle other roleId values as needed
                    }

                    this.Hide();
                }
                Con.Close();
            }
            else
            {
                MessageBox.Show("Fill in!");

            }
        }


        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Prompt the user for uId and uCNIC
            string uId = Interaction.InputBox("Enter uId:", "Change Password", "");
            string uCNIC = Interaction.InputBox("Enter uCNIC:", "Change Password", "");

            // Check if uId and uCNIC are provided
            if (!string.IsNullOrEmpty(uId) && !string.IsNullOrEmpty(uCNIC))
            {
                // Verify uCNIC against the provided uId in the database
                string query = "SELECT COUNT(*) FROM [user] WHERE uId='" + uId + "' AND uCNIC='" + uCNIC + "'";
                SqlCommand cmd = new SqlCommand(query, Con);
                Con.Open();
                int count = (int)cmd.ExecuteScalar();
                Con.Close();

                if (count == 1)
                {
                    // If uCNIC is correct, prompt the user for a new password
                    string newPassword = Interaction.InputBox("Enter new password:", "Change Password", "");

                    // Update the password in the database
                    if (!string.IsNullOrEmpty(newPassword))
                    {
                        query = "UPDATE [user] SET uPass='" + newPassword + "' WHERE uId='" + uId + "'";
                        Con.Open();
                        cmd = new SqlCommand(query, Con);
                        cmd.ExecuteNonQuery();
                        Con.Close();

                        MessageBox.Show("Password changed successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Invalid password!");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid uId or uCNIC!");
                }
            }
            else
            {
                MessageBox.Show("Please provide uId and uCNIC!");
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Prompt the user for a phone number
            string phoneNumber = Interaction.InputBox("Enter phone number:", "Retrieve uId", "");

            // Check if a phone number is provided
            if (!string.IsNullOrEmpty(phoneNumber))
            {
                // Execute a SQL query to retrieve uId based on the provided phone number
                string query = "SELECT uId FROM [user] WHERE uPhn='" + phoneNumber + "'";
                SqlCommand cmd = new SqlCommand(query, Con);

                try
                {
                    Con.Open();
                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        // Display the retrieved uId in a message box
                        MessageBox.Show("Your ID is  " + result.ToString());
                    }
                    else
                    {
                        MessageBox.Show("No user found with the provided phone number.");
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
            else
            {
                MessageBox.Show("Please provide a phone number!");
            }
        }

    }
}