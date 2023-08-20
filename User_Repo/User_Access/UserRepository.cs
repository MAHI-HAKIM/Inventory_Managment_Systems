using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;
using IMS_DataAccess;
using User_Repo.User_Repo;

namespace User_Repo
{
    public class UserRepository : IUserRepository
    {
        IDBConnection dbConnection = new DBConnection();

        PasswordWithSaltHasher hasher = new PasswordWithSaltHasher();

        public void CreateUser(User user)
        {
            dbConnection.OpenConnection();

            using (SqlTransaction transaction = dbConnection.Connection.BeginTransaction())
            {
                try
                {
                    // Inserting the ContactInfo
                    string contactInfoQuery = "INSERT INTO Contact(FirstName, LastName, PhoneNumber, Address) OUTPUT INSERTED.ContactId VALUES(@FirstName, @LastName, @PhoneNumber, @Address)";

                    SqlCommand contactInfoCommand = new SqlCommand(contactInfoQuery, dbConnection.Connection, transaction);
                    contactInfoCommand.Parameters.AddWithValue("@FirstName", user.UserContact.FirstName);
                    contactInfoCommand.Parameters.AddWithValue("@LastName", user.UserContact.LastName);
                    contactInfoCommand.Parameters.AddWithValue("@PhoneNumber", user.UserContact.PhoneNumber);
                    contactInfoCommand.Parameters.AddWithValue("@Address", user.UserContact.Address);

                    // Retrieve the inserted ContactId
                    int contactId = (int)contactInfoCommand.ExecuteScalar();

                    // Inserting the User
                    string userQuery = "INSERT INTO Users(Username, PasswordHash, Salt, IsActive, AssignedDate, RoleAssignment , RoleId, ContactId) VALUES(@Username, @PasswordHash, @Salt, @IsActive, @AssignedDate,@RoleAssignment, @RoleId, @ContactId)";

                    SqlCommand userCommand = new SqlCommand(userQuery, dbConnection.Connection, transaction);
                    userCommand.Parameters.AddWithValue("@Username", user.Username);
                    userCommand.Parameters.AddWithValue("@PasswordHash", user.PasswordHash);
                    userCommand.Parameters.AddWithValue("@Salt", user.Salt);
                    userCommand.Parameters.AddWithValue("@IsActive", user.IsActive);
                    userCommand.Parameters.AddWithValue("@AssignedDate", user.AssignedDate);
                    userCommand.Parameters.AddWithValue("@RoleAssignment", user.RoleAssignment);
                    userCommand.Parameters.AddWithValue("@RoleId", user.RoleId);
                    userCommand.Parameters.AddWithValue("@ContactId", contactId);

                    userCommand.ExecuteNonQuery();

                    // Committing the transaction
                    transaction.Commit();
                }
                catch
                {
                    // Roll back in case of errors
                    transaction.Rollback();
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
                    string contactInfoQuery = "DELETE FROM Contact WHERE ContactId = @ContactId";

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
            try
            {
                dbConnection.OpenConnection();

                string query = "SELECT u.UserId, u.Username, u.PasswordHash, u.Salt, u.IsActive, u.RoleId, c.FirstName, c.LastName FROM Users u " +
                               "INNER JOIN Contact c ON u.ContactId = c.ContactId " +
                               "WHERE BINARY_CHECKSUM(u.Username) = BINARY_CHECKSUM(@Username)";

                using (SqlCommand command = new SqlCommand(query, dbConnection.Connection))
                {
                    command.Parameters.AddWithValue("@Username", enteredUsername);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        User user = null;
                        if (reader.Read())
                        {
                            int userId = Convert.ToInt32(reader["UserId"]);
                            bool isActive = Convert.ToBoolean(reader["IsActive"]);

                            if (!isActive)
                            {
                                // User is not active, don't proceed with login
                                return null;
                            }

                            string storedSalt = reader["Salt"].ToString();
                            string storedHashedPassword = reader["PasswordHash"].ToString();

                            // Compare the hashed password with the entered password
                            string hashedEnteredPassword = hasher.HashPassword(enteredPassword, storedSalt);
                            if (hashedEnteredPassword == storedHashedPassword)
                            {
                                user = new User
                                {
                                    UserId = userId,
                                    Username = enteredUsername,
                                    PasswordHash = storedHashedPassword,
                                    Salt = storedSalt,
                                    IsActive = isActive,
                                    RoleId = Convert.ToInt32(reader["RoleId"]),
                                    UserContact = new ContactInfo
                                    {
                                        FirstName = reader["FirstName"].ToString(),
                                        LastName = reader["LastName"].ToString()
                                    }
                                };
                            }
                        }
                        return user;
                    }
                }
            }
            catch (SqlException ex)
            {
                // Handle database-related exceptions here
                throw new Exception("Database error: " + ex.Message, ex);
            }
            catch (Exception ex)
            {
                // Handle other general exceptions here
                throw new Exception("An error occurred: " + ex.Message, ex);
            }
            finally
            {
                dbConnection.CloseConnection();
            }
        }


        public bool UpdateUserDetails(int userId, string newUsername, string newPasswordHash, string newSalt, int roleId, string newFirstName, string newLastName, string newPhoneNumber, string newAddress, bool isActive)
        {
            try
            {
                dbConnection.OpenConnection();

                // Fetch the ContactID associated with the user
                //int contactId = GetContactIdByUserId(userId);

                //if (contactId == -1)
                //{
                //    throw new Exception("User not found or associated with a contact.");
                //}

                // Construct your SQL query to update user information
                string updateUserQuery = "UPDATE Users SET Username = @Username, PasswordHash = @PasswordHash, Salt = @Salt, RoleId = @RoleId, IsActive = @IsActive WHERE UserId = @UserId";
                string updateContactQuery = "UPDATE ContactInfo SET FirstName = @FirstName, LastName = @LastName, PhoneNumber = @PhoneNumber, Address = @Address WHERE ContactId = @ContactId";

                using (SqlCommand updateUserCommand = new SqlCommand(updateUserQuery, dbConnection.Connection))
                using (SqlCommand updateContactCommand = new SqlCommand(updateContactQuery, dbConnection.Connection))
                {
                    updateUserCommand.Parameters.AddWithValue("@Username", newUsername);
                    updateUserCommand.Parameters.AddWithValue("@PasswordHash", newPasswordHash);
                    updateUserCommand.Parameters.AddWithValue("@Salt", newSalt);
                    updateUserCommand.Parameters.AddWithValue("@RoleId", roleId);
                    updateUserCommand.Parameters.AddWithValue("@IsActive", isActive);
                    updateUserCommand.Parameters.AddWithValue("@UserId", userId);

                    updateContactCommand.Parameters.AddWithValue("@FirstName", newFirstName);
                    updateContactCommand.Parameters.AddWithValue("@LastName", newLastName);
                    updateContactCommand.Parameters.AddWithValue("@PhoneNumber", newPhoneNumber);
                    updateContactCommand.Parameters.AddWithValue("@Address", newAddress);
                    //updateContactCommand.Parameters.AddWithValue("@ContactId", contactId);

                    int userRowsAffected = updateUserCommand.ExecuteNonQuery();
                    int contactRowsAffected = updateContactCommand.ExecuteNonQuery();

                    return userRowsAffected > 0 && contactRowsAffected > 0; // Return true if both updates were successful
                }
            }
            catch (SqlException ex)
            {
                // Handle database-related exceptions here
                throw new Exception("Database error: " + ex.Message, ex);
            }
            catch (Exception ex)
            {
                // Handle other general exceptions here
                throw new Exception("An error occurred: " + ex.Message, ex);
            }
            finally
            {
                dbConnection.CloseConnection();
            }
        }










    }
}
