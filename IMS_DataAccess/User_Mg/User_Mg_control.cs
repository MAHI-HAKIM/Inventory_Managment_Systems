using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS_DataAccess
{
    public class User_Mg_control
    {
        IDBConnection dBConnection = new DBConnection();

        public List<UserDetail> GetAllUsers()
        {
            List<UserDetail> userDetails = new List<UserDetail>();

            // Creating an instance of DBConnection
            IDBConnection dbConnection = new DBConnection();

            // Open the connection

            // Your SQL query that gets all users except super admin and joins with ContactInfo
            string query = @"SELECT u.UserID as UserID, c.FirstName, c.LastName, c.PhoneNo 
                     FROM Users u
                     JOIN ContactInfo c ON u.ContactID = c.ContactID "; // Joining on ContactID

            using (SqlCommand command = new SqlCommand(query, dbConnection.OpenConnection()))
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    UserDetail userDetail = new UserDetail
                    {
                        // Map the reader fields to UserDetail properties
                        UserID = reader.GetInt32(reader.GetOrdinal("UserID")),
                        FirstName = reader.GetString(reader.GetOrdinal("FirstName")),
                        LastName = reader.GetString(reader.GetOrdinal("LastName")),
                        PhoneNumber = reader.GetString(reader.GetOrdinal("PhoneNo")),
                    };
                    userDetails.Add(userDetail);
                }
            }

            // Close the connection
            dbConnection.CloseConnection();

            return userDetails;
        }     
    }
}
