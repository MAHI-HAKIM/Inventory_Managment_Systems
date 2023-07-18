using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace Inventory_Managment_System
{
    public class DBConnection : IDBConnection
    {
        private SqlConnection connection;
<<<<<<< Updated upstream:Validation_Folder/DBConnection.cs

        private const string ConnectionString = (@"Data Source=HP-ENVY-MAHI\MSSQLSERVER03;Initial Catalog=Inventory_MGS;Integrated Security=True");
=======
        private const string ConnectionString = (@"Data Source=C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA;Initial Catalog=Inventory_MG;Integrated Security=True");
>>>>>>> Stashed changes:DBConnection.cs

        public DBConnection()
        {
            connection = new SqlConnection(ConnectionString);
        }

        public SqlConnection Connection
        {
            get { return this.connection; }
        }

        //Opens the database connection if it is closed
        public SqlConnection OpenConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
            return connection;
        }
        // Closes the database connection if it is open
        public void CloseConnection()
        {
            if (Connection != null && connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }
}
