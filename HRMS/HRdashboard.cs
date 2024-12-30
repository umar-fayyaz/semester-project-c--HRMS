using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HRMS
{

    public partial class HRdashboard : Form
    {
        HRattendance att;
        HREmployees prof;
        HRRecord rec;

        bool sidebarExpand;
        public HRdashboard()
        {
            InitializeComponent();
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.DoubleBuffer, true);
            this.MdiChildActivate += HRdashboard_MdiChildActivate;
        }
        SqlConnection Con = new SqlConnection(@"Data Source=.;Initial Catalog=hrms;Integrated Security=True");

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;   // WS_EX_COMPOSITED
                return cp;
            }
        }


        private void guna2Button6_Click(object sender, EventArgs e)
        {


            if (prof == null)
            {

                prof = new HREmployees();
                prof.FormClosed += profile_FormClosed;
                prof.MdiParent = this;
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
                rec = new HRRecord();
                rec.FormClosed += record_FormClosed;
                rec.MdiParent = this;
                rec.Show();
            }
            else
            {
                rec.Activate();

            }
            rec.WindowState = FormWindowState.Maximized;
        }

        private void record_FormClosed(object sender, FormClosedEventArgs e)
        {
            rec = null;
        }


        private void guna2Button5_Click(object sender, EventArgs e)
        {
            if (att == null)
            {
                att = new HRattendance();

                att.FormClosed += attendance_FormClosed;
                att.MdiParent = this;
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

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void HRdashboard_Load(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel8_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void HRdashboard_Load_1(object sender, EventArgs e)
        {

        }

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 30;
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();

                }
            }
            else
            {
                sidebar.Width += 30;
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

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Form1 home = new Form1();
            home.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
        }

        private void sidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint_1(object sender, PaintEventArgs e)
        {
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }
        private void HRdashboard_MdiChildActivate(object sender, EventArgs e)
        {
            // Check if any MDI child form is active
            if (this.ActiveMdiChild != null)
            {
                // If an MDI child form is active, hide guna2Button1
                guna2Button1.Visible = false;

                // Update label1.Text based on the active MDI child form
                if (this.ActiveMdiChild is HRattendance)
                {
                    label1.Text = "Attendance and Leave Management";
                }
                else if (this.ActiveMdiChild is HRRecord)
                {
                    label1.Text = "Salary Record";
                }
                else if (this.ActiveMdiChild is HREmployees)
                {
                    label1.Text = "Employees";
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


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }
    }
}
