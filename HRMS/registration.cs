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
using System.Net;

namespace HRMS
{
    public partial class registration : Form
    {
        public registration()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=.;Initial Catalog=hrms;Integrated Security=True");


        private void InitializeComponent()
        {
            ComponentResourceManager resources = new ComponentResourceManager(typeof(registration));
            SuspendLayout();
            // 
            // registration
            // 
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(736, 676);
            Font = new Font("Britannic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "registration";
            StartPosition = FormStartPosition.CenterScreen;
            Load += registration_Load;
            ResumeLayout(false);
        }

        private void registration_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
      

        int check(string id)
        {
            Con.Open();
            string query = "select count(*) from user where uId='" + id + "' ";
            SqlCommand command = new SqlCommand(query, Con);
            int v = (int)command.ExecuteScalar();

            Con.Close();
            return v;
        }
    }
}
