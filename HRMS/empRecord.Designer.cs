namespace HRMS
{
    partial class empRecord
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(components);
            label1 = new Label();
            label2 = new Label();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            attgridView = new Guna.UI2.WinForms.Guna2DataGridView();
            salgridview = new Guna.UI2.WinForms.Guna2DataGridView();
            guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            lab1 = new Label();
            label4 = new Label();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            lab2 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)attgridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)salgridview).BeginInit();
            guna2Panel2.SuspendLayout();
            guna2Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // bunifuDragControl1
            // 
            bunifuDragControl1.Fixed = true;
            bunifuDragControl1.Horizontal = true;
            bunifuDragControl1.TargetControl = null;
            bunifuDragControl1.Vertical = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Gothic", 30F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(64, 0, 0);
            label1.Location = new Point(117, 167);
            label1.Name = "label1";
            label1.Size = new Size(409, 49);
            label1.TabIndex = 18;
            label1.Text = "Attendance Record";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Century Gothic", 30F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(64, 0, 0);
            label2.Location = new Point(805, 164);
            label2.Name = "label2";
            label2.Size = new Size(290, 49);
            label2.TabIndex = 19;
            label2.Text = "Salary Record";
            // 
            // guna2Button1
            // 
            guna2Button1.BorderColor = Color.FromArgb(64, 0, 0);
            guna2Button1.BorderRadius = 16;
            guna2Button1.BorderThickness = 3;
            guna2Button1.CustomizableEdges = customizableEdges1;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.White;
            guna2Button1.Font = new Font("Arial Rounded MT Bold", 15F, FontStyle.Regular, GraphicsUnit.Point);
            guna2Button1.ForeColor = Color.FromArgb(64, 0, 0);
            guna2Button1.Location = new Point(1061, 610);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Button1.Size = new Size(127, 48);
            guna2Button1.TabIndex = 20;
            guna2Button1.Text = "Print Slip";
            guna2Button1.Click += guna2Button1_Click;
            // 
            // attgridView
            // 
            attgridView.AllowUserToAddRows = false;
            attgridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            attgridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            attgridView.BorderStyle = BorderStyle.FixedSingle;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.DarkRed;
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 20F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.DarkRed;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            attgridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            attgridView.ColumnHeadersHeight = 70;
            attgridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 20F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            attgridView.DefaultCellStyle = dataGridViewCellStyle3;
            attgridView.EditMode = DataGridViewEditMode.EditProgrammatically;
            attgridView.GridColor = Color.Brown;
            attgridView.Location = new Point(70, 243);
            attgridView.Name = "attgridView";
            attgridView.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Century Gothic", 20F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.SelectionForeColor = Color.DarkRed;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            attgridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            attgridView.RowHeadersVisible = false;
            attgridView.RowHeadersWidth = 40;
            attgridView.RowTemplate.Height = 40;
            attgridView.Size = new Size(514, 429);
            attgridView.TabIndex = 21;
            attgridView.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            attgridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            attgridView.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            attgridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            attgridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            attgridView.ThemeStyle.BackColor = Color.White;
            attgridView.ThemeStyle.GridColor = Color.Brown;
            attgridView.ThemeStyle.HeaderStyle.BackColor = Color.DarkRed;
            attgridView.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            attgridView.ThemeStyle.HeaderStyle.Font = new Font("Gadugi", 20F, FontStyle.Regular, GraphicsUnit.Point);
            attgridView.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            attgridView.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            attgridView.ThemeStyle.HeaderStyle.Height = 70;
            attgridView.ThemeStyle.ReadOnly = true;
            attgridView.ThemeStyle.RowsStyle.BackColor = Color.White;
            attgridView.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            attgridView.ThemeStyle.RowsStyle.Font = new Font("Century Gothic", 20F, FontStyle.Regular, GraphicsUnit.Point);
            attgridView.ThemeStyle.RowsStyle.ForeColor = SystemColors.ControlText;
            attgridView.ThemeStyle.RowsStyle.Height = 40;
            attgridView.ThemeStyle.RowsStyle.SelectionBackColor = Color.Maroon;
            attgridView.ThemeStyle.RowsStyle.SelectionForeColor = Color.White;
            attgridView.CellContentClick += gridView_CellContentClick;
            // 
            // salgridview
            // 
            salgridview.AllowUserToAddRows = false;
            salgridview.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = Color.White;
            salgridview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            salgridview.BorderStyle = BorderStyle.FixedSingle;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.DarkRed;
            dataGridViewCellStyle6.Font = new Font("Century Gothic", 20F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.SelectionBackColor = Color.DarkRed;
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            salgridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            salgridview.ColumnHeadersHeight = 70;
            salgridview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.White;
            dataGridViewCellStyle7.Font = new Font("Century Gothic", 20F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle7.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            salgridview.DefaultCellStyle = dataGridViewCellStyle7;
            salgridview.EditMode = DataGridViewEditMode.EditProgrammatically;
            salgridview.GridColor = Color.Brown;
            salgridview.Location = new Point(638, 374);
            salgridview.Name = "salgridview";
            salgridview.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Control;
            dataGridViewCellStyle8.Font = new Font("Century Gothic", 20F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.SelectionForeColor = Color.DarkRed;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            salgridview.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            salgridview.RowHeadersVisible = false;
            salgridview.RowHeadersWidth = 40;
            salgridview.RowTemplate.Height = 40;
            salgridview.Size = new Size(592, 298);
            salgridview.TabIndex = 22;
            salgridview.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            salgridview.ThemeStyle.AlternatingRowsStyle.Font = null;
            salgridview.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            salgridview.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            salgridview.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            salgridview.ThemeStyle.BackColor = Color.White;
            salgridview.ThemeStyle.GridColor = Color.Brown;
            salgridview.ThemeStyle.HeaderStyle.BackColor = Color.DarkRed;
            salgridview.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            salgridview.ThemeStyle.HeaderStyle.Font = new Font("Gadugi", 20F, FontStyle.Regular, GraphicsUnit.Point);
            salgridview.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            salgridview.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            salgridview.ThemeStyle.HeaderStyle.Height = 70;
            salgridview.ThemeStyle.ReadOnly = true;
            salgridview.ThemeStyle.RowsStyle.BackColor = Color.White;
            salgridview.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            salgridview.ThemeStyle.RowsStyle.Font = new Font("Century Gothic", 20F, FontStyle.Regular, GraphicsUnit.Point);
            salgridview.ThemeStyle.RowsStyle.ForeColor = SystemColors.ControlText;
            salgridview.ThemeStyle.RowsStyle.Height = 40;
            salgridview.ThemeStyle.RowsStyle.SelectionBackColor = Color.Maroon;
            salgridview.ThemeStyle.RowsStyle.SelectionForeColor = Color.White;
            salgridview.CellContentClick += salgridview_CellContentClick;
            // 
            // guna2Panel2
            // 
            guna2Panel2.BackColor = Color.Transparent;
            guna2Panel2.BorderColor = Color.Maroon;
            guna2Panel2.BorderRadius = 36;
            guna2Panel2.BorderThickness = 4;
            guna2Panel2.Controls.Add(lab1);
            guna2Panel2.Controls.Add(label4);
            guna2Panel2.CustomizableEdges = customizableEdges3;
            guna2Panel2.Location = new Point(672, 243);
            guna2Panel2.Name = "guna2Panel2";
            guna2Panel2.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2Panel2.Size = new Size(250, 106);
            guna2Panel2.TabIndex = 23;
            // 
            // lab1
            // 
            lab1.AutoSize = true;
            lab1.Font = new Font("Century Gothic", 35.25F, FontStyle.Regular, GraphicsUnit.Point);
            lab1.ForeColor = Color.Maroon;
            lab1.Location = new Point(88, 43);
            lab1.Name = "lab1";
            lab1.Size = new Size(77, 57);
            lab1.TabIndex = 1;
            lab1.Text = "73";
            lab1.Click += showsdAbsent_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 17F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(36, 15);
            label4.Name = "label4";
            label4.Size = new Size(192, 27);
            label4.TabIndex = 0;
            label4.Text = "Limit Of Absents";
            // 
            // guna2Panel1
            // 
            guna2Panel1.BackColor = Color.Transparent;
            guna2Panel1.BorderColor = Color.Maroon;
            guna2Panel1.BorderRadius = 36;
            guna2Panel1.BorderThickness = 4;
            guna2Panel1.Controls.Add(lab2);
            guna2Panel1.Controls.Add(label6);
            guna2Panel1.CustomizableEdges = customizableEdges5;
            guna2Panel1.Location = new Point(949, 243);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2Panel1.Size = new Size(250, 106);
            guna2Panel1.TabIndex = 24;
            // 
            // lab2
            // 
            lab2.AutoSize = true;
            lab2.Font = new Font("Century Gothic", 35.25F, FontStyle.Regular, GraphicsUnit.Point);
            lab2.ForeColor = Color.Maroon;
            lab2.Location = new Point(70, 43);
            lab2.Name = "lab2";
            lab2.Size = new Size(77, 57);
            lab2.TabIndex = 1;
            lab2.Text = "73";
            lab2.Click += showsdAmount_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(18, 16);
            label6.Name = "label6";
            label6.Size = new Size(216, 25);
            label6.TabIndex = 0;
            label6.Text = "Deduction Amount";
            // 
            // empRecord
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1314, 703);
            Controls.Add(guna2Panel1);
            Controls.Add(guna2Panel2);
            Controls.Add(attgridView);
            Controls.Add(guna2Button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(salgridview);
            FormBorderStyle = FormBorderStyle.None;
            Name = "empRecord";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "empRecord";
            Load += empRecord_Load;
            ((System.ComponentModel.ISupportInitialize)attgridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)salgridview).EndInit();
            guna2Panel2.ResumeLayout(false);
            guna2Panel2.PerformLayout();
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Label label1;
        private Label label2;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2DataGridView attgridView;
        private Guna.UI2.WinForms.Guna2DataGridView salgridview;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Label lab1;
        private Label label4;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Label lab2;
        private Label label6;
    }
}