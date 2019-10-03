using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace SecuritySystem
{
    class SecurityBase
    {
        private string pwd = null;

        public SecurityBase(string pwd)
        {
            this.pwd = pwd;
        }

        public static string Encrypt(string val)
        {
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                UTF8Encoding utf8 = new UTF8Encoding();
                byte[] data = md5.ComputeHash(utf8.GetBytes(val));
                return Convert.ToBase64String(data);
            }
        }

        public override string ToString()
        {
            return "Hashed Password: " + pwd;
        }
    }
}
