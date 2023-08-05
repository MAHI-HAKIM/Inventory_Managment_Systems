using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

namespace IMS_DataAccess
{
    public class UserRepository : IUserRepository
    {
        IDBConnection dbConnection = new DBConnection();

        PasswordWithSaltHasher hasher = new PasswordWithSaltHasher();

        public void CreateUser(User user)
        {

            dbConnection.OpenConnection();

            // Start a new transaction
            using (SqlTransaction transaction = dbConnection.Connection.BeginTransaction())
            {
                try
                {
                    // First, insert the ContactInfo
                    string contactInfoQuery = "INSERT INTO ContactInfo(FirstName, LastName, PhoneNo, Address) OUTPUT INSERTED.ContactId VALUES(@FirstName, @LastName, @PhoneNumber, @Address)";

                    SqlCommand contactInfoCommand = new SqlCommand(contactInfoQuery, dbConnection.Connection, transaction);
                    contactInfoCommand.Parameters.AddWithValue("@FirstName", user.Contact.FirstName);
                    contactInfoCommand.Parameters.AddWithValue("@LastName", user.Contact.LastName);
                    contactInfoCommand.Parameters.AddWithValue("@PhoneNumber", user.Contact.PhoneNo);
                    contactInfoCommand.Parameters.AddWithValue("@Address", user.Contact.Address);

                    // Execute the command and get the inserted ContactId
                    int contactId = (int)contactInfoCommand.ExecuteScalar();

                    // Next, insert the User
                    string userQuery = "INSERT INTO Users(Username, PasswordHash, Salt, Role, ContactId) VALUES(@Username, @PasswordHash, @Salt, @Role, @ContactId)";

                    SqlCommand userCommand = new SqlCommand(userQuery, dbConnection.Connection, transaction);
                    userCommand.Parameters.AddWithValue("@Username", user.Username);
                    userCommand.Parameters.AddWithValue("@PasswordHash", user.PasswordHash);
                    userCommand.Parameters.AddWithValue("@Salt", user.Salt);
                    userCommand.Parameters.AddWithValue("@Role", user.Role.ToString());
                    userCommand.Parameters.AddWithValue("@ContactId", contactId);

                    userCommand.ExecuteNonQuery();

                    // If we reach this point, both insertions were successful, so commit the transaction
                    transaction.Commit();
                }
                catch
                {
                    // If anything goes wrong, roll back the transaction
                    transaction.Rollback();

                    // Re-throw the exception
                    throw;
                }
                finally
                {
                    dbConnection.CloseConnection();
                }
            }
        }

        public void DeleteUser(int userId)
        {
            dbConnection.OpenConnection();

            // Start a new transaction
            using (SqlTransaction transaction = dbConnection.Connection.BeginTransaction())
            {
                try
                {
                    // First, get the ContactId for this user
                    string getContactIdQuery = "SELECT ContactId FROM Users WHERE UserId = @UserId";

                    SqlCommand getContactIdCommand = new SqlCommand(getContactIdQuery, dbConnection.Connection, transaction);
                    getContactIdCommand.Parameters.AddWithValue("@UserId", userId);

                    // Execute the command and get the ContactId
                    int contactId = (int)getContactIdCommand.ExecuteScalar();

                    // Next, delete the User
                    string userQuery = "DELETE FROM Users WHERE UserId = @UserId";

                    SqlCommand userCommand = new SqlCommand(userQuery, dbConnection.Connection, transaction);
                    userCommand.Parameters.AddWithValue("@UserId", userId);

                    userCommand.ExecuteNonQuery();

                    // Finally, delete the ContactInfo
                    string contactInfoQuery = "DELETE FROM ContactInfo WHERE ContactId = @ContactId";

                    SqlCommand contactInfoCommand = new SqlCommand(contactInfoQuery, dbConnection.Connection, transaction);
                    contactInfoCommand.Parameters.AddWithValue("@ContactId", contactId);

                    contactInfoCommand.ExecuteNonQuery();

                    // If we reach this point, both deletions were successful, so commit the transaction
                    transaction.Commit();
                }
                catch
                {
                    // If anything goes wrong, roll back the transaction
                    transaction.Rollback();

                    // Re-throw the exception
                    throw;
                }
                finally
                {
                    dbConnection.CloseConnection();
                }
            }
        }

        public User LogUserIn(string enteredUsername, string enteredPassword)
        {
            dbConnection.OpenConnection();

            string query = "SELECT u.Username, u.PasswordHash, u.Salt, u.Role, c.FirstName, c.LastName, c.PhoneNo, c.Address FROM Users u " +
                           "INNER JOIN ContactInfo c ON u.ContactId = c.ContactId " +
                           "WHERE BINARY_CHECKSUM(u.Username) = BINARY_CHECKSUM(@Username)";

            using (SqlCommand command = new SqlCommand(query, dbConnection.Connection))
            {
                command.Parameters.AddWithValue("@Username", enteredUsername);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    User user = null;
                    if (reader.Read())
                    {
                        Role role = (Role)Enum.Parse(typeof(Role), reader["Role"].ToString());
                        ContactInfo contact = new ContactInfo
                        {
                            FirstName = reader["FirstName"].ToString(),
                            LastName = reader["LastName"].ToString(),
                            PhoneNo = reader["PhoneNo"].ToString(),
                            Address = reader["Address"].ToString()
                        };

                        string storedSalt = reader["Salt"].ToString();
                        string storedHashedPassword = reader["PasswordHash"].ToString();

                        // Compare the hashed password with the stored hashed password
                        string hashedEnteredPassword = hasher.HashPassword(enteredPassword, storedSalt);
                        if (hashedEnteredPassword != storedHashedPassword)
                        {
                            // Passwords don't match
                            return null;
                        }

                        user = new User
                        {
                            Username = enteredUsername,
                            PasswordHash = storedHashedPassword,
                            Salt = storedSalt,
                            Contact = contact,
                            Role = role
                        };
                    }
                    return user;
                }
            }
        }

    }

}
