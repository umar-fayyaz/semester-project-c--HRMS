namespace HRMS
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(components);
            groupBox1 = new GroupBox();
            linkLabel2 = new LinkLabel();
            linkLabel1 = new LinkLabel();
            button1 = new Button();
            txtpassword = new Guna.UI2.WinForms.Guna2TextBox();
            label2 = new Label();
            txtId = new Guna.UI2.WinForms.Guna2TextBox();
            label1 = new Label();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // bunifuDragControl1
            // 
            bunifuDragControl1.Fixed = true;
            bunifuDragControl1.Horizontal = true;
            bunifuDragControl1.TargetControl = null;
            bunifuDragControl1.Vertical = true;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(linkLabel2);
            groupBox1.Controls.Add(linkLabel1);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(txtpassword);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtId);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.ForeColor = SystemColors.ControlLightLight;
            groupBox1.Location = new Point(277, 116);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(468, 291);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Log In Here";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel2.LinkColor = Color.White;
            linkLabel2.Location = new Point(256, 243);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(94, 17);
            linkLabel2.TabIndex = 8;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Forgot You ID?";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel1.LinkColor = Color.White;
            linkLabel1.Location = new Point(277, 156);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(113, 17);
            linkLabel1.TabIndex = 7;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Change Password";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked_1;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.FlatStyle = FlatStyle.Popup;
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(219, 195);
            button1.Name = "button1";
            button1.Size = new Size(154, 41);
            button1.TabIndex = 6;
            button1.Text = "LogIn";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtpassword
            // 
            txtpassword.BorderRadius = 5;
            txtpassword.CustomizableEdges = customizableEdges1;
            txtpassword.DefaultText = "";
            txtpassword.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtpassword.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtpassword.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtpassword.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtpassword.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtpassword.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtpassword.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtpassword.IconRightCursor = Cursors.Hand;
            txtpassword.Location = new Point(190, 116);
            txtpassword.Name = "txtpassword";
            txtpassword.PasswordChar = '●';
            txtpassword.PlaceholderText = "";
            txtpassword.SelectedText = "";
            txtpassword.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtpassword.Size = new Size(200, 34);
            txtpassword.TabIndex = 4;
            txtpassword.UseSystemPasswordChar = true;
            txtpassword.TextChanged += guna2TextBox2_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 126);
            label2.Name = "label2";
            label2.Size = new Size(82, 21);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // txtId
            // 
            txtId.BorderRadius = 5;
            txtId.CustomizableEdges = customizableEdges3;
            txtId.DefaultText = "";
            txtId.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtId.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtId.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtId.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtId.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtId.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtId.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtId.Location = new Point(190, 65);
            txtId.Name = "txtId";
            txtId.PasswordChar = '\0';
            txtId.PlaceholderText = "";
            txtId.SelectedText = "";
            txtId.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtId.Size = new Size(200, 34);
            txtId.TabIndex = 2;
            txtId.TextChanged += txtId_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(60, 73);
            label1.Name = "label1";
            label1.Size = new Size(27, 21);
            label1.TabIndex = 1;
            label1.Text = "ID";
            // 
            // button2
            // 
            button2.BackColor = Color.Black;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Century Gothic", 20F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(750, -2);
            button2.Name = "button2";
            button2.Size = new Size(52, 43);
            button2.TabIndex = 7;
            button2.Text = "X";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(37, 172);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(192, 192);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial Rounded MT Bold", 30F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(173, 38);
            label3.Name = "label3";
            label3.Size = new Size(494, 46);
            label3.TabIndex = 9;
            label3.Text = "HR Management System";
            label3.Click += label3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkRed;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2TextBox txtId;
        private Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtpassword;
        private Label label2;
        private Button button1;
        private Button button2;
        private PictureBox pictureBox1;
        private Label label3;
        private LinkLabel linkLabel1;
        private LinkLabel linkLabel2;
    }
}