using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_Repo
{
    public class UserDetails
    {
        public int UserId { get; set; } // Auto-incremented by the database
        public string Firstname { get; set; } = "";
        public string LastName { get; set; } = "";
        public string PhoneNumber { get; set; } = "";
        public string Address { get; set; } = "";
        public DateTime AssignedDate { get; set; }
        public string RoleType { get; set; } = ""; // This will reference a role from the Role table
    }
}
