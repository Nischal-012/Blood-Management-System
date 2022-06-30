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
			

			return isSuccess;

		}

	}
}
