using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Collections;


namespace DataAccessLib
{
    public static class NorthwindDataAccess
    {
        //Note:  If your server is not named localhost, you will need to change the connection string
        private const string connectString = @"Server = localhost;Database=Northwind;Integrated Security=SSPI";

        /// <summary>
        /// Retrieves list of customers from the Northwind database
        /// </summary>
        /// <param name="countryName">
        /// only customers from the specified country are retrieved if the string is not ""
        /// if the string is "" (zero length string) then all customers are retrieved
        /// </param>
        /// <returns>
        /// a list containing  customer names
        /// </returns>
        public static List<String> GetCustomers(string countryName)
        {
            //command object
            SqlCommand selectCommand;
            //datareader
            SqlDataReader customerReader;

            //array to hold customer list
            List<String> customerList;

            // instantiate the command 
            selectCommand = new SqlCommand();
            // instantiate array for Customer list
            customerList = new List<String>();

            try
            {
                //Configure the command object

                //set up the connection for the command
                selectCommand.Connection = new SqlConnection();
                selectCommand.Connection.ConnectionString = connectString;
                // alternate syntax
                //selectCommand.Connection = new SqlConnection(connectString);

                //set up sql for the command
                if (countryName == "")
                {
                    selectCommand.CommandText =
                        "Select CompanyName from Customers order by CompanyName";
                }
                else
                {
                    selectCommand.CommandText =
                        "Select CompanyName from Customers where Country = '" +
                        countryName +
                        "' order by CompanyName";
                }

                //open the database connection
                selectCommand.Connection.Open();

                //execute sql against the database
                customerReader = selectCommand.ExecuteReader();

                //use data reader to retrieve rows one at a time

                while (customerReader.Read())
                {
                    customerList.Add(customerReader["CompanyName"].ToString());
                }

                //close the data reader
                customerReader.Close();

                //return the arraylist
                return customerList;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                //close the database connection (log out)
                selectCommand.Connection.Close();
            }


        }

        

        /// <summary>
        /// Counts the number of Shippers in the Shippers table
        /// Demonstrates the use of the ExecuteScalar method of the Command class
        /// </summary>
        /// <returns>
        /// number of rows in the Shippers table
        /// </returns>
        public static int CountShippers()
        {
            SqlCommand selectCommand;
            const string sql = "Select count(*) from Shippers";

            selectCommand = new SqlCommand(sql, new SqlConnection(connectString));
            try
            {
                selectCommand.Connection.Open();
                return Convert.ToInt32(selectCommand.ExecuteScalar());
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                selectCommand.Connection.Close();

            }
        }


        /// <summary>
        /// Inserts a new row into the Shippers table
        /// </summary>
        /// <param name="companyName">
        /// name of shipping company
        /// </param>
        /// <param name="phone">
        /// phone number of shipping company
        /// </param>
        /// <returns>
        /// number of rows inserted
        /// </returns>
        public static int AddShipper(string companyName, string phone)
        {
            SqlCommand insertCommand;
            int rowsAffected;

            insertCommand = new SqlCommand();

            try
            {
                insertCommand.Connection = new SqlConnection();
                insertCommand.Connection.ConnectionString = connectString;

                insertCommand.CommandText =
                    "insert into Shippers " +
                    " (CompanyName, Phone )" +
                    "Values(" +
                    "'" + companyName + "'," +
                    "'" + phone + "')";

                insertCommand.Connection.Open();

                rowsAffected = insertCommand.ExecuteNonQuery();

                return rowsAffected;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                insertCommand.Connection.Close();
            }

        }

      
    }
}
