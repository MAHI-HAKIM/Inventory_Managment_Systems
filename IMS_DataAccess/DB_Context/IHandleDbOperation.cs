using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS_DataAccess
{
    public interface IHandleDbOperation
    {
        bool SuperAdminExists();
        bool AdminExist();
        bool AnyUserExists();
        bool UserExistsById(int userId);
        bool DoesUserExist(string username);

        //bool UserExists(string username);
    }
}
