/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Inventory_Managment_System
{
    public class HandleDbOperations: IHandleDbOperation
    {
         IDBConnection dbConnection = new DBConnection();

        public bool SuperAdminExists()
        {
            dbConnection.OpenConnection();

            string query = "SELECT COUNT(*) FROM Users WHERE Role = 'SuperAdmin'";

            SqlCommand command = new SqlCommand(query, dbConnection.Connection);
            int count = (int)command.ExecuteScalar();

            dbConnection.CloseConnection();

            return count > 0;
        }

        public bool AnyUserExists()
        {
            dbConnection.OpenConnection();

            string query = "SELECT COUNT(*) FROM Users";

            SqlCommand command = new SqlCommand(query, dbConnection.Connection);

            // ExecuteScalar returns the first column of the first row in the result set
            // In this case, it's the count of users
            int count = (int)command.ExecuteScalar();

            dbConnection.CloseConnection();

            // If the count is greater than 0, at least one user exists
            return count > 0;
        }
        public bool UserExistsById(int userId)
        {
            dbConnection.OpenConnection();
            string query = "SELECT COUNT(*) FROM Users WHERE UserId = @UserId";
            SqlCommand command = new SqlCommand(query, dbConnection.Connection);
            command.Parameters.AddWithValue("@UserId", userId);
            int count = (int)command.ExecuteScalar();
            dbConnection.CloseConnection();

            return count > 0;
        }

        //public bool DoesUserExist(string username)
        //{
        //    using (var connection = dbConnection.OpenConnection())
        //    {
        //        using (var command = new SqlCommand("SELECT COUNT(*) FROM Users WHERE Username = @Username", connection))
        //        {
        //            command.Parameters.AddWithValue("@Username", username);

        //            int userCount = (int)command.ExecuteScalar();

        //            return userCount > 0;
        //        }
        //    }
        //}
        public bool DoesUserExist(string username)
        {
            dbConnection.OpenConnection();

            string query = "SELECT Username FROM Users";
            SqlCommand command = new SqlCommand(query, dbConnection.Connection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                // String comparison with case sensitivity
                if (string.Equals(reader["Username"].ToString(), username, StringComparison.Ordinal))
                {
                    dbConnection.CloseConnection();
                    return true;
                }
            }

            dbConnection.CloseConnection();
            return false;
        }

    }
}*/

