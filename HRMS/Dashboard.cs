
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
    public partial class Dashboard : Form
    {

        empAttendance att;
        empProfile prof;
        empRecord rec;

        private bool isDashboardOpen = false;

        bool sidebarExpand;
        private string userId;
        public Dashboard(string userId)
        {
            InitializeComponent();
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.DoubleBuffer, true);
            this.MdiChildActivate += dashboard_MdiChildActivate;
            this.userId = userId;
        }
        SqlConnection Con = new SqlConnection(@"Data Source=.;Initial Catalog=hrms;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            Con.Open();
            string query = "select * from [user] WHERE uId= '" + userId + "'";
            SqlCommand cmd = new SqlCommand(query, Con);
            SqlDataReader dataReader = cmd.ExecuteReader();
            if (dataReader.Read())
            {
                label3.Text = dataReader["uFName"].ToString() + " " + dataReader["uLName"].ToString();
            }

            Con.Close();
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            // Center label3 within panel3
            int x = (panel3.Width - label3.Width) / 2;
            int y = panel3.Height - label3.Height;
            label3.Location = new Point(x, y);

        }

        private void panel3_SizeChanged(object sender, EventArgs e)
        {
            // Recalculate and set the position of label3 when the size of panel3 changes
            int x = (panel3.Width - label3.Width) / 2;
            int y = (panel3.Height - label3.Height) / 2;
            label3.Location = new Point(x, y);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click_1(object sender, EventArgs e)
        {
            Form1 home = new Form1();
            home.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();


                }
            }

        }

        private void menuButton_Click(object sender, EventArgs e)
        {

            sidebarTimer.Start();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            HRdashboard swi = new HRdashboard();
            swi.Show();
            this.Hide();
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            if (prof == null)
            {
                prof = new empProfile();
                prof.FormClosed += profile_FormClosed;
                prof.MdiParent = this;

                prof.SetUserId(userId);
                prof.Show();
            }
            else
            {
                prof.Activate();

            }
            prof.WindowState = FormWindowState.Maximized;
        }
        private void profile_FormClosed(object sender, FormClosedEventArgs e)
        {
            prof = null;
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            if (rec == null)
            {
                rec = new empRecord();
                rec.FormClosed += record_FormClosed;
                rec.MdiParent = this;
                rec.SetUserId(userId);
                rec.Show();
            }
            else
            {
                rec.Activate();

            }
            rec.WindowState = FormWindowState.Maximized;
        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;   // WS_EX_COMPOSITED
                return cp;
            }
        }
        private void record_FormClosed(object sender, FormClosedEventArgs e)
        {
            rec = null;
        }
        private void guna2Button5_Click(object sender, EventArgs e)
        {
            if (att == null)
            {
                att = new empAttendance();
                att.FormClosed += attendance_FormClosed;
                att.MdiParent = this;
                att.SetUserId(userId);
                att.Show();
            }
            else
            {
                att.Activate();

            }

            att.WindowState = FormWindowState.Maximized;
        }
        private void attendance_FormClosed(object sender, FormClosedEventArgs e)
        {
            att = null;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void dashboard_MdiChildActivate(object sender, EventArgs e)
        {
            // Check if any MDI child form is active
            if (this.ActiveMdiChild != null)
            {
                // If an MDI child form is active, hide guna2Button1
                guna2Button1.Visible = false;

                // Update label1.Text based on the active MDI child form
                if (this.ActiveMdiChild is empAttendance)
                {
                    label1.Text = "Attendance and Leave";
                }
                else if (this.ActiveMdiChild is empRecord)
                {
                    label1.Text = "Records";
                }
                else if (this.ActiveMdiChild is empProfile)
                {
                    label1.Text = "Profile";
                }

                // Center label1 within panel2
                int x = (panel2.Width - label1.Width) / 2;
                int y = (panel2.Height - label1.Height) / 2;
                label1.Location = new Point(x, y);
            }
            else
            {
                // If no MDI child form is active, show guna2Button1
                guna2Button1.Visible = true;

                // Set label1.Text to a default value when no MDI child is active
                label1.Text = "Default Text";

                // Center label1 within panel2
                int x = (panel2.Width - label1.Width) / 2;
                int y = (panel2.Height - label1.Height) / 2;
                label1.Location = new Point(x, y);
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}