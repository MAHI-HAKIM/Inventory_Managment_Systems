using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using User_Repo.User_Repo;
using IMS_DataAccess;

namespace User_Repo.User_Access
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
    }
}
