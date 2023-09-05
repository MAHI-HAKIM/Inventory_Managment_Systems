using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMS_DataAccess;
using System.Data.Common;
using System.Data;

namespace User_Repo
{
    public class User_Accessory : IUser_Accessory
    {
        IDBConnection dBConnection = new DBConnection();
        public List<UserDetails> GetAllUserDetails()
        {
            List<UserDetails> userDetailsList = new List<UserDetails>();

            // Creating an instance of DBConnection
            IDBConnection dbConnection = new DBConnection();

            try
            {
                // Adjusted SQL query to also join with the Role table and select the RoleName
                string query = @"SELECT u.UserID ,c.FirstName, c.LastName, c.PhoneNumber, c.Address, u.AssignedDate, r.RoleName 
                                 FROM Users u
                                JOIN Contact c ON u.ContactID = c.ContactID
                                JOIN Role r ON u.RoleID = r.RoleID";

                using (SqlCommand command = new SqlCommand(query, dbConnection.OpenConnection()))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        UserDetails userDetails = new UserDetails
                        {
                            UserId = reader.GetInt32(reader.GetOrdinal("UserId")),
                            Firstname = reader.GetString(reader.GetOrdinal("FirstName")),
                            LastName = reader.GetString(reader.GetOrdinal("LastName")),
                            PhoneNumber = reader.GetString(reader.GetOrdinal("PhoneNumber")),
                            Address = reader.GetString(reader.GetOrdinal("Address")),  // Assign Address here
                            AssignedDate = reader.GetDateTime(reader.GetOrdinal("AssignedDate")),
                            RoleType = reader.GetString(reader.GetOrdinal("RoleName"))  // Changed from RoleID to RoleName
                        };
                        userDetailsList.Add(userDetails);
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
                // Close the connection
                dbConnection.CloseConnection();
            }
            return userDetailsList;
        }
        public List<UserDetails> UserDetails(string firstName = null)
        {
            List<UserDetails> userDetailsList = new List<UserDetails>();
            IDBConnection dbConnection = new DBConnection();

            try
            {
                string query = @"SELECT u.UserID ,c.FirstName, c.LastName, c.PhoneNumber, c.Address, u.AssignedDate, r.RoleName 
                         FROM Users u
                         JOIN Contact c ON u.ContactID = c.ContactID
                         JOIN Role r ON u.RoleID = r.RoleID";

                // If a filter is provided, adjust the query to include it
                if (!string.IsNullOrEmpty(firstName))
                {
                    query += " WHERE c.FirstName LIKE @FirstName";
                }

                using (SqlCommand command = new SqlCommand(query, dbConnection.OpenConnection()))
                {
                    // If a filter is provided, add the parameter
                    if (!string.IsNullOrEmpty(firstName))
                    {
                        command.Parameters.AddWithValue("@FirstName", "%" + firstName + "%");
                    }

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            UserDetails userDetails = new UserDetails
                            {
                                UserId = reader.GetInt32(reader.GetOrdinal("UserId")),
                                Firstname = reader.GetString(reader.GetOrdinal("FirstName")),
                                PhoneNumber = reader.GetString(reader.GetOrdinal("PhoneNumber")),
                                Address = reader.GetString(reader.GetOrdinal("Address")),  // Assign Address here
                                AssignedDate = reader.GetDateTime(reader.GetOrdinal("AssignedDate")),
                                RoleType = reader.GetString(reader.GetOrdinal("RoleName"))  // Changed from RoleID to RoleName
                            };

                            userDetailsList.Add(userDetails);
                        }
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
                // Close the connection
                dbConnection.CloseConnection();
            }
            //... rest remains the same
            return userDetailsList;

        }
        public List<Role> FetchRoles()
        {
            List<Role> rolesList = new List<Role>();

            try
            {
                dBConnection.OpenConnection();

                string query = "SELECT RoleID, RoleName FROM Role";
                using (SqlCommand command = new SqlCommand(query, dBConnection.Connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Role role = new Role
                            {
                                RoleID = reader.GetInt32(reader.GetOrdinal("RoleID")),
                                RoleName = reader.GetString(reader.GetOrdinal("RoleName"))
                            };
                            rolesList.Add(role);
                        }
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
                dBConnection.CloseConnection();
            }

            return rolesList;
        }
        public Users GetUserById(int userId)
        {
            try
            {
                dBConnection.OpenConnection();

                string query = @" SELECT  u.UserId, u.Username, u.PasswordHash, u.Salt, u.IsActive, u.AssignedDate, u.RoleAssignment, u.RoleId,
                                 c.ContactId, c.FirstName, c.LastName, c.PhoneNumber, c.Address
                                 FROM Users u
                                 INNER JOIN Contact c ON u.ContactId = c.ContactId
                                 WHERE u.UserId = @UserId";

                using (SqlCommand command = new SqlCommand(query, dBConnection.Connection))
                {
                    command.Parameters.AddWithValue("@UserId", userId);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Users user = new Users
                            {
                                UserId = Convert.ToInt32(reader["UserId"]),
                                Username = reader["Username"].ToString(),
                                PasswordHash = reader["PasswordHash"].ToString(),
                                Salt = reader["Salt"].ToString(),
                                IsActive = Convert.ToBoolean(reader["IsActive"]),
                                AssignedDate = Convert.ToDateTime(reader["AssignedDate"]),
                                RoleAssignment = Convert.ToDateTime(reader["RoleAssignment"]),
                                RoleId = Convert.ToInt32(reader["RoleId"]),

                                UserContact = new ContactInfo
                                {
                                    ContactId = Convert.ToInt32(reader["ContactId"]),
                                    FirstName = reader["FirstName"].ToString(),
                                    LastName = reader["LastName"].ToString(),
                                    PhoneNumber = reader["PhoneNumber"].ToString(),
                                    Address = reader["Address"].ToString()
                                }
                            };
                            return user;
                        }
                    }
                }

                return null; // User not found
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
                dBConnection.CloseConnection();
            }
        }

    }
}
