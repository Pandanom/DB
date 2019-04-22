using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace WindowsFormsTask1
{
   public static class PasswordChecker
    {
        static public bool Check(string passW,string mdPW)
        {
            string hash = "";
            using (MD5 md = MD5.Create())
            {
                hash = GetMd5Hash(md, passW);
                
            }
            mdPW = mdPW.Trim();
            if (mdPW ==  hash)
            {
                return true;
            }
            else
            {
                return false;
            }
         
        }
        
        static public string GetHash(string pw)
        {
            using (MD5 md = MD5.Create())
                return GetMd5Hash(md, pw);
        }

        static private string GetMd5Hash(MD5 md5Hash, string input)
        {

            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
            StringBuilder sBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            return sBuilder.ToString();
        }



    }
}
