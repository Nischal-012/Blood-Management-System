namespace Blood_Management_System.UI
{
	partial class UsersForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsersForm));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.topSidePanel = new System.Windows.Forms.Panel();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.manageUsers = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.profilePictureBox = new System.Windows.Forms.PictureBox();
			this.setPictureButton = new System.Windows.Forms.Button();
			this.userId = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.AddressTextBox = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.topSidePanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.CornflowerBlue;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(1195, 3);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(50, 47);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 13;
			this.pictureBox1.TabStop = false;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.SteelBlue;
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 645);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1246, 88);
			this.panel1.TabIndex = 14;
			// 
			// topSidePanel
			// 
			this.topSidePanel.BackColor = System.Drawing.Color.CornflowerBlue;
			this.topSidePanel.Controls.Add(this.pictureBox2);
			this.topSidePanel.Controls.Add(this.manageUsers);
			this.topSidePanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.topSidePanel.Location = new System.Drawing.Point(0, 0);
			this.topSidePanel.Name = "topSidePanel";
			this.topSidePanel.Size = new System.Drawing.Size(1246, 77);
			this.topSidePanel.TabIndex = 15;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(1197, 0);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(48, 48);
			this.pictureBox2.TabIndex = 0;
			this.pictureBox2.TabStop = false;
			// 
			// manageUsers
			// 
			this.manageUsers.AutoSize = true;
			this.manageUsers.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.manageUsers.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.manageUsers.Location = new System.Drawing.Point(465, 18);
			this.manageUsers.Name = "manageUsers";
			this.manageUsers.Size = new System.Drawing.Size(266, 50);
			this.manageUsers.TabIndex = 16;
			this.manageUsers.Text = "Manage Users";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label2.Location = new System.Drawing.Point(141, 285);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(91, 25);
			this.label2.TabIndex = 17;
			this.label2.Text = "Full Name";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label4.Location = new System.Drawing.Point(115, 83);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(120, 25);
			this.label4.TabIndex = 19;
			this.label4.Text = "Profile Picture";
			this.label4.Click += new System.EventHandler(this.label4_Click);
			// 
			// profilePictureBox
			// 
			this.profilePictureBox.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.profilePictureBox.Location = new System.Drawing.Point(264, 83);
			this.profilePictureBox.Name = "profilePictureBox";
			this.profilePictureBox.Size = new System.Drawing.Size(134, 128);
			this.profilePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.profilePictureBox.TabIndex = 20;
			this.profilePictureBox.TabStop = false;
			// 
			// setPictureButton
			// 
			this.setPictureButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.setPictureButton.Location = new System.Drawing.Point(404, 182);
			this.setPictureButton.Name = "setPictureButton";
			this.setPictureButton.Size = new System.Drawing.Size(94, 29);
			this.setPictureButton.TabIndex = 21;
			this.setPictureButton.Text = "Set Image";
			this.setPictureButton.UseVisualStyleBackColor = true;
			// 
			// userId
			// 
			this.userId.Location = new System.Drawing.Point(264, 241);
			this.userId.Name = "userId";
			this.userId.ReadOnly = true;
			this.userId.Size = new System.Drawing.Size(199, 27);
			this.userId.TabIndex = 22;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label1.Location = new System.Drawing.Point(141, 243);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(65, 25);
			this.label1.TabIndex = 23;
			this.label1.Text = "UserID";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(264, 283);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(346, 27);
			this.textBox1.TabIndex = 25;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(264, 370);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(346, 27);
			this.textBox2.TabIndex = 27;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label3.Location = new System.Drawing.Point(141, 372);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(91, 25);
			this.label3.TabIndex = 26;
			this.label3.Text = "Username";
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(264, 326);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(346, 27);
			this.textBox3.TabIndex = 29;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label5.Location = new System.Drawing.Point(141, 328);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(54, 25);
			this.label5.TabIndex = 28;
			this.label5.Text = "Email";
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(264, 413);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(346, 27);
			this.textBox4.TabIndex = 31;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label6.Location = new System.Drawing.Point(141, 415);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(106, 25);
			this.label6.TabIndex = 30;
			this.label6.Text = "Contact No.";
			// 
			// AddressTextBox
			// 
			this.AddressTextBox.Location = new System.Drawing.Point(264, 459);
			this.AddressTextBox.Multiline = true;
			this.AddressTextBox.Name = "AddressTextBox";
			this.AddressTextBox.Size = new System.Drawing.Size(346, 101);
			this.AddressTextBox.TabIndex = 33;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label7.Location = new System.Drawing.Point(141, 461);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(77, 25);
			this.label7.TabIndex = 32;
			this.label7.Text = "Address";
			// 
			// button1
			// 
			this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.button1.Location = new System.Drawing.Point(230, 588);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(85, 51);
			this.button1.TabIndex = 34;
			this.button1.Text = "Set Image";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.button2.Location = new System.Drawing.Point(443, 588);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(85, 51);
			this.button2.TabIndex = 35;
			this.button2.Text = "Set Image";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.button3.Location = new System.Drawing.Point(334, 588);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(85, 51);
			this.button3.TabIndex = 36;
			this.button3.Text = "Set Image";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// button4
			// 
			this.button4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.button4.Location = new System.Drawing.Point(557, 588);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(85, 51);
			this.button4.TabIndex = 37;
			this.button4.Text = "Set Image";
			this.button4.UseVisualStyleBackColor = true;
			// 
			// UsersForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1246, 733);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.AddressTextBox);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.userId);
			this.Controls.Add(this.setPictureButton);
			this.Controls.Add(this.profilePictureBox);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.topSidePanel);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.pictureBox1);
			this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "UsersForm";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.topSidePanel.ResumeLayout(false);
			this.topSidePanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private PictureBox pictureBox1;
		private Panel panel1;
		private Panel topSidePanel;
		private PictureBox pictureBox2;
		private Label manageUsers;
		private Label label2;
		private Label label4;
		private PictureBox profilePictureBox;
		private Button setPictureButton;
		private TextBox userId;
		private Label label1;
		private TextBox textBox1;
		private TextBox textBox2;
		private Label label3;
		private TextBox textBox3;
		private Label label5;
		private TextBox textBox4;
		private Label label6;
		private TextBox AddressTextBox;
		private Label label7;
		private Button button1;
		private Button button2;
		private Button button3;
		private Button button4;
	}
}