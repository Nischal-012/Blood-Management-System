namespace Blood_Management_System
{
	partial class LoginPage
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
			this.Title = new System.Windows.Forms.Label();
			this.topSidePanel = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.UserNameLabel = new System.Windows.Forms.Label();
			this.UserNameEnter = new System.Windows.Forms.TextBox();
			this.PasswordLabel = new System.Windows.Forms.Label();
			this.PasswordArea = new System.Windows.Forms.TextBox();
			this.LoginButton = new System.Windows.Forms.Button();
			this.ForgotPasswordLabel = new System.Windows.Forms.LinkLabel();
			this.NewHereLabel = new System.Windows.Forms.Label();
			this.SignInLabel = new System.Windows.Forms.LinkLabel();
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
			this.Title.TabIndex = 0;
			this.Title.Text = "Blood Bank Manager";
			// 
			// topSidePanel
			// 
			this.topSidePanel.BackColor = System.Drawing.Color.CornflowerBlue;
			this.topSidePanel.Controls.Add(this.pictureBox1);
			this.topSidePanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.topSidePanel.Location = new System.Drawing.Point(0, 0);
			this.topSidePanel.Name = "topSidePanel";
			this.topSidePanel.Size = new System.Drawing.Size(437, 86);
			this.topSidePanel.TabIndex = 1;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(391, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(48, 48);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// UserNameLabel
			// 
			this.UserNameLabel.AutoSize = true;
			this.UserNameLabel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.UserNameLabel.Location = new System.Drawing.Point(113, 159);
			this.UserNameLabel.Name = "UserNameLabel";
			this.UserNameLabel.Size = new System.Drawing.Size(160, 25);
			this.UserNameLabel.TabIndex = 2;
			this.UserNameLabel.Text = "Username or Email";
			// 
			// UserNameEnter
			// 
			this.UserNameEnter.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.UserNameEnter.Location = new System.Drawing.Point(113, 196);
			this.UserNameEnter.Name = "UserNameEnter";
			this.UserNameEnter.PlaceholderText = "Username or Email";
			this.UserNameEnter.Size = new System.Drawing.Size(250, 27);
			this.UserNameEnter.TabIndex = 3;
			// 
			// PasswordLabel
			// 
			this.PasswordLabel.AutoSize = true;
			this.PasswordLabel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.PasswordLabel.Location = new System.Drawing.Point(113, 239);
			this.PasswordLabel.Name = "PasswordLabel";
			this.PasswordLabel.Size = new System.Drawing.Size(87, 25);
			this.PasswordLabel.TabIndex = 4;
			this.PasswordLabel.Text = "Password";
			// 
			// PasswordArea
			// 
			this.PasswordArea.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.PasswordArea.Location = new System.Drawing.Point(113, 279);
			this.PasswordArea.Name = "PasswordArea";
			this.PasswordArea.PlaceholderText = "Password Here";
			this.PasswordArea.Size = new System.Drawing.Size(250, 27);
			this.PasswordArea.TabIndex = 5;
			this.PasswordArea.UseSystemPasswordChar = true;
			// 
			// LoginButton
			// 
			this.LoginButton.BackColor = System.Drawing.Color.CornflowerBlue;
			this.LoginButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.LoginButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
			this.LoginButton.Location = new System.Drawing.Point(113, 333);
			this.LoginButton.Name = "LoginButton";
			this.LoginButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.LoginButton.Size = new System.Drawing.Size(94, 29);
			this.LoginButton.TabIndex = 6;
			this.LoginButton.Text = "Log In";
			this.LoginButton.UseVisualStyleBackColor = false;
			// 
			// ForgotPasswordLabel
			// 
			this.ForgotPasswordLabel.AutoSize = true;
			this.ForgotPasswordLabel.Cursor = System.Windows.Forms.Cursors.Hand;
			this.ForgotPasswordLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.ForgotPasswordLabel.Location = new System.Drawing.Point(113, 386);
			this.ForgotPasswordLabel.Name = "ForgotPasswordLabel";
			this.ForgotPasswordLabel.Size = new System.Drawing.Size(143, 23);
			this.ForgotPasswordLabel.TabIndex = 7;
			this.ForgotPasswordLabel.TabStop = true;
			this.ForgotPasswordLabel.Text = "Forgot Password?";
			// 
			// NewHereLabel
			// 
			this.NewHereLabel.AutoSize = true;
			this.NewHereLabel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.NewHereLabel.Location = new System.Drawing.Point(113, 427);
			this.NewHereLabel.Name = "NewHereLabel";
			this.NewHereLabel.Size = new System.Drawing.Size(94, 25);
			this.NewHereLabel.TabIndex = 8;
			this.NewHereLabel.Text = "New here?";
			// 
			// SignInLabel
			// 
			this.SignInLabel.AutoSize = true;
			this.SignInLabel.Cursor = System.Windows.Forms.Cursors.Hand;
			this.SignInLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.SignInLabel.Location = new System.Drawing.Point(113, 463);
			this.SignInLabel.Name = "SignInLabel";
			this.SignInLabel.Size = new System.Drawing.Size(63, 23);
			this.SignInLabel.TabIndex = 9;
			this.SignInLabel.TabStop = true;
			this.SignInLabel.Text = "Sign In";
			// 
			// LoginPage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(437, 565);
			this.Controls.Add(this.SignInLabel);
			this.Controls.Add(this.NewHereLabel);
			this.Controls.Add(this.Title);
			this.Controls.Add(this.ForgotPasswordLabel);
			this.Controls.Add(this.LoginButton);
			this.Controls.Add(this.PasswordArea);
			this.Controls.Add(this.PasswordLabel);
			this.Controls.Add(this.UserNameEnter);
			this.Controls.Add(this.UserNameLabel);
			this.Controls.Add(this.topSidePanel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "LoginPage";
			this.Text = "LoginPage";
			this.topSidePanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Label Title;
		private Panel topSidePanel;
		private Label UserNameLabel;
		private TextBox UserNameEnter;
		private Label PasswordLabel;
		private TextBox PasswordArea;
		private Button LoginButton;
		private PictureBox pictureBox1;
		private LinkLabel ForgotPasswordLabel;
		private Label NewHereLabel;
		private LinkLabel SignInLabel;
	}
}