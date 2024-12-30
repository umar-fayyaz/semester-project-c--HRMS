namespace HRMS
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges18 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges19 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges20 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges21 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges22 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            sidebarTimer = new System.Windows.Forms.Timer(components);
            panel1 = new Panel();
            guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            button3 = new Button();
            panel6 = new Panel();
            bempProfile = new Guna.UI2.WinForms.Guna2Button();
            bempAttendance = new Guna.UI2.WinForms.Guna2Button();
            panel4 = new Panel();
            panel7 = new Panel();
            bempRecord = new Guna.UI2.WinForms.Guna2Button();
            menuButton = new PictureBox();
            panel3 = new Panel();
            guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            label3 = new Label();
            sidebar = new FlowLayoutPanel();
            label1 = new Label();
            panel2 = new Panel();
            button1 = new Button();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            panel1.SuspendLayout();
            panel6.SuspendLayout();
            panel4.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)menuButton).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)guna2CirclePictureBox1).BeginInit();
            sidebar.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // sidebarTimer
            // 
            sidebarTimer.Interval = 15;
            sidebarTimer.Tick += sidebarTimer_Tick;
            // 
            // panel1
            // 
            panel1.Controls.Add(guna2Button2);
            panel1.Location = new Point(3, 472);
            panel1.Name = "panel1";
            panel1.Size = new Size(271, 68);
            panel1.TabIndex = 13;
            // 
            // guna2Button2
            // 
            guna2Button2.BackColor = Color.Transparent;
            guna2Button2.BorderColor = Color.DarkRed;
            guna2Button2.BorderRadius = 8;
            guna2Button2.Cursor = Cursors.Hand;
            guna2Button2.CustomizableEdges = customizableEdges12;
            guna2Button2.DisabledState.BorderColor = Color.DarkGray;
            guna2Button2.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button2.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button2.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button2.FillColor = Color.Transparent;
            guna2Button2.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            guna2Button2.ForeColor = Color.White;
            guna2Button2.Image = (Image)resources.GetObject("guna2Button2.Image");
            guna2Button2.ImageAlign = HorizontalAlignment.Left;
            guna2Button2.ImageOffset = new Point(22, 0);
            guna2Button2.ImageSize = new Size(35, 35);
            guna2Button2.Location = new Point(-22, 3);
            guna2Button2.Name = "guna2Button2";
            guna2Button2.Padding = new Padding(55, 0, 0, 0);
            guna2Button2.ShadowDecoration.CustomizableEdges = customizableEdges13;
            guna2Button2.Size = new Size(300, 62);
            guna2Button2.TabIndex = 15;
            guna2Button2.Text = "LogOut";
            guna2Button2.TextAlign = HorizontalAlignment.Left;
            guna2Button2.Click += guna2Button2_Click_1;
            // 
            // button3
            // 
            button3.BackColor = Color.DarkRed;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(1244, 11);
            button3.Name = "button3";
            button3.Size = new Size(53, 52);
            button3.TabIndex = 15;
            button3.Text = "_";
            button3.UseVisualStyleBackColor = false;
            // 
            // panel6
            // 
            panel6.Controls.Add(bempProfile);
            panel6.Location = new Point(3, 261);
            panel6.Name = "panel6";
            panel6.Size = new Size(271, 65);
            panel6.TabIndex = 13;
            // 
            // bempProfile
            // 
            bempProfile.BackColor = Color.Transparent;
            bempProfile.BorderColor = Color.DarkRed;
            bempProfile.BorderRadius = 8;
            bempProfile.Cursor = Cursors.Hand;
            bempProfile.CustomizableEdges = customizableEdges14;
            bempProfile.DisabledState.BorderColor = Color.DarkGray;
            bempProfile.DisabledState.CustomBorderColor = Color.DarkGray;
            bempProfile.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            bempProfile.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            bempProfile.FillColor = Color.Transparent;
            bempProfile.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            bempProfile.ForeColor = Color.White;
            bempProfile.Image = (Image)resources.GetObject("bempProfile.Image");
            bempProfile.ImageAlign = HorizontalAlignment.Left;
            bempProfile.ImageOffset = new Point(11, 0);
            bempProfile.ImageSize = new Size(40, 40);
            bempProfile.Location = new Point(-13, 3);
            bempProfile.Name = "bempProfile";
            bempProfile.Padding = new Padding(45, 0, 0, 0);
            bempProfile.ShadowDecoration.CustomizableEdges = customizableEdges15;
            bempProfile.Size = new Size(292, 63);
            bempProfile.TabIndex = 12;
            bempProfile.Text = "Profile";
            bempProfile.TextAlign = HorizontalAlignment.Left;
            bempProfile.Click += guna2Button6_Click;
            // 
            // bempAttendance
            // 
            bempAttendance.BackColor = Color.Transparent;
            bempAttendance.BorderColor = Color.DarkRed;
            bempAttendance.BorderRadius = 8;
            bempAttendance.Cursor = Cursors.Hand;
            bempAttendance.CustomizableEdges = customizableEdges16;
            bempAttendance.DisabledState.BorderColor = Color.DarkGray;
            bempAttendance.DisabledState.CustomBorderColor = Color.DarkGray;
            bempAttendance.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            bempAttendance.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            bempAttendance.FillColor = Color.Transparent;
            bempAttendance.Font = new Font("Century Gothic", 17F, FontStyle.Bold, GraphicsUnit.Point);
            bempAttendance.ForeColor = Color.White;
            bempAttendance.Image = (Image)resources.GetObject("bempAttendance.Image");
            bempAttendance.ImageAlign = HorizontalAlignment.Left;
            bempAttendance.ImageOffset = new Point(13, 0);
            bempAttendance.ImageSize = new Size(40, 40);
            bempAttendance.Location = new Point(-16, 6);
            bempAttendance.Name = "bempAttendance";
            bempAttendance.Padding = new Padding(45, 0, 0, 0);
            bempAttendance.ShadowDecoration.CustomizableEdges = customizableEdges17;
            bempAttendance.Size = new Size(293, 57);
            bempAttendance.TabIndex = 13;
            bempAttendance.Text = "Attendance";
            bempAttendance.TextAlign = HorizontalAlignment.Left;
            bempAttendance.Click += guna2Button5_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(bempAttendance);
            panel4.Location = new Point(3, 332);
            panel4.Name = "panel4";
            panel4.Size = new Size(271, 63);
            panel4.TabIndex = 1;
            // 
            // panel7
            // 
            panel7.Controls.Add(bempRecord);
            panel7.Location = new Point(3, 401);
            panel7.Name = "panel7";
            panel7.Size = new Size(271, 65);
            panel7.TabIndex = 15;
            // 
            // bempRecord
            // 
            bempRecord.BackColor = Color.Transparent;
            bempRecord.BorderColor = Color.DarkRed;
            bempRecord.BorderRadius = 8;
            bempRecord.Cursor = Cursors.Hand;
            bempRecord.CustomizableEdges = customizableEdges18;
            bempRecord.DisabledState.BorderColor = Color.DarkGray;
            bempRecord.DisabledState.CustomBorderColor = Color.DarkGray;
            bempRecord.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            bempRecord.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            bempRecord.FillColor = Color.Transparent;
            bempRecord.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            bempRecord.ForeColor = Color.White;
            bempRecord.Image = (Image)resources.GetObject("bempRecord.Image");
            bempRecord.ImageAlign = HorizontalAlignment.Left;
            bempRecord.ImageOffset = new Point(13, 0);
            bempRecord.ImageSize = new Size(40, 40);
            bempRecord.Location = new Point(-14, 4);
            bempRecord.Name = "bempRecord";
            bempRecord.Padding = new Padding(45, 0, 0, 0);
            bempRecord.ShadowDecoration.CustomizableEdges = customizableEdges19;
            bempRecord.Size = new Size(292, 58);
            bempRecord.TabIndex = 14;
            bempRecord.Text = "Record";
            bempRecord.TextAlign = HorizontalAlignment.Left;
            bempRecord.Click += guna2Button4_Click;
            // 
            // menuButton
            // 
            menuButton.Cursor = Cursors.Hand;
            menuButton.Image = (Image)resources.GetObject("menuButton.Image");
            menuButton.Location = new Point(9, 9);
            menuButton.Name = "menuButton";
            menuButton.Size = new Size(36, 39);
            menuButton.TabIndex = 13;
            menuButton.TabStop = false;
            menuButton.Click += menuButton_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(menuButton);
            panel3.Controls.Add(guna2CirclePictureBox1);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(278, 252);
            panel3.TabIndex = 0;
            // 
            // guna2CirclePictureBox1
            // 
            guna2CirclePictureBox1.ImageRotate = 0F;
            guna2CirclePictureBox1.Location = new Point(56, 24);
            guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            guna2CirclePictureBox1.ShadowDecoration.CustomizableEdges = customizableEdges20;
            guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            guna2CirclePictureBox1.Size = new Size(171, 167);
            guna2CirclePictureBox1.TabIndex = 9;
            guna2CirclePictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Variable Display Semib", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(84, 206);
            label3.Name = "label3";
            label3.Size = new Size(124, 32);
            label3.TabIndex = 6;
            label3.Text = "Username";
            label3.Click += label3_Click;
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.FromArgb(100, 30, 22);
            sidebar.Controls.Add(panel3);
            sidebar.Controls.Add(panel6);
            sidebar.Controls.Add(panel4);
            sidebar.Controls.Add(panel7);
            sidebar.Controls.Add(panel1);
            sidebar.Dock = DockStyle.Left;
            sidebar.Location = new Point(0, 0);
            sidebar.MaximumSize = new Size(281, 680);
            sidebar.MinimumSize = new Size(58, 680);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(281, 680);
            sidebar.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(528, 19);
            label1.Name = "label1";
            label1.Size = new Size(404, 40);
            label1.TabIndex = 6;
            label1.Text = "EMPLOYEE DASHBOARD";
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkRed;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(button1);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(label1);
            panel2.ForeColor = Color.White;
            panel2.Location = new Point(-2, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1360, 79);
            panel2.TabIndex = 14;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkRed;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(1302, 11);
            button1.Name = "button1";
            button1.Size = new Size(53, 52);
            button1.TabIndex = 16;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_2;
            // 
            // guna2Button1
            // 
            guna2Button1.BorderColor = Color.DarkRed;
            guna2Button1.BorderRadius = 10;
            guna2Button1.BorderThickness = 2;
            guna2Button1.CustomizableEdges = customizableEdges21;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.White;
            guna2Button1.Font = new Font("Trebuchet MS", 18F, FontStyle.Bold, GraphicsUnit.Point);
            guna2Button1.ForeColor = Color.White;
            guna2Button1.HoverState.BorderColor = Color.White;
            guna2Button1.HoverState.CustomBorderColor = Color.White;
            guna2Button1.HoverState.FillColor = Color.White;
            guna2Button1.Location = new Point(1, 4);
            guna2Button1.MaximumSize = new Size(1355, 678);
            guna2Button1.MinimumSize = new Size(1075, 678);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges22;
            guna2Button1.Size = new Size(1355, 678);
            guna2Button1.TabIndex = 17;
            guna2Button1.TextOffset = new Point(5, 0);
            guna2Button1.Click += guna2Button1_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1360, 682);
            Controls.Add(sidebar);
            Controls.Add(panel2);
            Controls.Add(guna2Button1);
            FormBorderStyle = FormBorderStyle.None;
            IsMdiContainer = true;
            Name = "Dashboard";
            SizeGripStyle = SizeGripStyle.Show;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            Load += Dashboard_Load;
            panel1.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)menuButton).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)guna2CirclePictureBox1).EndInit();
            sidebar.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Timer sidebarTimer;
        private Panel panel1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Button button3;
        private Panel panel6;
        private Guna.UI2.WinForms.Guna2Button bempAttendance;
        private Panel panel4;
        private Guna.UI2.WinForms.Guna2Button bempProfile;
        private Panel panel7;
        private Guna.UI2.WinForms.Guna2Button bempRecord;
        private PictureBox menuButton;
        private Panel panel3;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Label label3;
        private FlowLayoutPanel sidebar;
        private Label label1;
        private Panel panel2;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Button button1;
    }
}