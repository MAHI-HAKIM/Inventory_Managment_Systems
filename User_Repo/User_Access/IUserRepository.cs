using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_Repo
{
    public interface IUserRepository
    {
        void CreateUser(Users user);
        void DeleteUser(int userId);
        Users LogUserIn(string enteredUsername, string enteredPassword);
        bool UpdateUserDetails(Users updatedUser);
    }
}
