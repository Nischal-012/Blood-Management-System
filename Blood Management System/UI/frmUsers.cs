﻿using Blood_Management_System.BLL;
using Blood_Management_System.DAL_DataAccessLayer_;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blood_Management_System.UI
{
	public partial class frmUsers : Form
	{
		public frmUsers()
		{
			InitializeComponent();
		}

		UserBussiness u = new UserBussiness();
		userDAL dal = new userDAL();
		string imageName = "no_image.jpg";

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void label4_Click(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}
		private void pictureBox2_Click_1(object sender, EventArgs e)
		{
			this.Hide();
		}

		private void AddButton_Click(object sender, EventArgs e)
		{
			//get the values from UI
			u.full_name = txtFullName.Text;
			u.email = txtEmail.Text;
			u.contact_no = txtContact.Text;
			u.user_name = txtUserName.Text;
			u.address = txtAddress.Text;
			u.password = txtPassword.Text;
			u.added_date = DateTime.Now;
			u.image_name = imageName;

			//adding values from UI to the database
			bool success = dal.Insert(u);

			if(success == true)
			{
				MessageBox.Show("Data Added Successfully");
				DataTable dt = dal.Select();
				dgvusers.DataSource = dt;
				Clear();
			}
			else
			{
				MessageBox.Show("Failed to add data");
			}
		}
		
		public void Clear()
		{
			txtFullName.Text = "";
			txtEmail.Text = "";
			txtContact.Text = "";
			txtUserName.Text = "";
			txtAddress.Text = "";
			txtPassword.Text = "";
		}
	}	
}
