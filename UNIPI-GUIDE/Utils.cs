using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace UNIPI_GUIDE
{
    internal class Utils
    {
        /**
        * Displays texts read from the database correctly.
        */
        public static string readMultilineFromDB(string retrieved)
        {
            return retrieved.Replace("\\n", "\n");
        }

        /**
         * Encrypts password with SHA1 to check against DB
         */
        public static string Hash(string password)
        {
            // compromised, but will do for test project
            using (SHA1Managed sha1 = new SHA1Managed())
            {
                var hash = sha1.ComputeHash(Encoding.UTF8.GetBytes(password));
                var hashStringBuilder = new StringBuilder(hash.Length * 2);
                foreach (byte b in hash) hashStringBuilder.Append(b.ToString("x2"));
                return hashStringBuilder.ToString();
            }
        }
    }
}
