namespace Blood_Management_System
{
	partial class formHome
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formHome));
			this.topBarStrip = new System.Windows.Forms.MenuStrip();
			this.contactUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.panel1 = new System.Windows.Forms.Panel();
			this.developerLabel = new System.Windows.Forms.Label();
			this.developedBy = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.OPosCount = new System.Windows.Forms.Label();
			this.oPositive = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label4 = new System.Windows.Forms.Label();
			this.ONegCount = new System.Windows.Forms.Label();
			this.ONegative = new System.Windows.Forms.Label();
			this.panel4 = new System.Windows.Forms.Panel();
			this.label7 = new System.Windows.Forms.Label();
			this.ANegCount = new System.Windows.Forms.Label();
			this.ANegative = new System.Windows.Forms.Label();
			this.panel5 = new System.Windows.Forms.Panel();
			this.label10 = new System.Windows.Forms.Label();
			this.APosCount = new System.Windows.Forms.Label();
			this.APositive = new System.Windows.Forms.Label();
			this.panel6 = new System.Windows.Forms.Panel();
			this.label13 = new System.Windows.Forms.Label();
			this.ABNegCount = new System.Windows.Forms.Label();
			this.ABNegative = new System.Windows.Forms.Label();
			this.panel7 = new System.Windows.Forms.Panel();
			this.label16 = new System.Windows.Forms.Label();
			this.ABPosCount = new System.Windows.Forms.Label();
			this.BNegative = new System.Windows.Forms.Label();
			this.panel8 = new System.Windows.Forms.Panel();
			this.label19 = new System.Windows.Forms.Label();
			this.BNegCount = new System.Windows.Forms.Label();
			this.ABPositive = new System.Windows.Forms.Label();
			this.panel9 = new System.Windows.Forms.Panel();
			this.label22 = new System.Windows.Forms.Label();
			this.BPosCount = new System.Windows.Forms.Label();
			this.BPositive = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.searchButton = new System.Windows.Forms.Button();
			this.searchBar = new System.Windows.Forms.TextBox();
			this.topBarStrip.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel5.SuspendLayout();
			this.panel6.SuspendLayout();
			this.panel7.SuspendLayout();
			this.panel8.SuspendLayout();
			this.panel9.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// topBarStrip
			// 
			this.topBarStrip.BackColor = System.Drawing.Color.CornflowerBlue;
			this.topBarStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.topBarStrip.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.topBarStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.topBarStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contactUsToolStripMenuItem,
            this.homeToolStripMenuItem});
			this.topBarStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
			this.topBarStrip.Location = new System.Drawing.Point(0, 0);
			this.topBarStrip.Name = "topBarStrip";
			this.topBarStrip.Padding = new System.Windows.Forms.Padding(6, 7, 0, 7);
			this.topBarStrip.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.topBarStrip.Size = new System.Drawing.Size(1135, 49);
			this.topBarStrip.TabIndex = 0;
			this.topBarStrip.Text = "menubar";
			this.topBarStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.topBarStrip_ItemClicked);
			// 
			// contactUsToolStripMenuItem
			// 
			this.contactUsToolStripMenuItem.Name = "contactUsToolStripMenuItem";
			this.contactUsToolStripMenuItem.Size = new System.Drawing.Size(76, 35);
			this.contactUsToolStripMenuItem.Text = "User";
			this.contactUsToolStripMenuItem.Click += new System.EventHandler(this.contactUsToolStripMenuItem_Click);
			// 
			// homeToolStripMenuItem
			// 
			this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
			this.homeToolStripMenuItem.Size = new System.Drawing.Size(96, 35);
			this.homeToolStripMenuItem.Text = "Donor";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.SteelBlue;
			this.panel1.Controls.Add(this.developerLabel);
			this.panel1.Controls.Add(this.developedBy);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 700);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1135, 100);
			this.panel1.TabIndex = 1;
			// 
			// developerLabel
			// 
			this.developerLabel.AutoSize = true;
			this.developerLabel.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.developerLabel.Location = new System.Drawing.Point(684, 19);
			this.developerLabel.Name = "developerLabel";
			this.developerLabel.Size = new System.Drawing.Size(226, 46);
			this.developerLabel.TabIndex = 3;
			this.developerLabel.Text = "Nischal Joshi";
			// 
			// developedBy
			// 
			this.developedBy.AutoSize = true;
			this.developedBy.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.developedBy.Location = new System.Drawing.Point(427, 19);
			this.developedBy.Name = "developedBy";
			this.developedBy.Size = new System.Drawing.Size(262, 46);
			this.developedBy.TabIndex = 2;
			this.developedBy.Text = "Developed By -";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label1.ForeColor = System.Drawing.Color.Firebrick;
			this.label1.Location = new System.Drawing.Point(74, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(347, 46);
			this.label1.TabIndex = 0;
			this.label1.Text = "BloodBank Manager";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.OPosCount);
			this.panel2.Controls.Add(this.oPositive);
			this.panel2.Location = new System.Drawing.Point(12, 74);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(250, 125);
			this.panel2.TabIndex = 2;
			this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label3.Location = new System.Drawing.Point(138, 64);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(80, 28);
			this.label3.TabIndex = 4;
			this.label3.Text = "Donors";
			// 
			// OPosCount
			// 
			this.OPosCount.AutoSize = true;
			this.OPosCount.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.OPosCount.ForeColor = System.Drawing.Color.Red;
			this.OPosCount.Location = new System.Drawing.Point(149, 10);
			this.OPosCount.Name = "OPosCount";
			this.OPosCount.Size = new System.Drawing.Size(69, 54);
			this.OPosCount.TabIndex = 4;
			this.OPosCount.Text = "50";
			// 
			// oPositive
			// 
			this.oPositive.AutoSize = true;
			this.oPositive.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.oPositive.ForeColor = System.Drawing.Color.Red;
			this.oPositive.Location = new System.Drawing.Point(19, 38);
			this.oPositive.Name = "oPositive";
			this.oPositive.Size = new System.Drawing.Size(81, 54);
			this.oPositive.TabIndex = 3;
			this.oPositive.Text = "O+";
			this.oPositive.Click += new System.EventHandler(this.label2_Click);
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.SystemColors.ControlLight;
			this.panel3.Controls.Add(this.label4);
			this.panel3.Controls.Add(this.ONegCount);
			this.panel3.Controls.Add(this.ONegative);
			this.panel3.Location = new System.Drawing.Point(300, 74);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(250, 125);
			this.panel3.TabIndex = 5;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label4.Location = new System.Drawing.Point(138, 64);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(80, 28);
			this.label4.TabIndex = 4;
			this.label4.Text = "Donors";
			// 
			// ONegCount
			// 
			this.ONegCount.AutoSize = true;
			this.ONegCount.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.ONegCount.ForeColor = System.Drawing.Color.Red;
			this.ONegCount.Location = new System.Drawing.Point(149, 10);
			this.ONegCount.Name = "ONegCount";
			this.ONegCount.Size = new System.Drawing.Size(69, 54);
			this.ONegCount.TabIndex = 4;
			this.ONegCount.Text = "50";
			// 
			// ONegative
			// 
			this.ONegative.AutoSize = true;
			this.ONegative.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.ONegative.ForeColor = System.Drawing.Color.Red;
			this.ONegative.Location = new System.Drawing.Point(31, 38);
			this.ONegative.Name = "ONegative";
			this.ONegative.Size = new System.Drawing.Size(69, 54);
			this.ONegative.TabIndex = 3;
			this.ONegative.Text = "O-";
			this.ONegative.Click += new System.EventHandler(this.label6_Click);
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.SystemColors.ControlLight;
			this.panel4.Controls.Add(this.label7);
			this.panel4.Controls.Add(this.ANegCount);
			this.panel4.Controls.Add(this.ANegative);
			this.panel4.Location = new System.Drawing.Point(300, 221);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(250, 125);
			this.panel4.TabIndex = 7;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label7.Location = new System.Drawing.Point(138, 64);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(80, 28);
			this.label7.TabIndex = 4;
			this.label7.Text = "Donors";
			// 
			// ANegCount
			// 
			this.ANegCount.AutoSize = true;
			this.ANegCount.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.ANegCount.ForeColor = System.Drawing.Color.Red;
			this.ANegCount.Location = new System.Drawing.Point(149, 10);
			this.ANegCount.Name = "ANegCount";
			this.ANegCount.Size = new System.Drawing.Size(69, 54);
			this.ANegCount.TabIndex = 4;
			this.ANegCount.Text = "50";
			// 
			// ANegative
			// 
			this.ANegative.AutoSize = true;
			this.ANegative.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.ANegative.ForeColor = System.Drawing.Color.Red;
			this.ANegative.Location = new System.Drawing.Point(42, 38);
			this.ANegative.Name = "ANegative";
			this.ANegative.Size = new System.Drawing.Size(67, 54);
			this.ANegative.TabIndex = 3;
			this.ANegative.Text = "A-";
			this.ANegative.Click += new System.EventHandler(this.label9_Click);
			// 
			// panel5
			// 
			this.panel5.BackColor = System.Drawing.SystemColors.ControlLight;
			this.panel5.Controls.Add(this.label10);
			this.panel5.Controls.Add(this.APosCount);
			this.panel5.Controls.Add(this.APositive);
			this.panel5.Location = new System.Drawing.Point(12, 221);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(250, 125);
			this.panel5.TabIndex = 6;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label10.Location = new System.Drawing.Point(138, 64);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(80, 28);
			this.label10.TabIndex = 4;
			this.label10.Text = "Donors";
			// 
			// APosCount
			// 
			this.APosCount.AutoSize = true;
			this.APosCount.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.APosCount.ForeColor = System.Drawing.Color.Red;
			this.APosCount.Location = new System.Drawing.Point(149, 10);
			this.APosCount.Name = "APosCount";
			this.APosCount.Size = new System.Drawing.Size(69, 54);
			this.APosCount.TabIndex = 4;
			this.APosCount.Text = "50";
			// 
			// APositive
			// 
			this.APositive.AutoSize = true;
			this.APositive.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.APositive.ForeColor = System.Drawing.Color.Red;
			this.APositive.Location = new System.Drawing.Point(21, 38);
			this.APositive.Name = "APositive";
			this.APositive.Size = new System.Drawing.Size(79, 54);
			this.APositive.TabIndex = 3;
			this.APositive.Text = "A+";
			// 
			// panel6
			// 
			this.panel6.BackColor = System.Drawing.SystemColors.ControlLight;
			this.panel6.Controls.Add(this.label13);
			this.panel6.Controls.Add(this.ABNegCount);
			this.panel6.Controls.Add(this.ABNegative);
			this.panel6.Location = new System.Drawing.Point(300, 520);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(250, 125);
			this.panel6.TabIndex = 11;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label13.Location = new System.Drawing.Point(138, 64);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(80, 28);
			this.label13.TabIndex = 4;
			this.label13.Text = "Donors";
			// 
			// ABNegCount
			// 
			this.ABNegCount.AutoSize = true;
			this.ABNegCount.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.ABNegCount.ForeColor = System.Drawing.Color.Red;
			this.ABNegCount.Location = new System.Drawing.Point(149, 10);
			this.ABNegCount.Name = "ABNegCount";
			this.ABNegCount.Size = new System.Drawing.Size(69, 54);
			this.ABNegCount.TabIndex = 4;
			this.ABNegCount.Text = "50";
			// 
			// ABNegative
			// 
			this.ABNegative.AutoSize = true;
			this.ABNegative.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.ABNegative.ForeColor = System.Drawing.Color.Red;
			this.ABNegative.Location = new System.Drawing.Point(31, 38);
			this.ABNegative.Name = "ABNegative";
			this.ABNegative.Size = new System.Drawing.Size(93, 54);
			this.ABNegative.TabIndex = 3;
			this.ABNegative.Text = "AB-";
			this.ABNegative.Click += new System.EventHandler(this.label15_Click);
			// 
			// panel7
			// 
			this.panel7.BackColor = System.Drawing.SystemColors.ControlLight;
			this.panel7.Controls.Add(this.label16);
			this.panel7.Controls.Add(this.ABPosCount);
			this.panel7.Controls.Add(this.ABPositive);
			this.panel7.Location = new System.Drawing.Point(12, 520);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(250, 125);
			this.panel7.TabIndex = 10;
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label16.Location = new System.Drawing.Point(138, 64);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(80, 28);
			this.label16.TabIndex = 4;
			this.label16.Text = "Donors";
			// 
			// ABPosCount
			// 
			this.ABPosCount.AutoSize = true;
			this.ABPosCount.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.ABPosCount.ForeColor = System.Drawing.Color.Red;
			this.ABPosCount.Location = new System.Drawing.Point(149, 10);
			this.ABPosCount.Name = "ABPosCount";
			this.ABPosCount.Size = new System.Drawing.Size(69, 54);
			this.ABPosCount.TabIndex = 4;
			this.ABPosCount.Text = "50";
			// 
			// BNegative
			// 
			this.BNegative.AutoSize = true;
			this.BNegative.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.BNegative.ForeColor = System.Drawing.Color.Red;
			this.BNegative.Location = new System.Drawing.Point(31, 38);
			this.BNegative.Name = "BNegative";
			this.BNegative.Size = new System.Drawing.Size(65, 54);
			this.BNegative.TabIndex = 3;
			this.BNegative.Text = "B-";
			// 
			// panel8
			// 
			this.panel8.BackColor = System.Drawing.SystemColors.ControlLight;
			this.panel8.Controls.Add(this.label19);
			this.panel8.Controls.Add(this.BNegCount);
			this.panel8.Controls.Add(this.BNegative);
			this.panel8.Location = new System.Drawing.Point(300, 373);
			this.panel8.Name = "panel8";
			this.panel8.Size = new System.Drawing.Size(250, 125);
			this.panel8.TabIndex = 9;
			// 
			// label19
			// 
			this.label19.AutoSize = true;
			this.label19.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label19.Location = new System.Drawing.Point(138, 64);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(80, 28);
			this.label19.TabIndex = 4;
			this.label19.Text = "Donors";
			// 
			// BNegCount
			// 
			this.BNegCount.AutoSize = true;
			this.BNegCount.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.BNegCount.ForeColor = System.Drawing.Color.Red;
			this.BNegCount.Location = new System.Drawing.Point(149, 10);
			this.BNegCount.Name = "BNegCount";
			this.BNegCount.Size = new System.Drawing.Size(69, 54);
			this.BNegCount.TabIndex = 4;
			this.BNegCount.Text = "50";
			// 
			// ABPositive
			// 
			this.ABPositive.AutoSize = true;
			this.ABPositive.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.ABPositive.ForeColor = System.Drawing.Color.Red;
			this.ABPositive.Location = new System.Drawing.Point(21, 38);
			this.ABPositive.Name = "ABPositive";
			this.ABPositive.Size = new System.Drawing.Size(105, 54);
			this.ABPositive.TabIndex = 3;
			this.ABPositive.Text = "AB+";
			// 
			// panel9
			// 
			this.panel9.BackColor = System.Drawing.SystemColors.ControlLight;
			this.panel9.Controls.Add(this.label22);
			this.panel9.Controls.Add(this.BPosCount);
			this.panel9.Controls.Add(this.BPositive);
			this.panel9.Location = new System.Drawing.Point(12, 373);
			this.panel9.Name = "panel9";
			this.panel9.Size = new System.Drawing.Size(250, 125);
			this.panel9.TabIndex = 8;
			// 
			// label22
			// 
			this.label22.AutoSize = true;
			this.label22.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label22.Location = new System.Drawing.Point(138, 64);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(80, 28);
			this.label22.TabIndex = 4;
			this.label22.Text = "Donors";
			// 
			// BPosCount
			// 
			this.BPosCount.AutoSize = true;
			this.BPosCount.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.BPosCount.ForeColor = System.Drawing.Color.Red;
			this.BPosCount.Location = new System.Drawing.Point(149, 10);
			this.BPosCount.Name = "BPosCount";
			this.BPosCount.Size = new System.Drawing.Size(69, 54);
			this.BPosCount.TabIndex = 4;
			this.BPosCount.Text = "50";
			// 
			// BPositive
			// 
			this.BPositive.AutoSize = true;
			this.BPositive.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.BPositive.ForeColor = System.Drawing.Color.Red;
			this.BPositive.Location = new System.Drawing.Point(23, 38);
			this.BPositive.Name = "BPositive";
			this.BPositive.Size = new System.Drawing.Size(77, 54);
			this.BPositive.TabIndex = 3;
			this.BPositive.Text = "B+";
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.CornflowerBlue;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(1085, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(50, 47);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 12;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(601, 138);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 29;
			this.dataGridView1.Size = new System.Drawing.Size(508, 507);
			this.dataGridView1.TabIndex = 13;
			// 
			// searchButton
			// 
			this.searchButton.Location = new System.Drawing.Point(1015, 84);
			this.searchButton.Name = "searchButton";
			this.searchButton.Size = new System.Drawing.Size(94, 29);
			this.searchButton.TabIndex = 14;
			this.searchButton.Text = "Search";
			this.searchButton.UseVisualStyleBackColor = true;
			// 
			// searchBar
			// 
			this.searchBar.Location = new System.Drawing.Point(601, 86);
			this.searchBar.Name = "searchBar";
			this.searchBar.Size = new System.Drawing.Size(393, 27);
			this.searchBar.TabIndex = 15;
			// 
			// formHome
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1135, 800);
			this.Controls.Add(this.searchBar);
			this.Controls.Add(this.searchButton);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.panel6);
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.panel7);
			this.Controls.Add(this.panel5);
			this.Controls.Add(this.panel8);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel9);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.topBarStrip);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MainMenuStrip = this.topBarStrip;
			this.Name = "formHome";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Home";
			this.topBarStrip.ResumeLayout(false);
			this.topBarStrip.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			this.panel5.ResumeLayout(false);
			this.panel5.PerformLayout();
			this.panel6.ResumeLayout(false);
			this.panel6.PerformLayout();
			this.panel7.ResumeLayout(false);
			this.panel7.PerformLayout();
			this.panel8.ResumeLayout(false);
			this.panel8.PerformLayout();
			this.panel9.ResumeLayout(false);
			this.panel9.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private MenuStrip topBarStrip;
		private ToolStripMenuItem homeToolStripMenuItem;
		private ToolStripMenuItem contactUsToolStripMenuItem;
		private Panel panel1;
		private Label label1;
		private Label developerLabel;
		private Label developedBy;
		private Panel panel2;
		private Label oPositive;
		private Label label3;
		private Label OPosCount;
		private Panel panel3;
		private Label label4;
		private Label ONegCount;
		private Label ONegative;
		private Panel panel4;
		private Label label7;
		private Label ANegCount;
		private Label ANegative;
		private Panel panel5;
		private Label label10;
		private Label APosCount;
		private Label APositive;
		private Panel panel6;
		private Label label13;
		private Label ABNegCount;
		private Label ABNegative;
		private Panel panel7;
		private Label label16;
		private Label ABPosCount;
		private Label BNegative;
		private Panel panel8;
		private Label label19;
		private Label BNegCount;
		private Label ABPositive;
		private Panel panel9;
		private Label label22;
		private Label BPosCount;
		private Label BPositive;
		private PictureBox pictureBox1;
		private DataGridView dataGridView1;
		private Button searchButton;
		private TextBox searchBar;
	}
}