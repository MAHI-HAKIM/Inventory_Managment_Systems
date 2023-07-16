using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Inventory_Managment_System
{
    public class SqlServerUserRepository:IUserRepository
    {
        private readonly IDatabaseConnection dbConnection;
        
        public SqlServerUserRepository(IDatabaseConnection dbConnection)
        {
            this.dbConnection = dbConnection;
        }

        public bool DoesUsernameExist(string username)
        {
            string query = "SELECT COUNT(*) FROM Users WHERE Username = @username";
            Dictionary<string, object> parameters = new Dictionary<string, object>
    {
        {"@username", username}
    };

            int userCount = dbConnection.ExecuteScalarQuery(query, parameters);

            return userCount > 0;
        }
        public void CreateUser(string username, string hashedPassword, string salt, string phoneNo, string firstName, string lastName, string role)
        {
            try
            {
                dbConnection.OpenConnection();

                using (SqlCommand cmd = new SqlCommand(
                    "INSERT INTO Users (Username, PasswordHash, Salt, PhoneNo, FirstName, LastName, Role) VALUES (@username, @hashed, @salt, @phoneNo, @firstName, @lastName, @role)",
                    dbConnection.Connection))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@hashed", hashedPassword);
                    cmd.Parameters.AddWithValue("@salt", salt);
                    cmd.Parameters.AddWithValue("@phoneNo", phoneNo);
                    cmd.Parameters.AddWithValue("@firstName", firstName);
                    cmd.Parameters.AddWithValue("@lastName", lastName);
                    cmd.Parameters.AddWithValue("@role", role);

                    cmd.ExecuteNonQuery();
                }
            }
            finally
            {
                dbConnection.CloseConnection();
            }
        }

    }
}
