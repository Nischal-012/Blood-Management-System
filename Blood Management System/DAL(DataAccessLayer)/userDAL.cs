using Blood_Management_System.BLL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blood_Management_System.DAL_DataAccessLayer_
{
	 class userDAL
	{
		static string myconnectionstring = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

		#region Select Data from server
		public DataTable Select()
		{
			//create an Object to connect to database
			SqlConnection conn = new SqlConnection();

			//Create a DataTable to hold the data from the data base
			DataTable dt = new DataTable();

			try
			{
				//write sql query to get data from database
				String sql = "SELECT * FROM tbl_user";
				
				// create a sql command to execute queries
				SqlCommand command = new SqlCommand(sql,conn);

				//create the adapter to hold the data from databse temporially
				SqlDataAdapter adapter = new SqlDataAdapter(command);

				//Open the database Connection
				conn.Open();

				// Fill the data from sql adapter to data table
				adapter.Fill(dt);
			}
			catch(Exception ex)
			{
				//Display error message if there is any exception
				MessageBox.Show(ex.Message);
			}
			finally
			{
				//Close database connection
				conn.Close();
			}

			return dt;
		}

		#endregion
		#region Insert Data to the Database
		public bool Insert(UserBussiness u)
		{
			//create a boolean variable to set its default value to false
			bool isSuccess = false;
			//creating a object to connect to databse
			SqlConnection conn = new SqlConnection();

			try
			{
				//creating a sql query to insert data into database
				string sql = "INSERT INTO tbl_user(user_name,email,password,full_name,contact_no,address,added_date,image_name) VALUES(@user_name,@email,@password,@full_name,@contact_no,@address,@added_date,@image_name)";

				//create to sql command to execute above query
				SqlCommand command = new SqlCommand(sql, conn);

				//create the parameter to pass the value from UI to Sql Query above
				command.Parameters.AddWithValue("@user_name",u.user_name);
				command.Parameters.AddWithValue("@email", u.email);
				command.Parameters.AddWithValue("@password", u.password);
				command.Parameters.AddWithValue("@full_name", u.full_name);
				command.Parameters.AddWithValue("@contact_no", u.contact_no);
				command.Parameters.AddWithValue("@address", u.address);
				command.Parameters.AddWithValue("@added_date", u.added_date);
				command.Parameters.AddWithValue("@image_name", u.image_name);

				//open database connection
				conn.Open();

				//create the int valur to check if the data is added or not
				int row = 0;
				//if row is greater than 0 it means the data is added to the database
				if(row>0)
				{
					//data inserted sucessfully
					isSuccess = true;
				}
				else
				{
					//data insertion failed
					isSuccess = false;
				}
			}
			catch(Exception ex)
			{
				//Shows error Message
				MessageBox.Show(ex.Message);
			}
			finally
			{
				//Closes the connection
				conn.Close();
			}


			return isSuccess;

		}

		#region Update Data in database (userModule)
		public bool Update(UserBussiness u)
		{
			bool isSuccess = false;

			//Creating object for sql connection
			SqlConnection conn = new SqlConnection();
			try
			{
				//creating query for updating data
				string sql = "UPDATE tbl_user SET user_name=@user_name email=@email password= @password full_name =@full_name contact_no = @contact_no address=@address added_date=@added_data image_name = @image_name WHERE user_id =@user_id";

				//creating command to execute sql query
				SqlCommand command = new SqlCommand(sql, conn);

				//passing value to the query
				command.Parameters.AddWithValue("user_name", u.user_name);
				command.Parameters.AddWithValue("email", u.email);
				command.Parameters.AddWithValue("password", u.password);
				command.Parameters.AddWithValue("full_name", u.full_name);
				command.Parameters.AddWithValue("contact_no." u.contact_no);
				command.Parameters.AddWithValue("address", u.address);
				command.Parameters.AddWithValue("added_data", u.added_date);
				command.Parameters.AddWithValue("image_name", u.image_name);

			}
			catch(Exception ex)
			{
				//shows Error Message
				MessageBox.Show(ex.Message);
			}
			finally
			{
				//Closes the connection
				conn.Close();
			}

			return isSuccess;
		}
	}
}
