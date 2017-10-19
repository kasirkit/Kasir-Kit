using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Kasir_Kit
{
    public class Encryption
    {
        /* Class yang bertugas melakukan segala aktifitas pengenkripsian 
         * terutama pada password user yang akan di hash menggunakan
         * kriptografi
         * 
         * @author: Yusril Takeuchi 
         * */

        /// <summary>
        /// Melakukan enkripsi pada password user
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public string HashPassword(string input)
        {
            /*  Kriptografi
            byte[] data = System.Text.Encoding.ASCII.GetBytes(input);
            data = new System.Security.Cryptography.SHA256Managed().ComputeHash(data);
            string hash = System.Text.Encoding.ASCII.GetString(data); */

            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(input));
            byte[] result = md5.Hash;
            StringBuilder str = new StringBuilder();

            for(int i = 1; i < result.Length; i++)
            {
                str.Append(result[i].ToString("x2"));
            }

            return str.ToString();
        }
    }
}
