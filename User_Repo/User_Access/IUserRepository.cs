using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_Repo
{
    public interface IUserRepository
    {
        void CreateUser(User user);
        void DeleteUser(int userId);

        User LogUserIn(string enteredUsername, string enteredPassword);

        bool UpdateUserDetails(int userId, string newUsername, string newPasswordHash, string newSalt, int roleId, string newFirstName, string newLastName, string newPhoneNumber, string newAddress, bool isActive);


        // void UpdateUser(User user);

        //User GetUser(int userId);
    }
}
