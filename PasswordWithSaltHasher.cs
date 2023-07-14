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
        public string HashPassword(string password, string salt)
        {
            // Combine password and salt
            string passwordAndSalt = password + salt;

            // Create a SHA256 hash (you can also use SHA384 or SHA512)
            SHA256 sha256 = SHA256.Create();
            byte[] passwordAndSaltBytes = Encoding.UTF8.GetBytes(passwordAndSalt);
            byte[] hashBytes = sha256.ComputeHash(passwordAndSaltBytes);

            // Convert byte array to string
            string hashString = Convert.ToBase64String(hashBytes);

            return hashString;
        }

        public string GenerateSalt()
        {
            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
            byte[] saltBytes = new byte[32]; // 256 bits
            rng.GetBytes(saltBytes);

            string saltString = Convert.ToBase64String(saltBytes);

            return saltString;
        }
    }

}
