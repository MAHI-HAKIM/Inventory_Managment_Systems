using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;
using IMS_DataAccess;

namespace User_Repo
{
    public class UserRepository : IUserRepository
    {
        IDBConnection dbConnection = new DBConnection();

        PasswordWithSaltHasher hasher = new PasswordWithSaltHasher();

        public void CreateUser(Users user)
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
        public Users LogUserIn(string enteredUsername, string enteredPassword)
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
                        Users user = null;

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
                                user = new Users
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
        public bool UpdateUserDetails(Users updatedUser)
        {
            try
            {
                dbConnection.OpenConnection();

                using (SqlTransaction transaction = dbConnection.Connection.BeginTransaction())
                {
                    try
                    {
                        // Construct your SQL query to update user information excluding password and AssignedDate
                        //string updateUserQuery = "UPDATE Users SET Username = @Username, IsActive = @IsActive RoleAssignment = @RoleAssignment, RoleId = @RoleId WHERE UserId = @UserId";

                        string updateUserQuery = "UPDATE Users SET IsActive = @IsActive, RoleAssignment = @RoleAssignment, RoleID = @RoleID WHERE UserID = @UserID";

                        using (SqlCommand updateUserCommand = new SqlCommand(updateUserQuery, dbConnection.Connection, transaction))
                        {
                            updateUserCommand.Parameters.AddWithValue("@IsActive", updatedUser.IsActive);
                            updateUserCommand.Parameters.AddWithValue("@RoleAssignment", updatedUser.RoleAssignment);
                            updateUserCommand.Parameters.AddWithValue("@RoleId", updatedUser.RoleId);
                            updateUserCommand.Parameters.AddWithValue("@UserID", updatedUser.UserId);


                            int userRowsAffected = updateUserCommand.ExecuteNonQuery();

                            if (userRowsAffected <= 0)
                            {
                                transaction.Rollback();
                                return false; // User update failed
                            }
                        }

                        // Only update contact information if there are changes
                        if (!string.IsNullOrEmpty(updatedUser.UserContact.FirstName) || !string.IsNullOrEmpty(updatedUser.UserContact.LastName) || !string.IsNullOrEmpty(updatedUser.UserContact.PhoneNumber) || !string.IsNullOrEmpty(updatedUser.UserContact.Address))
                        {
                            //string updateContactQuery = "UPDATE ContactInfo SET FirstName = @FirstName, LastName = @LastName, PhoneNumber = @PhoneNumber, Address = @Address WHERE ContactId = @ContactId";
                            string updateContactQuery = "UPDATE Contact SET Firstname = @Firstname, Lastname = @Lastname, PhoneNumber = @PhoneNumber, Address = @Address WHERE ContactID = (SELECT ContactID FROM Users WHERE UserID = @UserID)";
                            using (SqlCommand updateContactCommand = new SqlCommand(updateContactQuery, dbConnection.Connection, transaction))
                            {
                                updateContactCommand.Parameters.AddWithValue("@FirstName", updatedUser.UserContact.FirstName);
                                updateContactCommand.Parameters.AddWithValue("@LastName", updatedUser.UserContact.LastName);
                                updateContactCommand.Parameters.AddWithValue("@PhoneNumber", updatedUser.UserContact.PhoneNumber);
                                updateContactCommand.Parameters.AddWithValue("@Address", updatedUser.UserContact.Address);
                                updateContactCommand.Parameters.AddWithValue("@UserID", updatedUser.UserId);



                                int contactRowsAffected = updateContactCommand.ExecuteNonQuery();

                                if (contactRowsAffected <= 0)
                                {
                                    transaction.Rollback();
                                    return false; // Contact update failed
                                }
                            }

                        }
                        transaction.Commit();
                        return true;
                    }
                    catch (SqlException ex)
                    {
                        // Handle database-related exceptions and log them
                        // You might want to log ex.ToString() or store it in a log file
                        transaction.Rollback();
                        return false;
                    }
                    catch (Exception ex)
                    {
                        // Handle other general exceptions and log them
                        // You might want to log ex.ToString() or store it in a log file

                        transaction.Rollback();
                        return false;
                    }
                }
            }
            finally
            {
                dbConnection.CloseConnection();
            }
        }

    }
}


