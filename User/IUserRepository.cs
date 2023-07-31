using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Inventory_Managment_System
{
    public interface IUserRepository
    {
        void CreateUser(User user);
        void DeleteUser(int userId);
        User LogUserIn(string enteredUsername, string enteredPassword);

        //void UpdateUser(User user);
        //User GetUser(int userId);
    }
}
