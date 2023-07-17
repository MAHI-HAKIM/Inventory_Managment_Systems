using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Managment_System
{
    public interface IHandleDbOperation
    {
        bool SuperAdminExists();
        bool AnyUserExists();
        bool UserExistsById(int userId);
        bool DoesUserExist(string username);
        //bool UserExists(string username);
    }
}
