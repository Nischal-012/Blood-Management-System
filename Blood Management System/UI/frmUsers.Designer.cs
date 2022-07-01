namespace Blood_Management_System.UI
{
	partial class frmUsers
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsers));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.topSidePanel = new System.Windows.Forms.Panel();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.manageUsers = new System.Windows.Forms.Label();
			this.lblFullName = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.profilePictureBox = new System.Windows.Forms.PictureBox();
			this.setPictureButton = new System.Windows.Forms.Button();
			this.userId = new System.Windows.Forms.TextBox();
			this.lblUserId = new System.Windows.Forms.Label();
			this.txtFullName = new System.Windows.Forms.TextBox();
			this.txtUserName = new System.Windows.Forms.TextBox();
			this.lblUserName = new System.Windows.Forms.Label();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.lblEmail = new System.Windows.Forms.Label();
			this.txtContact = new System.Windows.Forms.TextBox();
			this.lblContact = new System.Windows.Forms.Label();
			this.txtAddress = new System.Windows.Forms.TextBox();
			this.lblAddress = new System.Windows.Forms.Label();
			this.AddButton = new System.Windows.Forms.Button();
			this.DelButton = new System.Windows.Forms.Button();
			this.updatebutton = new System.Windows.Forms.Button();
			this.srchbar = new System.Windows.Forms.TextBox();
			this.searchButton = new System.Windows.Forms.Button();
			this.dgvusers = new System.Windows.Forms.DataGridView();
			this.lblPassword = new System.Windows.Forms.Label();
			this.txtPassword = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel1.SuspendLayout();
			this.topSidePanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvusers)).BeginInit();
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
			this.panel1.Controls.Add(this.AddButton);
			this.panel1.Controls.Add(this.updatebutton);
			this.panel1.Controls.Add(this.DelButton);
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
			this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click_1);
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
			// lblFullName
			// 
			this.lblFullName.AutoSize = true;
			this.lblFullName.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblFullName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.lblFullName.Location = new System.Drawing.Point(141, 285);
			this.lblFullName.Name = "lblFullName";
			this.lblFullName.Size = new System.Drawing.Size(91, 25);
			this.lblFullName.TabIndex = 17;
			this.lblFullName.Text = "Full Name";
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
			// lblUserId
			// 
			this.lblUserId.AutoSize = true;
			this.lblUserId.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblUserId.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.lblUserId.Location = new System.Drawing.Point(141, 243);
			this.lblUserId.Name = "lblUserId";
			this.lblUserId.Size = new System.Drawing.Size(65, 25);
			this.lblUserId.TabIndex = 23;
			this.lblUserId.Text = "UserID";
			this.lblUserId.Click += new System.EventHandler(this.label1_Click);
			// 
			// txtFullName
			// 
			this.txtFullName.Location = new System.Drawing.Point(264, 283);
			this.txtFullName.Name = "txtFullName";
			this.txtFullName.Size = new System.Drawing.Size(346, 27);
			this.txtFullName.TabIndex = 25;
			// 
			// txtUserName
			// 
			this.txtUserName.Location = new System.Drawing.Point(264, 372);
			this.txtUserName.Name = "txtUserName";
			this.txtUserName.Size = new System.Drawing.Size(346, 27);
			this.txtUserName.TabIndex = 27;
			// 
			// lblUserName
			// 
			this.lblUserName.AutoSize = true;
			this.lblUserName.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblUserName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.lblUserName.Location = new System.Drawing.Point(141, 372);
			this.lblUserName.Name = "lblUserName";
			this.lblUserName.Size = new System.Drawing.Size(91, 25);
			this.lblUserName.TabIndex = 26;
			this.lblUserName.Text = "Username";
			// 
			// txtEmail
			// 
			this.txtEmail.Location = new System.Drawing.Point(264, 326);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(346, 27);
			this.txtEmail.TabIndex = 29;
			// 
			// lblEmail
			// 
			this.lblEmail.AutoSize = true;
			this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblEmail.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.lblEmail.Location = new System.Drawing.Point(141, 328);
			this.lblEmail.Name = "lblEmail";
			this.lblEmail.Size = new System.Drawing.Size(54, 25);
			this.lblEmail.TabIndex = 28;
			this.lblEmail.Text = "Email";
			// 
			// txtContact
			// 
			this.txtContact.Location = new System.Drawing.Point(264, 459);
			this.txtContact.Name = "txtContact";
			this.txtContact.Size = new System.Drawing.Size(346, 27);
			this.txtContact.TabIndex = 31;
			// 
			// lblContact
			// 
			this.lblContact.AutoSize = true;
			this.lblContact.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblContact.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.lblContact.Location = new System.Drawing.Point(141, 458);
			this.lblContact.Name = "lblContact";
			this.lblContact.Size = new System.Drawing.Size(106, 25);
			this.lblContact.TabIndex = 30;
			this.lblContact.Text = "Contact No.";
			// 
			// txtAddress
			// 
			this.txtAddress.Location = new System.Drawing.Point(264, 522);
			this.txtAddress.Multiline = true;
			this.txtAddress.Name = "txtAddress";
			this.txtAddress.Size = new System.Drawing.Size(346, 101);
			this.txtAddress.TabIndex = 33;
			// 
			// lblAddress
			// 
			this.lblAddress.AutoSize = true;
			this.lblAddress.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblAddress.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.lblAddress.Location = new System.Drawing.Point(141, 521);
			this.lblAddress.Name = "lblAddress";
			this.lblAddress.Size = new System.Drawing.Size(77, 25);
			this.lblAddress.TabIndex = 32;
			this.lblAddress.Text = "Address";
			// 
			// AddButton
			// 
			this.AddButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.AddButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.AddButton.Location = new System.Drawing.Point(264, 15);
			this.AddButton.Name = "AddButton";
			this.AddButton.Size = new System.Drawing.Size(85, 51);
			this.AddButton.TabIndex = 34;
			this.AddButton.Text = "ADD";
			this.AddButton.UseVisualStyleBackColor = false;
			this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
			// 
			// DelButton
			// 
			this.DelButton.BackColor = System.Drawing.Color.IndianRed;
			this.DelButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.DelButton.Location = new System.Drawing.Point(510, 15);
			this.DelButton.Name = "DelButton";
			this.DelButton.Size = new System.Drawing.Size(85, 51);
			this.DelButton.TabIndex = 35;
			this.DelButton.Text = "DELETE";
			this.DelButton.UseVisualStyleBackColor = false;
			// 
			// updatebutton
			// 
			this.updatebutton.BackColor = System.Drawing.Color.Gold;
			this.updatebutton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.updatebutton.Location = new System.Drawing.Point(390, 15);
			this.updatebutton.Name = "updatebutton";
			this.updatebutton.Size = new System.Drawing.Size(85, 51);
			this.updatebutton.TabIndex = 36;
			this.updatebutton.Text = "UPDATE";
			this.updatebutton.UseVisualStyleBackColor = false;
			// 
			// srchbar
			// 
			this.srchbar.Location = new System.Drawing.Point(680, 102);
			this.srchbar.Name = "srchbar";
			this.srchbar.Size = new System.Drawing.Size(393, 27);
			this.srchbar.TabIndex = 39;
			// 
			// searchButton
			// 
			this.searchButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.searchButton.Location = new System.Drawing.Point(1094, 100);
			this.searchButton.Name = "searchButton";
			this.searchButton.Size = new System.Drawing.Size(94, 29);
			this.searchButton.TabIndex = 38;
			this.searchButton.Text = "Search";
			this.searchButton.UseVisualStyleBackColor = true;
			// 
			// dgvusers
			// 
			this.dgvusers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvusers.Location = new System.Drawing.Point(680, 154);
			this.dgvusers.Name = "dgvusers";
			this.dgvusers.RowHeadersWidth = 51;
			this.dgvusers.RowTemplate.Height = 29;
			this.dgvusers.Size = new System.Drawing.Size(508, 485);
			this.dgvusers.TabIndex = 37;
			// 
			// lblPassword
			// 
			this.lblPassword.AutoSize = true;
			this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblPassword.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.lblPassword.Location = new System.Drawing.Point(141, 417);
			this.lblPassword.Name = "lblPassword";
			this.lblPassword.Size = new System.Drawing.Size(87, 25);
			this.lblPassword.TabIndex = 40;
			this.lblPassword.Text = "Password";
			// 
			// txtPassword
			// 
			this.txtPassword.Location = new System.Drawing.Point(264, 418);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Size = new System.Drawing.Size(346, 27);
			this.txtPassword.TabIndex = 41;
			// 
			// frmUsers
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1246, 733);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.lblPassword);
			this.Controls.Add(this.srchbar);
			this.Controls.Add(this.searchButton);
			this.Controls.Add(this.dgvusers);
			this.Controls.Add(this.txtAddress);
			this.Controls.Add(this.lblAddress);
			this.Controls.Add(this.txtContact);
			this.Controls.Add(this.lblContact);
			this.Controls.Add(this.txtEmail);
			this.Controls.Add(this.lblEmail);
			this.Controls.Add(this.txtUserName);
			this.Controls.Add(this.lblUserName);
			this.Controls.Add(this.txtFullName);
			this.Controls.Add(this.lblUserId);
			this.Controls.Add(this.userId);
			this.Controls.Add(this.setPictureButton);
			this.Controls.Add(this.profilePictureBox);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.lblFullName);
			this.Controls.Add(this.topSidePanel);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.pictureBox1);
			this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frmUsers";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.topSidePanel.ResumeLayout(false);
			this.topSidePanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvusers)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private PictureBox pictureBox1;
		private Panel panel1;
		private Panel topSidePanel;
		private PictureBox pictureBox2;
		private Label manageUsers;
		private Label lblFullName;
		private Label label4;
		private PictureBox profilePictureBox;
		private Button setPictureButton;
		private TextBox userId;
		private Label lblUserId;
		private TextBox txtFullName;
		private TextBox txtUserName;
		private Label lblUserName;
		private TextBox txtEmail;
		private Label lblEmail;
		private TextBox txtContact;
		private Label lblContact;
		private TextBox txtAddress;
		private Label lblAddress;
		private Button AddButton;
		private Button DelButton;
		private Button updatebutton;
		private TextBox srchbar;
		private Button searchButton;
		private DataGridView dgvusers;
		private Label lblPassword;
		private TextBox txtPassword;
	}
}