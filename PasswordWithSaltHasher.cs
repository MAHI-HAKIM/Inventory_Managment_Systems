using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Inventory_Managment_System
{

    public class PasswordWithSaltHasher
    {
        public byte[] Salt { get; private set; }

        public PasswordWithSaltHasher()
        {
            new RNGCryptoServiceProvider().GetBytes(Salt = new byte[16]);
        }

        public byte[] Hash(string password)
        {
            var pbkdf2 = new Rfc2898DeriveBytes(password, Salt, 10000);
            byte[] hash = pbkdf2.GetBytes(20);

            byte[] hashBytes = new byte[36];
            Array.Copy(Salt, 0, hashBytes, 0, 16);
            Array.Copy(hash, 0, hashBytes, 16, 20);

            return hashBytes;
        }

        public bool Verify(byte[] savedPasswordHash, string passwordToCheck)
        {
            byte[] salt = new byte[16];
            Array.Copy(savedPasswordHash, 0, salt, 0, 16);

            var pbkdf2 = new Rfc2898DeriveBytes(passwordToCheck, salt, 10000);
            byte[] hash = pbkdf2.GetBytes(20);

            for (int i = 0; i < 20; i++)
            {
                if (savedPasswordHash[i + 16] != hash[i])
                    return false;
            }

            return true;
        }
    }

}
