using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace test_mysql.Cryptography
{
    public class Encryption
    {
        public string CalculateSHA256(string str)
        {
            SHA256 sha256 = SHA256.Create();
            byte[] passwordBytes = Encoding.UTF8.GetBytes(str);
            byte[] hashBytes = sha256.ComputeHash(passwordBytes);
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < hashBytes.Length; i++)
            {
                stringBuilder.Append(hashBytes[i].ToString("x2"));
            }

            return stringBuilder.ToString();
        }
    }
}
