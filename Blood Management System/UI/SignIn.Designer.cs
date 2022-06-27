namespace Blood_Management_System
{
	partial class SignIn
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignIn));
			this.Title = new System.Windows.Forms.Label();
			this.topSidePanel = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.SigninButton = new System.Windows.Forms.Button();
			this.PasswordArea = new System.Windows.Forms.TextBox();
			this.Email = new System.Windows.Forms.Label();
			this.UserNameEnter = new System.Windows.Forms.TextBox();
			this.Fullname = new System.Windows.Forms.Label();
			this.UserNameLabel = new System.Windows.Forms.Label();
			this.UserNameArea = new System.Windows.Forms.TextBox();
			this.PasswordLabel = new System.Windows.Forms.Label();
			this.PasswordText = new System.Windows.Forms.TextBox();
			this.topSidePanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// Title
			// 
			this.Title.AutoSize = true;
			this.Title.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.Title.ForeColor = System.Drawing.Color.Red;
			this.Title.Location = new System.Drawing.Point(23, 98);
			this.Title.Name = "Title";
			this.Title.Size = new System.Drawing.Size(388, 50);
			this.Title.TabIndex = 10;
			this.Title.Text = "Blood Bank Manager";
			// 
			// topSidePanel
			// 
			this.topSidePanel.BackColor = System.Drawing.Color.CornflowerBlue;
			this.topSidePanel.Controls.Add(this.pictureBox1);
			this.topSidePanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.topSidePanel.Location = new System.Drawing.Point(0, 0);
			this.topSidePanel.Name = "topSidePanel";
			this.topSidePanel.Size = new System.Drawing.Size(442, 86);
			this.topSidePanel.TabIndex = 11;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(391, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(48, 48);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// SigninButton
			// 
			this.SigninButton.BackColor = System.Drawing.Color.CornflowerBlue;
			this.SigninButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.SigninButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
			this.SigninButton.Location = new System.Drawing.Point(113, 466);
			this.SigninButton.Name = "SigninButton";
			this.SigninButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.SigninButton.Size = new System.Drawing.Size(94, 29);
			this.SigninButton.TabIndex = 16;
			this.SigninButton.Text = "Sign In";
			this.SigninButton.UseVisualStyleBackColor = false;
			// 
			// PasswordArea
			// 
			this.PasswordArea.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.PasswordArea.Location = new System.Drawing.Point(113, 272);
			this.PasswordArea.Name = "PasswordArea";
			this.PasswordArea.PlaceholderText = "Enter your email";
			this.PasswordArea.Size = new System.Drawing.Size(250, 27);
			this.PasswordArea.TabIndex = 15;
			// 
			// Email
			// 
			this.Email.AutoSize = true;
			this.Email.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.Email.Location = new System.Drawing.Point(113, 244);
			this.Email.Name = "Email";
			this.Email.Size = new System.Drawing.Size(54, 25);
			this.Email.TabIndex = 14;
			this.Email.Text = "Email";
			this.Email.Click += new System.EventHandler(this.PasswordLabel_Click);
			// 
			// UserNameEnter
			// 
			this.UserNameEnter.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.UserNameEnter.Location = new System.Drawing.Point(113, 202);
			this.UserNameEnter.Name = "UserNameEnter";
			this.UserNameEnter.PlaceholderText = "Enter your name";
			this.UserNameEnter.Size = new System.Drawing.Size(250, 27);
			this.UserNameEnter.TabIndex = 13;
			// 
			// Fullname
			// 
			this.Fullname.AutoSize = true;
			this.Fullname.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.Fullname.Location = new System.Drawing.Point(113, 174);
			this.Fullname.Name = "Fullname";
			this.Fullname.Size = new System.Drawing.Size(91, 25);
			this.Fullname.TabIndex = 12;
			this.Fullname.Text = "Full Name";
			// 
			// UserNameLabel
			// 
			this.UserNameLabel.AutoSize = true;
			this.UserNameLabel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.UserNameLabel.Location = new System.Drawing.Point(113, 316);
			this.UserNameLabel.Name = "UserNameLabel";
			this.UserNameLabel.Size = new System.Drawing.Size(91, 25);
			this.UserNameLabel.TabIndex = 20;
			this.UserNameLabel.Text = "Username";
			// 
			// UserNameArea
			// 
			this.UserNameArea.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.UserNameArea.Location = new System.Drawing.Point(113, 344);
			this.UserNameArea.Name = "UserNameArea";
			this.UserNameArea.PlaceholderText = "Preferred Username";
			this.UserNameArea.Size = new System.Drawing.Size(250, 27);
			this.UserNameArea.TabIndex = 21;
			// 
			// PasswordLabel
			// 
			this.PasswordLabel.AutoSize = true;
			this.PasswordLabel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.PasswordLabel.Location = new System.Drawing.Point(113, 374);
			this.PasswordLabel.Name = "PasswordLabel";
			this.PasswordLabel.Size = new System.Drawing.Size(87, 25);
			this.PasswordLabel.TabIndex = 22;
			this.PasswordLabel.Text = "Password";
			// 
			// PasswordText
			// 
			this.PasswordText.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.PasswordText.Location = new System.Drawing.Point(113, 413);
			this.PasswordText.Name = "PasswordText";
			this.PasswordText.PlaceholderText = "Password";
			this.PasswordText.Size = new System.Drawing.Size(250, 27);
			this.PasswordText.TabIndex = 23;
			this.PasswordText.UseSystemPasswordChar = true;
			// 
			// SignIn
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(442, 603);
			this.Controls.Add(this.PasswordText);
			this.Controls.Add(this.PasswordLabel);
			this.Controls.Add(this.UserNameArea);
			this.Controls.Add(this.UserNameLabel);
			this.Controls.Add(this.Title);
			this.Controls.Add(this.topSidePanel);
			this.Controls.Add(this.SigninButton);
			this.Controls.Add(this.PasswordArea);
			this.Controls.Add(this.Email);
			this.Controls.Add(this.UserNameEnter);
			this.Controls.Add(this.Fullname);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "SignIn";
			this.Text = "SignIn";
			this.topSidePanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Label Title;
		private Panel topSidePanel;
		private PictureBox pictureBox1;
		private Button SigninButton;
		private TextBox PasswordArea;
		private Label Email;
		private TextBox UserNameEnter;
		private Label Fullname;
		private Label UserNameLabel;
		private TextBox UserNameArea;
		private Label PasswordLabel;
		private TextBox PasswordText;
	}
}