using Blood_Management_System.BLL;
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
			u.full_name = txtFullName.Text;
			u.email = txtEmail.Text;
			u.contact_no = Int16.Parse(txtContact.Text);
			u.user_name = txtUserName.Text;
			u.address = txtAddress.Text;
			u.password = txtPassword.Text;
			u.added_date = DateTime.Now;
			u.image_name = imageName;
		}
	}	
}
