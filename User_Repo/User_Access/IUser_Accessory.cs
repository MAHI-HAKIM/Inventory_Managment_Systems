using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_Repo
{
    public interface IUser_Accessory
    {
        List<UserDetails> GetAllUserDetails();
        List<UserDetails> UserDetails(string firstName = null);

        List<Role> FetchRoles();
        Users GetUserById(int userId);
    }
}
