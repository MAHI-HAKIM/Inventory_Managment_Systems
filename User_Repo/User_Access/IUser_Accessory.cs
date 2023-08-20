using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using User_Repo.User_Repo;

namespace User_Repo.User_Access
{
    public interface IUser_Accessory
    {
        List<UserDetails> GetAllUserDetails();
        List<Role> FetchRoles();
    }
}
