using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS_DataAccess
{
    public interface IDBConnection
    {
        SqlConnection Connection { get; }
        SqlConnection OpenConnection();
        void CloseConnection();
    }
}
