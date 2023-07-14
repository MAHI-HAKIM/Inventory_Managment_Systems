using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Inventory_Managment_System
{
    class HandleDbOperations
    {
        
         DBConnection dbConnection = new DBConnection();

        public bool IsAdminExists()
        {

            // Open a connection to the database
             dbConnection.OpenConnection();

            using (SqlCommand cmd = new SqlCommand("sp_CheckAdminExists", dbConnection.Connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                int adminCount = (int)cmd.ExecuteScalar();

                // Close the connection
                dbConnection.CloseConnection();

                return adminCount > 0;
            }
        }
    }
}

