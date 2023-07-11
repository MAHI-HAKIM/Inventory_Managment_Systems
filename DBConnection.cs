using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace Inventory_Managment_System
{
    class DBConnection
    {
        private SqlConnection connection;
        private const string ConnectionString = (@"Data Source=HP-ENVY-MAHI\MSSQLSERVER03;Initial Catalog=Inventory_MG;Integrated Security=True");

        public DBConnection()
        {
            connection = new SqlConnection(ConnectionString);
        }

        public SqlConnection OpenConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }

            return connection;
        }

        public bool TestConnection()
        {
            try
            {
                connection.Open();
                connection.Close();
                return true;
            }
            catch (SqlException)
            {
                return false;
            }
        }

        public SqlConnection CloseConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
            return connection;

        }
    }
}
