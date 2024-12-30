using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HRMS
{
    public partial class empProfile : Form
    {
        public string id { set; get; }

        public empProfile()
        {
            InitializeComponent();

        }
        SqlConnection Con = new SqlConnection(@"Data Source=.;Initial Catalog=hrms;Integrated Security=True");
        public void SetUserId(string userId)
        {
            Con.Open();
            string query = "select * from [user] WHERE uId= '" + userId + "'";
            SqlCommand cmd = new SqlCommand(query, Con);
            SqlDataReader dataReader = cmd.ExecuteReader();
            if (dataReader.Read())
            {
                label1.Text = dataReader["uFName"].ToString() + " " + dataReader["uLName"].ToString();
                label14.Text = dataReader["uDepartment"].ToString();
                label13.Text = dataReader["uDesignation"].ToString();
                DateTime joinDate = Convert.ToDateTime(dataReader["uJoinDate"]);
                label12.Text = joinDate.ToString("yyyy-MM-dd");
                label7.Text = dataReader["uPhn"].ToString();
                label8.Text = dataReader["uEmail"].ToString();
                label9.Text = dataReader["uAddress"].ToString();
                label10.Text = dataReader["uCNIC"].ToString();
                DateTime dob = Convert.ToDateTime(dataReader["uDOB"]);
                label11.Text = dob.ToString("yyyy-MM-dd");

                label1.Location = new Point(160, 517); // Set the appropriate X and Y values

            }
            Con.Close();
        }
        public void LoadUserProfile(string userId)
        {
            Con.Open();
            string query = "select * from [user] WHERE uId= '" + userId + "'";
            SqlCommand cmd = new SqlCommand(query, Con);
            SqlDataReader dataReader = cmd.ExecuteReader();
            if (dataReader.Read())
            {
                label1.Text = dataReader["uId"].ToString();
                // Set other labels accordingly
            }
            Con.Close();
        }

        private void empProfile_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;

        }

        private void guna2CirclePictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
    }
}
