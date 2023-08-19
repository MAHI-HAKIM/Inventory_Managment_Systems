using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_Repo
{
    public class User
    {
        public int UserId { get; set; } // Auto-incremented by the database
        public string Username { get; set; } = "";
        public string PasswordHash { get; set; } = "";
        public string Salt { get; set; } = "";
        public bool IsActive { get; set; }
        public DateTime AssignedDate { get; set; }
        public DateTime RoleAssignment { get; set; }
        public int RoleId { get; set; } // This will reference a role from the Role table
        public ContactInfo UserContact { get; set; } // Embedded Contact object

        //// Constructor
        //public User(string username, string passwordHash, string salt, bool isActive, DateTime assignedDate, int roleId, ContactInfo contact)
        //{
        //    Username = username;
        //    PasswordHash = passwordHash;
        //    Salt = salt;
        //    IsActive = isActive;
        //    AssignedDate = assignedDate;
        //    RoleId = roleId;
        //    UserContact = contact;
        //}
    }
}
